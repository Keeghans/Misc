
namespace Homework2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.graderInfo = new System.Windows.Forms.ListBox();
            this.btnNewGrader = new System.Windows.Forms.Button();
            this.btnNewGraduateGrader = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // graderInfo
            // 
            this.graderInfo.FormattingEnabled = true;
            this.graderInfo.ItemHeight = 15;
            this.graderInfo.Location = new System.Drawing.Point(12, 15);
            this.graderInfo.Name = "graderInfo";
            this.graderInfo.Size = new System.Drawing.Size(345, 394);
            this.graderInfo.TabIndex = 0;
            this.graderInfo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNewGrader
            // 
            this.btnNewGrader.Location = new System.Drawing.Point(378, 37);
            this.btnNewGrader.Name = "btnNewGrader";
            this.btnNewGrader.Size = new System.Drawing.Size(212, 96);
            this.btnNewGrader.TabIndex = 1;
            this.btnNewGrader.Text = "Add a Grader";
            this.btnNewGrader.UseVisualStyleBackColor = true;
            this.btnNewGrader.Click += new System.EventHandler(this.btnNewGrader_Click);
            // 
            // btnNewGraduateGrader
            // 
            this.btnNewGraduateGrader.Location = new System.Drawing.Point(378, 139);
            this.btnNewGraduateGrader.Name = "btnNewGraduateGrader";
            this.btnNewGraduateGrader.Size = new System.Drawing.Size(212, 110);
            this.btnNewGraduateGrader.TabIndex = 2;
            this.btnNewGraduateGrader.Text = "Add a Graduate Grader";
            this.btnNewGraduateGrader.UseVisualStyleBackColor = true;
            this.btnNewGraduateGrader.Click += new System.EventHandler(this.btnNewGraduateGrader_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(805, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnNewGraduateGrader);
            this.Controls.Add(this.btnNewGrader);
            this.Controls.Add(this.graderInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox graderInfo;
        private System.Windows.Forms.Button btnNewGrader;
        private System.Windows.Forms.Button btnNewGraduateGrader;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

