
Public Class frmRVWinners

    Private Sub frmRVWinners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim intCounter As Integer

        'Crystal Report's report document object

        Dim objReport As New _
            CrystalDecisions.CrystalReports.Engine.ReportDocument

        'object of table Log on info of Crystal report

        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

        Dim mySubRepDoc As New _
            CrystalDecisions.CrystalReports.Engine.ReportDocument

        Try

            'Load the report

            objReport.Load(Application.StartupPath & "\crptWinners.rpt")

            ConInfo.ConnectionInfo.UserID = "sa"
            ConInfo.ConnectionInfo.Password = "zAm@1974101800"
            ConInfo.ConnectionInfo.ServerName = "MAINSERVER-PC"
            ConInfo.ConnectionInfo.DatabaseName = "ISDDB"

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next

            'Set the current report object to report.

            CVWinners.ReportSource = objReport

            'Show the report

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class