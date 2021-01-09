Public Class frmAnimate

    Dim RandomClass As New Random()
    Dim Rndnum As Integer

    Private Sub frmAnimate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        Me.tmr1.Enabled = True

        For y = 1 To Len(Me.txtRandomNumber.Text)
            num(y) = Mid(Me.txtRandomNumber.Text, y, 1)
        Next

    End Sub

    Private Sub tm1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        pgBar1.Value = pgBar1.Value + 1
        RandomNum()
        Me.Label1.Text = Rndnum
        If Me.pgBar1.Value = Me.pgBar1.Maximum Then
            Me.tmr1.Enabled = False
            Me.Label1.Text = num(1)
            Me.tmr2.Enabled = True
            Me.pic2.Visible = False
        End If
    End Sub

    Private Sub RandomNum()

        Rndnum = (RandomClass.Next(9))

    End Sub

    Private Sub tm2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        pgBar2.Value = pgBar2.Value + 1
        RandomNum()
        Me.Label2.Text = Rndnum
        If Me.pgBar2.Value = Me.pgBar2.Maximum Then
            Me.tmr2.Enabled = False
            Me.Label2.Text = num(2)
            Me.tmr3.Enabled = True
            Me.pic3.Visible = False
        End If
    End Sub

    Private Sub tm3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr3.Tick
        pgBar3.Value = pgBar3.Value + 1
        RandomNum()
        Me.Label3.Text = Rndnum
        If Me.pgBar3.Value = Me.pgBar3.Maximum Then
            Me.tmr3.Enabled = False
            Me.Label3.Text = num(3)
            Me.tmr4.Enabled = True
            Me.pic4.Visible = False
        End If
    End Sub

    Private Sub tm4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr4.Tick
        pgBar4.Value = pgBar4.Value + 1
        RandomNum()
        Me.Label4.Text = Rndnum
        If Me.pgBar4.Value = Me.pgBar4.Maximum Then
            Me.tmr4.Enabled = False
            Me.Label4.Text = num(4)
            Me.tmr5.Enabled = True
            Me.pic5.Visible = False
        End If
    End Sub

    Private Sub tm5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr5.Tick
        pgBar5.Value = pgBar5.Value + 1
        RandomNum()
        Me.Label5.Text = Rndnum
        If Me.pgBar5.Value = Me.pgBar5.Maximum Then
            Me.tmr5.Enabled = False
            Me.Label5.Text = num(5)
            Me.tmr6.Enabled = True
            Me.pic6.Visible = False
        End If
    End Sub

    Private Sub tm6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr6.Tick
        pgBar6.Value = pgBar6.Value + 1
        RandomNum()
        Me.Label6.Text = Rndnum
        If Me.pgBar6.Value = Me.pgBar6.Maximum Then
            Me.tmr6.Enabled = False
            Me.Label6.Text = num(6)
            Me.tmr7.Enabled = True
            Me.pic7.Visible = False
        End If
    End Sub

    Private Sub Reset()
        Me.pic2.Visible = True
        Me.pic3.Visible = True
        Me.pic4.Visible = True
        Me.pic5.Visible = True
        Me.pic6.Visible = True
    End Sub

    Private Sub tmDone_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDone.Tick
        Me.tmrDone.Enabled = False
        Me.tmrCongrat.Enabled = False
        Me.lblCongrats.Visible = False
        Me.Cursor = Cursors.Hand
        Me.Close()
        Reset()
    End Sub

    Private Sub tmrCongrat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCongrat.Tick
        If Me.lblCongrats.ForeColor = Color.Blue = True Then
            Me.lblCongrats.ForeColor = Color.Yellow
            Exit Sub
        End If

        If Me.lblCongrats.ForeColor = Color.Yellow = True Then
            Me.lblCongrats.ForeColor = Color.Red
            Exit Sub
        End If

        If Me.lblCongrats.ForeColor = Color.Red = True Then
            Me.lblCongrats.ForeColor = Color.Blue
            Exit Sub
        End If
    End Sub

    Private Sub tmr10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr10.Tick
        pgBar10.Value = pgBar10.Value + 1
        RandomNum()
        Me.Label10.Text = Rndnum
        If Me.pgBar10.Value = Me.pgBar10.Maximum Then
            Me.tmr10.Enabled = False
            Me.Label10.Text = num(10)
            Me.tmrDone.Enabled = True
            Me.tmrCongrat.Enabled = True
            Me.lblCongrats.Visible = True
        End If
    End Sub

    Private Sub tmr7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr7.Tick
        pgBar7.Value = pgBar7.Value + 1
        RandomNum()
        Me.Label7.Text = Rndnum
        If Me.pgBar7.Value = Me.pgBar7.Maximum Then
            Me.tmr7.Enabled = False
            Me.Label7.Text = num(7)
            Me.tmr8.Enabled = True
            Me.pic8.Visible = False
        End If
    End Sub

    Private Sub tmr8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr8.Tick
        pgBar8.Value = pgBar8.Value + 1
        RandomNum()
        Me.Label8.Text = Rndnum
        If Me.pgBar8.Value = Me.pgBar8.Maximum Then
            Me.tmr8.Enabled = False
            Me.Label8.Text = num(8)
            Me.tmr9.Enabled = True
            Me.pic9.Visible = False
        End If
    End Sub

    Private Sub tmr9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr9.Tick
        pgBar9.Value = pgBar9.Value + 1
        RandomNum()
        Me.Label9.Text = Rndnum
        If Me.pgBar9.Value = Me.pgBar9.Maximum Then
            Me.tmr9.Enabled = False
            Me.Label9.Text = num(9)
            Me.tmr10.Enabled = True
            Me.pic10.Visible = False
        End If
    End Sub
End Class