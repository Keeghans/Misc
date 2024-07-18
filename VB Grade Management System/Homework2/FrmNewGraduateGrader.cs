using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework2
{

    public partial class FrmNewGraduateGrader : Form
    {
        GraduateGrader graduateGrader = null;
        public FrmNewGraduateGrader()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            graduateGrader = new GraduateGrader();
            graduateGrader.ID = IDtextBox.Text;
            graduateGrader.FirstName = firstNameTextBox.Text;
            graduateGrader.LastName = lastNameTextBox.Text;
            graduateGrader.HourlyPay = decimal.Parse(hourlyPayTextbox.Text);
            graduateGrader.Hours = decimal.Parse(hoursTextBox.Text);
            graduateGrader.Stipend = decimal.Parse(stipendTextBox.Text);
            MessageBox.Show(("Total Pay = " + graduateGrader.GetTotalPay().ToString("c")));
            this.Close();
        }
        public GraduateGrader GetNewGraduateGrader()
        {
            this.ShowDialog();
            return graduateGrader;
        }

        private void FrmNewGraduateGrader_Load(object sender, EventArgs e)
        {

        }
       
    }
}
