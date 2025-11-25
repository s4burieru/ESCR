Public Class Form3

    Private Sub TblitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
    End Sub

    Private Sub QtyTextBox_TextChanged(sender As Object, e As EventArgs) Handles QtyTextBox.TextChanged
        If ItemnameComboBox.Text = "Apple" Then
            PriceTextBox.Text = Val(QtyTextBox.Text) * 25
        ElseIf ItemnameComboBox.Text = "Banana" Then
            PriceTextBox.Text = Val(QtyTextBox.Text) * 15
        ElseIf ItemnameComboBox.Text = "Mango" Then
            PriceTextBox.Text = Val(QtyTextBox.Text) * 30
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class