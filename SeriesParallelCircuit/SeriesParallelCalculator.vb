Option Strict On
Option Explicit On
Imports System.Windows.Forms.VisualStyles



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
    Dim ztotalResult As Double
    Dim zb1Result As Double
    Dim zb2Result As Double
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
    Dim vc1Result As Double
    Dim vr1Result As Double
    Dim vl1Result As Double
    Dim vr2Result As Double
    Dim vc2Result As Double
    Dim vr3Result As Double
    Dim message As String

    Sub SetDefaults()

        VgenTextBox.Text = ""
        VgenLabel.Text = ""
        FrequencyTextBox.Text = ""
        FrequencyLabel.Text = ""
        C1TextBox.Text = ""
        C1Label.Text = ""
        C2TextBox.Text = ""
        C2Label.Text = ""
        R1TextBox.Text = ""
        R1Label.Text = ""
        R2TextBox.Text = ""
        R2Label.Text = ""
        R3TextBox.Text = ""
        R3Label.Text = ""
        L1TextBox.Text = ""
        L1Label.Text = ""
        RwTextBox.Text = ""
        R2Label.Text = ""
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
                    FrequencyTextBox.BackColor= Color.LightYellow
                    message &="Valid Frequency Value is Required" & vbNewLine
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
            RwTextBox.BackColor = Color.White
            Return True
        End Try

    End Function
    Function FieldValidation() As Boolean

        If VgenValidation() And FrequencyValidation() And C1Validation() And R1Validation() And L1Validation() And RwValidation() And R2Validation() And C2Validation() And R3Validation() = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If FieldValidation() = True Then

        Else
            MsgBox(message, MsgBoxStyle.Critical, "User Information Error")
            message = ""
        End If
    End Sub
End Class
