'Program: Beach Bike Rentals
'Author: Omar Vallejo
'Date: 2/17/2018
'Purpose: This Application calculates and displays the total cost
'   if renting a bike for a specified number of days.

Option Strict On


Public Class frmBike

    'cost per bike rental - used in multiple procedures
    Const _cdecPricePerDay As Decimal = 9.95D

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Close() 'Close the window
    End Sub

    Private Sub fromDigitalDownloads_Load(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the form is loaded
        lblCostHeading.Text = _cdecPricePerDay.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        'event handler is executed when the user clicks the clear button
        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCost.Click
        'this event handler is executed when the user clicke the clear button
        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub
End Class
