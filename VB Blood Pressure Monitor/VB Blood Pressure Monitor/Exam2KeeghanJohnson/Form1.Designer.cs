namespace Exam2KeeghanJohnson
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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Display_Patient_Status_Button = new System.Windows.Forms.Button();
            this.Clear_MonitorButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(615, 351);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit_Button.Size = new System.Drawing.Size(123, 72);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "EXIT SYSTEM";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(779, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Pressure Monitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AVG Systolic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "AVG Diastolic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Physician";
            // 
            // Display_Patient_Status_Button
            // 
            this.Display_Patient_Status_Button.Location = new System.Drawing.Point(105, 351);
            this.Display_Patient_Status_Button.Name = "Display_Patient_Status_Button";
            this.Display_Patient_Status_Button.Size = new System.Drawing.Size(123, 72);
            this.Display_Patient_Status_Button.TabIndex = 8;
            this.Display_Patient_Status_Button.Text = "DISPLAY PATIENT STATUS";
            this.Display_Patient_Status_Button.UseVisualStyleBackColor = true;
            this.Display_Patient_Status_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clear_MonitorButton
            // 
            this.Clear_MonitorButton.Location = new System.Drawing.Point(352, 351);
            this.Clear_MonitorButton.Name = "Clear_MonitorButton";
            this.Clear_MonitorButton.Size = new System.Drawing.Size(123, 72);
            this.Clear_MonitorButton.TabIndex = 9;
            this.Clear_MonitorButton.Text = "CLEAR MONITOR";
            this.Clear_MonitorButton.UseVisualStyleBackColor = true;
            this.Clear_MonitorButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_MonitorButton);
            this.Controls.Add(this.Display_Patient_Status_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Exit_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Display_Patient_Status_Button;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button Clear_MonitorButton;
    }
}

