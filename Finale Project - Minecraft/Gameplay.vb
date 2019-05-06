Public Class Gameplay

    Dim RandomSpawn As New Random()
    Dim X As Integer
    Dim intPic As Integer
    Dim metaadd As Integer = 0
    Dim addnum As Integer
    Private Sub Gameplay_KeyE(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.E Then
            PictureBox3.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
        ElseIf PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            PictureBox9.Visible = False
        End If
    End Sub

    Private Sub Gameplay_MouseClick(ByVal sender As Object, e As EventArgs) Handles Me.MouseClick
        If welcome.CheckBox1.Text = "Selected" Then
            PictureBox1.Image = My.Resources.minesteve
            PictureBox1.Size = New Size(77, 151)
        Else
            If welcome.CheckBox2.Text = "Selected" Then
                PictureBox1.Image = My.Resources.minealex
                PictureBox1.Size = New Size(77, 151)
            Else
                If welcome.CheckBox3.Text = "Selected" Then
                    PictureBox1.Image = My.Resources.shonpic
                    PictureBox1.Size = New Size(77, 151)
                End If
            End If
        End If
    End Sub

    Private Sub Gameplay_Keyadd(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Divide Then
            My.Settings.Diamond += 23
            My.Settings.Emerald += 15
            My.Settings.Iron += 45
            My.Settings.Gold += 18
        End If
    End Sub

    Private Sub Gameplay_KeyEscape(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Escape.Show()
            'My.Settings.Diamond += 23'
            'My.Settings.Emerald += 15 '
            'My.Settings.Iron += 45 '
            'My.Settings.Gold += 18 '
        Else
            If e.KeyCode = Keys.Escape And Escape.Visible = True Then
                Escape.Visible = False
            End If
        End If
    End Sub

    Private Sub Gameplay_KeyLeft(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Left And welcome.CheckBox1.Checked = True Then
            PictureBox1.Size = New Size(48, 151)
            PictureBox1.Image = My.Resources.movepose1
            Label6.Left -= 35
            PictureBox1.Left -= 35
        Else
            If e.KeyCode = Keys.Left And welcome.CheckBox2.Checked = True Then
                PictureBox1.Size = New Size(48, 151)
                PictureBox1.Image = My.Resources.alexmove51
                Label6.Left -= 35
                PictureBox1.Left -= 35
            Else
                If e.KeyCode = Keys.Left And welcome.CheckBox3.Checked = True Then
                    PictureBox1.Size = New Size(48, 151)
                    PictureBox1.Image = My.Resources.shonmove1
                    Label6.Left -= 35
                    PictureBox1.Left -= 35
                End If
            End If
        End If
    End Sub

    Private Sub Gameplay_KeyJump(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space And welcome.CheckBox1.Checked = True Then

            PictureBox1.Size = New Size(77, 151)
            PictureBox1.Image = My.Resources.jumpstand
            Jump.Start()
        Else
            If e.KeyCode = Keys.Space And welcome.CheckBox2.Checked = True Then
                PictureBox1.Size = New Size(77, 151)
                PictureBox1.Image = My.Resources.download1
                Jump.Start()
            Else
                If e.KeyCode = Keys.Space And welcome.CheckBox3.Checked = True Then
                    PictureBox1.Size = New Size(77, 151)
                    PictureBox1.Image = My.Resources.shonstand
                    Jump.Start()
                End If
            End If
        End If
    End Sub

    Private Sub Gameplay_KeyRight(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Right And welcome.CheckBox1.Checked = True Then
            Label6.Left += 35
            PictureBox1.Size = New Size(48, 151)
            PictureBox1.Image = My.Resources.movepose2
            PictureBox1.Left += 35
        Else
            If e.KeyCode = Keys.Right And welcome.CheckBox2.Checked = True Then
                Label6.Left += 35
                PictureBox1.Size = New Size(48, 151)
                PictureBox1.Image = My.Resources.alexmove
                PictureBox1.Left += 35
            Else
                If e.KeyCode = Keys.Right And welcome.CheckBox3.Checked = True Then
                    Label6.Left += 35
                    PictureBox1.Size = New Size(48, 151)
                    PictureBox1.Image = My.Resources.shonmove
                    PictureBox1.Left += 35
                End If
            End If
        End If
    End Sub

    Private Sub Gameplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If welcome.CheckBox1.Text = "Selected" Then
            PictureBox1.Image = My.Resources.jumpstand
        Else
            If welcome.CheckBox2.Text = "Selected" Then
                PictureBox1.Image = My.Resources.download1
            Else
                If welcome.CheckBox3.Text = "Selected" Then
                    PictureBox1.Image = My.Resources.shonstand

                End If
            End If
        End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        BorderTouch.Start()
        BorderTouch2.Start()
        PictureBox10.Size = New Size(2348, 715)
        Label7.Visible = False
        Border1.Visible = True
        Border2.Visible = True
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        Label6.Text = mcusername
        Label1.Text = My.Settings.Iron
        Label2.Text = My.Settings.Coal
        Label3.Text = My.Settings.Diamond
        Label4.Text = My.Settings.Gold
        Label5.Text = My.Settings.Emerald
        PictureBox3.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Border3.Visible = False
        Border4.Visible = False
    End Sub

    Private Sub Jump_Tick(sender As Object, e As EventArgs) Handles Jump.Tick
        PictureBox1.Top -= 40
        Label6.Top -= 40
        Jump.Stop()
        Fall.Start()

    End Sub

    Private Sub Fall_Tick(sender As Object, e As EventArgs) Handles Fall.Tick
        PictureBox1.Top += 20
        Label6.Top += 20
        If PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            Fall.Stop()

        End If
    End Sub

    Private Sub Border_Tick(sender As Object, e As EventArgs) Handles BorderTouch.Tick
        If PictureBox1.Bounds.IntersectsWith(Border1.Bounds) Then
            PictureBox1.Location = New Point(1795, 339)
            Label6.Location = New Point(1805, 316)
            Border1.Visible = False
            Border2.Visible = False
            PictureBox10.Image = My.Resources.floor
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            Label7.Visible = True
            PictureBox10.Size = New Size(2348, 715)
            PictureBox11.Size = New Size(77, 151)
            PictureBox11.Location = New Point(121, 339)
            Border3.Visible = False
            Border5.Visible = True
            Border4.Visible = False
            BorderTouch2.Stop()
        ElseIf PictureBox1.Bounds.IntersectsWith(picturebox11.Bounds) Then
            PictureBox1.Location = New Point(204, 339)
            Label6.Location = New Point(214, 316)
            Shop.Show()
        ElseIf PictureBox1.Bounds.IntersectsWith(Border5.Bounds) Then
            PictureBox1.Location = New Point(13, 339)
            Label6.Location = New Point(23, 316)
            Border1.Visible = True
                Border2.Visible = True
                PictureBox10.Image = My.Resources.floor
                PictureBox11.Visible = False
            PictureBox12.Visible = False
            Label7.Visible = False
                PictureBox10.Size = New Size(2348, 715)
                Border3.Visible = False
                Border4.Visible = False
                Border5.Visible = False
                BorderTouch2.Start()
            BorderTouch.Stop()
        End If
    End Sub

    Private Sub Border3_Click(sender As Object, e As EventArgs) Handles Border3.Click

    End Sub

    Private Sub OresRandom_Tick(sender As Object, e As EventArgs) Handles OresRandom.Tick

        Dim Rnd As New Random

        intPic = Rnd.Next(0, ImageList1.Images.Count)
        Spawn1.Image = ImageList1.Images(intPic)
    End Sub

    Private Sub OresSpawn_Tick(sender As Object, e As EventArgs) Handles OresSpawn.Tick

        For floorpos = 208 To 1365
            X = RandomSpawn.Next(1365)
            Spawn1.Visible = True
            Spawn1.Location = New Point(X, 413)
        Next floorpos
    End Sub

    Private Sub Spawn1_Click(sender As Object, e As EventArgs) Handles Spawn1.Click


        If PictureBox1.Bounds.IntersectsWith(Spawn1.Bounds) Then
            If welcome.CheckBox1.Text = "Selected" Then
                PictureBox1.Image = My.Resources.minesteve
                PictureBox1.Size = New Size(77, 151)
            Else
                If welcome.CheckBox2.Text = "Selected" Then
                    PictureBox1.Image = My.Resources.minealex
                    PictureBox1.Size = New Size(77, 151)
                Else
                    If welcome.CheckBox3.Text = "Selected" Then
                        PictureBox1.Image = My.Resources.shonpic
                        PictureBox1.Size = New Size(77, 151)
                    End If
                End If
            End If
            Spawn1.Visible = False
            If intPic = 1 Then
                My.Settings.Diamond += 1
                Label3.Text = My.Settings.Diamond
                My.Settings.Save()
            ElseIf intPic = 0 Then
                My.Settings.Emerald += 1
                Label5.Text = My.Settings.Emerald
                My.Settings.Save()
            ElseIf intPic = 2 Then
                My.Settings.Gold += 1
                    Label4.Text = My.Settings.Gold
                    My.Settings.Save()
                    ElseIf intPic = 3 Then
                    My.Settings.Coal += 1
                    Label2.Text = My.Settings.Coal
                    My.Settings.Save()
                    ElseIf intPic = 4 Then
                    My.Settings.Iron += 1
                    Label1.Text = My.Settings.Iron
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Border4_Click(sender As Object, e As EventArgs) Handles Border4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If PictureBox1.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            Shop.Show()
        End If
    End Sub

    Private Sub BorderTouch2_Tick(sender As Object, e As EventArgs) Handles BorderTouch2.Tick
        If PictureBox1.Bounds.IntersectsWith(Border2.Bounds) Then
            PictureBox1.Location = New Point(13, 339)
            Label6.Location = New Point(23, 316)
            Border1.Visible = False
            Border2.Visible = False
            PictureBox10.Image = My.Resources.sandfloor
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            Label7.Visible = False
            PictureBox10.Size = New Size(2348, 715)
            Border3.Visible = True
            Border4.Visible = True
            BorderTouch.Stop()
        ElseIf PictureBox1.Bounds.IntersectsWith(Border4.Bounds) Then
            PictureBox1.Location = New Point(1795, 339)
            Label6.Location = New Point(1805, 316)
        ElseIf PictureBox1.Bounds.IntersectsWith(Border3.Bounds) Then
            PictureBox1.Location = New Point(1795, 339)
            Label6.Location = New Point(1805, 316)
            PictureBox10.Image = My.Resources.floor
            PictureBox10.Size = New Size(2348, 715)
            Border3.Visible = False
            Border4.Visible = False
            Border1.Visible = True
            Border2.Visible = True
            BorderTouch.Start()
            BorderTouch2.Stop()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub NoPass_Tick(sender As Object, e As EventArgs) Handles NoPass.Tick
        If PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            PictureBox1.Top += 35
            Label6.Top += 35
        End If
    End Sub

    Private Sub PictureBox13_Click_1(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

End Class