<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administrerSykler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboxSykkelType = New System.Windows.Forms.ComboBox()
        Me.lboxSykkelValg = New System.Windows.Forms.ListBox()
        Me.lblDisplay1 = New System.Windows.Forms.Label()
        Me.lblDisplay4 = New System.Windows.Forms.Label()
        Me.cboxVelgAvdeling = New System.Windows.Forms.ComboBox()
        Me.lblDisplay5 = New System.Windows.Forms.Label()
        Me.lboxHandlinger = New System.Windows.Forms.ListBox()
        Me.lblDisplay6 = New System.Windows.Forms.Label()
        Me.btnUtfor = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDisplay7 = New System.Windows.Forms.Label()
        Me.lblDisplay8 = New System.Windows.Forms.Label()
        Me.lblDisplay9 = New System.Windows.Forms.Label()
        Me.txtMerke = New System.Windows.Forms.TextBox()
        Me.lblDisplay10 = New System.Windows.Forms.Label()
        Me.txtRamme = New System.Windows.Forms.TextBox()
        Me.txtSykkelType = New System.Windows.Forms.TextBox()
        Me.lblDisplay2 = New System.Windows.Forms.Label()
        Me.txtGirsystem = New System.Windows.Forms.TextBox()
        Me.cboxAvdeling = New System.Windows.Forms.ComboBox()
        Me.rtbUtstyrsbegrensing = New System.Windows.Forms.RichTextBox()
        Me.lblDisplay11 = New System.Windows.Forms.Label()
        Me.btnRegistrerNySykkel = New System.Windows.Forms.Button()
        Me.gboxVelgSykkel = New System.Windows.Forms.GroupBox()
        Me.gboxSykkelDetaljer = New System.Windows.Forms.GroupBox()
        Me.gboxSykkelListe = New System.Windows.Forms.GroupBox()
        Me.btnHenteListe = New System.Windows.Forms.Button()
        Me.btnReparereListe = New System.Windows.Forms.Button()
        Me.btnForSentListe = New System.Windows.Forms.Button()
        Me.lblDisplay3 = New System.Windows.Forms.Label()
        Me.lboxListe = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gboxVelgSykkel.SuspendLayout()
        Me.gboxSykkelDetaljer.SuspendLayout()
        Me.gboxSykkelListe.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxSykkelType
        '
        Me.cboxSykkelType.FormattingEnabled = True
        Me.cboxSykkelType.Location = New System.Drawing.Point(56, 29)
        Me.cboxSykkelType.Name = "cboxSykkelType"
        Me.cboxSykkelType.Size = New System.Drawing.Size(121, 21)
        Me.cboxSykkelType.TabIndex = 0
        '
        'lboxSykkelValg
        '
        Me.lboxSykkelValg.FormattingEnabled = True
        Me.lboxSykkelValg.Location = New System.Drawing.Point(183, 29)
        Me.lboxSykkelValg.Name = "lboxSykkelValg"
        Me.lboxSykkelValg.Size = New System.Drawing.Size(120, 95)
        Me.lboxSykkelValg.TabIndex = 1
        '
        'lblDisplay1
        '
        Me.lblDisplay1.AutoSize = True
        Me.lblDisplay1.Location = New System.Drawing.Point(56, 13)
        Me.lblDisplay1.Name = "lblDisplay1"
        Me.lblDisplay1.Size = New System.Drawing.Size(90, 13)
        Me.lblDisplay1.TabIndex = 2
        Me.lblDisplay1.Text = "Velg produkttype:"
        '
        'lblDisplay4
        '
        Me.lblDisplay4.AutoSize = True
        Me.lblDisplay4.Location = New System.Drawing.Point(180, 13)
        Me.lblDisplay4.Name = "lblDisplay4"
        Me.lblDisplay4.Size = New System.Drawing.Size(70, 13)
        Me.lblDisplay4.TabIndex = 3
        Me.lblDisplay4.Text = "Velg produkt:"
        '
        'cboxVelgAvdeling
        '
        Me.cboxVelgAvdeling.FormattingEnabled = True
        Me.cboxVelgAvdeling.Location = New System.Drawing.Point(183, 146)
        Me.cboxVelgAvdeling.Name = "cboxVelgAvdeling"
        Me.cboxVelgAvdeling.Size = New System.Drawing.Size(121, 21)
        Me.cboxVelgAvdeling.TabIndex = 0
        '
        'lblDisplay5
        '
        Me.lblDisplay5.AutoSize = True
        Me.lblDisplay5.Location = New System.Drawing.Point(180, 130)
        Me.lblDisplay5.Name = "lblDisplay5"
        Me.lblDisplay5.Size = New System.Drawing.Size(73, 13)
        Me.lblDisplay5.TabIndex = 2
        Me.lblDisplay5.Text = "Velg lokasjon:"
        '
        'lboxHandlinger
        '
        Me.lboxHandlinger.FormattingEnabled = True
        Me.lboxHandlinger.Items.AddRange(New Object() {"Registrer som levert fra valgte lokasjon", "Hent info", "Rediger info", "Hent data", "Marker for reparasjon"})
        Me.lboxHandlinger.Location = New System.Drawing.Point(309, 29)
        Me.lboxHandlinger.Name = "lboxHandlinger"
        Me.lboxHandlinger.Size = New System.Drawing.Size(196, 95)
        Me.lboxHandlinger.TabIndex = 1
        '
        'lblDisplay6
        '
        Me.lblDisplay6.AutoSize = True
        Me.lblDisplay6.Location = New System.Drawing.Point(306, 13)
        Me.lblDisplay6.Name = "lblDisplay6"
        Me.lblDisplay6.Size = New System.Drawing.Size(74, 13)
        Me.lblDisplay6.TabIndex = 3
        Me.lblDisplay6.Text = "Velg handling:"
        '
        'btnUtfor
        '
        Me.btnUtfor.Location = New System.Drawing.Point(369, 130)
        Me.btnUtfor.Name = "btnUtfor"
        Me.btnUtfor.Size = New System.Drawing.Size(91, 50)
        Me.btnUtfor.TabIndex = 4
        Me.btnUtfor.Text = "Utfør handling"
        Me.btnUtfor.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.75525!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.24475!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMerke, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRamme, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSykkelType, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGirsystem, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cboxAvdeling, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rtbUtstyrsbegrensing, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDisplay11, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 314)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblDisplay7
        '
        Me.lblDisplay7.AutoSize = True
        Me.lblDisplay7.Location = New System.Drawing.Point(3, 213)
        Me.lblDisplay7.Name = "lblDisplay7"
        Me.lblDisplay7.Size = New System.Drawing.Size(97, 13)
        Me.lblDisplay7.TabIndex = 12
        Me.lblDisplay7.Text = "Utstyrsbegrensning"
        '
        'lblDisplay8
        '
        Me.lblDisplay8.AutoSize = True
        Me.lblDisplay8.Location = New System.Drawing.Point(3, 167)
        Me.lblDisplay8.Name = "lblDisplay8"
        Me.lblDisplay8.Size = New System.Drawing.Size(52, 13)
        Me.lblDisplay8.TabIndex = 9
        Me.lblDisplay8.Text = "Girsystem"
        '
        'lblDisplay9
        '
        Me.lblDisplay9.AutoSize = True
        Me.lblDisplay9.Location = New System.Drawing.Point(3, 85)
        Me.lblDisplay9.Name = "lblDisplay9"
        Me.lblDisplay9.Size = New System.Drawing.Size(43, 13)
        Me.lblDisplay9.TabIndex = 4
        Me.lblDisplay9.Text = "Ramme"
        '
        'txtMerke
        '
        Me.txtMerke.Location = New System.Drawing.Point(131, 44)
        Me.txtMerke.Name = "txtMerke"
        Me.txtMerke.Size = New System.Drawing.Size(140, 20)
        Me.txtMerke.TabIndex = 3
        '
        'lblDisplay10
        '
        Me.lblDisplay10.AutoSize = True
        Me.lblDisplay10.Location = New System.Drawing.Point(3, 41)
        Me.lblDisplay10.Name = "lblDisplay10"
        Me.lblDisplay10.Size = New System.Drawing.Size(37, 13)
        Me.lblDisplay10.TabIndex = 2
        Me.lblDisplay10.Text = "Merke"
        '
        'txtRamme
        '
        Me.txtRamme.Location = New System.Drawing.Point(131, 88)
        Me.txtRamme.Name = "txtRamme"
        Me.txtRamme.Size = New System.Drawing.Size(140, 20)
        Me.txtRamme.TabIndex = 5
        '
        'txtSykkelType
        '
        Me.txtSykkelType.Location = New System.Drawing.Point(131, 128)
        Me.txtSykkelType.Name = "txtSykkelType"
        Me.txtSykkelType.Size = New System.Drawing.Size(140, 20)
        Me.txtSykkelType.TabIndex = 6
        '
        'lblDisplay2
        '
        Me.lblDisplay2.AutoSize = True
        Me.lblDisplay2.Location = New System.Drawing.Point(3, 125)
        Me.lblDisplay2.Name = "lblDisplay2"
        Me.lblDisplay2.Size = New System.Drawing.Size(59, 13)
        Me.lblDisplay2.TabIndex = 11
        Me.lblDisplay2.Text = "Sykkeltype"
        '
        'txtGirsystem
        '
        Me.txtGirsystem.Location = New System.Drawing.Point(131, 170)
        Me.txtGirsystem.Name = "txtGirsystem"
        Me.txtGirsystem.Size = New System.Drawing.Size(140, 20)
        Me.txtGirsystem.TabIndex = 13
        '
        'cboxAvdeling
        '
        Me.cboxAvdeling.FormattingEnabled = True
        Me.cboxAvdeling.Location = New System.Drawing.Point(131, 3)
        Me.cboxAvdeling.Name = "cboxAvdeling"
        Me.cboxAvdeling.Size = New System.Drawing.Size(140, 21)
        Me.cboxAvdeling.TabIndex = 14
        '
        'rtbUtstyrsbegrensing
        '
        Me.rtbUtstyrsbegrensing.Location = New System.Drawing.Point(131, 216)
        Me.rtbUtstyrsbegrensing.Name = "rtbUtstyrsbegrensing"
        Me.rtbUtstyrsbegrensing.Size = New System.Drawing.Size(140, 67)
        Me.rtbUtstyrsbegrensing.TabIndex = 15
        Me.rtbUtstyrsbegrensing.Text = ""
        '
        'lblDisplay11
        '
        Me.lblDisplay11.AutoSize = True
        Me.lblDisplay11.Location = New System.Drawing.Point(3, 0)
        Me.lblDisplay11.Name = "lblDisplay11"
        Me.lblDisplay11.Size = New System.Drawing.Size(98, 13)
        Me.lblDisplay11.TabIndex = 1
        Me.lblDisplay11.Text = "Registrert avdeling:"
        '
        'btnRegistrerNySykkel
        '
        Me.btnRegistrerNySykkel.Location = New System.Drawing.Point(169, 339)
        Me.btnRegistrerNySykkel.Name = "btnRegistrerNySykkel"
        Me.btnRegistrerNySykkel.Size = New System.Drawing.Size(123, 23)
        Me.btnRegistrerNySykkel.TabIndex = 6
        Me.btnRegistrerNySykkel.Text = "Registrer ny sykkel"
        Me.btnRegistrerNySykkel.UseVisualStyleBackColor = True
        '
        'gboxVelgSykkel
        '
        Me.gboxVelgSykkel.Controls.Add(Me.lblDisplay1)
        Me.gboxVelgSykkel.Controls.Add(Me.cboxSykkelType)
        Me.gboxVelgSykkel.Controls.Add(Me.cboxVelgAvdeling)
        Me.gboxVelgSykkel.Controls.Add(Me.btnUtfor)
        Me.gboxVelgSykkel.Controls.Add(Me.lboxSykkelValg)
        Me.gboxVelgSykkel.Controls.Add(Me.lblDisplay6)
        Me.gboxVelgSykkel.Controls.Add(Me.lboxHandlinger)
        Me.gboxVelgSykkel.Controls.Add(Me.lblDisplay4)
        Me.gboxVelgSykkel.Controls.Add(Me.lblDisplay5)
        Me.gboxVelgSykkel.Location = New System.Drawing.Point(12, 12)
        Me.gboxVelgSykkel.Name = "gboxVelgSykkel"
        Me.gboxVelgSykkel.Size = New System.Drawing.Size(586, 188)
        Me.gboxVelgSykkel.TabIndex = 7
        Me.gboxVelgSykkel.TabStop = False
        '
        'gboxSykkelDetaljer
        '
        Me.gboxSykkelDetaljer.Controls.Add(Me.TableLayoutPanel1)
        Me.gboxSykkelDetaljer.Controls.Add(Me.btnRegistrerNySykkel)
        Me.gboxSykkelDetaljer.Location = New System.Drawing.Point(12, 206)
        Me.gboxSykkelDetaljer.Name = "gboxSykkelDetaljer"
        Me.gboxSykkelDetaljer.Size = New System.Drawing.Size(300, 380)
        Me.gboxSykkelDetaljer.TabIndex = 8
        Me.gboxSykkelDetaljer.TabStop = False
        '
        'gboxSykkelListe
        '
        Me.gboxSykkelListe.Controls.Add(Me.btnHenteListe)
        Me.gboxSykkelListe.Controls.Add(Me.btnReparereListe)
        Me.gboxSykkelListe.Controls.Add(Me.btnForSentListe)
        Me.gboxSykkelListe.Controls.Add(Me.lblDisplay3)
        Me.gboxSykkelListe.Controls.Add(Me.lboxListe)
        Me.gboxSykkelListe.Location = New System.Drawing.Point(318, 206)
        Me.gboxSykkelListe.Name = "gboxSykkelListe"
        Me.gboxSykkelListe.Size = New System.Drawing.Size(280, 380)
        Me.gboxSykkelListe.TabIndex = 9
        Me.gboxSykkelListe.TabStop = False
        '
        'btnHenteListe
        '
        Me.btnHenteListe.Location = New System.Drawing.Point(198, 156)
        Me.btnHenteListe.Name = "btnHenteListe"
        Me.btnHenteListe.Size = New System.Drawing.Size(75, 48)
        Me.btnHenteListe.TabIndex = 11
        Me.btnHenteListe.Text = "Sykler som må hentes"
        Me.btnHenteListe.UseVisualStyleBackColor = True
        '
        'btnReparereListe
        '
        Me.btnReparereListe.Location = New System.Drawing.Point(198, 102)
        Me.btnReparereListe.Name = "btnReparereListe"
        Me.btnReparereListe.Size = New System.Drawing.Size(75, 48)
        Me.btnReparereListe.TabIndex = 12
        Me.btnReparereListe.Text = "Sykler som må repareres"
        Me.btnReparereListe.UseVisualStyleBackColor = True
        '
        'btnForSentListe
        '
        Me.btnForSentListe.Location = New System.Drawing.Point(198, 48)
        Me.btnForSentListe.Name = "btnForSentListe"
        Me.btnForSentListe.Size = New System.Drawing.Size(75, 48)
        Me.btnForSentListe.TabIndex = 13
        Me.btnForSentListe.Text = "Sykler som er levert for sent"
        Me.btnForSentListe.UseVisualStyleBackColor = True
        '
        'lblDisplay3
        '
        Me.lblDisplay3.AutoSize = True
        Me.lblDisplay3.Location = New System.Drawing.Point(195, 16)
        Me.lblDisplay3.Name = "lblDisplay3"
        Me.lblDisplay3.Size = New System.Drawing.Size(78, 13)
        Me.lblDisplay3.TabIndex = 10
        Me.lblDisplay3.Text = "Hent liste over:"
        '
        'lboxListe
        '
        Me.lboxListe.FormattingEnabled = True
        Me.lboxListe.Location = New System.Drawing.Point(8, 12)
        Me.lboxListe.Name = "lboxListe"
        Me.lboxListe.Size = New System.Drawing.Size(183, 355)
        Me.lboxListe.TabIndex = 0
        '
        'administrerSykler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 618)
        Me.Controls.Add(Me.gboxSykkelListe)
        Me.Controls.Add(Me.gboxSykkelDetaljer)
        Me.Controls.Add(Me.gboxVelgSykkel)
        Me.Name = "administrerSykler"
        Me.Text = "Administrer sykler og tilbehør"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gboxVelgSykkel.ResumeLayout(False)
        Me.gboxVelgSykkel.PerformLayout()
        Me.gboxSykkelDetaljer.ResumeLayout(False)
        Me.gboxSykkelListe.ResumeLayout(False)
        Me.gboxSykkelListe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboxSykkelType As ComboBox
    Friend WithEvents lboxSykkelValg As ListBox
    Friend WithEvents lblDisplay1 As Label
    Friend WithEvents lblDisplay4 As Label
    Friend WithEvents cboxVelgAvdeling As ComboBox
    Friend WithEvents lblDisplay5 As Label
    Friend WithEvents lboxHandlinger As ListBox
    Friend WithEvents lblDisplay6 As Label
    Friend WithEvents btnUtfor As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDisplay7 As Label
    Friend WithEvents lblDisplay8 As Label
    Friend WithEvents lblDisplay9 As Label
    Friend WithEvents txtMerke As TextBox
    Friend WithEvents lblDisplay10 As Label
    Friend WithEvents lblDisplay11 As Label
    Friend WithEvents txtRamme As TextBox
    Friend WithEvents txtSykkelType As TextBox
    Friend WithEvents lblDisplay2 As Label
    Friend WithEvents txtGirsystem As TextBox
    Friend WithEvents cboxAvdeling As ComboBox
    Friend WithEvents rtbUtstyrsbegrensing As RichTextBox
    Friend WithEvents btnRegistrerNySykkel As Button
    Friend WithEvents gboxVelgSykkel As GroupBox
    Friend WithEvents gboxSykkelDetaljer As GroupBox
    Friend WithEvents gboxSykkelListe As GroupBox
    Friend WithEvents btnHenteListe As Button
    Friend WithEvents btnReparereListe As Button
    Friend WithEvents btnForSentListe As Button
    Friend WithEvents lblDisplay3 As Label
    Friend WithEvents lboxListe As ListBox
End Class
