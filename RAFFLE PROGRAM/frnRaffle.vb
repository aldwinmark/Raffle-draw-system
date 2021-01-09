Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO


Public Class frmRaffle

    Private Sub frmRaffle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.tmrRaffle.Enabled = True
        'FillListViewdbf("SELECT * FROM bcraf ")
        FillRaffleDrawSet("SELECT * FROM tblRaffle ")
        Norecord()

    End Sub

    Private Sub LoadLv()
        FillListViewsql("SELECT * FROM tblWinners WHERE Quarter='" & Me.lblRaffleDrawSet.Text & "'  AND Prize='" & "Consolation" & "'")
        FillListTemp("SELECT * FROM tblWinners WHERE Quarter='" & Me.lblRaffleDrawSet.Text & "'ORDER BY Seq Asc")
    End Sub

    Public Function FillListTemp(ByVal SqlString As String)

        Me.lstvwWinnersTemp.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(SqlString, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        Sqlda.Fill(ds)

        iCountRecord = Format(ds.Tables(0).Rows.Count, "###0")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1

                Dim MyItem = Me.lstvwWinnersTemp.Items.Add(dr("Account"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Prize".ToString))
                    .SubItems.Add(dr("PrizeAmt".ToString))
                    .SubItems.Add(dr("Ticket".ToString))
                    .SubItems.Add(dr("Amount".ToString))
                    .SubItems.Add(dr("Name".ToString))
                    .SubItems.Add(dr("Address".ToString))
                    .SubItems.Add(dr("ORDate".ToString))
                End With
            Next
        End If
        Return SqlString
        cn.Close()

    End Function

    Private Sub FillRaffleDrawSet(ByVal SqlString As String)

        Me.lstbxRaffleDrawSet.Items.Clear()
        '
        CheckConnection(cn)
        '
        da.SelectCommand = New SqlCommand(SqlString, cn)
        cmbldr = New SqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        iCountRecord = Format(ds.Tables(0).Rows.Count, "###0")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Me.lstbxRaffleDrawSet.Items.Add(dr("ID"))
            Next
        End If
        cn.Close()
    End Sub

    Public Function FillListViewdbf(ByVal SqlString As String)

        'dbf connection
        dbfcn = New OleDb.OleDbConnection("Provider=vfpoledb;" & _
                    "Data Source=" & Application.StartupPath & "\bcraf.dbf;")
        dbfcn.Open()

        Me.lstvwWinners.Items.Clear()
        ds.Clear()

        oleDbda.SelectCommand = New OleDbCommand(SqlString, dbfcn)
        oleDbcmbldr = New OleDbCommandBuilder(oleDbda)

        oleDbda.Fill(ds)
        iCountRecord = Format(ds.Tables(0).Rows.Count, "###0")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1
                Dim MyItem = Me.lstvwWinners.Items.Add(dr("Prize"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Ticket".ToString))
                    .SubItems.Add(dr("Account".ToString))
                    .SubItems.Add(dr("Amount".ToString))
                    .SubItems.Add(dr("Name".ToString))
                    .SubItems.Add(dr("Address".ToString))
                    .SubItems.Add(dr("Date".ToString))
                End With
            Next
        End If
        Me.txtTotalRecord.Text = iCountRecord
        Return SqlString
        dbfcn.Close()

    End Function

    Public Function FillListViewsql(ByVal SqlString As String)

        Me.lstvwWinners.Items.Clear()
        ds.Clear()

        Sqlda.SelectCommand = New SqlCommand(SqlString, cn)
        Sqlcmbldr = New SqlCommandBuilder(Sqlda)

        Sqlda.Fill(ds)

        iCountRecord = Format(ds.Tables(0).Rows.Count, "###0")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                iCurrentRecord = Me.BindingContext(ds.Tables(0)).Position + 1

                Dim MyItem = Me.lstvwWinners.Items.Add(dr("Account"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Prize".ToString))
                    .SubItems.Add(dr("PrizeAmt".ToString))
                    .SubItems.Add(dr("Ticket".ToString))
                    .SubItems.Add(dr("Amount".ToString))
                    .SubItems.Add(dr("Name".ToString))
                    .SubItems.Add(dr("Address".ToString))
                    .SubItems.Add(dr("ORDate".ToString))
                End With
            Next
        End If
        Me.txtTotalRecord.Text = iCountRecord
        Return SqlString
        cn.Close()

    End Function

    Private Sub btnConsolation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolation.Click

        Dim CODE As Long

        Dim TicketNo As String = 0
        Dim AccountNo As String = 0
        Dim Amount As String = 0

        Me.progbar.Maximum = Me.txtInputRecord.Text

        Me.btnDelete.Enabled = False
        Me.btnClose.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'dbf connection
        'dbfcnRaffle = New OleDb.OleDbConnection("Provider=vfpoledb;" & _
        '            "Data Source=" & Application.StartupPath & "\RAFFLE.dbf;")
        'dbfcnRaffle.Open()

InsertConso:

NoRecord:

        Dim RandomClass As New Random()

        CODE = (RandomClass.Next(999999))
        'strCODE = CStr(CODE)

        ''MsgBox(CODE)

        'If Len(strCODE) = 6 Then
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 5 Then
        '    strCODE = "0" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 4 Then
        '    strCODE = "00" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 3 Then
        '    strCODE = "000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 2 Then
        '    strCODE = "0000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 1 Then
        '    strCODE = "00000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'check if ID is existing
        StrSelect = "SELECT * FROM tblConverted WHERE CODE= '" & CODE & "'"

        Dim cmd As New SqlCommand(StrSelect, cn)

        Dim objReader As SqlDataReader = cmd.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then

            ConsoName = CSQ(Trim(objReader("Name").ToString))
            Try
                ConsoTicket = objReader("Bill")
            Catch ex As Exception
                ConsoTicket = 0
            End Try

            ConsoAmount = objReader("Amount")
            ConsoAccount = objReader("Account")
            'MsgBox(ConsoAccount)
            ConsoBillmo = objReader("Billmo")
            'MsgBox(ConsoBillmo)
            ConsoDate = objReader("Date")
            ConsoAddress = Trim(objReader("Address"))
            ConsoQuarter = Me.lblRaffleDrawSet.Text
            PrizeAmt = ConsoPrizeAmt
            objReader.Close()

            'check if winner is existing in database of consolation prize
            StrSelect = "SELECT * FROM tblWinners WHERE Ticket= '" & ConsoTicket & "' and Quarter='" & Me.lblRaffleDrawSet.Text & "'"

            Dim cmdSearch As New SqlCommand(StrSelect, cn)

            Dim objReaderSearch As SqlDataReader = cmdSearch.ExecuteReader
            objReaderSearch.Read()

            If objReaderSearch.HasRows = True Then
                objReaderSearch.Close()
                GoTo NoRecord

            End If

            objReaderSearch.Close()

            StrSelect = "INSERT INTO tblWinners" & _
            "(Prize,Ticket,Account,Amount,Name,Address,ORDate,Billmo,Quarter,PrizeAmt,Seq)VALUES " & _
            "('" & ConsoPrize & "'," & _
            "'" & ConsoTicket & _
            "','" & ConsoAccount & _
            "','" & ConsoAmount & _
            "','" & CSQ(Trim(ConsoName)) & _
            "','" & CSQ(Trim(ConsoAddress)) & _
            "','" & ConsoDate & _
            "','" & ConsoBillmo & _
            "','" & ConsoQuarter & _
            "','" & PrizeAmt & _
            "', " & "'" & 4 & "')"

            Dim cmdSave As New SqlCommand(StrSelect, cn)
            cmdSave.ExecuteNonQuery()

            progbar.Value = progbar.Value + 1

            If CInt(progbar.Value) < tempConsolation Then GoTo InsertConso

            Me.progbar.Value = 0

            LoadLv()

            If CInt(Me.txtTotalRecord.Text) > 0 Then
                Me.btnEnter.Visible = True
                Me.btnEnter.Text = "Third winner!"
                Me.tmrbtnEnter.Enabled = True
            End If
        Else

            objReader.Close()
            GoTo NoRecord

        End If


        objReader.Close()

        Me.btnDelete.Enabled = True
        Me.btnClose.Enabled = True

        Me.btnConsolation.Visible = False

        Me.Cursor = Cursors.Hand

    End Sub

    Public Function CSQ(ByVal str)
        If IsDBNull(str) Then str = ""
        CSQ = Replace(str, "'", "''")
    End Function

    Private Sub tmrbtnEnter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbtnEnter.Tick

        If Me.btnEnter.ForeColor = Color.Blue = True Then
            Me.btnEnter.ForeColor = Color.Yellow
            Exit Sub
        End If

        If Me.btnEnter.ForeColor = Color.Yellow = True Then
            Me.btnEnter.ForeColor = Color.Red
            Exit Sub
        End If

        If Me.btnEnter.ForeColor = Color.Red = True Then
            Me.btnEnter.ForeColor = Color.Blue
            Exit Sub
        End If

    End Sub

    Private Sub tmrbtnConso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbtnConso.Tick
        If Me.btnConsolation.ForeColor = Color.Blue = True Then
            Me.btnConsolation.ForeColor = Color.Yellow
            Exit Sub
        End If

        If Me.btnConsolation.ForeColor = Color.Yellow = True Then
            Me.btnConsolation.ForeColor = Color.Red
            Exit Sub
        End If

        If Me.btnConsolation.ForeColor = Color.Red = True Then
            Me.btnConsolation.ForeColor = Color.Blue
            Exit Sub
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim CODE As Long

        Dim TicketNo As Integer = 0

        Dim Amount As Double = 0

        'dbf connection
        'dbfcn = New OleDb.OleDbConnection("Provider=vfpoledb;" & _
        '            "Data Source=" & Application.StartupPath & "\RAFFLE.dbf;")
        'dbfcn.Open()

        
NoRecord:

        Dim RandomClass As New Random()

        'create random number
        CODE = (RandomClass.Next(999999))
        'strCODE = CStr(CODE)

        'If Len(strCODE) = 6 Then
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 5 Then
        '    strCODE = "0" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 4 Then
        '    strCODE = "00" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 3 Then
        '    strCODE = "000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 2 Then
        '    strCODE = "0000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'If Len(strCODE) = 1 Then
        '    strCODE = "00000" & strCODE
        '    Me.txtBill.Text = strCODE
        'End If

        'check if ID is exist den get the data from raffle.dbf
        StrSelect = "SELECT * FROM tblConverted WHERE CODE= '" & CODE & "'"

        Dim cmd As New SqlCommand(StrSelect, cn)

        Dim objReader As SqlDataReader = cmd.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then

            Me.txtName.Text = objReader("Name").ToString
            Try
                TicketNo = objReader("Bill")
            Catch ex As Exception
                TicketNo = 0
            End Try
            Amount = objReader("amount")
            AccountNo = objReader("Account")
            Address = objReader("Address").ToString
            ORDate = CDate(objReader("Date"))
            BillMo = objReader("Billmo")

        Else

            objReader.Close()
            GoTo NoRecord

        End If

        objReader.Close()

        'check if winner is existing in database
        StrSelect = "SELECT * FROM tblWinners WHERE Ticket= '" & TicketNo & "' and Quarter='" & Me.lblRaffleDrawSet.Text & "'"

        Dim cmdSearch As New SqlCommand(StrSelect, cn)

        Dim objReaderSearch As SqlDataReader = cmdSearch.ExecuteReader
        objReaderSearch.Read()

        If objReaderSearch.HasRows = True Then
            objReaderSearch.Close()
            'MsgBox("existing")
            GoTo NoRecord

        End If

        objReaderSearch.Close()

        'Third prize entry
        If Len(Trim(Me.txt3rdPrize.Text)) = 0 And Me.txt3rdPrizeAccount.Text = 0 Then

            CallRandom()

            Me.txt3rdPrize.Text = Me.txtName.Text
            Me.txt3rdPrizeTicket.Text = TicketNo
            Amount = Me.txt3rdPrizeAmount.Text
            Me.txt3rdPrizeAccount.Text = AccountNo
            Me.btnEnter.Text = "2nd winner!"
            Prize = "Third Prize"
            PrizeAmt = ThirdPrizeAmt
            Seq = 3
            GoTo saveRec

        End If

        'second prize entry
        If Len(Trim(Me.txt2ndPrize.Text)) = 0 And Me.txt2ndPrizeAccount.Text = 0 Then

            CallRandom()

            Me.txt2ndPrize.Text = Me.txtName.Text
            Me.txt2ndPrizeTicket.Text = TicketNo
            Amount = Me.txt2ndPrizeAmount.Text
            Me.txt2ndPrizeAccount.Text = AccountNo
            Me.btnEnter.Text = "First winner!"
            Prize = "Second Prize"
            PrizeAmt = SecondPrizeAmt
            Seq = 2
            GoTo saveRec

        End If

        'First prize entry
        If Len(Trim(Me.txtFirstPrize.Text)) = 0 And Me.txtFirstPrizeAccount.Text = 0 Then

            CallRandom()

            Me.txtFirstPrize.Text = Me.txtName.Text
            Me.txtFirstPrizeTicket.Text = TicketNo
            Amount = FormatNumber(Me.txtFirstPrizeAmount.Text)
            Me.txtFirstPrizeAccount.Text = AccountNo
            Me.btnTextFile.Visible = True
            Me.btnEnter.Visible = False
            Prize = "First Prize"
            PrizeAmt = FirstPrizeAmt
            Seq = 1
        End If

saveRec:

        'save in sql 

        StrSelect = "INSERT INTO tblWinners" & _
                    "(Prize,Ticket,Account,Amount,Name,Address,ORDate,Billmo,Quarter,PrizeAmt,Seq)VALUES " & _
                    "('" & Prize & "'," & _
                    "'" & TicketNo & _
                    "','" & AccountNo & _
                    "','" & (Amount) & _
                    "','" & CSQ(Trim(Me.txtName.Text)) & _
                    "','" & CSQ(Trim(Address)) & _
                    "','" & ORDate & _
                    "','" & BillMo & _
                    "','" & Me.lblRaffleDrawSet.Text & _
                    "','" & PrizeAmt & _
                    "', " & "'" & Seq & "')"

        CheckConnection(cn)

        Dim cmdSaveSQL As New SqlCommand(StrSelect, cn)
        cmdSaveSQL.ExecuteNonQuery()

        LoadLv()

    End Sub

    Private Sub CallRandom()
        Dim frmobj As New frmAnimate
        frmobj.txtRandomNumber.Text = AccountNo
        frmobj.ShowDialog()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Ask = MsgBox("Are you sure you want to delete records?", MsgBoxStyle.YesNo, "Delete")
        If Ask = vbYes Then

            CheckConnection(cn)
            StrSelect = "DELETE FROM tblWinners WHERE Quarter='" & CSQ(Me.lblRaffleDrawSet.Text) & "'"

            Dim cmdDelete As New SqlCommand(StrSelect, cn)
            cmdDelete.ExecuteNonQuery()

            ClearRecord()

            Me.btnEnter.Text = "First winner!"
            Me.btnEnter.Visible = False
            Me.btnConsolation.Visible = True
            Me.tmrbtnConso.Enabled = True

            MsgBox("All record has been successfully deleted.", MsgBoxStyle.Information, "Deleted")
            LoadLv()
            Me.btnTextFile.Visible = False

        End If
    End Sub

    Private Sub ClearRecord()

        Me.txtFirstPrize.Text = ""
        Me.txtFirstPrizeTicket.Text = "0"
        Me.txtFirstPrizeAccount.Text = "0"

        Me.txt2ndPrize.Text = ""
        Me.txt2ndPrizeTicket.Text = "0"
        Me.txt2ndPrizeAccount.Text = "0"

        Me.txt3rdPrize.Text = ""
        Me.txt3rdPrizeTicket.Text = "0"
        Me.txt3rdPrizeAccount.Text = "0"

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If Me.btnClose.Text = "&Close" Then

            Ask = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
            If Ask = vbYes Then
                End
            End If

        Else

            Me.lstbxRaffleDrawSet.Visible = True
            Me.btnDeleteEntry.Enabled = True
            Me.btnClose.Text = "&Close"
            Me.btnAddEntry.Text = "&Add Entry"
            Me.txtConsoPrize.Text = 100
            Me.txtInputFirst.Text = 0
            Me.txtInputSecond.Text = 0
            Me.txtInputThird.Text = 0

            Norecord()

        End If

    End Sub

    Private Sub btnAddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEntry.Click

        Me.lstbxRaffleDrawSet.Visible = False
        Me.grpRaffleDrawSet.Enabled = True

        Dim str As String = Me.cmbxQuarter.Text & ", " & Me.cmbxYear.Text

        If Me.btnAddEntry.Text = "&Save Entry" Then

            If Me.cmbxQuarter.Text = "" Then
                MsgBox("Please choose a quarter for the raffle draw.", MsgBoxStyle.Exclamation, "Required.....")
                Me.cmbxQuarter.Focus()
                Exit Sub
            End If

            If Me.cmbxYear.Text = "" Then
                MsgBox("Please choose a year for the raffle draw.", MsgBoxStyle.Exclamation, "Required.....")
                Me.cmbxYear.Focus()
                Exit Sub
            End If

            If Len(Trim(Me.txtInputRecord.Text)) = 0 Or Me.txtInputRecord.Text = "0" Then
                MsgBox("Please input a no. of consolation prize for the raffle draw.", MsgBoxStyle.Exclamation, "Required.....")
                Me.txtInputRecord.Focus()
                Exit Sub
            End If

            If Len(Trim(Me.txtConsoPrize.Text)) = 0 Or Me.txtConsoPrize.Text = "0" Then
                MsgBox("Please input the amount prize for the consolation prize.", MsgBoxStyle.Exclamation, "Required.....")
                Me.txtConsoPrize.Focus()
                Exit Sub
            End If

            If Len(Trim(Me.txtInputFirst.Text)) = 0 Or Me.txtInputFirst.Text = "0" Then
                MsgBox("Please input the amount prize for the first prize.", MsgBoxStyle.Exclamation, "Required.....")
                Me.txtInputFirst.Focus()
                Exit Sub
            End If

            If Len(Trim(Me.txtInputSecond.Text)) = 0 Or Me.txtInputSecond.Text = "0" Then
                MsgBox("Please input the amount prize for the second prize.", MsgBoxStyle.Exclamation, "Required.....")
                Me.txtInputSecond.Focus()
                Exit Sub
            End If

            If Len(Trim(Me.txtInputThird.Text)) = 0 Or Me.txtInputThird.Text = "0" Then
                MsgBox("Please input the amount prize for the third prize.", MsgBoxStyle.Exclamation, "Required.....")
                Me.txtInputThird.Focus()
                Exit Sub
            End If

            'check if data is existing
            CheckConnection(cn)
            StrSelect = "SELECT * FROM tblRaffle WHERE ID= '" & str & "'"
            Dim cmdSearch As New SqlCommand(StrSelect, cn)

            Dim objReader As SqlDataReader = cmdSearch.ExecuteReader
            objReader.Read()

            If objReader.HasRows = True Then
                MsgBox(str & " is already an existing record.", MsgBoxStyle.Critical, "Duplication.....")
                objReader.Close()
                Exit Sub
            End If

            objReader.Close()

            StrSelect = "INSERT INTO tblRaffle" & _
            "(ID,Quarter,Year,Conso_Prize,First_Prize,Second_Prize,Third_Prize,ConsoNo)VALUES " & _
            "('" & str.ToString & "'," & _
            "'" & Me.cmbxQuarter.Text & _
            "','" & CInt(Me.cmbxYear.Text) & _
            "','" & CInt(Me.txtConsoPrize.Text) & _
            "','" & CInt(Me.txtInputFirst.Text) & _
             "','" & CInt(Me.txtInputSecond.Text) & _
              "','" & CInt(Me.txtInputThird.Text) & _
            "', " & "'" & CInt(Me.txtInputRecord.Text) & "')"

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()

            MsgBox(str & " has been successfully saved.", MsgBoxStyle.Information, "Saved")

            Me.lstbxRaffleDrawSet.Visible = True
            Me.btnAddEntry.Text = "&Add Entry"
            Me.btnClose.Text = "&Close"
            Me.btnDeleteEntry.Enabled = True
            FillRaffleDrawSet("SELECT * FROM tblRaffle")

            Exit Sub

        End If

        Me.btnAddEntry.Text = "&Save Entry"
        Me.btnClose.Text = "&Cancel"

        Me.cmbxQuarter.Text = ""
        Me.cmbxYear.Text = ""
        Me.txtInputFirst.Text = 0
        Me.txtInputSecond.Text = 0
        Me.txtInputThird.Text = 0

        Me.btnDeleteEntry.Enabled = False

    End Sub

    Private Sub cmbxYear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbxYear.KeyPress
        e.Handled = NoCharacter(Asc(e.KeyChar))
    End Sub

    Private Sub cmbxYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxYear.SelectedIndexChanged
        Me.txtInputRecord.Focus()
    End Sub

    Private Sub txtInputRecord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputRecord.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.txtConsoPrize.Focus()
            Exit Sub
        End If

        e.Handled = OnlyNumeric(Asc(e.KeyChar))

    End Sub

    Private Sub btnDeleteEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteEntry.Click

        If Trim(Me.lstbxRaffleDrawSet.SelectedItem) = "" Then
            MsgBox("Please choose a raffle draw date.", MsgBoxStyle.Exclamation, "Required.....")
            Exit Sub
        End If

        Ask = MsgBox("Are you sure you want to delete " & Me.lstbxRaffleDrawSet.SelectedItem & "?", MsgBoxStyle.YesNo, "Delete.....")
        If Ask = vbYes Then
            StrSelect = "DELETE FROM tblRaffle " & _
                   "WHERE ID = '" & Me.lstbxRaffleDrawSet.SelectedItem & "' "

            CheckConnection(cn)

            Dim cmd As New SqlCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()

            MsgBox(Me.lstbxRaffleDrawSet.SelectedItem & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted.....")
            FillRaffleDrawSet("SELECT * FROM tblRaffle")

        End If

        Norecord

    End Sub

    Private Sub Norecord()
        If Me.lstbxRaffleDrawSet.Items.Count = 0 Then
            Me.btnDeleteEntry.Enabled = False
        Else
            Me.btnDeleteEntry.Enabled = True
        End If
    End Sub

    Private Sub cmbxQuarter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbxQuarter.KeyPress
        e.Handled = NoCharacter(Asc(e.KeyChar))
    End Sub

    Private Sub lstbxRaffleDrawSet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstbxRaffleDrawSet.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            OpenRecord()
        End If
    End Sub

    Private Sub OpenRecord()

        ClearRecord()

        Me.lblRaffleDrawSet.Text = Me.lstbxRaffleDrawSet.SelectedItem
        Me.pnRaffleDrawSet.Visible = False
        Me.lblRaffleDrawSet.Visible = True
        Me.pnWinnersInfo.Visible = True
        Me.pnWinnersInfo.Enabled = True

        FillListViewsql("SELECT * FROM tblWinners WHERE Quarter='" & Me.lstbxRaffleDrawSet.SelectedItem & "' ORDER by Ticket ASC ")

        'check for number of consolation prize winner
        CheckConnection(cn)
        StrSelect = "SELECT * FROM tblRaffle WHERE ID='" & Me.lblRaffleDrawSet.Text & "'"
        Dim cmdSearchConso As New SqlCommand(StrSelect, cn)

        Dim objReaderConso As SqlDataReader = cmdSearchConso.ExecuteReader
        objReaderConso.Read()

        If objReaderConso.HasRows = True Then

            tempConsolation = objReaderConso("ConsoNo")

            FirstPrizeAmt = objReaderConso("First_Prize")
            SecondPrizeAmt = objReaderConso("Second_Prize")
            ThirdPrizeAmt = objReaderConso("Third_Prize")
            ConsoPrizeAmt = objReaderConso("Conso_Prize")

            Me.txtFirstPrizeAmount.Text = FormatNumber(FirstPrizeAmt)
            Me.txt2ndPrizeAmount.Text = FormatNumber(SecondPrizeAmt)
            Me.txt3rdPrizeAmount.Text = FormatNumber(ThirdPrizeAmt)

        End If

        objReaderConso.Close()

        'check for First prize winner
        CheckConnection(cn)
        StrSelect = "SELECT * FROM tblWinners WHERE Prize= '" & "First Prize" & "'and Quarter='" & Me.lblRaffleDrawSet.Text & "'"
        Dim cmdSearch1st As New SqlCommand(StrSelect, cn)

        Dim objReader1st As SqlDataReader = cmdSearch1st.ExecuteReader
        objReader1st.Read()

        If objReader1st.HasRows = True Then

            Me.txtFirstPrize.Text = objReader1st("Name").ToString
            Me.txtFirstPrizeTicket.Text = objReader1st("Ticket")
            Me.txtFirstPrizeAccount.Text = objReader1st("Account")
            Me.btnConsolation.Visible = False
            Me.btnEnter.Visible = False
            Me.btnTextFile.Visible = True
        Else
            Me.btnEnter.Text = "First winner!"
        End If

        objReader1st.Close()

        'check for second prize winner
        CheckConnection(cn)
        StrSelect = "SELECT * FROM tblWinners WHERE Prize= '" & "Second Prize" & "' and Quarter='" & Me.lblRaffleDrawSet.Text & "'"
        Dim cmdSearch2nd As New SqlCommand(StrSelect, cn)

        Dim objReader2nd As SqlDataReader = cmdSearch2nd.ExecuteReader
        objReader2nd.Read()

        If objReader2nd.HasRows = True Then
            Me.txt2ndPrize.Text = objReader2nd("Name").ToString
            Me.txt2ndPrizeTicket.Text = objReader2nd("Ticket")
            Me.txt2ndPrizeAccount.Text = objReader2nd("Account")
            Me.btnEnter.Text = "First winner!"
        Else
            Me.btnEnter.Text = "Second winner!"
        End If

        objReader2nd.Close()

        'check for Third prize winner
        CheckConnection(cn)
        StrSelect = "SELECT * FROM tblWinners WHERE Prize= '" & "Third Prize" & "'and Quarter='" & Me.lblRaffleDrawSet.Text & "'"
        Dim cmdSearch3rd As New SqlCommand(StrSelect, cn)

        Dim objReader3rd As SqlDataReader = cmdSearch3rd.ExecuteReader
        objReader3rd.Read()

        If objReader3rd.HasRows = True Then

            Me.txt3rdPrize.Text = objReader3rd("Name").ToString
            Me.txt3rdPrizeTicket.Text = objReader3rd("Ticket")
            Me.txt3rdPrizeAccount.Text = objReader3rd("Account")
            Me.btnEnter.Visible = True
            Me.tmrbtnEnter.Enabled = True
            Me.btnConsolation.Visible = False

        Else
            If CInt(Me.txtTotalRecord.Text) = 0 Then
                Me.btnConsolation.Visible = True
                Me.tmrbtnConso.Enabled = True
                Me.btnEnter.Visible = False
                Me.tmrbtnEnter.Enabled = False

            Else
                Me.btnEnter.Visible = True
                Me.tmrbtnEnter.Enabled = True
                Me.btnEnter.Text = "Third winner!"
                Me.btnConsolation.Visible = False
                Me.tmrbtnConso.Enabled = False
            End If
        End If

        objReader3rd.Close()

        LoadLv()

        'Check if raffle draw is complete and ready to be print in a text file
        If Me.txtFirstPrize.Text = "" Then
            Me.btnTextFile.Visible = False
        Else
            Me.btnTextFile.Visible = True
        End If

    End Sub

    Private Sub lstbxRaffleDrawSet_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstbxRaffleDrawSet.MouseDoubleClick

        If Trim(Me.lstbxRaffleDrawSet.SelectedItem) = "" Then
            MsgBox("Please choose a raffle draw date.", MsgBoxStyle.Exclamation, "Required.....")
            Exit Sub
        End If

        OpenRecord()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnEnter.Text = "First winner!"
        Me.pnRaffleDrawSet.Visible = True
        Me.lblRaffleDrawSet.Visible = False
        Me.pnWinnersInfo.Visible = False
        Me.pnWinnersInfo.Enabled = False
    End Sub

    Private Sub tmrRaffle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRaffle.Tick
        If Me.lblRaffleDrawSet.ForeColor = Color.Blue = True Then
            Me.lblRaffleDrawSet.ForeColor = Color.Yellow
            Exit Sub
        End If

        If Me.lblRaffleDrawSet.ForeColor = Color.Yellow = True Then
            Me.lblRaffleDrawSet.ForeColor = Color.Red
            Exit Sub
        End If

        If Me.lblRaffleDrawSet.ForeColor = Color.Red = True Then
            Me.lblRaffleDrawSet.ForeColor = Color.Blue
            Exit Sub
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim frm As New frmRVWinners
        Dim Fltr

        Fltr = "{tblWinners.Quarter}='" & Trim(Me.lblRaffleDrawSet.Text) & " ' "   'Quarter
        frm.CVWinners.SelectionFormula = (Fltr)

        frm.Show()

    End Sub

    Private Sub btntextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTextFile.Click

        Dim TW As System.IO.TextWriter

        'Save Dialog File
        SFDTxtFile.Filter = "Text Documents (*.txt)|*.txt"
        SFDTxtFile.DefaultExt = ".txt"
        SFDTxtFile.FileName = "Raffle Draw"

        If SFDTxtFile.ShowDialog = DialogResult.OK Then
            'FileOpen(1, SFDTxtFile.FileName, OpenMode.Output)


            'Create a Text file and load it into the TextWriter 
            TW = System.IO.File.CreateText(SFDTxtFile.FileName)

            Dim x As Integer

            TW.WriteLine("Accounts:     " & "Billmo:     " & "Prize:")

            For x = 0 To CInt(tempConsolation) + 2

                'add record to text file
                StrSelect = "SELECT * FROM tblWinners WHERE Account= '" & Me.lstvwWinnersTemp.Items(x).Text & "' ORDER BY Seq ASC"

                Dim cmdAdd As New SqlCommand(StrSelect, cn)

                Dim objReaderAdd As SqlDataReader = cmdAdd.ExecuteReader

                objReaderAdd.Read()

                If objReaderAdd.HasRows = True Then

                    ConsoName = CSQ(Trim(objReaderAdd("Name").ToString))
                    Try
                        ConsoTicket = objReaderAdd("Bill")
                    Catch ex As Exception
                        ConsoTicket = 0
                    End Try

                    ConsoPrize = objReaderAdd("Prize")
                    ConsoAccount = objReaderAdd("Account")
                    ConsoBillmo = objReaderAdd("Billmo")

                    objReaderAdd.Close()


                    'Write a line 
                    TW.WriteLine(ConsoAccount & "   " & ConsoBillmo & "     " & ConsoPrize)

                    'Flush the text to the file 
                    TW.Flush()

                End If
            Next

            'Close the File 
            TW.Close()

            FileClose(1)

            MsgBox("Text File has been successfully saved,", MsgBoxStyle.Information, "Saved")

        End If

    End Sub

    Private Sub txtInputFirst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputFirst.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.txtInputSecond.Focus()
            Exit Sub
        End If

        e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Sub

    Private Sub txtConsoPrize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsoPrize.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.txtInputFirst.Focus()
            Exit Sub
        End If

        e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Sub

    Private Sub txtInputSecond_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputSecond.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.txtInputThird.Focus()
            Exit Sub
        End If

        e.Handled = OnlyNumeric(Asc(e.KeyChar))

    End Sub

    Private Sub txtInputThird_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputThird.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.btnAddEntry.Focus()
            Exit Sub
        End If

        e.Handled = OnlyNumeric(Asc(e.KeyChar))

    End Sub
End Class
