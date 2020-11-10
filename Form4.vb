Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = Val(TextBox4.Text) - Val(TextBox10.Text)
        Me.Table1BindingSource.EndEdit()
        Me.Table1TableAdapter.Update(DataSet1.Table1)


        TextBox12.Text = (TextBox2.Text)
        TextBox11.Text = Val(TextBox3.Text)

        Me.Table2BindingSource.EndEdit()
        Me.Table2TableAdapter.Update(DataSet1.Table2)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Table2BindingSource.AddNew()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DataSet1.Table2)
        'TODO: This line of code loads data into the 'DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSet1.Table1)

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Table1BindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Table1BindingSource.MoveNext()
    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Table2BindingSource.RemoveCurrent()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Table2BindingSource.MovePrevious()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Table2BindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ALL_SELLS.Show()
    End Sub
End Class