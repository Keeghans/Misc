
namespace Homework2
{
    partial class FrmNewGrader
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
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(133, 76);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 23);
            this.IDtextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(133, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // hourlyPayTextbox
            // 
            this.hourlyPayTextbox.Location = new System.Drawing.Point(133, 163);
            this.hourlyPayTextbox.Name = "hourlyPayTextbox";
            this.hourlyPayTextbox.Size = new System.Drawing.Size(100, 23);
            this.hourlyPayTextbox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(133, 134);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(133, 192);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoursTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hourly Pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hours";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmNewGrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.hourlyPayTextbox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.IDtextBox);
            this.Name = "FrmNewGrader";
            this.Text = "FrmNewGrader";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox hourlyPayTextbox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
    }
}