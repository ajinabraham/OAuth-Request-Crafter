<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oauthrequestcrafter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(oauthrequestcrafter))
        Me.urlz = New System.Windows.Forms.TextBox()
        Me.parameters = New System.Windows.Forms.TextBox()
        Me.method = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.version = New System.Windows.Forms.TextBox()
        Me.ckey = New System.Windows.Forms.TextBox()
        Me.csecret = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tokensecret = New System.Windows.Forms.TextBox()
        Me.token = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.headers = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cookies = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RTB = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.responseheaders = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.signaturemethod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.browserparams = New System.Windows.Forms.WebBrowser()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetProxyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.oauth_auth_header = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'urlz
        '
        Me.urlz.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urlz.Location = New System.Drawing.Point(137, 54)
        Me.urlz.Name = "urlz"
        Me.urlz.Size = New System.Drawing.Size(765, 23)
        Me.urlz.TabIndex = 0
        '
        'parameters
        '
        Me.parameters.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parameters.Location = New System.Drawing.Point(137, 84)
        Me.parameters.Name = "parameters"
        Me.parameters.Size = New System.Drawing.Size(765, 23)
        Me.parameters.TabIndex = 1
        '
        'method
        '
        Me.method.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.method.FormattingEnabled = True
        Me.method.Items.AddRange(New Object() {"GET", "POST", "PUT", "DELETE"})
        Me.method.Location = New System.Drawing.Point(137, 24)
        Me.method.Name = "method"
        Me.method.Size = New System.Drawing.Size(63, 23)
        Me.method.TabIndex = 2
        Me.method.Text = "GET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Method:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "URL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Parameters:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Version:"
        '
        'version
        '
        Me.version.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.Location = New System.Drawing.Point(257, 24)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(77, 23)
        Me.version.TabIndex = 7
        Me.version.Text = "1.0"
        '
        'ckey
        '
        Me.ckey.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckey.Location = New System.Drawing.Point(137, 114)
        Me.ckey.Name = "ckey"
        Me.ckey.Size = New System.Drawing.Size(336, 23)
        Me.ckey.TabIndex = 8
        '
        'csecret
        '
        Me.csecret.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csecret.Location = New System.Drawing.Point(137, 144)
        Me.csecret.Name = "csecret"
        Me.csecret.Size = New System.Drawing.Size(336, 23)
        Me.csecret.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Consumer Secret:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Consumer Key:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Token:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Token secret:"
        '
        'tokensecret
        '
        Me.tokensecret.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokensecret.Location = New System.Drawing.Point(574, 146)
        Me.tokensecret.Name = "tokensecret"
        Me.tokensecret.Size = New System.Drawing.Size(328, 23)
        Me.tokensecret.TabIndex = 13
        '
        'token
        '
        Me.token.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.token.Location = New System.Drawing.Point(574, 114)
        Me.token.Name = "token"
        Me.token.Size = New System.Drawing.Size(328, 23)
        Me.token.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.headers)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 158)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Headers"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(258, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(177, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'headers
        '
        Me.headers.FormattingEnabled = True
        Me.headers.Items.AddRange(New Object() {"User-Agent: Dalvik/1.6.0 (Linux; U; Android 4.4.2; MotoX01 Build/KOT49H)", "Accept-Encoding: gzip"})
        Me.headers.Location = New System.Drawing.Point(15, 20)
        Me.headers.Name = "headers"
        Me.headers.Size = New System.Drawing.Size(415, 108)
        Me.headers.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.cookies)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Location = New System.Drawing.Point(479, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 158)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cookies"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(334, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cookies
        '
        Me.cookies.FormattingEnabled = True
        Me.cookies.Location = New System.Drawing.Point(13, 20)
        Me.cookies.Name = "cookies"
        Me.cookies.Size = New System.Drawing.Size(396, 108)
        Me.cookies.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(253, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Remove"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(172, 129)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Edit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(91, 129)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Add"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Controls.Add(Me.responseheaders)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 365)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(873, 310)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESPONSE"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(449, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(410, 279)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RTB)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(402, 253)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Raw View"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RTB
        '
        Me.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB.Location = New System.Drawing.Point(5, 7)
        Me.RTB.Name = "RTB"
        Me.RTB.Size = New System.Drawing.Size(391, 243)
        Me.RTB.TabIndex = 0
        Me.RTB.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.browser)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(402, 253)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Browser View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(3, 3)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(393, 244)
        Me.browser.TabIndex = 25
        '
        'responseheaders
        '
        Me.responseheaders.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.responseheaders.Location = New System.Drawing.Point(12, 19)
        Me.responseheaders.Multiline = True
        Me.responseheaders.Name = "responseheaders"
        Me.responseheaders.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.responseheaders.Size = New System.Drawing.Size(432, 276)
        Me.responseheaders.TabIndex = 24
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(732, 333)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(170, 35)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "CLOSE"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(570, 333)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(156, 35)
        Me.Button11.TabIndex = 25
        Me.Button11.Text = "REQUEST"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'signaturemethod
        '
        Me.signaturemethod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signaturemethod.Location = New System.Drawing.Point(449, 25)
        Me.signaturemethod.Name = "signaturemethod"
        Me.signaturemethod.Size = New System.Drawing.Size(128, 23)
        Me.signaturemethod.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Signature Method:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(794, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 37)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.Visible = False
        '
        'browserparams
        '
        Me.browserparams.Location = New System.Drawing.Point(628, 2)
        Me.browserparams.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browserparams.Name = "browserparams"
        Me.browserparams.Size = New System.Drawing.Size(87, 40)
        Me.browserparams.TabIndex = 26
        Me.browserparams.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(489, 343)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Use Proxy"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(929, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetProxyToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SetProxyToolStripMenuItem
        '
        Me.SetProxyToolStripMenuItem.Name = "SetProxyToolStripMenuItem"
        Me.SetProxyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SetProxyToolStripMenuItem.Text = "Set Proxy"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CheckBox2.Location = New System.Drawing.Point(301, 343)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(172, 17)
        Me.CheckBox2.TabIndex = 31
        Me.CheckBox2.Text = "OAuth as Authorization Header"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'oauth_auth_header
        '
        Me.oauth_auth_header.Location = New System.Drawing.Point(742, 22)
        Me.oauth_auth_header.Name = "oauth_auth_header"
        Me.oauth_auth_header.Size = New System.Drawing.Size(125, 20)
        Me.oauth_auth_header.TabIndex = 32
        Me.oauth_auth_header.Text = resources.GetString("oauth_auth_header.Text")
        Me.oauth_auth_header.Visible = False
        '
        'oauthrequestcrafter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 689)
        Me.Controls.Add(Me.oauth_auth_header)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.browserparams)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.signaturemethod)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tokensecret)
        Me.Controls.Add(Me.token)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.csecret)
        Me.Controls.Add(Me.ckey)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.method)
        Me.Controls.Add(Me.parameters)
        Me.Controls.Add(Me.urlz)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "oauthrequestcrafter"
        Me.Text = "OAuth 1.0a Request Crafter"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents urlz As System.Windows.Forms.TextBox
    Friend WithEvents parameters As System.Windows.Forms.TextBox
    Friend WithEvents method As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents version As System.Windows.Forms.TextBox
    Friend WithEvents ckey As System.Windows.Forms.TextBox
    Friend WithEvents csecret As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tokensecret As System.Windows.Forms.TextBox
    Friend WithEvents token As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents headers As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cookies As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents responseheaders As System.Windows.Forms.TextBox
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents signaturemethod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents browserparams As System.Windows.Forms.WebBrowser
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetProxyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents oauth_auth_header As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RTB As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

End Class
