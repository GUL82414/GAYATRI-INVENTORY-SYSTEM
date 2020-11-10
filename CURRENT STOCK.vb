Public Class CURRENT_STOCK
    Private Sub CURRENT_STOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSet1.Table1)

    End Sub

    Private Sub PRODUCT_IDToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table1TableAdapter.PRODUCT_ID(Me.DataSet1.Table1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub
    Private Sub notFound()


    End Sub

    Private Sub PRODUCT_NAMEToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table1TableAdapter.PRODUCT_NAME(Me.DataSet1.Table1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SEARCHToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table1TableAdapter.SEARCH(Me.DataSet1.Table1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class