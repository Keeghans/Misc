using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_Johnson
{
    public partial class Form1 : Form
    {
        // Coded By Keeghan Johnson
        public Form1()
        {
            InitializeComponent();
        }
        //Variable and constant deifition
        int touchdownin = 0, extrakickin = 0, fieldgoalin = 0, totalpoints = 0;
        const int TD = 6, TDKICK = 1, FGOAL = 3;

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Code behind the Total points scored button
            try
            {
                inputdata();
                processdata();
                displayoutput();
            }
            catch
            {
                //P
            }
        }
        private void inputdata()
        {
            try
            {
                touchdownin = int.Parse(textBox1.Text);
                extrakickin = int.Parse(textBox2.Text);
                fieldgoalin = int.Parse(textBox3.Text);
            }
            catch
            {
                //P
            }
        }
        private void processdata()
        {
            try
            {
                touchdownin = touchdownin * TD;
                extrakickin = extrakickin * TDKICK;
                fieldgoalin = fieldgoalin * FGOAL;
                totalpoints = touchdownin + extrakickin + fieldgoalin;
            }
            catch
            {
                //P
            }
        }
        private void displayoutput()
        {
            label5.Text = totalpoints.ToString("");
        }
        private void button2_Click(object sender, EventArgs e)
        {// This is the CLEAR SCORE BOARD BUTTON
            try
            {
                MessageBox.Show("Clearing the scoreboard");
                clearfields();
                clearvariables();
            }
            catch
            {
                //P
            }
        }
        private void clearfields()
        {
            try
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                label5.Text = " ";
            }
            catch
            {
                //P
            }
        }
        private void clearvariables()
        {
            try
            {
                touchdownin = 0;
                extrakickin = 0;
                fieldgoalin = 0;
                totalpoints = 0;
            }
            catch
            {
                //P
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {// This is the codebehind the EXIT button
            try
            {
                endprogram();
            }
            catch
            {
                //pending
            }
        }
        private void endprogram()
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                //pending
            }
        }
    }
}
