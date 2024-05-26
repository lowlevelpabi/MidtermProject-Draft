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
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        Timer1 = New Timer(components)
        Label7 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.CharacterCasing = CharacterCasing.Lower
        txtUsername.Font = New Font("Segoe UI Semilight", 10F)
        txtUsername.ForeColor = SystemColors.Control
        txtUsername.Location = New Point(338, 166)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(262, 20)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword.ForeColor = SystemColors.Control
        txtPassword.Location = New Point(338, 243)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(262, 20)
        txtPassword.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label3.Location = New Point(95, 508)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 17)
        Label3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label4.Location = New Point(12, 508)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 17)
        Label4.TabIndex = 6
        Label4.Text = "Status :"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.ForeColor = SystemColors.Control
        CheckBox1.Location = New Point(338, 315)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(117, 21)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(539, 474)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 34)
        Button1.TabIndex = 11
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.x_mark_4_24
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 19)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        Label8.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(210, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 31)
        Label8.TabIndex = 16
        Label8.Text = "SIGN IN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label7.Location = New Point(134, 281)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 23)
        Label7.TabIndex = 19
        Label7.Text = "STORE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label6.Location = New Point(134, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 23)
        Label6.TabIndex = 18
        Label6.Text = "MEMA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label1.Font = New Font("Segoe UI Semibold", 32F, FontStyle.Bold)
        Label1.Location = New Point(50, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 65)
        Label1.TabIndex = 17
        Label1.Text = "MS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        BackgroundImage = My.Resources.Resources.Untitled_design__18_1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(683, 534)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label

End Class
