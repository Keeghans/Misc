import tkinter as tk
from tkinter import messagebox

# ============ 1. Form Management ============
class FormManager:
    def __init__(self, window):
        """Initialize form elements."""
        self.window = window

    def submit(self):
        """Submit form and display a message."""
        messagebox.showinfo("Submission", "Form Submitted!")

    def create_label(self, text):
        """Create a label with given text."""
        label = tk.Label(self.window, text=text)
        label.pack()
        return label

    def create_entry(self):
        """Create a text entry box."""
        entry = tk.Entry(self.window)
        entry.pack()
        return entry

    def create_button(self, text, command):
        """Create a button with given text and command."""
        button = tk.Button(self.window, text=text, command=command)
        button.pack()
        return button

    def create_checkbutton(self, text, variable):
        """Create a check button with given text and variable."""
        checkbutton = tk.Checkbutton(self.window, text=text, variable=variable)
        checkbutton.pack()
        return checkbutton

    def create_radiobutton(self, text, variable, value):
        """Create a radio button with given text, variable, and value."""
        radiobutton = tk.Radiobutton(self.window, text=text, variable=variable, value=value)
        radiobutton.pack()
        return radiobutton

    def create_listbox(self):
        """Create a list box."""
        listbox = tk.Listbox(self.window)
        listbox.pack()
        return listbox

    def create_scrollbar(self, command):
        """Create a scrollbar with given command."""
        scrollbar = tk.Scrollbar(self.window, command=command)
        scrollbar.pack(side=tk.RIGHT, fill=tk.Y)
        return scrollbar

# ============ 2. Main Execution ============
if __name__ == "__main__":
    # Create the main window
    window = tk.Tk()
    window.title("Example Form")
    
    # Create an instance of FormManager
    form_manager = FormManager(window)
    
    # Create form elements
    label = form_manager.create_label("Name:")
    entry = form_manager.create_entry()
    button = form_manager.create_button("Submit", form_manager.submit)
    check_var = tk.IntVar()
    checkbutton = form_manager.create_checkbutton("Subscribe", check_var)
    radio_var = tk.IntVar()
    radiobutton1 = form_manager.create_radiobutton("Option 1", radio_var, value=1)
    radiobutton2 = form_manager.create_radiobutton("Option 2", radio_var, value=2)
    listbox = form_manager.create_listbox()
    scrollbar = form_manager.create_scrollbar(listbox.yview)
    
    # Configure the Listbox to use the Scrollbar
    listbox.config(yscrollcommand=scrollbar.set)
    
    # Start the Tkinter event loop
    window.mainloop()
