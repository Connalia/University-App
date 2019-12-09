<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Scien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxScien = New System.Windows.Forms.ListBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btn_in = New System.Windows.Forms.Button()
        Me.btn_End = New System.Windows.Forms.Button()
        Me.txt_Scien = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(240, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Επιστημικά πεδία:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(638, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Επιστημονικό πεδίο:"
        '
        'ListBoxScien
        '
        Me.ListBoxScien.FormattingEnabled = True
        Me.ListBoxScien.Location = New System.Drawing.Point(244, 192)
        Me.ListBoxScien.Name = "ListBoxScien"
        Me.ListBoxScien.Size = New System.Drawing.Size(267, 186)
        Me.ListBoxScien.TabIndex = 2
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Khaki
        Me.btnUp.Location = New System.Drawing.Point(823, 295)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(85, 33)
        Me.btnUp.TabIndex = 3
        Me.btnUp.Text = "Ενημέρωση"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btn_in
        '
        Me.btn_in.Location = New System.Drawing.Point(642, 295)
        Me.btn_in.Name = "btn_in"
        Me.btn_in.Size = New System.Drawing.Size(85, 33)
        Me.btn_in.TabIndex = 4
        Me.btn_in.Text = "Eισαγωγή"
        Me.btn_in.UseVisualStyleBackColor = True
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.Color.Maroon
        Me.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_End.ForeColor = System.Drawing.Color.Khaki
        Me.btn_End.Location = New System.Drawing.Point(1019, 621)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(144, 46)
        Me.btn_End.TabIndex = 5
        Me.btn_End.Text = "Τέλος Επεξεργασίας"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'txt_Scien
        '
        Me.txt_Scien.Location = New System.Drawing.Point(642, 259)
        Me.txt_Scien.Name = "txt_Scien"
        Me.txt_Scien.Size = New System.Drawing.Size(266, 20)
        Me.txt_Scien.TabIndex = 6
        '
        'Edit_Scien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.txt_Scien)
        Me.Controls.Add(Me.btn_End)
        Me.Controls.Add(Me.btn_in)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.ListBoxScien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Scien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Scien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxScien As ListBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btn_in As Button
    Friend WithEvents btn_End As Button
    Friend WithEvents txt_Scien As TextBox
End Class
