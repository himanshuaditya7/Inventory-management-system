Imports System.Data.OleDb
Public Class Form2
    Dim cnn As OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim dtrdr As OleDb.OleDbDataReader
    Dim sql, u, p As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select Username,Password from userlogin WHERE Username= '" & Me.TextBox1.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        cnn.Open()
        dtrdr = cmd.ExecuteReader
        While dtrdr.Read = True
            u = dtrdr(0)
            p = dtrdr(1)
        End While
        cnn.Close()

        If TextBox1.Text = u Then
            If TextBox1.Text = u And TextBox2.Text = p Then
                MsgBox("WELCOME")
                Form8.Show()
                Me.Hide()
            ElseIf TextBox1.Text = u And TextBox2.Text = "" Then
                MsgBox("Enter password")
            ElseIf TextBox1.Text = u And Not TextBox2.Text = p Then
                MsgBox("invalid password")
            End If
        Else
            MsgBox("invalid username")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=D:\inventorydatabase1.mdb"
    End Sub
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into signupadmin ([Username], [Password]) values (?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Usename", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox2.Text, String)))
       

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            
            TextBox3.Clear()
            TextBox4.Clear()


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        MsgBox("Login successfull")
        
        Form6.Show()
        Me.Hide()
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form13.Show()
    End Sub
End Class