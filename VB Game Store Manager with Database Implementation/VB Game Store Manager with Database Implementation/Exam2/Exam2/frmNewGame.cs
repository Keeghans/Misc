using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class frmNewGame : Form
    {
        Game ga = null;
        public frmNewGame()
        {
            InitializeComponent();
        }

        private void frmNewGame_Load(object sender, EventArgs e)
        {
            List<Game> games = GameDB.getAllGames();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ga = new Game();
            ga.GameId = txtGameID.Text;
            ga.Title = txtTitle.Text;
            try
            {
                ga.Price = Decimal.Parse(txtPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a decimal Price.");
            }
            try
            {
                ga.Discount = decimal.Parse(txtDiscount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a decimal discount.");
                this.Hide();
            }
            if (txtGameID.Text == "" || txtTitle.Text == "" || txtPrice.Text == "" || txtDiscount.Text == "")
                MessageBox.Show("Please enter values into all boxes");      
            else
                GameDB.addGame(ga);
                this.Close();
        }
    }
}
