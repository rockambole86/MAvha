Imports System.Web.Services
Imports MAvhaService

Partial Class _Default
    Inherits Page

    Private Shared ReadOnly _client As ServiceSoapClient = New ServiceSoapClient()

    <WebMethod> _
    Public Shared Function ListJson() As String
        Return _client.ListJson()
    End Function

    <WebMethod> _
    Public Shared Sub Save(person As Person)
        _client.Save(person)
    End Sub

    <WebMethod> _
    Public Shared Sub Delete(id As Integer)
        _client.Delete(id)
    End Sub
End Class
