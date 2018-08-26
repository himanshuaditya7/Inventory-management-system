Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventorydatabase1DataSet1.Customerdetail' table. You can move, or remove it, as needed.
        Me.CustomerdetailTableAdapter.Fill(Me.Inventorydatabase1DataSet1.Customerdetail)

    End Sub
End Class