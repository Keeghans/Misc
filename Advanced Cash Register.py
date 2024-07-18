"""
==============================================================
          Customer Transaction Management System
==============================================================

1. Introduction
---------------
I've developed a Python-based system for managing customer transactions and inventory. The goal is to handle product listings, customer information, reward programs, service contracts, and ensure that transaction processing includes accurate receipts.

2. Code Structure
-----------------
- **Class Definitions**: Defines entities such as products, customers, and transactions.
- **Helper Functions**: Functions that ensure accurate and valid user input.
- **User Interaction Functions**: Functions that handle different user operations, from adding customers to processing transactions.

3. Class Descriptions
---------------------
- **Product Class**: Describes a basic product in the inventory. The class has been augmented with warranty functionalities.
- **ServiceContract Class**: A subclass of Product, it represents a product with associated service contracts. If the end date of the contract is before the start date, an error will be raised.
- **Customer Class**: Represents a customer with basic attributes.
- **RewardCustomer Class**: An extension of the Customer class, it caters to customers within a reward program, maintaining their reward points and levels.
- **Transaction Class**: Represents a transaction, maintaining details about purchased products and transaction dates.

4. Helper Functions
-------------------
- `is_valid_email()`: Validates email structure.
- `input_integer()`: Ensures inputted integers are valid and optionally checks if they lie within a specified range.
- `input_float()`: Validates positive floating-point number inputs.
- `input_date()`: Validates the date input and ensures it's not set in the future.

5. User Interaction Functions
-----------------------------
- `add_customer()`: Registers a new customer, either of standard type or a reward customer.
- `add_product()`: Adds a new product, be it a regular one or a service contract.
- `display_customers()` & `display_products()`: Display lists of existing customers and products.
- `run_transaction()`: Takes the user through the transaction process, concluding with a receipt.
- `modify_customer()`: Updates existing customer details.
- `remove_customer()`: Deletes a customer from the system.
- `modify_product()`: Updates product details.
- `remove_product()`: Removes a product from the inventory.

6. Main Program Loop
--------------------
The main loop provides an interactive menu, guiding the user to perform different operations. This loop continues until the user chooses to exit the program.

7. Conclusion
-------------
The Customer Transaction and Inventory Management System, as presented here, provides a structured way to simulate basic business operations using object-oriented programming concepts. I aimed for clarity, efficiency, and user-friendliness in the design.

==============================================================
"""
import datetime
import re

# Class Definitions

class Product:
    """Represents a basic product in the inventory with essential attributes."""
    
    def __init__(self, product_id, product_name, price, quantity_in_stock):
        """Constructor to initialize a product with its details."""
        self._product_id = product_id
        self._product_name = product_name
        self._price = price
        self._quantity_in_stock = quantity_in_stock

    # Getter methods for product attributes
    def get_product_id(self):
        return self._product_id

    def get_product_name(self):
        return self._product_name

    def get_price(self):
        return self._price

    def get_quantity_in_stock(self):
        return self._quantity_in_stock

    # Setter methods to update product attributes
    def set_price(self, price):
        self._price = price

    def set_quantity_in_stock(self, quantity):
        self._quantity_in_stock = quantity

    # Method to reduce product stock by a given quantity
    def reduce_stock(self, quantity):
        if self._quantity_in_stock >= quantity:
            self._quantity_in_stock -= quantity
            return True
        else:
            return False

    # Getter and Setter methods for product warranty
    def set_warranty(self, warranty):
        self._warranty = warranty

    def get_warranty(self):
        return self._warranty

class ServiceContract(Product):
    """Represents a service contract which is a type of product with additional attributes related to contract dates."""
    
    def __init__(self, product_id, product_name, price, quantity_in_stock, contract_start_date, contract_end_date):
        super().__init__(product_id, product_name, price, quantity_in_stock)
        if contract_end_date <= contract_start_date:
            raise ValueError("Contract end date should be after the start date.")
        self._contract_start_date = contract_start_date
        self._contract_end_date = contract_end_date

    # Getter and Setter methods for contract dates
    def get_contract_start_date(self):
        return self._contract_start_date

    def get_contract_end_date(self):
        return self._contract_end_date

    def set_contract_start_date(self, date):
        self._contract_start_date = date

    def set_contract_end_date(self, date):
        self._contract_end_date = date

