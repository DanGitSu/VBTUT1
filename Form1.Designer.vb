<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddValue1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddValue2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDivide2 = New System.Windows.Forms.TextBox()
        Me.btnDivideValues = New System.Windows.Forms.Button()
        Me.txtDivide1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(21, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 23)
        Me.txtName.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(21, 68)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(124, 68)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(75, 23)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "&Message"
        Me.txtMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(231, 68)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddValue1
        '
        Me.txtAddValue1.Location = New System.Drawing.Point(21, 115)
        Me.txtAddValue1.Name = "txtAddValue1"
        Me.txtAddValue1.Size = New System.Drawing.Size(55, 23)
        Me.txtAddValue1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(87, 115)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(23, 23)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddValue2
        '
        Me.txtAddValue2.Location = New System.Drawing.Point(127, 115)
        Me.txtAddValue2.Name = "txtAddValue2"
        Me.txtAddValue2.Size = New System.Drawing.Size(55, 23)
        Me.txtAddValue2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(197, 119)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(15, 15)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(221, 115)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(55, 23)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivAnswer
        '
        Me.txtDivAnswer.Location = New System.Drawing.Point(221, 169)
        Me.txtDivAnswer.Name = "txtDivAnswer"
        Me.txtDivAnswer.Size = New System.Drawing.Size(55, 23)
        Me.txtDivAnswer.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "="
        '
        'txtDivide2
        '
        Me.txtDivide2.Location = New System.Drawing.Point(127, 169)
        Me.txtDivide2.Name = "txtDivide2"
        Me.txtDivide2.Size = New System.Drawing.Size(55, 23)
        Me.txtDivide2.TabIndex = 12
        '
        'btnDivideValues
        '
        Me.btnDivideValues.Location = New System.Drawing.Point(87, 169)
        Me.btnDivideValues.Name = "btnDivideValues"
        Me.btnDivideValues.Size = New System.Drawing.Size(23, 23)
        Me.btnDivideValues.TabIndex = 11
        Me.btnDivideValues.Text = "/"
        Me.btnDivideValues.UseVisualStyleBackColor = True
        '
        'txtDivide1
        '
        Me.txtDivide1.Location = New System.Drawing.Point(21, 169)
        Me.txtDivide1.Name = "txtDivide1"
        Me.txtDivide1.Size = New System.Drawing.Size(55, 23)
        Me.txtDivide1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 402)
        Me.Controls.Add(Me.txtDivAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDivide2)
        Me.Controls.Add(Me.btnDivideValues)
        Me.Controls.Add(Me.txtDivide1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddValue2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtAddValue1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents txtMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddValue1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddValue2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDivide2 As TextBox
    Friend WithEvents btnDivideValues As Button
    Friend WithEvents txtDivide1 As TextBox
End Class
