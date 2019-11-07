<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrerBruker
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
        Me.tlpBrukerRegistrering = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDisplay3 = New System.Windows.Forms.Label()
        Me.txtBrukerEtternavn = New System.Windows.Forms.TextBox()
        Me.lblDisplay2 = New System.Windows.Forms.Label()
        Me.lblDisplay1 = New System.Windows.Forms.Label()
        Me.txtBrukerFornavn = New System.Windows.Forms.TextBox()
        Me.dtpBrukerFodselsdato = New System.Windows.Forms.DateTimePicker()
        Me.txtBrukerPostnr = New System.Windows.Forms.TextBox()
        Me.lblDisplay6 = New System.Windows.Forms.Label()
        Me.lblDisplay4 = New System.Windows.Forms.Label()
        Me.txtBrukerPoststed = New System.Windows.Forms.TextBox()
        Me.txtBrukerEpost = New System.Windows.Forms.TextBox()
        Me.lblDisplay5 = New System.Windows.Forms.Label()
        Me.gboxRegistrer = New System.Windows.Forms.GroupBox()
        Me.btnRegistrerNyKunde = New System.Windows.Forms.Button()
        Me.tlpBrukerRegistrering.SuspendLayout()
        Me.gboxRegistrer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpBrukerRegistrering
        '
        Me.tlpBrukerRegistrering.ColumnCount = 2
        Me.tlpBrukerRegistrering.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.90871!))
        Me.tlpBrukerRegistrering.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.09129!))
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay3, 0, 2)
        Me.tlpBrukerRegistrering.Controls.Add(Me.txtBrukerEtternavn, 1, 1)
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay2, 0, 1)
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay1, 0, 0)
        Me.tlpBrukerRegistrering.Controls.Add(Me.txtBrukerFornavn, 1, 0)
        Me.tlpBrukerRegistrering.Controls.Add(Me.dtpBrukerFodselsdato, 1, 2)
        Me.tlpBrukerRegistrering.Controls.Add(Me.txtBrukerPostnr, 1, 3)
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay6, 0, 3)
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay4, 0, 4)
        Me.tlpBrukerRegistrering.Controls.Add(Me.txtBrukerPoststed, 1, 4)
        Me.tlpBrukerRegistrering.Controls.Add(Me.txtBrukerEpost, 1, 5)
        Me.tlpBrukerRegistrering.Controls.Add(Me.lblDisplay5, 0, 5)
        Me.tlpBrukerRegistrering.Location = New System.Drawing.Point(16, 19)
        Me.tlpBrukerRegistrering.Name = "tlpBrukerRegistrering"
        Me.tlpBrukerRegistrering.RowCount = 6
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.19277!))
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.80723!))
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpBrukerRegistrering.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpBrukerRegistrering.Size = New System.Drawing.Size(230, 324)
        Me.tlpBrukerRegistrering.TabIndex = 0
        '
        'lblDisplay3
        '
        Me.lblDisplay3.AutoSize = True
        Me.lblDisplay3.Location = New System.Drawing.Point(3, 99)
        Me.lblDisplay3.Name = "lblDisplay3"
        Me.lblDisplay3.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplay3.TabIndex = 4
        Me.lblDisplay3.Text = "Fødselsdato:"
        '
        'txtBrukerEtternavn
        '
        Me.txtBrukerEtternavn.Location = New System.Drawing.Point(99, 51)
        Me.txtBrukerEtternavn.Name = "txtBrukerEtternavn"
        Me.txtBrukerEtternavn.Size = New System.Drawing.Size(128, 20)
        Me.txtBrukerEtternavn.TabIndex = 3
        '
        'lblDisplay2
        '
        Me.lblDisplay2.AutoSize = True
        Me.lblDisplay2.Location = New System.Drawing.Point(3, 48)
        Me.lblDisplay2.Name = "lblDisplay2"
        Me.lblDisplay2.Size = New System.Drawing.Size(56, 13)
        Me.lblDisplay2.TabIndex = 2
        Me.lblDisplay2.Text = "Etternavn:"
        '
        'lblDisplay1
        '
        Me.lblDisplay1.AutoSize = True
        Me.lblDisplay1.Location = New System.Drawing.Point(3, 0)
        Me.lblDisplay1.Name = "lblDisplay1"
        Me.lblDisplay1.Size = New System.Drawing.Size(49, 13)
        Me.lblDisplay1.TabIndex = 0
        Me.lblDisplay1.Text = "Fornavn:"
        '
        'txtBrukerFornavn
        '
        Me.txtBrukerFornavn.Location = New System.Drawing.Point(99, 3)
        Me.txtBrukerFornavn.Name = "txtBrukerFornavn"
        Me.txtBrukerFornavn.Size = New System.Drawing.Size(128, 20)
        Me.txtBrukerFornavn.TabIndex = 1
        '
        'dtpBrukerFodselsdato
        '
        Me.dtpBrukerFodselsdato.Location = New System.Drawing.Point(99, 102)
        Me.dtpBrukerFodselsdato.Name = "dtpBrukerFodselsdato"
        Me.dtpBrukerFodselsdato.Size = New System.Drawing.Size(128, 20)
        Me.dtpBrukerFodselsdato.TabIndex = 16
        '
        'txtBrukerPostnr
        '
        Me.txtBrukerPostnr.Location = New System.Drawing.Point(99, 157)
        Me.txtBrukerPostnr.Name = "txtBrukerPostnr"
        Me.txtBrukerPostnr.Size = New System.Drawing.Size(128, 20)
        Me.txtBrukerPostnr.TabIndex = 12
        '
        'lblDisplay6
        '
        Me.lblDisplay6.AutoSize = True
        Me.lblDisplay6.Location = New System.Drawing.Point(3, 154)
        Me.lblDisplay6.Name = "lblDisplay6"
        Me.lblDisplay6.Size = New System.Drawing.Size(68, 13)
        Me.lblDisplay6.TabIndex = 11
        Me.lblDisplay6.Text = "Postnummer:"
        '
        'lblDisplay4
        '
        Me.lblDisplay4.AutoSize = True
        Me.lblDisplay4.Location = New System.Drawing.Point(3, 213)
        Me.lblDisplay4.Name = "lblDisplay4"
        Me.lblDisplay4.Size = New System.Drawing.Size(51, 13)
        Me.lblDisplay4.TabIndex = 15
        Me.lblDisplay4.Text = "Poststed:"
        '
        'txtBrukerPoststed
        '
        Me.txtBrukerPoststed.Location = New System.Drawing.Point(99, 216)
        Me.txtBrukerPoststed.Name = "txtBrukerPoststed"
        Me.txtBrukerPoststed.Size = New System.Drawing.Size(128, 20)
        Me.txtBrukerPoststed.TabIndex = 14
        '
        'txtBrukerEpost
        '
        Me.txtBrukerEpost.Location = New System.Drawing.Point(99, 272)
        Me.txtBrukerEpost.Name = "txtBrukerEpost"
        Me.txtBrukerEpost.Size = New System.Drawing.Size(128, 20)
        Me.txtBrukerEpost.TabIndex = 18
        '
        'lblDisplay5
        '
        Me.lblDisplay5.AutoSize = True
        Me.lblDisplay5.Location = New System.Drawing.Point(3, 269)
        Me.lblDisplay5.Name = "lblDisplay5"
        Me.lblDisplay5.Size = New System.Drawing.Size(40, 13)
        Me.lblDisplay5.TabIndex = 17
        Me.lblDisplay5.Text = "E-post:"
        '
        'gboxRegistrer
        '
        Me.gboxRegistrer.Controls.Add(Me.btnRegistrerNyKunde)
        Me.gboxRegistrer.Controls.Add(Me.tlpBrukerRegistrering)
        Me.gboxRegistrer.Location = New System.Drawing.Point(12, 12)
        Me.gboxRegistrer.Name = "gboxRegistrer"
        Me.gboxRegistrer.Size = New System.Drawing.Size(258, 382)
        Me.gboxRegistrer.TabIndex = 1
        Me.gboxRegistrer.TabStop = False
        '
        'btnRegistrerNyKunde
        '
        Me.btnRegistrerNyKunde.Location = New System.Drawing.Point(145, 349)
        Me.btnRegistrerNyKunde.Name = "btnRegistrerNyKunde"
        Me.btnRegistrerNyKunde.Size = New System.Drawing.Size(98, 23)
        Me.btnRegistrerNyKunde.TabIndex = 1
        Me.btnRegistrerNyKunde.Text = "Registrer kunde"
        Me.btnRegistrerNyKunde.UseVisualStyleBackColor = True
        '
        'registrerBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 400)
        Me.Controls.Add(Me.gboxRegistrer)
        Me.Name = "registrerBruker"
        Me.Text = "Registrer ny kunde"
        Me.tlpBrukerRegistrering.ResumeLayout(False)
        Me.tlpBrukerRegistrering.PerformLayout()
        Me.gboxRegistrer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpBrukerRegistrering As TableLayoutPanel
    Friend WithEvents lblDisplay4 As Label
    Friend WithEvents txtBrukerPoststed As TextBox
    Friend WithEvents txtBrukerPostnr As TextBox
    Friend WithEvents lblDisplay6 As Label
    Friend WithEvents lblDisplay3 As Label
    Friend WithEvents txtBrukerEtternavn As TextBox
    Friend WithEvents lblDisplay2 As Label
    Friend WithEvents lblDisplay1 As Label
    Friend WithEvents txtBrukerFornavn As TextBox
    Friend WithEvents dtpBrukerFodselsdato As DateTimePicker
    Friend WithEvents lblDisplay5 As Label
    Friend WithEvents txtBrukerEpost As TextBox
    Friend WithEvents gboxRegistrer As GroupBox
    Friend WithEvents btnRegistrerNyKunde As Button
End Class
