Public Class Escape
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Gameplay.Close()

        My.Settings.Save()
        welcome.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseHover
        PictureBox1.Visible = True
        PictureBox11.Visible = False
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox11.Visible = True
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox12_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseHover
        PictureBox2.Visible = True
        PictureBox12.Visible = False
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox12.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        PictureBox7.Visible = True
        PictureBox4.Visible = False
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox4.Visible = True
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox12_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Gameplay.Hide()
        welcome.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Options2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Options2.Show()
        Me.Hide()
    End Sub

    Private Sub Escape_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class