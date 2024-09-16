Option Strict On
Option Explicit On



'TODO List
'[x] Set Default Values
'[x] Track Values from values text boxes
'[x] Do not allow the user to calculate before filling all the required values with valid values
'[ ] Highlight all invalid values
'[ ] All values in the text boxes will go to the labels on the schematics
'[ ] Check which 
'[ ] Calculate for current in total, for branches and components
'[ ] Calculate for voltage for each branch and individual components
'[ ] Calculate the reactance for each reactive component
'[ ] Calculate the impedance for each branch and in total
'[ ] Display all calculated values in a list box

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
    Sub cSettings()

        If CmicroRadioButton.Checked = True Then
            c1Value = CDbl(C1TextBox.Text) * 0.000001
            c2Value = CDbl(C2TextBox.Text) * 0.000001
        ElseIf CpicoRadioButton.Checked = True Then
            c1Value = CDbl(C1TextBox.Text) * 0.000000000001
            c2Value = CDbl(C2TextBox.Text) * 0.000000000001
        End If

    End Sub
    Sub LSettings()

        If LRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text)
        ElseIf LmilliRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text) * 0.001
        ElseIf LmicroRadioButton.Checked = True Then
            l1Value = CDbl(L1TextBox.Text) * 0.000001
        End If
    End Sub
    Sub FrequencySettings()
        If HzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue)
        ElseIf kHzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue) * 1000
        ElseIf MHzRadioButton.Checked = True Then
            frequencyValue = CDbl(frequencyValue) * 1000000
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
        zseriespol = Math.Sqrt((zseriesreal ^ 2) + (zseriesimg ^ 2))
        zseriesangle = Math.Atan(zseriesimg / zseriesreal)
        zb1real = r2Value + rwValue
        zb1img = xl1Result
        zb1pol = Math.Sqrt(((zb1real) ^ 2) + (zb1img ^ 2))
        zb1angle = Math.Atan(zb1img / zb1real)
        zb2real = r3Value
        zb2img = xc2Result
        zb2pol = Math.Sqrt(((zb2real) ^ 2) + (zb2img ^ 2))
        zb2angle = Math.Atan(zb2img / zb2real)
        zparallelpol = (zb1pol * zb2pol) / Math.Atan(zb1img / (Math.Sqrt(((zb1real + zb2real) ^ 2) + (zb1img + zb2img) ^ 2)))
        zparallelangle = zb1angle + zb2angle - (Math.Atan((zb1img + zb2img) / (zb1real + zb2real)))
        zparallelreal = zparallelpol * (Math.Cos(zparallelangle))
        zparallelimg = zparallelpol * (Math.Sin(zparallelangle))
        ztotalreal = (zseriesreal + zparallelreal)
        ztotalimg = (zseriesimg + zparallelimg)
        ztotalpol = Math.Sqrt(((ztotalreal) ^ 2) + (ztotalimg ^ 2))
        ztotalangle = Math.Atan(ztotalimg / ztotalreal)

    End Sub
    Sub VandICalculations()

        vc1Result = vgenValue / xc1Result

        vr1Result = vgenValue / r1Value

        itotalResult = vgenValue / ztotalpol

        vparallel = itotalResult * zb1pol

        ib1Result = vparallel / zb1pol

        vl1Result = ib1Result * xl1Result

        vr2Result = ib1Result * r2Value

        ib2Result = vparallel / zb2pol

        vc2Result = ib2Result * xc2Result

        vr3Result = ib2Result * r3Value

    End Sub



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If FieldValidation() = True Then

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
