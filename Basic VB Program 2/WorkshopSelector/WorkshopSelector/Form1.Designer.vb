<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpWorkshop = New System.Windows.Forms.GroupBox()
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.grpCosts = New System.Windows.Forms.GroupBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpWorkshop.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWorkshop
        '
        Me.grpWorkshop.Controls.Add(Me.lstWorkshop)
        Me.grpWorkshop.Location = New System.Drawing.Point(14, 29)
        Me.grpWorkshop.Name = "grpWorkshop"
        Me.grpWorkshop.Size = New System.Drawing.Size(164, 143)
        Me.grpWorkshop.TabIndex = 0
        Me.grpWorkshop.TabStop = False
        Me.grpWorkshop.Text = "Pick a Worshop"
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.ItemHeight = 15
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(7, 22)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(150, 109)
        Me.lstWorkshop.TabIndex = 0
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lstLocation)
        Me.grpLocation.Location = New System.Drawing.Point(209, 29)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(168, 143)
        Me.grpLocation.TabIndex = 1
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Pick a location"
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.ItemHeight = 15
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(9, 22)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(150, 109)
        Me.lstLocation.TabIndex = 0
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lstCosts)
        Me.grpCosts.Location = New System.Drawing.Point(409, 29)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(163, 143)
        Me.grpCosts.TabIndex = 2
        Me.grpCosts.TabStop = False
        Me.grpCosts.Text = "List of Costs"
        '
        'lstCosts
        '
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.ItemHeight = 15
        Me.lstCosts.Location = New System.Drawing.Point(6, 20)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(150, 109)
        Me.lstCosts.TabIndex = 3
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(179, 219)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(61, 15)
        Me.lblTotalCostLabel.TabIndex = 3
        Me.lblTotalCostLabel.Text = "Total Cost"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(256, 218)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalCost.TabIndex = 4
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(21, 295)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(100, 25)
        Me.btnAddWorkshop.TabIndex = 5
        Me.btnAddWorkshop.Text = "Add Workshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(168, 295)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(100, 25)
        Me.btnCalculateTotal.TabIndex = 6
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(316, 295)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 25)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Rest"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 358)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.grpCosts)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpWorkshop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.grpWorkshop.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpWorkshop As GroupBox
    Friend WithEvents lstWorkshop As ListBox
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents lstLocation As ListBox
    Friend WithEvents grpCosts As GroupBox
    Friend WithEvents lstCosts As ListBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnAddWorkshop As Button
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class