<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtUsername = New TextBox()
        txtPassword1 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        txtPassword2 = New TextBox()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.CharacterCasing = CharacterCasing.Lower
        txtUsername.Font = New Font("Segoe UI Semilight", 10F)
        txtUsername.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtUsername.Location = New Point(460, 201)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Create username"
        txtUsername.Size = New Size(299, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword1
        ' 
        txtPassword1.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtPassword1.BorderStyle = BorderStyle.None
        txtPassword1.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtPassword1.Location = New Point(460, 287)
        txtPassword1.Margin = New Padding(3, 4, 3, 4)
        txtPassword1.Name = "txtPassword1"
        txtPassword1.PasswordChar = "●"c
        txtPassword1.PlaceholderText = "Create password"
        txtPassword1.Size = New Size(299, 23)
        txtPassword1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Button1.Location = New Point(740, 525)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 34)
        Button1.TabIndex = 4
        Button1.Text = "Sign-up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(402, 599)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 5
        Label3.Text = "Status :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(460, 599)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 6
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        LinkLabel1.Location = New Point(460, 436)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(108, 20)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign-in instead"
        ' 
        ' txtPassword2
        ' 
        txtPassword2.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtPassword2.BorderStyle = BorderStyle.None
        txtPassword2.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword2.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtPassword2.Location = New Point(460, 376)
        txtPassword2.Margin = New Padding(3, 4, 3, 4)
        txtPassword2.Name = "txtPassword2"
        txtPassword2.PasswordChar = "●"c
        txtPassword2.PlaceholderText = "Confirm password"
        txtPassword2.Size = New Size(226, 23)
        txtPassword2.TabIndex = 9
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(692, 380)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 24)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.delete
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 628)
        Panel1.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label7.Location = New Point(197, 283)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 25)
        Label7.TabIndex = 15
        Label7.Text = "PROJECT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label6.Location = New Point(194, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 25)
        Label6.TabIndex = 14
        Label6.Text = "MIDTERM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 32F, FontStyle.Bold)
        Label8.Location = New Point(98, 245)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 72)
        Label8.TabIndex = 13
        Label8.Text = "MP"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.x_mark_4_24
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label9.Location = New Point(460, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 35)
        Label9.TabIndex = 17
        Label9.Text = "SIGN UP"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(884, 628)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(txtPassword2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(txtPassword1)
        Controls.Add(txtUsername)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Basta form 2 to :))"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
End Class
