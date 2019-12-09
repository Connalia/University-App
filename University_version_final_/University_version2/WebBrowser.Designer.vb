<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txt_URL = New System.Windows.Forms.TextBox()
        Me.btnViewSiteURL = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 74)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1151, 549)
        Me.WebBrowser1.TabIndex = 0
        '
        'txt_URL
        '
        Me.txt_URL.Location = New System.Drawing.Point(93, 9)
        Me.txt_URL.Name = "txt_URL"
        Me.txt_URL.Size = New System.Drawing.Size(1070, 20)
        Me.txt_URL.TabIndex = 1
        '
        'btnViewSiteURL
        '
        Me.btnViewSiteURL.Location = New System.Drawing.Point(12, 9)
        Me.btnViewSiteURL.Name = "btnViewSiteURL"
        Me.btnViewSiteURL.Size = New System.Drawing.Size(75, 23)
        Me.btnViewSiteURL.TabIndex = 2
        Me.btnViewSiteURL.Text = "View Site"
        Me.btnViewSiteURL.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(93, 31)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(43, 37)
        Me.btnBack.TabIndex = 3
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.Location = New System.Drawing.Point(142, 31)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(41, 37)
        Me.btnForward.TabIndex = 4
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(1122, 31)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(41, 37)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 635)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnViewSiteURL)
        Me.Controls.Add(Me.txt_URL)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "WebBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebBrowser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As Windows.Forms.WebBrowser
    Friend WithEvents txt_URL As TextBox
    Friend WithEvents btnViewSiteURL As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnRefresh As Button
End Class
