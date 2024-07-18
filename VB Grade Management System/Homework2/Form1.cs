using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        List<Grader> list = new List<Grader>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = GraderAccess.GetGraders();
            DisplayGraders();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewGrader_Click(object sender, EventArgs e)
        {
            FrmNewGrader form = new FrmNewGrader();
            Grader g = form.GetNewGrader();
            list.Add(g);
            graderInfo.Items.Clear();
            DisplayGraders();
        }

        private void btnNewGraduateGrader_Click(object sender, EventArgs e)
        {
            FrmNewGraduateGrader form = new FrmNewGraduateGrader();
            GraduateGrader gg = form.GetNewGraduateGrader();
            list.Add(gg);
            DisplayGraders();
        }
        private void DisplayGraders()
        {
            graderInfo.Items.Clear();
            foreach (Grader element in list)
            {
                graderInfo.Items.Add(element.GetDisplayText());
            }
        }
    }
}