class Customer:
    """Represents a basic customer with essential details like ID, name, and email."""
    
    def __init__(self, customer_id, customer_name, email):
        self._customer_id = customer_id
        self._customer_name = customer_name
        self._email = email

    # Getter methods for customer attributes
    def get_customer_id(self):
        return self._customer_id

    def get_customer_name(self):
        return self._customer_name

    def get_email(self):
        return self._email

    # Setter method to update customer email
    def set_email(self, email):
        self._email = email

class RewardCustomer(Customer):
    """Represents a reward customer, which is a type of customer with additional attributes related to rewards."""
    
    def __init__(self, customer_id, customer_name, email, reward_points=0, reward_level="Silver"):
        super().__init__(customer_id, customer_name, email)
        self._reward_points = reward_points
        self._reward_level = reward_level

    # Getter methods for reward attributes
    def get_reward_points(self):
        return self._reward_points

    def get_reward_level(self):
        return self._reward_level

    # Setter methods to update reward attributes
    def set_reward_points(self, points):
        self._reward_points = points

    def set_reward_level(self, level):
        self._reward_level = level

    # Method to earn reward points and possibly upgrade the reward level based on earned points
    def earn_reward_points(self, points_earned):
        self._reward_points += points_earned
        self.upgrade_reward_level()

    def upgrade_reward_level(self):
        LEVELS = {"Silver": 0, "Gold": 1000}
        for level, threshold in reversed(sorted(LEVELS.items(), key=lambda x: x[1])):
            if self._reward_points >= threshold:
                self._reward_level = level
                break

class Transaction:
    """Represents a transaction where a customer purchases products."""
    
    def __init__(self, transaction_id, customer_id, transaction_date):
        self._transaction_id = transaction_id
        self._customer_id = customer_id
        self._products_purchased = []
        self._transaction_date = transaction_date

    # Getter methods for transaction attributes
    def get_transaction_id(self):
        return self._transaction_id

    def get_customer_id(self):
        return self._customer_id

    def get_products_purchased(self):
        return self._products_purchased

    def get_transaction_date(self):
        return self._transaction_date

    # Method to add products to the transaction
    def add_product_to_transaction(self, product, quantity):
        for idx, (prod, qty) in enumerate(self._products_purchased):
            if prod.get_product_id() == product.get_product_id():
                self._products_purchased[idx] = (prod, qty + quantity)
                return
        self._products_purchased.append((product, quantity))

# Helper functions for input validation
def is_valid_email(email):
    """Checks if a given email is in valid format."""
    email_regex = r"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)"
    return re.match(email_regex, email) is not None

def input_integer(prompt, min_val=None, max_val=None):
    """Inputs an integer from user with optional range restrictions."""
    while True:
        try:
            value = int(input(prompt))
            if (min_val is not None and value < min_val) or (max_val is not None and value > max_val):
                print(f"Please enter a value between {min_val} and {max_val}.")
                continue
            return value
        except ValueError:
            print("Please enter a valid integer!")

def input_float(prompt):
    """Inputs a non-negative float from user."""
    while True:
        try:
            value = float(input(prompt))
            if value < 0:  # Ensure non-negative values
                print("Error: Value cannot be negative!")
                continue
            return value
        except ValueError:
            print("Please enter a valid number!")

def input_date(prompt):
    """Inputs a date from user in 'yyyy-mm-dd' format."""
    while True:
        date_str = input(prompt)
        try:
            date_obj = datetime.datetime.strptime(date_str, '%Y-%m-%d').date()
            if date_obj > datetime.date.today():
                print("Error: Future dates are not allowed!")
                continue
            return date_obj
        except ValueError:
            print("Invalid date format! Expected format: yyyy-mm-dd.")

