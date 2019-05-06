Public Class Shop
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.AlexSkin = "Purchased" Then
            Button2.ForeColor = Color.Red
        End If
        If My.Settings.ShonSkin = "Purchased" Then
            Button1.ForeColor = Color.Red
        End If
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Button2.Text = My.Settings.AlexSkin
        Button1.Text = My.Settings.ShonSkin
        Label1.Text = My.Settings.Iron
        Label2.Text = My.Settings.Coal
        Label3.Text = My.Settings.Diamond
        Label4.Text = My.Settings.Gold
        Label5.Text = My.Settings.Emerald
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Gameplay.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Gameplay.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Visible = False
        PictureBox3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.Diamond < 11 And My.Settings.Iron < 24 And My.Settings.Emerald < 8 And My.Settings.Coal < 15 Then
            MsgBox("You don't have enough materials to buy this skin.", MsgBoxStyle.Information, "Purchase Failed")
        Else
            If My.Settings.Diamond > 11 And My.Settings.Iron > 24 And My.Settings.Iron > 8 And My.Settings.Coal < 15 Then
                MsgBox("You have successfully purchased the skin ALEX", MsgBoxStyle.Information, "Purchase Complete")
                My.Settings.AlexSkin = "Purchased"
                Button2.Text = "Purchased"

                welcome.CheckBox1.Checked = False
                welcome.CheckBox1.Text = "Select"
                welcome.CheckBox3.Checked = False
                welcome.CheckBox3.Text = "Select"

                My.Settings.Diamond -= 11
                My.Settings.Emerald -= 8
                My.Settings.Iron -= 24
                My.Settings.Coal -= 15
                Button2.ForeColor = Color.Red
                welcome.PictureBox9.Show()
                welcome.CheckBox2.Show()
                My.Settings.Save()
            Else
                If My.Settings.AlexSkin = "Purchased" And Button2.Text = "Purchased" Then
                    MsgBox("You have already purchased this skin.", MsgBoxStyle.Information, "Purchase Error")
                End If
            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.Diamond < 23 And My.Settings.Iron < 45 And My.Settings.Emerald < 15 And My.Settings.Gold < 18 Then
            MsgBox("You don't have enough materials to buy this skin.", MsgBoxStyle.Information, "Purchase Failed")
        Else
            If My.Settings.Diamond > 23 And My.Settings.Iron > 45 And My.Settings.Emerald > 15 And My.Settings.Gold > 18 Then
                MsgBox("You have successfully purchased the skin SHON", MsgBoxStyle.Information, "Purchase Complete")
                My.Settings.ShonSkin = "Purchased"
                Button1.Text = "Purchased"
                welcome.CheckBox2.Checked = False
                welcome.CheckBox2.Text = "Select"
                welcome.CheckBox1.Checked = False
                welcome.CheckBox1.Text = "Select"

                My.Settings.Diamond -= 23
                My.Settings.Emerald -= 15
                My.Settings.Iron -= 45
                My.Settings.Gold -= 18
                Button1.ForeColor = Color.Red
                welcome.PictureBox10.Show()
                welcome.CheckBox3.Show()
                My.Settings.Save()
            Else
                If My.Settings.ShonSkin = "Purchased" And Button1.Text = "Purchased" Then
                    MsgBox("You have already purchased this skin.", MsgBoxStyle.Information, "Purchase Error")
                End If
            End If
        End If
    End Sub
End Class