Public Class Form1

    Private Sub TblitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Clear()
        If ComboBox1.Text = "All" Then
            Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        Else
            Me.TblitemsTableAdapter.FilterData(Me.Database1DataSet.tblitems, ComboBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ComboBox1.Text = "All"
        Me.TblitemsTableAdapter.Search(Me.Database1DataSet.tblitems, "%" + TextBox1.Text + "%")
    End Sub
End Class
