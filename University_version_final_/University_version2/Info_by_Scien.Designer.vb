<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_by_Scien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_by_Scien))
        Me.ListBoxScien = New System.Windows.Forms.ListBox()
        Me.ListBoxDepart2 = New System.Windows.Forms.ListBox()
        Me.btn_more_Info2 = New System.Windows.Forms.Button()
        Me.txt_Scien = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxScien
        '
        Me.ListBoxScien.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxScien.FormattingEnabled = True
        Me.ListBoxScien.Location = New System.Drawing.Point(140, 87)
        Me.ListBoxScien.Name = "ListBoxScien"
        Me.ListBoxScien.Size = New System.Drawing.Size(303, 121)
        Me.ListBoxScien.TabIndex = 3
        '
        'ListBoxDepart2
        '
        Me.ListBoxDepart2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDepart2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListBoxDepart2.FormattingEnabled = True
        Me.ListBoxDepart2.HorizontalScrollbar = True
        Me.ListBoxDepart2.Location = New System.Drawing.Point(860, 64)
        Me.ListBoxDepart2.Name = "ListBoxDepart2"
        Me.ListBoxDepart2.ScrollAlwaysVisible = True
        Me.ListBoxDepart2.Size = New System.Drawing.Size(303, 498)
        Me.ListBoxDepart2.TabIndex = 4
        '
        'btn_more_Info2
        '
        Me.btn_more_Info2.BackColor = System.Drawing.Color.Maroon
        Me.btn_more_Info2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_more_Info2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_more_Info2.ForeColor = System.Drawing.Color.Khaki
        Me.btn_more_Info2.Location = New System.Drawing.Point(860, 572)
        Me.btn_more_Info2.Name = "btn_more_Info2"
        Me.btn_more_Info2.Size = New System.Drawing.Size(303, 51)
        Me.btn_more_Info2.TabIndex = 5
        Me.btn_more_Info2.Text = "Αναζήτηση περισσότερων πληροφοριών"
        Me.btn_more_Info2.UseVisualStyleBackColor = False
        '
        'txt_Scien
        '
        Me.txt_Scien.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_Scien.Location = New System.Drawing.Point(860, 12)
        Me.txt_Scien.Name = "txt_Scien"
        Me.txt_Scien.Size = New System.Drawing.Size(303, 20)
        Me.txt_Scien.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(856, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Τμήματα:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(136, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Επιστημονικά πεδία:"
        '
        'Info_by_Scien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Scien)
        Me.Controls.Add(Me.btn_more_Info2)
        Me.Controls.Add(Me.ListBoxDepart2)
        Me.Controls.Add(Me.ListBoxScien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_by_Scien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ανά επιστημονικό πεδίο"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxScien As ListBox
    Friend WithEvents ListBoxDepart2 As ListBox
    Friend WithEvents btn_more_Info2 As Button
    Friend WithEvents txt_Scien As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
