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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTempOne = New System.Windows.Forms.TextBox()
        Me.txtTempTwo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTempThree = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTempFour = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTempFive = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAverageTemp = New System.Windows.Forms.Label()
        Me.btnCalcAvg = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week #1"
        '
        'txtTempOne
        '
        Me.txtTempOne.Location = New System.Drawing.Point(121, 18)
        Me.txtTempOne.Name = "txtTempOne"
        Me.txtTempOne.Size = New System.Drawing.Size(100, 20)
        Me.txtTempOne.TabIndex = 1
        '
        'txtTempTwo
        '
        Me.txtTempTwo.Location = New System.Drawing.Point(121, 44)
        Me.txtTempTwo.Name = "txtTempTwo"
        Me.txtTempTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtTempTwo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week #2"
        '
        'txtTempThree
        '
        Me.txtTempThree.Location = New System.Drawing.Point(121, 70)
        Me.txtTempThree.Name = "txtTempThree"
        Me.txtTempThree.Size = New System.Drawing.Size(100, 20)
        Me.txtTempThree.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Week #3"
        '
        'txtTempFour
        '
        Me.txtTempFour.Location = New System.Drawing.Point(121, 96)
        Me.txtTempFour.Name = "txtTempFour"
        Me.txtTempFour.Size = New System.Drawing.Size(100, 20)
        Me.txtTempFour.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Week #4"
        '
        'txtTempFive
        '
        Me.txtTempFive.Location = New System.Drawing.Point(121, 122)
        Me.txtTempFive.Name = "txtTempFive"
        Me.txtTempFive.Size = New System.Drawing.Size(100, 20)
        Me.txtTempFive.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Week #5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average"
        '
        'lblAverageTemp
        '
        Me.lblAverageTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTemp.Location = New System.Drawing.Point(121, 158)
        Me.lblAverageTemp.Name = "lblAverageTemp"
        Me.lblAverageTemp.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageTemp.TabIndex = 11
        '
        'btnCalcAvg
        '
        Me.btnCalcAvg.Location = New System.Drawing.Point(15, 208)
        Me.btnCalcAvg.Name = "btnCalcAvg"
        Me.btnCalcAvg.Size = New System.Drawing.Size(75, 41)
        Me.btnCalcAvg.TabIndex = 12
        Me.btnCalcAvg.Text = "Calculate Average"
        Me.btnCalcAvg.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 255)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 277)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcAvg)
        Me.Controls.Add(Me.lblAverageTemp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTempFive)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTempFour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTempThree)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTempTwo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTempOne)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Temperature Average"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTempOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTempTwo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTempThree As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTempFour As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTempFive As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAverageTemp As System.Windows.Forms.Label
    Friend WithEvents btnCalcAvg As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
