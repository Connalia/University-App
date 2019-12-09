<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Base
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Base))
        Me.ListBoxDepartment = New System.Windows.Forms.ListBox()
        Me.ListBoxNum = New System.Windows.Forms.ListBox()
        Me.txt_Num = New System.Windows.Forms.TextBox()
        Me.txt_depart = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txt_Year = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEndEditBase = New System.Windows.Forms.Button()
        Me.txt_dID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxDepartment
        '
        Me.ListBoxDepartment.FormattingEnabled = True
        Me.ListBoxDepartment.Location = New System.Drawing.Point(229, 25)
        Me.ListBoxDepartment.Name = "ListBoxDepartment"
        Me.ListBoxDepartment.Size = New System.Drawing.Size(254, 589)
        Me.ListBoxDepartment.TabIndex = 0
        '
        'ListBoxNum
        '
        Me.ListBoxNum.FormattingEnabled = True
        Me.ListBoxNum.Location = New System.Drawing.Point(509, 25)
        Me.ListBoxNum.Name = "ListBoxNum"
        Me.ListBoxNum.Size = New System.Drawing.Size(120, 589)
        Me.ListBoxNum.TabIndex = 1
        '
        'txt_Num
        '
        Me.txt_Num.Location = New System.Drawing.Point(670, 164)
        Me.txt_Num.Name = "txt_Num"
        Me.txt_Num.Size = New System.Drawing.Size(282, 20)
        Me.txt_Num.TabIndex = 2
        '
        'txt_depart
        '
        Me.txt_depart.Location = New System.Drawing.Point(669, 118)
        Me.txt_depart.Name = "txt_depart"
        Me.txt_depart.Size = New System.Drawing.Size(283, 20)
        Me.txt_depart.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(665, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Τμήμα:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(666, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Μόρια-Βάση:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(877, 187)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Εισαγωγή"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Khaki
        Me.btnUpdate.Location = New System.Drawing.Point(670, 237)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 48)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Ενημέρωση"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txt_Year
        '
        Me.txt_Year.Location = New System.Drawing.Point(60, 118)
        Me.txt_Year.Name = "txt_Year"
        Me.txt_Year.Size = New System.Drawing.Size(115, 20)
        Me.txt_Year.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(56, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Χρονολογία:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(100, 144)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEndEditBase
        '
        Me.btnEndEditBase.BackColor = System.Drawing.Color.Maroon
        Me.btnEndEditBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndEditBase.ForeColor = System.Drawing.Color.Khaki
        Me.btnEndEditBase.Location = New System.Drawing.Point(1019, 621)
        Me.btnEndEditBase.Name = "btnEndEditBase"
        Me.btnEndEditBase.Size = New System.Drawing.Size(144, 46)
        Me.btnEndEditBase.TabIndex = 12
        Me.btnEndEditBase.Text = "Τέλος Επεξεργασίας"
        Me.btnEndEditBase.UseVisualStyleBackColor = False
        '
        'txt_dID
        '
        Me.txt_dID.Location = New System.Drawing.Point(796, 189)
        Me.txt_dID.Name = "txt_dID"
        Me.txt_dID.Size = New System.Drawing.Size(75, 20)
        Me.txt_dID.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(758, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "dID:"
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(832, 237)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(120, 48)
        Me.btn_Delete.TabIndex = 27
        Me.btn_Delete.Text = "Διαγραφή"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'Edit_Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_dID)
        Me.Controls.Add(Me.btnEndEditBase)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Year)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_depart)
        Me.Controls.Add(Me.txt_Num)
        Me.Controls.Add(Me.ListBoxNum)
        Me.Controls.Add(Me.ListBoxDepartment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Edit_Base"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxDepartment As ListBox
    Friend WithEvents ListBoxNum As ListBox
    Friend WithEvents txt_Num As TextBox
    Friend WithEvents txt_depart As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txt_Year As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEndEditBase As Button
    Friend WithEvents txt_dID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Delete As Button
End Class
