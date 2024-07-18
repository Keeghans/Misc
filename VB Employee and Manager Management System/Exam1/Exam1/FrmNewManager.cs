using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exam1
{
    public partial class New_Manager : Form
    {
        Employee employee = null;
        Manager manager = null;
        public New_Manager()
        {
            InitializeComponent();
        }
        public Employee GetEmployees()
        {
            this.ShowDialog();
            return employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            manager = new Manager();
            employee.ID = int.Parse(IDtextBox.Text);
            employee.LastName = lastNameTextBox.Text;
            employee.Salary = decimal.Parse(salaryTextbox.Text);
            manager.Bonus = decimal.Parse(bonusTextBox.Text);
            this.Close();
        }
    }
}
