Public Class welcome

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MsgBox("You must choose a skin to play with.", MsgBoxStyle.Information)
        Else
            Gameplay.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MsgBox("You must choose a skin to play with.", MsgBoxStyle.Information)
        Else
            Gameplay.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Options.Show()
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox5.Visible = True
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox1.Visible = True
        PictureBox5.Visible = False
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        PictureBox7.Visible = True
        PictureBox4.Visible = False
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox4.Visible = True
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox11_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseHover
        PictureBox12.Visible = True
        PictureBox11.Visible = False
    End Sub

    Private Sub PictureBox12_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseLeave
        PictureBox11.Visible = True
        PictureBox12.Visible = False
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox6.Visible = True
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox3.Visible = True
        PictureBox6.Visible = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Options.Show()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Label2.Text = mcusername
        Shop.Button1.Text = My.Settings.ShonSkin
        Shop.Button2.Text = My.Settings.AlexSkin
        If My.Settings.AlexSkin = "Purchase" Then
            PictureBox9.Hide()
            CheckBox2.Hide()
        Else
            If My.Settings.AlexSkin = "Purchased" Then
                PictureBox9.Show()
                CheckBox2.Show()
            End If
        End If

        If My.Settings.ShonSkin = "Purchase" Then
            PictureBox10.Hide()
            CheckBox3.Hide()
        Else
            If My.Settings.ShonSkin = "Purchased" Then
                PictureBox10.Show()
                CheckBox3.Show()
            End If
        End If

        If My.Settings.Music = "On" Then
            My.Computer.Audio.Play(My.Resources.background,
          AudioPlayMode.BackgroundLoop)
            Options.Label1.Text = "On"
            Options2.Label1.Text = "On"
        Else
            If My.Settings.Music = "Off" Then
                My.Computer.Audio.Stop()
                Options.Label1.Text = "Off"
                Options2.Label1.Text = "Off"
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Gameplay.Hide()
        Launch.Hide()
        Escape.Hide()
        Options.Hide()
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Gameplay.Hide()
        Launch.Hide()
        Escape.Hide()
        Options.Hide()

        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.Text = "Selected"
        CheckBox3.Checked = False
        CheckBox2.Checked = False
        CheckBox2.Text = "Select"
        CheckBox3.Text = "Select"
        If CheckBox1.Checked = False Then
            CheckBox1.Text = "Select"
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim delete As MsgBoxResult = MsgBox("This button will delete you data (It will erase your skins, materials, nametags) Are you sure you want to delete?", MsgBoxStyle.YesNo, "Erase Data?")

        If delete = MsgBoxResult.Yes Then
            PictureBox9.Hide()
            CheckBox2.Hide()
            PictureBox10.Hide()
            CheckBox3.Hide()
            CheckBox1.Text = "Select"
            My.Settings.Music = "On"
            Options.Label1.Text = "On"
            Options2.Label1.Text = "On"
            My.Computer.Audio.Play(My.Resources.background,
          AudioPlayMode.BackgroundLoop)
            My.Settings.Diamond = 0
            My.Settings.Emerald = 0
            My.Settings.Gold = 0
            My.Settings.Iron = 0
            My.Settings.Coal = 0
            Gameplay.Close()
            My.Settings.AlexSkin = "Purchase"
            My.Settings.ShonSkin = "Purchase"
            MsgBox("Game data has been erased.")
            My.Settings.Save()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim delete As MsgBoxResult = MsgBox("This button will delete you data (It will erase your skins, materials, nametags) Are you sure you want to delete?", MsgBoxStyle.YesNo, "Erase Data?")

        If delete = MsgBoxResult.Yes Then
            My.Settings.AlexSkin = "Purchase"
            My.Settings.ShonSkin = "Purchase"
            PictureBox9.Hide()
            CheckBox2.Hide()
            PictureBox10.Hide()
            CheckBox3.Hide()
            My.Settings.Diamond = 0
            CheckBox1.Checked = True
            CheckBox1.Text = "Selected"
            My.Settings.Emerald = 0
            My.Settings.Gold = 0
            My.Settings.Iron = 0
            My.Settings.Coal = 0
            Gameplay.Close()
            MsgBox("Game data has been erased.")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        CheckBox2.Text = "Selected"
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox1.Text = "Select"
        CheckBox3.Text = "Select"
        If CheckBox2.Checked = False Then
            CheckBox2.Text = "Select"
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox2.Text = "Select"
        CheckBox3.Text = "Selected"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Text = "Select"
        If CheckBox3.Checked = False Then
            CheckBox3.Text = "Select"
        End If
    End Sub
End Class
