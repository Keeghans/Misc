
namespace Exam2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnNewGameForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(9, 21);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.RowHeadersWidth = 62;
            this.dgvGames.RowTemplate.Height = 28;
            this.dgvGames.Size = new System.Drawing.Size(220, 524);
            this.dgvGames.TabIndex = 0;
            this.dgvGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellClick);
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellContentClick);
            this.dgvGames.SelectionChanged += new System.EventHandler(this.dgvGames_SelectionChanged);
            // 
            // btnNewGameForm
            // 
            this.btnNewGameForm.Location = new System.Drawing.Point(233, 21);
            this.btnNewGameForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGameForm.Name = "btnNewGameForm";
            this.btnNewGameForm.Size = new System.Drawing.Size(196, 131);
            this.btnNewGameForm.TabIndex = 1;
            this.btnNewGameForm.Text = "New Game Form";
            this.btnNewGameForm.UseVisualStyleBackColor = true;
            this.btnNewGameForm.Click += new System.EventHandler(this.btnNewGameForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 570);
            this.Controls.Add(this.btnNewGameForm);
            this.Controls.Add(this.dgvGames);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnNewGameForm;
    }
}

