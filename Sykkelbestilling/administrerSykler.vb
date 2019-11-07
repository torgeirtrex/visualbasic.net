Imports MySql.Data.MySqlClient

Public Class administrerSykler

    Private tilkobling As MySqlConnection

    'Laster inn info når vinduet åpnes
    Private Sub administrerSykler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=torgekro;Uid=torgekro;Pwd=ZkybLjAu")

        hentSykkelType()
        hentAvdelingID()
    End Sub

    'Henter sykkeltypene og legger dem inn i drop down menyen for sykkeltyper
    Private Sub hentSykkelType()
        Try
            tilkobling.Open()
            Dim sqlSporring = "select distinct Sykkeltype from Sykkel"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim typetabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(typetabell)

            cboxSykkelType.Items.Clear()

            For Each row As DataRow In typetabell.Rows
                cboxSykkelType.Items.Add(row("Sykkeltype"))
            Next
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    'Henter alle avdelings IDene og legger dem inn i de to drop down menyene for avdelings IDer
    Private Sub hentAvdelingID()
        Try
            tilkobling.Open()
            Dim sqlSporring = "select distinct AvdelingsID from Avdeling"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim IDtabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(IDtabell)

            cboxAvdeling.Items.Clear()
            cboxVelgAvdeling.Items.Clear()

            For Each row As DataRow In IDtabell.Rows
                cboxAvdeling.Items.Add(row("AvdelingsID"))
                cboxVelgAvdeling.Items.Add(row("AvdelingsID"))
            Next
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    'Henter inn de ulike syklene tilgjengelig under valgt sykkeltype
    Private Sub cboxSykkelType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSykkelType.SelectedIndexChanged
        Try
            tilkobling.Open()
            Dim valgtType = cboxSykkelType.SelectedItem

            Dim sqlSporring = "select Sykkel_ID, Merke, Ramme from Sykkel Where Sykkeltype = '" & valgtType & "'"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim valgteSykler As New DataTable
            DA.SelectCommand = sql
            DA.Fill(valgteSykler)

            lboxSykkelValg.Items.Clear()

            For Each row As DataRow In valgteSykler.Rows
                Dim radTekst = row("Sykkel_ID") & "-" & row("Merke") & "-" & row("Ramme")
                lboxSykkelValg.Items.Add(radTekst)
            Next
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try

    End Sub

    'Håndterer de ulike handlingene brukeren kan utføre fra menyen
    Private Sub btnUtfor_Click(sender As Object, e As EventArgs) Handles btnUtfor.Click
        'Sjekker om en sykkel er valgt
        If lboxSykkelValg.SelectedItem = Nothing Then
            MsgBox("Du må velge en sykkel å utføre en handling på.")
        Else
            'Utfører valgt handling
            Select Case lboxHandlinger.SelectedItem
                Case Nothing
                    MsgBox("Du må velge en handling fra menyen for å kunne utføre den.")
                Case "Registrer som levert fra valgte lokasjon"
                    If cboxVelgAvdeling.SelectedItem = Nothing Then
                        MsgBox("Du må velge en avdeling å registrere sykkelen som levert til.")
                    Else
                        registrerSomLevert()
                    End If
                Case "Hent info"
                    hentInfo()
                Case "Rediger info"
                    redigerInfo()
                Case "Hent data"
                    MsgBox("Hent data")
                Case "Marker for reparasjon"
                    markerForReparasjon()
            End Select
        End If

    End Sub

    'Registrerer sykkelen som levert fra valgte avdeling
    Private Sub registrerSomLevert()
        Try
            tilkobling.Open()
            Dim sykkelData = lboxSykkelValg.SelectedItem.Split("-")
            Dim sykkelID = sykkelData(0)
            Dim sqlSporring = "Update Sykkel Set Tilgjengelighetstatus = '" & cboxVelgAvdeling.SelectedItem & "Ledig' Where Sykkel_ID = '" & sykkelID & "'"

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.ExecuteNonQuery()
            MessageBox.Show("Sykkel registrert som ledig.")
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try

    End Sub

    'Henter informasjon om valgt sykkel
    Private Sub hentInfo()
        Try
            tilkobling.Open()
            Dim sykkelData = lboxSykkelValg.SelectedItem.Split("-")
            Dim sykkelID = sykkelData(0)

            Dim sqlSporring = "Select * from Sykkel Where Sykkel_ID = " & sykkelID

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim sykkelTabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(sykkelTabell)

            For Each r As DataRow In sykkelTabell.Rows
                cboxAvdeling.SelectedItem = r("SykkelUtleieAvdID")
                txtMerke.Text = r("Merke")
                txtRamme.Text = r("Ramme")
                txtSykkelType.Text = r("Sykkeltype")
                txtGirsystem.Text = r("Girsystem")
                rtbUtstyrsbegrensing.Text = r("Utstyrsbegrensning")
            Next
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    'Endrer på informasjonen til valgt sykkel
    Private Sub redigerInfo()
        If cboxAvdeling.SelectedItem = Nothing Or txtMerke.Text = "" Or txtRamme.Text = "" Or
            txtSykkelType.Text = "" Or txtGirsystem.Text = "" Or rtbUtstyrsbegrensing.Text = "" Then

            MessageBox.Show("Alle feltene må fylles inn for å redigere informasjonen til en sykkel.")

        Else
            Try
                tilkobling.Open()
                Dim sykkelData = lboxSykkelValg.SelectedItem.Split("-")
                Dim sykkelID = sykkelData(0)
                Dim sqlSporring = "Update Sykkel Set " &
                    "SykkelUtleieAvdID = '" & cboxAvdeling.SelectedItem & "', " &
                    "Merke = '" & txtMerke.Text & "', " &
                    "Ramme = '" & txtRamme.Text & "', " &
                    "Sykkeltype = '" & txtSykkelType.Text & "', " &
                    "Girsystem = '" & txtGirsystem.Text & "', " &
                    "Utstyrsbegrensning = '" & rtbUtstyrsbegrensing.Text & "' " &
                    "Where Sykkel_ID = " & sykkelID

                Dim sql As New MySqlCommand(sqlSporring, tilkobling)
                sql.ExecuteNonQuery()
                MessageBox.Show("Informasjon redigert.")
                tilkobling.Close()
                hentSykkelType()
            Catch ex As MySqlException
                MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
            End Try
        End If

    End Sub

    'Markerer sykkel for reparasjon
    Private Sub markerForReparasjon()
        Try
            tilkobling.Open()
            Dim sykkelData = lboxSykkelValg.SelectedItem.Split("-")
            Dim sykkelID = sykkelData(0)
            Dim sqlSporring = "Update Sykkel Set Tilgjengelighetstatus = 'Trenger reparasjon' Where Sykkel_ID = '" & sykkelID & "'"

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.ExecuteNonQuery()
            MessageBox.Show("Sykkel markert for reparasjon.")
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try

    End Sub

    'Registrerer en ny sykkel med satte parametere

    Private Sub btnRegistrerNySykkel_Click(sender As Object, e As EventArgs) Handles btnRegistrerNySykkel.Click
        registrerNySykkel()
    End Sub

    Private Sub registrerNySykkel()
        If cboxAvdeling.SelectedItem = Nothing Or txtMerke.Text = "" Or txtRamme.Text = "" Or
            txtSykkelType.Text = "" Or txtGirsystem.Text = "" Or rtbUtstyrsbegrensing.Text = "" Then

            MessageBox.Show("Alle feltene må fylles inn for å registrere en ny sykkel.")

        Else
            Dim nySykkel As New Sykkel
            nySykkel.SykkelUtleieAvdID = cboxAvdeling.SelectedItem
            nySykkel.Merke = txtMerke.Text
            nySykkel.Ramme = txtRamme.Text
            nySykkel.Sykkeltype = txtSykkelType.Text
            nySykkel.Girsystem = txtGirsystem.Text
            nySykkel.Utstyrsbegrensing = rtbUtstyrsbegrensing.Text
            nySykkel.Tilgjengelighetstatus = "Ledig"

            nySykkel.leggTilIDatabase()

            hentSykkelType()

        End If
    End Sub

    Private Sub btnReparereListe_Click(sender As Object, e As EventArgs) Handles btnReparereListe.Click
        Try
            tilkobling.Open()
            Dim valgtType = cboxSykkelType.SelectedItem

            Dim sqlSporring = "select Sykkel_ID, Merke, Ramme from Sykkel Where Tilgjengelighetstatus = 'Trenger reparasjon'"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim valgteSykler As New DataTable
            DA.SelectCommand = sql
            DA.Fill(valgteSykler)

            lboxListe.Items.Clear()

            For Each row As DataRow In valgteSykler.Rows
                Dim radTekst = row("Sykkel_ID") & "-" & row("Merke") & "-" & row("Ramme")
                lboxListe.Items.Add(radTekst)
            Next
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub



    Private Sub btnHenteListe_Click(sender As Object, e As EventArgs) Handles btnHenteListe.Click
        Try
            tilkobling.Open()
            Dim sqlSporring = "Select * from Sykkel where Tilgjengelighetstatus like '%Ledig%'"

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim sykkelTabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(sykkelTabell)

            tilkobling.Close()

            For Each r As DataRow In sykkelTabell.Rows
                Dim registrertAvdeling As String
                registrertAvdeling = r("Tilgjengelighetstatus").ToString().Replace("Ledig", "")
                If Not r("SykkelUtleieAvdID").ToString = registrertAvdeling Then
                    Dim listeTekst = "Sykkel ID: " & r("Sykkel_ID") & " skal fraktes fra " & registrertAvdeling & " til " & r("SykkelUtleieAvdID")
                    lboxListe.Items.Add(listeTekst)
                End If
            Next

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    Private Sub btnForSentListe_Click(sender As Object, e As EventArgs) Handles btnForSentListe.Click
        lboxListe.Items.Clear()
        finnUtleideSykler()
    End Sub

    'Finner alle utleide sykler og sjekker om de innleveringsdatoen har passert
    Private Sub finnUtleideSykler()
        Try
            tilkobling.Open()
            Dim sqlSporring = "Select * from Sykkel"

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim sykkelTabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(sykkelTabell)

            tilkobling.Close()

            For Each r As DataRow In sykkelTabell.Rows
                If r("Tilgjengelighetstatus") = "Utleid" Then
                    If sjekkSykkel(r("Sykkel_ID")) Then
                        Dim listeTekst = r("Sykkel_ID") & "-" & r("Merke") & "-" & r("Ramme")
                        lboxListe.Items.Add(listeTekst)
                    End If
                End If
            Next

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    Private Function sjekkSykkel(ByVal ID As Integer)
        Try
            tilkobling.Open()

            Dim sqlSporring = "Select Sykkel_Til_Dato from Bestilling where sykkel_ID = " & ID & " and Sykkel_Til_Dato > CURRENT_DATE"

            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            Dim DA As New MySqlDataAdapter
            Dim sykkelTabell As New DataTable
            DA.SelectCommand = sql
            DA.Fill(sykkelTabell)

            tilkobling.Close()

            If sykkelTabell.Rows.Count = 0 Then
                Return True
            End If

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
        Return False
    End Function
End Class