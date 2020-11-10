Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("USER ID AND PASSWORD IS REQUERD")
        End If
        If TextBox1.Text = "GULSHAN" And TextBox2.Text = "GULSHAN98" Then


            Form1.Show()
            Me.Hide()


        End If
        If TextBox1.Text = "ADMIN" And TextBox2.Text = "QWERTY" Then
            Form1.Show()
            Me.Hide()
        End If

        If TextBox1.Text = "MUNNA" And TextBox2.Text = "12345" Then
            Form1.Show()
            Me.Hide()
        End If

        If TextBox1.Text = "ADMIN" And TextBox2.Text = "12345" Then
            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Button2.BackColor = Color.Red
    End Sub
End Class