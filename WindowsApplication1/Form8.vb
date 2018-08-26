Public Class Form8

    Private Sub Form8_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False

        ''ReadOnly
        TextBox5.ReadOnly = True

        ''add items to listbox
        With ListBox2.Items

            .Add("SMARTPHONE")
            .Add("Samsung galaxy S6")
            .Add("Samsung galaxy S5")
            .Add("Iphone S6")
            .Add("Lenovo K6 power")
            .Add("MOTO E3 POWER")
            .Add("HTC desire 615")
            .Add("NOKIA LUMIA 1020")
            .Add("Redmi note 3")
            
        End With

        ''listview property
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ''add column header
        ListView1.Columns.Add("Item", 150)
        ListView1.Columns.Add("Price", 55)
        ListView1.Columns.Add("Quantity", 50)
        ListView1.Columns.Add("Total", 50)

        ''sort
        ListBox2.Sorted = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            ''check txbox value
            'For Each item As Control In GroupBox1.Controls
            If Item.Text = "0" Then
                MsgBox("enter numeric value", MsgBoxStyle.OkOnly, "")
                Exit Sub
            End If
            ' Next

            ''sort listview
            ListView1.Sorting = SortOrder.Ascending

            'check empty fields
            For Each item As Control In GroupBox1.Controls
                If item.Text = Nothing Then
                    MsgBox("Fill up all fields", MsgBoxStyle.OkOnly, "")
                    Exit Sub
                Else

                End If
            Next

            'Add item to listview
            Dim arr(4) As String
            Dim itm As ListViewItem


            arr(0) = TextBox2.Text
            arr(1) = TextBox3.Text
            arr(2) = TextBox4.Text
            arr(3) = TextBox5.Text

            itm = New ListViewItem(arr)
            ListView1.Items.Add(itm)

            'clear these fields
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

            ''compute total
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In ListView1.Items
                TotalSum += CDbl(TempNode.SubItems.Item(3).Text)
            Next

            TextBox6.Text = TotalSum
            
        Catch ex As Exception

        End Try
       



    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
       
        ''numeric value only
        If Not IsNumeric(TextBox4.Text) Then
            TextBox4.Clear()
        End If
        '' sum
        TextBox5.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''remove selected items
        For Each i As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(i)
        Next



        ''compute total
        Dim TotalSum As Double = 0
        Dim TempNode As ListViewItem
        For Each TempNode In ListView1.Items
            TotalSum += CDbl(TempNode.SubItems.Item(3).Text)
        Next

        TextBox6.Text = TotalSum
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ''numeric value only
        If Not IsNumeric(TextBox3.Text) Then
            TextBox3.Clear()
        End If
        'sum
        TextBox5.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'search item
        Dim count As Integer = (ListBox2.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox2.Items.Item(a)
            If InStr(words.ToLower, TextBox1.Text.ToLower) Then
                ListBox2.SelectedItem = words
            End If
        Next
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "Samsung galaxy S6" Then
            TextBox3.Text = "72000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "Samsung galaxy S5" Then
            TextBox3.Text = "25000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "Iphone S6" Then
            TextBox3.Text = "52000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "Lenovo K6 power" Then
            TextBox3.Text = "9000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "MOTO E3 POWER" Then
            TextBox3.Text = "7999"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "HTC desire 615" Then
            TextBox3.Text = "12000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "NOKIA LUMIA 1020" Then
            TextBox3.Text = "61000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "Redmi note 3" Then
            TextBox3.Text = "12000"
            TextBox3.ReadOnly = True
            TextBox2.ReadOnly = True
        ElseIf TextBox2.Text = "SMARTPHONE" Then
            TextBox2.Text = ""
            TextBox3.Text = "0"
            TextBox3.ReadOnly = False
            TextBox2.ReadOnly = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'copy items
        Dim f9 As New Form9
        For Each itm As ListViewItem In ListView1.Items

            f9.ListView1.Items.Add(itm.Clone())

        Next
        f9.Label2.Text = TextBox6.Text
        f9.Show()


        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'remove items
        For Each i As ListViewItem In ListView1.Items
            ListView1.Items.Remove(i)
        Next

        ''compute total
        Dim TotalSum As Double = 0
        Dim TempNode As ListViewItem
        For Each TempNode In ListView1.Items
            TotalSum += CDbl(TempNode.SubItems.Item(3).Text)
        Next

        TextBox6.Text = TotalSum
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox2.Text = ListBox2.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox5.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
        TextBox6.Text = TextBox5.Text
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

    End Sub
End Class