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

namespace EXAM3JohnsonKeeghan
{
    public partial class Form1 : Form
    { 
        //Coded by Keeghan Johnson
        public Form1()
        {
            InitializeComponent();
        }
        string FName;
        string LName;
        string[] AnswerKey = new string[12];
        string KeyData;
        string Data;
        string[] Reader = new string[12];
        int index = 0;
        int CorrectAnswers = 0;
        int Grade;
        double AccumulatedScore;
        double MeanScore;
        int lowestScore = 100;
        int highestScore = 0;
        StreamReader ExamInput;        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputExam();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void InputExam()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExamInput = File.OpenText(openFileDialog1.FileName);
                    KeyData = ExamInput.ReadLine();
                    AnswerKey = KeyData.Split(',');
                    while (!ExamInput.EndOfStream)
                    {
                        ProcessInput();
                        Grading();
                        DisplayResult();
                    }
                    ExamInput.Close();
                    DisplaySummary();
                }
            }
            catch
            {
                //
            }
        }
        private void ProcessInput()
        {
            try
            {
                Data = ExamInput.ReadLine();
                Reader = Data.Split(',');
                FName = Reader[0];
                LName = Reader[1];
                index++;
            }
            catch
            {
                //
            }
        }
        private void Grading()
        {
            try
            {
                for (int i = 2; i < Reader.Length - 1; i++)
                {
                    if (AnswerKey[i] == Reader[i])
                    {
                        CorrectAnswers++;
                    }
                }
                Grade = CorrectAnswers * 10;
                AccumulatedScore += Grade;
                if (Grade > highestScore)
                {
                    highestScore = Grade;
                }
                if (Grade < lowestScore)
                {
                    lowestScore = Grade;
                }
                CorrectAnswers = 0;
                MeanScore = AccumulatedScore / index;
            }
            catch
            {
                //
            }
        }
        private void DisplayResult()
        {
            try
            {
                listBox1.Items.Add(index + "\t" + "\t" + "\t" + LName
                    + " " + FName + " \t" + "\t" + "\t" + Grade);
            }
            catch
            {
                //
            }
        }
        private void DisplaySummary()
        {
            try
            {
                listBox1.Items.Add("Exams graded: " + index + "\t"
                    + "Low Score:" + lowestScore + "\t" + "High Score:" + highestScore
                    + "\t" + "Mean Score:" + MeanScore);
            }
            catch
            {
                //
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ClearAll()
        {
            try
            {
                listBox1.Items.Clear();
                Array.Clear(AnswerKey, 0, AnswerKey.Length);
                Array.Clear(Reader, 0, Reader.Length);
                Data = "";
                KeyData = "";
                FName = ""; LName = "";
                index = 0; CorrectAnswers = 0;
                Grade = 0; MeanScore = 0; AccumulatedScore = 0;
                highestScore = 0; lowestScore = 100;
            }
            catch
            {

            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExitMethod();
            }
            catch (Exception)
            {

                //
            }
        }
        private void ExitMethod()
        {
            try
            {
                MessageBox.Show("Please press Ok to close the program.");
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
