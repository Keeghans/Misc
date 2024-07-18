# Psudeo:
# 1. Define RetailItem with description, units in inv, and price
#   1.1 Initialize it


# Define the RetailItem class
class RetailItem:
    def __init__(self, description, units_in_inventory, price):
        self.description = description
        self.units_in_inventory = units_in_inventory
        self.price = price

# Psudeo:
# 2. Define class CashRegister with an empty list
#   2.1 Way to buy item, add item to list
#   2.2 Way to get total price, loop and give sum.
#   2.3 Way to show the items, print descriptions and prices
#   2.4 Way to clear the item list

# Define CashRegister class
class CashRegister:
    def __init__(self):
        self.items = []

    def purchase_item(self, item):
        self.items.append(item)

    def get_total(self):
        total_price = 0
        for item in self.items:
            total_price += item.price
        return total_price

    def show_items(self):
        for item in self.items:
            print(f"Item: {item.description}, Price: {item.price}")

    def clear(self):
        self.items = []

# Psudeo:
# 3. Create RetailItem objects for the jeans, jacket, and shirt, with the values for them included
jacket = RetailItem("Jacket", 12, 59.95)
jeans = RetailItem("Designer Jeans", 40, 34.95)
shirt = RetailItem("Shirt", 20, 24.95)

# Psudeo:
# 4. Create CashRegister object
register = CashRegister()

# Psudeo:
# 5. Loop to present menu options to the user
#    5.1 Display the options and prices
#    5.2 Get the user input
#    5.3 Make sure the given input works
#    5.4 Add the item that got selected to CashRegister
#    5.5 Option to clear the cart
#    5.6 Repeat or exit loop based on user choice

# Main loop for user interaction
while True:
    print("[1] Jacket ($59.95)")
    print("[2] Designer Jeans ($34.95)")
    print("[3] Shirt ($24.95)")
    print("[4] Checkout")
    print("[5] Clear Cart")
    try:
        selection = int(input("Make a selection: "))
        if selection not in [1, 2, 3, 4, 5]:
            raise ValueError("Invalid selection.")
    except ValueError as e:
        print(e)
        continue
    
    if selection == 1:
        register.purchase_item(jacket)
    elif selection == 2:
        register.purchase_item(jeans)
    elif selection == 3:
        register.purchase_item(shirt)
    elif selection == 4:
        break
    elif selection == 5:
        register.clear()
        print("Cart cleared.")
        
# Psudeo:
# 6. Display the items purchased and the total price
print("You purchased:")
register.show_items()
total_price = register.get_total()
print(f"Total: ${total_price}")

# Psudeo:
# 7. Clear the cash register
register.clear()
