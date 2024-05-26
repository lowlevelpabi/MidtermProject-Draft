<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountOption
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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Button1.Location = New Point(56, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 38)
        Button1.TabIndex = 12
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(203, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 17)
        Label1.TabIndex = 13
        Label1.Text = "OR"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Button2.Location = New Point(258, 68)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 38)
        Button2.TabIndex = 14
        Button2.Text = "Sign up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(394, 17)
        Label2.TabIndex = 15
        Label2.Text = "Looks like you're not signed-in yet, please sign-in first to add-cart."
        ' 
        ' accountOption
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 129)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "accountOption"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
