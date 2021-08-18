<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMotor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.MaskedTextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.IdNumber = New System.Windows.Forms.NumericUpDown()
        Me.txtRPM = New System.Windows.Forms.NumericUpDown()
        Me.txtVoltage = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IdNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVoltage)
        Me.GroupBox1.Controls.Add(Me.txtRPM)
        Me.GroupBox1.Controls.Add(Me.IdNumber)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motor Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Voltage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RPM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motor ID:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 243)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(114, 243)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(116, 65)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 11
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ON: Motor is online and running.", "OFF: Motor is online but not running.", "MNT: Motor is undergoing maintenance and cleaning.", "NA: Motor is not available."})
        Me.cmbStatus.Location = New System.Drawing.Point(116, 147)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(100, 21)
        Me.cmbStatus.TabIndex = 15
        '
        'IdNumber
        '
        Me.IdNumber.Location = New System.Drawing.Point(116, 36)
        Me.IdNumber.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.IdNumber.Minimum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.IdNumber.Name = "IdNumber"
        Me.IdNumber.Size = New System.Drawing.Size(100, 20)
        Me.IdNumber.TabIndex = 16
        Me.IdNumber.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'txtRPM
        '
        Me.txtRPM.Location = New System.Drawing.Point(116, 91)
        Me.txtRPM.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtRPM.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtRPM.Name = "txtRPM"
        Me.txtRPM.Size = New System.Drawing.Size(100, 20)
        Me.txtRPM.TabIndex = 17
        Me.txtRPM.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(116, 121)
        Me.txtVoltage.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtVoltage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(100, 20)
        Me.txtVoltage.TabIndex = 18
        Me.txtVoltage.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AddMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 299)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddMotor"
        Me.Text = "Add Motor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IdNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDescription As MaskedTextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents IdNumber As NumericUpDown
    Friend WithEvents txtRPM As NumericUpDown
    Friend WithEvents txtVoltage As NumericUpDown
End Class