# Initialization of lists to store system data
customers = []
products = []
transactions = []

# User Interaction Functions

def add_customer():
    """Function to add a new customer to the system, either regular or reward type."""
    customer_id = input("Enter customer ID: ")

    # Check if customer ID already exists
    if any(c.get_customer_id() == customer_id for c in customers):
        print("Error: Customer ID already exists!")
        return

    customer_name = input("Enter customer name: ")

    # Validate email format
    email = input("Enter customer email: ")
    if not is_valid_email(email):
        print("Error: Invalid email format!")
        return

    # Determine if the customer is a reward customer
    reward_choice = input("Is this a reward customer? (yes/no): ").lower()
    if reward_choice == 'yes':
        customer = RewardCustomer(customer_id, customer_name, email)
    else:
        customer = Customer(customer_id, customer_name, email)
    customers.append(customer)
    print(f"Customer {customer_name} added successfully!")

def handle_warranty(product):
    """Helper function to set warranty details for a product."""
    while True:
        warranty = input("Enter warranty details for the product (or 'None' if not available): ")
        if len(warranty) > 200:
            print("Error: Warranty details too long!")
            continue
        if warranty.lower() == 'none':
            warranty = None
        product.set_warranty(warranty)
        break

def add_product():
    """Function to add a new product to the system. This could be a regular product or a service contract."""
    product_id = input("Enter product ID: ")

    # Check if product ID already exists
    if any(p.get_product_id() == product_id for p in products):
        print("Error: Product ID already exists!")
        return

    product_name = input("Enter product name: ")
    price = input_float("Enter product price: ")
    quantity_in_stock = input_integer("Enter product stock quantity: ")

    # Determine if the product is a service contract
    product_type = input("Is this a service contract product? (yes/no): ").lower()
    if product_type == 'yes':
        contract_start_date = input_date("Enter contract start date (yyyy-mm-dd): ")
        contract_end_date = input_date("Enter contract end date (yyyy-mm-dd): ")
        if contract_end_date <= contract_start_date:
            print("Error: Contract end date should be after the start date.")
            return
        product = ServiceContract(product_id, product_name, price, quantity_in_stock, contract_start_date, contract_end_date)
    else:
        product = Product(product_id, product_name, price, quantity_in_stock)
        handle_warranty(product)  # Add warranty if it's a regular product

    products.append(product)
    print(f"Product {product_name} added successfully!")

def display_customers():
    """Displays the details of all customers in the system."""
    for customer in customers:
        print(f"ID: {customer.get_customer_id()}, Name: {customer.get_customer_name()}, Email: {customer.get_email()}")

def display_products():
    """Displays the details of all products in the system."""
    for product in products:
        print(f"ID: {product.get_product_id()}, Name: {product.get_product_name()}, Price: {product.get_price()}, Stock: {product.get_quantity_in_stock()}")

def run_transaction():
    """Function to conduct a new transaction. The process involves selecting a customer, 
    choosing products, and finalizing the transaction with a receipt."""
    transaction_id = input("Enter transaction ID: ")
    display_customers()
    
    # Selecting the customer
    while True:
        customer_id = input("Select a customer ID for the transaction: ")
        customer = next((c for c in customers if c.get_customer_id() == customer_id), None)
        if customer:
            break
        else:
            print("Invalid customer ID! Please try again.")

    transaction_date = input_date("Enter transaction date (yyyy-mm-dd): ")
    transaction = Transaction(transaction_id, customer_id, transaction_date)

    while True:
        display_products()
        product_id = input("Enter product ID to add to transaction or 'done' to finish: ")

        if product_id.lower() == 'done':
            break

        selected_product = next((p for p in products if p.get_product_id() == product_id), None)
        if not selected_product:
            print("Product not found!")
            continue

        # Check for stock and add warranty
        quantity = input_integer("Enter quantity: ")
        if not selected_product.reduce_stock(quantity):
            print("Not enough stock for this product!")
            continue
        warranty_choice = input("Would you like to add a warranty to this product? (yes/no): ").lower()
        if warranty_choice == 'yes':
            warranty_details = input("Enter warranty details: ")
            selected_product.set_warranty(warranty_details)

        transaction.add_product_to_transaction(selected_product, quantity)

    reward_program = input("Does the customer want to join the reward program? (yes/no): ").lower()
    if reward_program == 'yes':
        for customer in customers:
            if customer.get_customer_id() == customer_id and isinstance(customer, RewardCustomer):
                points = input_integer("Enter reward points earned in this transaction: ")
                customer.earn_reward_points(points)
                break

    transactions.append(transaction)

    print("\n----- Receipt -----")
    total_cost = 0
    for product, qty in transaction.get_products_purchased():
        product_total = product.get_price() * qty
        print(f"{product.get_product_name()} (x{qty}): ${product_total:.2f}")
        total_cost += product_total
    print(f"Total: ${total_cost:.2f}")

