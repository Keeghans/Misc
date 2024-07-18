# =================== 1. Imports ===================
import tkinter as tk
from tkinter import font
import sqlite3
import logging
from logging.handlers import RotatingFileHandler
import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from nltk.corpus import stopwords
import string
import datetime
from gpt_client import ChatGPTClient

# =================== 2. Configuration and Initialization ===================

try:
    nltk.data.find('tokenizers/punkt')
except LookupError:
    nltk.download('punkt')

logging.basicConfig(
    level=logging.INFO,
    format='%(asctime)s - %(levelname)s - %(message)s',
    handlers=[RotatingFileHandler('app.log', maxBytes=10000, backupCount=5)]
)

MAX_FOLLOW_UPS = 5
is_dark_mode = False

def is_response_similar(new_response, previous_responses):
    new_tokens = word_tokenize(new_response.lower())
    new_words = set(word for word in new_tokens if word not in stopwords.words('english') and word not in string.punctuation)
    for response in previous_responses:
        response_tokens = word_tokenize(response.lower())
        response_words = set(word for word in response_tokens if word not in stopwords.words('english') and word not in string.punctuation)
        similarity = len(new_words.intersection(response_words)) / len(new_words.union(response_words))
        if similarity > 0.7:  # Adjusted for readability
            return True
    return False

# =================== 3. Database Management Functions ===================

def create_conversation_table():
    with sqlite3.connect('conversation.db') as conn:
        cursor = conn.cursor()
        cursor.execute('''
            CREATE TABLE IF NOT EXISTS ConversationEntries (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                conversation_id INTEGER NOT NULL,
                content TEXT NOT NULL,
                entry_type TEXT NOT NULL,
                timestamp DATETIME NOT NULL
            )
        ''')
        conn.commit()

conversation_ids = []

def get_max_conversation_id():
    return max(conversation_ids, default=0)

def generate_new_conversation_id():
    new_id = get_max_conversation_id() + 1
    conversation_ids.append(new_id)
    return new_id

def store_conversation_entry(conversation_id, content, entry_type):
    timestamp = datetime.datetime.now()
    with sqlite3.connect('conversation.db') as conn:
        cursor = conn.cursor()
        cursor.execute('''
            INSERT INTO ConversationEntries (conversation_id, content, entry_type, timestamp)
            VALUES (?, ?, ?, ?)
        ''', (conversation_id, content, entry_type, timestamp))
        logging.info(f"Entry Type: {entry_type}, Content: {content}")

def parse_and_store_list(response, topic):
    list_items = [item.strip() for item in response.split('\n') if item.strip()]
    for item in list_items:
        store_conversation_entry(topic, item, 'query')

# =================== 4. GPT Interaction Functions ===================

def generate_follow_up_questions(response):
    sentences = sent_tokenize(response)
    return [f"Can you elaborate on '{sentence}'?" for sentence in sentences if len(sentence.split()) > 5]

def display_response(response_text, text, response_type):
    response_text.config(state=tk.NORMAL)
    response_text.insert(tk.END, text, response_type)
    response_text.tag_config(response_type, foreground=response_colors.get(response_type, 'black'))
    response_text.see(tk.END)
    response_text.config(state=tk.DISABLED)

def summarize_data_with_gpt(data, gpt_client):
    chunk_size = 150
    chunks = [data[i:i + chunk_size] for i in range(0, len(data), chunk_size)]

    summarized_reports = []
    for chunk in chunks:
        prompt = f"Collate and summarize the following data without repeating information: {chunk}"
        response = fetch_gpt_response(None, prompt, gpt_client)
        summarized_reports.append(response)
        
    final_summary = " ".join(summarized_reports)
    return final_summary

def summarize_responses(responses):
    combined_text = " ".join(responses)
    summarized_text = summarize_data_with_gpt(combined_text, gpt_client) 
    return summarized_text

def handle_follow_ups(conversation_id, initial_response, response_text, follow_up_var, follow_up_entry, gpt_client):
    previous_responses = [initial_response]
    max_follow_ups = min(int(follow_up_entry.get()), MAX_FOLLOW_UPS) if follow_up_var.get() else 0

    summarized_follow_ups = []

    for _ in range(max_follow_ups):
        follow_up_questions = generate_follow_up_questions(previous_responses[-1])
        for question in follow_up_questions:
            follow_up_response = fetch_gpt_response(conversation_id, question, gpt_client)
            if not is_response_similar(follow_up_response, previous_responses):
                display_response(response_text, f"Asking: {question}\n", 'follow_up')
                display_response(response_text, f"GPT: {follow_up_response}\n", 'gpt_response')
                previous_responses.append(follow_up_response)
                store_conversation_entry(conversation_id, follow_up_response, 'response')
                summarized_follow_up = summarize_responses([follow_up_response]) 

                if summarized_follow_up not in summarized_follow_ups:
                    summarized_follow_ups.append(summarized_follow_up)
                break
    if summarized_follow_ups:
        summarized_follow_up_text = "\n".join(f"GPT Summary: {summary}\n" for summary in summarized_follow_ups)
        display_response(response_text, summarized_follow_up_text, 'gpt_response')



