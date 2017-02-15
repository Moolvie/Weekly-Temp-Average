Public Class WeeklyTempAvg


    Private Sub CalcAvgButton_Click(sender As Object, e As EventArgs) Handles CalcAvgButton.Click
        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPERATURES As Integer = 5

        ' Declare the variables
        Dim WeekTemperatureOne As Single = 0.0
        Dim WeekTemperatureTwo As Single = 0.0
        Dim WeekTemperatureThree As Single = 0.0
        Dim WeekTemperatureFour As Single = 0.0
        Dim WeekTemperatureFive As Single = 0.0
        Dim WeekAverageTemperature As Single = 0.0

        ' convert inputs to double
        If Single.TryParse(TemperatureOneInput.Text, WeekTemperatureOne) Then
            If WeekTemperatureOne < -50 Or WeekTemperatureOne > 130 Then
                Status.Text = "Temperature out of range in Week #1"
                TemperatureOneInput.Focus()
                TemperatureOneInput.SelectionStart = 0
                TemperatureOneInput.SelectionLength = TemperatureOneInput.Text.Length
            Else
                WeekAverageTemperature = WeekAverageTemperature + WeekTemperatureOne
                Status.Text = String.Empty ' clear any error in the status bar
                ' week two start
                If Single.TryParse(TemperatureTwoInput.Text, WeekTemperatureTwo) Then
                    If WeekTemperatureTwo < -50 Or WeekTemperatureTwo > 130 Then
                        Status.Text = "Temperature out of range in Week #2"
                        TemperatureTwoInput.Focus()
                        TemperatureTwoInput.SelectionStart = 0
                        TemperatureTwoInput.SelectionLength = TemperatureTwoInput.Text.Length
                    Else
                        WeekAverageTemperature = WeekAverageTemperature + WeekTemperatureTwo
                        Status.Text = String.Empty ' clear any error in the status bar
                        'week three start
                        If Single.TryParse(TemperatureThreeInput.Text, WeekTemperatureThree) Then
                            If WeekTemperatureThree < -50 Or WeekTemperatureThree > 130 Then
                                Status.Text = "Temperature out of range in Week #3"
                                TemperatureThreeInput.Focus()
                                TemperatureThreeInput.SelectionStart = 0
                                TemperatureThreeInput.SelectionLength = TemperatureThreeInput.Text.Length
                            Else
                                WeekAverageTemperature = WeekAverageTemperature + WeekTemperatureThree
                                Status.Text = String.Empty ' clear any error in the status bar
                                'week four start
                                If Single.TryParse(TemperatureFourInput.Text, WeekTemperatureFour) Then
                                    If WeekTemperatureFour < -50 Or WeekTemperatureFour > 130 Then
                                        Status.Text = "Temperature out of range in Week #1"
                                        TemperatureFourInput.Focus()
                                        TemperatureFourInput.SelectionStart = 0
                                        TemperatureFourInput.SelectionLength = TemperatureFourInput.Text.Length
                                    Else
                                        WeekAverageTemperature = WeekAverageTemperature + WeekTemperatureFour
                                        Status.Text = String.Empty ' clear any error in the status bar
                                        'week five start
                                        If Single.TryParse(TemperatureFiveInput.Text, WeekTemperatureFive) Then
                                            If WeekTemperatureFive < -50 Or WeekTemperatureFive > 130 Then
                                                Status.Text = "Temperature out of range in Week #5"
                                                TemperatureFiveInput.Focus()
                                                TemperatureFiveInput.SelectionStart = 0
                                                TemperatureFiveInput.SelectionLength = TemperatureFiveInput.Text.Length
                                            Else
                                                WeekAverageTemperature = WeekAverageTemperature + WeekTemperatureFive
                                                Status.Text = String.Empty ' clear any error in the status bar
                                                ' calculate average
                                                WeekAverageTemperature = WeekAverageTemperature / NUMBER_OF_TEMPERATURES
                                                ' display result
                                                AverageTemperatureOutput.Text = Convert.ToString(WeekAverageTemperature)
                                            End If ' week five range end

                                        Else
                                            TemperatureFiveInput.Focus()
                                            TemperatureFiveInput.SelectionStart = 0
                                            TemperatureFiveInput.SelectionLength = TemperatureFiveInput.Text.Length
                                            Status.Text = "You must enter a numeric value in Week #5"


                                        End If ' end of week 5
                                    End If ' week four range end

                                Else
                                    TemperatureFourInput.Focus()
                                    TemperatureFourInput.SelectionStart = 0
                                    TemperatureFourInput.SelectionLength = TemperatureFourInput.Text.Length
                                    Status.Text = "You must enter a numeric value in Week #4"


                                End If ' end of week 4
                            End If ' week three range end

                        Else
                            TemperatureThreeInput.Focus()
                            TemperatureThreeInput.SelectionStart = 0
                            TemperatureThreeInput.SelectionLength = TemperatureThreeInput.Text.Length
                            Status.Text = "You must enter a numeric value in Week #3"


                        End If ' end of week 3
                    End If ' week two range end

                Else
                    TemperatureTwoInput.Focus()
                    TemperatureTwoInput.SelectionStart = 0
                    TemperatureTwoInput.SelectionLength = TemperatureTwoInput.Text.Length
                    Status.Text = "You must enter a numeric value in Week #2"


                End If ' end of week 2

            End If ' week one range end

        Else
                TemperatureOneInput.Focus()
                TemperatureOneInput.SelectionStart = 0
                TemperatureOneInput.SelectionLength = TemperatureOneInput.Text.Length
                Status.Text = "You must enter a numeric value in Week #1"


        End If ' end of week 1





    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' clear all the text boxes for another set of Weekly temps
        TemperatureOneInput.Clear()
        TemperatureTwoInput.Clear()
        TemperatureThreeInput.Clear()
        TemperatureFourInput.Clear()
        TemperatureFiveInput.Clear()
        Status.Text = String.Empty ' clear any error in the status bar
        AverageTemperatureOutput.Text = String.Empty

        ' set focus to the first Weekly Temp after clearing the form
        TemperatureOneInput.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' put the focus in the Week one temperature text box when loading the form
        TemperatureOneInput.Focus()
    End Sub
End Class
