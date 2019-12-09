<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Variety
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
        Me.ListBoxVariety = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Variety = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Insert = New System.Windows.Forms.Button()
        Me.btn_UpdateVar = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxVariety
        '
        Me.ListBoxVariety.FormattingEnabled = True
        Me.ListBoxVariety.Location = New System.Drawing.Point(217, 212)
        Me.ListBoxVariety.Name = "ListBoxVariety"
        Me.ListBoxVariety.Size = New System.Drawing.Size(312, 199)
        Me.ListBoxVariety.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(213, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Είδοι Ιδρυμάτων:"
        '
        'txt_Variety
        '
        Me.txt_Variety.Location = New System.Drawing.Point(610, 280)
        Me.txt_Variety.Name = "txt_Variety"
        Me.txt_Variety.Size = New System.Drawing.Size(327, 20)
        Me.txt_Variety.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(606, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Είδος Ιδρυμάτων:"
        '
        'btn_Insert
        '
        Me.btn_Insert.Location = New System.Drawing.Point(610, 306)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(100, 31)
        Me.btn_Insert.TabIndex = 4
        Me.btn_Insert.Text = "Εισαγωγή"
        Me.btn_Insert.UseVisualStyleBackColor = True
        '
        'btn_UpdateVar
        '
        Me.btn_UpdateVar.BackColor = System.Drawing.Color.Khaki
        Me.btn_UpdateVar.Location = New System.Drawing.Point(837, 306)
        Me.btn_UpdateVar.Name = "btn_UpdateVar"
        Me.btn_UpdateVar.Size = New System.Drawing.Size(100, 31)
        Me.btn_UpdateVar.TabIndex = 5
        Me.btn_UpdateVar.Text = "Ενημέρωση"
        Me.btn_UpdateVar.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.ForeColor = System.Drawing.Color.Khaki
        Me.btn_Exit.Location = New System.Drawing.Point(1019, 621)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(144, 46)
        Me.btn_Exit.TabIndex = 9
        Me.btn_Exit.Text = "Τέλος Επεξεργασίας"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'Edit_Variety
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_UpdateVar)
        Me.Controls.Add(Me.btn_Insert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Variety)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxVariety)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Variety"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Variety"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxVariety As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Variety As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Insert As Button
    Friend WithEvents btn_UpdateVar As Button
    Friend WithEvents btn_Exit As Button
End Class
