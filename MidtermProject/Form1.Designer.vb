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
        components = New ComponentModel.Container()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.CharacterCasing = CharacterCasing.Lower
        txtUsername.Font = New Font("Segoe UI Semilight", 10F)
        txtUsername.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtUsername.Location = New Point(395, 200)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(262, 20)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtPassword.Location = New Point(395, 261)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(262, 20)
        txtPassword.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(415, 501)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 17)
        Label3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(364, 501)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 17)
        Label4.TabIndex = 6
        Label4.Text = "Status :"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        LinkLabel1.Location = New Point(529, 450)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(95, 17)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create account"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Location = New Point(395, 311)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(117, 21)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Button1.Location = New Point(643, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 29)
        Button1.TabIndex = 11
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.x_mark_4_24
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 19)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 534)
        Panel1.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label7.Location = New Point(172, 241)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 23)
        Label7.TabIndex = 15
        Label7.Text = "PROJECT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label6.Location = New Point(170, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 23)
        Label6.TabIndex = 14
        Label6.Text = "MIDTERM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 32F, FontStyle.Bold)
        Label5.Location = New Point(86, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 65)
        Label5.TabIndex = 13
        Label5.Text = "MP"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label8.Location = New Point(395, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 31)
        Label8.TabIndex = 16
        Label8.Text = "SIGN IN"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(774, 534)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Basta form 1 to :)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Timer1 As Timer

End Class
