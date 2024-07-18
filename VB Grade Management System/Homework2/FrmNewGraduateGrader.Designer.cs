
namespace Homework2
{
    partial class FrmNewGraduateGrader
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.Stipend = new System.Windows.Forms.Label();
            this.stipendTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hourly Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(112, 165);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoursTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(112, 107);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // hourlyPayTextbox
            // 
            this.hourlyPayTextbox.Location = new System.Drawing.Point(112, 136);
            this.hourlyPayTextbox.Name = "hourlyPayTextbox";
            this.hourlyPayTextbox.Size = new System.Drawing.Size(100, 23);
            this.hourlyPayTextbox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(112, 78);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(112, 49);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 23);
            this.IDtextBox.TabIndex = 11;
            // 
            // Stipend
            // 
            this.Stipend.AutoSize = true;
            this.Stipend.Location = new System.Drawing.Point(45, 201);
            this.Stipend.Name = "Stipend";
            this.Stipend.Size = new System.Drawing.Size(47, 15);
            this.Stipend.TabIndex = 23;
            this.Stipend.Text = "Stipend";
            // 
            // stipendTextBox
            // 
            this.stipendTextBox.Location = new System.Drawing.Point(112, 194);
            this.stipendTextBox.Name = "stipendTextBox";
            this.stipendTextBox.Size = new System.Drawing.Size(100, 23);
            this.stipendTextBox.TabIndex = 16;
            // 
            // FrmNewGraduateGrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stipend);
            this.Controls.Add(this.stipendTextBox);
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
            this.Name = "FrmNewGraduateGrader";
            this.Text = "FrmNewGraduateGrader";
            this.Load += new System.EventHandler(this.FrmNewGraduateGrader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox hourlyPayTextbox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label Stipend;
        private System.Windows.Forms.TextBox stipendTextBox;
    }
}