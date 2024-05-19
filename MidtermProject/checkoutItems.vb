Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector
Public Class checkoutItems

    Dim connection As New MySqlConnection("server=localhost;port=;user id=root;password=;database=alterdb")

    Dim dt As New DataSet

    'Draggable form propertys
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Function subconnection(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then

            connection.Open()

        End If

        Try

            If cmd.ExecuteNonQuery() = 1 Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox("An error has occured", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Return False

        End Try

        If connection.State = ConnectionState.Open Then

            connection.Close()

        End If

    End Function

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub
    Private Sub checkoutItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated

        mainForm.Enabled = True

        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        Dim total As Decimal = 0


        For Each row As DataGridViewRow In DataGridView1.Rows

            If Not row.Cells("Column6").Value Is Nothing AndAlso IsNumeric(row.Cells("Column6").Value) Then

                total += Convert.ToDecimal(row.Cells("Column6").Value)

            End If

        Next

        Label2.Text = "Total Cost : ₱ " & total

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim response As String

        response = MsgBox("Proceed to buy?", MsgBoxStyle.Question + vbYesNo, "Purchase")

        If response = vbYes Then

            Dim connectionString As String = "server=localhost;port=;user id=root;password=;database=alterdb"

            Dim connection As MySqlConnection = New MySqlConnection(connectionString)

            Dim sql As String = "UPDATE products SET prd_stock = prd_stock - @quantity WHERE prd_code = @id"

            Dim cmd As MySqlCommand = New MySqlCommand(sql, connection)

            cmd.Parameters.AddWithValue("@id", MySqlDbType.Int32)

            cmd.Parameters.AddWithValue("@quantity", MySqlDbType.Int32)

            Try
                connection.Open()

                For Each row In DataGridView1.Rows

                    Dim productId As Integer = CInt(row.Cells("Column2").Value)

                    Dim quantityToDeduct As Integer = CInt(row.Cells("Column5").Value)


                    cmd.Parameters("@id").Value = productId

                    cmd.Parameters("@quantity").Value = quantityToDeduct

                    cmd.ExecuteNonQuery()


                Next

                checkOutSaver.orderInserter(Me)

                loadPurchase.ShowDialog()

            Catch ex As Exception

                MsgBox(ex, " Error")

            Finally

                connection.Close()

            End Try



        Else

            ' ...

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim response As String

        response = MsgBox("Do you want to return to merchant?", MsgBoxStyle.Question + vbYesNo)

        If response = vbYes Then

            mainForm.storePanel.BringToFront()

            mainForm.btnStore.BackColor = Color.FromArgb(67, 61, 63)

            mainForm.btnHome.BackColor = Color.FromArgb(30, 28, 26)

            mainForm.btnAbout.BackColor = Color.FromArgb(30, 28, 26)

            Me.Close()

        End If

    End Sub
End Class