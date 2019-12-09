<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_by_Jobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_by_Jobs))
        Me.ListBoxJobs = New System.Windows.Forms.ListBox()
        Me.ListBoxDepartment = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Job = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJobNote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMoreInfo = New System.Windows.Forms.Button()
        Me.btn_SearchJob = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxJobs
        '
        Me.ListBoxJobs.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxJobs.FormattingEnabled = True
        Me.ListBoxJobs.HorizontalScrollbar = True
        Me.ListBoxJobs.Location = New System.Drawing.Point(12, 34)
        Me.ListBoxJobs.Name = "ListBoxJobs"
        Me.ListBoxJobs.ScrollAlwaysVisible = True
        Me.ListBoxJobs.Size = New System.Drawing.Size(308, 589)
        Me.ListBoxJobs.TabIndex = 0
        '
        'ListBoxDepartment
        '
        Me.ListBoxDepartment.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDepartment.FormattingEnabled = True
        Me.ListBoxDepartment.HorizontalScrollbar = True
        Me.ListBoxDepartment.Location = New System.Drawing.Point(860, 37)
        Me.ListBoxDepartment.Name = "ListBoxDepartment"
        Me.ListBoxDepartment.ScrollAlwaysVisible = True
        Me.ListBoxDepartment.Size = New System.Drawing.Size(303, 524)
        Me.ListBoxDepartment.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(375, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Επάγγελμα:"
        '
        'txt_Job
        '
        Me.txt_Job.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_Job.Location = New System.Drawing.Point(472, 34)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.Size = New System.Drawing.Size(249, 20)
        Me.txt_Job.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Επέλεξε επάγγελμα για να δεις περισσότερες πληροφορίες:"
        '
        'txtJobNote
        '
        Me.txtJobNote.Location = New System.Drawing.Point(472, 101)
        Me.txtJobNote.Multiline = True
        Me.txtJobNote.Name = "txtJobNote"
        Me.txtJobNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobNote.Size = New System.Drawing.Size(249, 218)
        Me.txtJobNote.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(357, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Πληροφορίες:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(857, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Τμήματα:"
        '
        'btnMoreInfo
        '
        Me.btnMoreInfo.BackColor = System.Drawing.Color.Maroon
        Me.btnMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreInfo.ForeColor = System.Drawing.Color.Khaki
        Me.btnMoreInfo.Location = New System.Drawing.Point(860, 572)
        Me.btnMoreInfo.Name = "btnMoreInfo"
        Me.btnMoreInfo.Size = New System.Drawing.Size(303, 51)
        Me.btnMoreInfo.TabIndex = 9
        Me.btnMoreInfo.Text = "Αναζήτηση περισσότερων πληροφοριών"
        Me.btnMoreInfo.UseVisualStyleBackColor = False
        '
        'btn_SearchJob
        '
        Me.btn_SearchJob.BackColor = System.Drawing.Color.Maroon
        Me.btn_SearchJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SearchJob.ForeColor = System.Drawing.Color.Khaki
        Me.btn_SearchJob.Location = New System.Drawing.Point(646, 57)
        Me.btn_SearchJob.Name = "btn_SearchJob"
        Me.btn_SearchJob.Size = New System.Drawing.Size(75, 28)
        Me.btn_SearchJob.TabIndex = 10
        Me.btn_SearchJob.Text = "Search"
        Me.btn_SearchJob.UseVisualStyleBackColor = False
        '
        'Info_by_Jobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.btn_SearchJob)
        Me.Controls.Add(Me.btnMoreInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJobNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Job)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxDepartment)
        Me.Controls.Add(Me.ListBoxJobs)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_by_Jobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ανά Επάγγελμα"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxJobs As ListBox
    Friend WithEvents ListBoxDepartment As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Job As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJobNote As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMoreInfo As Button
    Friend WithEvents btn_SearchJob As Button
End Class
