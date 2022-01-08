<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertorForm
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
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.StringTextBox = New System.Windows.Forms.TextBox()
        Me.NatoButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MorseButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StringToNatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StringToMorseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.AutoSize = True
        Me.InstructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsLabel.Location = New System.Drawing.Point(7, 37)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(300, 20)
        Me.InstructionsLabel.TabIndex = 0
        Me.InstructionsLabel.Text = "Please enter a string to be coverted."
        '
        'StringTextBox
        '
        Me.StringTextBox.Location = New System.Drawing.Point(12, 69)
        Me.StringTextBox.Name = "StringTextBox"
        Me.StringTextBox.Size = New System.Drawing.Size(286, 20)
        Me.StringTextBox.TabIndex = 1
        '
        'NatoButton
        '
        Me.NatoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NatoButton.Location = New System.Drawing.Point(12, 110)
        Me.NatoButton.Name = "NatoButton"
        Me.NatoButton.Size = New System.Drawing.Size(137, 29)
        Me.NatoButton.TabIndex = 2
        Me.NatoButton.Text = "Nato Phonetic"
        Me.NatoButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(12, 145)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(286, 29)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MorseButton
        '
        Me.MorseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MorseButton.Location = New System.Drawing.Point(156, 110)
        Me.MorseButton.Name = "MorseButton"
        Me.MorseButton.Size = New System.Drawing.Size(142, 29)
        Me.MorseButton.TabIndex = 3
        Me.MorseButton.Text = "Morse Code"
        Me.MorseButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StringToNatoToolStripMenuItem, Me.StringToMorseToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'StringToNatoToolStripMenuItem
        '
        Me.StringToNatoToolStripMenuItem.Name = "StringToNatoToolStripMenuItem"
        Me.StringToNatoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.StringToNatoToolStripMenuItem.Text = "String to &Nato"
        '
        'StringToMorseToolStripMenuItem
        '
        Me.StringToMorseToolStripMenuItem.Name = "StringToMorseToolStripMenuItem"
        Me.StringToMorseToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.StringToMorseToolStripMenuItem.Text = "String to &Morse"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ConvertorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 184)
        Me.Controls.Add(Me.MorseButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NatoButton)
        Me.Controls.Add(Me.StringTextBox)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ConvertorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String to Military Convertor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructionsLabel As System.Windows.Forms.Label
    Friend WithEvents StringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NatoButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MorseButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StringToNatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StringToMorseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
