<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtLoginUsername = New System.Windows.Forms.TextBox()
        Me.bLogIn = New System.Windows.Forms.Button()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P3150092DataSet1 = New University_version2.p3150092DataSet1()
        Me.P3150092DataSet = New University_version2.p3150092DataSet()
        Me.P3150092DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New University_version2.p3150092DataSetTableAdapters.departmentTableAdapter()
        Me.Fk1departmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseTableAdapter = New University_version2.p3150092DataSetTableAdapters.baseTableAdapter()
        Me.Fk1departmentscientificfieldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Department_scientific_fieldTableAdapter = New University_version2.p3150092DataSetTableAdapters.department_scientific_fieldTableAdapter()
        Me.DepartmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New University_version2.p3150092DataSet1TableAdapters.customerTableAdapter()
        Me.btnInfoByJob = New System.Windows.Forms.Button()
        Me.btn_Info_Job = New System.Windows.Forms.Button()
        Me.btn_Info_Scien = New System.Windows.Forms.Button()
        Me.btn_Info_University = New System.Windows.Forms.Button()
        Me.txt_SearchAll = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3150092DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3150092DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3150092DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fk1departmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fk1departmentscientificfieldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Location = New System.Drawing.Point(1009, 566)
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(154, 20)
        Me.txtLoginUsername.TabIndex = 0
        '
        'bLogIn
        '
        Me.bLogIn.BackColor = System.Drawing.Color.Maroon
        Me.bLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogIn.ForeColor = System.Drawing.Color.Khaki
        Me.bLogIn.Location = New System.Drawing.Point(1088, 592)
        Me.bLogIn.Name = "bLogIn"
        Me.bLogIn.Size = New System.Drawing.Size(75, 31)
        Me.bLogIn.TabIndex = 1
        Me.bLogIn.Text = "Log In"
        Me.bLogIn.UseVisualStyleBackColor = False
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.P3150092DataSet1
        '
        'P3150092DataSet1
        '
        Me.P3150092DataSet1.DataSetName = "p3150092DataSet1"
        Me.P3150092DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P3150092DataSet
        '
        Me.P3150092DataSet.DataSetName = "p3150092DataSet"
        Me.P3150092DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P3150092DataSetBindingSource
        '
        Me.P3150092DataSetBindingSource.DataSource = Me.P3150092DataSet
        Me.P3150092DataSetBindingSource.Position = 0
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "department"
        Me.DepartmentBindingSource.DataSource = Me.P3150092DataSetBindingSource
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Fk1departmentBindingSource
        '
        Me.Fk1departmentBindingSource.DataMember = "fk1_department"
        Me.Fk1departmentBindingSource.DataSource = Me.DepartmentBindingSource
        '
        'BaseTableAdapter
        '
        Me.BaseTableAdapter.ClearBeforeFill = True
        '
        'Fk1departmentscientificfieldBindingSource
        '
        Me.Fk1departmentscientificfieldBindingSource.DataMember = "fk1_department_scientific_field"
        Me.Fk1departmentscientificfieldBindingSource.DataSource = Me.DepartmentBindingSource
        '
        'Department_scientific_fieldTableAdapter
        '
        Me.Department_scientific_fieldTableAdapter.ClearBeforeFill = True
        '
        'DepartmentBindingSource1
        '
        Me.DepartmentBindingSource1.DataMember = "department"
        Me.DepartmentBindingSource1.DataSource = Me.P3150092DataSetBindingSource
        '
        'DepartmentBindingSource2
        '
        Me.DepartmentBindingSource2.DataMember = "department"
        Me.DepartmentBindingSource2.DataSource = Me.P3150092DataSetBindingSource
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'btnInfoByJob
        '
        Me.btnInfoByJob.AutoSize = True
        Me.btnInfoByJob.BackgroundImage = CType(resources.GetObject("btnInfoByJob.BackgroundImage"), System.Drawing.Image)
        Me.btnInfoByJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfoByJob.Location = New System.Drawing.Point(167, 195)
        Me.btnInfoByJob.Name = "btnInfoByJob"
        Me.btnInfoByJob.Size = New System.Drawing.Size(351, 117)
        Me.btnInfoByJob.TabIndex = 2
        Me.btnInfoByJob.UseVisualStyleBackColor = True
        '
        'btn_Info_Job
        '
        Me.btn_Info_Job.Image = CType(resources.GetObject("btn_Info_Job.Image"), System.Drawing.Image)
        Me.btn_Info_Job.Location = New System.Drawing.Point(637, 399)
        Me.btn_Info_Job.Name = "btn_Info_Job"
        Me.btn_Info_Job.Size = New System.Drawing.Size(351, 117)
        Me.btn_Info_Job.TabIndex = 3
        Me.btn_Info_Job.UseVisualStyleBackColor = True
        '
        'btn_Info_Scien
        '
        Me.btn_Info_Scien.BackgroundImage = CType(resources.GetObject("btn_Info_Scien.BackgroundImage"), System.Drawing.Image)
        Me.btn_Info_Scien.Image = CType(resources.GetObject("btn_Info_Scien.Image"), System.Drawing.Image)
        Me.btn_Info_Scien.Location = New System.Drawing.Point(167, 401)
        Me.btn_Info_Scien.Name = "btn_Info_Scien"
        Me.btn_Info_Scien.Size = New System.Drawing.Size(351, 117)
        Me.btn_Info_Scien.TabIndex = 4
        Me.btn_Info_Scien.UseVisualStyleBackColor = True
        '
        'btn_Info_University
        '
        Me.btn_Info_University.Image = CType(resources.GetObject("btn_Info_University.Image"), System.Drawing.Image)
        Me.btn_Info_University.Location = New System.Drawing.Point(637, 195)
        Me.btn_Info_University.Name = "btn_Info_University"
        Me.btn_Info_University.Size = New System.Drawing.Size(351, 117)
        Me.btn_Info_University.TabIndex = 5
        Me.btn_Info_University.UseVisualStyleBackColor = True
        '
        'txt_SearchAll
        '
        Me.txt_SearchAll.Location = New System.Drawing.Point(373, 34)
        Me.txt_SearchAll.Name = "txt_SearchAll"
        Me.txt_SearchAll.Size = New System.Drawing.Size(409, 20)
        Me.txt_SearchAll.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(231, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Αναζήτηση Τμήματος:"
        '
        'btn_OK
        '
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_OK.Image = CType(resources.GetObject("btn_OK.Image"), System.Drawing.Image)
        Me.btn_OK.Location = New System.Drawing.Point(788, 24)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(35, 38)
        Me.btn_OK.TabIndex = 8
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(162, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Επαγγέλμα:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(634, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Πανεπιστήμιο:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.CausesValidation = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(162, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Επιστημονικό πεδίο:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.CausesValidation = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(634, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Πόλη:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_SearchAll)
        Me.Controls.Add(Me.btn_Info_University)
        Me.Controls.Add(Me.btn_Info_Scien)
        Me.Controls.Add(Me.btn_Info_Job)
        Me.Controls.Add(Me.btnInfoByJob)
        Me.Controls.Add(Me.bLogIn)
        Me.Controls.Add(Me.txtLoginUsername)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3150092DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3150092DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3150092DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fk1departmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fk1departmentscientificfieldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLoginUsername As TextBox
    Friend WithEvents bLogIn As Button
    Friend WithEvents P3150092DataSetBindingSource As BindingSource
    Friend WithEvents P3150092DataSet As p3150092DataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As p3150092DataSetTableAdapters.departmentTableAdapter
    Friend WithEvents Fk1departmentBindingSource As BindingSource
    Friend WithEvents BaseTableAdapter As p3150092DataSetTableAdapters.baseTableAdapter
    Friend WithEvents Fk1departmentscientificfieldBindingSource As BindingSource
    Friend WithEvents Department_scientific_fieldTableAdapter As p3150092DataSetTableAdapters.department_scientific_fieldTableAdapter
    Friend WithEvents DepartmentBindingSource2 As BindingSource
    Friend WithEvents DepartmentBindingSource1 As BindingSource
    Friend WithEvents P3150092DataSet1 As p3150092DataSet1
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As p3150092DataSet1TableAdapters.customerTableAdapter
    Friend WithEvents btnInfoByJob As Button
    Friend WithEvents btn_Info_Job As Button
    Friend WithEvents btn_Info_Scien As Button
    Friend WithEvents btn_Info_University As Button
    Friend WithEvents txt_SearchAll As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
