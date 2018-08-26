Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''set date
        Label1.Text = Date.Now

        ''Set view property
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ''add column header
        ListView1.Columns.Add("Item", 200)
        ListView1.Columns.Add("Price", 70)
        ListView1.Columns.Add("Quantity", 70)
        ListView1.Columns.Add("Total", 80)

        '
        MaximizeBox = False

        TopMost = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ''printing

        If MsgBox("Do you want to print?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            LinkLabel1.Visible = False

            TopMost = False
            
        Else

            Me.Close()
        End If
    End Sub
End Class