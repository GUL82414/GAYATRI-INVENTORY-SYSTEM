Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table3' table. You can move, or remove it, as needed.
        Me.Table3TableAdapter.Fill(Me.DataSet1.Table3)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Table3BindingSource.EndEdit()
        Me.Table3TableAdapter.Update(DataSet1.Table3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Table3BindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Table3BindingSource.RemoveCurrent()

    End Sub
End Class