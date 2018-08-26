Imports System.Data.OleDb
Public Class Form10
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into Customerdetail ([Customer_id], [First_name], [Last_name], [City], [Address], [Phone_no], [Purchased_item], [Seller]) values (?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Customer_id", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("First_name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Last_name", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("City", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone_no", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Purchased_item", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Seller", CType(TextBox9.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox9.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("added")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
            dataFile = "D:\inventorydatabase1.mdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "Delete from Customerdetail Where Customer_id = '" & TextBox1.Text & "'"
            str = "Delete from Customerdetail Where First_name = '" & TextBox2.Text & "'"
            str = "Delete from Customerdetail Where Last_name = '" & TextBox3.Text & "'"
            str = "Delete from Customerdetail Where City = '" & TextBox4.Text & "'"
            str = "Delete from Customerdetail Where Address = '" & TextBox5.Text & "'"
            str = "Delete from Customerdetail Where Phone_no = '" & TextBox6.Text & "'"
            str = "Delete from Customerdetail Where Purchased_item = '" & TextBox7.Text & "'"
            str = "Delete from Customerdetail Where Seller = '" & TextBox9.Text & "'"


            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If
    End Sub

   
End Class