'Rahiel Rodriguez
'RCET 3371
'Fall 2024
'Series-Parallel Circuit Calculator
'https://github.com/rahielrodriguez/Series-ParallelCalculator.git

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
'[x] Display all calculated values in a list box
'[x] Display correct j signs for real values
'[x] Display impedance values with the correct resistance setting

Public Class SeriesParallelCalculator

    Dim vgenValue As Double
    Dim frequencyValue As Double
    Dim frequencyCurrentValue As Double
    Dim c1Value As Double
    Dim c1CurrentValue As Double
    Dim c2Value As Double
    Dim c2CurrentValue As Double
    Dim r1Value As Double
    Dim r1CurrentValue As Double
    Dim r2Value As Double
    Dim r2CurrentValue As Double
    Dim r3Value As Double
    Dim r3CurrentValue As Double
    Dim l1Value As Double
    Dim l1CurrentValue As Double
    Dim rwValue As Double
    Dim ztotalreal As Double
    Dim ztotalimg As Double
    Dim ztotalpol As Double
    Dim ztotalangle As Double
    Dim ztotalj As String
    Dim zseriesreal As Double
    Dim zseriesimg As Double
    Dim zseriespol As Double
    Dim zseriesangle As Double
    Dim zseriesj As String
    Dim zparallelreal As Double
    Dim zparallelimg As Double
    Dim zparallelpol As Double
    Dim zparallelangle As Double
    Dim zparallelj As String
    Dim zb1real As Double
    Dim zb1img As Double
    Dim zb1pol As Double
    Dim zb1angle As Double
    Dim zb1j As String
    Dim zb2real As Double
    Dim zb2img As Double
    Dim zb2pol As Double
    Dim zb2angle As Double
    Dim zb2j As String
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
    Dim zl1PolResult As Double
    Dim zl1AngResult As Double
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
    Dim vSeries As Double
    Dim vc1Result As Double
    Dim vr1Result As Double
    Dim vz1Result As Double
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

        'Only allows a number into the vgen text box and it cannot be equal to 0
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

        'Only allows a number into the frequency text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the C1 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the R1 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the L1 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the R2 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the C2 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the R3 text box and it can not be 0 or less to not allow negative numbers
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

        'Only allows a number into the frequency text box and it cannot be less than 0 to not allow negative numbers
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
            'In case an Rw value is not written, throws a 0 into the operation
            If RwTextBox.Text = "" Then
                rwValue = 0
                RwTextBox.BackColor = Color.White
                Return True
            Else
                'In case Rw value is a not valid value different to a negative number, it throws an error and does not allow to continue
                RwTextBox.BackColor = Color.LightYellow
                message &= "Valid resistance value for Rw is Required" & vbNewLine
                Return False
            End If
        End Try

    End Function
    Sub RSettings()

        'Sets all magnitudes for resistances according to the users selection
        If OhmsRadioButton.Checked = True Then
            r1CurrentValue = r1Value
            r2CurrentValue = r2Value
            r3CurrentValue = r3Value
        ElseIf kOhmsRadioButton.Checked = True Then
            r1CurrentValue = r1Value * 1000
            r2CurrentValue = r2Value * 1000
            r3CurrentValue = r3Value * 1000
        ElseIf MOhmsRadioButton.Checked = True Then
            r1CurrentValue = r1Value * 1000000
            r2CurrentValue = r2Value * 1000000
            r3CurrentValue = r3Value * 1000000
        End If
    End Sub
    Sub cSettings()

        'sets all magnitudes for capacitances according to the user selection
        If CmicroRadioButton.Checked = True Then
            c1CurrentValue = c1Value * 0.000001
            c2CurrentValue = c2Value * 0.000001
        ElseIf CpicoRadioButton.Checked = True Then
            c1CurrentValue = c1Value * 0.000000000001
            c2CurrentValue = c2Value * 0.000000000001
        End If

    End Sub
    Sub LSettings()

        'sets all magnitudes for inductance according to the user selection
        If LRadioButton.Checked = True Then
            l1CurrentValue = l1Value
        ElseIf LmilliRadioButton.Checked = True Then
            l1CurrentValue = l1Value * 0.001
        ElseIf LmicroRadioButton.Checked = True Then
            l1CurrentValue = l1Value * 0.000001
        End If
    End Sub
    Sub FrequencySettings()

        'sets all magnitudes for frequency according to the user selection
        If HzRadioButton.Checked = True Then
            frequencyCurrentValue = frequencyValue
        ElseIf kHzRadioButton.Checked = True Then
            frequencyCurrentValue = frequencyValue * 1000
        ElseIf MHzRadioButton.Checked = True Then
            frequencyCurrentValue = frequencyValue * 1000000
        End If
    End Sub
    Function FieldValidation() As Boolean

        'If one field does not have information or is wrong information, it will not allow to proceed
        If VgenValidation() And FrequencyValidation() And C1Validation() And R1Validation() And L1Validation() And RwValidation() And R2Validation() And C2Validation() And R3Validation() = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub ReactanceCalculation()

        RSettings()
        cSettings()
        LSettings()
        FrequencySettings()

        'calculates the reactances for C1, C2 and L1
        xc1Result = -1 * (1 / (2 * Math.PI * frequencyCurrentValue * c1CurrentValue))

        xl1Result = 2 * Math.PI * frequencyCurrentValue * l1CurrentValue

        xc2Result = -1 * (1 / (2 * Math.PI * frequencyCurrentValue * c2CurrentValue))

    End Sub
    Sub ZCalculations()

        'Calculates impedance (Polar) for L1 in case an Rw value is used
        zl1PolResult = Math.Sqrt((rwValue ^ 2) + (xl1Result ^ 2))

        zl1AngResult = (((Math.Atan(xl1Result / rwValue)) * 180) / Math.PI)

        'Calculates all impedances in the circuit in polar and rectangular form
        zseriesreal = r1CurrentValue

        zseriesimg = xc1Result

        zseriesj = "-j"

        zseriespol = Math.Sqrt((zseriesreal ^ 2) + (zseriesimg ^ 2))

        zseriesangle = (((Math.Atan(zseriesimg / zseriesreal)) * 180) / Math.PI)

        zb1real = r2CurrentValue + rwValue

        zb1img = xl1Result

        zb1j = "+j"

        zb1pol = Math.Sqrt(((zb1real) ^ 2) + (zb1img ^ 2))

        zb1angle = (((Math.Atan(zb1img / zb1real)) * 180) / Math.PI)

        zb2real = r3CurrentValue

        zb2img = xc2Result

        zb2j = "-j"

        zb2pol = Math.Sqrt(((zb2real) ^ 2) + (zb2img ^ 2))

        zb2angle = (((Math.Atan(zb2img / zb2real)) * 180) / Math.PI)

        zparallelpol = (zb1pol * zb2pol) / (Math.Sqrt(((zb1real + zb2real) ^ 2) + ((zb1img + zb2img) ^ 2)))

        zparallelangle = zb1angle + zb2angle - (((Math.Atan((zb1img + zb2img) / (zb1real + zb2real))) * 180) / Math.PI)

        zparallelreal = zparallelpol * Math.Cos((zparallelangle * Math.PI) / 180)

        zparallelimg = zparallelpol * Math.Sin((zparallelangle * Math.PI) / 180)

        'Determines if j values for rectangular form impedances are positive or negative
        If zparallelimg < 0 Then

            zparallelj = "-j"

        ElseIf zparallelimg > 0 Then
            zparallelj = "+j"

        End If

        ztotalreal = zseriesreal + zparallelreal

        ztotalimg = zseriesimg + zparallelimg

        If ztotalimg < 0 Then

            ztotalj = "-j"

        ElseIf ztotalimg > 0 Then

            ztotalj = "+j"

        End If

        ztotalpol = Math.Sqrt(((ztotalreal) ^ 2) + (ztotalimg ^ 2))

        ztotalangle = (((Math.Atan(ztotalimg / ztotalreal)) * 180) / Math.PI)

    End Sub
    Sub VandICalculations()

        'Calculates all currents and voltages in the circuit
        itotalResult = vgenValue / ztotalpol

        vc1Result = itotalResult * Math.Abs(xc1Result)

        vr1Result = itotalResult * r1CurrentValue

        vSeries = itotalResult * zseriespol

        vparallel = itotalResult * zparallelpol

        ib1Result = vparallel / zb1pol

        vz1Result = ib1Result * zl1PolResult

        vr2Result = ib1Result * r2CurrentValue

        ib2Result = vparallel / zb2pol

        vc2Result = ib2Result * Math.Abs(xc2Result)

        vr3Result = ib2Result * r3CurrentValue

    End Sub
    Sub DisplayResults()

        ReactanceCalculation()
        ZCalculations()
        VandICalculations()

        'Displays all impedances in the circuit in the Listbox
        'All impedances will have 3 decimal places with rouding
        'All reactances have extra decimal places to display values in case they are too small
        'All impedances and reactances will be displayed with the magnitude selected by the user in the R Display Settings Group Box
        If OhmsDisplayRadioButton.Checked = True Then

            ResultsListBox.Items.Add($"Xc1 = {Math.Round((Math.Abs(xc1Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Xl1 = {Math.Round((Math.Abs(xl1Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of +90 degrees")
            ResultsListBox.Items.Add($"Zl1 = {Math.Round((Math.Abs(zl1PolResult)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Xc2 = {Math.Round((Math.Abs(xc2Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Zbranch1 in polar = {Math.Round((zb1pol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch1 in rectangular = {Math.Round((zb1real), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zb1img), 3, MidpointRounding.AwayFromZero)} ohms")
            ResultsListBox.Items.Add($"Zbranch2 in polar = {Math.Round((zb2pol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch2 in rectangular = {Math.Round((zb2real), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zb2img), 3, MidpointRounding.AwayFromZero)} ohms")
            ResultsListBox.Items.Add($"Zseries in polar = {Math.Round((zseriespol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zseries in rectangular = {Math.Round((zseriesreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zseriesimg), 3, MidpointRounding.AwayFromZero)} ohms")
            ResultsListBox.Items.Add($"Zparallel in polar = {Math.Round((zparallelpol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zparallel in rectangular = {Math.Round((zparallelreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zparallelimg), 3, MidpointRounding.AwayFromZero)} ohms")
            ResultsListBox.Items.Add($"Ztotal in polar = {Math.Round((ztotalpol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Ztotal in rectangular = {Math.Round((ztotalreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(ztotalimg), 3, MidpointRounding.AwayFromZero)} ohms")

        ElseIf kOhmsDisplayRadioButton.Checked = True Then

            ResultsListBox.Items.Add($"Xc1 = {Math.Round((Math.Abs(xc1Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Xl1 = {Math.Round((Math.Abs(xl1Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of +90 degrees")
            ResultsListBox.Items.Add($"Zl1 = {Math.Round((Math.Abs(zl1PolResult / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Xc2 = {Math.Round((Math.Abs(xc2Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Zbranch1 in polar = {Math.Round((zb1pol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch1 in rectangular = {Math.Round((zb1real / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zb1img / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            ResultsListBox.Items.Add($"Zbranch2 in polar = {Math.Round((zb2pol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch2 in rectangular = {Math.Round((zb2real / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zb2img / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            ResultsListBox.Items.Add($"Zseries in polar = {Math.Round((zseriespol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zseries in rectangular = {Math.Round((zseriesreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zseriesimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            ResultsListBox.Items.Add($"Zparallel in polar = {Math.Round((zparallelpol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zparallel in rectangular = {Math.Round((zparallelreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zparallelimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            ResultsListBox.Items.Add($"Ztotal in polar = {Math.Round((ztotalpol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Ztotal in rectangular = {Math.Round((ztotalreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(ztotalimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")

        ElseIf MOhmsDisplayRadioButton.Checked = True Then

            ResultsListBox.Items.Add($"Xc1 = {Math.Round((Math.Abs(xc1Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Xl1 = {Math.Round((Math.Abs(xl1Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of +90 degrees")
            ResultsListBox.Items.Add($"Zl1 = {Math.Round((Math.Abs(zl1PolResult / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Xc2 = {Math.Round((Math.Abs(xc2Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of -90 degrees")
            ResultsListBox.Items.Add($"Zbranch1 in polar = {Math.Round((zb1pol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch1 in rectangular = {Math.Round((zb1real / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zb1img / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            ResultsListBox.Items.Add($"Zbranch2 in polar = {Math.Round((zb2pol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zbranch2 in rectangular = {Math.Round((zb2real / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zb2img / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            ResultsListBox.Items.Add($"Zseries in polar = {Math.Round((zseriespol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zseries in rectangular = {Math.Round((zseriesreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zseriesimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            ResultsListBox.Items.Add($"Zparallel in polar = {Math.Round((zparallelpol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Zparallel in rectangular = {Math.Round((zparallelreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zparallelimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            ResultsListBox.Items.Add($"Ztotal in polar = {Math.Round((ztotalpol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            ResultsListBox.Items.Add($"Ztotal in rectangular = {Math.Round((ztotalreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(ztotalimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
        End If

        'Displays all currents in the circuit in the Listbox
        'All currents will have 3 decimal places with rouding
        'All currents will be displayed with the magnitude selected by the user in the I Display Settings Group Box

        If AmpsRadioButton.Checked = True Then
            ResultsListBox.Items.Add($"Itotal = {Math.Round((itotalResult), 3, MidpointRounding.AwayFromZero)} Amps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch1 = {Math.Round((ib1Result), 3, MidpointRounding.AwayFromZero)} Amps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch2 = {Math.Round((ib2Result), 3, MidpointRounding.AwayFromZero)} Amps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf mAmpsRadioButton.Checked = True Then
            ResultsListBox.Items.Add($"Itotal = {Math.Round((itotalResult / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch1 = {Math.Round((ib1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch2 = {Math.Round((ib2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf uAmpsRadioButton.Checked = True Then
            ResultsListBox.Items.Add($"Itotal = {Math.Round((itotalResult / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch1 = {Math.Round((ib1Result / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Ibranch2 = {Math.Round((ib2Result / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")
        End If

        'Displays all voltages in the circuit in the Listbox
        'All voltages will have 3 decimal places with rouding
        'All voltages will be displayed with the magnitude selected by the user in the V Display Settings Group Box

        If VRadioButton.Checked = True Then
            ResultsListBox.Items.Add($"Vc1 = {Math.Round((vc1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (c1valueangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr1 = {Math.Round((vr1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vseries = {Math.Round((vSeries), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zseriesangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vparallel = {Math.Round((vparallel), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zparallelangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vz1 = {Math.Round((vz1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle) + l1valueangle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr2 = {Math.Round((vr2Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vc2 = {Math.Round((vc2Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + zparallelangle - zb2angle) + c1valueangle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr3 = {Math.Round((vr3Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf mVRadioButton.Checked = True Then
            ResultsListBox.Items.Add($"Vc1 = {Math.Round((vc1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (c1valueangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr1 = {Math.Round((vr1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vseries = {Math.Round((vSeries / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zseriesangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vparallel = {Math.Round((vparallel / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zparallelangle)), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vz1 = {Math.Round((vz1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle) + l1valueangle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr2 = {Math.Round((vr2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vc2 = {Math.Round((vc2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + zparallelangle - zb2angle) + c1valueangle), 3, MidpointRounding.AwayFromZero)}")
            ResultsListBox.Items.Add($"Vr3 = {Math.Round((vr3Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        End If

    End Sub

    Sub DocumentSaving()

        FileOpen(1, "..\..\Series-Parallel Circuit Calculator Results.txt", OpenMode.Append)

        If OhmsDisplayRadioButton.Checked = True Then

            PrintLine(1, $"Xc1 = {Math.Round((Math.Abs(xc1Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of -90 degrees")
            PrintLine(1, $"Xl1 = {Math.Round((Math.Abs(xl1Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of +90 degrees")
            PrintLine(1, $"Zl1 = {Math.Round((Math.Abs(zl1PolResult)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Xc2 = {Math.Round((Math.Abs(xc2Result)), 3, MidpointRounding.AwayFromZero)} ohms with an angle of -90 degrees")
            PrintLine(1, $"Zbranch1 in polar = {Math.Round((zb1pol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch1 in rectangular = {Math.Round((zb1real), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zb1img), 3, MidpointRounding.AwayFromZero)} ohms")
            PrintLine(1, $"Zbranch2 in polar = {Math.Round((zb2pol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch2 in rectangular = {Math.Round((zb2real), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zb2img), 3, MidpointRounding.AwayFromZero)} ohms")
            PrintLine(1, $"Zseries in polar = {Math.Round((zseriespol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zseries in rectangular = {Math.Round((zseriesreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zseriesimg), 3, MidpointRounding.AwayFromZero)} ohms")
            PrintLine(1, $"Zparallel in polar = {Math.Round((zparallelpol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zparallel in rectangular = {Math.Round((zparallelreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(zparallelimg), 3, MidpointRounding.AwayFromZero)} ohms")
            PrintLine(1, $"Ztotal in polar = {Math.Round((ztotalpol), 3, MidpointRounding.AwayFromZero)} ohms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Ztotal in rectangular = {Math.Round((ztotalreal), 3, MidpointRounding.AwayFromZero)} ohms {zb1j} {Math.Round(Math.Abs(ztotalimg), 3, MidpointRounding.AwayFromZero)} ohms")

        ElseIf kOhmsDisplayRadioButton.Checked = True Then

            PrintLine(1, $"Xc1 = {Math.Round((Math.Abs(xc1Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of -90 degrees")
            PrintLine(1, $"Xl1 = {Math.Round((Math.Abs(xl1Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of +90 degrees")
            PrintLine(1, $"Zl1 = {Math.Round((Math.Abs(zl1PolResult / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Xc2 = {Math.Round((Math.Abs(xc2Result / 1000)), 6, MidpointRounding.AwayFromZero)} kOhms with an angle of -90 degrees")
            PrintLine(1, $"Zbranch1 in polar = {Math.Round((zb1pol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch1 in rectangular = {Math.Round((zb1real / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zb1img / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            PrintLine(1, $"Zbranch2 in polar = {Math.Round((zb2pol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch2 in rectangular = {Math.Round((zb2real / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zb2img / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            PrintLine(1, $"Zseries in polar = {Math.Round((zseriespol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zseries in rectangular = {Math.Round((zseriesreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zseriesimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            PrintLine(1, $"Zparallel in polar = {Math.Round((zparallelpol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zparallel in rectangular = {Math.Round((zparallelreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(zparallelimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")
            PrintLine(1, $"Ztotal in polar = {Math.Round((ztotalpol / 1000), 3, MidpointRounding.AwayFromZero)} kOhms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Ztotal in rectangular = {Math.Round((ztotalreal / 1000), 3, MidpointRounding.AwayFromZero)} kOhms {zb1j} {Math.Round(Math.Abs(ztotalimg / 1000), 3, MidpointRounding.AwayFromZero)} kOhms")

        ElseIf MOhmsDisplayRadioButton.Checked = True Then

            PrintLine(1, $"Xc1 = {Math.Round((Math.Abs(xc1Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of -90 degrees")
            PrintLine(1, $"Xl1 = {Math.Round((Math.Abs(xl1Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of +90 degrees")
            PrintLine(1, $"Zl1 = {Math.Round((Math.Abs(zl1PolResult / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zl1AngResult), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Xc2 = {Math.Round((Math.Abs(xc2Result / 1000000)), 9, MidpointRounding.AwayFromZero)} MOhms with an angle of -90 degrees")
            PrintLine(1, $"Zbranch1 in polar = {Math.Round((zb1pol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zb1angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch1 in rectangular = {Math.Round((zb1real / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zb1img / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            PrintLine(1, $"Zbranch2 in polar = {Math.Round((zb2pol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zb2angle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zbranch2 in rectangular = {Math.Round((zb2real / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zb2img / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            PrintLine(1, $"Zseries in polar = {Math.Round((zseriespol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zseriesangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zseries in rectangular = {Math.Round((zseriesreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zseriesimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            PrintLine(1, $"Zparallel in polar = {Math.Round((zparallelpol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((zparallelangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Zparallel in rectangular = {Math.Round((zparallelreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(zparallelimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
            PrintLine(1, $"Ztotal in polar = {Math.Round((ztotalpol / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms with an angle of {Math.Round((ztotalangle), 3, MidpointRounding.AwayFromZero)} degrees")
            PrintLine(1, $"Ztotal in rectangular = {Math.Round((ztotalreal / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms {zb1j} {Math.Round(Math.Abs(ztotalimg / 1000000), 3, MidpointRounding.AwayFromZero)} MOhms")
        End If

        'Displays all currents in the circuit in the Listbox
        'All currents will have 3 decimal places with rouding
        'All currents will be displayed with the magnitude selected by the user in the I Display Settings Group Box

        If AmpsRadioButton.Checked = True Then
            PrintLine(1, $"Itotal = {Math.Round((itotalResult), 3, MidpointRounding.AwayFromZero)} Amps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch1 = {Math.Round((ib1Result), 3, MidpointRounding.AwayFromZero)} Amps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch2 = {Math.Round((ib2Result), 3, MidpointRounding.AwayFromZero)} Amps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf mAmpsRadioButton.Checked = True Then
            PrintLine(1, $"Itotal = {Math.Round((itotalResult / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch1 = {Math.Round((ib1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch2 = {Math.Round((ib2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf uAmpsRadioButton.Checked = True Then
            PrintLine(1, $"Itotal = {Math.Round((itotalResult / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch1 = {Math.Round((ib1Result / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Ibranch2 = {Math.Round((ib2Result / 0.000001), 3, MidpointRounding.AwayFromZero)} mAmps With an angle Of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")
        End If

        'Displays all voltages in the circuit in the Listbox
        'All voltages will have 3 decimal places with rouding
        'All voltages will be displayed with the magnitude selected by the user in the V Display Settings Group Box

        If VRadioButton.Checked = True Then
            PrintLine(1, $"Vc1 = {Math.Round((vc1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (c1valueangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr1 = {Math.Round((vr1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vseries = {Math.Round((vSeries), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zseriesangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vparallel = {Math.Round((vparallel), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zparallelangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vz1 = {Math.Round((vz1Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle) + l1valueangle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr2 = {Math.Round((vr2Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vc2 = {Math.Round((vc2Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + zparallelangle - zb2angle) + c1valueangle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr3 = {Math.Round((vr3Result), 3, MidpointRounding.AwayFromZero)} Volts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        ElseIf mVRadioButton.Checked = True Then
            PrintLine(1, $"Vc1 = {Math.Round((vc1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (c1valueangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr1 = {Math.Round((vr1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((-1 * (ztotalangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vseries = {Math.Round((vSeries / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zseriesangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vparallel = {Math.Round((vparallel / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + (zparallelangle)), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vz1 = {Math.Round((vz1Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle) + l1valueangle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr2 = {Math.Round((vr2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + (zparallelangle)) - zb1angle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vc2 = {Math.Round((vc2Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round((((-1 * (ztotalangle)) + zparallelangle - zb2angle) + c1valueangle), 3, MidpointRounding.AwayFromZero)}")
            PrintLine(1, $"Vr3 = {Math.Round((vr3Result / 0.001), 3, MidpointRounding.AwayFromZero)} mVolts peak with an angle of {Math.Round(((-1 * (ztotalangle)) + zparallelangle - zb2angle), 3, MidpointRounding.AwayFromZero)}")

        End If

        PrintLine(1, "----------------------------------------------------------------------")
        FileClose()

    End Sub


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click, CalculateToolStripMenuItem1.Click

        ResultsListBox.Items.Clear()

        If FieldValidation() = True Then

            DisplayResults()

        Else
            MsgBox(message, MsgBoxStyle.Critical, "User Information Error")
            message = ""
        End If
    End Sub

    Private Sub SeriesParallelCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileOpen(1, "..\..\Series-Parallel Circuit Calculator Results.txt", OpenMode.Append)
        FileClose()
        SetDefaults()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        SetDefaults()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        DocumentSaving()

    End Sub

End Class
