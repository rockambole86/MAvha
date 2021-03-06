﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace MAvhaService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Person", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Person
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private IdField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FullnameField As String
        
        Private DOBField As Date
        
        Private AgeField As Integer
        
        Private GenderField As MAvhaService.Gender
        
        Private IsActiveField As Boolean
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                If (Me.IdField.Equals(value) <> true) Then
                    Me.IdField = value
                    Me.RaisePropertyChanged("Id")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public Property Fullname() As String
            Get
                Return Me.FullnameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FullnameField, value) <> true) Then
                    Me.FullnameField = value
                    Me.RaisePropertyChanged("Fullname")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=2)>  _
        Public Property DOB() As Date
            Get
                Return Me.DOBField
            End Get
            Set
                If (Me.DOBField.Equals(value) <> true) Then
                    Me.DOBField = value
                    Me.RaisePropertyChanged("DOB")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=3)>  _
        Public Property Age() As Integer
            Get
                Return Me.AgeField
            End Get
            Set
                If (Me.AgeField.Equals(value) <> true) Then
                    Me.AgeField = value
                    Me.RaisePropertyChanged("Age")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=4)>  _
        Public Property Gender() As MAvhaService.Gender
            Get
                Return Me.GenderField
            End Get
            Set
                If (Me.GenderField.Equals(value) <> true) Then
                    Me.GenderField = value
                    Me.RaisePropertyChanged("Gender")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=5)>  _
        Public Property IsActive() As Boolean
            Get
                Return Me.IsActiveField
            End Get
            Set
                If (Me.IsActiveField.Equals(value) <> true) Then
                    Me.IsActiveField = value
                    Me.RaisePropertyChanged("IsActive")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Gender", [Namespace]:="http://tempuri.org/")>  _
    Public Enum Gender As Integer
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Masculino = 0
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Femenino = 1
    End Enum
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="MAvhaService.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        'CODEGEN: Generating message contract since element name ListResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/List", ReplyAction:="*")>  _
        Function List(ByVal request As MAvhaService.ListRequest) As MAvhaService.ListResponse
        
        'CODEGEN: Generating message contract since element name ListJsonResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ListJson", ReplyAction:="*")>  _
        Function ListJson(ByVal request As MAvhaService.ListJsonRequest) As MAvhaService.ListJsonResponse
        
        'CODEGEN: Generating message contract since element name person from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Save", ReplyAction:="*")>  _
        Function Save(ByVal request As MAvhaService.SaveRequest) As MAvhaService.SaveResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Delete", ReplyAction:="*")>  _
        Sub Delete(ByVal id As Integer)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ListRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="List", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.ListRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.ListRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class ListRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ListResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ListResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.ListResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.ListResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ListResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ListResult() As MAvhaService.Person
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ListResult() As MAvhaService.Person)
            MyBase.New
            Me.ListResult = ListResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ListJsonRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ListJson", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.ListJsonRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.ListJsonRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class ListJsonRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ListJsonResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ListJsonResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.ListJsonResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.ListJsonResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ListJsonResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ListJsonResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ListJsonResult As String)
            MyBase.New
            Me.ListJsonResult = ListJsonResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class SaveRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Save", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.SaveRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.SaveRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class SaveRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public person As MAvhaService.Person
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal person As MAvhaService.Person)
            MyBase.New
            Me.person = person
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class SaveResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="SaveResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As MAvhaService.SaveResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As MAvhaService.SaveResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class SaveResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits MAvhaService.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of MAvhaService.ServiceSoap)
        Implements MAvhaService.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MAvhaService_ServiceSoap_List(ByVal request As MAvhaService.ListRequest) As MAvhaService.ListResponse Implements MAvhaService.ServiceSoap.List
            Return MyBase.Channel.List(request)
        End Function
        
        Public Function List() As MAvhaService.Person()
            Dim inValue As MAvhaService.ListRequest = New MAvhaService.ListRequest()
            inValue.Body = New MAvhaService.ListRequestBody()
            Dim retVal As MAvhaService.ListResponse = CType(Me,MAvhaService.ServiceSoap).List(inValue)
            Return retVal.Body.ListResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MAvhaService_ServiceSoap_ListJson(ByVal request As MAvhaService.ListJsonRequest) As MAvhaService.ListJsonResponse Implements MAvhaService.ServiceSoap.ListJson
            Return MyBase.Channel.ListJson(request)
        End Function
        
        Public Function ListJson() As String
            Dim inValue As MAvhaService.ListJsonRequest = New MAvhaService.ListJsonRequest()
            inValue.Body = New MAvhaService.ListJsonRequestBody()
            Dim retVal As MAvhaService.ListJsonResponse = CType(Me,MAvhaService.ServiceSoap).ListJson(inValue)
            Return retVal.Body.ListJsonResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MAvhaService_ServiceSoap_Save(ByVal request As MAvhaService.SaveRequest) As MAvhaService.SaveResponse Implements MAvhaService.ServiceSoap.Save
            Return MyBase.Channel.Save(request)
        End Function
        
        Public Sub Save(ByVal person As MAvhaService.Person)
            Dim inValue As MAvhaService.SaveRequest = New MAvhaService.SaveRequest()
            inValue.Body = New MAvhaService.SaveRequestBody()
            inValue.Body.person = person
            Dim retVal As MAvhaService.SaveResponse = CType(Me,MAvhaService.ServiceSoap).Save(inValue)
        End Sub
        
        Public Sub Delete(ByVal id As Integer) Implements MAvhaService.ServiceSoap.Delete
            MyBase.Channel.Delete(id)
        End Sub
    End Class
End Namespace
