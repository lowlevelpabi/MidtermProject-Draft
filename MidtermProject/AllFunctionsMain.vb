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

                    For Each itm As DataGridViewRow In mainForm.DataGridView1.Rows

                        If itm.Cells(1).Value IsNot Nothing Then

                            If itm.Cells(1).Value.ToString = dr.Item("prd_code") Then

                                exist = True

                                numrow = itm.Index

                                numtext = CInt(itm.Cells(4).Value)

                                Exit For
                            End If
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

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            dr.Dispose()

            conn.Close()

        Else



            If (String.IsNullOrEmpty(mainForm.unSession)) Then

                Dim response

                response = MsgBox("Looks like you're not sign-in? Would you like to sign-in first?", MsgBoxStyle.Exclamation + vbYesNo, "Not sign-in")

                If response = vbYes Then

                    Form1.Show()

                    mainForm.Hide()

                Else

                    ' ...

                End If

            End If

        End If

    End Sub

    Public Shared Sub mainFunction(mainForm As mainForm)

        mainForm.connection.Open()

        Dim dt As New DataSet

        Try

            Dim username As String = Form1.txtUsername.Text

            Dim sql As String = "SELECT * FROM altertable WHERE username='" & username & "'"

            Dim da As New MySqlDataAdapter(sql, mainForm.connection)

            da.Fill(dt, "altertable")

            mainForm.myID.DataBindings.Add("text", dt, "altertable.id")

            Dim cmd As New MySqlCommand("Select * FROM altertable WHERE username='" & username & "'", mainForm.connection)

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

        ' groupbox color
        mainForm.GroupBox3.ForeColor = Color.FromArgb(192, 192, 194)

        ' con for fetching items
        dbconn()
        mainForm.Load_Items()


        ' extras

        mainForm.Text = "Midterm Project : Main"

        mainForm.Label13.Text = "Logged-in as, " & Environment.NewLine & mainForm.unSession

        mainForm.DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        mainForm.DataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView2.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        If mainForm.RoundedPictureBox3.Image Is Nothing Then

            mainForm.btnPicture.Enabled = False
        End If

        mainForm.ToolTip1.SetToolTip(mainForm.btnHome, "Home")
        mainForm.ToolTip1.SetToolTip(mainForm.btnStore, "Store")
        mainForm.ToolTip1.SetToolTip(mainForm.btnAbout, "Abut us")
        mainForm.ToolTip1.SetToolTip(mainForm.btnSettings, "Settings")


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
        Catch ex As Exception
            MsgBox(ex.Message)
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
        Catch ex As Exception
            MsgBox(ex.Message)
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

        Dim query As String = "SELECT order_id FROM altertable WHERE username=@username"

        Dim username As String = mainForm.unSession

        Try


            Using con As New MySqlConnection(cs)
                con.Open()

                Using cmd As New MySqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@username", username)


                    Using rdr As MySqlDataReader = cmd.ExecuteReader()

                        If rdr.Read() Then

                            mainForm.orderIdByUser = rdr("order_id")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Shared Sub retrieveOrders(mainForm As mainForm)

        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim baseid As String = mainForm.orderIdByUser

        Try

            Dim con As New MySqlConnection(cs)

            con.Open()

            Dim cmd As New MySqlCommand("SELECT orders.order_id, orders.item_code, users.username FROM alter_orders AS orders JOIN altertable AS users ON orders.order_id = users.order_id WHERE users.order_id LIKE @baseid", con)

            cmd.Parameters.AddWithValue("@baseid", baseid)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            mainForm.DataGridView2.Rows.Clear()

            While (rdr.Read() = True)

                mainForm.DataGridView2.Rows.Add(rdr(0), rdr(1), rdr(2))

            End While

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class
