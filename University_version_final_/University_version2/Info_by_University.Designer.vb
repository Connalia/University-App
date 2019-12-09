<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_by_University
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_by_University))
        Me.ListBoxVariety = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Var = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxUnvers = New System.Windows.Forms.ListBox()
        Me.btn_Search_Univers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxVariety
        '
        Me.ListBoxVariety.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxVariety.FormattingEnabled = True
        Me.ListBoxVariety.Location = New System.Drawing.Point(12, 28)
        Me.ListBoxVariety.Name = "ListBoxVariety"
        Me.ListBoxVariety.Size = New System.Drawing.Size(287, 173)
        Me.ListBoxVariety.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Είδοι Πανεπιστημιακών Ιδρυμάτων:"
        '
        'txt_Var
        '
        Me.txt_Var.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_Var.Location = New System.Drawing.Point(399, 42)
        Me.txt_Var.Name = "txt_Var"
        Me.txt_Var.Size = New System.Drawing.Size(261, 20)
        Me.txt_Var.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(100, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "University Variety:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(753, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Πανεπιστήμια:"
        '
        'ListBoxUnvers
        '
        Me.ListBoxUnvers.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxUnvers.FormattingEnabled = True
        Me.ListBoxUnvers.HorizontalScrollbar = True
        Me.ListBoxUnvers.Location = New System.Drawing.Point(757, 28)
        Me.ListBoxUnvers.Name = "ListBoxUnvers"
        Me.ListBoxUnvers.ScrollAlwaysVisible = True
        Me.ListBoxUnvers.Size = New System.Drawing.Size(406, 550)
        Me.ListBoxUnvers.TabIndex = 11
        '
        'btn_Search_Univers
        '
        Me.btn_Search_Univers.BackColor = System.Drawing.Color.Maroon
        Me.btn_Search_Univers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search_Univers.ForeColor = System.Drawing.Color.Khaki
        Me.btn_Search_Univers.Location = New System.Drawing.Point(847, 584)
        Me.btn_Search_Univers.Name = "btn_Search_Univers"
        Me.btn_Search_Univers.Size = New System.Drawing.Size(228, 39)
        Me.btn_Search_Univers.TabIndex = 12
        Me.btn_Search_Univers.Text = "Αναζήτηση Πανεπισημίου"
        Me.btn_Search_Univers.UseVisualStyleBackColor = False
        '
        'Info_by_University
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.btn_Search_Univers)
        Me.Controls.Add(Me.ListBoxUnvers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Var)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxVariety)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_by_University"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ανά είδος πανεπιστημίου"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxVariety As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Var As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxUnvers As ListBox
    Friend WithEvents btn_Search_Univers As Button
End Class
