Public Class ALL_SELLS
    Private Sub ALL_SELLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DataSet1.Table2)

    End Sub

    Private Sub SEARCHToolStripButton_Click(sender As Object, e As EventArgs) 
        Try
            Me.Table2TableAdapter.SEARCH(Me.DataSet1.Table2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class