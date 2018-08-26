Imports System.Data.OleDb
Public Class Form13
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into signupadmin ([Username], [Password], [Emailid], [Phoneno]) values (?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Usename", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Emailid", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phoneno", CType(TextBox4.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        MsgBox("Admin Register")
    End Sub
End Class