<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaffle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRaffle))
        Me.grpWinnersInfo = New System.Windows.Forms.GroupBox
        Me.txt3rdPrize = New System.Windows.Forms.Label
        Me.txt2ndPrize = New System.Windows.Forms.Label
        Me.txtFirstPrize = New System.Windows.Forms.Label
        Me.txt3rdPrizeAmount = New System.Windows.Forms.TextBox
        Me.txt2ndPrizeAmount = New System.Windows.Forms.TextBox
        Me.txtFirstPrizeAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt3rdPrizeTicket = New System.Windows.Forms.TextBox
        Me.txt2ndPrizeTicket = New System.Windows.Forms.TextBox
        Me.txtFirstPrizeTicket = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt3rdPrizeAccount = New System.Windows.Forms.TextBox
        Me.txt2ndPrizeAccount = New System.Windows.Forms.TextBox
        Me.txtFirstPrizeAccount = New System.Windows.Forms.TextBox
        Me.lblThirdAmt = New System.Windows.Forms.Label
        Me.lblSecondAmt = New System.Windows.Forms.Label
        Me.lblFirstAmt = New System.Windows.Forms.Label
        Me.tmrbtnEnter = New System.Windows.Forms.Timer(Me.components)
        Me.lstvwWinners = New System.Windows.Forms.ListView
        Me.colmnAccount = New System.Windows.Forms.ColumnHeader
        Me.colmnPrize = New System.Windows.Forms.ColumnHeader
        Me.colmPrizeAmt = New System.Windows.Forms.ColumnHeader
        Me.colmnTicket = New System.Windows.Forms.ColumnHeader
        Me.colmnAmount = New System.Windows.Forms.ColumnHeader
        Me.colmnName = New System.Windows.Forms.ColumnHeader
        Me.colmnAddress = New System.Windows.Forms.ColumnHeader
        Me.colmnDate = New System.Windows.Forms.ColumnHeader
        Me.txtTotalRecord = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtInputRecord = New System.Windows.Forms.TextBox
        Me.progbar = New System.Windows.Forms.ProgressBar
        Me.cmbxQuarter = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tmrbtnConso = New System.Windows.Forms.Timer(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtBill = New System.Windows.Forms.TextBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnConsolation = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnTextFile = New System.Windows.Forms.Button
        Me.grpRaffleDrawSet = New System.Windows.Forms.GroupBox
        Me.txtConsoPrize = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInputThird = New System.Windows.Forms.TextBox
        Me.txtInputSecond = New System.Windows.Forms.TextBox
        Me.txtInputFirst = New System.Windows.Forms.TextBox
        Me.cmbxYear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.pnWinnersInfo = New System.Windows.Forms.Panel
        Me.lstvwWinnersTemp = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.btnAddEntry = New System.Windows.Forms.Button
        Me.btnDeleteEntry = New System.Windows.Forms.Button
        Me.pnRaffleDrawSet = New System.Windows.Forms.Panel
        Me.lstbxRaffleDrawSet = New System.Windows.Forms.ListBox
        Me.lblRaffleDrawSet = New System.Windows.Forms.Label
        Me.pcbxSlot = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tmrRaffle = New System.Windows.Forms.Timer(Me.components)
        Me.SFDTxtFile = New System.Windows.Forms.SaveFileDialog
        Me.grpWinnersInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpRaffleDrawSet.SuspendLayout()
        Me.pnWinnersInfo.SuspendLayout()
        Me.pnRaffleDrawSet.SuspendLayout()
        CType(Me.pcbxSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpWinnersInfo
        '
        Me.grpWinnersInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpWinnersInfo.Controls.Add(Me.txt3rdPrize)
        Me.grpWinnersInfo.Controls.Add(Me.txt2ndPrize)
        Me.grpWinnersInfo.Controls.Add(Me.txtFirstPrize)
        Me.grpWinnersInfo.Controls.Add(Me.txt3rdPrizeAmount)
        Me.grpWinnersInfo.Controls.Add(Me.txt2ndPrizeAmount)
        Me.grpWinnersInfo.Controls.Add(Me.txtFirstPrizeAmount)
        Me.grpWinnersInfo.Controls.Add(Me.Label10)
        Me.grpWinnersInfo.Controls.Add(Me.Label9)
        Me.grpWinnersInfo.Controls.Add(Me.Label8)
        Me.grpWinnersInfo.Controls.Add(Me.Label14)
        Me.grpWinnersInfo.Controls.Add(Me.txt3rdPrizeTicket)
        Me.grpWinnersInfo.Controls.Add(Me.txt2ndPrizeTicket)
        Me.grpWinnersInfo.Controls.Add(Me.txtFirstPrizeTicket)
        Me.grpWinnersInfo.Controls.Add(Me.Label11)
        Me.grpWinnersInfo.Controls.Add(Me.Label6)
        Me.grpWinnersInfo.Controls.Add(Me.txt3rdPrizeAccount)
        Me.grpWinnersInfo.Controls.Add(Me.txt2ndPrizeAccount)
        Me.grpWinnersInfo.Controls.Add(Me.txtFirstPrizeAccount)
        Me.grpWinnersInfo.Controls.Add(Me.lblThirdAmt)
        Me.grpWinnersInfo.Controls.Add(Me.lblSecondAmt)
        Me.grpWinnersInfo.Controls.Add(Me.lblFirstAmt)
        Me.grpWinnersInfo.Location = New System.Drawing.Point(18, 9)
        Me.grpWinnersInfo.Name = "grpWinnersInfo"
        Me.grpWinnersInfo.Size = New System.Drawing.Size(989, 251)
        Me.grpWinnersInfo.TabIndex = 7
        Me.grpWinnersInfo.TabStop = False
        '
        'txt3rdPrize
        '
        Me.txt3rdPrize.AutoSize = True
        Me.txt3rdPrize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txt3rdPrize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rdPrize.ForeColor = System.Drawing.Color.White
        Me.txt3rdPrize.Location = New System.Drawing.Point(13, 201)
        Me.txt3rdPrize.Name = "txt3rdPrize"
        Me.txt3rdPrize.Size = New System.Drawing.Size(191, 26)
        Me.txt3rdPrize.TabIndex = 34
        Me.txt3rdPrize.Text = "Name of Third Prize"
        '
        'txt2ndPrize
        '
        Me.txt2ndPrize.AutoSize = True
        Me.txt2ndPrize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txt2ndPrize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2ndPrize.ForeColor = System.Drawing.Color.White
        Me.txt2ndPrize.Location = New System.Drawing.Point(13, 120)
        Me.txt2ndPrize.Name = "txt2ndPrize"
        Me.txt2ndPrize.Size = New System.Drawing.Size(208, 26)
        Me.txt2ndPrize.TabIndex = 33
        Me.txt2ndPrize.Text = "Name of Second Prize"
        '
        'txtFirstPrize
        '
        Me.txtFirstPrize.AutoSize = True
        Me.txtFirstPrize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtFirstPrize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstPrize.ForeColor = System.Drawing.Color.White
        Me.txtFirstPrize.Location = New System.Drawing.Point(13, 46)
        Me.txtFirstPrize.Name = "txtFirstPrize"
        Me.txtFirstPrize.Size = New System.Drawing.Size(186, 26)
        Me.txtFirstPrize.TabIndex = 32
        Me.txtFirstPrize.Text = "Name of First Prize"
        '
        'txt3rdPrizeAmount
        '
        Me.txt3rdPrizeAmount.BackColor = System.Drawing.Color.Black
        Me.txt3rdPrizeAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3rdPrizeAmount.Enabled = False
        Me.txt3rdPrizeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rdPrizeAmount.ForeColor = System.Drawing.Color.White
        Me.txt3rdPrizeAmount.Location = New System.Drawing.Point(716, 201)
        Me.txt3rdPrizeAmount.Name = "txt3rdPrizeAmount"
        Me.txt3rdPrizeAmount.Size = New System.Drawing.Size(127, 24)
        Me.txt3rdPrizeAmount.TabIndex = 21
        Me.txt3rdPrizeAmount.Text = "0.00"
        Me.txt3rdPrizeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2ndPrizeAmount
        '
        Me.txt2ndPrizeAmount.BackColor = System.Drawing.Color.Black
        Me.txt2ndPrizeAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2ndPrizeAmount.Enabled = False
        Me.txt2ndPrizeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2ndPrizeAmount.ForeColor = System.Drawing.Color.White
        Me.txt2ndPrizeAmount.Location = New System.Drawing.Point(716, 120)
        Me.txt2ndPrizeAmount.Name = "txt2ndPrizeAmount"
        Me.txt2ndPrizeAmount.Size = New System.Drawing.Size(127, 24)
        Me.txt2ndPrizeAmount.TabIndex = 20
        Me.txt2ndPrizeAmount.Text = "0.00"
        Me.txt2ndPrizeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstPrizeAmount
        '
        Me.txtFirstPrizeAmount.BackColor = System.Drawing.Color.Black
        Me.txtFirstPrizeAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstPrizeAmount.Enabled = False
        Me.txtFirstPrizeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstPrizeAmount.ForeColor = System.Drawing.Color.White
        Me.txtFirstPrizeAmount.Location = New System.Drawing.Point(716, 46)
        Me.txtFirstPrizeAmount.Name = "txtFirstPrizeAmount"
        Me.txtFirstPrizeAmount.Size = New System.Drawing.Size(127, 24)
        Me.txtFirstPrizeAmount.TabIndex = 19
        Me.txtFirstPrizeAmount.Text = "0.00"
        Me.txtFirstPrizeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(675, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 29)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Php"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(675, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 29)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Php"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(675, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Php"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(884, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 29)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Ticket"
        '
        'txt3rdPrizeTicket
        '
        Me.txt3rdPrizeTicket.BackColor = System.Drawing.Color.Black
        Me.txt3rdPrizeTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3rdPrizeTicket.Enabled = False
        Me.txt3rdPrizeTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rdPrizeTicket.ForeColor = System.Drawing.Color.White
        Me.txt3rdPrizeTicket.Location = New System.Drawing.Point(871, 201)
        Me.txt3rdPrizeTicket.Name = "txt3rdPrizeTicket"
        Me.txt3rdPrizeTicket.Size = New System.Drawing.Size(107, 24)
        Me.txt3rdPrizeTicket.TabIndex = 27
        Me.txt3rdPrizeTicket.Text = "0"
        Me.txt3rdPrizeTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2ndPrizeTicket
        '
        Me.txt2ndPrizeTicket.BackColor = System.Drawing.Color.Black
        Me.txt2ndPrizeTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2ndPrizeTicket.Enabled = False
        Me.txt2ndPrizeTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2ndPrizeTicket.ForeColor = System.Drawing.Color.White
        Me.txt2ndPrizeTicket.Location = New System.Drawing.Point(872, 120)
        Me.txt2ndPrizeTicket.Name = "txt2ndPrizeTicket"
        Me.txt2ndPrizeTicket.Size = New System.Drawing.Size(107, 24)
        Me.txt2ndPrizeTicket.TabIndex = 26
        Me.txt2ndPrizeTicket.Text = "0"
        Me.txt2ndPrizeTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstPrizeTicket
        '
        Me.txtFirstPrizeTicket.BackColor = System.Drawing.Color.Black
        Me.txtFirstPrizeTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstPrizeTicket.Enabled = False
        Me.txtFirstPrizeTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstPrizeTicket.ForeColor = System.Drawing.Color.White
        Me.txtFirstPrizeTicket.Location = New System.Drawing.Point(873, 50)
        Me.txtFirstPrizeTicket.Name = "txtFirstPrizeTicket"
        Me.txtFirstPrizeTicket.Size = New System.Drawing.Size(107, 24)
        Me.txtFirstPrizeTicket.TabIndex = 25
        Me.txtFirstPrizeTicket.Text = "0"
        Me.txtFirstPrizeTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(733, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 29)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(553, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Account"
        '
        'txt3rdPrizeAccount
        '
        Me.txt3rdPrizeAccount.BackColor = System.Drawing.Color.Black
        Me.txt3rdPrizeAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3rdPrizeAccount.Enabled = False
        Me.txt3rdPrizeAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rdPrizeAccount.ForeColor = System.Drawing.Color.White
        Me.txt3rdPrizeAccount.Location = New System.Drawing.Point(535, 201)
        Me.txt3rdPrizeAccount.Name = "txt3rdPrizeAccount"
        Me.txt3rdPrizeAccount.Size = New System.Drawing.Size(127, 24)
        Me.txt3rdPrizeAccount.TabIndex = 15
        Me.txt3rdPrizeAccount.Text = "0"
        Me.txt3rdPrizeAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2ndPrizeAccount
        '
        Me.txt2ndPrizeAccount.BackColor = System.Drawing.Color.Black
        Me.txt2ndPrizeAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2ndPrizeAccount.Enabled = False
        Me.txt2ndPrizeAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2ndPrizeAccount.ForeColor = System.Drawing.Color.White
        Me.txt2ndPrizeAccount.Location = New System.Drawing.Point(535, 120)
        Me.txt2ndPrizeAccount.Name = "txt2ndPrizeAccount"
        Me.txt2ndPrizeAccount.Size = New System.Drawing.Size(127, 24)
        Me.txt2ndPrizeAccount.TabIndex = 14
        Me.txt2ndPrizeAccount.Text = "0"
        Me.txt2ndPrizeAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstPrizeAccount
        '
        Me.txtFirstPrizeAccount.BackColor = System.Drawing.Color.Black
        Me.txtFirstPrizeAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstPrizeAccount.Enabled = False
        Me.txtFirstPrizeAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstPrizeAccount.ForeColor = System.Drawing.Color.White
        Me.txtFirstPrizeAccount.Location = New System.Drawing.Point(535, 46)
        Me.txtFirstPrizeAccount.Name = "txtFirstPrizeAccount"
        Me.txtFirstPrizeAccount.Size = New System.Drawing.Size(127, 24)
        Me.txtFirstPrizeAccount.TabIndex = 13
        Me.txtFirstPrizeAccount.Text = "0"
        Me.txtFirstPrizeAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblThirdAmt
        '
        Me.lblThirdAmt.AutoSize = True
        Me.lblThirdAmt.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblThirdAmt.Location = New System.Drawing.Point(9, 169)
        Me.lblThirdAmt.Name = "lblThirdAmt"
        Me.lblThirdAmt.Size = New System.Drawing.Size(162, 26)
        Me.lblThirdAmt.TabIndex = 11
        Me.lblThirdAmt.Text = "3rd Prize Winner"
        '
        'lblSecondAmt
        '
        Me.lblSecondAmt.AutoSize = True
        Me.lblSecondAmt.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSecondAmt.Location = New System.Drawing.Point(10, 88)
        Me.lblSecondAmt.Name = "lblSecondAmt"
        Me.lblSecondAmt.Size = New System.Drawing.Size(157, 26)
        Me.lblSecondAmt.TabIndex = 9
        Me.lblSecondAmt.Text = "2nd PrizeWinner"
        '
        'lblFirstAmt
        '
        Me.lblFirstAmt.AutoSize = True
        Me.lblFirstAmt.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFirstAmt.Location = New System.Drawing.Point(9, 14)
        Me.lblFirstAmt.Name = "lblFirstAmt"
        Me.lblFirstAmt.Size = New System.Drawing.Size(172, 26)
        Me.lblFirstAmt.TabIndex = 7
        Me.lblFirstAmt.Text = "First Prize Winner"
        '
        'tmrbtnEnter
        '
        '
        'lstvwWinners
        '
        Me.lstvwWinners.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstvwWinners.BackColor = System.Drawing.Color.Black
        Me.lstvwWinners.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwWinners.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnAccount, Me.colmnPrize, Me.colmPrizeAmt, Me.colmnTicket, Me.colmnAmount, Me.colmnName, Me.colmnAddress, Me.colmnDate})
        Me.lstvwWinners.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwWinners.ForeColor = System.Drawing.Color.White
        Me.lstvwWinners.FullRowSelect = True
        Me.lstvwWinners.Location = New System.Drawing.Point(18, 276)
        Me.lstvwWinners.MultiSelect = False
        Me.lstvwWinners.Name = "lstvwWinners"
        Me.lstvwWinners.Size = New System.Drawing.Size(989, 234)
        Me.lstvwWinners.TabIndex = 8
        Me.lstvwWinners.UseCompatibleStateImageBehavior = False
        Me.lstvwWinners.View = System.Windows.Forms.View.Details
        '
        'colmnAccount
        '
        Me.colmnAccount.Text = "Account"
        Me.colmnAccount.Width = 82
        '
        'colmnPrize
        '
        Me.colmnPrize.Text = "Prize"
        Me.colmnPrize.Width = 116
        '
        'colmPrizeAmt
        '
        Me.colmPrizeAmt.Text = "Prize Amount"
        Me.colmPrizeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colmPrizeAmt.Width = 100
        '
        'colmnTicket
        '
        Me.colmnTicket.Text = "Ticket"
        Me.colmnTicket.Width = 101
        '
        'colmnAmount
        '
        Me.colmnAmount.Text = "Amount"
        Me.colmnAmount.Width = 110
        '
        'colmnName
        '
        Me.colmnName.Text = "Name"
        Me.colmnName.Width = 268
        '
        'colmnAddress
        '
        Me.colmnAddress.Text = "Address"
        Me.colmnAddress.Width = 234
        '
        'colmnDate
        '
        Me.colmnDate.Text = "Date"
        Me.colmnDate.Width = 298
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.BackColor = System.Drawing.Color.Black
        Me.txtTotalRecord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.ForeColor = System.Drawing.Color.White
        Me.txtTotalRecord.Location = New System.Drawing.Point(144, 539)
        Me.txtTotalRecord.Name = "txtTotalRecord"
        Me.txtTotalRecord.Size = New System.Drawing.Size(102, 30)
        Me.txtTotalRecord.TabIndex = 10
        Me.txtTotalRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 542)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 23)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Total record(s):"
        '
        'txtInputRecord
        '
        Me.txtInputRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInputRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtInputRecord.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputRecord.Location = New System.Drawing.Point(123, 72)
        Me.txtInputRecord.MaxLength = 3
        Me.txtInputRecord.Name = "txtInputRecord"
        Me.txtInputRecord.Size = New System.Drawing.Size(59, 23)
        Me.txtInputRecord.TabIndex = 2
        Me.txtInputRecord.Text = "100"
        Me.txtInputRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'progbar
        '
        Me.progbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progbar.Location = New System.Drawing.Point(18, 266)
        Me.progbar.Maximum = 999999999
        Me.progbar.Name = "progbar"
        Me.progbar.Size = New System.Drawing.Size(989, 13)
        Me.progbar.TabIndex = 13
        '
        'cmbxQuarter
        '
        Me.cmbxQuarter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbxQuarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbxQuarter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxQuarter.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxQuarter.FormattingEnabled = True
        Me.cmbxQuarter.Items.AddRange(New Object() {"First Quarter", "Second Quarter", "Third Quarter", "Fourth Quarter"})
        Me.cmbxQuarter.Location = New System.Drawing.Point(96, 12)
        Me.cmbxQuarter.Name = "cmbxQuarter"
        Me.cmbxQuarter.Size = New System.Drawing.Size(205, 25)
        Me.cmbxQuarter.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Quarter:"
        '
        'tmrbtnConso
        '
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(734, 117)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(31, 20)
        Me.txtName.TabIndex = 31
        Me.txtName.Text = "Name"
        Me.txtName.Visible = False
        '
        'txtBill
        '
        Me.txtBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBill.Location = New System.Drawing.Point(734, 94)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(31, 20)
        Me.txtBill.TabIndex = 30
        Me.txtBill.Text = "Bill"
        Me.txtBill.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Black
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Blue
        Me.btnEnter.Location = New System.Drawing.Point(6, 15)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(135, 37)
        Me.btnEnter.TabIndex = 32
        Me.btnEnter.Text = "First winner!"
        Me.btnEnter.UseVisualStyleBackColor = False
        Me.btnEnter.Visible = False
        '
        'btnConsolation
        '
        Me.btnConsolation.BackColor = System.Drawing.Color.Black
        Me.btnConsolation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsolation.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolation.ForeColor = System.Drawing.Color.Blue
        Me.btnConsolation.Location = New System.Drawing.Point(6, 15)
        Me.btnConsolation.Name = "btnConsolation"
        Me.btnConsolation.Size = New System.Drawing.Size(135, 37)
        Me.btnConsolation.TabIndex = 34
        Me.btnConsolation.Text = "&Consolation !"
        Me.btnConsolation.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(287, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 37)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(352, 111)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 37)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnTextFile)
        Me.GroupBox1.Controls.Add(Me.btnConsolation)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 520)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 61)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(147, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(135, 37)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "&Print preview"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(428, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 37)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnTextFile
        '
        Me.btnTextFile.BackColor = System.Drawing.Color.Black
        Me.btnTextFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTextFile.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextFile.Location = New System.Drawing.Point(6, 15)
        Me.btnTextFile.Name = "btnTextFile"
        Me.btnTextFile.Size = New System.Drawing.Size(135, 37)
        Me.btnTextFile.TabIndex = 38
        Me.btnTextFile.Text = "Save to Text File"
        Me.btnTextFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTextFile.UseVisualStyleBackColor = False
        Me.btnTextFile.Visible = False
        '
        'grpRaffleDrawSet
        '
        Me.grpRaffleDrawSet.BackColor = System.Drawing.Color.Black
        Me.grpRaffleDrawSet.Controls.Add(Me.txtConsoPrize)
        Me.grpRaffleDrawSet.Controls.Add(Me.txtInputRecord)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label17)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label16)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label13)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label12)
        Me.grpRaffleDrawSet.Controls.Add(Me.txtInputThird)
        Me.grpRaffleDrawSet.Controls.Add(Me.txtInputSecond)
        Me.grpRaffleDrawSet.Controls.Add(Me.txtInputFirst)
        Me.grpRaffleDrawSet.Controls.Add(Me.cmbxYear)
        Me.grpRaffleDrawSet.Controls.Add(Me.cmbxQuarter)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label2)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label7)
        Me.grpRaffleDrawSet.Controls.Add(Me.Label1)
        Me.grpRaffleDrawSet.Enabled = False
        Me.grpRaffleDrawSet.Location = New System.Drawing.Point(18, 9)
        Me.grpRaffleDrawSet.Name = "grpRaffleDrawSet"
        Me.grpRaffleDrawSet.Size = New System.Drawing.Size(314, 142)
        Me.grpRaffleDrawSet.TabIndex = 37
        Me.grpRaffleDrawSet.TabStop = False
        '
        'txtConsoPrize
        '
        Me.txtConsoPrize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConsoPrize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtConsoPrize.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsoPrize.Location = New System.Drawing.Point(253, 73)
        Me.txtConsoPrize.MaxLength = 3
        Me.txtConsoPrize.Name = "txtConsoPrize"
        Me.txtConsoPrize.Size = New System.Drawing.Size(48, 23)
        Me.txtConsoPrize.TabIndex = 3
        Me.txtConsoPrize.Text = "100"
        Me.txtConsoPrize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(181, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Consolation:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(204, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Third Prize:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(108, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Second Prize:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "First Prize:"
        '
        'txtInputThird
        '
        Me.txtInputThird.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInputThird.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtInputThird.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputThird.Location = New System.Drawing.Point(208, 114)
        Me.txtInputThird.MaxLength = 7
        Me.txtInputThird.Name = "txtInputThird"
        Me.txtInputThird.Size = New System.Drawing.Size(93, 23)
        Me.txtInputThird.TabIndex = 6
        Me.txtInputThird.Text = "0"
        Me.txtInputThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInputSecond
        '
        Me.txtInputSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInputSecond.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtInputSecond.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputSecond.Location = New System.Drawing.Point(111, 114)
        Me.txtInputSecond.MaxLength = 7
        Me.txtInputSecond.Name = "txtInputSecond"
        Me.txtInputSecond.Size = New System.Drawing.Size(93, 23)
        Me.txtInputSecond.TabIndex = 5
        Me.txtInputSecond.Text = "0"
        Me.txtInputSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInputFirst
        '
        Me.txtInputFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInputFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtInputFirst.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputFirst.Location = New System.Drawing.Point(13, 114)
        Me.txtInputFirst.MaxLength = 7
        Me.txtInputFirst.Name = "txtInputFirst"
        Me.txtInputFirst.Size = New System.Drawing.Size(93, 23)
        Me.txtInputFirst.TabIndex = 4
        Me.txtInputFirst.Text = "0"
        Me.txtInputFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbxYear
        '
        Me.cmbxYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbxYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbxYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxYear.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxYear.FormattingEnabled = True
        Me.cmbxYear.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "3000"})
        Me.cmbxYear.Location = New System.Drawing.Point(68, 42)
        Me.cmbxYear.Name = "cmbxYear"
        Me.cmbxYear.Size = New System.Drawing.Size(233, 25)
        Me.cmbxYear.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "No of Consolation:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Year:"
        '
        'pnWinnersInfo
        '
        Me.pnWinnersInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnWinnersInfo.Controls.Add(Me.lstvwWinnersTemp)
        Me.pnWinnersInfo.Controls.Add(Me.txtTotalRecord)
        Me.pnWinnersInfo.Controls.Add(Me.Label15)
        Me.pnWinnersInfo.Controls.Add(Me.GroupBox1)
        Me.pnWinnersInfo.Controls.Add(Me.grpWinnersInfo)
        Me.pnWinnersInfo.Controls.Add(Me.progbar)
        Me.pnWinnersInfo.Controls.Add(Me.lstvwWinners)
        Me.pnWinnersInfo.Enabled = False
        Me.pnWinnersInfo.Location = New System.Drawing.Point(12, 154)
        Me.pnWinnersInfo.Name = "pnWinnersInfo"
        Me.pnWinnersInfo.Size = New System.Drawing.Size(1020, 582)
        Me.pnWinnersInfo.TabIndex = 38
        Me.pnWinnersInfo.Visible = False
        '
        'lstvwWinnersTemp
        '
        Me.lstvwWinnersTemp.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstvwWinnersTemp.BackColor = System.Drawing.Color.Black
        Me.lstvwWinnersTemp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstvwWinnersTemp.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwWinnersTemp.ForeColor = System.Drawing.Color.White
        Me.lstvwWinnersTemp.FullRowSelect = True
        Me.lstvwWinnersTemp.Location = New System.Drawing.Point(132, 367)
        Me.lstvwWinnersTemp.MultiSelect = False
        Me.lstvwWinnersTemp.Name = "lstvwWinnersTemp"
        Me.lstvwWinnersTemp.Size = New System.Drawing.Size(333, 88)
        Me.lstvwWinnersTemp.TabIndex = 39
        Me.lstvwWinnersTemp.UseCompatibleStateImageBehavior = False
        Me.lstvwWinnersTemp.View = System.Windows.Forms.View.Details
        Me.lstvwWinnersTemp.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Prize"
        Me.ColumnHeader2.Width = 116
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prize Amount"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ticket"
        Me.ColumnHeader4.Width = 101
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 268
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Address"
        Me.ColumnHeader7.Width = 234
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date"
        Me.ColumnHeader8.Width = 298
        '
        'btnAddEntry
        '
        Me.btnAddEntry.BackColor = System.Drawing.Color.Black
        Me.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEntry.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.ForeColor = System.Drawing.Color.White
        Me.btnAddEntry.Location = New System.Drawing.Point(352, 22)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(135, 37)
        Me.btnAddEntry.TabIndex = 39
        Me.btnAddEntry.Text = "&Add Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'btnDeleteEntry
        '
        Me.btnDeleteEntry.BackColor = System.Drawing.Color.Black
        Me.btnDeleteEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteEntry.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEntry.ForeColor = System.Drawing.Color.White
        Me.btnDeleteEntry.Location = New System.Drawing.Point(352, 65)
        Me.btnDeleteEntry.Name = "btnDeleteEntry"
        Me.btnDeleteEntry.Size = New System.Drawing.Size(135, 37)
        Me.btnDeleteEntry.TabIndex = 40
        Me.btnDeleteEntry.Text = "&Delete Entry"
        Me.btnDeleteEntry.UseVisualStyleBackColor = False
        '
        'pnRaffleDrawSet
        '
        Me.pnRaffleDrawSet.BackColor = System.Drawing.Color.Transparent
        Me.pnRaffleDrawSet.Controls.Add(Me.btnClose)
        Me.pnRaffleDrawSet.Controls.Add(Me.btnDeleteEntry)
        Me.pnRaffleDrawSet.Controls.Add(Me.btnAddEntry)
        Me.pnRaffleDrawSet.Controls.Add(Me.lstbxRaffleDrawSet)
        Me.pnRaffleDrawSet.Controls.Add(Me.grpRaffleDrawSet)
        Me.pnRaffleDrawSet.Location = New System.Drawing.Point(15, 0)
        Me.pnRaffleDrawSet.Name = "pnRaffleDrawSet"
        Me.pnRaffleDrawSet.Size = New System.Drawing.Size(498, 174)
        Me.pnRaffleDrawSet.TabIndex = 42
        '
        'lstbxRaffleDrawSet
        '
        Me.lstbxRaffleDrawSet.BackColor = System.Drawing.Color.Black
        Me.lstbxRaffleDrawSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstbxRaffleDrawSet.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxRaffleDrawSet.ForeColor = System.Drawing.Color.White
        Me.lstbxRaffleDrawSet.FormattingEnabled = True
        Me.lstbxRaffleDrawSet.ItemHeight = 23
        Me.lstbxRaffleDrawSet.Location = New System.Drawing.Point(18, 9)
        Me.lstbxRaffleDrawSet.Name = "lstbxRaffleDrawSet"
        Me.lstbxRaffleDrawSet.Size = New System.Drawing.Size(314, 142)
        Me.lstbxRaffleDrawSet.TabIndex = 42
        '
        'lblRaffleDrawSet
        '
        Me.lblRaffleDrawSet.AutoSize = True
        Me.lblRaffleDrawSet.BackColor = System.Drawing.Color.Transparent
        Me.lblRaffleDrawSet.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaffleDrawSet.ForeColor = System.Drawing.Color.Blue
        Me.lblRaffleDrawSet.Location = New System.Drawing.Point(18, 77)
        Me.lblRaffleDrawSet.Name = "lblRaffleDrawSet"
        Me.lblRaffleDrawSet.Size = New System.Drawing.Size(371, 67)
        Me.lblRaffleDrawSet.TabIndex = 29
        Me.lblRaffleDrawSet.Text = "RaffleDrawSet"
        Me.lblRaffleDrawSet.Visible = False
        '
        'pcbxSlot
        '
        Me.pcbxSlot.ErrorImage = CType(resources.GetObject("pcbxSlot.ErrorImage"), System.Drawing.Image)
        Me.pcbxSlot.Image = CType(resources.GetObject("pcbxSlot.Image"), System.Drawing.Image)
        Me.pcbxSlot.Location = New System.Drawing.Point(524, 32)
        Me.pcbxSlot.Name = "pcbxSlot"
        Me.pcbxSlot.Size = New System.Drawing.Size(87, 82)
        Me.pcbxSlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbxSlot.TabIndex = 43
        Me.pcbxSlot.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(920, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'tmrRaffle
        '
        '
        'frmRaffle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 738)
        Me.Controls.Add(Me.pcbxSlot)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.pnWinnersInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRaffleDrawSet)
        Me.Controls.Add(Me.pnRaffleDrawSet)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "frmRaffle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpWinnersInfo.ResumeLayout(False)
        Me.grpWinnersInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.grpRaffleDrawSet.ResumeLayout(False)
        Me.grpRaffleDrawSet.PerformLayout()
        Me.pnWinnersInfo.ResumeLayout(False)
        Me.pnWinnersInfo.PerformLayout()
        Me.pnRaffleDrawSet.ResumeLayout(False)
        CType(Me.pcbxSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpWinnersInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblThirdAmt As System.Windows.Forms.Label
    Friend WithEvents lblSecondAmt As System.Windows.Forms.Label
    Friend WithEvents lblFirstAmt As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt3rdPrizeAccount As System.Windows.Forms.TextBox
    Friend WithEvents txt2ndPrizeAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstPrizeAccount As System.Windows.Forms.TextBox
    Friend WithEvents tmrbtnEnter As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt3rdPrizeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt2ndPrizeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstPrizeAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt3rdPrizeTicket As System.Windows.Forms.TextBox
    Friend WithEvents txt2ndPrizeTicket As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstPrizeTicket As System.Windows.Forms.TextBox
    Friend WithEvents lstvwWinners As System.Windows.Forms.ListView
    Friend WithEvents colmnPrize As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnTicket As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnAccount As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInputRecord As System.Windows.Forms.TextBox
    Friend WithEvents progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents cmbxQuarter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colmnAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrbtnConso As System.Windows.Forms.Timer
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtBill As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnConsolation As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpRaffleDrawSet As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnWinnersInfo As System.Windows.Forms.Panel
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEntry As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnRaffleDrawSet As System.Windows.Forms.Panel
    Friend WithEvents lstbxRaffleDrawSet As System.Windows.Forms.ListBox
    Friend WithEvents lblRaffleDrawSet As System.Windows.Forms.Label
    Friend WithEvents pcbxSlot As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRaffle As System.Windows.Forms.Timer
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnTextFile As System.Windows.Forms.Button
    Friend WithEvents txtInputThird As System.Windows.Forms.TextBox
    Friend WithEvents txtInputSecond As System.Windows.Forms.TextBox
    Friend WithEvents txtInputFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtConsoPrize As System.Windows.Forms.TextBox
    Friend WithEvents colmPrizeAmt As System.Windows.Forms.ColumnHeader
    Friend WithEvents SFDTxtFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lstvwWinnersTemp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtFirstPrize As System.Windows.Forms.Label
    Friend WithEvents txt3rdPrize As System.Windows.Forms.Label
    Friend WithEvents txt2ndPrize As System.Windows.Forms.Label

End Class
