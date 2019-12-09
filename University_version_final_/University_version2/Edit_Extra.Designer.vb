<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Extra
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
        Me.txt_Extra = New System.Windows.Forms.TextBox()
        Me.ListBoxExtra = New System.Windows.Forms.ListBox()
        Me.btn_EndExtra = New System.Windows.Forms.Button()
        Me.Up_Extra = New System.Windows.Forms.Button()
        Me.In_Extra = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(146, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ειδικά Μαθήματα:"
        '
        'txt_Extra
        '
        Me.txt_Extra.Location = New System.Drawing.Point(607, 184)
        Me.txt_Extra.Name = "txt_Extra"
        Me.txt_Extra.Size = New System.Drawing.Size(332, 20)
        Me.txt_Extra.TabIndex = 1
        '
        'ListBoxExtra
        '
        Me.ListBoxExtra.FormattingEnabled = True
        Me.ListBoxExtra.Location = New System.Drawing.Point(150, 80)
        Me.ListBoxExtra.Name = "ListBoxExtra"
        Me.ListBoxExtra.Size = New System.Drawing.Size(332, 472)
        Me.ListBoxExtra.TabIndex = 2
        '
        'btn_EndExtra
        '
        Me.btn_EndExtra.BackColor = System.Drawing.Color.Maroon
        Me.btn_EndExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EndExtra.ForeColor = System.Drawing.Color.Khaki
        Me.btn_EndExtra.Location = New System.Drawing.Point(1019, 621)
        Me.btn_EndExtra.Name = "btn_EndExtra"
        Me.btn_EndExtra.Size = New System.Drawing.Size(144, 46)
        Me.btn_EndExtra.TabIndex = 3
        Me.btn_EndExtra.Text = "Τέλος Επεξεργασίας"
        Me.btn_EndExtra.UseVisualStyleBackColor = False
        '
        'Up_Extra
        '
        Me.Up_Extra.BackColor = System.Drawing.Color.Khaki
        Me.Up_Extra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Up_Extra.Location = New System.Drawing.Point(849, 210)
        Me.Up_Extra.Name = "Up_Extra"
        Me.Up_Extra.Size = New System.Drawing.Size(90, 33)
        Me.Up_Extra.TabIndex = 4
        Me.Up_Extra.Text = "Ενημέρωση"
        Me.Up_Extra.UseVisualStyleBackColor = False
        '
        'In_Extra
        '
        Me.In_Extra.Location = New System.Drawing.Point(607, 210)
        Me.In_Extra.Name = "In_Extra"
        Me.In_Extra.Size = New System.Drawing.Size(90, 33)
        Me.In_Extra.TabIndex = 5
        Me.In_Extra.Text = "Εισαγωγή"
        Me.In_Extra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(603, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ειδικό Μάθημα:"
        '
        'Edit_Extra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.In_Extra)
        Me.Controls.Add(Me.Up_Extra)
        Me.Controls.Add(Me.btn_EndExtra)
        Me.Controls.Add(Me.ListBoxExtra)
        Me.Controls.Add(Me.txt_Extra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Extra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Extra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Extra As TextBox
    Friend WithEvents ListBoxExtra As ListBox
    Friend WithEvents btn_EndExtra As Button
    Friend WithEvents Up_Extra As Button
    Friend WithEvents In_Extra As Button
    Friend WithEvents Label2 As Label
End Class
