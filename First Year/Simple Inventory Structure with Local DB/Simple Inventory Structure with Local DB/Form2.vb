Public Class Form2

    Private Sub TblitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblitems' table. You can move, or remove it, as needed.
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        Label3.Text = TblitemsBindingSource.Count

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblitemsBindingSource.RemoveCurrent()
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        Label3.Text = TblitemsBindingSource.Count
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.TblitemsTableAdapter.Search(Me.Database1DataSet.tblitems, TextBox1.Text + "%")
        Label3.Text = TblitemsBindingSource.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Form3.TblitemsBindingSource.AddNew()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Form4.tblitemsTableAdapter.Search(Form4.Database1DataSet.tblitems, TextBox1.Text + "%")
        Form4.ReportViewer1.RefreshReport()
    End Sub
End Class