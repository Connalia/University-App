<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Info_by_University_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_by_University_2))
        Me.txt_Un = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxSect = New System.Windows.Forms.ListBox()
        Me.ListBoxDepart3 = New System.Windows.Forms.ListBox()
        Me.btn_Info5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Sector = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_Un
        '
        Me.txt_Un.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_Un.Location = New System.Drawing.Point(11, 33)
        Me.txt_Un.Name = "txt_Un"
        Me.txt_Un.Size = New System.Drawing.Size(336, 20)
        Me.txt_Un.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Πανεπιστήμιο:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Σχολές:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(399, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Τμήματα:"
        '
        'ListBoxSect
        '
        Me.ListBoxSect.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxSect.FormattingEnabled = True
        Me.ListBoxSect.Location = New System.Drawing.Point(11, 79)
        Me.ListBoxSect.Name = "ListBoxSect"
        Me.ListBoxSect.Size = New System.Drawing.Size(336, 108)
        Me.ListBoxSect.TabIndex = 4
        '
        'ListBoxDepart3
        '
        Me.ListBoxDepart3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDepart3.FormattingEnabled = True
        Me.ListBoxDepart3.HorizontalScrollbar = True
        Me.ListBoxDepart3.Location = New System.Drawing.Point(403, 30)
        Me.ListBoxDepart3.Name = "ListBoxDepart3"
        Me.ListBoxDepart3.ScrollAlwaysVisible = True
        Me.ListBoxDepart3.Size = New System.Drawing.Size(342, 563)
        Me.ListBoxDepart3.TabIndex = 5
        '
        'btn_Info5
        '
        Me.btn_Info5.BackColor = System.Drawing.Color.Maroon
        Me.btn_Info5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Info5.ForeColor = System.Drawing.Color.Khaki
        Me.btn_Info5.Location = New System.Drawing.Point(403, 599)
        Me.btn_Info5.Name = "btn_Info5"
        Me.btn_Info5.Size = New System.Drawing.Size(342, 34)
        Me.btn_Info5.TabIndex = 7
        Me.btn_Info5.Text = "Αναζήτηση περισσότερων πληροφοριών"
        Me.btn_Info5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Khaki
        Me.Label4.Location = New System.Drawing.Point(765, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Σχολή:"
        '
        'txt_Sector
        '
        Me.txt_Sector.Location = New System.Drawing.Point(769, 30)
        Me.txt_Sector.Name = "txt_Sector"
        Me.txt_Sector.Size = New System.Drawing.Size(336, 20)
        Me.txt_Sector.TabIndex = 9
        '
        'Info_by_University_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.txt_Sector)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_Info5)
        Me.Controls.Add(Me.ListBoxDepart3)
        Me.Controls.Add(Me.ListBoxSect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Un)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_by_University_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ανά σχολές"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Un As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxSect As ListBox
    Friend WithEvents ListBoxDepart3 As ListBox
    Friend WithEvents btn_Info5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Sector As TextBox
End Class
