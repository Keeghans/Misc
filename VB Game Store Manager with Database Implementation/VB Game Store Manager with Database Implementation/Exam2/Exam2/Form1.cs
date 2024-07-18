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
    public partial class Form1 : Form
    {

        List<Game> games = new List<Game>();
        Game selectedGame = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGameForm_Click(object sender, EventArgs e)
        {
            frmNewGame form = new frmNewGame();
            form.ShowDialog();

            //refresh the data grid view;
            showGames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showGames();
        }
        private void showGames()
        {
            try
            {
                games = GameDB.getAllGames();
                games = games.OrderBy(x => x.Title).ToList();
                var values = games.Select(x => new { x.Title }).ToList();
                dgvGames.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = dgvGames.CurrentRow.Index;
            if (selectedIndex >= 0)
            {
                selectedGame = games.ElementAt(selectedIndex);
            }
            

        }

        private void dgvGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show(selectedGame.GetSalePrice().ToString());
        }
    }
}

