Public Class Options

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.Text = "On" Then
            Label1.Text = "Off"
            Options2.Label1.Text = "Off"
            My.Settings.Music = "Off"
            My.Settings.Save()
            My.Computer.Audio.Stop()
        Else
            Label1.Text = "On"
            Options2.Label1.Text = "On"
            My.Settings.Music = "On"
            My.Settings.Save()
            My.Computer.Audio.Play(My.Resources.background,
          AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        welcome.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        welcome.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox3.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox2.Visible = True
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class