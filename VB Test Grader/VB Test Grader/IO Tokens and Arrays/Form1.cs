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

namespace IO_Tokens_and_Arrays
{
    public partial class Form1 : Form
    {
        //made by Keeghan Johnson
        string fName, lName, finalG, input;
        int i = 0, count = 0, index = 0, minIndex = 0, maxIndex = 0;
        char search;
        int[] grade = new int[9];
        string[] Reader = new string[9];
        double s1, s2, s3, s4, s5, s6, 
            s7, s8, s9, lowestScore, highestScore, meanScore;
        StreamReader inputFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InputFile();
                SortValues();
            }
            catch
            {
                //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch
            {
                //
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                //
            }
        }
        private void OutputFile()
        {
            try
            {

            }
            catch
            {

            }
        }
        private void OutputProcess()
        {
            try
            {
                double lowscore = double.Parse(Reader[2]);
                double highestscore = double.Parse(Reader[8]);
                listBox1.Items.Add(i + "\t" + fName + " " + lName + "\t" 
                    + Reader[3] + "\t" +
                                          Reader[4] + "\t" + Reader[5] + "\t" +
                                          Reader[6] + "\t" + Reader[7] + "\t" +
                                          meanScore + "\t" + lowscore + "\t" 
                                          + highestscore + "\t" + finalG);
            }
            catch
            {
                //
            }
        }
        private void InputFile()
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Report.txt");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    while (!inputFile.EndOfStream)
                    {
                        i++;
                        ReadInput();
                        OutputProcess();
                        outputFile.WriteLine("" + Reader[0] + "," + Reader[1] 
                            + "," + finalG);
                    }
                    inputFile.Close();
                    outputFile.Close();
                    MessageBox.Show("a report has been created");
                }
            }
            catch
            {

            }
        }
        private void ReadInput()
        {
            try
            {
                input = inputFile.ReadLine();
                Reader = input.Split(',');
                fName = Reader[0];
                lName = Reader[1];
                s1 = double.Parse(Reader[2]);
                s2 = double.Parse(Reader[3]);
                s3 = double.Parse(Reader[4]);
                s4 = double.Parse(Reader[5]);
                s5 = double.Parse(Reader[6]);
                s6 = double.Parse(Reader[7]);
                s7 = double.Parse(Reader[8]);
                SortValues();
                CalcMean();
                CalcGrade();
            }
            catch
            {

            }
        }
        private void ClearAll()
        {
            try
            {
                listBox1.Items.Clear();
            }
            catch
            {

            }
        }
        private void SortValues()
        {
            try
            {
                for (int index = 2; index < Reader.Length - 1; index++)
                {
                    minIndex = index;
                    lowestScore = double.Parse(Reader[index]);
                    for (int count = index + 1; count < Reader.Length; count++)
                    {
                        if (double.Parse(Reader[count]) < lowestScore)
                        {
                            lowestScore = double.Parse(Reader[count]);
                            minIndex = count;
                        }
                    }
                    Swap(ref Reader[minIndex], ref Reader[index]);
                }
            }
            catch
            {
                //
            }
        }
        private void Swap (ref string a, ref string b)
        {
            string score = a;   
            a = b;
            b = score;
        }
        private void CalcMean()
        {
            try
            {
                double totalgrade = 0;
                totalgrade = double.Parse(Reader[3]) + double.Parse(Reader[4]) + double.Parse(Reader[5]) + double.Parse(Reader[6]) + double.Parse(Reader[7]);
                meanScore = totalgrade / 5;
            }
            catch
            {
                //
            }
        }
        private void CalcGrade()
        {
            try
            {
                if (meanScore >= 90)
                {
                    finalG = "A";
                }
                else if (meanScore >= 80)
                {
                    finalG = "B";
                }
                else if (meanScore >= 70)
                {
                    finalG = "C";

                }
                else if (meanScore >= 60)
                {
                    finalG = "D";
                }
                else
                {
                    finalG = "F";
                }
            }
            catch
            {
                //
            }
        }
    }
}
