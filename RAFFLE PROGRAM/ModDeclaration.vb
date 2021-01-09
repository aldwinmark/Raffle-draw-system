Imports System.Data.SqlClient
Imports System.Data.OleDb

Module ModDeclaration

    Public da As SqlDataAdapter = New SqlDataAdapter
    Public cmbldr As SqlCommandBuilder

    'for dbf
    Public Ask As String
    Public dbfcn As OleDbConnection
    Public dbfcnRaffle As OleDbConnection
    Public dbfcnBcraf As OleDbConnection

    Public StrSelect As String

    Public ds As DataSet = New DataSet
    Public oleDbds As DataSet = New DataSet
    Public oleDbda As OleDbDataAdapter = New OleDbDataAdapter
    Public dr As DataRow
    Public oleDbcmbldr As OleDbCommandBuilder

    Public Sqlds As DataSet = New DataSet
    Public Sqlda As SqlDataAdapter = New SqlDataAdapter
    Public Sqlcmbldr As SqlCommandBuilder

    Public iCountRecord As Integer
    Public iCurrentRecord As Integer

    Public ConsoPrize As String = "Consolation"
    Public ConsoTicket As Integer
    Public ConsoAccount As String
    Public ConsoAmount As Double
    Public ConsoName As String
    Public ConsoAddress As String
    Public ConsoBillmo As String
    Public ConsoDate As String
    Public ConsoQuarter As String

    Public Address As String
    Public BillMo As String
    Public ORDate As String
    Public Prize As String

    Public PrizeAmt As Double
    Public FirstPrizeAmt As Double
    Public SecondPrizeAmt As Double
    Public ThirdPrizeAmt As Double
    Public ConsoPrizeAmt As Double

    Public tempConsolation As Integer
    Public Seq As Integer

    Public num(10) As String
    Public y As Integer
    Public strCODE As String
    Public AccountNo As String = 0

End Module
