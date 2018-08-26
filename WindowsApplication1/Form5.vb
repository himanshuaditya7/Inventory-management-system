Imports System.Data.OleDb
Public Class Form5
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
            dataFile = "D:\inventorydatabase1.mdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "Delete from Productdetail Where Product_id = '" & Product_idTextBox.Text & "'"
            str = "Delete from Productdetail Where Brand = '" & BrandTextBox.Text & "'"
            str = "Delete from Productdetail Where Model = '" & ModelTextBox.Text & "'"
            str = "Delete from Productdetail Where Quantity = '" & QuantityTextBox.Text & "'"
            str = "Delete from Productdetail Where Price = '" & PriceTextBox.Text & "'"
            str = "Delete from Productdetail Where Colour = '" & ColourTextBox.Text & "'"
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