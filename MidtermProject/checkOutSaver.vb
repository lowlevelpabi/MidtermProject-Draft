Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports MySqlConnector
Imports Windows.Win32.System

Public Class checkOutSaver


    Public Shared Sub mainmemory(checkoutItems As checkoutItems, mainForm As mainForm)


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

                            checkoutItems.orderIdByUser = rdr("id")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Shared Sub orderInserter(checkoutItems As checkoutItems)

        Dim orderid As Integer = checkoutItems.generatedID

        Dim totalbill As Integer = Convert.ToInt32(checkoutItems.Label5.Text)


        Try

            Form2.conString.openConnection()

            For Each row As DataGridViewRow In checkoutItems.DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim itemcode As Integer = Convert.ToInt32(row.Cells("Column2").Value)

                    Dim itemname As String = row.Cells("Column3").Value.ToString()

                    Dim itemprice As Integer = Convert.ToInt32(row.Cells("Column4").Value)

                    Dim itemqty As Integer = Convert.ToInt32(row.Cells("Column5").Value)

                    Dim itemsubt As Integer = Convert.ToInt32(row.Cells("Column6").Value)

                    Dim idref As Integer = checkoutItems.orderIdByUser

                    Dim cmd As New MySqlCommand("INSERT INTO `alter_orders` (`order_id`, `item_code`, `item_name`, `item_price`, `item_qty`, `item_subt`, `item_total`, `id`) VALUES (@orderid, @itemcode, @itemname, @itemprice, @itemqty, @itemsubt, @totalbill, @idref)", Form2.conString.getConnection())

                    cmd.Parameters.Add("@orderid", MySqlDbType.Int32).Value = orderid
                    cmd.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode
                    cmd.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname
                    cmd.Parameters.Add("@itemprice", MySqlDbType.Int32).Value = itemprice
                    cmd.Parameters.Add("@itemqty", MySqlDbType.Int32).Value = itemqty
                    cmd.Parameters.Add("@itemsubt", MySqlDbType.Int32).Value = itemsubt
                    cmd.Parameters.Add("@totalbill", MySqlDbType.Int32).Value = totalbill
                    cmd.Parameters.Add("@idref", MySqlDbType.Int32).Value = idref

                    cmd.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Form2.conString.closeConnection()
        End Try


    End Sub

    Public Shared Sub orderIdGenerator(checkoutItems As checkoutItems)

        Try

            Dim Num As Integer = 0

            checkoutItems.con = New MySqlConnection(checkoutItems.cs)

            checkoutItems.con.Open()

            Dim sql As String = ("SELECT MAX(order_id) FROM alter_orders")

            cmd = New MySqlCommand(sql)

            cmd.Connection = checkoutItems.con

            If (IsDBNull(cmd.ExecuteScalar)) Then

                Num = 1001

                checkoutItems.generatedID = Num.ToString

            Else

                Num = cmd.ExecuteScalar + 1

                checkoutItems.generatedID = Num.ToString

            End If

            cmd.Dispose()

            checkoutItems.con.Close()

            checkoutItems.con.Dispose()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class
