<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Job
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
        Me.btn_EndJob = New System.Windows.Forms.Button()
        Me.btn_InJOB = New System.Windows.Forms.Button()
        Me.btn_Up_Job = New System.Windows.Forms.Button()
        Me.ListBoxJob = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Job = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Note = New System.Windows.Forms.TextBox()
        Me.btnUpNote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_EndJob
        '
        Me.btn_EndJob.BackColor = System.Drawing.Color.Maroon
        Me.btn_EndJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EndJob.ForeColor = System.Drawing.Color.Khaki
        Me.btn_EndJob.Location = New System.Drawing.Point(1019, 621)
        Me.btn_EndJob.Name = "btn_EndJob"
        Me.btn_EndJob.Size = New System.Drawing.Size(144, 46)
        Me.btn_EndJob.TabIndex = 0
        Me.btn_EndJob.Text = "Τέλος Επεξεργασίας"
        Me.btn_EndJob.UseVisualStyleBackColor = False
        '
        'btn_InJOB
        '
        Me.btn_InJOB.Location = New System.Drawing.Point(586, 484)
        Me.btn_InJOB.Name = "btn_InJOB"
        Me.btn_InJOB.Size = New System.Drawing.Size(306, 23)
        Me.btn_InJOB.TabIndex = 1
        Me.btn_InJOB.Text = "Εισαγωγή"
        Me.btn_InJOB.UseVisualStyleBackColor = True
        '
        'btn_Up_Job
        '
        Me.btn_Up_Job.BackColor = System.Drawing.Color.Khaki
        Me.btn_Up_Job.Location = New System.Drawing.Point(785, 101)
        Me.btn_Up_Job.Name = "btn_Up_Job"
        Me.btn_Up_Job.Size = New System.Drawing.Size(107, 23)
        Me.btn_Up_Job.TabIndex = 2
        Me.btn_Up_Job.Text = "Ενημέρωση"
        Me.btn_Up_Job.UseVisualStyleBackColor = False
        '
        'ListBoxJob
        '
        Me.ListBoxJob.FormattingEnabled = True
        Me.ListBoxJob.Location = New System.Drawing.Point(174, 75)
        Me.ListBoxJob.Name = "ListBoxJob"
        Me.ListBoxJob.Size = New System.Drawing.Size(306, 498)
        Me.ListBoxJob.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(170, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Επαγγέλματα:"
        '
        'txt_Job
        '
        Me.txt_Job.Location = New System.Drawing.Point(586, 75)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.Size = New System.Drawing.Size(306, 20)
        Me.txt_Job.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(582, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Επάγγελμα:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(583, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Περιγραφή:"
        '
        'txt_Note
        '
        Me.txt_Note.Location = New System.Drawing.Point(586, 161)
        Me.txt_Note.Multiline = True
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Size = New System.Drawing.Size(306, 254)
        Me.txt_Note.TabIndex = 8
        '
        'btnUpNote
        '
        Me.btnUpNote.BackColor = System.Drawing.Color.Khaki
        Me.btnUpNote.Location = New System.Drawing.Point(785, 421)
        Me.btnUpNote.Name = "btnUpNote"
        Me.btnUpNote.Size = New System.Drawing.Size(107, 23)
        Me.btnUpNote.TabIndex = 9
        Me.btnUpNote.Text = "Eνημέρωση"
        Me.btnUpNote.UseVisualStyleBackColor = False
        '
        'Edit_Job
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btnUpNote)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Job)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxJob)
        Me.Controls.Add(Me.btn_Up_Job)
        Me.Controls.Add(Me.btn_InJOB)
        Me.Controls.Add(Me.btn_EndJob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit_Job"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Job"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_EndJob As Button
    Friend WithEvents btn_InJOB As Button
    Friend WithEvents btn_Up_Job As Button
    Friend WithEvents ListBoxJob As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Job As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Note As TextBox
    Friend WithEvents btnUpNote As Button
End Class
