using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exam2KeeghanJohnson
{// Designed and coded by Keeghan Johnson
    public partial class Form1 : Form
    {
        string pName = null, status = null, doctor = null;
        int doc = 0;
        double s0 = 0, s1 = 0, s2 = 0, s3 = 0, s4 = 0, d0 = 0, d1 = 0, d2 = 0, d3 = 0, d4 = 0, avgSystolic = 0.00, avgDiastolic = 0.00;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {// Codebehind DISPLAY PATIENT STATUS BUTTON
            ProcessFile();         
        }
        private void ProcessFile()
        {// Has all the processing and stuff
            StreamReader InputFile;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                InputFile = File.OpenText(openFile.FileName);
                while (!InputFile.EndOfStream)
                {
                    pName = InputFile.ReadLine();
                    s0 = int.Parse(InputFile.ReadLine());
                    d0 = int.Parse(InputFile.ReadLine());
                    s1 = int.Parse(InputFile.ReadLine());
                    d1 = int.Parse(InputFile.ReadLine());
                    s2 = int.Parse(InputFile.ReadLine());
                    d2 = int.Parse(InputFile.ReadLine());
                    s3 = int.Parse(InputFile.ReadLine());
                    d3 = int.Parse(InputFile.ReadLine());
                    s4 = int.Parse(InputFile.ReadLine());
                    d4 = int.Parse(InputFile.ReadLine());
                    doc = int.Parse(InputFile.ReadLine());
                    SystolicPressure();
                    DiastolicPressure();
                    PatientStatus();
                    DoctorsName();
                    DisplayOutput();
                }
                InputFile.Close();
            }
        }
        private void SystolicPressure()
        {//assigns the values to the array then averages the systolic
          
            try
            {
               avgSystolic=((s0 +s1 + s2 + s3 + s4) / 5);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void DiastolicPressure()
        {//assigns the values to the array then averages the diastolic

            try
            {
                avgDiastolic =((d0 + d1 + d2 + d3 + d4) / 5);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void PatientStatus()
        {// find if there is any warnings due to the results of the systolic
            try
            {
                if (avgSystolic <= 90)
                    status = "WARNING";
                else if
                    (avgSystolic >= 160)
                    status = "WARNING";
                else if (avgDiastolic <= 60)
                    status = "WARNING";
                else if (avgDiastolic >= 90)
                    status = "WARNING";
                else status = "NORMAL  ";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void DoctorsName()
        {// find if there is any warnings due to the results of the systolic
            try
            {
                if (doc <= 0)
                    doctor = "D.ABRAMS,MD";
                else if
                    (doc <= 1)
                    doctor = "D.JARVIC,MD";
                else if (doc <= 2)
                    doctor = "T.PANOS,MD";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DisplayOutput()
        { // put the text int the list box
            try
            {
                listBox1.Items.Add(pName + "\t \t \t" + avgSystolic.ToString("N2")
                    + "\t \t \t" + avgDiastolic.ToString("N2") + "\t \t \t" + status + "\t \t \t" + doctor + "\t \t \t");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void resetitems()
        {
            try
            {
                openFile.FileName = " ";
                listBox1.Items.Clear();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            resetitems();
        }
        private void button1_Click(object sender, EventArgs e)
        {// Codebehind EXIT Button
            Application.Exit();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
    