def modify_customer():
    """Allows the user to modify the details of an existing customer."""
    display_customers()
    customer_id = input("Enter the customer ID you want to modify: ")
    customer = next((c for c in customers if c.get_customer_id() == customer_id), None)

    if not customer:
        print("Customer not found!")
        return

    # Menu to select which attribute to modify
    print("1. Modify Name")
    print("2. Modify Email")
    choice = input_integer("Select attribute to modify: ", 1, 2)

    if choice == 1:
        new_name = input("Enter new name: ")
        customer._customer_name = new_name
    elif choice == 2:
        new_email = input("Enter new email: ")
        if is_valid_email(new_email):
            customer._email = new_email
        else:
            print("Invalid email format!")

def remove_customer():
    """Allows the user to remove a customer from the system."""
    display_customers()
    customer_id = input("Enter the customer ID you want to remove: ")

    global customers  # Declare customers as global to modify it
    customers = [c for c in customers if c.get_customer_id() != customer_id]
    print("Customer removed!")

def modify_product():
    """Allows the user to modify the details of an existing product."""
    display_products()
    product_id = input("Enter the product ID you want to modify: ")
    product = next((p for p in products if p.get_product_id() == product_id), None)

    if not product:
        print("Product not found!")
        return

    # Menu to select which attribute to modify
    print("1. Modify Name")
    print("2. Modify Price")
    print("3. Modify Stock Quantity")
    choice = input_integer("Select attribute to modify: ", 1, 3)

    if choice == 1:
        new_name = input("Enter new name: ")
        product._product_name = new_name
    elif choice == 2:
        new_price = input_float("Enter new price: ")
        product._price = new_price
    elif choice == 3:
        new_stock = input_integer("Enter new stock quantity: ")
        product._quantity_in_stock = new_stock

def remove_product():
    """Allows the user to remove a product from the system."""
    display_products()
    product_id = input("Enter the product ID you want to remove: ")

    global products  # Declare products as global to modify it
    products = [p for p in products if p.get_product_id() != product_id]
    print("Product removed!")

def main():
    """Main program loop that provides an interactive menu for users. 
    The loop continues until the user chooses to exit."""
    while True:
        print("\nOptions:")
        print("1. Add a new customer")
        print("2. Add a new product")
        print("3. Display customer details")
        print("4. Display product details")
        print("5. Run a transaction")
        print("6. Modify a customer")
        print("7. Remove a customer")
        print("8. Modify a product")
        print("9. Remove a product")
        print("10. Exit")

        choice = input_integer("Enter your choice: ")

        # Handling user choices based on the menu
        if choice == 1:
            add_customer()
        elif choice == 2:
            add_product()
        elif choice == 3:
            display_customers()
        elif choice == 4:
            display_products()
        elif choice == 5:
            run_transaction()
        elif choice == 6:
            modify_customer()
        elif choice == 7:
            remove_customer()
        elif choice == 8:
            modify_product()
        elif choice == 9:
            remove_product()
        elif choice == 10:
            break
        else:
            print("Invalid choice! Please enter again.")

if __name__ == "__main__":
    main()
