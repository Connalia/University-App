<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_by_City
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_by_City))
        Me.ListBoxCities = New System.Windows.Forms.ListBox()
        Me.ListBoxDepart = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.btn_MoreInfo = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxCities
        '
        Me.ListBoxCities.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxCities.FormattingEnabled = True
        Me.ListBoxCities.HorizontalScrollbar = True
        Me.ListBoxCities.Location = New System.Drawing.Point(49, 31)
        Me.ListBoxCities.Name = "ListBoxCities"
        Me.ListBoxCities.Size = New System.Drawing.Size(266, 316)
        Me.ListBoxCities.TabIndex = 0
        '
        'ListBoxDepart
        '
        Me.ListBoxDepart.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDepart.FormattingEnabled = True
        Me.ListBoxDepart.HorizontalScrollbar = True
        Me.ListBoxDepart.Location = New System.Drawing.Point(860, 42)
        Me.ListBoxDepart.Name = "ListBoxDepart"
        Me.ListBoxDepart.ScrollAlwaysVisible = True
        Me.ListBoxDepart.Size = New System.Drawing.Size(303, 524)
        Me.ListBoxDepart.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(471, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Πόλη:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(857, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Τμήματα:"
        '
        'txt_City
        '
        Me.txt_City.Location = New System.Drawing.Point(475, 93)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(270, 20)
        Me.txt_City.TabIndex = 6
        '
        'btn_MoreInfo
        '
        Me.btn_MoreInfo.BackColor = System.Drawing.Color.Maroon
        Me.btn_MoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoreInfo.ForeColor = System.Drawing.Color.Khaki
        Me.btn_MoreInfo.Location = New System.Drawing.Point(860, 572)
        Me.btn_MoreInfo.Name = "btn_MoreInfo"
        Me.btn_MoreInfo.Size = New System.Drawing.Size(303, 51)
        Me.btn_MoreInfo.TabIndex = 7
        Me.btn_MoreInfo.Text = "Αναζήτηση περισσότερων πληροφοριών"
        Me.btn_MoreInfo.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Επέλεξε την πόλη που επιθυμείς,για να δείς ποια τμήματα έχει:"
        '
        'Info_by_City
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.btn_MoreInfo)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxDepart)
        Me.Controls.Add(Me.ListBoxCities)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_by_City"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ανά Πόλη"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxCities As ListBox
    Friend WithEvents ListBoxDepart As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_City As TextBox
    Friend WithEvents btn_MoreInfo As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
End Class
