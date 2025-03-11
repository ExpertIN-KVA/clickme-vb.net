Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Text = Button1.Text + 1


        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button2.Text = Button2.Text - 1

        If Button2.Text = 0 Then
            Timer1.Enabled = False
            Button1.Enabled = False
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.Text = 0
        Button2.Text = 5
        Button1.Enabled = True

    End Sub


End Class
