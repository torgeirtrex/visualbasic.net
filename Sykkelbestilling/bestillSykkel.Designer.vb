<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bestillSykkel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboxSykkelType = New System.Windows.Forms.ComboBox()
        Me.lboxSykkelValg = New System.Windows.Forms.ListBox()
        Me.lboxHovedkonsoll = New System.Windows.Forms.ListBox()
        Me.lblDisplay1 = New System.Windows.Forms.Label()
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.lblDisplay8 = New System.Windows.Forms.Label()
        Me.lblDisplay9 = New System.Windows.Forms.Label()
        Me.gboxBestillingsSkjema = New System.Windows.Forms.GroupBox()
        Me.chboxBarnesete = New System.Windows.Forms.CheckBox()
        Me.chboxSykkelhjelm = New System.Windows.Forms.CheckBox()
        Me.lblDisplay7 = New System.Windows.Forms.Label()
        Me.lblDisplay6 = New System.Windows.Forms.Label()
        Me.lblDisplay5 = New System.Windows.Forms.Label()
        Me.lblDisplay4 = New System.Windows.Forms.Label()
        Me.lblDisplay3 = New System.Windows.Forms.Label()
        Me.lblDisplay2 = New System.Windows.Forms.Label()
        Me.txtTilDatoÅr = New System.Windows.Forms.TextBox()
        Me.txtTilDatoDag = New System.Windows.Forms.TextBox()
        Me.txtTilDatoMåned = New System.Windows.Forms.TextBox()
        Me.txtFraDatoDag = New System.Windows.Forms.TextBox()
        Me.txtFraDatoÅr = New System.Windows.Forms.TextBox()
        Me.txtFraDatoMåned = New System.Windows.Forms.TextBox()
        Me.lblViservalgtSykkelID = New System.Windows.Forms.Label()
        Me.lblDisplay12 = New System.Windows.Forms.Label()
        Me.lblDisplay11 = New System.Windows.Forms.Label()
        Me.lblDato = New System.Windows.Forms.Label()
        Me.btnFjernSykkel = New System.Windows.Forms.Button()
        Me.btnLeggTilSykkel = New System.Windows.Forms.Button()
        Me.lblSykkelID = New System.Windows.Forms.Label()
        Me.gboxLoggInn = New System.Windows.Forms.GroupBox()
        Me.btnTilbakeTilBestilling = New System.Windows.Forms.Button()
        Me.gboxRegistrerBruker = New System.Windows.Forms.GroupBox()
        Me.btnRegistrerBruker = New System.Windows.Forms.Button()
        Me.gboxEksisterendeKunde = New System.Windows.Forms.GroupBox()
        Me.txtVelgSykkelIDForBestilling = New System.Windows.Forms.TextBox()
        Me.btnBestillForKunde = New System.Windows.Forms.Button()
        Me.lblDisplay10 = New System.Windows.Forms.Label()
        Me.txtVelgKundeIdForBestilling = New System.Windows.Forms.TextBox()
        Me.gboxOpprettNyAvdeling = New System.Windows.Forms.GroupBox()
        Me.btnRedigerAvdelinger = New System.Windows.Forms.Button()
        Me.btnApneAdministrer = New System.Windows.Forms.Button()
        Me.btnHentRapport = New System.Windows.Forms.Button()
        Me.lboxVisOmsetningMåned = New System.Windows.Forms.ListBox()
        Me.lboxVisOmsetningSykkelmerke = New System.Windows.Forms.ListBox()
        Me.gboxBestillingsSkjema.SuspendLayout()
        Me.gboxLoggInn.SuspendLayout()
        Me.gboxRegistrerBruker.SuspendLayout()
        Me.gboxEksisterendeKunde.SuspendLayout()
        Me.gboxOpprettNyAvdeling.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxSykkelType
        '
        Me.cboxSykkelType.FormattingEnabled = True
        Me.cboxSykkelType.Items.AddRange(New Object() {"Terrengsykkel", "Downhillsykkel", "Racer", "Barnesykkel", "Tilbehør"})
        Me.cboxSykkelType.Location = New System.Drawing.Point(9, 47)
        Me.cboxSykkelType.Name = "cboxSykkelType"
        Me.cboxSykkelType.Size = New System.Drawing.Size(121, 21)
        Me.cboxSykkelType.TabIndex = 0
        '
        'lboxSykkelValg
        '
        Me.lboxSykkelValg.FormattingEnabled = True
        Me.lboxSykkelValg.Location = New System.Drawing.Point(151, 47)
        Me.lboxSykkelValg.Name = "lboxSykkelValg"
        Me.lboxSykkelValg.Size = New System.Drawing.Size(120, 95)
        Me.lboxSykkelValg.TabIndex = 1
        '
        'lboxHovedkonsoll
        '
        Me.lboxHovedkonsoll.FormattingEnabled = True
        Me.lboxHovedkonsoll.Location = New System.Drawing.Point(420, 47)
        Me.lboxHovedkonsoll.Name = "lboxHovedkonsoll"
        Me.lboxHovedkonsoll.Size = New System.Drawing.Size(177, 199)
        Me.lboxHovedkonsoll.TabIndex = 2
        '
        'lblDisplay1
        '
        Me.lblDisplay1.AutoSize = True
        Me.lblDisplay1.Location = New System.Drawing.Point(6, 27)
        Me.lblDisplay1.Name = "lblDisplay1"
        Me.lblDisplay1.Size = New System.Drawing.Size(99, 13)
        Me.lblDisplay1.TabIndex = 3
        Me.lblDisplay1.Text = "Velg en sykkeltype:"
        '
        'btnBestill
        '
        Me.btnBestill.Location = New System.Drawing.Point(492, 275)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(75, 23)
        Me.btnBestill.TabIndex = 4
        Me.btnBestill.Text = "Bestill"
        Me.btnBestill.UseVisualStyleBackColor = True
        '
        'lblDisplay8
        '
        Me.lblDisplay8.AutoSize = True
        Me.lblDisplay8.Location = New System.Drawing.Point(420, 28)
        Me.lblDisplay8.Name = "lblDisplay8"
        Me.lblDisplay8.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplay8.TabIndex = 6
        Me.lblDisplay8.Text = "Valgte sykler"
        '
        'lblDisplay9
        '
        Me.lblDisplay9.AutoSize = True
        Me.lblDisplay9.Location = New System.Drawing.Point(148, 27)
        Me.lblDisplay9.Name = "lblDisplay9"
        Me.lblDisplay9.Size = New System.Drawing.Size(79, 13)
        Me.lblDisplay9.TabIndex = 7
        Me.lblDisplay9.Text = "Velg en sykkel:"
        '
        'gboxBestillingsSkjema
        '
        Me.gboxBestillingsSkjema.Controls.Add(Me.chboxBarnesete)
        Me.gboxBestillingsSkjema.Controls.Add(Me.chboxSykkelhjelm)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay7)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay6)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay5)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay4)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay3)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay2)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtTilDatoÅr)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtTilDatoDag)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtTilDatoMåned)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtFraDatoDag)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtFraDatoÅr)
        Me.gboxBestillingsSkjema.Controls.Add(Me.txtFraDatoMåned)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblViservalgtSykkelID)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay12)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay11)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDato)
        Me.gboxBestillingsSkjema.Controls.Add(Me.btnFjernSykkel)
        Me.gboxBestillingsSkjema.Controls.Add(Me.btnLeggTilSykkel)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lboxHovedkonsoll)
        Me.gboxBestillingsSkjema.Controls.Add(Me.cboxSykkelType)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay9)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lboxSykkelValg)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay8)
        Me.gboxBestillingsSkjema.Controls.Add(Me.lblDisplay1)
        Me.gboxBestillingsSkjema.Controls.Add(Me.btnBestill)
        Me.gboxBestillingsSkjema.Location = New System.Drawing.Point(12, 12)
        Me.gboxBestillingsSkjema.Name = "gboxBestillingsSkjema"
        Me.gboxBestillingsSkjema.Size = New System.Drawing.Size(612, 343)
        Me.gboxBestillingsSkjema.TabIndex = 8
        Me.gboxBestillingsSkjema.TabStop = False
        Me.gboxBestillingsSkjema.Text = "Bestillingsskjema"
        '
        'chboxBarnesete
        '
        Me.chboxBarnesete.AutoSize = True
        Me.chboxBarnesete.Location = New System.Drawing.Point(302, 134)
        Me.chboxBarnesete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chboxBarnesete.Name = "chboxBarnesete"
        Me.chboxBarnesete.Size = New System.Drawing.Size(74, 17)
        Me.chboxBarnesete.TabIndex = 38
        Me.chboxBarnesete.Text = "Barnesete"
        Me.chboxBarnesete.UseVisualStyleBackColor = True
        '
        'chboxSykkelhjelm
        '
        Me.chboxSykkelhjelm.AutoSize = True
        Me.chboxSykkelhjelm.Location = New System.Drawing.Point(302, 112)
        Me.chboxSykkelhjelm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chboxSykkelhjelm.Name = "chboxSykkelhjelm"
        Me.chboxSykkelhjelm.Size = New System.Drawing.Size(82, 17)
        Me.chboxSykkelhjelm.TabIndex = 37
        Me.chboxSykkelhjelm.Text = "Sykkelhjelm"
        Me.chboxSykkelhjelm.UseVisualStyleBackColor = True
        '
        'lblDisplay7
        '
        Me.lblDisplay7.AutoSize = True
        Me.lblDisplay7.Location = New System.Drawing.Point(251, 232)
        Me.lblDisplay7.Name = "lblDisplay7"
        Me.lblDisplay7.Size = New System.Drawing.Size(27, 13)
        Me.lblDisplay7.TabIndex = 36
        Me.lblDisplay7.Text = "Dag"
        '
        'lblDisplay6
        '
        Me.lblDisplay6.AutoSize = True
        Me.lblDisplay6.Location = New System.Drawing.Point(290, 232)
        Me.lblDisplay6.Name = "lblDisplay6"
        Me.lblDisplay6.Size = New System.Drawing.Size(40, 13)
        Me.lblDisplay6.TabIndex = 35
        Me.lblDisplay6.Text = "Måned"
        '
        'lblDisplay5
        '
        Me.lblDisplay5.AutoSize = True
        Me.lblDisplay5.Location = New System.Drawing.Point(337, 232)
        Me.lblDisplay5.Name = "lblDisplay5"
        Me.lblDisplay5.Size = New System.Drawing.Size(17, 13)
        Me.lblDisplay5.TabIndex = 34
        Me.lblDisplay5.Text = "År"
        '
        'lblDisplay4
        '
        Me.lblDisplay4.AutoSize = True
        Me.lblDisplay4.Location = New System.Drawing.Point(334, 174)
        Me.lblDisplay4.Name = "lblDisplay4"
        Me.lblDisplay4.Size = New System.Drawing.Size(17, 13)
        Me.lblDisplay4.TabIndex = 33
        Me.lblDisplay4.Text = "År"
        '
        'lblDisplay3
        '
        Me.lblDisplay3.AutoSize = True
        Me.lblDisplay3.Location = New System.Drawing.Point(290, 174)
        Me.lblDisplay3.Name = "lblDisplay3"
        Me.lblDisplay3.Size = New System.Drawing.Size(40, 13)
        Me.lblDisplay3.TabIndex = 32
        Me.lblDisplay3.Text = "Måned"
        '
        'lblDisplay2
        '
        Me.lblDisplay2.AutoSize = True
        Me.lblDisplay2.Location = New System.Drawing.Point(251, 175)
        Me.lblDisplay2.Name = "lblDisplay2"
        Me.lblDisplay2.Size = New System.Drawing.Size(27, 13)
        Me.lblDisplay2.TabIndex = 31
        Me.lblDisplay2.Text = "Dag"
        '
        'txtTilDatoÅr
        '
        Me.txtTilDatoÅr.Location = New System.Drawing.Point(330, 249)
        Me.txtTilDatoÅr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTilDatoÅr.Name = "txtTilDatoÅr"
        Me.txtTilDatoÅr.Size = New System.Drawing.Size(48, 20)
        Me.txtTilDatoÅr.TabIndex = 30
        '
        'txtTilDatoDag
        '
        Me.txtTilDatoDag.Location = New System.Drawing.Point(256, 249)
        Me.txtTilDatoDag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTilDatoDag.Name = "txtTilDatoDag"
        Me.txtTilDatoDag.Size = New System.Drawing.Size(23, 20)
        Me.txtTilDatoDag.TabIndex = 29
        '
        'txtTilDatoMåned
        '
        Me.txtTilDatoMåned.Location = New System.Drawing.Point(294, 249)
        Me.txtTilDatoMåned.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTilDatoMåned.Name = "txtTilDatoMåned"
        Me.txtTilDatoMåned.Size = New System.Drawing.Size(23, 20)
        Me.txtTilDatoMåned.TabIndex = 28
        '
        'txtFraDatoDag
        '
        Me.txtFraDatoDag.Location = New System.Drawing.Point(256, 191)
        Me.txtFraDatoDag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFraDatoDag.Name = "txtFraDatoDag"
        Me.txtFraDatoDag.Size = New System.Drawing.Size(23, 20)
        Me.txtFraDatoDag.TabIndex = 27
        '
        'txtFraDatoÅr
        '
        Me.txtFraDatoÅr.Location = New System.Drawing.Point(330, 191)
        Me.txtFraDatoÅr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFraDatoÅr.Name = "txtFraDatoÅr"
        Me.txtFraDatoÅr.Size = New System.Drawing.Size(48, 20)
        Me.txtFraDatoÅr.TabIndex = 25
        '
        'txtFraDatoMåned
        '
        Me.txtFraDatoMåned.Location = New System.Drawing.Point(294, 191)
        Me.txtFraDatoMåned.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFraDatoMåned.Name = "txtFraDatoMåned"
        Me.txtFraDatoMåned.Size = New System.Drawing.Size(23, 20)
        Me.txtFraDatoMåned.TabIndex = 24
        '
        'lblViservalgtSykkelID
        '
        Me.lblViservalgtSykkelID.Location = New System.Drawing.Point(292, 280)
        Me.lblViservalgtSykkelID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblViservalgtSykkelID.Name = "lblViservalgtSykkelID"
        Me.lblViservalgtSykkelID.Size = New System.Drawing.Size(75, 14)
        Me.lblViservalgtSykkelID.TabIndex = 22
        '
        'lblDisplay12
        '
        Me.lblDisplay12.AutoSize = True
        Me.lblDisplay12.Location = New System.Drawing.Point(198, 249)
        Me.lblDisplay12.Name = "lblDisplay12"
        Me.lblDisplay12.Size = New System.Drawing.Size(42, 13)
        Me.lblDisplay12.TabIndex = 20
        Me.lblDisplay12.Text = "Til dato"
        '
        'lblDisplay11
        '
        Me.lblDisplay11.AutoSize = True
        Me.lblDisplay11.Location = New System.Drawing.Point(198, 193)
        Me.lblDisplay11.Name = "lblDisplay11"
        Me.lblDisplay11.Size = New System.Drawing.Size(46, 13)
        Me.lblDisplay11.TabIndex = 18
        Me.lblDisplay11.Text = "Fra dato"
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.Location = New System.Drawing.Point(420, 280)
        Me.lblDato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(30, 13)
        Me.lblDato.TabIndex = 12
        Me.lblDato.Text = "Dato"
        '
        'btnFjernSykkel
        '
        Me.btnFjernSykkel.Location = New System.Drawing.Point(300, 81)
        Me.btnFjernSykkel.Name = "btnFjernSykkel"
        Me.btnFjernSykkel.Size = New System.Drawing.Size(106, 23)
        Me.btnFjernSykkel.TabIndex = 11
        Me.btnFjernSykkel.Text = "<- Fjern sykkel"
        Me.btnFjernSykkel.UseVisualStyleBackColor = True
        '
        'btnLeggTilSykkel
        '
        Me.btnLeggTilSykkel.Location = New System.Drawing.Point(300, 47)
        Me.btnLeggTilSykkel.Name = "btnLeggTilSykkel"
        Me.btnLeggTilSykkel.Size = New System.Drawing.Size(106, 23)
        Me.btnLeggTilSykkel.TabIndex = 10
        Me.btnLeggTilSykkel.Text = "Legg til sykkel ->"
        Me.btnLeggTilSykkel.UseVisualStyleBackColor = True
        '
        'lblSykkelID
        '
        Me.lblSykkelID.AutoSize = True
        Me.lblSykkelID.Location = New System.Drawing.Point(30, 45)
        Me.lblSykkelID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSykkelID.Name = "lblSykkelID"
        Me.lblSykkelID.Size = New System.Drawing.Size(50, 13)
        Me.lblSykkelID.TabIndex = 21
        Me.lblSykkelID.Text = "SykkelID"
        '
        'gboxLoggInn
        '
        Me.gboxLoggInn.Controls.Add(Me.btnTilbakeTilBestilling)
        Me.gboxLoggInn.Controls.Add(Me.gboxRegistrerBruker)
        Me.gboxLoggInn.Controls.Add(Me.gboxEksisterendeKunde)
        Me.gboxLoggInn.Location = New System.Drawing.Point(644, 12)
        Me.gboxLoggInn.Name = "gboxLoggInn"
        Me.gboxLoggInn.Size = New System.Drawing.Size(294, 255)
        Me.gboxLoggInn.TabIndex = 8
        Me.gboxLoggInn.TabStop = False
        Me.gboxLoggInn.Visible = False
        '
        'btnTilbakeTilBestilling
        '
        Me.btnTilbakeTilBestilling.Location = New System.Drawing.Point(171, 223)
        Me.btnTilbakeTilBestilling.Name = "btnTilbakeTilBestilling"
        Me.btnTilbakeTilBestilling.Size = New System.Drawing.Size(117, 23)
        Me.btnTilbakeTilBestilling.TabIndex = 7
        Me.btnTilbakeTilBestilling.Text = "Gå tilbake til bestilling"
        Me.btnTilbakeTilBestilling.UseVisualStyleBackColor = True
        '
        'gboxRegistrerBruker
        '
        Me.gboxRegistrerBruker.Controls.Add(Me.btnRegistrerBruker)
        Me.gboxRegistrerBruker.Location = New System.Drawing.Point(18, 125)
        Me.gboxRegistrerBruker.Name = "gboxRegistrerBruker"
        Me.gboxRegistrerBruker.Size = New System.Drawing.Size(252, 82)
        Me.gboxRegistrerBruker.TabIndex = 6
        Me.gboxRegistrerBruker.TabStop = False
        Me.gboxRegistrerBruker.Text = "Registrer ny kunde"
        '
        'btnRegistrerBruker
        '
        Me.btnRegistrerBruker.Location = New System.Drawing.Point(67, 32)
        Me.btnRegistrerBruker.Name = "btnRegistrerBruker"
        Me.btnRegistrerBruker.Size = New System.Drawing.Size(125, 23)
        Me.btnRegistrerBruker.TabIndex = 5
        Me.btnRegistrerBruker.Text = "Registrer bruker"
        Me.btnRegistrerBruker.UseVisualStyleBackColor = True
        '
        'gboxEksisterendeKunde
        '
        Me.gboxEksisterendeKunde.Controls.Add(Me.txtVelgSykkelIDForBestilling)
        Me.gboxEksisterendeKunde.Controls.Add(Me.btnBestillForKunde)
        Me.gboxEksisterendeKunde.Controls.Add(Me.lblSykkelID)
        Me.gboxEksisterendeKunde.Controls.Add(Me.lblDisplay10)
        Me.gboxEksisterendeKunde.Controls.Add(Me.txtVelgKundeIdForBestilling)
        Me.gboxEksisterendeKunde.Location = New System.Drawing.Point(18, 19)
        Me.gboxEksisterendeKunde.Name = "gboxEksisterendeKunde"
        Me.gboxEksisterendeKunde.Size = New System.Drawing.Size(249, 100)
        Me.gboxEksisterendeKunde.TabIndex = 5
        Me.gboxEksisterendeKunde.TabStop = False
        Me.gboxEksisterendeKunde.Text = "Allerede eksisterende kunde"
        '
        'txtVelgSykkelIDForBestilling
        '
        Me.txtVelgSykkelIDForBestilling.Location = New System.Drawing.Point(105, 45)
        Me.txtVelgSykkelIDForBestilling.Name = "txtVelgSykkelIDForBestilling"
        Me.txtVelgSykkelIDForBestilling.Size = New System.Drawing.Size(100, 20)
        Me.txtVelgSykkelIDForBestilling.TabIndex = 22
        '
        'btnBestillForKunde
        '
        Me.btnBestillForKunde.Location = New System.Drawing.Point(105, 70)
        Me.btnBestillForKunde.Name = "btnBestillForKunde"
        Me.btnBestillForKunde.Size = New System.Drawing.Size(108, 23)
        Me.btnBestillForKunde.TabIndex = 4
        Me.btnBestillForKunde.Text = "Registrer bestilling"
        Me.btnBestillForKunde.UseVisualStyleBackColor = True
        '
        'lblDisplay10
        '
        Me.lblDisplay10.AutoSize = True
        Me.lblDisplay10.Location = New System.Drawing.Point(30, 24)
        Me.lblDisplay10.Name = "lblDisplay10"
        Me.lblDisplay10.Size = New System.Drawing.Size(49, 13)
        Me.lblDisplay10.TabIndex = 2
        Me.lblDisplay10.Text = "KundeID"
        '
        'txtVelgKundeIdForBestilling
        '
        Me.txtVelgKundeIdForBestilling.Location = New System.Drawing.Point(105, 24)
        Me.txtVelgKundeIdForBestilling.Name = "txtVelgKundeIdForBestilling"
        Me.txtVelgKundeIdForBestilling.Size = New System.Drawing.Size(100, 20)
        Me.txtVelgKundeIdForBestilling.TabIndex = 0
        '
        'gboxOpprettNyAvdeling
        '
        Me.gboxOpprettNyAvdeling.Controls.Add(Me.btnRedigerAvdelinger)
        Me.gboxOpprettNyAvdeling.Location = New System.Drawing.Point(644, 273)
        Me.gboxOpprettNyAvdeling.Name = "gboxOpprettNyAvdeling"
        Me.gboxOpprettNyAvdeling.Size = New System.Drawing.Size(294, 82)
        Me.gboxOpprettNyAvdeling.TabIndex = 10
        Me.gboxOpprettNyAvdeling.TabStop = False
        Me.gboxOpprettNyAvdeling.Text = "Opprett ny avdeling"
        '
        'btnRedigerAvdelinger
        '
        Me.btnRedigerAvdelinger.Location = New System.Drawing.Point(67, 32)
        Me.btnRedigerAvdelinger.Name = "btnRedigerAvdelinger"
        Me.btnRedigerAvdelinger.Size = New System.Drawing.Size(125, 23)
        Me.btnRedigerAvdelinger.TabIndex = 5
        Me.btnRedigerAvdelinger.Text = "Rediger avdelinger"
        Me.btnRedigerAvdelinger.UseVisualStyleBackColor = True
        '
        'btnApneAdministrer
        '
        Me.btnApneAdministrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnApneAdministrer.Location = New System.Drawing.Point(432, 361)
        Me.btnApneAdministrer.Name = "btnApneAdministrer"
        Me.btnApneAdministrer.Size = New System.Drawing.Size(246, 59)
        Me.btnApneAdministrer.TabIndex = 11
        Me.btnApneAdministrer.Text = "Administrer sykler"
        Me.btnApneAdministrer.UseVisualStyleBackColor = True
        '
        'btnHentRapport
        '
        Me.btnHentRapport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHentRapport.Location = New System.Drawing.Point(959, 12)
        Me.btnHentRapport.Name = "btnHentRapport"
        Me.btnHentRapport.Size = New System.Drawing.Size(105, 23)
        Me.btnHentRapport.TabIndex = 12
        Me.btnHentRapport.Text = "Hent ut rapport"
        Me.btnHentRapport.UseVisualStyleBackColor = False
        '
        'lboxVisOmsetningMåned
        '
        Me.lboxVisOmsetningMåned.FormattingEnabled = True
        Me.lboxVisOmsetningMåned.Location = New System.Drawing.Point(959, 40)
        Me.lboxVisOmsetningMåned.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lboxVisOmsetningMåned.Name = "lboxVisOmsetningMåned"
        Me.lboxVisOmsetningMåned.Size = New System.Drawing.Size(106, 147)
        Me.lboxVisOmsetningMåned.TabIndex = 13
        '
        'lboxVisOmsetningSykkelmerke
        '
        Me.lboxVisOmsetningSykkelmerke.FormattingEnabled = True
        Me.lboxVisOmsetningSykkelmerke.Location = New System.Drawing.Point(959, 195)
        Me.lboxVisOmsetningSykkelmerke.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lboxVisOmsetningSykkelmerke.Name = "lboxVisOmsetningSykkelmerke"
        Me.lboxVisOmsetningSykkelmerke.Size = New System.Drawing.Size(106, 160)
        Me.lboxVisOmsetningSykkelmerke.TabIndex = 14
        '
        'bestillSykkel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 432)
        Me.Controls.Add(Me.lboxVisOmsetningSykkelmerke)
        Me.Controls.Add(Me.lboxVisOmsetningMåned)
        Me.Controls.Add(Me.btnHentRapport)
        Me.Controls.Add(Me.btnApneAdministrer)
        Me.Controls.Add(Me.gboxOpprettNyAvdeling)
        Me.Controls.Add(Me.gboxLoggInn)
        Me.Controls.Add(Me.gboxBestillingsSkjema)
        Me.Name = "bestillSykkel"
        Me.Text = "Bestill en sykkel"
        Me.gboxBestillingsSkjema.ResumeLayout(False)
        Me.gboxBestillingsSkjema.PerformLayout()
        Me.gboxLoggInn.ResumeLayout(False)
        Me.gboxRegistrerBruker.ResumeLayout(False)
        Me.gboxEksisterendeKunde.ResumeLayout(False)
        Me.gboxEksisterendeKunde.PerformLayout()
        Me.gboxOpprettNyAvdeling.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboxSykkelType As ComboBox
    Friend WithEvents lboxSykkelValg As ListBox
    Friend WithEvents lblDisplay1 As Label
    Friend WithEvents btnBestill As Button
    Friend WithEvents lblDisplay8 As Label
    Friend WithEvents lblDisplay9 As Label
    Friend WithEvents gboxBestillingsSkjema As GroupBox
    Friend WithEvents gboxLoggInn As GroupBox
    Friend WithEvents lblDisplay10 As Label
    Friend WithEvents txtVelgKundeIdForBestilling As TextBox
    Friend WithEvents gboxRegistrerBruker As GroupBox
    Friend WithEvents btnRegistrerBruker As Button
    Friend WithEvents gboxEksisterendeKunde As GroupBox
    Friend WithEvents btnTilbakeTilBestilling As Button
    Friend WithEvents btnBestillForKunde As Button
    Friend WithEvents btnFjernSykkel As Button
    Friend WithEvents btnLeggTilSykkel As Button
    Friend WithEvents gboxOpprettNyAvdeling As GroupBox
    Friend WithEvents btnRedigerAvdelinger As Button
    Friend WithEvents lblDato As Label
    Friend WithEvents lblDisplay12 As Label
    Friend WithEvents lblViservalgtSykkelID As Label
    Friend WithEvents lblSykkelID As Label
    Friend WithEvents txtVelgSykkelIDForBestilling As TextBox
    Friend WithEvents btnApneAdministrer As Button
    Friend WithEvents lblDisplay4 As Label
    Friend WithEvents lblDisplay3 As Label
    Friend WithEvents lblDisplay2 As Label
    Friend WithEvents txtTilDatoÅr As TextBox
    Friend WithEvents txtTilDatoDag As TextBox
    Friend WithEvents txtTilDatoMåned As TextBox
    Friend WithEvents txtFraDatoDag As TextBox
    Friend WithEvents txtFraDatoÅr As TextBox
    Friend WithEvents txtFraDatoMåned As TextBox
    Friend WithEvents lblDisplay11 As Label
    Friend WithEvents lblDisplay7 As Label
    Friend WithEvents lblDisplay6 As Label
    Friend WithEvents lblDisplay5 As Label
    Friend WithEvents lboxHovedkonsoll As ListBox
    Friend WithEvents btnHentRapport As Button
    Friend WithEvents lboxVisOmsetningMåned As ListBox
    Friend WithEvents lboxVisOmsetningSykkelmerke As ListBox
    Friend WithEvents chboxBarnesete As CheckBox
    Friend WithEvents chboxSykkelhjelm As CheckBox
End Class
