import openai

class ChatGPTClient:
    def __init__(self, api_key, system_message="You are ChatGPT, a helpful assistant.", reply_message=""):
        self.api_key = api_key
        self.system_message = system_message
        self.reply_message = reply_message

    def get_api_key(self):
        return self.api_key

    def set_api_key(self, api_key):
        self.api_key = api_key

    def get_system_message(self):
        return self.system_message

    def set_system_message(self, system_message):
        self.system_message = system_message

    def get_reply_message(self):
        return self.reply_message

    def set_reply_message(self, reply_message):
        self.reply_message = reply_message

    def chat_with_gpt(self, prompt, max_tokens=300, temperature=0.7):
        try:
            openai.api_key = self.api_key

            response = openai.Completion.create(
                engine="text-davinci-003",
                prompt=f"{self.system_message}\n{prompt}\n",
                max_tokens=max_tokens,
                temperature=temperature
            )

            self.reply_message = response.choices[0].text
            return self.reply_message

        except openai.error.RateLimitError:
            return "You've exceeded your rate limit. Please wait for some time before making another request."

        except openai.error.OpenAIError as e:
            return f"An error occurred: {e}"

# Initialize client
api_key = ' Key '  # Replace with your actual OpenAI API key
client = ChatGPTClient(api_key)
client.set_system_message("You are ChatGPT, a helpful assistant.")

while True:
    prompt = input("Please enter your question or type 'stop' to exit: ")
    
    if prompt.lower() == 'stop':
        print("Session ended.")
        break
    
    response = client.chat_with_gpt(prompt)
    print("ChatGPT Reply:", response)
