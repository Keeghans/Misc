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
    public partial class MealPlan : Form
    {
        public MealPlan()
        {
            InitializeComponent();
        }
        string mealPlan = " ";
        public static double mealplancost = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            mealPlan = listBox1.SelectedItem.ToString();
            if (mealPlan == "7 Meals")
            {
                mealplancost = 560;
            }
            else if (mealPlan == "14 Meals")
            {
                mealplancost = 1095;
            }
            else if (mealPlan == "Unlimited Meals")
            {
                mealplancost = 1500;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
