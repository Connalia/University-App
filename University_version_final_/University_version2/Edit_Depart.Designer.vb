<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Depart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Depart))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxDepart = New System.Windows.Forms.ListBox()
        Me.txt_Depart = New System.Windows.Forms.TextBox()
        Me.btn_Up_NameDep = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txt_Code = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_link = New System.Windows.Forms.TextBox()
        Me.txt_sectId = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_Sect = New System.Windows.Forms.TextBox()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_duration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_upLink = New System.Windows.Forms.Button()
        Me.btn_UpNote = New System.Windows.Forms.Button()
        Me.btn_upCity = New System.Windows.Forms.Button()
        Me.btn_UpCode = New System.Windows.Forms.Button()
        Me.btn_upDuration = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_End = New System.Windows.Forms.Button()
        Me.btn_ok_Depart = New System.Windows.Forms.Button()
        Me.btn_more = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(18, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Τμήματα:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(417, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Τμήμα:"
        '
        'ListBoxDepart
        '
        Me.ListBoxDepart.FormattingEnabled = True
        Me.ListBoxDepart.Location = New System.Drawing.Point(22, 25)
        Me.ListBoxDepart.Name = "ListBoxDepart"
        Me.ListBoxDepart.Size = New System.Drawing.Size(317, 589)
        Me.ListBoxDepart.TabIndex = 2
        '
        'txt_Depart
        '
        Me.txt_Depart.Location = New System.Drawing.Point(464, 6)
        Me.txt_Depart.Name = "txt_Depart"
        Me.txt_Depart.Size = New System.Drawing.Size(615, 20)
        Me.txt_Depart.TabIndex = 3
        '
        'btn_Up_NameDep
        '
        Me.btn_Up_NameDep.BackColor = System.Drawing.Color.Khaki
        Me.btn_Up_NameDep.Location = New System.Drawing.Point(984, 32)
        Me.btn_Up_NameDep.Name = "btn_Up_NameDep"
        Me.btn_Up_NameDep.Size = New System.Drawing.Size(95, 23)
        Me.btn_Up_NameDep.TabIndex = 4
        Me.btn_Up_NameDep.Text = "Ενημέρωση"
        Me.btn_Up_NameDep.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(462, 506)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(454, 48)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Εισαγωγή"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txt_Code
        '
        Me.txt_Code.Location = New System.Drawing.Point(464, 183)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.Size = New System.Drawing.Size(116, 20)
        Me.txt_Code.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(461, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Κωδικός Σχολής:"
        '
        'txt_link
        '
        Me.txt_link.Location = New System.Drawing.Point(464, 61)
        Me.txt_link.Name = "txt_link"
        Me.txt_link.Size = New System.Drawing.Size(615, 20)
        Me.txt_link.TabIndex = 8
        '
        'txt_sectId
        '
        Me.txt_sectId.Location = New System.Drawing.Point(464, 361)
        Me.txt_sectId.Name = "txt_sectId"
        Me.txt_sectId.Size = New System.Drawing.Size(100, 20)
        Me.txt_sectId.TabIndex = 9
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(463, 144)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(117, 20)
        Me.txt_city.TabIndex = 10
        '
        'txt_Sect
        '
        Me.txt_Sect.Location = New System.Drawing.Point(464, 321)
        Me.txt_Sect.Name = "txt_Sect"
        Me.txt_Sect.Size = New System.Drawing.Size(300, 20)
        Me.txt_Sect.TabIndex = 11
        '
        'txt_Note
        '
        Me.txt_Note.Location = New System.Drawing.Point(688, 146)
        Me.txt_Note.Multiline = True
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(391, 100)
        Me.txt_Note.TabIndex = 12
        '
        'txt_duration
        '
        Me.txt_duration.Location = New System.Drawing.Point(465, 222)
        Me.txt_duration.Name = "txt_duration"
        Me.txt_duration.Size = New System.Drawing.Size(115, 20)
        Me.txt_duration.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(461, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Σχολή:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(685, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Περιγραφή:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(462, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Διάρκεια σπουδών:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(461, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Πόλη:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(461, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "SectID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(459, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Μετά την εισαγωγή όλων των στοιχείων,"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(428, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Link:"
        '
        'btn_upLink
        '
        Me.btn_upLink.BackColor = System.Drawing.Color.Khaki
        Me.btn_upLink.Location = New System.Drawing.Point(984, 87)
        Me.btn_upLink.Name = "btn_upLink"
        Me.btn_upLink.Size = New System.Drawing.Size(95, 23)
        Me.btn_upLink.TabIndex = 21
        Me.btn_upLink.Text = "Ενημέρωση"
        Me.btn_upLink.UseVisualStyleBackColor = False
        '
        'btn_UpNote
        '
        Me.btn_UpNote.BackColor = System.Drawing.Color.Khaki
        Me.btn_UpNote.Location = New System.Drawing.Point(984, 252)
        Me.btn_UpNote.Name = "btn_UpNote"
        Me.btn_UpNote.Size = New System.Drawing.Size(95, 23)
        Me.btn_UpNote.TabIndex = 22
        Me.btn_UpNote.Text = "Ενημέρωση"
        Me.btn_UpNote.UseVisualStyleBackColor = False
        '
        'btn_upCity
        '
        Me.btn_upCity.BackColor = System.Drawing.Color.Khaki
        Me.btn_upCity.Location = New System.Drawing.Point(586, 144)
        Me.btn_upCity.Name = "btn_upCity"
        Me.btn_upCity.Size = New System.Drawing.Size(95, 23)
        Me.btn_upCity.TabIndex = 23
        Me.btn_upCity.Text = "Ενημέρωση"
        Me.btn_upCity.UseVisualStyleBackColor = False
        '
        'btn_UpCode
        '
        Me.btn_UpCode.BackColor = System.Drawing.Color.Khaki
        Me.btn_UpCode.Location = New System.Drawing.Point(586, 183)
        Me.btn_UpCode.Name = "btn_UpCode"
        Me.btn_UpCode.Size = New System.Drawing.Size(95, 23)
        Me.btn_UpCode.TabIndex = 24
        Me.btn_UpCode.Text = "Ενημέρωση"
        Me.btn_UpCode.UseVisualStyleBackColor = False
        '
        'btn_upDuration
        '
        Me.btn_upDuration.BackColor = System.Drawing.Color.Khaki
        Me.btn_upDuration.Location = New System.Drawing.Point(586, 222)
        Me.btn_upDuration.Name = "btn_upDuration"
        Me.btn_upDuration.Size = New System.Drawing.Size(95, 23)
        Me.btn_upDuration.TabIndex = 25
        Me.btn_upDuration.Text = "Ενημέρωση"
        Me.btn_upDuration.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(770, 321)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(50, 23)
        Me.btn_ok.TabIndex = 26
        Me.btn_ok.Text = "ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(461, 413)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(628, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = resources.GetString("Label12.Text")
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.Color.Maroon
        Me.btn_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_End.ForeColor = System.Drawing.Color.Khaki
        Me.btn_End.Location = New System.Drawing.Point(1019, 621)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(144, 46)
        Me.btn_End.TabIndex = 29
        Me.btn_End.Text = "Τέλος Επεξεργασίας"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'btn_ok_Depart
        '
        Me.btn_ok_Depart.Location = New System.Drawing.Point(1085, 3)
        Me.btn_ok_Depart.Name = "btn_ok_Depart"
        Me.btn_ok_Depart.Size = New System.Drawing.Size(44, 23)
        Me.btn_ok_Depart.TabIndex = 30
        Me.btn_ok_Depart.Text = "οκ"
        Me.btn_ok_Depart.UseVisualStyleBackColor = True
        '
        'btn_more
        '
        Me.btn_more.Location = New System.Drawing.Point(463, 387)
        Me.btn_more.Name = "btn_more"
        Me.btn_more.Size = New System.Drawing.Size(356, 23)
        Me.btn_more.TabIndex = 31
        Me.btn_more.Text = "Επεξεργασία περισσότερων πληροφοριών"
        Me.btn_more.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(459, 488)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(458, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "θα πρέπει να εισαγθούν επιπλέων στοιχεία σε άλλη καρτέλα που αφορούν το τμήμα ."
        '
        'Edit_Depart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_more)
        Me.Controls.Add(Me.btn_ok_Depart)
        Me.Controls.Add(Me.btn_End)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_upDuration)
        Me.Controls.Add(Me.btn_UpCode)
        Me.Controls.Add(Me.btn_upCity)
        Me.Controls.Add(Me.btn_UpNote)
        Me.Controls.Add(Me.btn_upLink)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_duration)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.txt_Sect)
        Me.Controls.Add(Me.txt_city)
        Me.Controls.Add(Me.txt_sectId)
        Me.Controls.Add(Me.txt_link)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Code)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btn_Up_NameDep)
        Me.Controls.Add(Me.txt_Depart)
        Me.Controls.Add(Me.ListBoxDepart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Depart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Depart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxDepart As ListBox
    Friend WithEvents txt_Depart As TextBox
    Friend WithEvents btn_Up_NameDep As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txt_Code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_link As TextBox
    Friend WithEvents txt_sectId As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents txt_Sect As TextBox
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_duration As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_upLink As Button
    Friend WithEvents btn_UpNote As Button
    Friend WithEvents btn_upCity As Button
    Friend WithEvents btn_UpCode As Button
    Friend WithEvents btn_upDuration As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_End As Button
    Friend WithEvents btn_ok_Depart As Button
    Friend WithEvents btn_more As Button
    Friend WithEvents Label13 As Label
End Class
