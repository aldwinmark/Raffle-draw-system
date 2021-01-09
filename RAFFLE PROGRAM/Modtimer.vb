Module Modtimer

    Public Sub FormOpacity(ByRef form As Form, ByRef timer As Timer)
        form.Opacity = form.Opacity + 0.01
        If form.Opacity >= 100 Then
            timer.Enabled = False
        End If
    End Sub
End Module
