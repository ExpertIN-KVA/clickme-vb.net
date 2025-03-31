Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles countBtn.Click

        countBtn.Text = countBtn.Text + 1


        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            ResetToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timerLbl.Text = timerLbl.Text - 1

        If timerLbl.Text = 0 Then
            Timer1.Enabled = False
            countBtn.Enabled = False
            ResetToolStripMenuItem.Enabled = True
        End If


    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        countBtn.Text = 0
        timerLbl.Text = 5
        countBtn.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

End Class
