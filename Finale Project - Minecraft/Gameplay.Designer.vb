<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gameplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gameplay))
        Me.Jump = New System.Windows.Forms.Timer(Me.components)
        Me.Fall = New System.Windows.Forms.Timer(Me.components)
        Me.BorderTouch = New System.Windows.Forms.Timer(Me.components)
        Me.OresRandom = New System.Windows.Forms.Timer(Me.components)
        Me.OresSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BorderTouch2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Spawn1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Border4 = New System.Windows.Forms.PictureBox()
        Me.Border2 = New System.Windows.Forms.PictureBox()
        Me.Border3 = New System.Windows.Forms.PictureBox()
        Me.Border1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Border5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.NoPass = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spawn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jump
        '
        '
        'Fall
        '
        '
        'BorderTouch
        '
        Me.BorderTouch.Enabled = True
        '
        'OresRandom
        '
        Me.OresRandom.Enabled = True
        Me.OresRandom.Interval = 20000
        '
        'OresSpawn
        '
        Me.OresSpawn.Enabled = True
        Me.OresSpawn.Interval = 20000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "42b32a65901b1e58137dba59640b5781.png")
        Me.ImageList1.Images.SetKeyName(1, "s189772745713394276_p3855_i147_w750.jpeg")
        Me.ImageList1.Images.SetKeyName(2, "120px-Gold_oreTex.png")
        Me.ImageList1.Images.SetKeyName(3, "s189772745713394276_p3851_i145_w750.jpeg")
        Me.ImageList1.Images.SetKeyName(4, "minecraft-iron-texture_126504.jpg")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(714, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Steve"
        '
        'BorderTouch2
        '
        Me.BorderTouch2.Enabled = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.Blank_Sign
        Me.Label7.Location = New System.Drawing.Point(21, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 31)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Shop"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.Finale_Project___Minecraft.My.Resources.Resources._11b52ea12b329819d532f1e8d068c8bc
        Me.PictureBox12.Location = New System.Drawing.Point(13, 386)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(102, 104)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 23
        Me.PictureBox12.TabStop = False
        '
        'Spawn1
        '
        Me.Spawn1.BackColor = System.Drawing.Color.Transparent
        Me.Spawn1.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.diamondore
        Me.Spawn1.Location = New System.Drawing.Point(568, 413)
        Me.Spawn1.Name = "Spawn1"
        Me.Spawn1.Size = New System.Drawing.Size(81, 77)
        Me.Spawn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Spawn1.TabIndex = 18
        Me.Spawn1.TabStop = False
        Me.Spawn1.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox10.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.floor
        Me.PictureBox10.Location = New System.Drawing.Point(-386, 488)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(2348, 667)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 13
        Me.PictureBox10.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.gogo
        Me.Label5.Location = New System.Drawing.Point(218, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 33)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.gogo
        Me.Label4.Location = New System.Drawing.Point(164, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 33)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.gogo
        Me.Label3.Location = New System.Drawing.Point(114, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.gogo
        Me.Label2.Location = New System.Drawing.Point(65, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.gogo
        Me.Label1.Location = New System.Drawing.Point(13, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Gray
        Me.PictureBox5.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.ironingot_icon32
        Me.PictureBox5.Location = New System.Drawing.Point(9, 203)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Gray
        Me.PictureBox9.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.Emerald
        Me.PictureBox9.Location = New System.Drawing.Point(208, 203)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 7
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Gray
        Me.PictureBox8.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.Gold_Ingot
        Me.PictureBox8.Location = New System.Drawing.Point(160, 203)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Gray
        Me.PictureBox7.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.Diamond
        Me.PictureBox7.Location = New System.Drawing.Point(113, 203)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gray
        Me.PictureBox6.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.coal_icon32
        Me.PictureBox6.Location = New System.Drawing.Point(56, 203)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.sunback1
        Me.PictureBox4.Location = New System.Drawing.Point(1261, -28)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(259, 258)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.inv
        Me.PictureBox3.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(466, 262)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Border4
        '
        Me.Border4.BackColor = System.Drawing.Color.Transparent
        Me.Border4.Location = New System.Drawing.Point(1881, 28)
        Me.Border4.Name = "Border4"
        Me.Border4.Size = New System.Drawing.Size(10, 579)
        Me.Border4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Border4.TabIndex = 17
        Me.Border4.TabStop = False
        Me.Border4.Visible = False
        '
        'Border2
        '
        Me.Border2.BackColor = System.Drawing.Color.Transparent
        Me.Border2.Location = New System.Drawing.Point(1876, 28)
        Me.Border2.Name = "Border2"
        Me.Border2.Size = New System.Drawing.Size(15, 579)
        Me.Border2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Border2.TabIndex = 15
        Me.Border2.TabStop = False
        '
        'Border3
        '
        Me.Border3.BackColor = System.Drawing.Color.Transparent
        Me.Border3.Location = New System.Drawing.Point(-7, -1)
        Me.Border3.Name = "Border3"
        Me.Border3.Size = New System.Drawing.Size(14, 579)
        Me.Border3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Border3.TabIndex = 16
        Me.Border3.TabStop = False
        Me.Border3.Visible = False
        '
        'Border1
        '
        Me.Border1.BackColor = System.Drawing.Color.Transparent
        Me.Border1.Location = New System.Drawing.Point(-17, -1)
        Me.Border1.Name = "Border1"
        Me.Border1.Size = New System.Drawing.Size(32, 579)
        Me.Border1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Border1.TabIndex = 14
        Me.Border1.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.download
        Me.PictureBox11.Location = New System.Drawing.Point(568, -122)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(77, 120)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 20
        Me.PictureBox11.TabStop = False
        '
        'Border5
        '
        Me.Border5.BackColor = System.Drawing.Color.Transparent
        Me.Border5.Location = New System.Drawing.Point(1881, 60)
        Me.Border5.Name = "Border5"
        Me.Border5.Size = New System.Drawing.Size(10, 579)
        Me.Border5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Border5.TabIndex = 22
        Me.Border5.TabStop = False
        Me.Border5.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Finale_Project___Minecraft.My.Resources.Resources.jumpstand
        Me.PictureBox1.Location = New System.Drawing.Point(707, 339)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Location = New System.Drawing.Point(-7, 12)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(1946, 267)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'NoPass
        '
        Me.NoPass.Enabled = True
        '
        'Gameplay
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1884, 1032)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Spawn1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Border4)
        Me.Controls.Add(Me.Border2)
        Me.Controls.Add(Me.Border3)
        Me.Controls.Add(Me.Border1)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Border5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gameplay"
        Me.Text = "Minecraft - Build-0.4"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spawn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Jump As Timer
    Friend WithEvents Fall As Timer
    Friend WithEvents BorderTouch As Timer
    Friend WithEvents Border1 As PictureBox
    Friend WithEvents Border2 As PictureBox
    Friend WithEvents Border3 As PictureBox
    Friend WithEvents Border4 As PictureBox
    Friend WithEvents OresRandom As Timer
    Friend WithEvents Spawn1 As PictureBox
    Friend WithEvents OresSpawn As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Border5 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BorderTouch2 As Timer
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents NoPass As Timer
End Class
