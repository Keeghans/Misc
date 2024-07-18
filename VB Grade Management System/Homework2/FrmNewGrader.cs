using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework2
{
    public partial class FrmNewGrader : Form
    {
        Grader grader = null;
        public FrmNewGrader()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Grader GetNewGrader()
        {
            this.ShowDialog();
            return grader;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            grader = new Grader();
            grader.ID = IDtextBox.Text;
            grader.FirstName = firstNameTextBox.Text;
            grader.LastName = lastNameTextBox.Text;
            grader.HourlyPay = decimal.Parse(hourlyPayTextbox.Text);
            grader.Hours = decimal.Parse(hoursTextBox.Text);
            MessageBox.Show("Total Pay = " + (grader.GetTotalPay().ToString("c")));
            this.Close();
        }
    }
}
