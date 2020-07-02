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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnNewWindow = New System.Windows.Forms.Button()
        Me.srchGo = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnGoForth = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.AllowDrop = True
        Me.txtURL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.txtURL.Location = New System.Drawing.Point(206, 10)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(413, 20)
        Me.txtURL.TabIndex = 4
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(1, 41)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(983, 520)
        Me.WebBrowser1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.Location = New System.Drawing.Point(683, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtSearch.TabIndex = 6
        '
        'btnNewWindow
        '
        Me.btnNewWindow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNewWindow.Image = Global.Luna_Beta_1.My.Resources.Resources.page_new
        Me.btnNewWindow.Location = New System.Drawing.Point(654, 8)
        Me.btnNewWindow.Name = "btnNewWindow"
        Me.btnNewWindow.Size = New System.Drawing.Size(23, 23)
        Me.btnNewWindow.TabIndex = 0
        Me.btnNewWindow.UseVisualStyleBackColor = True
        '
        'srchGo
        '
        Me.srchGo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.srchGo.Image = Global.Luna_Beta_1.My.Resources.Resources.bullet_magnify
        Me.srchGo.Location = New System.Drawing.Point(870, 8)
        Me.srchGo.Name = "srchGo"
        Me.srchGo.Size = New System.Drawing.Size(23, 23)
        Me.srchGo.TabIndex = 0
        Me.srchGo.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGo.Image = Global.Luna_Beta_1.My.Resources.Resources.action_go
        Me.btnGo.Location = New System.Drawing.Point(625, 8)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(23, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnGoHome
        '
        Me.btnGoHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGoHome.Image = Global.Luna_Beta_1.My.Resources.Resources.icon_home
        Me.btnGoHome.Location = New System.Drawing.Point(177, 8)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(23, 23)
        Me.btnGoHome.TabIndex = 0
        Me.btnGoHome.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReload.Image = Global.Luna_Beta_1.My.Resources.Resources.action_refresh_blue
        Me.btnReload.Location = New System.Drawing.Point(148, 8)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(23, 23)
        Me.btnReload.TabIndex = 0
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnGoForth
        '
        Me.btnGoForth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGoForth.Image = Global.Luna_Beta_1.My.Resources.Resources.action_forward
        Me.btnGoForth.Location = New System.Drawing.Point(119, 8)
        Me.btnGoForth.Name = "btnGoForth"
        Me.btnGoForth.Size = New System.Drawing.Size(23, 23)
        Me.btnGoForth.TabIndex = 0
        Me.btnGoForth.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGoBack.Image = Global.Luna_Beta_1.My.Resources.Resources.action_back
        Me.btnGoBack.Location = New System.Drawing.Point(90, 8)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(23, 23)
        Me.btnGoBack.TabIndex = 0
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnNewWindow)
        Me.Controls.Add(Me.srchGo)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnGoHome)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnGoForth)
        Me.Controls.Add(Me.btnGoBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Luna Internet Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoBack As Button
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnGoForth As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents btnGoHome As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnGo As Button
    Friend WithEvents btnNewWindow As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents srchGo As Button
End Class
