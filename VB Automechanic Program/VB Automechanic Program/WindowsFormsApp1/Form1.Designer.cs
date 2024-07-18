namespace Joe_s_Automotive
{
    partial class Form1
    {
    
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.grpOilLube = new System.Windows.Forms.GroupBox();
            this.cbLubeJob = new System.Windows.Forms.CheckBox();
            this.cbOilChange = new System.Windows.Forms.CheckBox();
            this.grpFlushes = new System.Windows.Forms.GroupBox();
            this.cbTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.cbRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.cbTireRotation = new System.Windows.Forms.CheckBox();
            this.cbReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.cbInspection = new System.Windows.Forms.CheckBox();
            this.grpPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPartsSummary = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTaxCaption = new System.Windows.Forms.Label();
            this.lblPartsSummaryCaption = new System.Windows.Forms.Label();
            this.lblServicesCaption = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOilLube.SuspendLayout();
            this.grpFlushes.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.grpPartsAndLabor.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilLube
            // 
            this.grpOilLube.Controls.Add(this.cbLubeJob);
            this.grpOilLube.Controls.Add(this.cbOilChange);
            this.grpOilLube.Location = new System.Drawing.Point(12, 12);
            this.grpOilLube.Name = "grpOilLube";
            this.grpOilLube.Size = new System.Drawing.Size(158, 82);
            this.grpOilLube.TabIndex = 1;
            this.grpOilLube.TabStop = false;
            this.grpOilLube.Text = "Oil && Lube";
            // 
            // cbLubeJob
            // 
            this.cbLubeJob.AutoSize = true;
            this.cbLubeJob.Location = new System.Drawing.Point(15, 52);
            this.cbLubeJob.Name = "cbLubeJob";
            this.cbLubeJob.Size = new System.Drawing.Size(112, 17);
            this.cbLubeJob.TabIndex = 1;
            this.cbLubeJob.Text = "Lube Job ($18.00)";
            this.cbLubeJob.UseVisualStyleBackColor = true;
            // 
            // cbOilChange
            // 
            this.cbOilChange.AutoSize = true;
            this.cbOilChange.Location = new System.Drawing.Point(15, 23);
            this.cbOilChange.Name = "cbOilChange";
            this.cbOilChange.Size = new System.Drawing.Size(120, 17);
            this.cbOilChange.TabIndex = 0;
            this.cbOilChange.Text = "Oil Change ($26.00)";
            this.cbOilChange.UseVisualStyleBackColor = true;
            // 
            // grpFlushes
            // 
            this.grpFlushes.Controls.Add(this.cbTransmissionFlush);
            this.grpFlushes.Controls.Add(this.cbRadiatorFlush);
            this.grpFlushes.Location = new System.Drawing.Point(176, 12);
            this.grpFlushes.Name = "grpFlushes";
            this.grpFlushes.Size = new System.Drawing.Size(190, 82);
            this.grpFlushes.TabIndex = 2;
            this.grpFlushes.TabStop = false;
            this.grpFlushes.Text = "Flushes";
            // 
            // cbTransmissionFlush
            // 
            this.cbTransmissionFlush.AutoSize = true;
            this.cbTransmissionFlush.Location = new System.Drawing.Point(15, 52);
            this.cbTransmissionFlush.Name = "cbTransmissionFlush";
            this.cbTransmissionFlush.Size = new System.Drawing.Size(157, 17);
            this.cbTransmissionFlush.TabIndex = 1;
            this.cbTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.cbTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // cbRadiatorFlush
            // 
            this.cbRadiatorFlush.AutoSize = true;
            this.cbRadiatorFlush.Location = new System.Drawing.Point(15, 23);
            this.cbRadiatorFlush.Name = "cbRadiatorFlush";
            this.cbRadiatorFlush.Size = new System.Drawing.Size(136, 17);
            this.cbRadiatorFlush.TabIndex = 0;
            this.cbRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.cbRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.cbTireRotation);
            this.grpMisc.Controls.Add(this.cbReplaceMuffler);
            this.grpMisc.Controls.Add(this.cbInspection);
            this.grpMisc.Location = new System.Drawing.Point(12, 100);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(158, 118);
            this.grpMisc.TabIndex = 3;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc";
            // 
            // cbTireRotation
            // 
            this.cbTireRotation.AutoSize = true;
            this.cbTireRotation.Location = new System.Drawing.Point(15, 86);
            this.cbTireRotation.Name = "cbTireRotation";
            this.cbTireRotation.Size = new System.Drawing.Size(129, 17);
            this.cbTireRotation.TabIndex = 2;
            this.cbTireRotation.Text = "Tire Rotation ($20.00)";
            this.cbTireRotation.UseVisualStyleBackColor = true;
            // 
            // cbReplaceMuffler
            // 
            this.cbReplaceMuffler.Location = new System.Drawing.Point(15, 47);
            this.cbReplaceMuffler.Name = "cbReplaceMuffler";
            this.cbReplaceMuffler.Size = new System.Drawing.Size(112, 33);
            this.cbReplaceMuffler.TabIndex = 1;
            this.cbReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.cbReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // cbInspection
            // 
            this.cbInspection.AutoSize = true;
            this.cbInspection.Location = new System.Drawing.Point(15, 24);
            this.cbInspection.Name = "cbInspection";
            this.cbInspection.Size = new System.Drawing.Size(117, 17);
            this.cbInspection.TabIndex = 0;
            this.cbInspection.Text = "Inspection ($15.00)";
            this.cbInspection.UseVisualStyleBackColor = true;
            // 
            // grpPartsAndLabor
            // 
            this.grpPartsAndLabor.Controls.Add(this.txtLabor);
            this.grpPartsAndLabor.Controls.Add(this.txtParts);
            this.grpPartsAndLabor.Controls.Add(this.lblLabor);
            this.grpPartsAndLabor.Controls.Add(this.lblParts);
            this.grpPartsAndLabor.Location = new System.Drawing.Point(176, 103);
            this.grpPartsAndLabor.Name = "grpPartsAndLabor";
            this.grpPartsAndLabor.Size = new System.Drawing.Size(190, 115);
            this.grpPartsAndLabor.TabIndex = 0;
            this.grpPartsAndLabor.TabStop = false;
            this.grpPartsAndLabor.Text = "Parts and Labor";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(81, 69);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(84, 20);
            this.txtLabor.TabIndex = 1;
            this.txtLabor.Text = "0";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(82, 32);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(79, 20);
            this.txtParts.TabIndex = 0;
            this.txtParts.Text = "0";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(26, 72);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(49, 13);
            this.lblLabor.TabIndex = 1;
            this.lblLabor.Text = "Labor ($)";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(45, 35);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(31, 13);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parts";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.lblPartsSummary);
            this.grpSummary.Controls.Add(this.lblServices);
            this.grpSummary.Controls.Add(this.lblTotalCaption);
            this.grpSummary.Controls.Add(this.lblTaxCaption);
            this.grpSummary.Controls.Add(this.lblPartsSummaryCaption);
            this.grpSummary.Controls.Add(this.lblServicesCaption);
            this.grpSummary.Location = new System.Drawing.Point(12, 224);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(354, 142);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(139, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(139, 78);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 23);
            this.lblTax.TabIndex = 6;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartsSummary
            // 
            this.lblPartsSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsSummary.Location = new System.Drawing.Point(139, 50);
            this.lblPartsSummary.Name = "lblPartsSummary";
            this.lblPartsSummary.Size = new System.Drawing.Size(100, 23);
            this.lblPartsSummary.TabIndex = 5;
            this.lblPartsSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServices
            // 
            this.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServices.Location = new System.Drawing.Point(139, 22);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(100, 23);
            this.lblServices.TabIndex = 4;
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(55, 111);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(57, 13);
            this.lblTotalCaption.TabIndex = 3;
            this.lblTotalCaption.Text = "Total Fees";
            // 
            // lblTaxCaption
            // 
            this.lblTaxCaption.AutoSize = true;
            this.lblTaxCaption.Location = new System.Drawing.Point(40, 83);
            this.lblTaxCaption.Name = "lblTaxCaption";
            this.lblTaxCaption.Size = new System.Drawing.Size(72, 13);
            this.lblTaxCaption.TabIndex = 2;
            this.lblTaxCaption.Text = "Tax (on parts)";
            // 
            // lblPartsSummaryCaption
            // 
            this.lblPartsSummaryCaption.AutoSize = true;
            this.lblPartsSummaryCaption.Location = new System.Drawing.Point(81, 55);
            this.lblPartsSummaryCaption.Name = "lblPartsSummaryCaption";
            this.lblPartsSummaryCaption.Size = new System.Drawing.Size(31, 13);
            this.lblPartsSummaryCaption.TabIndex = 1;
            this.lblPartsSummaryCaption.Text = "Parts";
            // 
            // lblServicesCaption
            // 
            this.lblServicesCaption.AutoSize = true;
            this.lblServicesCaption.Location = new System.Drawing.Point(25, 27);
            this.lblServicesCaption.Name = "lblServicesCaption";
            this.lblServicesCaption.Size = new System.Drawing.Size(87, 13);
            this.lblServicesCaption.TabIndex = 0;
            this.lblServicesCaption.Text = "Services && Labor";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(29, 378);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 35);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate Total";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(251, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 425);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPartsAndLabor);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpFlushes);
            this.Controls.Add(this.grpOilLube);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.grpOilLube.ResumeLayout(false);
            this.grpOilLube.PerformLayout();
            this.grpFlushes.ResumeLayout(false);
            this.grpFlushes.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.grpPartsAndLabor.ResumeLayout(false);
            this.grpPartsAndLabor.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOilLube;
        private System.Windows.Forms.CheckBox cbLubeJob;
        private System.Windows.Forms.CheckBox cbOilChange;
        private System.Windows.Forms.GroupBox grpFlushes;
        private System.Windows.Forms.CheckBox cbTransmissionFlush;
        private System.Windows.Forms.CheckBox cbRadiatorFlush;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.CheckBox cbTireRotation;
        private System.Windows.Forms.CheckBox cbReplaceMuffler;
        private System.Windows.Forms.CheckBox cbInspection;
        private System.Windows.Forms.GroupBox grpPartsAndLabor;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTaxCaption;
        private System.Windows.Forms.Label lblPartsSummaryCaption;
        private System.Windows.Forms.Label lblServicesCaption;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}