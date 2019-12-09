<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Place
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
        Me.btn_Up = New System.Windows.Forms.Button()
        Me.btn_In = New System.Windows.Forms.Button()
        Me.btn_End = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxPlace = New System.Windows.Forms.ListBox()
        Me.txt_Place = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Up
        '
        Me.btn_Up.BackColor = System.Drawing.Color.Khaki
        Me.btn_Up.Location = New System.Drawing.Point(1001, 281)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(80, 32)
        Me.btn_Up.TabIndex = 0
        Me.btn_Up.Text = "Ενημέρωση"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'btn_In
        '
        Me.btn_In.Location = New System.Drawing.Point(628, 281)
        Me.btn_In.Name = "btn_In"
        Me.btn_In.Size = New System.Drawing.Size(80, 32)
        Me.btn_In.TabIndex = 1
        Me.btn_In.Text = "Eισαγωγή"
        Me.btn_In.UseVisualStyleBackColor = True
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.Color.Maroon
        Me.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_End.ForeColor = System.Drawing.Color.Khaki
        Me.btn_End.Location = New System.Drawing.Point(1019, 621)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(144, 46)
        Me.btn_End.TabIndex = 2
        Me.btn_End.Text = "Τέλος Επεξεργασίας"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(101, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ενδεικτικεί Χώροι Απασχόλησης:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(624, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Χώρος Απασχόλησεις:"
        '
        'ListBoxPlace
        '
        Me.ListBoxPlace.FormattingEnabled = True
        Me.ListBoxPlace.HorizontalScrollbar = True
        Me.ListBoxPlace.Location = New System.Drawing.Point(105, 57)
        Me.ListBoxPlace.Name = "ListBoxPlace"
        Me.ListBoxPlace.ScrollAlwaysVisible = True
        Me.ListBoxPlace.Size = New System.Drawing.Size(453, 537)
        Me.ListBoxPlace.TabIndex = 5
        '
        'txt_Place
        '
        Me.txt_Place.Location = New System.Drawing.Point(628, 233)
        Me.txt_Place.Name = "txt_Place"
        Me.txt_Place.Size = New System.Drawing.Size(453, 20)
        Me.txt_Place.TabIndex = 6
        '
        'Edit_Place
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.txt_Place)
        Me.Controls.Add(Me.ListBoxPlace)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_End)
        Me.Controls.Add(Me.btn_In)
        Me.Controls.Add(Me.btn_Up)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Place"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Place"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Up As Button
    Friend WithEvents btn_In As Button
    Friend WithEvents btn_End As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxPlace As ListBox
    Friend WithEvents txt_Place As TextBox
End Class
