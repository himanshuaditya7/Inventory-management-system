Imports System.Data.OleDb
Public Class Form7
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [Productdetail] set [Brand] = '" & BrandTextBox.Text & "' , [Model] = '" & ModelTextBox.Text & "', [Quantity] = '" & QuantityTextBox.Text & "', [Price] = '" & PriceTextBox.Text & "', [Colour] = '" & ColourTextBox.Text & "' Where [Product_id] = '" & Product_idTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class