def read_api_key():
    try:
        with open("api_key.txt", "r") as file:
            return file.read().strip()
    except FileNotFoundError:
        logging.error("api_key.txt file not found. Please create the file and add your API key.")
        exit(1)

def fetch_gpt_response(conversation_id, prompt, gpt_client):
    prompt_with_instruction = f"Be detailed in your response to my following question: {prompt}"
    gpt_response = gpt_client.chat(prompt_with_instruction)   
    gpt_response = gpt_client.chat(prompt)
    logging.info(f"Prompt: {prompt}, Response: {gpt_response}")
    if conversation_id is None:
        conversation_id = generate_new_conversation_id()
    store_conversation_entry(conversation_id, gpt_response, 'response')
    return gpt_response

# =================== 5. UI Color Schemes and Setup Functions ===================

nltk.download('punkt')
nltk.download('stopwords')

light_mode = {
    "background": "white", "foreground": "black",
    "button": "SystemButtonFace", "text": "black", "entry": "white",
}

dark_mode = {
    "background": "#121212", "foreground": "white",
    "button": "#333333", "text": "white", "entry": "#1E1E1E",
}

response_colors = {
    'user_prompt': 'blue', 'gpt_response': 'green', 'follow_up': 'orange',
}

def setup_ui(gpt_client):
    root = tk.Tk()
    root.title("GPT Interface")
    root.geometry("800x600")

    custom_font = font.Font(family="Helvetica", size=12)
    frame = tk.Frame(root, bg="#1a1a1a")
    frame.pack(padx=10, pady=10, fill="both", expand=True)

    spinner_frame, follow_up_entry, increment_button, decrement_button = setup_spinner(frame, custom_font)
    follow_up_var = setup_follow_up_check(frame, custom_font, spinner_frame)
    spinner_frame.pack_forget()

    prompt_entry = setup_prompt_widgets(frame, custom_font)
    response_text = setup_response_text_widget(frame, custom_font)
    submit_button = setup_submit_button(frame, custom_font, prompt_entry, response_text, follow_up_var, follow_up_entry, gpt_client)

    global all_widgets
    all_widgets = [root, frame, spinner_frame, increment_button, decrement_button, prompt_entry, response_text, submit_button]

    return root

def setup_spinner(frame, custom_font):
    spinner_frame = tk.Frame(frame, bg="#262626")
    follow_up_entry = tk.Entry(spinner_frame, font=custom_font, width=5)
    follow_up_entry.insert(1, "1")
    follow_up_entry.pack(side=tk.LEFT)

    increment_button = tk.Button(spinner_frame, text="▲", font=custom_font, 
                                 command=lambda: increment_follow_ups(follow_up_entry))
    increment_button.pack(side=tk.LEFT)

    decrement_button = tk.Button(spinner_frame, text="▼", font=custom_font, 
                                 command=lambda: decrement_follow_ups(follow_up_entry))
    decrement_button.pack(side=tk.LEFT)

    return spinner_frame, follow_up_entry, increment_button, decrement_button

def toggle_spinner_visibility(follow_up_var, spinner_frame):
    if follow_up_var.get():
        spinner_frame.pack(side=tk.LEFT)
    else:
        spinner_frame.pack_forget()

def setup_follow_up_check(frame, custom_font, spinner_frame):
    follow_up_var = tk.IntVar()
    follow_up_check = tk.Checkbutton(
        frame, text="Enable follow-up questions",
        variable=follow_up_var, font=custom_font,
        bg="#262626",
        command=lambda: toggle_spinner_visibility(follow_up_var, spinner_frame)
    )
    follow_up_check.pack()
    return follow_up_var

def setup_response_text_widget(frame, custom_font):
    response_text = tk.Text(frame, wrap=tk.WORD, height=15, bd=2, relief=tk.SUNKEN)
    response_text.pack(padx=10, pady=10, side=tk.TOP, fill=tk.BOTH, expand=True)
    response_text.config(state=tk.DISABLED)

    response_text.tag_configure('user_prompt', font=('Helvetica', 12, 'bold'), foreground="blue")
    response_text.tag_configure('gpt_response', font=('Helvetica', 12), foreground="black")
    response_text.tag_configure('follow_up', font=('Helvetica', 12, 'italic'), foreground="green")

    scrollbar = tk.Scrollbar(frame, command=response_text.yview)
    scrollbar.pack(side=tk.RIGHT, fill=tk.Y)
    response_text['yscrollcommand'] = scrollbar.set

    return response_text

