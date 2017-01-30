Public Class Form1

   
    Private Sub btnCalcAvg_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click
        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPS As Integer = 5
        Try
            ' Declare the variables
            Dim dblTempOne As Double = 0.0
            Dim dblTempTwo As Double = 0.0
            Dim dblTempThree As Double = 0.0
            Dim dblTempFour As Double = 0.0
            Dim dblTempFive As Double = 0.0
            Dim AverageTemp As Double = 0.0

            ' convert inputs to double
            dblTempOne = CDbl(txtTempOne.Text)
            dblTempTwo = CDbl(txtTempTwo.Text)
            dblTempThree = CDbl(txtTempThree.Text)
            dblTempFour = CDbl(txtTempFour.Text)
            dblTempFive = CDbl(txtTempFive.Text)

            ' calculate the average Temp
            AverageTemp = (dblTempOne + dblTempTwo + dblTempThree + dblTempFour + dblTempFive) / NUMBER_OF_TEMPS

            ' display the result
            lblAverageTemp.Text = CStr(AverageTemp)
        Catch
            lblStatus.Text = "You must enter numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all the text boxes for another set of Weekly temps
        txtTempOne.Clear()
        txtTempTwo.Clear()
        txtTempThree.Clear()
        txtTempFour.Clear()
        txtTempFive.Clear()

        lblAverageTemp.Text = String.Empty

        ' set focus to the first Weekly Temp
        txtTempOne.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTempOne.Focus()
    End Sub
End Class
