Imports MySql.Data.MySqlClient

Public Class registrerBruker
    Private tilkobling As MySqlConnection

    Private Sub registrerBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=torgekro;Uid=torgekro;Pwd=ZkybLjAu")

    End Sub

    Private Sub btnRegistrerNyKunde_Click(sender As Object, e As EventArgs) Handles btnRegistrerNyKunde.Click
        If (Not IsNumeric(txtBrukerPostnr.Text)) Or txtBrukerFornavn.Text = "" Or txtBrukerEtternavn.Text = "" Or
            txtBrukerEpost.Text = "" Or txtBrukerPostnr.Text = "" Or txtBrukerPoststed.Text = "" Then

            MessageBox.Show("Alle feltene må fylles inn, og kun tall kan brukes i feltet for postnummer.")

        Else
            Try
                tilkobling.Open()
                Dim sqlSporring = "Insert into Kunde (Fornavn, Etternavn, Epost, Foedselsdato, Postnummer, Poststed) values (" &
                    "'" & txtBrukerFornavn.Text & "', " &
                    "'" & txtBrukerEtternavn.Text & "', " &
                    "'" & txtBrukerEpost.Text & "', " &
                    "'" & formatDate(dtpBrukerFodselsdato.Value) & "', " &
                    txtBrukerPostnr.Text & ", " &
                    "'" & txtBrukerPoststed.Text & "' " &
                    ");"
                Dim sql As New MySqlCommand(sqlSporring, tilkobling)
                MessageBox.Show(sqlSporring)
                sql.ExecuteNonQuery()
                MessageBox.Show("Kunde lagt til i databasen.")
                tilkobling.Close()
            Catch ex As MySqlException
                MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
            End Try
        End If
    End Sub

    'SQL krever at datoen er på formatet yyyy-mm-dd, og ikke dd/mm/yyyy som vi har i tekstboksen
    'Derfor må vi formattere datoen før vi kan oppdatere
    Function formatDate(ByVal entry As String)
        Dim day, month, year As String
        day = entry.Substring(0, 2)
        month = entry.Substring(3, 2)
        year = entry.Substring(6, 4)
        Return year & "-" & month & "-" & day
    End Function
End Class