Option Strict On
Option Explicit On



'TODO List
'[x] Set Default Values
'[x] Track Values from values text boxes
'[x] Do not allow the user to calculate before filling all the required values with valid values
'[x] Highlight all invalid values
'[x] Set Capacitance Settings
'[x] Set Inductance Settings
'[x] Set Frequency Settings
'[x] Set Resistance Settings
'[x] Calculate for current in total, for branches and components
'[x] Calculate for voltage for each branch and individual components
'[x] Calculate the reactance for each reactive component
'[x] Calculate the impedance for each branch and in total
'[ ] Display all calculated values in a list box
'[ ] Display correct j signs for real values
'[ ] Display impedance values with the correct resistance setting

Public Class SeriesParallelCalculator

    Dim vgenValue As Double
    Dim frequencyValue As Double
    Dim c1Value As Double
    Dim c2Value As Double
    Dim r1Value As Double
    Dim r2Value As Double
    Dim r3Value As Double
    Dim l1Value As Double
    Dim rwValue As Double
    Dim ztotalreal As Double
    Dim ztotalimg As Double
    Dim ztotalpol As Double
    Dim ztotalangle As Double
    Dim zseriesreal As Double
    Dim zseriesimg As Double
    Dim zseriespol As Double
    Dim zseriesangle As Double
    Dim zparallelreal As Double
    Dim zparallelimg As Double
    Dim zparallelpol As Double
    Dim zparallelangle As Double
    Dim zb1real As Double
    Dim zb1img As Double
    Dim zb1pol As Double
    Dim zb1angle As Double
    Dim zb2real As Double
    Dim zb2img As Double
    Dim zb2pol As Double
    Dim zb2angle As Double
    Dim c1valueangle As Double = -90
    Dim r1valueangle As Double = 0
    Dim l1valueangle As Double = 90
    Dim rwvalueangle As Double = 0
    Dim r2valueangle As Double = 0
    Dim c2valueangle As Double = -90
    Dim r3valueangle As Double = 0
    Dim xc1Result As Double
    Dim xc2Result As Double
    Dim xl1Result As Double
    Dim itotalResult As Double
    Dim ib1Result As Double
    Dim ib2Result As Double
    Dim ic1Result As Double
    Dim ir1Result As Double
    Dim ir2Result As Double
    Dim il1Result As Double
    Dim ic2Result As Double
    Dim ir3Result As Double
    Dim vparallel As Double
    Dim vc1Result As Double
    Dim vr1Result As Double
    Dim vl1Result As Double
    Dim vr2Result As Double
    Dim vc2Result As Double
    Dim vr3Result As Double
    Dim message As String

    Sub SetDefaults()

        VgenTextBox.Text = ""
        FrequencyTextBox.Text = ""
        C1TextBox.Text = ""
        C2TextBox.Text = ""
        R1TextBox.Text = ""
        R2TextBox.Text = ""
        R3TextBox.Text = ""
        L1TextBox.Text = ""
        RwTextBox.Text = ""
        ResultsListBox.Items.Clear()

    End Sub
    Function VgenValidation() As Boolean

        Try
            vgenValue = CDbl(VgenTextBox.Text)

            Select Case vgenValue
                Case = 0
                    VgenTextBox.BackColor = Color.LightYellow
                    message &= "Valid Vgen Value is Required" & vbNewLine
                    Return False
                Case Else
                    VgenTextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            VgenTextBox.BackColor = Color.LightYellow
            message &= "Valid Vgen Value is Required" & vbNewLine
            Return False
        End Try


    End Function
    Function FrequencyValidation() As Boolean

        Try
            frequencyValue = CDbl(FrequencyTextBox.Text)

            Select Case vgenValue
                Case <= 0
                    FrequencyTextBox.BackColor = Color.LightYellow
                    message &= "Valid Frequency Value is Required" & vbNewLine
                    Return False
                Case Else
                    FrequencyTextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            FrequencyTextBox.BackColor = Color.LightYellow
            message &= "Valid Frequency Value is Required" & vbNewLine
            Return False
        End Try
    End Function
    Function C1Validation() As Boolean

        Try
            c1Value = CDbl(C1TextBox.Text)

            Select Case c1Value
                Case <= 0
                    C1TextBox.BackColor = Color.LightYellow
                    message &= "Valid capacitance value for C1 is Required" & vbNewLine
                    Return False
                Case Else
                    C1TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            C1TextBox.BackColor = Color.LightYellow
            message &= "Valid capacitance for C1 Value is Required" & vbNewLine
            Return False
        End Try

    End Function
    Function R1Validation() As Boolean

        Try
            r1Value = CDbl(R1TextBox.Text)

            Select Case r1Value
                Case <= 0
                    R1TextBox.BackColor = Color.LightYellow
                    message &= "Valid resistance value for R1 is Required" & vbNewLine
                    Return False
                Case Else
                    R1TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            R1TextBox.BackColor = Color.LightYellow
            message &= "Valid resistance value for R1 is Required" & vbNewLine
            Return False
        End Try

    End Function
    Function L1Validation() As Boolean

        Try
            l1Value = CDbl(L1TextBox.Text)

            Select Case l1Value
                Case <= 0
                    L1TextBox.BackColor = Color.LightYellow
                    message &= "Valid inductance value for L1 is Required" & vbNewLine
                    Return False
                Case Else
                    L1TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            L1TextBox.BackColor = Color.LightYellow
            message &= "Valid inductance value for L1 is Required" & vbNewLine
            Return False
        End Try
    End Function

    Function R2Validation() As Boolean

        Try
            r2Value = CDbl(R2TextBox.Text)

            Select Case r2Value
                Case <= 0
                    R2TextBox.BackColor = Color.LightYellow
                    message &= "Valid resistance value for R2 is Required" & vbNewLine
                    Return False
                Case Else
                    R2TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            R2TextBox.BackColor = Color.LightYellow
            message &= "Valid resistance value for R2 is Required" & vbNewLine
            Return False
        End Try

    End Function
    Function C2Validation() As Boolean

        Try
            c2Value = CDbl(C2TextBox.Text)

            Select Case c2Value
                Case <= 0
                    C2TextBox.BackColor = Color.LightYellow
                    message &= "Valid capacitance value for C2 is Required" & vbNewLine
                    Return False
                Case Else
                    C2TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            C2TextBox.BackColor = Color.LightYellow
            message &= "Valid capacitance value for C2 is Required" & vbNewLine
            Return False
        End Try

    End Function
    Function R3Validation() As Boolean

        Try
            r3Value = CDbl(R3TextBox.Text)

            Select Case r3Value
                Case <= 0
                    R3TextBox.BackColor = Color.LightYellow
                    message &= "Valid resistance value for R3 is Required" & vbNewLine
                    Return False
                Case Else
                    R3TextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            R3TextBox.BackColor = Color.LightYellow
            message &= "Valid resistance value for R3 is Required" & vbNewLine
            Return False
        End Try

    End Function
    Function RwValidation() As Boolean

        Try
            rwValue = CDbl(RwTextBox.Text)

            Select Case rwValue
                Case < 0
                    RwTextBox.BackColor = Color.LightYellow
                    message &= "Valid resistance value for Rw is Required" & vbNewLine
                    Return False
                Case Else
                    RwTextBox.BackColor = Color.White
                    Return True
            End Select

        Catch ex As Exception
            rwValue = 0
            RwTextBox.BackColor = Color.White
            Return True
        End Try

    End Function
    Sub RSettings()

        If OhmsRadioButton.Checked = True Then
            r1Value = CDbl(frequencyValue)
            r2Value = CDbl(frequencyValue)
            r3Value = CDbl(frequencyValue)
        ElseIf kOhmsRadioButton.Checked = True Then
            r1Value = CDbl(frequencyValue) * 1 ^ 3
            r2Value = CDbl(frequencyValue) * 1 ^ 3
            r3Value = CDbl(frequencyValue) * 1 ^ 3
        ElseIf MOhmsRadioButton.Checked = True Then
            r1Value = CDbl(frequencyValue) * 1 ^ 6
            r2Value = CDbl(frequencyValue) * 1 ^ 6
            r3Value = CDbl(frequencyValue) * 1 ^ 6
        End If
    End Sub
    End Sub
    Sub cSettings()

        If CmicroRadioButton.Checked = True Then
            c1Value = CDbl(C1TextBox.Text) * 1 ^ -6
            c2Value = CDbl(C2TextBox.Text) * 1 ^ -6
        ElseIf CpicoRadioButton.Checked = True Then
            c1Value = CDbl(C1TextBox.Text) * 1 ^ -12
            c2Value = CDbl(C2TextBox.Text) * 1 ^ -12
        End If

    End Sub
    Sub LSettings()

        If LRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text)
        ElseIf LmilliRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text) * 1 ^ -3
        ElseIf LmicroRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text) * 1 ^ -6
        End If
    End Sub
    Sub FrequencySettings()
        If HzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue)
        ElseIf kHzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue) * 1 ^ 3
        ElseIf MHzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue) * 1 ^ 6
        End If
    End Sub
    Function FieldValidation() As Boolean

        If VgenValidation() And FrequencyValidation() And C1Validation() And R1Validation() And L1Validation() And RwValidation() And R2Validation() And C2Validation() And R3Validation() = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub ReactanceCalculation()

        xc1Result = 1 / (2 * Math.PI * frequencyValue * c1Value)

        xl1Result = 2 * Math.PI * frequencyValue * l1Value

        xc2Result = 1 / (2 * Math.PI * frequencyValue * c2Value)

    End Sub
    Sub ZCalculations()

        zseriesreal = r1Value
        zseriesimg = xc1Result
        zseriespol = Math.Round(Math.Sqrt((zseriesreal ^ 2) + (zseriesimg ^ 2)), 2, MidpointRounding.AwayFromZero)
        zseriesangle = Math.Round(Math.Atan(zseriesimg / zseriesreal), 2, MidpointRounding.AwayFromZero)
        zb1real = r2Value + rwValue
        zb1img = xl1Result
        zb1pol = Math.Round(Math.Sqrt(((zb1real) ^ 2) + (zb1img ^ 2)), 2, MidpointRounding.AwayFromZero)
        zb1angle = Math.Round(Math.Atan(zb1img / zb1real), 2, MidpointRounding.AwayFromZero)
        zb2real = r3Value
        zb2img = xc2Result
        zb2pol = Math.Round(Math.Sqrt(((zb2real) ^ 2) + (zb2img ^ 2)), 2, MidpointRounding.AwayFromZero)
        zb2angle = Math.Round(Math.Atan(zb2img / zb2real), 2, MidpointRounding.AwayFromZero)
        zparallelpol = Math.Round((zb1pol * zb2pol) / (Math.Atan(zb1img / (Math.Sqrt(((zb1real + zb2real) ^ 2) + (zb1img + zb2img) ^ 2)))), 2, MidpointRounding.AwayFromZero)
        zparallelangle = Math.Round(zb1angle + zb2angle - (Math.Atan((zb1img + zb2img) / (zb1real + zb2real))), 2, MidpointRounding.AwayFromZero)
        zparallelreal = Math.Round(zparallelpol * (Math.Cos(zparallelangle)), 2, MidpointRounding.AwayFromZero)
        zparallelimg = Math.Round(zparallelpol * (Math.Sin(zparallelangle)), 2, MidpointRounding.AwayFromZero)
        ztotalreal = Math.Round((zseriesreal + zparallelreal), 2, MidpointRounding.AwayFromZero)
        ztotalimg = Math.Round((zseriesimg + zparallelimg), 2, MidpointRounding.AwayFromZero)
        ztotalpol = Math.Round(Math.Sqrt(((ztotalreal) ^ 2) + (ztotalimg ^ 2)), 2, MidpointRounding.AwayFromZero)
        ztotalangle = Math.Round(Math.Atan(ztotalimg / ztotalreal), 2, MidpointRounding.AwayFromZero)

    End Sub
    Sub VandICalculations()

        vc1Result = Math.Round((vgenValue / xc1Result), 2, MidpointRounding.AwayFromZero)

        vr1Result = Math.Round((vgenValue / r1Value), 2, MidpointRounding.AwayFromZero)

        itotalResult = Math.Round((vgenValue / ztotalpol), 2, MidpointRounding.AwayFromZero)

        vparallel = Math.Round((itotalResult * zb1pol), 2, MidpointRounding.AwayFromZero)

        ib1Result = Math.Round((vparallel / zb1pol), 2, MidpointRounding.AwayFromZero)

        vl1Result = Math.Round((ib1Result * xl1Result), 2, MidpointRounding.AwayFromZero)

        vr2Result = Math.Round((ib1Result * r2Value), 2, MidpointRounding.AwayFromZero)

        ib2Result = Math.Round((vparallel / zb2pol), 2, MidpointRounding.AwayFromZero)

        vc2Result = Math.Round((ib2Result * xc2Result), 2, MidpointRounding.AwayFromZero)

        vr3Result = Math.Round((ib2Result * r3Value), 2, MidpointRounding.AwayFromZero)

    End Sub
    Sub DisplayResults()

        ReactanceCalculation()
        ZCalculations()
        VandICalculations()
        ResultsListBox.Items.Add($"Ztotal in polar = {ztotalpol} ohms with  an angle of {ztotalangle} degrees")
        ResultsListBox.Items.Add($"Ztotal in rectangular = {ztotalreal} +j {ztotalimg}")
        ResultsListBox.Items.Add($"Zseries in polar = {zseriespol} with an angle of {zseriesangle} degrees")
        ResultsListBox.Items.Add($"Zseries in rectangular = {zseriesreal} +j {zseriesimg}")
        ResultsListBox.Items.Add($"Zparallel in polar = {zparallelpol} with an angle of {zparallelangle} degrees")
        ResultsListBox.Items.Add($"Zparallel in rectangular = {zparallelreal} +j {zparallelimg}")
        ResultsListBox.Items.Add($"Zbranch1 in polar = {zb1pol} with an angle of {zb1angle} degrees")
        ResultsListBox.Items.Add($"Zbranch1 in rectangular = {zb1real} +j {zb1img}")
        ResultsListBox.Items.Add($"Zbranch2 in polar = {zb2pol} with an angle of {zb2angle}")
        ResultsListBox.Items.Add($"Zbranch2 in rectangular = {zb2real} +j {zb2img}")

    End Sub


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If FieldValidation() = True Then
            DisplayResults()

        Else
            MsgBox(message, MsgBoxStyle.Critical, "User Information Error")
            message = ""
        End If
    End Sub

    Private Sub SeriesParallelCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDefaults()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class
