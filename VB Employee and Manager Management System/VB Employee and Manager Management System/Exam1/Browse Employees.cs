using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    
    public partial class Form1 : Form
    {
        List<Employee> list = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addManagerBtn_Click(object sender, EventArgs e)
        {
            New_Manager form = new New_Manager();
            Employee es = form.GetEmployees();
            list.Add(es);
            employeeInfo.Items.Clear();
            DisplayEmployees();
        }
        private void DisplayEmployees()
        {
            employeeInfo.Items.Clear();
            foreach (Employee element in list)
            {
                employeeInfo.Items.Add(element.GetDisplayText());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = EmployeeAccess.GetEmployees();
            DisplayEmployees();
        }
    }
}
