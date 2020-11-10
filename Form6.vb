Public Class Form6
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
        TextBox6.Text = OpenFileDialog1.FileName
        Label7.Hide()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If (System.IO.File.Exists(TextBox6.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox6.Text)
        End If
        If TextBox6.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table4' table. You can move, or remove it, as needed.
        Me.Table4TableAdapter.Fill(Me.DataSet1.Table4)
        'TODO: This line of code loads data into the 'DataSet1.Table3' table. You can move, or remove it, as needed.
        Me.Table3TableAdapter.Fill(Me.DataSet1.Table3)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Table4BindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Table4BindingSource.EndEdit()
        Me.Table4TableAdapter.Update(DataSet1.Table4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Table4BindingSource.RemoveCurrent()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Table4BindingSource.MovePrevious()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Table4BindingSource.MoveNext()

    End Sub
End Class