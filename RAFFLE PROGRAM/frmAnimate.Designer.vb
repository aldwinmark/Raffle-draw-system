<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimate))
        Me.pic2 = New System.Windows.Forms.PictureBox
        Me.pic3 = New System.Windows.Forms.PictureBox
        Me.pic4 = New System.Windows.Forms.PictureBox
        Me.pic5 = New System.Windows.Forms.PictureBox
        Me.pic6 = New System.Windows.Forms.PictureBox
        Me.pgBar1 = New System.Windows.Forms.ProgressBar
        Me.pgBar2 = New System.Windows.Forms.ProgressBar
        Me.pgBar3 = New System.Windows.Forms.ProgressBar
        Me.pgBar4 = New System.Windows.Forms.ProgressBar
        Me.pgBar5 = New System.Windows.Forms.ProgressBar
        Me.pgBar6 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr5 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr6 = New System.Windows.Forms.Timer(Me.components)
        Me.txtRandomNumber = New System.Windows.Forms.TextBox
        Me.tmrDone = New System.Windows.Forms.Timer(Me.components)
        Me.lblCongrats = New System.Windows.Forms.Label
        Me.tmrCongrat = New System.Windows.Forms.Timer(Me.components)
        Me.pgBar7 = New System.Windows.Forms.ProgressBar
        Me.pgBar8 = New System.Windows.Forms.ProgressBar
        Me.pgBar9 = New System.Windows.Forms.ProgressBar
        Me.pgBar10 = New System.Windows.Forms.ProgressBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.pic7 = New System.Windows.Forms.PictureBox
        Me.pic8 = New System.Windows.Forms.PictureBox
        Me.pic9 = New System.Windows.Forms.PictureBox
        Me.pic10 = New System.Windows.Forms.PictureBox
        Me.tmr7 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr8 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr9 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr10 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic2
        '
        Me.pic2.ErrorImage = CType(resources.GetObject("pic2.ErrorImage"), System.Drawing.Image)
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(120, 150)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(43, 52)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 45
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.ErrorImage = CType(resources.GetObject("pic3.ErrorImage"), System.Drawing.Image)
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(188, 150)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(43, 52)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 46
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.ErrorImage = CType(resources.GetObject("pic4.ErrorImage"), System.Drawing.Image)
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(257, 150)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(43, 52)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 47
        Me.pic4.TabStop = False
        '
        'pic5
        '
        Me.pic5.ErrorImage = CType(resources.GetObject("pic5.ErrorImage"), System.Drawing.Image)
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(324, 150)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(43, 52)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 48
        Me.pic5.TabStop = False
        '
        'pic6
        '
        Me.pic6.ErrorImage = CType(resources.GetObject("pic6.ErrorImage"), System.Drawing.Image)
        Me.pic6.Image = CType(resources.GetObject("pic6.Image"), System.Drawing.Image)
        Me.pic6.Location = New System.Drawing.Point(394, 150)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(43, 52)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 49
        Me.pic6.TabStop = False
        '
        'pgBar1
        '
        Me.pgBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar1.Location = New System.Drawing.Point(35, 117)
        Me.pgBar1.Name = "pgBar1"
        Me.pgBar1.Size = New System.Drawing.Size(67, 10)
        Me.pgBar1.TabIndex = 51
        '
        'pgBar2
        '
        Me.pgBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar2.Location = New System.Drawing.Point(101, 117)
        Me.pgBar2.Name = "pgBar2"
        Me.pgBar2.Size = New System.Drawing.Size(71, 10)
        Me.pgBar2.TabIndex = 52
        '
        'pgBar3
        '
        Me.pgBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar3.Location = New System.Drawing.Point(172, 117)
        Me.pgBar3.Name = "pgBar3"
        Me.pgBar3.Size = New System.Drawing.Size(70, 10)
        Me.pgBar3.TabIndex = 53
        '
        'pgBar4
        '
        Me.pgBar4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar4.Location = New System.Drawing.Point(242, 117)
        Me.pgBar4.Name = "pgBar4"
        Me.pgBar4.Size = New System.Drawing.Size(70, 10)
        Me.pgBar4.TabIndex = 54
        '
        'pgBar5
        '
        Me.pgBar5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar5.Location = New System.Drawing.Point(312, 117)
        Me.pgBar5.Name = "pgBar5"
        Me.pgBar5.Size = New System.Drawing.Size(67, 10)
        Me.pgBar5.TabIndex = 55
        '
        'pgBar6
        '
        Me.pgBar6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar6.Location = New System.Drawing.Point(379, 117)
        Me.pgBar6.Name = "pgBar6"
        Me.pgBar6.Size = New System.Drawing.Size(69, 10)
        Me.pgBar6.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 55)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(117, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 55)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(184, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 55)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(252, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 55)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(319, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 55)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(389, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 55)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "0"
        '
        'tmr1
        '
        Me.tmr1.Interval = 10
        '
        'tmr2
        '
        Me.tmr2.Interval = 10
        '
        'tmr3
        '
        Me.tmr3.Interval = 10
        '
        'tmr4
        '
        Me.tmr4.Interval = 10
        '
        'tmr5
        '
        Me.tmr5.Interval = 10
        '
        'tmr6
        '
        Me.tmr6.Interval = 10
        '
        'txtRandomNumber
        '
        Me.txtRandomNumber.Location = New System.Drawing.Point(312, 23)
        Me.txtRandomNumber.Name = "txtRandomNumber"
        Me.txtRandomNumber.Size = New System.Drawing.Size(94, 20)
        Me.txtRandomNumber.TabIndex = 63
        Me.txtRandomNumber.Text = "123456"
        Me.txtRandomNumber.Visible = False
        '
        'tmrDone
        '
        Me.tmrDone.Interval = 5000
        '
        'lblCongrats
        '
        Me.lblCongrats.AutoSize = True
        Me.lblCongrats.BackColor = System.Drawing.Color.Transparent
        Me.lblCongrats.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongrats.ForeColor = System.Drawing.Color.Blue
        Me.lblCongrats.Location = New System.Drawing.Point(200, 33)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(364, 67)
        Me.lblCongrats.TabIndex = 64
        Me.lblCongrats.Text = "Congratulation!"
        Me.lblCongrats.Visible = False
        '
        'tmrCongrat
        '
        '
        'pgBar7
        '
        Me.pgBar7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar7.Location = New System.Drawing.Point(448, 117)
        Me.pgBar7.Name = "pgBar7"
        Me.pgBar7.Size = New System.Drawing.Size(70, 10)
        Me.pgBar7.TabIndex = 65
        '
        'pgBar8
        '
        Me.pgBar8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar8.Location = New System.Drawing.Point(518, 117)
        Me.pgBar8.Name = "pgBar8"
        Me.pgBar8.Size = New System.Drawing.Size(69, 10)
        Me.pgBar8.TabIndex = 66
        '
        'pgBar9
        '
        Me.pgBar9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar9.Location = New System.Drawing.Point(587, 117)
        Me.pgBar9.Name = "pgBar9"
        Me.pgBar9.Size = New System.Drawing.Size(69, 10)
        Me.pgBar9.TabIndex = 67
        '
        'pgBar10
        '
        Me.pgBar10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgBar10.Location = New System.Drawing.Point(656, 117)
        Me.pgBar10.Name = "pgBar10"
        Me.pgBar10.Size = New System.Drawing.Size(69, 10)
        Me.pgBar10.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(457, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 55)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(526, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 55)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(595, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 55)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(665, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 55)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "0"
        '
        'pic7
        '
        Me.pic7.ErrorImage = CType(resources.GetObject("pic7.ErrorImage"), System.Drawing.Image)
        Me.pic7.Image = CType(resources.GetObject("pic7.Image"), System.Drawing.Image)
        Me.pic7.Location = New System.Drawing.Point(465, 150)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(43, 52)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 73
        Me.pic7.TabStop = False
        '
        'pic8
        '
        Me.pic8.ErrorImage = CType(resources.GetObject("pic8.ErrorImage"), System.Drawing.Image)
        Me.pic8.Image = CType(resources.GetObject("pic8.Image"), System.Drawing.Image)
        Me.pic8.Location = New System.Drawing.Point(531, 150)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(43, 52)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8.TabIndex = 74
        Me.pic8.TabStop = False
        '
        'pic9
        '
        Me.pic9.ErrorImage = CType(resources.GetObject("pic9.ErrorImage"), System.Drawing.Image)
        Me.pic9.Image = CType(resources.GetObject("pic9.Image"), System.Drawing.Image)
        Me.pic9.Location = New System.Drawing.Point(602, 150)
        Me.pic9.Name = "pic9"
        Me.pic9.Size = New System.Drawing.Size(43, 52)
        Me.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic9.TabIndex = 75
        Me.pic9.TabStop = False
        '
        'pic10
        '
        Me.pic10.ErrorImage = CType(resources.GetObject("pic10.ErrorImage"), System.Drawing.Image)
        Me.pic10.Image = CType(resources.GetObject("pic10.Image"), System.Drawing.Image)
        Me.pic10.Location = New System.Drawing.Point(671, 150)
        Me.pic10.Name = "pic10"
        Me.pic10.Size = New System.Drawing.Size(43, 52)
        Me.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic10.TabIndex = 76
        Me.pic10.TabStop = False
        '
        'tmr7
        '
        Me.tmr7.Interval = 10
        '
        'tmr8
        '
        Me.tmr8.Interval = 10
        '
        'tmr9
        '
        Me.tmr9.Interval = 10
        '
        'tmr10
        '
        Me.tmr10.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(570, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'frmAnimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(754, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic10)
        Me.Controls.Add(Me.pic9)
        Me.Controls.Add(Me.pic8)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pgBar10)
        Me.Controls.Add(Me.pgBar9)
        Me.Controls.Add(Me.pgBar8)
        Me.Controls.Add(Me.pgBar7)
        Me.Controls.Add(Me.txtRandomNumber)
        Me.Controls.Add(Me.pgBar6)
        Me.Controls.Add(Me.pgBar5)
        Me.Controls.Add(Me.pgBar4)
        Me.Controls.Add(Me.pgBar3)
        Me.Controls.Add(Me.pgBar2)
        Me.Controls.Add(Me.pgBar1)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCongrats)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnimate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents pic6 As System.Windows.Forms.PictureBox
    Friend WithEvents pgBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar6 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents tmr3 As System.Windows.Forms.Timer
    Friend WithEvents tmr4 As System.Windows.Forms.Timer
    Friend WithEvents tmr5 As System.Windows.Forms.Timer
    Friend WithEvents tmr6 As System.Windows.Forms.Timer
    Friend WithEvents txtRandomNumber As System.Windows.Forms.TextBox
    Friend WithEvents tmrDone As System.Windows.Forms.Timer
    Friend WithEvents lblCongrats As System.Windows.Forms.Label
    Friend WithEvents tmrCongrat As System.Windows.Forms.Timer
    Friend WithEvents pgBar7 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar8 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar9 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgBar10 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pic7 As System.Windows.Forms.PictureBox
    Friend WithEvents pic8 As System.Windows.Forms.PictureBox
    Friend WithEvents pic9 As System.Windows.Forms.PictureBox
    Friend WithEvents pic10 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr7 As System.Windows.Forms.Timer
    Friend WithEvents tmr8 As System.Windows.Forms.Timer
    Friend WithEvents tmr9 As System.Windows.Forms.Timer
    Friend WithEvents tmr10 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
