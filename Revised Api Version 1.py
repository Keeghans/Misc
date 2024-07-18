import openai

class ChatGPTClient:
    """
    This class handles interactions with OpenAI's GPT-based system.
    
    Instructions:
    1. Initialize an object with an API key, and optionally a system message and a reply message.
    2. Use the `chat_with_gpt` method to get a reply from the GPT system based on a prompt.
    3. Use getter and setter methods to modify the API key, system message, or reply message.
    """
    
    def __init__(self, api_key, system_message="You are ChatGPT, a helpful assistant.", reply_message=""):
        """Constructor to initialize the ChatGPTClient object."""
        self.api_key = api_key
        self.system_message = system_message
        self.reply_message = reply_message

    # Getter and Setter methods for api_key
    def get_api_key(self):
        return self.api_key

    def set_api_key(self, api_key):
        self.api_key = api_key

    # Getter and Setter methods for system_message
    def get_system_message(self):
        return self.system_message

    def set_system_message(self, system_message):
        self.system_message = system_message

    # Getter and Setter methods for reply_message
    def get_reply_message(self):
        return self.reply_message

    def set_reply_message(self, reply_message):
        self.reply_message = reply_message

    def chat_with_gpt(self, prompt, max_tokens=300, temperature=0.7):
        # Interact with GPT and get a reply based on the prompt.
        try:
            # Set the API key for the openai package
            openai.api_key = self.api_key
            
            # Generate a message from GPT
            response = openai.Completion.create(
                engine="text-davinci-003",
                prompt=f"{self.system_message}\n{prompt}\n",
                max_tokens=max_tokens,
                temperature=temperature
            )
            
            # Store and return the reply message
            self.reply_message = response.choices[0].text.strip()
            return self.reply_message
            self.reply_message = ""

        except openai.error.RateLimitError:
            return "You've exceeded your rate limit. Please wait for some time before making another request."

        except openai.error.OpenAIError as e:
            return f"An error occurred: {e}"

if __name__ == '__main__':
    # Initialize client
    api_key = 'Key' # Insert Own Key Here
    client = ChatGPTClient(api_key)
    
    # Variable to hold conversation history
    conversation_history = []
    
    # Flag to control the exit of the outer loop
    should_exit = False 

    while not should_exit:  # Use flag to control loop exit
        # Choose between multi-line question and multi-line code
        choice = input("Is this a multi-line question or multi-line code? (Enter: question/q or code/c): ").lower()
        
        # Check for valid input
        if choice not in ['question', 'q', 'code', 'c']:
            print("Error: Please enter either 'question/q' or 'code/c'.")
            continue
        
        print("Please enter your input (Enter 'EOF' to submit):")
        lines = []
        while True:
            line = input()
            if line == 'EOF':
                break
            lines.append(line)
        
        new_prompt = '\n'.join(lines)
        
        # Add the appropriate prefix based on the type of input
        prefix = "You: " if choice in ['question', 'q'] else "Your Code:\n"
        
        # Add new prompt to conversation history
        conversation_history.append(f"{prefix}{new_prompt}")
        
        # If input is code, prompt for a specific question about the code
        if choice in ['code', 'c']:
            print("What is your question about this code? (Enter 'EOF' to submit):")
            code_lines = []
            while True:
                line = input()
                if line == 'EOF':
                    break
                code_lines.append(line)
            
            code_question = '\n'.join(code_lines)
            
            # Add the code question to the conversation history
            conversation_history.append(f"You: {code_question}")
            
            # Add code question to new prompt
            new_prompt += f"\n{code_question}"
        
        # Combine conversation history and new prompt
        full_prompt = '\n'.join(conversation_history)
        
        # Make GPT request
        response = client.chat_with_gpt(full_prompt)
        
        # Add GPT's reply to conversation history
        conversation_history.append(f"{response.strip()}")
        
        # Display GPT's reply
        print(response)
        
        # Loop for 'Do you want to continue?' question
        while True:
            cont = input("Do you want to continue? (yes/y or no/n): ").lower()  # Case-insensitive
            if cont in ['no', 'n']:
                print("\nConversation History:")
                print('\n'.join(conversation_history))
                should_exit = True  # Set flag to exit loop
                break  # Break the inner loop
            elif cont in ['yes', 'y']:
                break  # Break inner loop, continue with outer loop
            elif cont == '':
                print("Error: Input cannot be empty. Please enter 'yes/y' or 'no/n'.")
            else:
                print("Error: Please enter 'yes/y' or 'no/n'.")
