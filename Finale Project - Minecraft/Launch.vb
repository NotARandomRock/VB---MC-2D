Public Class Launch

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Length <= 2 Then
            MsgBox("Your name must be more than 2 Characters")
        Else
            If TextBox1.Text.Length >= 10 Then
                MsgBox("Your name must be less than 9 Characters")
            Else
                My.Settings.Username1 = TextBox1.Text
                mcusername = My.Settings.Username1
                welcome.Show()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub Gameplay_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            My.Settings.Username1 = TextBox1.Text
            mcusername = My.Settings.Username1
            welcome.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Launch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Console.WriteLine("-=- [Minecraft 2D] -=-
-=- Developed by Shon - Idan -=-
-=- Based on the game Minecraft Java Edition -=-
-=- Education SUNSPARK -=-")
        If My.Settings.AlexSkin = "Purchase" Then
            welcome.PictureBox9.Hide()
            welcome.CheckBox1.Text = "Selected"
            welcome.CheckBox1.Checked = True
            welcome.CheckBox2.Hide()
        Else
            If My.Settings.AlexSkin = "Purchased" Then
                welcome.PictureBox9.Show()
                welcome.CheckBox2.Show()
            End If
        End If
        If My.Settings.ShonSkin = "Purchase" Then
            welcome.PictureBox10.Hide()
            welcome.CheckBox1.Text = "Selected"
            welcome.CheckBox1.Checked = True
            welcome.CheckBox3.Hide()
        Else
            If My.Settings.ShonSkin = "Purchased" Then
                welcome.PictureBox10.Show()
                welcome.CheckBox3.Show()
            End If
        End If
    End Sub
End Class