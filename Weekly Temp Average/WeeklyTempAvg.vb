Public Class WeeklyTempAvg


    Private Sub CalcAvgButton_Click(sender As Object, e As EventArgs) Handles CalcAvgButton.Click
        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPS As Integer = 5

        ' Declare the variables
        Dim WeekTempOne As Single = 0.0
        Dim WeekTempTwo As Single = 0.0
        Dim WeekTempThree As Single = 0.0
        Dim WeekTempFour As Single = 0.0
        Dim WeekTempFive As Single = 0.0
        Dim WeekAverageTemp As Single = 0.0

        ' convert inputs to double
        If Single.TryParse(TempOneInput.Text, WeekTempOne) Then
            If Single.TryParse(TempTwoInput.Text, WeekTempTwo) Then
                If Single.TryParse(TempThreeInput.Text, WeekTempThree) Then
                    If Single.TryParse(TempFourInput.Text, WeekTempFour) Then
                        If Single.TryParse(TempFiveInput.Text, WeekTempFive) Then
                            ' calculate the average Temp
                            WeekAverageTemp = (WeekTempOne + WeekTempTwo + WeekTempThree + WeekTempFour + WeekTempFive) / NUMBER_OF_TEMPS
                            ' display the result
                            AverageTempOutput.Text = Convert.ToString(WeekAverageTemp)
                            Status.Text = String.Empty ' clear any error in the status bar
                        Else
                            TempFiveInput.Focus()
                            TempFiveInput.SelectionStart = 0
                            TempFiveInput.SelectionLength = TempFiveInput.Text.Length
                            Status.Text = "You must enter a numeric value in week #5"
                        End If
                    Else
                        TempFourInput.Focus()
                        TempFourInput.SelectionStart = 0
                        TempFourInput.SelectionLength = TempFourInput.Text.Length
                        Status.Text = "You must enter a numeric value in week #4"
                    End If
                Else
                    TempThreeInput.Focus()
                    TempThreeInput.SelectionStart = 0
                    TempThreeInput.SelectionLength = TempThreeInput.Text.Length
                    Status.Text = "You must enter a numeric value in week #3"
                End If
            Else
                TempTwoInput.Focus()
                TempTwoInput.SelectionStart = 0
                TempTwoInput.SelectionLength = TempTwoInput.Text.Length
                Status.Text = "You must enter a numeric value in Week #2"
            End If
        Else
            TempOneInput.Focus()
            TempOneInput.SelectionStart = 0
            TempOneInput.SelectionLength = TempOneInput.Text.Length
            Status.Text = "You must enter a numeric value in Week #1"
        End If
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
