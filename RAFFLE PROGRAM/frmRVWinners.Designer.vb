<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRVWinners
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRVWinners))
        Me.CVWinners = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CVWinners
        '
        Me.CVWinners.ActiveViewIndex = -1
        Me.CVWinners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CVWinners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CVWinners.Location = New System.Drawing.Point(0, 0)
        Me.CVWinners.Name = "CVWinners"
        Me.CVWinners.SelectionFormula = ""
        Me.CVWinners.Size = New System.Drawing.Size(531, 406)
        Me.CVWinners.TabIndex = 0
        Me.CVWinners.ViewTimeSelectionFormula = ""
        '
        'frmRVWinners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 406)
        Me.Controls.Add(Me.CVWinners)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRVWinners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CVWinners As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
