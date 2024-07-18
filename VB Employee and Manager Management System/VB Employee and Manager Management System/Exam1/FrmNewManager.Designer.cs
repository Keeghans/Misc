
namespace Exam1
{
    partial class New_Manager
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextbox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 314);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 38);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bonus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(135, 147);
            this.bonusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(141, 31);
            this.bonusTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(135, 65);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(141, 31);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // salaryTextbox
            // 
            this.salaryTextbox.Location = new System.Drawing.Point(135, 106);
            this.salaryTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryTextbox.Name = "salaryTextbox";
            this.salaryTextbox.Size = new System.Drawing.Size(141, 31);
            this.salaryTextbox.TabIndex = 14;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(135, 24);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(141, 31);
            this.IDtextBox.TabIndex = 11;
            // 
            // New_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.salaryTextbox);
            this.Controls.Add(this.IDtextBox);
            this.Name = "New_Manager";
            this.Text = "New_Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox salaryTextbox;
        private System.Windows.Forms.TextBox IDtextBox;
    }
}