Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector


' wag nyo pansinin 'to, hindi 'to importante :) mema lang :)

Public Class AllFunctionsMain

    Public Shared Sub createItem(mainForm As mainForm)

        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(len) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))


        mainForm.pan = New Panel
        With mainForm.pan
            .Width = 250
            .Height = 390
            .BackColor = Color.Transparent
            .Tag = dr.Item("prd_code").ToString
            .BorderStyle = BorderStyle.FixedSingle
            .Margin = New Padding(50, 50, 0, 0)
        End With
        mainForm.pan_top = New Panel
        With mainForm.pan_top
            .Width = 150
            .Height = 6
            .BackColor = Color.FromArgb(40, 40, 40)
            .Dock = DockStyle.Top
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.img = New PictureBox
        With mainForm.img
            .Height = 170
            .Width = 170
            .BackgroundImageLayout = ImageLayout.Zoom
            .Dock = DockStyle.Top
            .Tag = dr.Item("prd_code").ToString
        End With


        mainForm.spacer = New Panel
        With mainForm.spacer
            .Height = 20
            .Dock = DockStyle.Top
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.prdcode = New Label
        With mainForm.prdcode
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 0, 0, 5)
            .Margin = New Padding(0, 0, 10, 0)
            .Tag = dr.Item("prd_code").ToString
            .Visible = False
        End With

        mainForm.prdname = New Label
        With mainForm.prdname
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.prdmodel = New Label
        With mainForm.prdmodel
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.price = New Label
        With mainForm.price
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.stock = New Label
        With mainForm.stock
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.BottomCenter
            .Dock = DockStyle.Bottom
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .Tag = dr.Item("prd_code").ToString
        End With

        mainForm.stock_count = New Label
        With mainForm.stock
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("prd_code").ToString
        End With

        Dim ms As New IO.MemoryStream(array)
        Dim bitmap As New Bitmap(ms)
        mainForm.img.BackgroundImage = bitmap

        mainForm.stock_count.Text = dr.Item("prd_stock").ToString
        mainForm.stock.Text = "Available stock: " + mainForm.stock_count.Text
        mainForm.prdcode.Text = "Code : " & dr.Item("prd_code").ToString
        mainForm.prdname.Text = "Product : " & dr.Item("prd_name").ToString
        mainForm.prdmodel.Text = "Model : " & dr.Item("prd_model").ToString
        mainForm.price.Text = "Price : " & dr.Item("prd_price").ToString

        mainForm.pan.Controls.Add(mainForm.stock)
        mainForm.pan.Controls.Add(mainForm.price)
        mainForm.pan.Controls.Add(mainForm.prdmodel)
        mainForm.pan.Controls.Add(mainForm.prdname)
        mainForm.pan.Controls.Add(mainForm.prdcode)
        mainForm.pan.Controls.Add(mainForm.img)
        mainForm.pan.Controls.Add(mainForm.pan_top)
        mainForm.FlowLayoutPanel1.Controls.Add(mainForm.pan)

        AddHandler mainForm.img.Click, AddressOf mainForm.img_Click

    End Sub

    Public Shared Sub toCart(mainForm As mainForm, sender As Object)


        If (Not String.IsNullOrEmpty(mainForm.unSession)) Then

            conn.Open()

            Try

                cmd = New MySqlCommand("SELECT `prd_code`, `prd_name`, `prd_price`, `prd_stock` FROM `products` WHERE `prd_code` LIKE '" & sender.tag.ToString & "%' ", conn)

                dr = cmd.ExecuteReader

                While dr.Read

                    Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer

                    For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                        If row.Cells(1).Value IsNot Nothing Then

                            If row.Cells(1).Value.ToString = dr.Item("prd_code") Then

                                exist = True

                                numrow = row.Index

                                numtext = CInt(row.Cells(4).Value)

                            End If

                            Exit For

                        End If

                    Next

                    Dim stockCount As Integer = Convert.ToInt32(dr("prd_stock"))

                    If exist = False And stockCount > 0 Then

                        Dim price As Decimal = dr("prd_price")

                        Dim subtotalprice As Double

                        subtotalprice = price * 1

                        mainForm.DataGridView1.Rows.Add(mainForm.DataGridView1.Rows.Count & 1, dr.Item("prd_code"), dr.Item("prd_name"), dr.Item("prd_price"), 1, subtotalprice)

                    ElseIf exist = False And stockCount = 0 Then

                        mainForm.stock_count.Text = mainForm.stock_count.Text + " (Out of stock)"

                        MsgBox("This product is out of stock", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                    Else

                        mainForm.DataGridView1.Rows(numrow).Cells(4).Value = "1" + numtext

                        mainForm.DataGridView1.Rows(numrow).Cells(5).Value = mainForm.DataGridView1.Rows(numrow).Cells(3).Value * mainForm.DataGridView1.Rows(numrow).Cells(4).Value

                    End If

                End While

            Catch ex As MySqlException

                MsgBox("Server is offline", ex.Message)

            End Try

            dr.Dispose()

            conn.Close()

        Else



            If (String.IsNullOrEmpty(mainForm.unSession)) Then

                accountOption.ShowDialog()

            End If

        End If

        Try

            mainForm.connect.openConnection()

            For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim cartid As String = mainForm.cartIdGenerated

                    Dim itemcode As Integer = Convert.ToInt32(row.Cells("Column2").Value)

                    Dim itemname As String = row.Cells("Column3").Value.ToString()

                    Dim itemprice As Integer = Convert.ToInt32(row.Cells("Column4").Value)

                    Dim itemqty As Integer = Convert.ToInt32(row.Cells("Column5").Value)

                    Dim itemsubt As Integer = Convert.ToInt32(row.Cells("Column6").Value)

                    Dim cartby As String = mainForm.unSession

                    Dim sessionid As Integer = mainForm.cartIdByUser


                    Dim cmd As New MySqlCommand("INSERT INTO `table_cart` (`cart_id`, `item_code`, `item_name`, `item_price`, `item_qty`, `item_subt`, `cart_by`, `id`) VALUES (@cartid, @itemcode, @itemname, @itemprice, @itemqty, @itemsubt, @cartby, @sessionid)", mainForm.connect.getConnection())

                    cmd.Parameters.Add("@cartid", MySqlDbType.Int32).Value = cartid

                    cmd.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode

                    cmd.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname

                    cmd.Parameters.Add("@itemprice", MySqlDbType.Int32).Value = itemprice

                    cmd.Parameters.Add("@itemqty", MySqlDbType.Int32).Value = itemqty

                    cmd.Parameters.Add("@itemsubt", MySqlDbType.Int32).Value = itemsubt

                    cmd.Parameters.Add("@cartby", MySqlDbType.Int32).Value = cartby

                    cmd.Parameters.Add("@sessionid", MySqlDbType.Int32).Value = sessionid

                    cmd.ExecuteNonQuery()

                End If

            Next

        Catch ex As MySqlException

            MessageBox.Show("An error occurred: " & ex.Message)

        Finally

            mainForm.connect.closeConnection()

        End Try

    End Sub

    Public Shared Sub mainFunction(mainForm As mainForm)


        ' - controls behavior if unSession is blank and isLoginSession is false

        If mainForm.unSession = String.Empty And mainForm.isLoginSession = False Then

            mainForm.RoundedPictureBox1.Visible = False

            mainForm.btnHistory.Visible = False

            mainForm.Text = "Midterm Project : Main"

            mainForm.Label1.Visible = True

            mainForm.LinkLabel1.Visible = True

        Else

            mainForm.Text = "Midterm Project : Main | Signed-in as: " & mainForm.unSession

            mainForm.btnHistory.Visible = True

            mainForm.Label1.Visible = False

            mainForm.LinkLabel1.Visible = False

        End If


        ' - sub 

        mainForm.Label13.Text = mainForm.unSession

        ' - ...


        ' - fetch id and user image

        mainForm.connection.Open()

        Dim dt As New DataSet

        Try

            Dim username As String = Form1.txtUsername.Text

            Dim sql As String = "SELECT * FROM altertable WHERE username='" & username & "'"

            Dim da As New MySqlDataAdapter(sql, mainForm.connection)

            da.Fill(dt, "altertable")

            mainForm.myID.DataBindings.Add("text", dt, "altertable.id")




            Dim cmd As New MySqlCommand("SELECT * FROM altertable WHERE username='" & username & "'", mainForm.connection)

            Dim dr As MySqlDataReader

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Dim imagebytes As Byte() = CType(dr("usr_prf"), Byte())

                Using ms As New IO.MemoryStream(imagebytes)

                    mainForm.RoundedPictureBox1.Image = Image.FromStream(ms)

                    mainForm.RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                End Using

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        ' - ...


        ' - prerequisite for fetching and populating products :p

        dikoalamto()

        mainForm.Load_Items()

        ' - ...



        ' - groupbox color

        mainForm.GroupBox3.ForeColor = Color.FromArgb(192, 192, 194)

        ' - ...



        ' - extras

        mainForm.DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        mainForm.DataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView2.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        mainForm.ToolTip1.SetToolTip(mainForm.btnHome, "Home")

        mainForm.ToolTip1.SetToolTip(mainForm.btnStore, "Store")

        mainForm.ToolTip1.SetToolTip(mainForm.btnAbout, "Abut us")

        mainForm.ToolTip1.SetToolTip(mainForm.btnSettings, "Settings")

        If mainForm.RoundedPictureBox3.Image Is Nothing Then

            mainForm.btnPicture.Enabled = False

        End If

        ' - ...

    End Sub

    Public Shared Sub loader(mainForm As mainForm)

        mainForm.FlowLayoutPanel1.Controls.Clear()

        mainForm.FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT `prd_img`, `prd_code`, `prd_name`, `prd_model`, `prd_price`, `prd_stock` FROM `products`", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                mainForm.Load_Controls()

            End While

        Catch ex As MySqlException

            MsgBox("Server is offline")

        End Try

        conn.Close()


    End Sub

    Public Shared Sub functionOne(mainForm As mainForm)


        If mainForm.DataGridView1.Rows.Count = 0 Then

            mainForm.Label4.Text = "Cart is empty, no item can delete."
            mainForm.Label4.ForeColor = Color.Yellow

        Else


            Dim selectedRow As DataGridViewRow

            For Each selectedRow In mainForm.DataGridView1.SelectedRows  ' Assuming DataGridView1 is your DataGrid

                Dim response As Integer
                Dim itemName As String = selectedRow.Cells(2).Value ' Assuming item name is in first column (index 0)

                response = MsgBox("Are you sure you want to remove " & itemName & "?", MsgBoxStyle.Information + vbYesNo)

                If response = vbYes Then
                    mainForm.DataGridView1.Rows.Remove(selectedRow)  ' Remove the selected row
                    mainForm.Label4.ForeColor = Color.Green
                    mainForm.Label4.Text = "Item " & itemName & " removed."

                End If

            Next
            mainForm.DataGridView1.Refresh()
        End If
    End Sub

    Public Shared Sub functionTwo(mainForm As mainForm)

        If mainForm.DataGridView1.Rows.Count = 0 Then

            mainForm.Label4.Text = "Can't clear cart, no item found."
            mainForm.Label4.ForeColor = Color.Yellow

        Else
            mainForm.DataGridView1.Rows.Clear()

            mainForm.Label4.Text = "Item(s) cleared"
            mainForm.Label4.ForeColor = Color.Green

        End If

    End Sub

    Public Shared Sub checkOut(mainForm As mainForm)

        If mainForm.DataGridView1.Rows.Count = 0 Then


            mainForm.Label4.Text = "Get something else to the store and cart it before you proceed."
            mainForm.Label4.ForeColor = Color.Yellow

        Else

            checkoutItems.DataGridView1.Rows.Clear()


            For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)


                    For i As Integer = 0 To row.Cells.Count - 1

                        clonedRow.Cells(i).Value = row.Cells(i).Value

                    Next


                    checkoutItems.DataGridView1.Rows.Add(clonedRow)

                End If
            Next

            checkoutItems.ShowDialog()

        End If

    End Sub

    Public Shared Sub textIdentifier(mainForm As mainForm)

        mainForm.FlowLayoutPanel1.Controls.Clear()

        mainForm.FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT prd_img, prd_code, prd_name, prd_model, prd_price, prd_stock FROM products WHERE prd_name LIKE '%" & mainForm.txtSearchproduct.Text & "%' or prd_model LIKE '%" & mainForm.txtSearchproduct.Text & "%'", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                mainForm.Load_Controls()

            End While

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        conn.Close()

    End Sub


    Public Shared Sub signChecker(mainForm As mainForm)

        If Not String.IsNullOrEmpty(mainForm.unSession) Then

            '...

        Else

            If String.IsNullOrEmpty(mainForm.unSession) Then

                mainForm.Label13.Text = "You're not signed-in"

            End If

        End If

    End Sub

    Public Shared Sub orderIdExtractor(mainForm As mainForm)

        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim query As String = "SELECT id FROM altertable WHERE username=@username"

        Dim username As String = mainForm.unSession

        Try


            Using con As New MySqlConnection(cs)
                con.Open()

                Using cmd As New MySqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@username", username)


                    Using rdr As MySqlDataReader = cmd.ExecuteReader()

                        If rdr.Read() Then

                            mainForm.orderIdByUser = rdr("id")

                            mainForm.cartIdByUser = rdr("id")

                            checkoutItems.orderIdByUser = rdr("id")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As MySqlException

            MsgBox("Server is offline, can't retrieve id.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No connection")

            End

        End Try

    End Sub

    Public Shared Sub retrieveOrders(mainForm As mainForm)


        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim baseid As Integer = mainForm.orderIdByUser

        Try

            Dim con As New MySqlConnection(cs)

            con.Open()

            Dim cmd As New MySqlCommand("SELECT orders.order_id, orders.item_code, users.username, orders.item_name, orders.order_date, orders.item_price, orders.item_qty," &
                                        "orders.item_subt, orders.item_total FROM altertable AS users JOIN alter_orders AS orders ON users.id = orders.id WHERE orders.id Like @baseid;", con)

            cmd.Parameters.AddWithValue("@baseid", baseid)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            mainForm.DataGridView2.Rows.Clear()

            While (rdr.Read() = True)

                mainForm.DataGridView2.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8))

            End While

            con.Close()

        Catch ex As MySqlException

            MsgBox("Server is offline, can't retrieve orders.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No connection")

        End Try


    End Sub


    ' DI PA TAPOS TANGINA :))
    Public Shared Sub retrieveCart(mainForm As mainForm)

        Dim cs As String = "Server=localhost;Port=3306;database=alterdb;uid=root;pwd=;"

        Dim baseid1 As Integer = mainForm.cartIdByUser

        Try

            Dim con As New MySqlConnection(cs)

            con.Open()

            Dim cmd As New MySqlCommand("SELECT cart.cart_id, cart.item_code, cart.item_name, cart.item_price, cart.item_qty, cart.item_subt FROM altertable AS users JOIN table_cart AS cart ON users.id = cart.id WHERE cart.id LIKE @baseid1;", con) ' naka join dapat to

            cmd.Parameters.AddWithValue("@baseid1", baseid1)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            mainForm.DataGridView2.Rows.Clear()

            While (rdr.Read() = True)

                mainForm.DataGridView1.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))

            End While

            con.Close()

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error 1", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Shared Sub cartIdGenerator(mainForm As mainForm)

        Try

            Dim Num As Integer = 0

            mainForm.con = New MySqlConnection(mainForm.cs)

            mainForm.con.Open()

            Dim sql As String = ("SELECT MAX(cart_id) FROM table_cart")

            cmd = New MySqlCommand(sql)

            cmd.Connection = checkoutItems.con

            If (IsDBNull(cmd.ExecuteScalar)) Then

                Num = 1011

                mainForm.cartIdGenerated = Num.ToString

            Else

                Num = cmd.ExecuteScalar + 1

                mainForm.cartIdGenerated = Num.ToString

            End If

            cmd.Dispose()

            checkoutItems.con.Close()

            checkoutItems.con.Dispose()

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
