<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_University_Sect
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
        Me.txt_Unver = New System.Windows.Forms.TextBox()
        Me.ListBoxUnver = New System.Windows.Forms.ListBox()
        Me.ListBoxSect = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Sect = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_unId = New System.Windows.Forms.TextBox()
        Me.btn_in = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_End = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(538, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Πανεπιστήμιο:"
        '
        'txt_Unver
        '
        Me.txt_Unver.Location = New System.Drawing.Point(541, 269)
        Me.txt_Unver.Name = "txt_Unver"
        Me.txt_Unver.Size = New System.Drawing.Size(365, 20)
        Me.txt_Unver.TabIndex = 1
        '
        'ListBoxUnver
        '
        Me.ListBoxUnver.FormattingEnabled = True
        Me.ListBoxUnver.Location = New System.Drawing.Point(95, 63)
        Me.ListBoxUnver.Name = "ListBoxUnver"
        Me.ListBoxUnver.Size = New System.Drawing.Size(299, 511)
        Me.ListBoxUnver.TabIndex = 2
        '
        'ListBoxSect
        '
        Me.ListBoxSect.FormattingEnabled = True
        Me.ListBoxSect.HorizontalScrollbar = True
        Me.ListBoxSect.Location = New System.Drawing.Point(535, 63)
        Me.ListBoxSect.Name = "ListBoxSect"
        Me.ListBoxSect.Size = New System.Drawing.Size(371, 95)
        Me.ListBoxSect.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(531, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Σχολές:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(91, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Πανεπιστήμια:"
        '
        'txt_Sect
        '
        Me.txt_Sect.Location = New System.Drawing.Point(541, 205)
        Me.txt_Sect.Name = "txt_Sect"
        Me.txt_Sect.Size = New System.Drawing.Size(365, 20)
        Me.txt_Sect.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(538, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Σχολή:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(538, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "unID:"
        '
        'txt_unId
        '
        Me.txt_unId.Location = New System.Drawing.Point(541, 308)
        Me.txt_unId.Name = "txt_unId"
        Me.txt_unId.Size = New System.Drawing.Size(76, 20)
        Me.txt_unId.TabIndex = 9
        '
        'btn_in
        '
        Me.btn_in.Location = New System.Drawing.Point(798, 295)
        Me.btn_in.Name = "btn_in"
        Me.btn_in.Size = New System.Drawing.Size(108, 33)
        Me.btn_in.TabIndex = 10
        Me.btn_in.Text = "Εισαγωγή"
        Me.btn_in.UseVisualStyleBackColor = True
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.Khaki
        Me.btn_up.Location = New System.Drawing.Point(798, 231)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(108, 28)
        Me.btn_up.TabIndex = 11
        Me.btn_up.Text = "Eνημέρωση"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.Color.Maroon
        Me.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_End.ForeColor = System.Drawing.Color.Khaki
        Me.btn_End.Location = New System.Drawing.Point(974, 615)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(189, 52)
        Me.btn_End.TabIndex = 12
        Me.btn_End.Text = "Πίσω στην επεξεργασία του πανεπιστημίου"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'Edit_University_Sect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btn_End)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_in)
        Me.Controls.Add(Me.txt_unId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Sect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxSect)
        Me.Controls.Add(Me.ListBoxUnver)
        Me.Controls.Add(Me.txt_Unver)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_University_Sect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_University_Sect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Unver As TextBox
    Friend WithEvents ListBoxUnver As ListBox
    Friend WithEvents ListBoxSect As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Sect As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_unId As TextBox
    Friend WithEvents btn_in As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_End As Button
End Class
