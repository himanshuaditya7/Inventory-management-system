Imports System.Data.OleDb
Public Class Form3
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into userlogin ([Username], [Password]) values (?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))
       
       
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
           

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Successfully Registered")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class