<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btnEditBase = New System.Windows.Forms.Button()
        Me.bVariety = New System.Windows.Forms.Button()
        Me.btnUnivers = New System.Windows.Forms.Button()
        Me.btnScien = New System.Windows.Forms.Button()
        Me.btnExtra = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnDepart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditBase
        '
        Me.btnEditBase.BackColor = System.Drawing.Color.Maroon
        Me.btnEditBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnEditBase.ForeColor = System.Drawing.Color.Khaki
        Me.btnEditBase.Location = New System.Drawing.Point(104, 142)
        Me.btnEditBase.Name = "btnEditBase"
        Me.btnEditBase.Size = New System.Drawing.Size(213, 82)
        Me.btnEditBase.TabIndex = 0
        Me.btnEditBase.Text = "Βάσεις"
        Me.btnEditBase.UseVisualStyleBackColor = False
        '
        'bVariety
        '
        Me.bVariety.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.bVariety.Location = New System.Drawing.Point(479, 98)
        Me.bVariety.Name = "bVariety"
        Me.bVariety.Size = New System.Drawing.Size(213, 38)
        Me.bVariety.TabIndex = 1
        Me.bVariety.Text = "Είδος Ιδρυμάτων"
        Me.bVariety.UseVisualStyleBackColor = True
        '
        'btnUnivers
        '
        Me.btnUnivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnUnivers.Location = New System.Drawing.Point(479, 142)
        Me.btnUnivers.Name = "btnUnivers"
        Me.btnUnivers.Size = New System.Drawing.Size(213, 38)
        Me.btnUnivers.TabIndex = 2
        Me.btnUnivers.Text = "Πανεπιστήμια"
        Me.btnUnivers.UseVisualStyleBackColor = True
        '
        'btnScien
        '
        Me.btnScien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnScien.Location = New System.Drawing.Point(479, 230)
        Me.btnScien.Name = "btnScien"
        Me.btnScien.Size = New System.Drawing.Size(213, 38)
        Me.btnScien.TabIndex = 3
        Me.btnScien.Text = "Επιστημονικά Πεδία"
        Me.btnScien.UseVisualStyleBackColor = True
        '
        'btnExtra
        '
        Me.btnExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnExtra.Location = New System.Drawing.Point(479, 274)
        Me.btnExtra.Name = "btnExtra"
        Me.btnExtra.Size = New System.Drawing.Size(213, 38)
        Me.btnExtra.TabIndex = 4
        Me.btnExtra.Text = "Ειδικά Μαθήματα"
        Me.btnExtra.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnJobs.Location = New System.Drawing.Point(479, 362)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(213, 38)
        Me.btnJobs.TabIndex = 5
        Me.btnJobs.Text = "Επαγγέλματα"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnPost.Location = New System.Drawing.Point(479, 318)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(213, 38)
        Me.btnPost.TabIndex = 6
        Me.btnPost.Text = "Μεταπτυχειακά"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnPlace
        '
        Me.btnPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnPlace.Location = New System.Drawing.Point(479, 186)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(213, 38)
        Me.btnPlace.TabIndex = 7
        Me.btnPlace.Text = "Χώροι Απασχόλησης"
        Me.btnPlace.UseVisualStyleBackColor = True
        '
        'btnDepart
        '
        Me.btnDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnDepart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepart.Location = New System.Drawing.Point(479, 435)
        Me.btnDepart.Name = "btnDepart"
        Me.btnDepart.Size = New System.Drawing.Size(213, 82)
        Me.btnDepart.TabIndex = 8
        Me.btnDepart.Text = "Τμήματα"
        Me.btnDepart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(317, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Διαχείρηση-Επεξεργασία Δεδομένων Εφαρμογής:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(754, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 336)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDepart)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnJobs)
        Me.Controls.Add(Me.btnExtra)
        Me.Controls.Add(Me.btnScien)
        Me.Controls.Add(Me.btnUnivers)
        Me.Controls.Add(Me.bVariety)
        Me.Controls.Add(Me.btnEditBase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditBase As Button
    Friend WithEvents bVariety As Button
    Friend WithEvents btnUnivers As Button
    Friend WithEvents btnScien As Button
    Friend WithEvents btnExtra As Button
    Friend WithEvents btnJobs As Button
    Friend WithEvents btnPost As Button
    Friend WithEvents btnPlace As Button
    Friend WithEvents btnDepart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
