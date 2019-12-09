<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_University
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxUn = New System.Windows.Forms.ListBox()
        Me.txt_Univers = New System.Windows.Forms.TextBox()
        Me.txt_Variety = New System.Windows.Forms.TextBox()
        Me.txt_vID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_upd = New System.Windows.Forms.Button()
        Me.btn_Insert = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.txt_Un2 = New System.Windows.Forms.TextBox()
        Me.txt_var2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Variety2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBoxSect = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(52, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Πανεπιστήμια:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(446, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "University:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(442, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Variety:"
        '
        'ListBoxUn
        '
        Me.ListBoxUn.FormattingEnabled = True
        Me.ListBoxUn.Location = New System.Drawing.Point(56, 46)
        Me.ListBoxUn.Name = "ListBoxUn"
        Me.ListBoxUn.Size = New System.Drawing.Size(320, 420)
        Me.ListBoxUn.TabIndex = 3
        '
        'txt_Univers
        '
        Me.txt_Univers.Location = New System.Drawing.Point(449, 51)
        Me.txt_Univers.Name = "txt_Univers"
        Me.txt_Univers.Size = New System.Drawing.Size(320, 20)
        Me.txt_Univers.TabIndex = 4
        '
        'txt_Variety
        '
        Me.txt_Variety.Location = New System.Drawing.Point(446, 126)
        Me.txt_Variety.Name = "txt_Variety"
        Me.txt_Variety.Size = New System.Drawing.Size(320, 20)
        Me.txt_Variety.TabIndex = 5
        '
        'txt_vID
        '
        Me.txt_vID.Location = New System.Drawing.Point(533, 490)
        Me.txt_vID.Name = "txt_vID"
        Me.txt_vID.Size = New System.Drawing.Size(83, 20)
        Me.txt_vID.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(496, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "vID:"
        '
        'btn_upd
        '
        Me.btn_upd.BackColor = System.Drawing.Color.Khaki
        Me.btn_upd.Location = New System.Drawing.Point(654, 77)
        Me.btn_upd.Name = "btn_upd"
        Me.btn_upd.Size = New System.Drawing.Size(112, 35)
        Me.btn_upd.TabIndex = 8
        Me.btn_upd.Text = "Ενημέρωση"
        Me.btn_upd.UseVisualStyleBackColor = False
        '
        'btn_Insert
        '
        Me.btn_Insert.Location = New System.Drawing.Point(437, 523)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(444, 23)
        Me.btn_Insert.TabIndex = 9
        Me.btn_Insert.Text = "Eισαγωγή"
        Me.btn_Insert.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.ForeColor = System.Drawing.Color.Khaki
        Me.btn_Exit.Location = New System.Drawing.Point(1019, 621)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(144, 46)
        Me.btn_Exit.TabIndex = 10
        Me.btn_Exit.Text = "Τέλος Επεξεργασίας"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(297, 528)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(79, 23)
        Me.btn_Search.TabIndex = 11
        Me.btn_Search.Text = "Αναζήτηση"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'txt_Un2
        '
        Me.txt_Un2.Location = New System.Drawing.Point(533, 439)
        Me.txt_Un2.Name = "txt_Un2"
        Me.txt_Un2.Size = New System.Drawing.Size(348, 20)
        Me.txt_Un2.TabIndex = 12
        '
        'txt_var2
        '
        Me.txt_var2.Location = New System.Drawing.Point(533, 464)
        Me.txt_var2.Name = "txt_var2"
        Me.txt_var2.Size = New System.Drawing.Size(348, 20)
        Me.txt_var2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(437, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Πανεπιστήμιο:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(485, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Είδος:"
        '
        'txt_Variety2
        '
        Me.txt_Variety2.Location = New System.Drawing.Point(56, 502)
        Me.txt_Variety2.Name = "txt_Variety2"
        Me.txt_Variety2.Size = New System.Drawing.Size(320, 20)
        Me.txt_Variety2.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(53, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Eίδος Ιδρυμάτων-πανεπιστημίων:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(701, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Επεξεργασία"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(437, 549)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(444, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Μετά την εισαγωγή του νέου πανεπιστημίου, πρέπει να προσθετούν και οι σχολές του." &
    ""
        '
        'ListBoxSect
        '
        Me.ListBoxSect.FormattingEnabled = True
        Me.ListBoxSect.HorizontalScrollbar = True
        Me.ListBoxSect.Location = New System.Drawing.Point(630, 240)
        Me.ListBoxSect.Name = "ListBoxSect"
        Me.ListBoxSect.Size = New System.Drawing.Size(346, 95)
        Me.ListBoxSect.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(627, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Σχολές:"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(622, 488)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(128, 23)
        Me.btn_ok.TabIndex = 22
        Me.btn_ok.Text = "Εμφάνισε το vID"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Edit_University
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListBoxSect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Variety2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_var2)
        Me.Controls.Add(Me.txt_Un2)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Insert)
        Me.Controls.Add(Me.btn_upd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_vID)
        Me.Controls.Add(Me.txt_Variety)
        Me.Controls.Add(Me.txt_Univers)
        Me.Controls.Add(Me.ListBoxUn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_University"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_University"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxUn As ListBox
    Friend WithEvents txt_Univers As TextBox
    Friend WithEvents txt_Variety As TextBox
    Friend WithEvents txt_vID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_upd As Button
    Friend WithEvents btn_Insert As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents txt_Un2 As TextBox
    Friend WithEvents txt_var2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Variety2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBoxSect As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_ok As Button
End Class
