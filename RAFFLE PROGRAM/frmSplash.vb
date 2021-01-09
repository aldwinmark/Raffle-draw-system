Public NotInheritable Class frmSplash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.tmrTrans.Enabled = True
    End Sub

    Private Sub tmSplash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmSplash.Tick
        FormOpacity(Me, tmSplash)
        tmShowForm.Enabled = True
    End Sub

    Private Sub tmShowForm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmShowForm.Tick
        Dim frmobj As New frmRaffle
        frmobj.Show()
        Me.Hide()
        tmShowForm.Enabled = False
        tmSplash.Enabled = False
    End Sub
End Class
