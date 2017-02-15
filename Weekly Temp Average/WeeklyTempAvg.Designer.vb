<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyTempAvg
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
        Me.TemperatureOneInput = New System.Windows.Forms.TextBox()
        Me.TemperatureTwoInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TemperatureThreeInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TemperatureFourInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TemperatureFiveInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AverageTemperatureOutput = New System.Windows.Forms.Label()
        Me.CalcAvgButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week #1"
        '
        'TemperatureOneInput
        '
        Me.TemperatureOneInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureOneInput.Location = New System.Drawing.Point(153, 40)
        Me.TemperatureOneInput.Name = "TemperatureOneInput"
        Me.TemperatureOneInput.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureOneInput.TabIndex = 1
        '
        'TemperatureTwoInput
        '
        Me.TemperatureTwoInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureTwoInput.Location = New System.Drawing.Point(153, 68)
        Me.TemperatureTwoInput.Name = "TemperatureTwoInput"
        Me.TemperatureTwoInput.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureTwoInput.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week #2"
        '
        'TemperatureThreeInput
        '
        Me.TemperatureThreeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureThreeInput.Location = New System.Drawing.Point(153, 96)
        Me.TemperatureThreeInput.Name = "TemperatureThreeInput"
        Me.TemperatureThreeInput.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureThreeInput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Week #3"
        '
        'TemperatureFourInput
        '
        Me.TemperatureFourInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureFourInput.Location = New System.Drawing.Point(153, 124)
        Me.TemperatureFourInput.Name = "TemperatureFourInput"
        Me.TemperatureFourInput.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureFourInput.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Week #4"
        '
        'TemperatureFiveInput
        '
        Me.TemperatureFiveInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureFiveInput.Location = New System.Drawing.Point(153, 152)
        Me.TemperatureFiveInput.Name = "TemperatureFiveInput"
        Me.TemperatureFiveInput.Size = New System.Drawing.Size(100, 22)
        Me.TemperatureFiveInput.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Week #5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average"
        '
        'AverageTemperatureOutput
        '
        Me.AverageTemperatureOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AverageTemperatureOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageTemperatureOutput.Location = New System.Drawing.Point(153, 189)
        Me.AverageTemperatureOutput.Name = "AverageTemperatureOutput"
        Me.AverageTemperatureOutput.Size = New System.Drawing.Size(100, 23)
        Me.AverageTemperatureOutput.TabIndex = 11
        '
        'CalcAvgButton
        '
        Me.CalcAvgButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcAvgButton.Location = New System.Drawing.Point(14, 249)
        Me.CalcAvgButton.Name = "CalcAvgButton"
        Me.CalcAvgButton.Size = New System.Drawing.Size(90, 30)
        Me.CalcAvgButton.TabIndex = 12
        Me.CalcAvgButton.Text = "Calculate"
        Me.CalcAvgButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(127, 249)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 30)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Cl&ear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(240, 249)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(90, 30)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 291)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(342, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 17)
        '
        'WeeklyTempAvg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 313)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcAvgButton)
        Me.Controls.Add(Me.AverageTemperatureOutput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TemperatureFiveInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TemperatureFourInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TemperatureThreeInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TemperatureTwoInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TemperatureOneInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WeeklyTempAvg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Temperature Average"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TemperatureOneInput As System.Windows.Forms.TextBox
    Friend WithEvents TemperatureTwoInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TemperatureThreeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TemperatureFourInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TemperatureFiveInput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AverageTemperatureOutput As System.Windows.Forms.Label
    Friend WithEvents CalcAvgButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel

End Class