def setup_submit_button(frame, custom_font, prompt_entry, response_text, follow_up_var, follow_up_entry, gpt_client):
    submit_button = tk.Button(
        frame, text="Submit", bg='#0d47a1', fg='#ffffff', relief='raised', borderwidth=0,
        command=lambda: submit_prompt(prompt_entry, response_text, follow_up_var, follow_up_entry, submit_button, gpt_client), 
        font=custom_font
    )
    submit_button.pack(pady=10)
    return submit_button

# =================== 6. Main Execution and Additional Functions ===================

def submit_prompt(prompt_entry, response_text, follow_up_var, follow_up_entry, submit_button, gpt_client):
    user_query = prompt_entry.get().strip()
    if not user_query:
        logging.warning("Empty prompt submitted.")
        display_response(response_text, "Please enter a valid query.\n", 'error')
        return

    # Generate a new conversation_id
    conversation_id = generate_new_conversation_id()

    # Store user's query in the database
    store_conversation_entry(conversation_id, user_query, 'query')

    # Fetch and display GPT response
    gpt_response = fetch_gpt_response(conversation_id, user_query, gpt_client)
    display_response(response_text, "GPT: " + gpt_response + "\n", 'gpt_response')

    # Get the final summary
    final_summary = summarize_data_with_gpt(gpt_response, gpt_client)
    display_response(response_text, "GPT Summary: " + final_summary + "\n", 'gpt_response')

    if follow_up_var.get() == 1:
        handle_follow_ups(conversation_id, gpt_response, response_text, follow_up_var, follow_up_entry, gpt_client)

    prompt_entry.delete(0, tk.END)  # Clear the prompt entry after submission



def setup_prompt_widgets(frame, custom_font):
    prompt_label = tk.Label(frame, text="Enter your prompt:", font=custom_font, bg="#0d47a1")
    prompt_label.pack(pady=(0, 10))

    prompt_entry = tk.Entry(frame, font=custom_font)
    prompt_entry.pack(pady=(0, 10), fill="x", expand=True)
    return prompt_entry

def get_conversation_data():
    with sqlite3.connect('conversation.db') as conn:
        cursor = conn.cursor()
        cursor.execute('SELECT content, entry_type FROM ConversationEntries')
        return cursor.fetchall()

def extract_subject_headers(data):
    return [entry[0] for entry in data if entry[1] == 'query']

def get_past_conversations():
    with sqlite3.connect('conversation.db') as conn:
        cursor = conn.cursor()
        cursor.execute("SELECT prompt, response, level FROM Conversations ORDER BY id ASC")
        return cursor.fetchall()

def populate_chat_with_past_conversations(response_text):
    for prompt, response, level in get_past_conversations():
        display_type = 'user_prompt' if level == 1 else 'follow_up'
        display_response(response_text, f"You: {prompt}\n", display_type)
        display_response(response_text, f"GPT: {response}\n", 'gpt_response')

def increment_follow_ups(entry_widget):
    current_value = min(int(entry_widget.get()), MAX_FOLLOW_UPS - 1)
    entry_widget.delete(0, tk.END)
    entry_widget.insert(0, str(current_value + 1))

def decrement_follow_ups(entry_widget):
    current_value = max(int(entry_widget.get()), 1)
    entry_widget.delete(0, tk.END)
    entry_widget.insert(0, str(current_value - 1))

def toggle_dark_mode(root):
    global is_dark_mode
    is_dark_mode = not is_dark_mode
    apply_ui_color_scheme(root)

def apply_ui_color_scheme(root):
    mode = dark_mode if is_dark_mode else light_mode
    user_prompt_color = "white" if is_dark_mode else "blue"
    for widget in all_widgets:
        bg, fg = mode["background"], mode["foreground"]
        configure_widget(widget, bg, fg, user_prompt_color)

def configure_widget(widget, bg, fg, user_prompt_color):
    widget_type = type(widget)
    if widget_type in (tk.Entry, tk.Text):
        widget.config(bg=bg, fg=fg, insertbackground=fg)
        if widget_type == tk.Text:
            widget.tag_configure('user_prompt', font=('Helvetica', 12, 'bold'), foreground=user_prompt_color)
            widget.tag_configure('gpt_response', foreground=fg)
            widget.tag_configure('follow_up', font=('Helvetica', 12, 'italic'), foreground="green")
    elif widget_type == tk.Label:
        widget.config(bg=bg, fg=fg)
    elif widget_type in (tk.Button, tk.Checkbutton):
        widget.config(bg=bg, fg=fg)

if __name__ == "__main__":
    create_conversation_table()
    gpt_client = ChatGPTClient(api_key=read_api_key())
    root = setup_ui(gpt_client)
    root.mainloop()
