'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.40120.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



Public Class MySettings
    Inherits System.Configuration.ApplicationSettingsBase
    
    Private Shared mm_DefaultInstance As MySettings

    Private Shared mm_SyncObject As Object = New Object

    Public Shared ReadOnly Property DefaultInstance() As MySettings
        Get
            If (MySettings.mm_DefaultInstance Is Nothing) Then
                System.Threading.Monitor.Enter(MySettings.mm_SyncObject)
                If (MySettings.mm_DefaultInstance Is Nothing) Then
                    Try
                        MySettings.mm_DefaultInstance = New MySettings
                    Finally
                        System.Threading.Monitor.Exit(MySettings.mm_SyncObject)
                    End Try
                End If
            End If
            Return MySettings.mm_DefaultInstance
        End Get
    End Property
End Class
