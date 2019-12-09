<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepart = New System.Windows.Forms.TextBox()
        Me.txt_dCode = New System.Windows.Forms.TextBox()
        Me.txt_dCity = New System.Windows.Forms.TextBox()
        Me.txt_durationStudy = New System.Windows.Forms.TextBox()
        Me.txt_dLink = New System.Windows.Forms.TextBox()
        Me.txt_dNote = New System.Windows.Forms.TextBox()
        Me.txt_University = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBoxExtra = New System.Windows.Forms.ListBox()
        Me.ListBoxScienName = New System.Windows.Forms.ListBox()
        Me.txt_Sector = New System.Windows.Forms.TextBox()
        Me.btnViewSite = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ListBoxDirection = New System.Windows.Forms.ListBox()
        Me.ListBoxGrad = New System.Windows.Forms.ListBox()
        Me.ListBoxProfJob = New System.Windows.Forms.ListBox()
        Me.txt_rightsNote = New System.Windows.Forms.TextBox()
        Me.ListBoxPlace = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_var = New System.Windows.Forms.TextBox()
        Me.P3150092DataSet1 = New University_version2.p3150092DataSet()
        Me.ListBoxYear = New System.Windows.Forms.ListBox()
        Me.ListBoxMoria = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.P3150092DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(233, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Τμήμα:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(100, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Κωδικός Σχολής:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(503, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Πόλη:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(859, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Διάρκεια Σπουδών:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(20, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ιστοσελίδα:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(3, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Πληροφορίες:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(100, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Επιστημονικό Πεδίο:"
        '
        'txtDepart
        '
        Me.txtDepart.Location = New System.Drawing.Point(293, 9)
        Me.txtDepart.Name = "txtDepart"
        Me.txtDepart.Size = New System.Drawing.Size(594, 20)
        Me.txtDepart.TabIndex = 7
        '
        'txt_dCode
        '
        Me.txt_dCode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_dCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dCode.Location = New System.Drawing.Point(213, 13)
        Me.txt_dCode.Name = "txt_dCode"
        Me.txt_dCode.Size = New System.Drawing.Size(74, 22)
        Me.txt_dCode.TabIndex = 8
        '
        'txt_dCity
        '
        Me.txt_dCity.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_dCity.Location = New System.Drawing.Point(553, 15)
        Me.txt_dCity.Name = "txt_dCity"
        Me.txt_dCity.Size = New System.Drawing.Size(123, 20)
        Me.txt_dCity.TabIndex = 9
        '
        'txt_durationStudy
        '
        Me.txt_durationStudy.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_durationStudy.Location = New System.Drawing.Point(984, 13)
        Me.txt_durationStudy.Name = "txt_durationStudy"
        Me.txt_durationStudy.Size = New System.Drawing.Size(100, 20)
        Me.txt_durationStudy.TabIndex = 10
        '
        'txt_dLink
        '
        Me.txt_dLink.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_dLink.Location = New System.Drawing.Point(112, 52)
        Me.txt_dLink.Name = "txt_dLink"
        Me.txt_dLink.Size = New System.Drawing.Size(935, 20)
        Me.txt_dLink.TabIndex = 11
        '
        'txt_dNote
        '
        Me.txt_dNote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_dNote.Location = New System.Drawing.Point(103, 253)
        Me.txt_dNote.Multiline = True
        Me.txt_dNote.Name = "txt_dNote"
        Me.txt_dNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_dNote.Size = New System.Drawing.Size(1013, 188)
        Me.txt_dNote.TabIndex = 12
        '
        'txt_University
        '
        Me.txt_University.Location = New System.Drawing.Point(331, 49)
        Me.txt_University.Name = "txt_University"
        Me.txt_University.Size = New System.Drawing.Size(522, 20)
        Me.txt_University.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(232, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Πανεπιστήμιο:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(227, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Σχολή(Τομέας):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(709, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Extra Μαθήματα:"
        '
        'ListBoxExtra
        '
        Me.ListBoxExtra.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxExtra.FormattingEnabled = True
        Me.ListBoxExtra.Location = New System.Drawing.Point(712, 131)
        Me.ListBoxExtra.Name = "ListBoxExtra"
        Me.ListBoxExtra.Size = New System.Drawing.Size(372, 82)
        Me.ListBoxExtra.TabIndex = 18
        '
        'ListBoxScienName
        '
        Me.ListBoxScienName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxScienName.FormattingEnabled = True
        Me.ListBoxScienName.Location = New System.Drawing.Point(103, 131)
        Me.ListBoxScienName.Name = "ListBoxScienName"
        Me.ListBoxScienName.Size = New System.Drawing.Size(219, 82)
        Me.ListBoxScienName.TabIndex = 19
        '
        'txt_Sector
        '
        Me.txt_Sector.Location = New System.Drawing.Point(331, 75)
        Me.txt_Sector.Name = "txt_Sector"
        Me.txt_Sector.Size = New System.Drawing.Size(522, 20)
        Me.txt_Sector.TabIndex = 20
        '
        'btnViewSite
        '
        Me.btnViewSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSite.ForeColor = System.Drawing.Color.Transparent
        Me.btnViewSite.Image = CType(resources.GetObject("btnViewSite.Image"), System.Drawing.Image)
        Me.btnViewSite.Location = New System.Drawing.Point(1053, 46)
        Me.btnViewSite.Name = "btnViewSite"
        Me.btnViewSite.Size = New System.Drawing.Size(31, 28)
        Me.btnViewSite.TabIndex = 21
        Me.btnViewSite.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(616, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Μόρια:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(20, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Επαγγέλματα:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(213, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Μεταπτυχειακά:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(231, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Κατευθύνσης:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(17, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 16)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Επαγγελματικά Δικαιώματα:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(567, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Ενδεικτικοί Χώροι Απασχόλησης:"
        '
        'ListBoxDirection
        '
        Me.ListBoxDirection.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDirection.FormattingEnabled = True
        Me.ListBoxDirection.Location = New System.Drawing.Point(234, 63)
        Me.ListBoxDirection.Name = "ListBoxDirection"
        Me.ListBoxDirection.Size = New System.Drawing.Size(610, 303)
        Me.ListBoxDirection.TabIndex = 28
        '
        'ListBoxGrad
        '
        Me.ListBoxGrad.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxGrad.FormattingEnabled = True
        Me.ListBoxGrad.Location = New System.Drawing.Point(216, 68)
        Me.ListBoxGrad.Name = "ListBoxGrad"
        Me.ListBoxGrad.Size = New System.Drawing.Size(616, 303)
        Me.ListBoxGrad.TabIndex = 29
        '
        'ListBoxProfJob
        '
        Me.ListBoxProfJob.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxProfJob.FormattingEnabled = True
        Me.ListBoxProfJob.Location = New System.Drawing.Point(23, 43)
        Me.ListBoxProfJob.Name = "ListBoxProfJob"
        Me.ListBoxProfJob.Size = New System.Drawing.Size(529, 394)
        Me.ListBoxProfJob.TabIndex = 30
        '
        'txt_rightsNote
        '
        Me.txt_rightsNote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_rightsNote.Location = New System.Drawing.Point(20, 38)
        Me.txt_rightsNote.Multiline = True
        Me.txt_rightsNote.Name = "txt_rightsNote"
        Me.txt_rightsNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_rightsNote.Size = New System.Drawing.Size(1118, 413)
        Me.txt_rightsNote.TabIndex = 31
        '
        'ListBoxPlace
        '
        Me.ListBoxPlace.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxPlace.FormattingEnabled = True
        Me.ListBoxPlace.Location = New System.Drawing.Point(570, 43)
        Me.ListBoxPlace.Name = "ListBoxPlace"
        Me.ListBoxPlace.Size = New System.Drawing.Size(555, 394)
        Me.ListBoxPlace.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(196, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 16)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "είδος πανεπιστημίου:"
        '
        'txt_var
        '
        Me.txt_var.Location = New System.Drawing.Point(331, 104)
        Me.txt_var.Name = "txt_var"
        Me.txt_var.Size = New System.Drawing.Size(522, 20)
        Me.txt_var.TabIndex = 34
        '
        'P3150092DataSet1
        '
        Me.P3150092DataSet1.DataSetName = "p3150092DataSet"
        Me.P3150092DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBoxYear
        '
        Me.ListBoxYear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxYear.FormattingEnabled = True
        Me.ListBoxYear.Location = New System.Drawing.Point(407, 72)
        Me.ListBoxYear.Name = "ListBoxYear"
        Me.ListBoxYear.Size = New System.Drawing.Size(114, 199)
        Me.ListBoxYear.TabIndex = 35
        '
        'ListBoxMoria
        '
        Me.ListBoxMoria.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxMoria.FormattingEnabled = True
        Me.ListBoxMoria.Location = New System.Drawing.Point(619, 72)
        Me.ListBoxMoria.Name = "ListBoxMoria"
        Me.ListBoxMoria.Size = New System.Drawing.Size(114, 199)
        Me.ListBoxMoria.TabIndex = 36
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(11, 184)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1152, 483)
        Me.TabControl1.TabIndex = 40
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_dCode)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_dCity)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_durationStudy)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnViewSite)
        Me.TabPage1.Controls.Add(Me.txt_dLink)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ListBoxScienName)
        Me.TabPage1.Controls.Add(Me.txt_dNote)
        Me.TabPage1.Controls.Add(Me.ListBoxExtra)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Γενικά"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBoxDirection)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Κατευθύνσεις"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBoxGrad)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Μεταπτυχειακά"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.ListBoxProfJob)
        Me.TabPage4.Controls.Add(Me.ListBoxPlace)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Jobs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.txt_rightsNote)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Eπαγγελματικα Δικαιώματα"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label18)
        Me.TabPage6.Controls.Add(Me.ListBoxMoria)
        Me.TabPage6.Controls.Add(Me.ListBoxYear)
        Me.TabPage6.Controls.Add(Me.Label11)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1144, 457)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Βάσεις"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(404, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 16)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Χρονιά:"
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(893, 3)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(29, 30)
        Me.btn_refresh.TabIndex = 41
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Khaki
        Me.Button1.Location = New System.Drawing.Point(1052, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 41)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Τέλος"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDepart)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txt_var)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_Sector)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_University)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DepartmentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Τμήμα"
        CType(Me.P3150092DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents txt_dCode As TextBox
    Friend WithEvents txt_dCity As TextBox
    Friend WithEvents txt_durationStudy As TextBox
    Friend WithEvents txt_dLink As TextBox
    Friend WithEvents txt_dNote As TextBox
    Friend WithEvents txt_University As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBoxExtra As ListBox
    Friend WithEvents ListBoxScienName As ListBox
    Friend WithEvents txt_Sector As TextBox
    Friend WithEvents btnViewSite As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ListBoxDirection As ListBox
    Friend WithEvents ListBoxGrad As ListBox
    Friend WithEvents ListBoxProfJob As ListBox
    Friend WithEvents txt_rightsNote As TextBox
    Friend WithEvents ListBoxPlace As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_var As TextBox
    Friend WithEvents P3150092DataSet1 As p3150092DataSet
    Friend WithEvents ListBoxYear As ListBox
    Friend WithEvents ListBoxMoria As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
End Class
