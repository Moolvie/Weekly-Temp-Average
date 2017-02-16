Public Class WeeklyTempAvg
    Private Sub CalcAvgButton_Click(sender As Object, e As EventArgs) Handles CalcAvgButton.Click

        ' Declare the constant for averaging. we are averaging five weekly temperatures
        Const NUMBER_OF_TEMPERATURES As Integer = 5

        ' Declare the constant for low limit of the temperature
        Const LOW_LIMIT As Single = -50.0

        ' Declare the constant for high limit
        Const HIGH_LIMIT As Single = 130.0


        ' Declare the variables
        Dim WeekTemperatureOne As Single = 0.0
        Dim WeekTemperatureTwo As Single = 0.0
        Dim WeekTemperatureThree As Single = 0.0
        Dim WeekTemperatureFour As Single = 0.0
        Dim WeekTemperatureFive As Single = 0.0

        Dim WeekAverageTemperature As Single = 0.0 ' an accumulator for the weekly temperatures

        ' define inputError for each week
        Dim inputError1 As Boolean = False
        Dim inputError2 As Boolean = False
        Dim inputError3 As Boolean = False
        Dim inputError4 As Boolean = False
        Dim inputError5 As Boolean = False

        ' call the function for each week
        inputError1 = ValidateInput(TemperatureOneInput, WeekTemperatureOne, HIGH_LIMIT, LOW_LIMIT)
        inputError2 = ValidateInput(TemperatureTwoInput, WeekTemperatureTwo, HIGH_LIMIT, LOW_LIMIT)
        inputError3 = ValidateInput(TemperatureThreeInput, WeekTemperatureThree, HIGH_LIMIT, LOW_LIMIT)
        inputError4 = ValidateInput(TemperatureFourInput, WeekTemperatureFour, HIGH_LIMIT, LOW_LIMIT)
        inputError5 = ValidateInput(TemperatureFiveInput, WeekTemperatureFive, HIGH_LIMIT, LOW_LIMIT)

        ' if we find an error in any of the inputs do not output an average
        If Not inputError1 And Not inputError2 And Not inputError3 And Not inputError4 And Not inputError5 Then
            WeekAverageTemperature = WeekTemperatureOne + WeekTemperatureTwo + WeekTemperatureThree + WeekTemperatureFour + WeekTemperatureFive
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

    Function ValidateInput(ByVal inputText As TextBox, ByRef InputNumber As Single, ByVal HIGH As Single, ByVal LOW As Single) As Boolean
        ' This function validates the value entered into a textbox.
        ' The value must be an single precision floating point number between the range of LOW and HIGH
        ' if the value is not, an error icon with message is displayed next to the input box, alerting the user 
        ' that the value is incorrect and in what manner, non-numeric or out of range.
        ' The function expects the name of the textbox, the variable in which the number will be stored, The LOW limit,
        ' and the HIGH limit.
        '
        ' if the value is correct it is stored in the variable passed by reference and the function returns true.
        ' otherwise the function returns false.

        ' Clear previous errors
        ErrorProvider1.SetError(inputText, String.Empty)

        ' set return value to false
        Dim foundError As Boolean = False

        ' validate input, must be a number between LOW and HIGH
        If Single.TryParse(inputText.Text, InputNumber) Then
            If InputNumber < LOW Or InputNumber > HIGH Then
                ErrorProvider1.SetError(inputText, "Value must be between" + LOW.ToString() + " and " + HIGH.ToString() + ".")
                ' if we are here we found an error
                foundError = True
                Return foundError ' return an error if not in range
            End If ' end inner if
        Else
            ErrorProvider1.SetError(inputText, "You must input a numeric value.")
            foundError = True
            Return foundError ' return an error if not a number
        End If 'end outer if
        ' we get here it is all good and we didn't find anything(actually I don't think we can get here)
        Return foundError
    End Function
End Class
