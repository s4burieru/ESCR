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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblitemsBindingSource.AddNew()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TblitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Do you want to delete this data?", vbYesNo) = vbYes Then
            TblitemsBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblitemsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
            Me.TblitemsTableAdapter.Fill(Me.Database1DataSet.tblitems)
        End If
    End Sub
End Class