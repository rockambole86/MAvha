Imports System.Configuration
Imports System.Data.SqlClient

Public Class DB

#Region "Variables"

    Private Shared _instance As DB = Nothing
    Private _connection As SqlConnection
    Private ReadOnly _connString As String
    Private _command As SqlCommand
    Private _paramPrefix As String = "@"

#End Region

    Public Property ScopeIdentity As Integer

    Protected Sub New()
        MyBase.New
        _connString = ConfigurationManager.ConnectionStrings("MAvha").ConnectionString
    End Sub

    Public Shared Function Instance() As DB
        If (_instance Is Nothing)
            _instance = New DB()
        End If

        Return _instance
    End Function

    Public Sub Connect()
        Try
            If (_connection Is Nothing) Then
                _connection = New SqlConnection(_connString)
            End If

            If (_connection.State <> ConnectionState.Open) Then
                _connection.Open
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Throw
        End Try
    End Sub

    Public Sub Disconnect()
        Try
            If (Not (Me._connection) Is Nothing) Then
                If (Me._connection.State <> ConnectionState.Closed) Then
                    Me._connection.Close
                End If

                Me._connection.Dispose
            End If

            Me._connection = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Throw
        End Try
    End Sub

    Public Sub ExecuteNonQuery(spName As String, parameters As Hashtable)
        Try
            Me._command = New SqlCommand(spName, Me._connection) With {
                .CommandType = CommandType.StoredProcedure
            }
            Me.AddParameters(parameters)

            Me._command.ExecuteNonQuery
        Catch ex As Exception
            Throw New ApplicationException(ex.Message)
        Finally
            Me._command = Nothing
        End Try
    End Sub

    Public Function ExecuteDataTable(spName As String, parameters As Hashtable) As DataTable
        Try
            Me._command = New SqlCommand(spName, Me._connection) With {
                .CommandType = CommandType.StoredProcedure
                }
            Me.AddParameters(parameters)

            Dim adapter = New SqlDataAdapter(Me._command)

            Dim table = New DataTable

            adapter.Fill(table)

            Return table
        Catch ex As Exception
            Throw New ApplicationException(ex.Message)
        Finally
            Me._command = Nothing
        End Try
    End Function

    Public Function ExecuteDataSet(spName As String, parameters As Hashtable) As DataSet
        Try
            Me._command = New SqlCommand(spName, Me._connection) With {
                .CommandType = CommandType.StoredProcedure
                }
            Me.AddParameters(parameters)

            Dim adapter = New SqlDataAdapter(Me._command)
            Dim ds = New DataSet

            adapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Throw New ApplicationException(ex.Message)
        End Try
    End Function

    Public Function ExecuteScalar(spName As String, parameters As Hashtable) As Object
        Try
            Me._command = New SqlCommand(spName, Me._connection) With {
                .CommandType = CommandType.StoredProcedure
                }
            Me.AddParameters(parameters)

            Return Me._command.ExecuteScalar
        Catch ex As Exception
            Throw New ApplicationException(ex.Message)
        Finally
            Me._command = Nothing
        End Try
    End Function

    Public Sub AddParameters(parameters As Hashtable)
        If (parameters Is Nothing) OrElse parameters.Count <= 0 Then Return

        Me._command.Parameters.Clear

        Dim paramName As String
        Dim paramValue As Object

        For Each param As DictionaryEntry In parameters
            paramName = _paramPrefix & param.Key

            If (param.Value Is Nothing)
                paramValue = DBNull.Value
            else
                paramValue = param.Value
            End If

            Me._command.Parameters.AddWithValue(paramName, paramValue)
        Next
    End Sub
End Class
