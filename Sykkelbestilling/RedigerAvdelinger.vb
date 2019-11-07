Imports MySql.Data.MySqlClient

Public Class RedigerAvdelinger

    Private Sub RedigerAvdelinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=torgekro;Uid=torgekro;Pwd=ZkybLjAu")
    End Sub

    Private tilkobling As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGaTilbake.Click
        Me.Hide()
    End Sub

    Private Sub LeggTilAvdelingKnapp_Click(sender As Object, e As EventArgs) Handles btnRegistrerAvdeling.Click
        Try
            tilkobling.Open()
            Dim leggtilavdsporring = "Insert into Avdeling (Avdelingsnavn, Avdelingsadresse, Postnummer, Poststed, Utleie_Innleverings_Indikator) VALUES (" &
                    "'" & txtAvdNavn.Text & "', " &
                    "'" & txtAvdAdresse.Text & "', " &
                    "'" & txtAvdPostnr.Text & "', " &
                    "'" & txtPoststed.Text & "', " &
                    "'" & cboxInnUt.SelectedItem & "');"

            Dim avdsql As New MySqlCommand(leggtilavdsporring, tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            'MessageBox.Show(leggtilavdsporring)
            avdsql.ExecuteNonQuery()

            MessageBox.Show("Avdeling lagt til i databasen.")
            tilkobling.Close()

        Catch ex As Exception

            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)

        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub
End Class