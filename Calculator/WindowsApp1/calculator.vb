'Omar Vallejo
'Midterm 
'3/14/2018
'Code will simulate a calculator. If too many numbers are entered to be displayed, 
'it will Return a msg box syaing To.
'


Option Strict On


Public Class calculator

    Dim strNum1 As String = "0"
    Dim strNum2 As String = "0"
    Dim boolNumOrder As Boolean = True
    Dim intMaxCharacters As Integer = 15
    Dim strMathematicalEquation As String


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "1"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "1"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "2"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "2"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "3"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "3"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "4"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "4"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "5"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "5"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "6"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "6"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "7"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "7"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "8"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "8"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "9"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "9"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        strNum1 = "0"
        strNum2 = "0"
        lblDisplay.Text = "0"
        boolNumOrder = True
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If boolNumOrder = True Then
            If Len(strNum1) < 15 Then
                strNum1 = strNum1 & "0"
                lblDisplay.Text = strNum1
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        Else
            If Len(strNum1) < 15 Then
                strNum2 = strNum2 & "0"
                lblDisplay.Text = strNum2
            Else
                MsgBox("You entered the maximum amount of characters.")
            End If
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Dim strAnswer As String

        'test for dividable by 0
        If strNum2 = "0" Then
            strAnswer = "Dividable by 0 Error"

        Else

            'selects which action to perform. after equation is done, set the answer to be an option to calculate something else. 
            Select Case strMathematicalEquation
                Case "+"
                    strAnswer = Convert.ToString(Convert.ToInt32(strNum1) + Convert.ToInt32(strNum2))

                Case "-"
                    strAnswer = Convert.ToString(Convert.ToInt32(strNum1) - Convert.ToInt32(strNum2))

                Case "X"
                    strAnswer = Convert.ToString(Convert.ToInt32(strNum1) * Convert.ToInt32(strNum2))

                Case "/"
                    strAnswer = Convert.ToString(Convert.ToInt32(strNum1) / Convert.ToInt32(strNum2))
                    If Len(strAnswer) < 15 Then
                        lblDisplay.Text = strAnswer
                    Else
                        MsgBox("Calculation too big for display. Press 'CE' to continue using calculator. ")
                    End If

                Case Else
                    strAnswer = strNum1
            End Select
        End If

        lblDisplay.Text = strAnswer
        strNum1 = strAnswer
        strNum2 = "0"
        strMathematicalEquation = ""

    End Sub


    'will identify what kind of mathematical operation to perform

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        boolNumOrder = False
        lblDisplay.Text = strNum2
        strMathematicalEquation = "+"

    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        boolNumOrder = False
        lblDisplay.Text = strNum2
        strMathematicalEquation = "X"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        boolNumOrder = False
        lblDisplay.Text = strNum2
        strMathematicalEquation = "/"
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        boolNumOrder = False
        lblDisplay.Text = strNum2
        strMathematicalEquation = "-"
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
