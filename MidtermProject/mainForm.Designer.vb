<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        RoundedPictureBox1 = New RoundedPictureBox()
        storePanel = New Panel()
        txtSearchproduct = New TextBox()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        homePanel = New Panel()
        Label57 = New Label()
        Label44 = New Label()
        Panel4 = New Panel()
        btnHistory = New BorderlessButton()
        btnCart = New BorderlessButton()
        Label13 = New Label()
        btnHome = New BorderlessButton()
        btnStore = New BorderlessButton()
        btnAbout = New BorderlessButton()
        btnSettings = New BorderlessButton()
        Panel3 = New Panel()
        panelCart = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Label3 = New Label()
        btnDelete = New Button()
        btnClear = New Button()
        btnCheckout = New Button()
        panelAbout = New Panel()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Label45 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label54 = New Label()
        Label55 = New Label()
        panelSettings = New Panel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        modPanel = New Panel()
        GroupBox3 = New GroupBox()
        btnPicture = New Button()
        RoundedPictureBox3 = New RoundedPictureBox()
        GroupBox4 = New GroupBox()
        CheckBox1 = New CheckBox()
        Label21 = New Label()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        cbPassword = New CheckBox()
        Label19 = New Label()
        newPass2 = New TextBox()
        Label20 = New Label()
        newPass = New TextBox()
        GroupBox1 = New GroupBox()
        cbUsername = New CheckBox()
        Label18 = New Label()
        newUsername = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        appPanel = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        Panel1 = New Panel()
        myID = New Label()
        Label22 = New Label()
        btnSett = New Button()
        btnMod = New Button()
        historyPanel = New Panel()
        Label23 = New Label()
        Label5 = New Label()
        DataGridView2 = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        ToolTip1 = New ToolTip(components)
        CType(RoundedPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        storePanel.SuspendLayout()
        homePanel.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        panelCart.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        panelAbout.SuspendLayout()
        panelSettings.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        modPanel.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(RoundedPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        appPanel.SuspendLayout()
        Panel1.SuspendLayout()
        historyPanel.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPictureBox1
        ' 
        RoundedPictureBox1.Location = New Point(35, 11)
        RoundedPictureBox1.Margin = New Padding(3, 2, 3, 2)
        RoundedPictureBox1.Name = "RoundedPictureBox1"
        RoundedPictureBox1.Size = New Size(55, 51)
        RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        RoundedPictureBox1.TabIndex = 34
        RoundedPictureBox1.TabStop = False
        ' 
        ' storePanel
        ' 
        storePanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        storePanel.Controls.Add(txtSearchproduct)
        storePanel.Controls.Add(Label2)
        storePanel.Controls.Add(FlowLayoutPanel1)
        storePanel.Dock = DockStyle.Fill
        storePanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        storePanel.Location = New Point(0, 0)
        storePanel.Margin = New Padding(3, 2, 3, 2)
        storePanel.Name = "storePanel"
        storePanel.Size = New Size(1418, 612)
        storePanel.TabIndex = 14
        ' 
        ' txtSearchproduct
        ' 
        txtSearchproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearchproduct.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtSearchproduct.BorderStyle = BorderStyle.FixedSingle
        txtSearchproduct.Font = New Font("Segoe UI", 10.3F)
        txtSearchproduct.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtSearchproduct.Location = New Point(25, 23)
        txtSearchproduct.Margin = New Padding(3, 2, 3, 2)
        txtSearchproduct.Multiline = True
        txtSearchproduct.Name = "txtSearchproduct"
        txtSearchproduct.PlaceholderText = "Search for product name or product model"
        txtSearchproduct.Size = New Size(1351, 31)
        txtSearchproduct.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 572)
        Label2.Name = "Label2"
        Label2.Size = New Size(323, 19)
        Label2.TabIndex = 32
        Label2.Text = "Product images reference is from different brands."
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Location = New Point(25, 67)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1351, 483)
        FlowLayoutPanel1.TabIndex = 31
        ' 
        ' homePanel
        ' 
        homePanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        homePanel.BackgroundImage = My.Resources.Resources.Untitled_design__9_
        homePanel.BackgroundImageLayout = ImageLayout.Zoom
        homePanel.Controls.Add(Label57)
        homePanel.Controls.Add(Label44)
        homePanel.Dock = DockStyle.Fill
        homePanel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        homePanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        homePanel.Location = New Point(0, 0)
        homePanel.Margin = New Padding(3, 2, 3, 2)
        homePanel.Name = "homePanel"
        homePanel.Size = New Size(1418, 612)
        homePanel.TabIndex = 15
        ' 
        ' Label57
        ' 
        Label57.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label57.AutoSize = True
        Label57.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        Label57.Location = New Point(481, 308)
        Label57.Name = "Label57"
        Label57.Size = New Size(483, 28)
        Label57.TabIndex = 32
        Label57.Text = "Apakah aku melakukannya dengan baik? bilang iya."
        ' 
        ' Label44
        ' 
        Label44.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label44.AutoSize = True
        Label44.BackColor = Color.Transparent
        Label44.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold)
        Label44.ForeColor = SystemColors.Control
        Label44.Location = New Point(526, 218)
        Label44.Name = "Label44"
        Label44.Size = New Size(366, 61)
        Label44.TabIndex = 30
        Label44.Text = "Welcome to MP!"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        Panel4.Controls.Add(btnHistory)
        Panel4.Controls.Add(btnCart)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(RoundedPictureBox1)
        Panel4.Controls.Add(btnHome)
        Panel4.Controls.Add(btnStore)
        Panel4.Controls.Add(btnAbout)
        Panel4.Controls.Add(btnSettings)
        Panel4.Dock = DockStyle.Top
        Panel4.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1418, 73)
        Panel4.TabIndex = 31
        ' 
        ' btnHistory
        ' 
        btnHistory.Anchor = AnchorStyles.Top
        btnHistory.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Image = My.Resources.Resources.icons8_time_machine_30
        btnHistory.Location = New Point(907, -1)
        btnHistory.Margin = New Padding(3, 2, 3, 2)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(132, 74)
        btnHistory.TabIndex = 37
        ToolTip1.SetToolTip(btnHistory, "Purchase History")
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnCart
        ' 
        btnCart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCart.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Image = My.Resources.Resources.icons8_fast_cart_30
        btnCart.Location = New Point(1285, 0)
        btnCart.Margin = New Padding(3, 2, 3, 2)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(132, 73)
        btnCart.TabIndex = 34
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.5F)
        Label13.Location = New Point(109, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 19)
        Label13.TabIndex = 35
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.Top
        btnHome.BackColor = Color.FromArgb(CByte(199), CByte(54), CByte(89))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Image = My.Resources.Resources.icons8_home_30__2_
        btnHome.Location = New Point(379, 0)
        btnHome.Margin = New Padding(3, 2, 3, 2)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(132, 73)
        btnHome.TabIndex = 33
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnStore
        ' 
        btnStore.Anchor = AnchorStyles.Top
        btnStore.FlatStyle = FlatStyle.Flat
        btnStore.Image = My.Resources.Resources.icons8_bag_301
        btnStore.Location = New Point(511, 0)
        btnStore.Margin = New Padding(3, 2, 3, 2)
        btnStore.Name = "btnStore"
        btnStore.Size = New Size(132, 73)
        btnStore.TabIndex = 34
        btnStore.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Anchor = AnchorStyles.Top
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.Image = My.Resources.Resources.icons8_about_30
        btnAbout.Location = New Point(643, 0)
        btnAbout.Margin = New Padding(3, 2, 3, 2)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(132, 73)
        btnAbout.TabIndex = 35
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnSettings
        ' 
        btnSettings.Anchor = AnchorStyles.Top
        btnSettings.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Image = My.Resources.Resources.icons8_setting_301
        btnSettings.Location = New Point(775, 0)
        btnSettings.Margin = New Padding(3, 2, 3, 2)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(132, 74)
        btnSettings.TabIndex = 36
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(homePanel)
        Panel3.Controls.Add(storePanel)
        Panel3.Controls.Add(panelCart)
        Panel3.Controls.Add(panelAbout)
        Panel3.Controls.Add(panelSettings)
        Panel3.Controls.Add(historyPanel)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 73)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1418, 612)
        Panel3.TabIndex = 16
        ' 
        ' panelCart
        ' 
        panelCart.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelCart.Controls.Add(DataGridView1)
        panelCart.Controls.Add(Label4)
        panelCart.Controls.Add(Label3)
        panelCart.Controls.Add(btnDelete)
        panelCart.Controls.Add(btnClear)
        panelCart.Controls.Add(btnCheckout)
        panelCart.Dock = DockStyle.Fill
        panelCart.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelCart.Location = New Point(0, 0)
        panelCart.Margin = New Padding(3, 2, 3, 2)
        panelCart.Name = "panelCart"
        panelCart.Size = New Size(1418, 612)
        panelCart.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(38, 42)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1339, 419)
        DataGridView1.TabIndex = 33
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 30
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product Code"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Product Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 300
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 300
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Quantity Count"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 300
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Subtotal per quantity count"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 300
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(92, 563)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 17)
        Label4.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(38, 563)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 17)
        Label3.TabIndex = 4
        Label3.Text = "Status :"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnDelete.Location = New Point(1046, 545)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 35)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnClear.Location = New Point(1158, 545)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 34)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnCheckout.Location = New Point(1270, 545)
        btnCheckout.Margin = New Padding(3, 2, 3, 2)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(106, 35)
        btnCheckout.TabIndex = 1
        btnCheckout.Text = "Place order"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' panelAbout
        ' 
        panelAbout.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelAbout.BackgroundImage = My.Resources.Resources.Untitled_design__11_
        panelAbout.BackgroundImageLayout = ImageLayout.Zoom
        panelAbout.Controls.Add(Label12)
        panelAbout.Controls.Add(Label11)
        panelAbout.Controls.Add(Label10)
        panelAbout.Controls.Add(Label9)
        panelAbout.Controls.Add(Label47)
        panelAbout.Controls.Add(Label48)
        panelAbout.Controls.Add(Label45)
        panelAbout.Controls.Add(Label8)
        panelAbout.Controls.Add(Label7)
        panelAbout.Controls.Add(Label6)
        panelAbout.Controls.Add(Label54)
        panelAbout.Controls.Add(Label55)
        panelAbout.Dock = DockStyle.Fill
        panelAbout.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelAbout.Location = New Point(0, 0)
        panelAbout.Margin = New Padding(3, 2, 3, 2)
        panelAbout.Name = "panelAbout"
        panelAbout.Size = New Size(1418, 612)
        panelAbout.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(265, 441)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 19)
        Label12.TabIndex = 29
        Label12.Text = "MySQL"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(244, 408)
        Label11.Name = "Label11"
        Label11.Size = New Size(181, 19)
        Label11.TabIndex = 28
        Label11.Text = "Microsoft Visual Basic .NET"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(134, 441)
        Label10.Name = "Label10"
        Label10.Size = New Size(133, 19)
        Label10.TabIndex = 27
        Label10.Text = "Other components :"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(134, 408)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 19)
        Label9.TabIndex = 26
        Label9.Text = "Language used :"
        ' 
        ' Label47
        ' 
        Label47.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label47.AutoSize = True
        Label47.Location = New Point(134, 554)
        Label47.Name = "Label47"
        Label47.Size = New Size(57, 17)
        Label47.TabIndex = 21
        Label47.Text = "BSCS-3A"
        ' 
        ' Label48
        ' 
        Label48.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label48.AutoSize = True
        Label48.Location = New Point(134, 513)
        Label48.Name = "Label48"
        Label48.Size = New Size(80, 17)
        Label48.TabIndex = 22
        Label48.Text = "Reyes, Ryan."
        ' 
        ' Label45
        ' 
        Label45.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label45.AutoSize = True
        Label45.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label45.Location = New Point(134, 478)
        Label45.Name = "Label45"
        Label45.Size = New Size(131, 19)
        Label45.TabIndex = 20
        Label45.Text = "Created by: alterrrrr"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label8.Location = New Point(118, 355)
        Label8.Name = "Label8"
        Label8.Size = New Size(203, 41)
        Label8.TabIndex = 25
        Label8.Text = "Development"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(134, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(736, 57)
        Label7.TabIndex = 24
        Label7.Text = resources.GetString("Label7.Text")
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label6.Location = New Point(118, 188)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 41)
        Label6.TabIndex = 23
        Label6.Text = "Goal"
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(134, 101)
        Label54.Name = "Label54"
        Label54.Size = New Size(751, 38)
        Label54.TabIndex = 13
        Label54.Text = "This software application is created for school project. This project is not for sale, and it is exclusive only to the owner." & vbCrLf & "If you have any concern kindly reach out or contact the creator."
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label55.Location = New Point(118, 45)
        Label55.Name = "Label55"
        Label55.Size = New Size(103, 41)
        Label55.TabIndex = 12
        Label55.Text = "About"
        ' 
        ' panelSettings
        ' 
        panelSettings.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelSettings.Controls.Add(Panel5)
        panelSettings.Controls.Add(Panel1)
        panelSettings.Dock = DockStyle.Fill
        panelSettings.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        panelSettings.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelSettings.Location = New Point(0, 0)
        panelSettings.Margin = New Padding(3, 2, 3, 2)
        panelSettings.Name = "panelSettings"
        panelSettings.Size = New Size(1418, 612)
        panelSettings.TabIndex = 36
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel2)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(212, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1206, 612)
        Panel5.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(modPanel)
        Panel2.Controls.Add(appPanel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1206, 612)
        Panel2.TabIndex = 6
        ' 
        ' modPanel
        ' 
        modPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        modPanel.Controls.Add(GroupBox3)
        modPanel.Controls.Add(GroupBox4)
        modPanel.Controls.Add(GroupBox2)
        modPanel.Controls.Add(GroupBox1)
        modPanel.Controls.Add(Label16)
        modPanel.Controls.Add(Label17)
        modPanel.Dock = DockStyle.Fill
        modPanel.Location = New Point(0, 0)
        modPanel.Margin = New Padding(3, 2, 3, 2)
        modPanel.Name = "modPanel"
        modPanel.Size = New Size(1206, 612)
        modPanel.TabIndex = 5
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnPicture)
        GroupBox3.Controls.Add(RoundedPictureBox3)
        GroupBox3.Location = New Point(33, 138)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(370, 221)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Choose profile"
        ' 
        ' btnPicture
        ' 
        btnPicture.FlatStyle = FlatStyle.Flat
        btnPicture.Location = New Point(134, 173)
        btnPicture.Margin = New Padding(3, 2, 3, 2)
        btnPicture.Name = "btnPicture"
        btnPicture.Size = New Size(82, 25)
        btnPicture.TabIndex = 5
        btnPicture.Text = "Confirm"
        btnPicture.UseVisualStyleBackColor = True
        ' 
        ' RoundedPictureBox3
        ' 
        RoundedPictureBox3.Location = New Point(106, 33)
        RoundedPictureBox3.Margin = New Padding(3, 2, 3, 2)
        RoundedPictureBox3.Name = "RoundedPictureBox3"
        RoundedPictureBox3.Size = New Size(140, 126)
        RoundedPictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        RoundedPictureBox3.TabIndex = 4
        RoundedPictureBox3.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Controls.Add(Label21)
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Location = New Point(850, 138)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(277, 121)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(0, 0)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(113, 23)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Change name"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(29, 37)
        Label21.Name = "Label21"
        Label21.Size = New Size(83, 19)
        Label21.TabIndex = 1
        Label21.Text = "New name :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(29, 66)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 25)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top
        GroupBox2.Controls.Add(cbPassword)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(newPass2)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(newPass)
        GroupBox2.Location = New Point(455, 279)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(338, 179)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' cbPassword
        ' 
        cbPassword.AutoSize = True
        cbPassword.Location = New Point(0, 0)
        cbPassword.Margin = New Padding(3, 2, 3, 2)
        cbPassword.Name = "cbPassword"
        cbPassword.Size = New Size(138, 23)
        cbPassword.TabIndex = 6
        cbPassword.Text = "Change password"
        cbPassword.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(29, 99)
        Label19.Name = "Label19"
        Label19.Size = New Size(115, 19)
        Label19.TabIndex = 3
        Label19.Text = "Repeat password"
        ' 
        ' newPass2
        ' 
        newPass2.Location = New Point(29, 127)
        newPass2.Margin = New Padding(3, 2, 3, 2)
        newPass2.Name = "newPass2"
        newPass2.Size = New Size(218, 25)
        newPass2.TabIndex = 2
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(29, 36)
        Label20.Name = "Label20"
        Label20.Size = New Size(108, 19)
        Label20.TabIndex = 1
        Label20.Text = "New password :"
        ' 
        ' newPass
        ' 
        newPass.Location = New Point(29, 65)
        newPass.Margin = New Padding(3, 2, 3, 2)
        newPass.Name = "newPass"
        newPass.Size = New Size(218, 25)
        newPass.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top
        GroupBox1.Controls.Add(cbUsername)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(newUsername)
        GroupBox1.Location = New Point(455, 138)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(338, 121)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' cbUsername
        ' 
        cbUsername.AutoSize = True
        cbUsername.Location = New Point(0, 0)
        cbUsername.Margin = New Padding(3, 2, 3, 2)
        cbUsername.Name = "cbUsername"
        cbUsername.Size = New Size(139, 23)
        cbUsername.TabIndex = 2
        cbUsername.Text = "Change username"
        cbUsername.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(29, 37)
        Label18.Name = "Label18"
        Label18.Size = New Size(109, 19)
        Label18.TabIndex = 1
        Label18.Text = "New username :"
        ' 
        ' newUsername
        ' 
        newUsername.Location = New Point(29, 66)
        newUsername.Margin = New Padding(3, 2, 3, 2)
        newUsername.Name = "newUsername"
        newUsername.Size = New Size(218, 25)
        newUsername.TabIndex = 0
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(33, 61)
        Label16.Name = "Label16"
        Label16.Size = New Size(291, 19)
        Label16.TabIndex = 1
        Label16.Text = "Modify your password, email, username here."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label17.Location = New Point(31, 18)
        Label17.Name = "Label17"
        Label17.Size = New Size(288, 41)
        Label17.TabIndex = 0
        Label17.Text = "Account credentials"
        ' 
        ' appPanel
        ' 
        appPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        appPanel.Controls.Add(Label15)
        appPanel.Controls.Add(Label14)
        appPanel.Dock = DockStyle.Fill
        appPanel.Location = New Point(0, 0)
        appPanel.Margin = New Padding(3, 2, 3, 2)
        appPanel.Name = "appPanel"
        appPanel.Size = New Size(1206, 612)
        appPanel.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(467, 315)
        Label15.Name = "Label15"
        Label15.Size = New Size(324, 19)
        Label15.TabIndex = 1
        Label15.Text = "No available feature for now. Soon to be available."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(555, 267)
        Label14.Name = "Label14"
        Label14.Size = New Size(110, 25)
        Label14.TabIndex = 0
        Label14.Text = "App setting"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Panel1.Controls.Add(myID)
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(btnSett)
        Panel1.Controls.Add(btnMod)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(212, 612)
        Panel1.TabIndex = 5
        ' 
        ' myID
        ' 
        myID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        myID.AutoSize = True
        myID.Location = New Point(149, 580)
        myID.Name = "myID"
        myID.Size = New Size(17, 19)
        myID.TabIndex = 15
        myID.Text = "0"
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label22.AutoSize = True
        Label22.Location = New Point(38, 580)
        Label22.Name = "Label22"
        Label22.Size = New Size(111, 19)
        Label22.TabIndex = 14
        Label22.Text = "Your fucking id :"
        ' 
        ' btnSett
        ' 
        btnSett.Anchor = AnchorStyles.Left
        btnSett.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        btnSett.FlatStyle = FlatStyle.Flat
        btnSett.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSett.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        btnSett.Location = New Point(0, 272)
        btnSett.Margin = New Padding(3, 2, 3, 2)
        btnSett.Name = "btnSett"
        btnSett.Size = New Size(211, 77)
        btnSett.TabIndex = 9
        btnSett.Text = "App setting"
        btnSett.UseVisualStyleBackColor = False
        ' 
        ' btnMod
        ' 
        btnMod.Anchor = AnchorStyles.Left
        btnMod.BackColor = Color.FromArgb(CByte(67), CByte(61), CByte(63))
        btnMod.FlatStyle = FlatStyle.Flat
        btnMod.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMod.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        btnMod.Location = New Point(0, 197)
        btnMod.Margin = New Padding(3, 2, 3, 2)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(211, 77)
        btnMod.TabIndex = 8
        btnMod.Text = "Modify credentials"
        btnMod.UseVisualStyleBackColor = False
        ' 
        ' historyPanel
        ' 
        historyPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        historyPanel.BackgroundImageLayout = ImageLayout.Zoom
        historyPanel.Controls.Add(Label23)
        historyPanel.Controls.Add(Label5)
        historyPanel.Controls.Add(DataGridView2)
        historyPanel.Dock = DockStyle.Fill
        historyPanel.Font = New Font("Segoe UI", 8.830189F)
        historyPanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        historyPanel.Location = New Point(0, 0)
        historyPanel.Margin = New Padding(3, 2, 3, 2)
        historyPanel.Name = "historyPanel"
        historyPanel.Size = New Size(1418, 612)
        historyPanel.TabIndex = 33
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(609, 45)
        Label23.Name = "Label23"
        Label23.Size = New Size(236, 20)
        Label23.TabIndex = 2
        Label23.Text = "Review your purchase history here."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(632, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 25)
        Label5.TabIndex = 1
        Label5.Text = "PURCHASE HISTORY"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column7, Column8, Column9})
        DataGridView2.Location = New Point(38, 77)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 45
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(1354, 502)
        DataGridView2.TabIndex = 0
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Order ID"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 500
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Item Code"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 400
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Order by"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 400
        ' 
        ' mainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1418, 685)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "mainForm"
        StartPosition = FormStartPosition.CenterScreen
        CType(RoundedPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        storePanel.ResumeLayout(False)
        storePanel.PerformLayout()
        homePanel.ResumeLayout(False)
        homePanel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        panelCart.ResumeLayout(False)
        panelCart.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        panelAbout.ResumeLayout(False)
        panelAbout.PerformLayout()
        panelSettings.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        modPanel.ResumeLayout(False)
        modPanel.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(RoundedPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        appPanel.ResumeLayout(False)
        appPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        historyPanel.ResumeLayout(False)
        historyPanel.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents storePanel As Panel
    Friend WithEvents homePanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelCart As Panel
    Friend WithEvents panelAbout As Panel
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label57 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents txtSearchproduct As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundedPictureBox1 As RoundedPictureBox
    Friend WithEvents panelSettings As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents modPanel As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPicture As Button
    Friend WithEvents RoundedPictureBox3 As RoundedPictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbPassword As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents newPass2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents newPass As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUsername As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents newUsername As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents appPanel As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents myID As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnSett As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnStore As BorderlessButton
    Friend WithEvents btnHome As BorderlessButton
    Friend WithEvents btnAbout As BorderlessButton
    Friend WithEvents btnSettings As BorderlessButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnCart As BorderlessButton
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents orderIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHistory As BorderlessButton
    Friend WithEvents historyPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
