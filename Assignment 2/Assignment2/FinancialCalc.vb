Option Strict On
Public Class FinancialCalc


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Dim rate As Double
    Dim years As Integer
    Dim cost As Decimal
    Dim principal As Decimal
    Dim yearlyInterest As Double
    Dim currentYear As Integer = 1
    Dim strNegativeError As String = "Error - Enter a positive number."
    Dim lastYears As Double = 0
    Dim strNonNumeric As String = "Error, non numeric value. "
    Private Sub btbCalculate_Click(sender As Object, e As EventArgs) Handles btbCalculate.Click
        rate = Convert.ToDecimal(txtInterest.Text)
        years = Convert.ToInt32(txtYears.Text)
        cost = Convert.ToDecimal(txtHouseCost.Text)
        principal = Convert.ToDecimal(txtPrincipal.Text)

        If IsNumeric(years) Then
            While currentYear <= years

                yearlyInterest = principal * (1 + rate)
                lstTotals.Items.Add("Year " & currentYear & "- " & yearlyInterest + lastYears)
                currentYear += 1
                lastYears = yearlyInterest
            End While

        Else
            MsgBox(strNonNumeric & " or " & strNegativeError)
        End If


    End Sub
End Class
