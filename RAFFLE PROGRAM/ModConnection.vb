Imports System.Data.SqlClient
Imports System.Data.OleDb
Module ModConnection

    Public Function CheckConnection(ByVal conn As SqlConnection) As SqlConnection
        Try
            'This function checks the recordset if it is open.
            'if it is open, then it will close the recordset
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return conn
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw (ex)
        End Try

    End Function


    '====================================================================
    'open a database connection.
    Public strConnection As String = "Data Source=MAINSERVER-PC;" & _
                                     "uid=sa;" & _
                                     "pwd=zAm@1974101800;" & _
                                     "database=ISDDB"
    Public cn As SqlConnection = New SqlConnection(strConnection)


    'open a database connection.
    'Public strConnection As String = "Data Source=Black-Cat;" & _
    '                                 "uid=sa;" & _
    '                                 "pwd=1987jul8;" & _
    '                                 "database=AccountingDatabase"
    'Public cn As SqlConnection = New SqlConnection(strConnection)


    Public Function OnlyNumeric(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            OnlyNumeric = False
        Else
            OnlyNumeric = True
        End If
        'e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Function

    Public Function NoCharacter(ByVal Key As String) As Boolean
        'If (Key >= 48 And Key <= 57) Or Key = 8 Then
        'NoCharacter = False
        'Else
        NoCharacter = True
        'End If
        'e.Handled = NoCharacter(Asc(e.KeyChar))
    End Function

End Module
