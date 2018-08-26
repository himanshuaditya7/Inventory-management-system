Imports System.Data.OleDb
Public Class Form4
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.Oledb.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "D:\inventorydatabase1.mdb"
        connString = provider & dataFile

        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into Productdetail ([Product_id], [Brand], [Model], [Quantity], [Price], [Colour]) values (?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Product_id", CType(Product_idTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Brand", CType(BrandTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Model", CType(ModelTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(QuantityTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Price", CType(PriceTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Colour", CType(ColourTextBox.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            Product_idTextBox.Clear()
            BrandTextBox.Clear()
            ModelTextBox.Clear()
            QuantityTextBox.Clear()
            PriceTextBox.Clear()
            ColourTextBox.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("added")
    End Sub
End Class