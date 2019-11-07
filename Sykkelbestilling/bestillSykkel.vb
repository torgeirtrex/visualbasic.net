Imports MySql.Data.MySqlClient


Public Class bestillSykkel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=torgekro;Uid=torgekro;Pwd=ZkybLjAu")
        tilkobling.Open()

        hentSykkelType()
    End Sub

    Private tilkobling As MySqlConnection

    Dim prissykkel As Double
    Dim bestillingsdato As String
    Dim innlesningtildato As String
    Dim innlesningfradato As String
    Dim rabattertpris As Double
    Dim pristilleggsykkelhjelm As Integer
    Dim pristilleggbarnesete As Integer

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    'Henter alle distinkte verdier av SykkelType fra tabellen Sykkel og lister dem i cboxSykkelType
    Private Sub hentSykkelType()
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
    End Sub

    'Sjekker om kunden er en ny kunde eller har tidligere bestillinger og gir mulighet for rabatter om det er
    'en returnerende kunde
    Private Sub sjekkkundehistorikk()
        Dim rabattprosent As String

        Dim Sqlsporring = "Select Kunde_ID, count(*) AS Antall_Bestillinger from Bestilling where Kunde_ID =" & txtVelgKundeIdForBestilling.Text & " GROUP BY 1 HAVING COUNT(*) > 1"
        Dim sql As New MySqlCommand(Sqlsporring, tilkobling)


        Dim DA As New MySqlDataAdapter
        Dim Kundehistorikk As New DataTable
        DA.SelectCommand = sql
        DA.Fill(Kundehistorikk)
        lboxHovedkonsoll.Items.Clear()

        For Each row As DataRow In Kundehistorikk.Rows
            Dim radTekst = "Kundenr: " & row("Kunde_ID") & " har " & row("Antall_Bestillinger") & vbCrLf & " tidligere kjøp."
            lboxHovedkonsoll.Items.Add(radTekst)
        Next
        gboxLoggInn.Visible = True
        If lboxHovedkonsoll.Items.Count > 0 Then
            rabattprosent = InputBox("Vil du gi noe rabatt til denne kunden før bestillingen registreres? Velg en prosent?")
            If rabattprosent = "" Then
                rabattertpris = prissykkel - 0
            ElseIf rabattprosent <> 0 Then
                rabattertpris = prissykkel - (CInt(rabattprosent) * prissykkel / 100)
            End If
        End If
    End Sub

    'Henter inn syklene fra valgt sykkeltype
    Private Sub cboxSykkelType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSykkelType.SelectedIndexChanged
        Dim valgtType = cboxSykkelType.SelectedItem
        Dim sqlSporring = "select Sykkel_ID, Merke, Ramme from Sykkel Where Sykkeltype = '" & valgtType & "' and Tilgjengelighetstatus like '%Ledig%'"
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
    End Sub

    'Registrerer bestillingen
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBestillForKunde.Click
        sjekkkundehistorikk()
        'Sjekker om rabatt er lagt inn 
        If rabattertpris <> prissykkel Then
            prissykkel = rabattertpris
        End If
        If txtVelgKundeIdForBestilling.Text = "" Then
            MsgBox("Du må skrive inn en kundeid og legge bestillingen på")
            Exit Sub
        ElseIf txtVelgSykkelIDForBestilling.Text = "" Then
            MsgBox("Du må skrive inn en sykkelid som skal gjelde for bestillingen")
            Exit Sub
        End If
        Try
            Dim sqlSporringBestilling = "Insert into Bestilling (Sykkel_ID, Kunde_ID, Beloep, Bestillingsdato,
                               Sykkel_Fra_Dato, Sykkel_Til_dato) values (" &
                    "'" & txtVelgSykkelIDForBestilling.Text & "', " &
                    "'" & txtVelgKundeIdForBestilling.Text & "', " &
                    "'" & prissykkel & "', " &
                    "'" & bestillingsdato & "', " &
                    "'" & innlesningfradato & "', " &
                    "'" & innlesningtildato & "');"
            Dim sql As New MySqlCommand(sqlSporringBestilling, tilkobling)
            MessageBox.Show(sqlSporringBestilling)
            sql.ExecuteNonQuery()
            MessageBox.Show("Bestilling lagt til i databasen.")
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
        Try
            Dim sqlSporringSettSykkeltilopptatt = "Update Sykkel set Tilgjengelighetstatus = 'Utleid' where Sykkel_ID = (" &
                    "'" & txtVelgSykkelIDForBestilling.Text & "');"
            Dim sqlupdate As New MySqlCommand(sqlSporringSettSykkeltilopptatt, tilkobling)
            MessageBox.Show(sqlSporringSettSykkeltilopptatt)
            sqlupdate.ExecuteNonQuery()
            MessageBox.Show("Sykkelen er nå registerert som utleid.")
            tilkobling.Close()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        End Try
    End Sub

    'Legger til valgt sykkel i bestillingsloggen
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLeggTilSykkel.Click
        If txtTilDatoÅr.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        ElseIf txtFraDatoÅr.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        ElseIf txtTilDatoMåned.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        ElseIf txtFraDatoMåned.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        ElseIf txtTilDatoDag.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        ElseIf txtFraDatoMåned.Text = "" = -1 Then
            MsgBox("Du må velge varighet før du kan fortsette bestilling")
        End If

        Dim dagensdato = Today
        bestillingsdato = registrerBruker.formatDate(dagensdato)
        lblDato.Text = bestillingsdato

        innlesningfradato = txtFraDatoÅr.Text & "-" & txtFraDatoMåned.Text & "-" & txtFraDatoDag.Text
        innlesningtildato = txtTilDatoÅr.Text & "-" & txtTilDatoMåned.Text & "-" & txtTilDatoDag.Text

        If txtTilDatoDag.Text = txtFraDatoDag.Text Then
            prissykkel = 599
            If chboxBarnesete.Checked Then
                prissykkel += 149
            End If
            If chboxSykkelhjelm.Checked Then
                prissykkel += 99
            End If
            lboxHovedkonsoll.Items.Add("Prisen på døgnutleie er kroner " & prissykkel)
        ElseIf txtTilDatoDag.Text <> txtFraDatoDag.Text Then
            prissykkel = 1499
            If chboxBarnesete.Checked Then
                prissykkel += 149
            End If
            If chboxSykkelhjelm.Checked Then
                prissykkel += 99
            End If
            lboxHovedkonsoll.Items.Add("Prisen på lengre utleie er " & prissykkel)
        End If
    End Sub

    Private Sub gboxBestillingsSkjema_Enter(sender As Object, e As EventArgs) Handles gboxBestillingsSkjema.Enter
        txtFraDatoÅr.Text = "2018"
        txtTilDatoÅr.Text = "2018"
        lboxVisOmsetningMåned.Hide()
        lboxVisOmsetningSykkelmerke.Hide()
    End Sub

    Private Sub btnFjernSykkel_Click(sender As Object, e As EventArgs) Handles btnFjernSykkel.Click
        lboxHovedkonsoll.Items.RemoveAt(lboxHovedkonsoll.Items.Count - 1)
    End Sub

    'Henter rapport om valgt sykkel
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnHentRapport.Click
        lboxVisOmsetningMåned.Show()
        lboxVisOmsetningSykkelmerke.Show()

        Dim sqlOmsetningMåned = "Select sum(Beloep) As Omsetning , EXTRACT(MONTH FROM Sykkel_Til_Dato) As Maanednummer FROM Bestilling GROUP BY 2 ORDER BY Maanednummer DESC"
        Dim sql As New MySqlCommand(sqlOmsetningMåned, tilkobling)

        Dim DA As New MySqlDataAdapter
        Dim omsetningstabell As New DataTable
        DA.SelectCommand = sql
        DA.Fill(omsetningstabell)

        lboxVisOmsetningMåned.Items.Clear()
        lboxVisOmsetningMåned.Items.Add("Måned  - Kr")
        For Each row As DataRow In omsetningstabell.Rows
            Dim radTekst = row("Maanednummer") & " - " & row("Omsetning")
            lboxVisOmsetningMåned.Items.Add(radTekst)
        Next

        Dim sqlOmsetningSykkelMerke = "SELECT Merke ,Count(B.Bestillings_ID) AS Antall_Bestillinger ,Sum(B.Beloep) AS Omsetning_Per_Sykkelmerke FROM Bestilling B INNER JOIN Sykkel S ON S.Sykkel_ID = B.Sykkel_ID GROUP BY 1 ORDER BY Omsetning_Per_Sykkelmerke DESC"
        Dim sql2 As New MySqlCommand(sqlOmsetningSykkelMerke, tilkobling)

        Dim DA2 As New MySqlDataAdapter
        Dim SykkelMerkeTabell As New DataTable
        DA.SelectCommand = sql2
        DA.Fill(SykkelMerkeTabell)

        lboxVisOmsetningSykkelmerke.Items.Clear()
        lboxVisOmsetningSykkelmerke.Items.Add("Merke-Antall-Kr")
        For Each row As DataRow In SykkelMerkeTabell.Rows
            Dim radTekst = row("Merke") & " - " & row("Antall_Bestillinger") & " - " & row("Omsetning_Per_Sykkelmerke")
            lboxVisOmsetningSykkelmerke.Items.Add(radTekst)
        Next
    End Sub

    'UI funksjoner
    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        gboxLoggInn.Visible = True
        gboxBestillingsSkjema.Visible = True
    End Sub

    Private Sub btnTilbakeTilBestilling_Click(sender As Object, e As EventArgs) Handles btnTilbakeTilBestilling.Click
        gboxBestillingsSkjema.Visible = True
        gboxLoggInn.Visible = False
    End Sub
    'UI funksjoner slutt

    'Metoder som åpner andre vinduer

    'Åpner vindu for å registrere ny bruker
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrerBruker.Click
        Dim registrerForm As New registrerBruker
        registrerForm.Show()
    End Sub

    'Åpner vindu for å registrere ny avdeling
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRedigerAvdelinger.Click
        Dim redigeravdelinger As New RedigerAvdelinger
        redigeravdelinger.Show()
    End Sub

    'Åpner vindu for administrasjon av sykler
    Private Sub btnApneAdministrer_Click(sender As Object, e As EventArgs) Handles btnApneAdministrer.Click
        Dim admSykler As New administrerSykler()
        admSykler.Show()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
