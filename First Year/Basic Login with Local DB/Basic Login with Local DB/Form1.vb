Public Class Form1

    Private Sub TblaccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblaccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblaccounts' table. You can move, or remove it, as needed.
        Me.TblaccountsTableAdapter.Fill(Me.Database1DataSet.tblaccounts)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblaccountsTableAdapter.FillBy(Me.Database1DataSet.tblaccounts, TextBox1.Text, TextBox2.Text)
        If TblaccountsBindingSource.Count = 1 Then
            Form2.show()
            Me.Close()
        Else
            MsgBox("Wrong username or password")

        End If

    End Sub
End Class
