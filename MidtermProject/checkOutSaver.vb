Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySqlConnector

Public Class checkOutSaver

    Public Shared Sub orderInserter(checkoutItems As checkoutItems)

        For Each row As DataGridViewRow In checkoutItems.DataGridView1.Rows

            If Not row.IsNewRow Then

                Dim itemcode As Integer = Convert.ToInt32(row.Cells("Column2").Value)

                Dim itemname As String = row.Cells("Column3").Value.ToString

                Dim itemprice As Integer = Convert.ToInt32(row.Cells("Column4").Value)

                Dim itemqty As Integer = Convert.ToInt32(row.Cells("Column5").Value)

                Dim itemsubt As Integer = Convert.ToInt32(row.Cells("Column6").Value)

                Dim itemtotal As Integer = Convert.ToInt32(checkoutItems.Label2.Text.Trim() = "text")


                Dim cmd As New MySqlCommand("INSERT INTO `alter_orders` (`item_code`, `item_name`, `item_price`, `item_qty`, `item_subt`, `item_total`) VALUES (@itemcode, @itemname, @itemprice, @itemqty, @itemsubt, @itemtotal)", Form2.conString.getConnection())

                cmd.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode.ToString
                cmd.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname.ToString
                cmd.Parameters.Add("@itemprice", MySqlDbType.Int32).Value = itemprice.ToString
                cmd.Parameters.Add("@itemqty", MySqlDbType.Int32).Value = itemqty.ToString
                cmd.Parameters.Add("@itemsubt", MySqlDbType.Int32).Value = itemsubt.ToString
                cmd.Parameters.Add("@itemtotal", MySqlDbType.Int32).Value = itemtotal.ToString

                Form2.conString.openConnection()

                If cmd.ExecuteNonQuery() = 1 Then



                End If

            End If

        Next

    End Sub

End Class
