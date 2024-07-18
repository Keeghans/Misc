
namespace Exam1
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
            this.employeeInfo = new System.Windows.Forms.ListBox();
            this.addManagerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeInfo
            // 
            this.employeeInfo.FormattingEnabled = true;
            this.employeeInfo.ItemHeight = 25;
            this.employeeInfo.Location = new System.Drawing.Point(33, 39);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.Size = new System.Drawing.Size(381, 429);
            this.employeeInfo.TabIndex = 0;
            // 
            // addManagerBtn
            // 
            this.addManagerBtn.Location = new System.Drawing.Point(469, 75);
            this.addManagerBtn.Name = "addManagerBtn";
            this.addManagerBtn.Size = new System.Drawing.Size(254, 118);
            this.addManagerBtn.TabIndex = 1;
            this.addManagerBtn.Text = "Add Manager";
            this.addManagerBtn.UseVisualStyleBackColor = true;
            this.addManagerBtn.Click += new System.EventHandler(this.addManagerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.addManagerBtn);
            this.Controls.Add(this.employeeInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeeInfo;
        private System.Windows.Forms.Button addManagerBtn;
    }
}

