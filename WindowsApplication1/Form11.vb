Public Class Form11

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventorydatabase1DataSet.Productdetail' table. You can move, or remove it, as needed.
        Me.ProductdetailTableAdapter.Fill(Me.Inventorydatabase1DataSet.Productdetail)

    End Sub
End Class