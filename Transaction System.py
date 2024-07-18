from datetime import datetime

# ============ 1. Product Management ============

class ProductData:
    def __init__(self):
        self.products = {}

    def add_product(self, sku, description, price):
        self.products[sku] = {'description': description, 'price': price}

    def get_product_details(self, sku):
        return self.products.get(sku, None)

    def get_all_skus(self):
        return list(self.products.keys())

# ============ 2. Transaction Details ============

class TransactionDetails:
    def __init__(self):
        self.transactions = []

    def add_transaction_line(self, product_name, quantity, price):
        self.transactions.append({'product_name': product_name, 'quantity': quantity, 'price': price})

    def calculate_total(self):
        return sum(transaction['quantity'] * transaction['price'] for transaction in self.transactions)

    def generate_receipt(self, reward_account=None):
        receipt = 'Date & Time: {}\n'.format(datetime.now())
        receipt += 'Transaction Lines:\n'
        for transaction in self.transactions:
            receipt += '- {}, Quantity: {}, Price: ${}\n'.format(transaction['product_name'], transaction['quantity'], transaction['price'])
        receipt += 'Total: ${}\n'.format(self.calculate_total())
        if reward_account:
            receipt += 'Reward Account: {}\n'.format(reward_account)
        return receipt

# ============ 3. Customer Rewards ============

class CustomerReward:
    def __init__(self):
        """Initialize an empty reward account."""
        self.reward_account = None

    def set_reward_account(self, account):
        """Set the reward account to the given account."""
        self.reward_account = account

    def get_reward_account(self):
        """Retrieve the current reward account."""
        return self.reward_account

# ============ 4. User Input Handling ============

class UserInput:
    def get_sku(self):
        """Prompt the user for a product SKU and return it."""
        return input('Please enter the SKU of the product: ')

    def get_quantity(self):
        """Prompt the user for a product quantity and return it."""
        return int(input('Please enter the quantity of the product: '))

    def get_reward_account(self):
        """Ask the user if they have a reward account and return it if they do."""
        reward_account = input('Do you have a reward account? (Y/N): ')
        if reward_account.lower() == 'y':
            return input('Please enter your reward account: ')
        return None

    def get_payment_type(self):
        """Prompt the user for the payment type (Cash/Card) and return it."""
        return input('Please enter the payment type (Cash/Card): ')

    def get_payment_amount(self):
        """Prompt the user for the payment amount and return it."""
        return float(input('Please enter the payment amount: '))

# ============ 5. Transaction System & Recursive Logic ============

class RecursiveLooper:
    @staticmethod
    def loop_recursively(func, items):
        if not items:
            return
        item = items.pop(0)
        func(item)
        RecursiveLooper.loop_recursively(func, items)

class TransactionSystem:
    def __init__(self, product_data, user_input, customer_reward):
        self.product_data = product_data
        self.user_input = user_input
        self.customer_reward = customer_reward
        self.transaction_details = TransactionDetails()

    def process_product_transaction(self, sku):
        product = self.product_data.get_product_details(sku)
        if not product:
            return

        quantity = self.user_input.get_quantity()
        self.transaction_details.add_transaction_line(product['description'], quantity, product['price'])

    def process_transaction(self):
        skus = self.product_data.get_all_skus()
        RecursiveLooper.loop_recursively(self.process_product_transaction, skus)

        reward_account = self.user_input.get_reward_account()
        if reward_account:
            self.customer_reward.set_reward_account(reward_account)
        
        return self.transaction_details.generate_receipt(self.customer_reward.get_reward_account())

# ============ 6. Examples of Usage ============

class ExampleUsage:
    @staticmethod
    def product_data_example():
        """Demonstrates how to use the ProductData class."""
        product_data = ProductData()
        product_data.add_product("SKU123", "Product A", 10.00)
        product_details = product_data.get_product_details("SKU123")
        print("Using ProductData class:")
        print(f"Added product details: {product_details}")
        skus = product_data.get_all_skus()
        print(f"Available SKUs: {skus}\n")

    @staticmethod
    def transaction_details_example():
        """Demonstrates how to use the TransactionDetails class."""
        transaction = TransactionDetails()
        transaction.add_transaction_line("Product A", 2, 10.00)
        print("Using TransactionDetails class:")
        print(transaction.generate_receipt("Reward1234"), '\n')
        
    @staticmethod
    def transaction_system_example():
        """Demonstrates how to process a complete transaction using hardcoded data."""
        product_data = ProductData()
        product_data.add_product("SKU123", "Product A", 10.00)
        product_data.add_product("SKU456", "Product B", 20.00)
        product_data.add_product("SKU789", "Product C", 15.00)

        user_input = UserInput()  # Create an instance of UserInput
        customer_reward = CustomerReward()  # Create an instance of CustomerReward

        transaction_system = TransactionSystem(product_data, user_input, customer_reward)
        transaction_system.transaction_details.add_transaction_line("Product A", 2, 10.00)
        transaction_system.transaction_details.add_transaction_line("Product B", 1, 20.00)
        transaction_system.customer_reward.set_reward_account("Reward1234")

        print("Processing a sample transaction using TransactionSystem class:")
        receipt = transaction_system.transaction_details.generate_receipt(transaction_system.customer_reward.get_reward_account())
        print(receipt)

class MainSystem:
    product_data = ProductData()  # Initialize product_data as a class attribute

    @staticmethod
    def display_menu():
        print("==== Menu ====")
        print("1. See an example")
        print("2. Enter transaction details")
        print("3. Exit")

    @staticmethod
    def process_choice():
        choice = input("Enter your choice (1-3): ")

        if choice == "1":
            ExampleUsage.product_data_example()
            ExampleUsage.transaction_details_example()
            ExampleUsage.transaction_system_example()

        elif choice == "2":
            print("Enter product details:")
            skus = ["SKU123", "SKU456", "SKU789"]
            for sku in skus:
                quantity = int(input(f"Enter the quantity for SKU {sku}: "))
                product = MainSystem.product_data.get_product_details(sku)  # Access product_data from the class attribute
                if product:
                    TransactionSystem.transaction_details.add_transaction_line(product['description'], quantity, product['price'])
                else:
                    print(f"Product with SKU {sku} not found.")

            reward_account = UserInput.get_reward_account()
            if reward_account:
                TransactionSystem.customer_reward.set_reward_account(reward_account)

            receipt = TransactionSystem.transaction_details.generate_receipt(
                TransactionSystem.customer_reward.get_reward_account()
            )
            print("Transaction processed successfully!")
            print(receipt)

        elif choice == "3":
            print("Exiting the program.")
            return

        else:
            print("Invalid choice. Please try again.")

        MainSystem.process_choice()

    @staticmethod
    def execute():
        user_input = UserInput()
        customer_reward = CustomerReward()
        transaction_system = TransactionSystem(MainSystem.product_data, user_input, customer_reward)

        MainSystem.display_menu()
        MainSystem.process_choice()

if __name__ == "__main__":
    MainSystem.execute()
