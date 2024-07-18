using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    // Made by Keeghan Johnson
    public partial class Dorm : Form
    {
        public Dorm()
        {
            InitializeComponent();
        }
        string dorm = " ";
        double dormprice = 0, mealplanprice = 0, total = 0;
        //Add Dormitory 
        private void button1_Click(object sender, EventArgs e)
        {
            dorm = listBox1.SelectedItem.ToString();
            if (dorm == "Allen Hall")
            {
                dormprice = 1500;  
            }
            else if (dorm == "Farthing Hall")
            {
                dormprice = 1200;
            }
            else if (dorm == "Pike Hall")
            {
                dormprice = 1600;
            }
            else if (dorm == "University Suites")
            {
                dormprice = 1800;
            }
            label4.Text = dormprice.ToString("C");
        }
        //view mealplan
        private void button2_Click(object sender, EventArgs e)
        {
            form();
            calculate();
        }
        private void form()
        {
            MealPlan meals = new MealPlan();
            meals.ShowDialog();
            mealplanprice = MealPlan.mealplancost;
        }       
        private void calculate()
        {
            label5.Text = mealplanprice.ToString("C");
            total = dormprice + mealplanprice;
            label6.Text = total.ToString("C");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //clear
        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            listBox1.SelectedItem = " ";
            listBox1.SelectedIndex = -1;
            dorm = " ";
            dormprice = 0;
            mealplanprice = 0;
        }
        //exit
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
