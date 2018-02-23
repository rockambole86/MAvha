Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports MAvha.Business
Imports MAvha.DAL
Imports Microsoft.VisualBasic.CompilerServices

<ScriptService> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<DesignerGenerated> _
Public Class Service
    Inherits WebService

    <WebMethod> _
    Public Function List() As List(Of Person)
        Return PersonList
    End Function

    <WebMethod> _
    Public Function ListJson() As String
        Dim js As New JavaScriptSerializer

        Return js.Serialize(PersonList) 
    End Function

    <WebMethod> _
    Public Sub Save(person As Person)
        PersonSave(person)
    End Sub

    <WebMethod> _
    Public Sub Delete(id As Integer)
        PersonDelete(id)
    End Sub

End Class