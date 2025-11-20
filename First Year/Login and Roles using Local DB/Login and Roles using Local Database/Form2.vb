Public Class Form2

    Private Sub TblusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblusers' table. You can move, or remove it, as needed.
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet.tblusers)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblusersBindingSource.AddNew()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TblusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Me.TblusersTableAdapter.Fill(Me.Database1DataSet.tblusers)
    End Sub
End Class