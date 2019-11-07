Imports MySql.Data.MySqlClient

Public Class Sykkel
    Private tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=torgekro;Uid=torgekro;Pwd=ZkybLjAu")

    Public SykkelUtleieAvdID As Integer
    Public Merke As String
    Public Ramme As String
    Public Sykkeltype As String
    Public Girsystem As String
    Public Utstyrsbegrensing As String
    Public Tilgjengelighetstatus As String

    Public Sub leggTilIDatabase()
        Try
            tilkobling.Open()
            Dim sqlSporring = "Insert into Sykkel (SykkelUtleieAvdID, Merke, Ramme, Sykkeltype, Girsystem, Utstyrsbegrensning, Tilgjengelighetstatus) values (" &
                "" & SykkelUtleieAvdID & ", " &
                "'" & Merke & "', " &
                "'" & Ramme & "', " &
                "'" & Sykkeltype & "', " &
                "'" & Girsystem & "', " &
                "'" & Utstyrsbegrensing & "'," &
                "'" & Tilgjengelighetstatus & "' " &
                ");"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.ExecuteNonQuery()
            MessageBox.Show("Sykkel lagt til i databasen.")
            tilkobling.Close()

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub
End Class
