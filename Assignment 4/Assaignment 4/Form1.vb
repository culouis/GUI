
Option Strict On

Public Class Form1
    Dim arrGames(10) As String
    Dim downloads(10) As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim file As String = "D:\Omar\Documents\GUI\Assaignment 4\mobile.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer = 0
        Dim strFileError As String = "The file is not available."


        If IO.File.Exists(file) Then
            objReader = IO.File.OpenText(file)
            Do While objReader.Peek <> -1
                arrGames(intCount) = objReader.ReadLine()
                downloads(intCount) = Convert.ToInt32(objReader.ReadLine())
                lstGames.Items.Add(arrGames(intCount))
                intCount += 1
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError,, "Error")
            Close()
        End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim selectedGame As Integer

        If lstGames.SelectedIndex >= 0 Then
            selectedGame = lstGames.SelectedIndex
            lblDownloads.Text = arrGames(selectedGame) & " had " & downloads(selectedGame) & " downloads."
            lblDownloads.Visible = True
            lblTotalDownloads.Visible = True
            Label2.Visible = True

            lblTotalDownloads.Text = downloads.Sum().ToString()
        End If
    End Sub
End Class
