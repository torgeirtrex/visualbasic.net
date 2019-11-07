<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RedigerAvdelinger
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
        Me.cboxInnUt = New System.Windows.Forms.ComboBox()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.txtAvdPostnr = New System.Windows.Forms.TextBox()
        Me.txtAvdAdresse = New System.Windows.Forms.TextBox()
        Me.txtAvdNavn = New System.Windows.Forms.TextBox()
        Me.lblDisplay2 = New System.Windows.Forms.Label()
        Me.lblDisplay3 = New System.Windows.Forms.Label()
        Me.lblDisplay4 = New System.Windows.Forms.Label()
        Me.lblDisplay5 = New System.Windows.Forms.Label()
        Me.lblDisplay1 = New System.Windows.Forms.Label()
        Me.btnRegistrerAvdeling = New System.Windows.Forms.Button()
        Me.btnGaTilbake = New System.Windows.Forms.Button()
        Me.gboxRegistrerNyAvdeling = New System.Windows.Forms.GroupBox()
        Me.gboxRegistrerNyAvdeling.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxInnUt
        '
        Me.cboxInnUt.DropDownWidth = 130
        Me.cboxInnUt.FormattingEnabled = True
        Me.cboxInnUt.Items.AddRange(New Object() {"Utlevering/Innlevering", "Innlevering"})
        Me.cboxInnUt.Location = New System.Drawing.Point(128, 127)
        Me.cboxInnUt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboxInnUt.Name = "cboxInnUt"
        Me.cboxInnUt.Size = New System.Drawing.Size(106, 21)
        Me.cboxInnUt.TabIndex = 25
        '
        'txtPoststed
        '
        Me.txtPoststed.Location = New System.Drawing.Point(128, 101)
        Me.txtPoststed.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.Size = New System.Drawing.Size(102, 20)
        Me.txtPoststed.TabIndex = 24
        '
        'txtAvdPostnr
        '
        Me.txtAvdPostnr.Location = New System.Drawing.Point(128, 75)
        Me.txtAvdPostnr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvdPostnr.Name = "txtAvdPostnr"
        Me.txtAvdPostnr.Size = New System.Drawing.Size(102, 20)
        Me.txtAvdPostnr.TabIndex = 23
        '
        'txtAvdAdresse
        '
        Me.txtAvdAdresse.Location = New System.Drawing.Point(128, 40)
        Me.txtAvdAdresse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvdAdresse.Name = "txtAvdAdresse"
        Me.txtAvdAdresse.Size = New System.Drawing.Size(102, 20)
        Me.txtAvdAdresse.TabIndex = 22
        '
        'txtAvdNavn
        '
        Me.txtAvdNavn.Location = New System.Drawing.Point(128, 14)
        Me.txtAvdNavn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAvdNavn.Name = "txtAvdNavn"
        Me.txtAvdNavn.Size = New System.Drawing.Size(102, 20)
        Me.txtAvdNavn.TabIndex = 21
        '
        'lblDisplay2
        '
        Me.lblDisplay2.AutoSize = True
        Me.lblDisplay2.Location = New System.Drawing.Point(15, 127)
        Me.lblDisplay2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay2.Name = "lblDisplay2"
        Me.lblDisplay2.Size = New System.Drawing.Size(110, 13)
        Me.lblDisplay2.TabIndex = 31
        Me.lblDisplay2.Text = "Innlevering/utlevering"
        '
        'lblDisplay3
        '
        Me.lblDisplay3.AutoSize = True
        Me.lblDisplay3.Location = New System.Drawing.Point(15, 106)
        Me.lblDisplay3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay3.Name = "lblDisplay3"
        Me.lblDisplay3.Size = New System.Drawing.Size(48, 13)
        Me.lblDisplay3.TabIndex = 30
        Me.lblDisplay3.Text = "Poststed"
        '
        'lblDisplay4
        '
        Me.lblDisplay4.AutoSize = True
        Me.lblDisplay4.Location = New System.Drawing.Point(15, 81)
        Me.lblDisplay4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay4.Name = "lblDisplay4"
        Me.lblDisplay4.Size = New System.Drawing.Size(65, 13)
        Me.lblDisplay4.TabIndex = 29
        Me.lblDisplay4.Text = "Postnummer"
        '
        'lblDisplay5
        '
        Me.lblDisplay5.AutoSize = True
        Me.lblDisplay5.Location = New System.Drawing.Point(15, 47)
        Me.lblDisplay5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay5.Name = "lblDisplay5"
        Me.lblDisplay5.Size = New System.Drawing.Size(90, 13)
        Me.lblDisplay5.TabIndex = 28
        Me.lblDisplay5.Text = "Avdelingsadresse"
        '
        'lblDisplay1
        '
        Me.lblDisplay1.AutoSize = True
        Me.lblDisplay1.Location = New System.Drawing.Point(15, 16)
        Me.lblDisplay1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay1.Name = "lblDisplay1"
        Me.lblDisplay1.Size = New System.Drawing.Size(77, 13)
        Me.lblDisplay1.TabIndex = 27
        Me.lblDisplay1.Text = "Avdelingsnavn"
        '
        'btnRegistrerAvdeling
        '
        Me.btnRegistrerAvdeling.Location = New System.Drawing.Point(148, 161)
        Me.btnRegistrerAvdeling.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrerAvdeling.Name = "btnRegistrerAvdeling"
        Me.btnRegistrerAvdeling.Size = New System.Drawing.Size(82, 28)
        Me.btnRegistrerAvdeling.TabIndex = 26
        Me.btnRegistrerAvdeling.Text = "Legg til avd"
        Me.btnRegistrerAvdeling.UseVisualStyleBackColor = True
        '
        'btnGaTilbake
        '
        Me.btnGaTilbake.Location = New System.Drawing.Point(164, 228)
        Me.btnGaTilbake.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGaTilbake.Name = "btnGaTilbake"
        Me.btnGaTilbake.Size = New System.Drawing.Size(78, 20)
        Me.btnGaTilbake.TabIndex = 32
        Me.btnGaTilbake.Text = "Gå tilbake"
        Me.btnGaTilbake.UseVisualStyleBackColor = True
        '
        'gboxRegistrerNyAvdeling
        '
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.lblDisplay1)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.txtAvdNavn)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.lblDisplay2)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.txtAvdAdresse)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.lblDisplay3)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.txtAvdPostnr)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.lblDisplay4)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.txtPoststed)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.lblDisplay5)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.cboxInnUt)
        Me.gboxRegistrerNyAvdeling.Controls.Add(Me.btnRegistrerAvdeling)
        Me.gboxRegistrerNyAvdeling.Location = New System.Drawing.Point(12, 12)
        Me.gboxRegistrerNyAvdeling.Name = "gboxRegistrerNyAvdeling"
        Me.gboxRegistrerNyAvdeling.Size = New System.Drawing.Size(244, 194)
        Me.gboxRegistrerNyAvdeling.TabIndex = 33
        Me.gboxRegistrerNyAvdeling.TabStop = False
        '
        'RedigerAvdelinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 262)
        Me.Controls.Add(Me.gboxRegistrerNyAvdeling)
        Me.Controls.Add(Me.btnGaTilbake)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RedigerAvdelinger"
        Me.Text = "Registrer ny avdeling"
        Me.gboxRegistrerNyAvdeling.ResumeLayout(False)
        Me.gboxRegistrerNyAvdeling.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboxInnUt As ComboBox
    Friend WithEvents txtPoststed As TextBox
    Friend WithEvents txtAvdPostnr As TextBox
    Friend WithEvents txtAvdAdresse As TextBox
    Friend WithEvents txtAvdNavn As TextBox
    Friend WithEvents lblDisplay2 As Label
    Friend WithEvents lblDisplay3 As Label
    Friend WithEvents lblDisplay4 As Label
    Friend WithEvents lblDisplay5 As Label
    Friend WithEvents lblDisplay1 As Label
    Friend WithEvents btnRegistrerAvdeling As Button
    Friend WithEvents btnGaTilbake As Button
    Friend WithEvents gboxRegistrerNyAvdeling As GroupBox
End Class
