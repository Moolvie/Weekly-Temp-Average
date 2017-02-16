Public Class WeeklyTempAvg
    Private Sub CalcAvgButton_Click(sender As Object, e As EventArgs) Handles CalcAvgButton.Click
        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPERATURES As Integer = 5
        ' Declare the constant for low limit
        Const LOW_LIMIT As Single = -50.0
        ' Declare the constant for high limit
        Const HIGH_LIMIT As Single = 130.0


        ' Declare the variables
        Dim WeekTemperatureOne As Single = 0.0
        Dim WeekTemperatureTwo As Single = 0.0
        Dim WeekTemperatureThree As Single = 0.0
        Dim WeekTemperatureFour As Single = 0.0
        Dim WeekTemperatureFive As Single = 0.0
        Dim WeekAverageTemperature As Single = 0.0

        ' define myError for each week
        Dim myError1 As Boolean = False
        Dim myError2 As Boolean = False
        Dim myError3 As Boolean = False
        Dim myError4 As Boolean = False
        Dim myError5 As Boolean = False

        ' call the function for each week
        myError1 = ValidateInput(TemperatureOneInput, WeekTemperatureOne, HIGH_LIMIT, LOW_LIMIT, WeekAverageTemperature)
        myError2 = ValidateInput(TemperatureTwoInput, WeekTemperatureTwo, HIGH_LIMIT, LOW_LIMIT, WeekAverageTemperature)
        myError3 = ValidateInput(TemperatureThreeInput, WeekTemperatureThree, HIGH_LIMIT, LOW_LIMIT, WeekAverageTemperature)
        myError4 = ValidateInput(TemperatureFourInput, WeekTemperatureFour, HIGH_LIMIT, LOW_LIMIT, WeekAverageTemperature)
        myError5 = ValidateInput(TemperatureFiveInput, WeekTemperatureFive, HIGH_LIMIT, LOW_LIMIT, WeekAverageTemperature)

        If Not myError1 And Not myError2 And Not myError3 And Not myError4 And Not myError5 Then
            WeekAverageTemperature = WeekAverageTemperature / NUMBER_OF_TEMPERATURES
            AverageTemperatureOutput.Text = WeekAverageTemperature.ToString()
        End If

    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' clear all the text boxes for another set of Weekly temps
        TemperatureOneInput.Clear()
        TemperatureTwoInput.Clear()
        TemperatureThreeInput.Clear()
        TemperatureFourInput.Clear()
        TemperatureFiveInput.Clear()

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

    Private Function ValidateInput(ByVal inputTemperature As TextBox, ByVal ThisWeeksTemperature As Single, ByVal high As Single, ByVal low As Single, ByRef WeekAverageTemperature As Single) As Boolean

        ' Clear previous errors
        ErrorProvider1.SetError(inputTemperature, String.Empty)
        ' set return value to false
        Dim foundError As Boolean = False

        ' validate input, must be a number between -50 and 130
        If Single.TryParse(inputTemperature.Text, ThisWeeksTemperature) Then
            If ThisWeeksTemperature < low Or ThisWeeksTemperature > high Then
                ErrorProvider1.SetError(inputTemperature, "Temperture must be between" + low.ToString() + " and " + high.ToString() + ".")
                inputTemperature.Focus()
                inputTemperature.SelectionStart = 0
                inputTemperature.SelectionLength = TemperatureOneInput.Text.Length
                foundError = True
                Return foundError ' return an error if not in range
            Else
                ' input is correct so add to accumulator
                WeekAverageTemperature = WeekAverageTemperature + ThisWeeksTemperature
            End If ' end inner if
        Else
            ErrorProvider1.SetError(inputTemperature, "You must input a numeric value.")
            foundError = True
            Return foundError ' return an error if not a number
        End If 'end outer if
    End Function
End Class
