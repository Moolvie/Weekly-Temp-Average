Public Class WeeklyTempAvg


    Private Sub CalcAvgButton_Click(sender As Object, e As EventArgs) Handles CalcAvgButton.Click
        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPS As Integer = 5
        Try
            ' Declare the variables
            Dim WeekTempOne As Single = 0.0
            Dim WeekTempTwo As Single = 0.0
            Dim WeekTempThree As Single = 0.0
            Dim WeekTempFour As Single = 0.0
            Dim WeekTempFive As Single = 0.0
            Dim WeekAverageTemp As Single = 0.0

            ' convert inputs to double
            WeekTempOne = Convert.ToSingle(TempOneInput.Text)
            WeekTempTwo = Convert.ToSingle(TempTwoInput.Text)
            WeekTempThree = Convert.ToSingle(TempThreeInput.Text)
            WeekTempFour = Convert.ToSingle(TempFourInput.Text)
            WeekTempFive = Convert.ToSingle(TempFiveInput.Text)

            ' calculate the average Temp
            WeekAverageTemp = (WeekTempOne + WeekTempTwo + WeekTempThree + WeekTempFour + WeekTempFive) / NUMBER_OF_TEMPS

            ' display the result
            AverageTempOutput.Text = Convert.ToString(WeekAverageTemp)
            Status.Text = String.Empty ' clear any error in the status bar
        Catch
            Status.Text = "You must enter numeric values for each week"
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' clear all the text boxes for another set of Weekly temps
        TempOneInput.Clear()
        TempTwoInput.Clear()
        TempThreeInput.Clear()
        TempFourInput.Clear()
        TempFiveInput.Clear()
        Status.Text = String.Empty ' clear any error in the status bar
        AverageTempOutput.Text = String.Empty

        ' set focus to the first Weekly Temp after clearing the form
        TempOneInput.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' put the focus in the Week one tempurature text box when loading the form
        TempOneInput.Focus()
    End Sub
End Class
