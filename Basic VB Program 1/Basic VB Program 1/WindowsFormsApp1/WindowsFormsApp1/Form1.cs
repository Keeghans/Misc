using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Coded By Keeghan Johnson
        public Form1()
        {
            InitializeComponent();
        }
        //Variable and Constant Definition
        Double soldA = 0.0, soldB = 0.0, soldC = 0.0, totalAll = 0.0;
        const int ticketA = 15, ticketB = 12, ticketC = 9;
        private void button3_Click(object sender, EventArgs e)
        {//Code behind calculate revune button
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
                soldA = double.Parse(textBox1.Text);
                soldB = double.Parse(textBox2.Text);
                soldC = double.Parse(textBox3.Text);
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
                soldA = soldA * ticketA;
                soldB = soldB * ticketB;
                soldC = soldC * ticketC;
                totalAll = soldA + soldB + soldC;
            }
            catch
            {
                //P
            }
        }
        private void displayoutput()
        {
            try
            {
                label11.Text = soldA.ToString("C");
                label12.Text = soldB.ToString("C");
                label13.Text = soldC.ToString("C");
                label14.Text = totalAll.ToString("C");
            }
            catch
            {
                //P
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//This is the CLEAR codebehind
            try
            {
                clearfields();
                clearvariables();
            }
            catch
            {
                //pending
            }
        }
        private void clearfields()
        {
            try
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                label11.Text = " ";
                label12.Text = " ";
                label13.Text = " ";
                label14.Text = " ";
            }
            catch
            {
                //pending
            }
        }
        private void clearvariables()
        {
            try
            {
                soldA = 0.0;
                soldB = 0.0;
                soldC = 0.0;
                totalAll = 0.0;
            }
            catch
            {
                //pending
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

