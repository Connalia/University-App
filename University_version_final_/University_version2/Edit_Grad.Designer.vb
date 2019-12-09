<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Grad
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
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btn_upNote = New System.Windows.Forms.Button()
        Me.btn_upGrad = New System.Windows.Forms.Button()
        Me.ListBoxGrad = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.txt_Grad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Univer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_UNid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Maroon
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.ForeColor = System.Drawing.Color.Khaki
        Me.btnEnd.Location = New System.Drawing.Point(1019, 621)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(144, 46)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "Τέλος Επεξεργασίας"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(583, 544)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(354, 23)
        Me.btnIn.TabIndex = 1
        Me.btnIn.Text = "Εισαγωγή"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'btn_upNote
        '
        Me.btn_upNote.BackColor = System.Drawing.Color.Khaki
        Me.btn_upNote.Location = New System.Drawing.Point(793, 396)
        Me.btn_upNote.Name = "btn_upNote"
        Me.btn_upNote.Size = New System.Drawing.Size(144, 23)
        Me.btn_upNote.TabIndex = 2
        Me.btn_upNote.Text = "Ενημέρωση"
        Me.btn_upNote.UseVisualStyleBackColor = False
        '
        'btn_upGrad
        '
        Me.btn_upGrad.BackColor = System.Drawing.Color.Khaki
        Me.btn_upGrad.Location = New System.Drawing.Point(793, 85)
        Me.btn_upGrad.Name = "btn_upGrad"
        Me.btn_upGrad.Size = New System.Drawing.Size(144, 23)
        Me.btn_upGrad.TabIndex = 3
        Me.btn_upGrad.Text = "Ενημέρωση"
        Me.btn_upGrad.UseVisualStyleBackColor = False
        '
        'ListBoxGrad
        '
        Me.ListBoxGrad.FormattingEnabled = True
        Me.ListBoxGrad.Location = New System.Drawing.Point(165, 56)
        Me.ListBoxGrad.Name = "ListBoxGrad"
        Me.ListBoxGrad.Size = New System.Drawing.Size(354, 511)
        Me.ListBoxGrad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(161, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mεταπτυχειακά:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(579, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Μεταπτυχειακό:"
        '
        'txt_Note
        '
        Me.txt_Note.Location = New System.Drawing.Point(583, 156)
        Me.txt_Note.Multiline = True
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(354, 234)
        Me.txt_Note.TabIndex = 7
        '
        'txt_Grad
        '
        Me.txt_Grad.Location = New System.Drawing.Point(583, 59)
        Me.txt_Grad.Name = "txt_Grad"
        Me.txt_Grad.Size = New System.Drawing.Size(354, 20)
        Me.txt_Grad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(582, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Περιγραφή:"
        '
        'txt_Univer
        '
        Me.txt_Univer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Univer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Univer.Location = New System.Drawing.Point(583, 466)
        Me.txt_Univer.Name = "txt_Univer"
        Me.txt_Univer.Size = New System.Drawing.Size(354, 20)
        Me.txt_Univer.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(580, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Πανεπιστήμιο:"
        '
        'txt_UNid
        '
        Me.txt_UNid.Location = New System.Drawing.Point(583, 511)
        Me.txt_UNid.Multiline = True
        Me.txt_UNid.Name = "txt_UNid"
        Me.txt_UNid.Size = New System.Drawing.Size(144, 20)
        Me.txt_UNid.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(582, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "unID:"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(896, 492)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(41, 23)
        Me.btn_ok.TabIndex = 14
        Me.btn_ok.Text = "οκ"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Edit_Grad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_UNid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Univer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Grad)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxGrad)
        Me.Controls.Add(Me.btn_upGrad)
        Me.Controls.Add(Me.btn_upNote)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.btnEnd)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Grad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Grad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents btn_upNote As Button
    Friend WithEvents btn_upGrad As Button
    Friend WithEvents ListBoxGrad As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents txt_Grad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Univer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_UNid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_ok As Button
End Class
