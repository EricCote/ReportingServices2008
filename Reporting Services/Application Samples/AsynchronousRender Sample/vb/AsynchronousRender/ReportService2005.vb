Namespace ReportService2005
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ReportingService2005Soap", [Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(DataSourceDefinitionOrReference)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ExpirationDefinition)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(RecurrencePattern)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ScheduleDefinitionOrReference))>  _
    Partial Public Class ReportingService2005
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private serverInfoHeaderValueField As ServerInfoHeader
        
        Private ListSecureMethodsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateBatchOperationCompleted As System.Threading.SendOrPostCallback
        
        Private batchHeaderValueField As BatchHeader
        
        Private CancelBatchOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ExecuteBatchOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetSystemPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetSystemPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DeleteItemOperationCompleted As System.Threading.SendOrPostCallback
        
        Private MoveItemOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListChildrenOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListDependentItemsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private itemNamespaceHeaderValueField As ItemNamespaceHeader
        
        Private GetPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetItemTypeOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateFolderOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateReportOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetReportDefinitionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetReportDefinitionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateResourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetResourceContentsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetResourceContentsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetReportParametersOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetReportParametersOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateLinkedReportOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetReportLinkOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetReportLinkOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetRenderResourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetExecutionOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetExecutionOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetCacheOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetCacheOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UpdateReportExecutionSnapshotOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FlushCacheOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListJobsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CancelJobOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateDataSourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetDataSourceContentsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetDataSourceContentsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private EnableDataSourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DisableDataSourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetItemDataSourcesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetItemDataSourcesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetItemDataSourcePromptsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateReportHistorySnapshotOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetReportHistoryOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetReportHistoryOptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetReportHistoryLimitOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetReportHistoryLimitOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListReportHistoryOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DeleteReportHistorySnapshotOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FindItemsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateScheduleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DeleteScheduleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetSchedulePropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetSchedulePropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListScheduledReportsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListSchedulesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private PauseScheduleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ResumeScheduleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateSubscriptionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateDataDrivenSubscriptionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetSubscriptionPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetDataDrivenSubscriptionPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetSubscriptionPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetDataDrivenSubscriptionPropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DeleteSubscriptionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private PrepareQueryOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetExtensionSettingsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ValidateExtensionSettingsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListSubscriptionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListSubscriptionsUsingDataSourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListExtensionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListEventsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private FireEventOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListTasksOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListRolesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateRoleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DeleteRoleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetRolePropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetRolePropertiesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetSystemPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetSystemPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private InheritParentSecurityOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetSystemPermissionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetPermissionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private LogonUserOperationCompleted As System.Threading.SendOrPostCallback
        
        Private LogoffOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CreateModelOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetModelDefinitionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetModelDefinitionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListModelPerspectivesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetUserModelOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListModelItemChildrenOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetModelItemPermissionsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetModelItemPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetModelItemPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private InheritModelItemParentSecurityOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RemoveAllModelItemPoliciesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SetModelDrillthroughReportsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListModelDrillthroughReportsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GenerateModelOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RegenerateModelOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = True
                Me.useDefaultCredentialsSetExplicitly = False
            Else
                Me.useDefaultCredentialsSetExplicitly = True
            End If
        End Sub
        
        Public Property ServerInfoHeaderValue() As ServerInfoHeader
            Get
                Return Me.serverInfoHeaderValueField
            End Get
            Set
                Me.serverInfoHeaderValueField = value
            End Set
        End Property
        
        Public Property BatchHeaderValue() As BatchHeader
            Get
                Return Me.batchHeaderValueField
            End Get
            Set
                Me.batchHeaderValueField = value
            End Set
        End Property
        
        Public Property ItemNamespaceHeaderValue() As ItemNamespaceHeader
            Get
                Return Me.itemNamespaceHeaderValueField
            End Get
            Set
                Me.itemNamespaceHeaderValueField = value
            End Set
        End Property
        
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")> Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set(ByVal value As String)
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) _
                            AndAlso (Me.IsLocalFileSystemWebService(Value) = False)) Then
                    MyBase.UseDefaultCredentials = False
                End If
                MyBase.Url = Value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event ListSecureMethodsCompleted As ListSecureMethodsCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateBatchCompleted As CreateBatchCompletedEventHandler
        
        '''<remarks/>
        Public Event CancelBatchCompleted As CancelBatchCompletedEventHandler
        
        '''<remarks/>
        Public Event ExecuteBatchCompleted As ExecuteBatchCompletedEventHandler
        
        '''<remarks/>
        Public Event GetSystemPropertiesCompleted As GetSystemPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetSystemPropertiesCompleted As SetSystemPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event DeleteItemCompleted As DeleteItemCompletedEventHandler
        
        '''<remarks/>
        Public Event MoveItemCompleted As MoveItemCompletedEventHandler
        
        '''<remarks/>
        Public Event ListChildrenCompleted As ListChildrenCompletedEventHandler
        
        '''<remarks/>
        Public Event ListDependentItemsCompleted As ListDependentItemsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetPropertiesCompleted As GetPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetPropertiesCompleted As SetPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetItemTypeCompleted As GetItemTypeCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateFolderCompleted As CreateFolderCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateReportCompleted As CreateReportCompletedEventHandler
        
        '''<remarks/>
        Public Event GetReportDefinitionCompleted As GetReportDefinitionCompletedEventHandler
        
        '''<remarks/>
        Public Event SetReportDefinitionCompleted As SetReportDefinitionCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateResourceCompleted As CreateResourceCompletedEventHandler
        
        '''<remarks/>
        Public Event SetResourceContentsCompleted As SetResourceContentsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetResourceContentsCompleted As GetResourceContentsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetReportParametersCompleted As GetReportParametersCompletedEventHandler
        
        '''<remarks/>
        Public Event SetReportParametersCompleted As SetReportParametersCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateLinkedReportCompleted As CreateLinkedReportCompletedEventHandler
        
        '''<remarks/>
        Public Event GetReportLinkCompleted As GetReportLinkCompletedEventHandler
        
        '''<remarks/>
        Public Event SetReportLinkCompleted As SetReportLinkCompletedEventHandler
        
        '''<remarks/>
        Public Event GetRenderResourceCompleted As GetRenderResourceCompletedEventHandler
        
        '''<remarks/>
        Public Event SetExecutionOptionsCompleted As SetExecutionOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetExecutionOptionsCompleted As GetExecutionOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event SetCacheOptionsCompleted As SetCacheOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetCacheOptionsCompleted As GetCacheOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event UpdateReportExecutionSnapshotCompleted As UpdateReportExecutionSnapshotCompletedEventHandler
        
        '''<remarks/>
        Public Event FlushCacheCompleted As FlushCacheCompletedEventHandler
        
        '''<remarks/>
        Public Event ListJobsCompleted As ListJobsCompletedEventHandler
        
        '''<remarks/>
        Public Event CancelJobCompleted As CancelJobCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateDataSourceCompleted As CreateDataSourceCompletedEventHandler
        
        '''<remarks/>
        Public Event GetDataSourceContentsCompleted As GetDataSourceContentsCompletedEventHandler
        
        '''<remarks/>
        Public Event SetDataSourceContentsCompleted As SetDataSourceContentsCompletedEventHandler
        
        '''<remarks/>
        Public Event EnableDataSourceCompleted As EnableDataSourceCompletedEventHandler
        
        '''<remarks/>
        Public Event DisableDataSourceCompleted As DisableDataSourceCompletedEventHandler
        
        '''<remarks/>
        Public Event SetItemDataSourcesCompleted As SetItemDataSourcesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetItemDataSourcesCompleted As GetItemDataSourcesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetItemDataSourcePromptsCompleted As GetItemDataSourcePromptsCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateReportHistorySnapshotCompleted As CreateReportHistorySnapshotCompletedEventHandler
        
        '''<remarks/>
        Public Event SetReportHistoryOptionsCompleted As SetReportHistoryOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetReportHistoryOptionsCompleted As GetReportHistoryOptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event SetReportHistoryLimitCompleted As SetReportHistoryLimitCompletedEventHandler
        
        '''<remarks/>
        Public Event GetReportHistoryLimitCompleted As GetReportHistoryLimitCompletedEventHandler
        
        '''<remarks/>
        Public Event ListReportHistoryCompleted As ListReportHistoryCompletedEventHandler
        
        '''<remarks/>
        Public Event DeleteReportHistorySnapshotCompleted As DeleteReportHistorySnapshotCompletedEventHandler
        
        '''<remarks/>
        Public Event FindItemsCompleted As FindItemsCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateScheduleCompleted As CreateScheduleCompletedEventHandler
        
        '''<remarks/>
        Public Event DeleteScheduleCompleted As DeleteScheduleCompletedEventHandler
        
        '''<remarks/>
        Public Event SetSchedulePropertiesCompleted As SetSchedulePropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetSchedulePropertiesCompleted As GetSchedulePropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event ListScheduledReportsCompleted As ListScheduledReportsCompletedEventHandler
        
        '''<remarks/>
        Public Event ListSchedulesCompleted As ListSchedulesCompletedEventHandler
        
        '''<remarks/>
        Public Event PauseScheduleCompleted As PauseScheduleCompletedEventHandler
        
        '''<remarks/>
        Public Event ResumeScheduleCompleted As ResumeScheduleCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateSubscriptionCompleted As CreateSubscriptionCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateDataDrivenSubscriptionCompleted As CreateDataDrivenSubscriptionCompletedEventHandler
        
        '''<remarks/>
        Public Event SetSubscriptionPropertiesCompleted As SetSubscriptionPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetDataDrivenSubscriptionPropertiesCompleted As SetDataDrivenSubscriptionPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetSubscriptionPropertiesCompleted As GetSubscriptionPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetDataDrivenSubscriptionPropertiesCompleted As GetDataDrivenSubscriptionPropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event DeleteSubscriptionCompleted As DeleteSubscriptionCompletedEventHandler
        
        '''<remarks/>
        Public Event PrepareQueryCompleted As PrepareQueryCompletedEventHandler
        
        '''<remarks/>
        Public Event GetExtensionSettingsCompleted As GetExtensionSettingsCompletedEventHandler
        
        '''<remarks/>
        Public Event ValidateExtensionSettingsCompleted As ValidateExtensionSettingsCompletedEventHandler
        
        '''<remarks/>
        Public Event ListSubscriptionsCompleted As ListSubscriptionsCompletedEventHandler
        
        '''<remarks/>
        Public Event ListSubscriptionsUsingDataSourceCompleted As ListSubscriptionsUsingDataSourceCompletedEventHandler
        
        '''<remarks/>
        Public Event ListExtensionsCompleted As ListExtensionsCompletedEventHandler
        
        '''<remarks/>
        Public Event ListEventsCompleted As ListEventsCompletedEventHandler
        
        '''<remarks/>
        Public Event FireEventCompleted As FireEventCompletedEventHandler
        
        '''<remarks/>
        Public Event ListTasksCompleted As ListTasksCompletedEventHandler
        
        '''<remarks/>
        Public Event ListRolesCompleted As ListRolesCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateRoleCompleted As CreateRoleCompletedEventHandler
        
        '''<remarks/>
        Public Event DeleteRoleCompleted As DeleteRoleCompletedEventHandler
        
        '''<remarks/>
        Public Event GetRolePropertiesCompleted As GetRolePropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetRolePropertiesCompleted As SetRolePropertiesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetSystemPoliciesCompleted As GetSystemPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetSystemPoliciesCompleted As SetSystemPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetPoliciesCompleted As GetPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetPoliciesCompleted As SetPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event InheritParentSecurityCompleted As InheritParentSecurityCompletedEventHandler
        
        '''<remarks/>
        Public Event GetSystemPermissionsCompleted As GetSystemPermissionsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetPermissionsCompleted As GetPermissionsCompletedEventHandler
        
        '''<remarks/>
        Public Event LogonUserCompleted As LogonUserCompletedEventHandler
        
        '''<remarks/>
        Public Event LogoffCompleted As LogoffCompletedEventHandler
        
        '''<remarks/>
        Public Event CreateModelCompleted As CreateModelCompletedEventHandler
        
        '''<remarks/>
        Public Event GetModelDefinitionCompleted As GetModelDefinitionCompletedEventHandler
        
        '''<remarks/>
        Public Event SetModelDefinitionCompleted As SetModelDefinitionCompletedEventHandler
        
        '''<remarks/>
        Public Event ListModelPerspectivesCompleted As ListModelPerspectivesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetUserModelCompleted As GetUserModelCompletedEventHandler
        
        '''<remarks/>
        Public Event ListModelItemChildrenCompleted As ListModelItemChildrenCompletedEventHandler
        
        '''<remarks/>
        Public Event GetModelItemPermissionsCompleted As GetModelItemPermissionsCompletedEventHandler
        
        '''<remarks/>
        Public Event GetModelItemPoliciesCompleted As GetModelItemPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetModelItemPoliciesCompleted As SetModelItemPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event InheritModelItemParentSecurityCompleted As InheritModelItemParentSecurityCompletedEventHandler
        
        '''<remarks/>
        Public Event RemoveAllModelItemPoliciesCompleted As RemoveAllModelItemPoliciesCompletedEventHandler
        
        '''<remarks/>
        Public Event SetModelDrillthroughReportsCompleted As SetModelDrillthroughReportsCompletedEventHandler
        
        '''<remarks/>
        Public Event ListModelDrillthroughReportsCompleted As ListModelDrillthroughReportsCompletedEventHandler
        
        '''<remarks/>
        Public Event GenerateModelCompleted As GenerateModelCompletedEventHandler
        
        '''<remarks/>
        Public Event RegenerateModelCompleted As RegenerateModelCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tSecureMethods", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListSecureMethods() As String()
            Dim results() As Object = Me.Invoke("ListSecureMethods", New Object(-1) {})
            Return CType(results(0),String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListSecureMethodsAsync()
            Me.ListSecureMethodsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListSecureMethodsAsync(ByVal userState As Object)
            If (Me.ListSecureMethodsOperationCompleted Is Nothing) Then
                Me.ListSecureMethodsOperationCompleted = AddressOf Me.OnListSecureMethodsOperationCompleted
            End If
            Me.InvokeAsync("ListSecureMethods", New Object(-1) {}, Me.ListSecureMethodsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListSecureMethodsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListSecureMethodsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListSecureMethodsCompleted(Me, New ListSecureMethodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateBatch", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateBatch() As <System.Xml.Serialization.XmlElementAttribute("BatchID")> String
            Dim results() As Object = Me.Invoke("CreateBatch", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateBatchAsync()
            Me.CreateBatchAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateBatchAsync(ByVal userState As Object)
            If (Me.CreateBatchOperationCompleted Is Nothing) Then
                Me.CreateBatchOperationCompleted = AddressOf Me.OnCreateBatchOperationCompleted
            End If
            Me.InvokeAsync("CreateBatch", New Object(-1) {}, Me.CreateBatchOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateBatchOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateBatchCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateBatchCompleted(Me, New CreateBatchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Can"& _ 
            "celBatch", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CancelBatch()
            Me.Invoke("CancelBatch", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CancelBatchAsync()
            Me.CancelBatchAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CancelBatchAsync(ByVal userState As Object)
            If (Me.CancelBatchOperationCompleted Is Nothing) Then
                Me.CancelBatchOperationCompleted = AddressOf Me.OnCancelBatchOperationCompleted
            End If
            Me.InvokeAsync("CancelBatch", New Object(-1) {}, Me.CancelBatchOperationCompleted, userState)
        End Sub
        
        Private Sub OnCancelBatchOperationCompleted(ByVal arg As Object)
            If (Not (Me.CancelBatchCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CancelBatchCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Exe"& _ 
            "cuteBatch", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub ExecuteBatch()
            Me.Invoke("ExecuteBatch", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ExecuteBatchAsync()
            Me.ExecuteBatchAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ExecuteBatchAsync(ByVal userState As Object)
            If (Me.ExecuteBatchOperationCompleted Is Nothing) Then
                Me.ExecuteBatchOperationCompleted = AddressOf Me.OnExecuteBatchOperationCompleted
            End If
            Me.InvokeAsync("ExecuteBatch", New Object(-1) {}, Me.ExecuteBatchOperationCompleted, userState)
        End Sub
        
        Private Sub OnExecuteBatchOperationCompleted(ByVal arg As Object)
            If (Not (Me.ExecuteBatchCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ExecuteBatchCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "SystemProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetSystemProperties(ByVal Properties() As [Property]) As <System.Xml.Serialization.XmlArrayAttribute("Values")> [Property]()
            Dim results() As Object = Me.Invoke("GetSystemProperties", New Object() {Properties})
            Return CType(results(0),[Property]())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetSystemPropertiesAsync(ByVal Properties() As [Property])
            Me.GetSystemPropertiesAsync(Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetSystemPropertiesAsync(ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.GetSystemPropertiesOperationCompleted Is Nothing) Then
                Me.GetSystemPropertiesOperationCompleted = AddressOf Me.OnGetSystemPropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetSystemProperties", New Object() {Properties}, Me.GetSystemPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetSystemPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetSystemPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetSystemPropertiesCompleted(Me, New GetSystemPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "SystemProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetSystemProperties(ByVal Properties() As [Property])
            Me.Invoke("SetSystemProperties", New Object() {Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSystemPropertiesAsync(ByVal Properties() As [Property])
            Me.SetSystemPropertiesAsync(Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSystemPropertiesAsync(ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.SetSystemPropertiesOperationCompleted Is Nothing) Then
                Me.SetSystemPropertiesOperationCompleted = AddressOf Me.OnSetSystemPropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetSystemProperties", New Object() {Properties}, Me.SetSystemPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetSystemPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetSystemPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetSystemPropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del"& _ 
            "eteItem", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub DeleteItem(ByVal Item As String)
            Me.Invoke("DeleteItem", New Object() {Item})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteItemAsync(ByVal Item As String)
            Me.DeleteItemAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteItemAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.DeleteItemOperationCompleted Is Nothing) Then
                Me.DeleteItemOperationCompleted = AddressOf Me.OnDeleteItemOperationCompleted
            End If
            Me.InvokeAsync("DeleteItem", New Object() {Item}, Me.DeleteItemOperationCompleted, userState)
        End Sub
        
        Private Sub OnDeleteItemOperationCompleted(ByVal arg As Object)
            If (Not (Me.DeleteItemCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DeleteItemCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Mov"& _ 
            "eItem", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub MoveItem(ByVal Item As String, ByVal Target As String)
            Me.Invoke("MoveItem", New Object() {Item, Target})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub MoveItemAsync(ByVal Item As String, ByVal Target As String)
            Me.MoveItemAsync(Item, Target, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub MoveItemAsync(ByVal Item As String, ByVal Target As String, ByVal userState As Object)
            If (Me.MoveItemOperationCompleted Is Nothing) Then
                Me.MoveItemOperationCompleted = AddressOf Me.OnMoveItemOperationCompleted
            End If
            Me.InvokeAsync("MoveItem", New Object() {Item, Target}, Me.MoveItemOperationCompleted, userState)
        End Sub
        
        Private Sub OnMoveItemOperationCompleted(ByVal arg As Object)
            If (Not (Me.MoveItemCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent MoveItemCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tChildren", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListChildren(ByVal Item As String, ByVal Recursive As Boolean) As <System.Xml.Serialization.XmlArrayAttribute("CatalogItems")> CatalogItem()
            Dim results() As Object = Me.Invoke("ListChildren", New Object() {Item, Recursive})
            Return CType(results(0),CatalogItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListChildrenAsync(ByVal Item As String, ByVal Recursive As Boolean)
            Me.ListChildrenAsync(Item, Recursive, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListChildrenAsync(ByVal Item As String, ByVal Recursive As Boolean, ByVal userState As Object)
            If (Me.ListChildrenOperationCompleted Is Nothing) Then
                Me.ListChildrenOperationCompleted = AddressOf Me.OnListChildrenOperationCompleted
            End If
            Me.InvokeAsync("ListChildren", New Object() {Item, Recursive}, Me.ListChildrenOperationCompleted, userState)
        End Sub
        
        Private Sub OnListChildrenOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListChildrenCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListChildrenCompleted(Me, New ListChildrenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tDependentItems", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListDependentItems(ByVal Item As String) As <System.Xml.Serialization.XmlArrayAttribute("CatalogItems")> CatalogItem()
            Dim results() As Object = Me.Invoke("ListDependentItems", New Object() {Item})
            Return CType(results(0),CatalogItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListDependentItemsAsync(ByVal Item As String)
            Me.ListDependentItemsAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListDependentItemsAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.ListDependentItemsOperationCompleted Is Nothing) Then
                Me.ListDependentItemsOperationCompleted = AddressOf Me.OnListDependentItemsOperationCompleted
            End If
            Me.InvokeAsync("ListDependentItems", New Object() {Item}, Me.ListDependentItemsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListDependentItemsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListDependentItemsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListDependentItemsCompleted(Me, New ListDependentItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("ItemNamespaceHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "Properties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetProperties(ByVal Item As String, ByVal Properties() As [Property]) As <System.Xml.Serialization.XmlArrayAttribute("Values")> [Property]()
            Dim results() As Object = Me.Invoke("GetProperties", New Object() {Item, Properties})
            Return CType(results(0),[Property]())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetPropertiesAsync(ByVal Item As String, ByVal Properties() As [Property])
            Me.GetPropertiesAsync(Item, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetPropertiesAsync(ByVal Item As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.GetPropertiesOperationCompleted Is Nothing) Then
                Me.GetPropertiesOperationCompleted = AddressOf Me.OnGetPropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetProperties", New Object() {Item, Properties}, Me.GetPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetPropertiesCompleted(Me, New GetPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "Properties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetProperties(ByVal Item As String, ByVal Properties() As [Property])
            Me.Invoke("SetProperties", New Object() {Item, Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetPropertiesAsync(ByVal Item As String, ByVal Properties() As [Property])
            Me.SetPropertiesAsync(Item, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetPropertiesAsync(ByVal Item As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.SetPropertiesOperationCompleted Is Nothing) Then
                Me.SetPropertiesOperationCompleted = AddressOf Me.OnSetPropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetProperties", New Object() {Item, Properties}, Me.SetPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetPropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ItemType", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetItemType(ByVal Item As String) As <System.Xml.Serialization.XmlElementAttribute("Type")> ItemTypeEnum
            Dim results() As Object = Me.Invoke("GetItemType", New Object() {Item})
            Return CType(results(0),ItemTypeEnum)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetItemTypeAsync(ByVal Item As String)
            Me.GetItemTypeAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetItemTypeAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.GetItemTypeOperationCompleted Is Nothing) Then
                Me.GetItemTypeOperationCompleted = AddressOf Me.OnGetItemTypeOperationCompleted
            End If
            Me.InvokeAsync("GetItemType", New Object() {Item}, Me.GetItemTypeOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetItemTypeOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetItemTypeCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetItemTypeCompleted(Me, New GetItemTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateFolder", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateFolder(ByVal Folder As String, ByVal Parent As String, ByVal Properties() As [Property])
            Me.Invoke("CreateFolder", New Object() {Folder, Parent, Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateFolderAsync(ByVal Folder As String, ByVal Parent As String, ByVal Properties() As [Property])
            Me.CreateFolderAsync(Folder, Parent, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateFolderAsync(ByVal Folder As String, ByVal Parent As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateFolderOperationCompleted Is Nothing) Then
                Me.CreateFolderOperationCompleted = AddressOf Me.OnCreateFolderOperationCompleted
            End If
            Me.InvokeAsync("CreateFolder", New Object() {Folder, Parent, Properties}, Me.CreateFolderOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateFolderOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateFolderCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateFolderCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateReport", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateReport(ByVal Report As String, ByVal Parent As String, ByVal Overwrite As Boolean, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Definition() As Byte, ByVal Properties() As [Property]) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("CreateReport", New Object() {Report, Parent, Overwrite, Definition, Properties})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateReportAsync(ByVal Report As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Definition() As Byte, ByVal Properties() As [Property])
            Me.CreateReportAsync(Report, Parent, Overwrite, Definition, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateReportAsync(ByVal Report As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Definition() As Byte, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateReportOperationCompleted Is Nothing) Then
                Me.CreateReportOperationCompleted = AddressOf Me.OnCreateReportOperationCompleted
            End If
            Me.InvokeAsync("CreateReport", New Object() {Report, Parent, Overwrite, Definition, Properties}, Me.CreateReportOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateReportOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateReportCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateReportCompleted(Me, New CreateReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ReportDefinition", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetReportDefinition(ByVal Report As String) As <System.Xml.Serialization.XmlElementAttribute("Definition", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetReportDefinition", New Object() {Report})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetReportDefinitionAsync(ByVal Report As String)
            Me.GetReportDefinitionAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetReportDefinitionAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetReportDefinitionOperationCompleted Is Nothing) Then
                Me.GetReportDefinitionOperationCompleted = AddressOf Me.OnGetReportDefinitionOperationCompleted
            End If
            Me.InvokeAsync("GetReportDefinition", New Object() {Report}, Me.GetReportDefinitionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetReportDefinitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetReportDefinitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetReportDefinitionCompleted(Me, New GetReportDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ReportDefinition", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SetReportDefinition(ByVal Report As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Definition() As Byte) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("SetReportDefinition", New Object() {Report, Definition})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub SetReportDefinitionAsync(ByVal Report As String, ByVal Definition() As Byte)
            Me.SetReportDefinitionAsync(Report, Definition, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportDefinitionAsync(ByVal Report As String, ByVal Definition() As Byte, ByVal userState As Object)
            If (Me.SetReportDefinitionOperationCompleted Is Nothing) Then
                Me.SetReportDefinitionOperationCompleted = AddressOf Me.OnSetReportDefinitionOperationCompleted
            End If
            Me.InvokeAsync("SetReportDefinition", New Object() {Report, Definition}, Me.SetReportDefinitionOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetReportDefinitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetReportDefinitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetReportDefinitionCompleted(Me, New SetReportDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateResource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateResource(ByVal Resource As String, ByVal Parent As String, ByVal Overwrite As Boolean, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Contents() As Byte, ByVal MimeType As String, ByVal Properties() As [Property])
            Me.Invoke("CreateResource", New Object() {Resource, Parent, Overwrite, Contents, MimeType, Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateResourceAsync(ByVal Resource As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Contents() As Byte, ByVal MimeType As String, ByVal Properties() As [Property])
            Me.CreateResourceAsync(Resource, Parent, Overwrite, Contents, MimeType, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateResourceAsync(ByVal Resource As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Contents() As Byte, ByVal MimeType As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateResourceOperationCompleted Is Nothing) Then
                Me.CreateResourceOperationCompleted = AddressOf Me.OnCreateResourceOperationCompleted
            End If
            Me.InvokeAsync("CreateResource", New Object() {Resource, Parent, Overwrite, Contents, MimeType, Properties}, Me.CreateResourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateResourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateResourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateResourceCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ResourceContents", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetResourceContents(ByVal Resource As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Contents() As Byte, ByVal MimeType As String)
            Me.Invoke("SetResourceContents", New Object() {Resource, Contents, MimeType})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetResourceContentsAsync(ByVal Resource As String, ByVal Contents() As Byte, ByVal MimeType As String)
            Me.SetResourceContentsAsync(Resource, Contents, MimeType, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetResourceContentsAsync(ByVal Resource As String, ByVal Contents() As Byte, ByVal MimeType As String, ByVal userState As Object)
            If (Me.SetResourceContentsOperationCompleted Is Nothing) Then
                Me.SetResourceContentsOperationCompleted = AddressOf Me.OnSetResourceContentsOperationCompleted
            End If
            Me.InvokeAsync("SetResourceContents", New Object() {Resource, Contents, MimeType}, Me.SetResourceContentsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetResourceContentsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetResourceContentsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetResourceContentsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ResourceContents", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetResourceContents(ByVal Resource As String, ByRef MimeType As String) As <System.Xml.Serialization.XmlElementAttribute("Contents", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetResourceContents", New Object() {Resource})
            MimeType = CType(results(1), String)
            Return CType(results(0), Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetResourceContentsAsync(ByVal Resource As String)
            Me.GetResourceContentsAsync(Resource, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetResourceContentsAsync(ByVal Resource As String, ByVal userState As Object)
            If (Me.GetResourceContentsOperationCompleted Is Nothing) Then
                Me.GetResourceContentsOperationCompleted = AddressOf Me.OnGetResourceContentsOperationCompleted
            End If
            Me.InvokeAsync("GetResourceContents", New Object() {Resource}, Me.GetResourceContentsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetResourceContentsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetResourceContentsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetResourceContentsCompleted(Me, New GetResourceContentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ReportParameters", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetReportParameters(ByVal Report As String, ByVal HistoryID As String, ByVal ForRendering As Boolean, ByVal Values() As ParameterValue, ByVal Credentials() As DataSourceCredentials) As <System.Xml.Serialization.XmlArrayAttribute("Parameters")> ReportParameter()
            Dim results() As Object = Me.Invoke("GetReportParameters", New Object() {Report, HistoryID, ForRendering, Values, Credentials})
            Return CType(results(0), ReportParameter())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetReportParametersAsync(ByVal Report As String, ByVal HistoryID As String, ByVal ForRendering As Boolean, ByVal Values() As ParameterValue, ByVal Credentials() As DataSourceCredentials)
            Me.GetReportParametersAsync(Report, HistoryID, ForRendering, Values, Credentials, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetReportParametersAsync(ByVal Report As String, ByVal HistoryID As String, ByVal ForRendering As Boolean, ByVal Values() As ParameterValue, ByVal Credentials() As DataSourceCredentials, ByVal userState As Object)
            If (Me.GetReportParametersOperationCompleted Is Nothing) Then
                Me.GetReportParametersOperationCompleted = AddressOf Me.OnGetReportParametersOperationCompleted
            End If
            Me.InvokeAsync("GetReportParameters", New Object() {Report, HistoryID, ForRendering, Values, Credentials}, Me.GetReportParametersOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetReportParametersOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetReportParametersCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetReportParametersCompleted(Me, New GetReportParametersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ReportParameters", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetReportParameters(ByVal Report As String, ByVal Parameters() As ReportParameter)
            Me.Invoke("SetReportParameters", New Object() {Report, Parameters})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportParametersAsync(ByVal Report As String, ByVal Parameters() As ReportParameter)
            Me.SetReportParametersAsync(Report, Parameters, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportParametersAsync(ByVal Report As String, ByVal Parameters() As ReportParameter, ByVal userState As Object)
            If (Me.SetReportParametersOperationCompleted Is Nothing) Then
                Me.SetReportParametersOperationCompleted = AddressOf Me.OnSetReportParametersOperationCompleted
            End If
            Me.InvokeAsync("SetReportParameters", New Object() {Report, Parameters}, Me.SetReportParametersOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetReportParametersOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetReportParametersCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetReportParametersCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateLinkedReport", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateLinkedReport(ByVal Report As String, ByVal Parent As String, ByVal Link As String, ByVal Properties() As [Property])
            Me.Invoke("CreateLinkedReport", New Object() {Report, Parent, Link, Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateLinkedReportAsync(ByVal Report As String, ByVal Parent As String, ByVal Link As String, ByVal Properties() As [Property])
            Me.CreateLinkedReportAsync(Report, Parent, Link, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateLinkedReportAsync(ByVal Report As String, ByVal Parent As String, ByVal Link As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateLinkedReportOperationCompleted Is Nothing) Then
                Me.CreateLinkedReportOperationCompleted = AddressOf Me.OnCreateLinkedReportOperationCompleted
            End If
            Me.InvokeAsync("CreateLinkedReport", New Object() {Report, Parent, Link, Properties}, Me.CreateLinkedReportOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateLinkedReportOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateLinkedReportCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateLinkedReportCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ReportLink", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetReportLink(ByVal Report As String) As <System.Xml.Serialization.XmlElementAttribute("Link")> String
            Dim results() As Object = Me.Invoke("GetReportLink", New Object() {Report})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetReportLinkAsync(ByVal Report As String)
            Me.GetReportLinkAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetReportLinkAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetReportLinkOperationCompleted Is Nothing) Then
                Me.GetReportLinkOperationCompleted = AddressOf Me.OnGetReportLinkOperationCompleted
            End If
            Me.InvokeAsync("GetReportLink", New Object() {Report}, Me.GetReportLinkOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetReportLinkOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetReportLinkCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetReportLinkCompleted(Me, New GetReportLinkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ReportLink", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetReportLink(ByVal Report As String, ByVal Link As String)
            Me.Invoke("SetReportLink", New Object() {Report, Link})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportLinkAsync(ByVal Report As String, ByVal Link As String)
            Me.SetReportLinkAsync(Report, Link, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportLinkAsync(ByVal Report As String, ByVal Link As String, ByVal userState As Object)
            If (Me.SetReportLinkOperationCompleted Is Nothing) Then
                Me.SetReportLinkOperationCompleted = AddressOf Me.OnSetReportLinkOperationCompleted
            End If
            Me.InvokeAsync("SetReportLink", New Object() {Report, Link}, Me.SetReportLinkOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetReportLinkOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetReportLinkCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetReportLinkCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "RenderResource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetRenderResource(ByVal Format As String, ByVal DeviceInfo As String, ByRef MimeType As String) As <System.Xml.Serialization.XmlElementAttribute("Result", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetRenderResource", New Object() {Format, DeviceInfo})
            MimeType = CType(results(1), String)
            Return CType(results(0), Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetRenderResourceAsync(ByVal Format As String, ByVal DeviceInfo As String)
            Me.GetRenderResourceAsync(Format, DeviceInfo, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetRenderResourceAsync(ByVal Format As String, ByVal DeviceInfo As String, ByVal userState As Object)
            If (Me.GetRenderResourceOperationCompleted Is Nothing) Then
                Me.GetRenderResourceOperationCompleted = AddressOf Me.OnGetRenderResourceOperationCompleted
            End If
            Me.InvokeAsync("GetRenderResource", New Object() {Format, DeviceInfo}, Me.GetRenderResourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetRenderResourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetRenderResourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetRenderResourceCompleted(Me, New GetRenderResourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ExecutionOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetExecutionOptions(ByVal Report As String, ByVal ExecutionSetting As ExecutionSettingEnum, <System.Xml.Serialization.XmlElementAttribute("ScheduleReference", GetType(ScheduleReference)), System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", GetType(ScheduleDefinition)), System.Xml.Serialization.XmlElementAttribute("NoSchedule", GetType(NoSchedule))> ByVal Item As ScheduleDefinitionOrReference)
            Me.Invoke("SetExecutionOptions", New Object() {Report, ExecutionSetting, Item})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetExecutionOptionsAsync(ByVal Report As String, ByVal ExecutionSetting As ExecutionSettingEnum, ByVal Item As ScheduleDefinitionOrReference)
            Me.SetExecutionOptionsAsync(Report, ExecutionSetting, Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetExecutionOptionsAsync(ByVal Report As String, ByVal ExecutionSetting As ExecutionSettingEnum, ByVal Item As ScheduleDefinitionOrReference, ByVal userState As Object)
            If (Me.SetExecutionOptionsOperationCompleted Is Nothing) Then
                Me.SetExecutionOptionsOperationCompleted = AddressOf Me.OnSetExecutionOptionsOperationCompleted
            End If
            Me.InvokeAsync("SetExecutionOptions", New Object() {Report, ExecutionSetting, Item}, Me.SetExecutionOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetExecutionOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetExecutionOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetExecutionOptionsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ExecutionOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetExecutionOptions(ByVal Report As String, <System.Xml.Serialization.XmlElementAttribute("ScheduleReference", GetType(ScheduleReference)), System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", GetType(ScheduleDefinition)), System.Xml.Serialization.XmlElementAttribute("NoSchedule", GetType(NoSchedule))> ByRef Item As ScheduleDefinitionOrReference) As <System.Xml.Serialization.XmlElementAttribute("ExecutionSetting")> ExecutionSettingEnum
            Dim results() As Object = Me.Invoke("GetExecutionOptions", New Object() {Report})
            Item = CType(results(1), ScheduleDefinitionOrReference)
            Return CType(results(0), ExecutionSettingEnum)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetExecutionOptionsAsync(ByVal Report As String)
            Me.GetExecutionOptionsAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetExecutionOptionsAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetExecutionOptionsOperationCompleted Is Nothing) Then
                Me.GetExecutionOptionsOperationCompleted = AddressOf Me.OnGetExecutionOptionsOperationCompleted
            End If
            Me.InvokeAsync("GetExecutionOptions", New Object() {Report}, Me.GetExecutionOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetExecutionOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetExecutionOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetExecutionOptionsCompleted(Me, New GetExecutionOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "CacheOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetCacheOptions(ByVal Report As String, ByVal CacheReport As Boolean, <System.Xml.Serialization.XmlElementAttribute("TimeExpiration", GetType(TimeExpiration)), System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", GetType(ScheduleExpiration))> ByVal Item As ExpirationDefinition)
            Me.Invoke("SetCacheOptions", New Object() {Report, CacheReport, Item})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetCacheOptionsAsync(ByVal Report As String, ByVal CacheReport As Boolean, ByVal Item As ExpirationDefinition)
            Me.SetCacheOptionsAsync(Report, CacheReport, Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetCacheOptionsAsync(ByVal Report As String, ByVal CacheReport As Boolean, ByVal Item As ExpirationDefinition, ByVal userState As Object)
            If (Me.SetCacheOptionsOperationCompleted Is Nothing) Then
                Me.SetCacheOptionsOperationCompleted = AddressOf Me.OnSetCacheOptionsOperationCompleted
            End If
            Me.InvokeAsync("SetCacheOptions", New Object() {Report, CacheReport, Item}, Me.SetCacheOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetCacheOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetCacheOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetCacheOptionsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "CacheOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetCacheOptions(ByVal Report As String, <System.Xml.Serialization.XmlElementAttribute("TimeExpiration", GetType(TimeExpiration)), System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", GetType(ScheduleExpiration))> ByRef Item As ExpirationDefinition) As <System.Xml.Serialization.XmlElementAttribute("CacheReport")> Boolean
            Dim results() As Object = Me.Invoke("GetCacheOptions", New Object() {Report})
            Item = CType(results(1), ExpirationDefinition)
            Return CType(results(0), Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetCacheOptionsAsync(ByVal Report As String)
            Me.GetCacheOptionsAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetCacheOptionsAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetCacheOptionsOperationCompleted Is Nothing) Then
                Me.GetCacheOptionsOperationCompleted = AddressOf Me.OnGetCacheOptionsOperationCompleted
            End If
            Me.InvokeAsync("GetCacheOptions", New Object() {Report}, Me.GetCacheOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetCacheOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetCacheOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetCacheOptionsCompleted(Me, New GetCacheOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Upd"& _ 
            "ateReportExecutionSnapshot", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub UpdateReportExecutionSnapshot(ByVal Report As String)
            Me.Invoke("UpdateReportExecutionSnapshot", New Object() {Report})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateReportExecutionSnapshotAsync(ByVal Report As String)
            Me.UpdateReportExecutionSnapshotAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateReportExecutionSnapshotAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.UpdateReportExecutionSnapshotOperationCompleted Is Nothing) Then
                Me.UpdateReportExecutionSnapshotOperationCompleted = AddressOf Me.OnUpdateReportExecutionSnapshotOperationCompleted
            End If
            Me.InvokeAsync("UpdateReportExecutionSnapshot", New Object() {Report}, Me.UpdateReportExecutionSnapshotOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdateReportExecutionSnapshotOperationCompleted(ByVal arg As Object)
            If (Not (Me.UpdateReportExecutionSnapshotCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UpdateReportExecutionSnapshotCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Flu"& _ 
            "shCache", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub FlushCache(ByVal Report As String)
            Me.Invoke("FlushCache", New Object() {Report})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlushCacheAsync(ByVal Report As String)
            Me.FlushCacheAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FlushCacheAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.FlushCacheOperationCompleted Is Nothing) Then
                Me.FlushCacheOperationCompleted = AddressOf Me.OnFlushCacheOperationCompleted
            End If
            Me.InvokeAsync("FlushCache", New Object() {Report}, Me.FlushCacheOperationCompleted, userState)
        End Sub
        
        Private Sub OnFlushCacheOperationCompleted(ByVal arg As Object)
            If (Not (Me.FlushCacheCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FlushCacheCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tJobs", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListJobs() As <System.Xml.Serialization.XmlArrayAttribute("Jobs")> Job()
            Dim results() As Object = Me.Invoke("ListJobs", New Object(-1) {})
            Return CType(results(0),Job())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListJobsAsync()
            Me.ListJobsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListJobsAsync(ByVal userState As Object)
            If (Me.ListJobsOperationCompleted Is Nothing) Then
                Me.ListJobsOperationCompleted = AddressOf Me.OnListJobsOperationCompleted
            End If
            Me.InvokeAsync("ListJobs", New Object(-1) {}, Me.ListJobsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListJobsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListJobsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListJobsCompleted(Me, New ListJobsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Can" & _
            "celJob", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function CancelJob(ByVal JobID As String) As Boolean
            Dim results() As Object = Me.Invoke("CancelJob", New Object() {JobID})
            Return CType(results(0), Boolean)
        End Function
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub CancelJobAsync(ByVal JobID As String)
            Me.CancelJobAsync(JobID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CancelJobAsync(ByVal JobID As String, ByVal userState As Object)
            If (Me.CancelJobOperationCompleted Is Nothing) Then
                Me.CancelJobOperationCompleted = AddressOf Me.OnCancelJobOperationCompleted
            End If
            Me.InvokeAsync("CancelJob", New Object() {JobID}, Me.CancelJobOperationCompleted, userState)
        End Sub
        
        Private Sub OnCancelJobOperationCompleted(ByVal arg As Object)
            If (Not (Me.CancelJobCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CancelJobCompleted(Me, New CancelJobCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateDataSource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateDataSource(ByVal DataSource As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Definition As DataSourceDefinition, ByVal Properties() As [Property])
            Me.Invoke("CreateDataSource", New Object() {DataSource, Parent, Overwrite, Definition, Properties})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateDataSourceAsync(ByVal DataSource As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Definition As DataSourceDefinition, ByVal Properties() As [Property])
            Me.CreateDataSourceAsync(DataSource, Parent, Overwrite, Definition, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateDataSourceAsync(ByVal DataSource As String, ByVal Parent As String, ByVal Overwrite As Boolean, ByVal Definition As DataSourceDefinition, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateDataSourceOperationCompleted Is Nothing) Then
                Me.CreateDataSourceOperationCompleted = AddressOf Me.OnCreateDataSourceOperationCompleted
            End If
            Me.InvokeAsync("CreateDataSource", New Object() {DataSource, Parent, Overwrite, Definition, Properties}, Me.CreateDataSourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateDataSourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateDataSourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateDataSourceCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "DataSourceContents", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetDataSourceContents(ByVal DataSource As String) As <System.Xml.Serialization.XmlElementAttribute("Definition")> DataSourceDefinition
            Dim results() As Object = Me.Invoke("GetDataSourceContents", New Object() {DataSource})
            Return CType(results(0),DataSourceDefinition)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetDataSourceContentsAsync(ByVal DataSource As String)
            Me.GetDataSourceContentsAsync(DataSource, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetDataSourceContentsAsync(ByVal DataSource As String, ByVal userState As Object)
            If (Me.GetDataSourceContentsOperationCompleted Is Nothing) Then
                Me.GetDataSourceContentsOperationCompleted = AddressOf Me.OnGetDataSourceContentsOperationCompleted
            End If
            Me.InvokeAsync("GetDataSourceContents", New Object() {DataSource}, Me.GetDataSourceContentsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetDataSourceContentsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetDataSourceContentsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetDataSourceContentsCompleted(Me, New GetDataSourceContentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "DataSourceContents", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetDataSourceContents(ByVal DataSource As String, ByVal Definition As DataSourceDefinition)
            Me.Invoke("SetDataSourceContents", New Object() {DataSource, Definition})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetDataSourceContentsAsync(ByVal DataSource As String, ByVal Definition As DataSourceDefinition)
            Me.SetDataSourceContentsAsync(DataSource, Definition, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetDataSourceContentsAsync(ByVal DataSource As String, ByVal Definition As DataSourceDefinition, ByVal userState As Object)
            If (Me.SetDataSourceContentsOperationCompleted Is Nothing) Then
                Me.SetDataSourceContentsOperationCompleted = AddressOf Me.OnSetDataSourceContentsOperationCompleted
            End If
            Me.InvokeAsync("SetDataSourceContents", New Object() {DataSource, Definition}, Me.SetDataSourceContentsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetDataSourceContentsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetDataSourceContentsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetDataSourceContentsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ena"& _ 
            "bleDataSource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub EnableDataSource(ByVal DataSource As String)
            Me.Invoke("EnableDataSource", New Object() {DataSource})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub EnableDataSourceAsync(ByVal DataSource As String)
            Me.EnableDataSourceAsync(DataSource, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub EnableDataSourceAsync(ByVal DataSource As String, ByVal userState As Object)
            If (Me.EnableDataSourceOperationCompleted Is Nothing) Then
                Me.EnableDataSourceOperationCompleted = AddressOf Me.OnEnableDataSourceOperationCompleted
            End If
            Me.InvokeAsync("EnableDataSource", New Object() {DataSource}, Me.EnableDataSourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnEnableDataSourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.EnableDataSourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent EnableDataSourceCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Dis"& _ 
            "ableDataSource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub DisableDataSource(ByVal DataSource As String)
            Me.Invoke("DisableDataSource", New Object() {DataSource})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DisableDataSourceAsync(ByVal DataSource As String)
            Me.DisableDataSourceAsync(DataSource, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DisableDataSourceAsync(ByVal DataSource As String, ByVal userState As Object)
            If (Me.DisableDataSourceOperationCompleted Is Nothing) Then
                Me.DisableDataSourceOperationCompleted = AddressOf Me.OnDisableDataSourceOperationCompleted
            End If
            Me.InvokeAsync("DisableDataSource", New Object() {DataSource}, Me.DisableDataSourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnDisableDataSourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.DisableDataSourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DisableDataSourceCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ItemDataSources", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetItemDataSources(ByVal Item As String, ByVal DataSources() As DataSource)
            Me.Invoke("SetItemDataSources", New Object() {Item, DataSources})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetItemDataSourcesAsync(ByVal Item As String, ByVal DataSources() As DataSource)
            Me.SetItemDataSourcesAsync(Item, DataSources, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetItemDataSourcesAsync(ByVal Item As String, ByVal DataSources() As DataSource, ByVal userState As Object)
            If (Me.SetItemDataSourcesOperationCompleted Is Nothing) Then
                Me.SetItemDataSourcesOperationCompleted = AddressOf Me.OnSetItemDataSourcesOperationCompleted
            End If
            Me.InvokeAsync("SetItemDataSources", New Object() {Item, DataSources}, Me.SetItemDataSourcesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetItemDataSourcesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetItemDataSourcesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetItemDataSourcesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ItemDataSources", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetItemDataSources(ByVal Item As String) As <System.Xml.Serialization.XmlArrayAttribute("DataSources")> DataSource()
            Dim results() As Object = Me.Invoke("GetItemDataSources", New Object() {Item})
            Return CType(results(0),DataSource())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetItemDataSourcesAsync(ByVal Item As String)
            Me.GetItemDataSourcesAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetItemDataSourcesAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.GetItemDataSourcesOperationCompleted Is Nothing) Then
                Me.GetItemDataSourcesOperationCompleted = AddressOf Me.OnGetItemDataSourcesOperationCompleted
            End If
            Me.InvokeAsync("GetItemDataSources", New Object() {Item}, Me.GetItemDataSourcesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetItemDataSourcesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetItemDataSourcesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetItemDataSourcesCompleted(Me, New GetItemDataSourcesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ItemDataSourcePrompts", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetItemDataSourcePrompts(ByVal Item As String) As <System.Xml.Serialization.XmlArrayAttribute("DataSourcePrompts")> DataSourcePrompt()
            Dim results() As Object = Me.Invoke("GetItemDataSourcePrompts", New Object() {Item})
            Return CType(results(0),DataSourcePrompt())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetItemDataSourcePromptsAsync(ByVal Item As String)
            Me.GetItemDataSourcePromptsAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetItemDataSourcePromptsAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.GetItemDataSourcePromptsOperationCompleted Is Nothing) Then
                Me.GetItemDataSourcePromptsOperationCompleted = AddressOf Me.OnGetItemDataSourcePromptsOperationCompleted
            End If
            Me.InvokeAsync("GetItemDataSourcePrompts", New Object() {Item}, Me.GetItemDataSourcePromptsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetItemDataSourcePromptsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetItemDataSourcePromptsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetItemDataSourcePromptsCompleted(Me, New GetItemDataSourcePromptsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" & _
            "ateReportHistorySnapshot", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function CreateReportHistorySnapshot(ByVal Report As String, ByRef Warnings() As Warning) As <System.Xml.Serialization.XmlElementAttribute("HistoryID")> String
            Dim results() As Object = Me.Invoke("CreateReportHistorySnapshot", New Object() {Report})
            Warnings = CType(results(1), Warning())
            Return CType(results(0), String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateReportHistorySnapshotAsync(ByVal Report As String)
            Me.CreateReportHistorySnapshotAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateReportHistorySnapshotAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.CreateReportHistorySnapshotOperationCompleted Is Nothing) Then
                Me.CreateReportHistorySnapshotOperationCompleted = AddressOf Me.OnCreateReportHistorySnapshotOperationCompleted
            End If
            Me.InvokeAsync("CreateReportHistorySnapshot", New Object() {Report}, Me.CreateReportHistorySnapshotOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateReportHistorySnapshotOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateReportHistorySnapshotCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateReportHistorySnapshotCompleted(Me, New CreateReportHistorySnapshotCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ReportHistoryOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetReportHistoryOptions(ByVal Report As String, ByVal EnableManualSnapshotCreation As Boolean, ByVal KeepExecutionSnapshots As Boolean, <System.Xml.Serialization.XmlElementAttribute("ScheduleReference", GetType(ScheduleReference)), System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", GetType(ScheduleDefinition)), System.Xml.Serialization.XmlElementAttribute("NoSchedule", GetType(NoSchedule))> ByVal Item As ScheduleDefinitionOrReference)
            Me.Invoke("SetReportHistoryOptions", New Object() {Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportHistoryOptionsAsync(ByVal Report As String, ByVal EnableManualSnapshotCreation As Boolean, ByVal KeepExecutionSnapshots As Boolean, ByVal Item As ScheduleDefinitionOrReference)
            Me.SetReportHistoryOptionsAsync(Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportHistoryOptionsAsync(ByVal Report As String, ByVal EnableManualSnapshotCreation As Boolean, ByVal KeepExecutionSnapshots As Boolean, ByVal Item As ScheduleDefinitionOrReference, ByVal userState As Object)
            If (Me.SetReportHistoryOptionsOperationCompleted Is Nothing) Then
                Me.SetReportHistoryOptionsOperationCompleted = AddressOf Me.OnSetReportHistoryOptionsOperationCompleted
            End If
            Me.InvokeAsync("SetReportHistoryOptions", New Object() {Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item}, Me.SetReportHistoryOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetReportHistoryOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetReportHistoryOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetReportHistoryOptionsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ReportHistoryOptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetReportHistoryOptions(ByVal Report As String, ByRef KeepExecutionSnapshots As Boolean, <System.Xml.Serialization.XmlElementAttribute("ScheduleReference", GetType(ScheduleReference)), System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", GetType(ScheduleDefinition)), System.Xml.Serialization.XmlElementAttribute("NoSchedule", GetType(NoSchedule))> ByRef Item As ScheduleDefinitionOrReference) As <System.Xml.Serialization.XmlElementAttribute("EnableManualSnapshotCreation")> Boolean
            Dim results() As Object = Me.Invoke("GetReportHistoryOptions", New Object() {Report})
            KeepExecutionSnapshots = CType(results(1), Boolean)
            Item = CType(results(2), ScheduleDefinitionOrReference)
            Return CType(results(0), Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetReportHistoryOptionsAsync(ByVal Report As String)
            Me.GetReportHistoryOptionsAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetReportHistoryOptionsAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetReportHistoryOptionsOperationCompleted Is Nothing) Then
                Me.GetReportHistoryOptionsOperationCompleted = AddressOf Me.OnGetReportHistoryOptionsOperationCompleted
            End If
            Me.InvokeAsync("GetReportHistoryOptions", New Object() {Report}, Me.GetReportHistoryOptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetReportHistoryOptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetReportHistoryOptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetReportHistoryOptionsCompleted(Me, New GetReportHistoryOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ReportHistoryLimit", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetReportHistoryLimit(ByVal Report As String, ByVal UseSystem As Boolean, ByVal HistoryLimit As Integer)
            Me.Invoke("SetReportHistoryLimit", New Object() {Report, UseSystem, HistoryLimit})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportHistoryLimitAsync(ByVal Report As String, ByVal UseSystem As Boolean, ByVal HistoryLimit As Integer)
            Me.SetReportHistoryLimitAsync(Report, UseSystem, HistoryLimit, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetReportHistoryLimitAsync(ByVal Report As String, ByVal UseSystem As Boolean, ByVal HistoryLimit As Integer, ByVal userState As Object)
            If (Me.SetReportHistoryLimitOperationCompleted Is Nothing) Then
                Me.SetReportHistoryLimitOperationCompleted = AddressOf Me.OnSetReportHistoryLimitOperationCompleted
            End If
            Me.InvokeAsync("SetReportHistoryLimit", New Object() {Report, UseSystem, HistoryLimit}, Me.SetReportHistoryLimitOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetReportHistoryLimitOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetReportHistoryLimitCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetReportHistoryLimitCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ReportHistoryLimit", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetReportHistoryLimit(ByVal Report As String, ByRef IsSystem As Boolean, ByRef SystemLimit As Integer) As <System.Xml.Serialization.XmlElementAttribute("HistoryLimit")> Integer
            Dim results() As Object = Me.Invoke("GetReportHistoryLimit", New Object() {Report})
            IsSystem = CType(results(1),Boolean)
            SystemLimit = CType(results(2),Integer)
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetReportHistoryLimitAsync(ByVal Report As String)
            Me.GetReportHistoryLimitAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetReportHistoryLimitAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.GetReportHistoryLimitOperationCompleted Is Nothing) Then
                Me.GetReportHistoryLimitOperationCompleted = AddressOf Me.OnGetReportHistoryLimitOperationCompleted
            End If
            Me.InvokeAsync("GetReportHistoryLimit", New Object() {Report}, Me.GetReportHistoryLimitOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetReportHistoryLimitOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetReportHistoryLimitCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetReportHistoryLimitCompleted(Me, New GetReportHistoryLimitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tReportHistory", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListReportHistory(ByVal Report As String) As <System.Xml.Serialization.XmlArrayAttribute("ReportHistory")> ReportHistorySnapshot()
            Dim results() As Object = Me.Invoke("ListReportHistory", New Object() {Report})
            Return CType(results(0),ReportHistorySnapshot())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListReportHistoryAsync(ByVal Report As String)
            Me.ListReportHistoryAsync(Report, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListReportHistoryAsync(ByVal Report As String, ByVal userState As Object)
            If (Me.ListReportHistoryOperationCompleted Is Nothing) Then
                Me.ListReportHistoryOperationCompleted = AddressOf Me.OnListReportHistoryOperationCompleted
            End If
            Me.InvokeAsync("ListReportHistory", New Object() {Report}, Me.ListReportHistoryOperationCompleted, userState)
        End Sub
        
        Private Sub OnListReportHistoryOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListReportHistoryCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListReportHistoryCompleted(Me, New ListReportHistoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" & _
            "eteReportHistorySnapshot", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub DeleteReportHistorySnapshot(ByVal Report As String, ByVal HistoryID As String)
            Me.Invoke("DeleteReportHistorySnapshot", New Object() {Report, HistoryID})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteReportHistorySnapshotAsync(ByVal Report As String, ByVal HistoryID As String)
            Me.DeleteReportHistorySnapshotAsync(Report, HistoryID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteReportHistorySnapshotAsync(ByVal Report As String, ByVal HistoryID As String, ByVal userState As Object)
            If (Me.DeleteReportHistorySnapshotOperationCompleted Is Nothing) Then
                Me.DeleteReportHistorySnapshotOperationCompleted = AddressOf Me.OnDeleteReportHistorySnapshotOperationCompleted
            End If
            Me.InvokeAsync("DeleteReportHistorySnapshot", New Object() {Report, HistoryID}, Me.DeleteReportHistorySnapshotOperationCompleted, userState)
        End Sub
        
        Private Sub OnDeleteReportHistorySnapshotOperationCompleted(ByVal arg As Object)
            If (Not (Me.DeleteReportHistorySnapshotCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DeleteReportHistorySnapshotCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fin"& _ 
            "dItems", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function FindItems(ByVal Folder As String, ByVal BooleanOperator As BooleanOperatorEnum, ByVal Conditions() As SearchCondition) As <System.Xml.Serialization.XmlArrayAttribute("Items")> CatalogItem()
            Dim results() As Object = Me.Invoke("FindItems", New Object() {Folder, BooleanOperator, Conditions})
            Return CType(results(0),CatalogItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub FindItemsAsync(ByVal Folder As String, ByVal BooleanOperator As BooleanOperatorEnum, ByVal Conditions() As SearchCondition)
            Me.FindItemsAsync(Folder, BooleanOperator, Conditions, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FindItemsAsync(ByVal Folder As String, ByVal BooleanOperator As BooleanOperatorEnum, ByVal Conditions() As SearchCondition, ByVal userState As Object)
            If (Me.FindItemsOperationCompleted Is Nothing) Then
                Me.FindItemsOperationCompleted = AddressOf Me.OnFindItemsOperationCompleted
            End If
            Me.InvokeAsync("FindItems", New Object() {Folder, BooleanOperator, Conditions}, Me.FindItemsOperationCompleted, userState)
        End Sub
        
        Private Sub OnFindItemsOperationCompleted(ByVal arg As Object)
            If (Not (Me.FindItemsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FindItemsCompleted(Me, New FindItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateSchedule", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateSchedule(ByVal Name As String, ByVal ScheduleDefinition As ScheduleDefinition) As <System.Xml.Serialization.XmlElementAttribute("ScheduleID")> String
            Dim results() As Object = Me.Invoke("CreateSchedule", New Object() {Name, ScheduleDefinition})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateScheduleAsync(ByVal Name As String, ByVal ScheduleDefinition As ScheduleDefinition)
            Me.CreateScheduleAsync(Name, ScheduleDefinition, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateScheduleAsync(ByVal Name As String, ByVal ScheduleDefinition As ScheduleDefinition, ByVal userState As Object)
            If (Me.CreateScheduleOperationCompleted Is Nothing) Then
                Me.CreateScheduleOperationCompleted = AddressOf Me.OnCreateScheduleOperationCompleted
            End If
            Me.InvokeAsync("CreateSchedule", New Object() {Name, ScheduleDefinition}, Me.CreateScheduleOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateScheduleOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateScheduleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateScheduleCompleted(Me, New CreateScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" & _
            "eteSchedule", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub DeleteSchedule(ByVal ScheduleID As String)
            Me.Invoke("DeleteSchedule", New Object() {ScheduleID})
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub DeleteScheduleAsync(ByVal ScheduleID As String)
            Me.DeleteScheduleAsync(ScheduleID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteScheduleAsync(ByVal ScheduleID As String, ByVal userState As Object)
            If (Me.DeleteScheduleOperationCompleted Is Nothing) Then
                Me.DeleteScheduleOperationCompleted = AddressOf Me.OnDeleteScheduleOperationCompleted
            End If
            Me.InvokeAsync("DeleteSchedule", New Object() {ScheduleID}, Me.DeleteScheduleOperationCompleted, userState)
        End Sub
        
        Private Sub OnDeleteScheduleOperationCompleted(ByVal arg As Object)
            If (Not (Me.DeleteScheduleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DeleteScheduleCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "ScheduleProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetScheduleProperties(ByVal Name As String, ByVal ScheduleID As String, ByVal ScheduleDefinition As ScheduleDefinition)
            Me.Invoke("SetScheduleProperties", New Object() {Name, ScheduleID, ScheduleDefinition})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSchedulePropertiesAsync(ByVal Name As String, ByVal ScheduleID As String, ByVal ScheduleDefinition As ScheduleDefinition)
            Me.SetSchedulePropertiesAsync(Name, ScheduleID, ScheduleDefinition, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSchedulePropertiesAsync(ByVal Name As String, ByVal ScheduleID As String, ByVal ScheduleDefinition As ScheduleDefinition, ByVal userState As Object)
            If (Me.SetSchedulePropertiesOperationCompleted Is Nothing) Then
                Me.SetSchedulePropertiesOperationCompleted = AddressOf Me.OnSetSchedulePropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetScheduleProperties", New Object() {Name, ScheduleID, ScheduleDefinition}, Me.SetSchedulePropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetSchedulePropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetSchedulePropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetSchedulePropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ScheduleProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetScheduleProperties(ByVal ScheduleID As String) As <System.Xml.Serialization.XmlElementAttribute("Schedule")> Schedule
            Dim results() As Object = Me.Invoke("GetScheduleProperties", New Object() {ScheduleID})
            Return CType(results(0), Schedule)
        End Function
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub GetSchedulePropertiesAsync(ByVal ScheduleID As String)
            Me.GetSchedulePropertiesAsync(ScheduleID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetSchedulePropertiesAsync(ByVal ScheduleID As String, ByVal userState As Object)
            If (Me.GetSchedulePropertiesOperationCompleted Is Nothing) Then
                Me.GetSchedulePropertiesOperationCompleted = AddressOf Me.OnGetSchedulePropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetScheduleProperties", New Object() {ScheduleID}, Me.GetSchedulePropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetSchedulePropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetSchedulePropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetSchedulePropertiesCompleted(Me, New GetSchedulePropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" & _
            "tScheduledReports", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListScheduledReports(ByVal ScheduleID As String) As <System.Xml.Serialization.XmlArrayAttribute("Reports")> CatalogItem()
            Dim results() As Object = Me.Invoke("ListScheduledReports", New Object() {ScheduleID})
            Return CType(results(0), CatalogItem())
        End Function
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub ListScheduledReportsAsync(ByVal ScheduleID As String)
            Me.ListScheduledReportsAsync(ScheduleID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListScheduledReportsAsync(ByVal ScheduleID As String, ByVal userState As Object)
            If (Me.ListScheduledReportsOperationCompleted Is Nothing) Then
                Me.ListScheduledReportsOperationCompleted = AddressOf Me.OnListScheduledReportsOperationCompleted
            End If
            Me.InvokeAsync("ListScheduledReports", New Object() {ScheduleID}, Me.ListScheduledReportsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListScheduledReportsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListScheduledReportsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListScheduledReportsCompleted(Me, New ListScheduledReportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tSchedules", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListSchedules() As <System.Xml.Serialization.XmlArrayAttribute("Schedules")> Schedule()
            Dim results() As Object = Me.Invoke("ListSchedules", New Object(-1) {})
            Return CType(results(0),Schedule())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListSchedulesAsync()
            Me.ListSchedulesAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListSchedulesAsync(ByVal userState As Object)
            If (Me.ListSchedulesOperationCompleted Is Nothing) Then
                Me.ListSchedulesOperationCompleted = AddressOf Me.OnListSchedulesOperationCompleted
            End If
            Me.InvokeAsync("ListSchedules", New Object(-1) {}, Me.ListSchedulesOperationCompleted, userState)
        End Sub
        
        Private Sub OnListSchedulesOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListSchedulesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListSchedulesCompleted(Me, New ListSchedulesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Pau" & _
            "seSchedule", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub PauseSchedule(ByVal ScheduleID As String)
            Me.Invoke("PauseSchedule", New Object() {ScheduleID})
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub PauseScheduleAsync(ByVal ScheduleID As String)
            Me.PauseScheduleAsync(ScheduleID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub PauseScheduleAsync(ByVal ScheduleID As String, ByVal userState As Object)
            If (Me.PauseScheduleOperationCompleted Is Nothing) Then
                Me.PauseScheduleOperationCompleted = AddressOf Me.OnPauseScheduleOperationCompleted
            End If
            Me.InvokeAsync("PauseSchedule", New Object() {ScheduleID}, Me.PauseScheduleOperationCompleted, userState)
        End Sub
        
        Private Sub OnPauseScheduleOperationCompleted(ByVal arg As Object)
            If (Not (Me.PauseScheduleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent PauseScheduleCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Res" & _
            "umeSchedule", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub ResumeSchedule(ByVal ScheduleID As String)
            Me.Invoke("ResumeSchedule", New Object() {ScheduleID})
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub ResumeScheduleAsync(ByVal ScheduleID As String)
            Me.ResumeScheduleAsync(ScheduleID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ResumeScheduleAsync(ByVal ScheduleID As String, ByVal userState As Object)
            If (Me.ResumeScheduleOperationCompleted Is Nothing) Then
                Me.ResumeScheduleOperationCompleted = AddressOf Me.OnResumeScheduleOperationCompleted
            End If
            Me.InvokeAsync("ResumeSchedule", New Object() {ScheduleID}, Me.ResumeScheduleOperationCompleted, userState)
        End Sub
        
        Private Sub OnResumeScheduleOperationCompleted(ByVal arg As Object)
            If (Not (Me.ResumeScheduleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ResumeScheduleCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateSubscription", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateSubscription(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue) As <System.Xml.Serialization.XmlElementAttribute("SubscriptionID")> String
            Dim results() As Object = Me.Invoke("CreateSubscription", New Object() {Report, ExtensionSettings, Description, EventType, MatchData, Parameters})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateSubscriptionAsync(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue)
            Me.CreateSubscriptionAsync(Report, ExtensionSettings, Description, EventType, MatchData, Parameters, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateSubscriptionAsync(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue, ByVal userState As Object)
            If (Me.CreateSubscriptionOperationCompleted Is Nothing) Then
                Me.CreateSubscriptionOperationCompleted = AddressOf Me.OnCreateSubscriptionOperationCompleted
            End If
            Me.InvokeAsync("CreateSubscription", New Object() {Report, ExtensionSettings, Description, EventType, MatchData, Parameters}, Me.CreateSubscriptionOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateSubscriptionOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateSubscriptionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateSubscriptionCompleted(Me, New CreateSubscriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateDataDrivenSubscription", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateDataDrivenSubscription(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference) As <System.Xml.Serialization.XmlElementAttribute("SubscriptionID")> String
            Dim results() As Object = Me.Invoke("CreateDataDrivenSubscription", New Object() {Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateDataDrivenSubscriptionAsync(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference)
            Me.CreateDataDrivenSubscriptionAsync(Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateDataDrivenSubscriptionAsync(ByVal Report As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference, ByVal userState As Object)
            If (Me.CreateDataDrivenSubscriptionOperationCompleted Is Nothing) Then
                Me.CreateDataDrivenSubscriptionOperationCompleted = AddressOf Me.OnCreateDataDrivenSubscriptionOperationCompleted
            End If
            Me.InvokeAsync("CreateDataDrivenSubscription", New Object() {Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters}, Me.CreateDataDrivenSubscriptionOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateDataDrivenSubscriptionOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateDataDrivenSubscriptionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateDataDrivenSubscriptionCompleted(Me, New CreateDataDrivenSubscriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "SubscriptionProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetSubscriptionProperties(ByVal SubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue)
            Me.Invoke("SetSubscriptionProperties", New Object() {SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSubscriptionPropertiesAsync(ByVal SubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue)
            Me.SetSubscriptionPropertiesAsync(SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSubscriptionPropertiesAsync(ByVal SubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValue, ByVal userState As Object)
            If (Me.SetSubscriptionPropertiesOperationCompleted Is Nothing) Then
                Me.SetSubscriptionPropertiesOperationCompleted = AddressOf Me.OnSetSubscriptionPropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetSubscriptionProperties", New Object() {SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters}, Me.SetSubscriptionPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetSubscriptionPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetSubscriptionPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetSubscriptionPropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "DataDrivenSubscriptionProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetDataDrivenSubscriptionProperties(ByVal DataDrivenSubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference)
            Me.Invoke("SetDataDrivenSubscriptionProperties", New Object() {DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetDataDrivenSubscriptionPropertiesAsync(ByVal DataDrivenSubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference)
            Me.SetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetDataDrivenSubscriptionPropertiesAsync(ByVal DataDrivenSubscriptionID As String, ByVal ExtensionSettings As ExtensionSettings, ByVal DataRetrievalPlan As DataRetrievalPlan, ByVal Description As String, ByVal EventType As String, ByVal MatchData As String, ByVal Parameters() As ParameterValueOrFieldReference, ByVal userState As Object)
            If (Me.SetDataDrivenSubscriptionPropertiesOperationCompleted Is Nothing) Then
                Me.SetDataDrivenSubscriptionPropertiesOperationCompleted = AddressOf Me.OnSetDataDrivenSubscriptionPropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetDataDrivenSubscriptionProperties", New Object() {DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters}, Me.SetDataDrivenSubscriptionPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetDataDrivenSubscriptionPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetDataDrivenSubscriptionPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetDataDrivenSubscriptionPropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="7#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="6#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="5#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="4#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "SubscriptionProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetSubscriptionProperties(ByVal SubscriptionID As String, ByRef ExtensionSettings As ExtensionSettings, ByRef Description As String, ByRef Active As ActiveState, ByRef Status As String, ByRef EventType As String, ByRef MatchData As String, ByRef Parameters() As ParameterValue) As <System.Xml.Serialization.XmlElementAttribute("Owner")> String
            Dim results() As Object = Me.Invoke("GetSubscriptionProperties", New Object() {SubscriptionID})
            ExtensionSettings = CType(results(1), ExtensionSettings)
            Description = CType(results(2), String)
            Active = CType(results(3), ActiveState)
            Status = CType(results(4), String)
            EventType = CType(results(5), String)
            MatchData = CType(results(6), String)
            Parameters = CType(results(7), ParameterValue())
            Return CType(results(0), String)
        End Function
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub GetSubscriptionPropertiesAsync(ByVal SubscriptionID As String)
            Me.GetSubscriptionPropertiesAsync(SubscriptionID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetSubscriptionPropertiesAsync(ByVal SubscriptionID As String, ByVal userState As Object)
            If (Me.GetSubscriptionPropertiesOperationCompleted Is Nothing) Then
                Me.GetSubscriptionPropertiesOperationCompleted = AddressOf Me.OnGetSubscriptionPropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetSubscriptionProperties", New Object() {SubscriptionID}, Me.GetSubscriptionPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetSubscriptionPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetSubscriptionPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetSubscriptionPropertiesCompleted(Me, New GetSubscriptionPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="8#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="7#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="6#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="5#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="4#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "DataDrivenSubscriptionProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetDataDrivenSubscriptionProperties(ByVal DataDrivenSubscriptionID As String, ByRef ExtensionSettings As ExtensionSettings, ByRef DataRetrievalPlan As DataRetrievalPlan, ByRef Description As String, ByRef Active As ActiveState, ByRef Status As String, ByRef EventType As String, ByRef MatchData As String, ByRef Parameters() As ParameterValueOrFieldReference) As <System.Xml.Serialization.XmlElementAttribute("Owner")> String
            Dim results() As Object = Me.Invoke("GetDataDrivenSubscriptionProperties", New Object() {DataDrivenSubscriptionID})
            ExtensionSettings = CType(results(1), ExtensionSettings)
            DataRetrievalPlan = CType(results(2), DataRetrievalPlan)
            Description = CType(results(3), String)
            Active = CType(results(4), ActiveState)
            Status = CType(results(5), String)
            EventType = CType(results(6), String)
            MatchData = CType(results(7), String)
            Parameters = CType(results(8), ParameterValueOrFieldReference())
            Return CType(results(0), String)
        End Function
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub GetDataDrivenSubscriptionPropertiesAsync(ByVal DataDrivenSubscriptionID As String)
            Me.GetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetDataDrivenSubscriptionPropertiesAsync(ByVal DataDrivenSubscriptionID As String, ByVal userState As Object)
            If (Me.GetDataDrivenSubscriptionPropertiesOperationCompleted Is Nothing) Then
                Me.GetDataDrivenSubscriptionPropertiesOperationCompleted = AddressOf Me.OnGetDataDrivenSubscriptionPropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetDataDrivenSubscriptionProperties", New Object() {DataDrivenSubscriptionID}, Me.GetDataDrivenSubscriptionPropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetDataDrivenSubscriptionPropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetDataDrivenSubscriptionPropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetDataDrivenSubscriptionPropertiesCompleted(Me, New GetDataDrivenSubscriptionPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" & _
            "eteSubscription", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub DeleteSubscription(ByVal SubscriptionID As String)
            Me.Invoke("DeleteSubscription", New Object() {SubscriptionID})
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub DeleteSubscriptionAsync(ByVal SubscriptionID As String)
            Me.DeleteSubscriptionAsync(SubscriptionID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteSubscriptionAsync(ByVal SubscriptionID As String, ByVal userState As Object)
            If (Me.DeleteSubscriptionOperationCompleted Is Nothing) Then
                Me.DeleteSubscriptionOperationCompleted = AddressOf Me.OnDeleteSubscriptionOperationCompleted
            End If
            Me.InvokeAsync("DeleteSubscription", New Object() {SubscriptionID}, Me.DeleteSubscriptionOperationCompleted, userState)
        End Sub
        
        Private Sub OnDeleteSubscriptionOperationCompleted(ByVal arg As Object)
            If (Not (Me.DeleteSubscriptionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DeleteSubscriptionCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Pre" & _
            "pareQuery", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function PrepareQuery(ByVal DataSource As DataSource, ByVal DataSet As DataSetDefinition, ByRef Changed As Boolean, ByRef ParameterNames() As String) As <System.Xml.Serialization.XmlElementAttribute("DataSettings")> DataSetDefinition
            Dim results() As Object = Me.Invoke("PrepareQuery", New Object() {DataSource, DataSet})
            Changed = CType(results(1), Boolean)
            ParameterNames = CType(results(2), String())
            Return CType(results(0), DataSetDefinition)
        End Function
        
        '''<remarks/>
        Public Overloads Sub PrepareQueryAsync(ByVal DataSource As DataSource, ByVal DataSet As DataSetDefinition)
            Me.PrepareQueryAsync(DataSource, DataSet, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub PrepareQueryAsync(ByVal DataSource As DataSource, ByVal DataSet As DataSetDefinition, ByVal userState As Object)
            If (Me.PrepareQueryOperationCompleted Is Nothing) Then
                Me.PrepareQueryOperationCompleted = AddressOf Me.OnPrepareQueryOperationCompleted
            End If
            Me.InvokeAsync("PrepareQuery", New Object() {DataSource, DataSet}, Me.PrepareQueryOperationCompleted, userState)
        End Sub
        
        Private Sub OnPrepareQueryOperationCompleted(ByVal arg As Object)
            If (Not (Me.PrepareQueryCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent PrepareQueryCompleted(Me, New PrepareQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ExtensionSettings", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetExtensionSettings(ByVal Extension As String) As <System.Xml.Serialization.XmlArrayAttribute("ExtensionParameters")> ExtensionParameter()
            Dim results() As Object = Me.Invoke("GetExtensionSettings", New Object() {Extension})
            Return CType(results(0),ExtensionParameter())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetExtensionSettingsAsync(ByVal Extension As String)
            Me.GetExtensionSettingsAsync(Extension, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetExtensionSettingsAsync(ByVal Extension As String, ByVal userState As Object)
            If (Me.GetExtensionSettingsOperationCompleted Is Nothing) Then
                Me.GetExtensionSettingsOperationCompleted = AddressOf Me.OnGetExtensionSettingsOperationCompleted
            End If
            Me.InvokeAsync("GetExtensionSettings", New Object() {Extension}, Me.GetExtensionSettingsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetExtensionSettingsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetExtensionSettingsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetExtensionSettingsCompleted(Me, New GetExtensionSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Val"& _ 
            "idateExtensionSettings", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ValidateExtensionSettings(ByVal Extension As String, ByVal ParameterValues() As ParameterValueOrFieldReference) As <System.Xml.Serialization.XmlArrayAttribute("ParameterErrors")> ExtensionParameter()
            Dim results() As Object = Me.Invoke("ValidateExtensionSettings", New Object() {Extension, ParameterValues})
            Return CType(results(0),ExtensionParameter())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ValidateExtensionSettingsAsync(ByVal Extension As String, ByVal ParameterValues() As ParameterValueOrFieldReference)
            Me.ValidateExtensionSettingsAsync(Extension, ParameterValues, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ValidateExtensionSettingsAsync(ByVal Extension As String, ByVal ParameterValues() As ParameterValueOrFieldReference, ByVal userState As Object)
            If (Me.ValidateExtensionSettingsOperationCompleted Is Nothing) Then
                Me.ValidateExtensionSettingsOperationCompleted = AddressOf Me.OnValidateExtensionSettingsOperationCompleted
            End If
            Me.InvokeAsync("ValidateExtensionSettings", New Object() {Extension, ParameterValues}, Me.ValidateExtensionSettingsOperationCompleted, userState)
        End Sub
        
        Private Sub OnValidateExtensionSettingsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ValidateExtensionSettingsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ValidateExtensionSettingsCompleted(Me, New ValidateExtensionSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tSubscriptions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListSubscriptions(ByVal Report As String, ByVal Owner As String) As <System.Xml.Serialization.XmlArrayAttribute("SubscriptionItems")> Subscription()
            Dim results() As Object = Me.Invoke("ListSubscriptions", New Object() {Report, Owner})
            Return CType(results(0),Subscription())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListSubscriptionsAsync(ByVal Report As String, ByVal Owner As String)
            Me.ListSubscriptionsAsync(Report, Owner, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListSubscriptionsAsync(ByVal Report As String, ByVal Owner As String, ByVal userState As Object)
            If (Me.ListSubscriptionsOperationCompleted Is Nothing) Then
                Me.ListSubscriptionsOperationCompleted = AddressOf Me.OnListSubscriptionsOperationCompleted
            End If
            Me.InvokeAsync("ListSubscriptions", New Object() {Report, Owner}, Me.ListSubscriptionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListSubscriptionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListSubscriptionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListSubscriptionsCompleted(Me, New ListSubscriptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tSubscriptionsUsingDataSource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListSubscriptionsUsingDataSource(ByVal DataSource As String) As <System.Xml.Serialization.XmlArrayAttribute("SubscriptionItems")> Subscription()
            Dim results() As Object = Me.Invoke("ListSubscriptionsUsingDataSource", New Object() {DataSource})
            Return CType(results(0),Subscription())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListSubscriptionsUsingDataSourceAsync(ByVal DataSource As String)
            Me.ListSubscriptionsUsingDataSourceAsync(DataSource, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListSubscriptionsUsingDataSourceAsync(ByVal DataSource As String, ByVal userState As Object)
            If (Me.ListSubscriptionsUsingDataSourceOperationCompleted Is Nothing) Then
                Me.ListSubscriptionsUsingDataSourceOperationCompleted = AddressOf Me.OnListSubscriptionsUsingDataSourceOperationCompleted
            End If
            Me.InvokeAsync("ListSubscriptionsUsingDataSource", New Object() {DataSource}, Me.ListSubscriptionsUsingDataSourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnListSubscriptionsUsingDataSourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListSubscriptionsUsingDataSourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListSubscriptionsUsingDataSourceCompleted(Me, New ListSubscriptionsUsingDataSourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tExtensions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListExtensions(ByVal ExtensionType As ExtensionTypeEnum) As <System.Xml.Serialization.XmlArrayAttribute("Extensions")> Extension()
            Dim results() As Object = Me.Invoke("ListExtensions", New Object() {ExtensionType})
            Return CType(results(0),Extension())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListExtensionsAsync(ByVal ExtensionType As ExtensionTypeEnum)
            Me.ListExtensionsAsync(ExtensionType, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListExtensionsAsync(ByVal ExtensionType As ExtensionTypeEnum, ByVal userState As Object)
            If (Me.ListExtensionsOperationCompleted Is Nothing) Then
                Me.ListExtensionsOperationCompleted = AddressOf Me.OnListExtensionsOperationCompleted
            End If
            Me.InvokeAsync("ListExtensions", New Object() {ExtensionType}, Me.ListExtensionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListExtensionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListExtensionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListExtensionsCompleted(Me, New ListExtensionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tEvents", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListEvents() As <System.Xml.Serialization.XmlArrayAttribute("Events")> [Event]()
            Dim results() As Object = Me.Invoke("ListEvents", New Object(-1) {})
            Return CType(results(0),[Event]())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListEventsAsync()
            Me.ListEventsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListEventsAsync(ByVal userState As Object)
            If (Me.ListEventsOperationCompleted Is Nothing) Then
                Me.ListEventsOperationCompleted = AddressOf Me.OnListEventsOperationCompleted
            End If
            Me.InvokeAsync("ListEvents", New Object(-1) {}, Me.ListEventsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListEventsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListEventsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListEventsCompleted(Me, New ListEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fir" & _
            "eEvent", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub FireEvent(ByVal EventType As String, ByVal EventData As String)
            Me.Invoke("FireEvent", New Object() {EventType, EventData})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FireEventAsync(ByVal EventType As String, ByVal EventData As String)
            Me.FireEventAsync(EventType, EventData, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FireEventAsync(ByVal EventType As String, ByVal EventData As String, ByVal userState As Object)
            If (Me.FireEventOperationCompleted Is Nothing) Then
                Me.FireEventOperationCompleted = AddressOf Me.OnFireEventOperationCompleted
            End If
            Me.InvokeAsync("FireEvent", New Object() {EventType, EventData}, Me.FireEventOperationCompleted, userState)
        End Sub
        
        Private Sub OnFireEventOperationCompleted(ByVal arg As Object)
            If (Not (Me.FireEventCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FireEventCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tTasks", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListTasks(ByVal SecurityScope As SecurityScopeEnum) As <System.Xml.Serialization.XmlArrayAttribute("Tasks")> Task()
            Dim results() As Object = Me.Invoke("ListTasks", New Object() {SecurityScope})
            Return CType(results(0),Task())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListTasksAsync(ByVal SecurityScope As SecurityScopeEnum)
            Me.ListTasksAsync(SecurityScope, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListTasksAsync(ByVal SecurityScope As SecurityScopeEnum, ByVal userState As Object)
            If (Me.ListTasksOperationCompleted Is Nothing) Then
                Me.ListTasksOperationCompleted = AddressOf Me.OnListTasksOperationCompleted
            End If
            Me.InvokeAsync("ListTasks", New Object() {SecurityScope}, Me.ListTasksOperationCompleted, userState)
        End Sub
        
        Private Sub OnListTasksOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListTasksCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListTasksCompleted(Me, New ListTasksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tRoles", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListRoles(ByVal SecurityScope As SecurityScopeEnum) As <System.Xml.Serialization.XmlArrayAttribute("Roles")> Role()
            Dim results() As Object = Me.Invoke("ListRoles", New Object() {SecurityScope})
            Return CType(results(0),Role())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListRolesAsync(ByVal SecurityScope As SecurityScopeEnum)
            Me.ListRolesAsync(SecurityScope, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListRolesAsync(ByVal SecurityScope As SecurityScopeEnum, ByVal userState As Object)
            If (Me.ListRolesOperationCompleted Is Nothing) Then
                Me.ListRolesOperationCompleted = AddressOf Me.OnListRolesOperationCompleted
            End If
            Me.InvokeAsync("ListRoles", New Object() {SecurityScope}, Me.ListRolesOperationCompleted, userState)
        End Sub
        
        Private Sub OnListRolesOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListRolesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListRolesCompleted(Me, New ListRolesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateRole", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateRole(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task)
            Me.Invoke("CreateRole", New Object() {Name, Description, Tasks})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateRoleAsync(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task)
            Me.CreateRoleAsync(Name, Description, Tasks, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateRoleAsync(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task, ByVal userState As Object)
            If (Me.CreateRoleOperationCompleted Is Nothing) Then
                Me.CreateRoleOperationCompleted = AddressOf Me.OnCreateRoleOperationCompleted
            End If
            Me.InvokeAsync("CreateRole", New Object() {Name, Description, Tasks}, Me.CreateRoleOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateRoleOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateRoleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateRoleCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del"& _ 
            "eteRole", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub DeleteRole(ByVal Name As String)
            Me.Invoke("DeleteRole", New Object() {Name})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteRoleAsync(ByVal Name As String)
            Me.DeleteRoleAsync(Name, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DeleteRoleAsync(ByVal Name As String, ByVal userState As Object)
            If (Me.DeleteRoleOperationCompleted Is Nothing) Then
                Me.DeleteRoleOperationCompleted = AddressOf Me.OnDeleteRoleOperationCompleted
            End If
            Me.InvokeAsync("DeleteRole", New Object() {Name}, Me.DeleteRoleOperationCompleted, userState)
        End Sub
        
        Private Sub OnDeleteRoleOperationCompleted(ByVal arg As Object)
            If (Not (Me.DeleteRoleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DeleteRoleCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "RoleProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetRoleProperties(ByVal Name As String, ByRef Description As String) As <System.Xml.Serialization.XmlArrayAttribute("Tasks")> Task()
            Dim results() As Object = Me.Invoke("GetRoleProperties", New Object() {Name})
            Description = CType(results(1), String)
            Return CType(results(0), Task())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetRolePropertiesAsync(ByVal Name As String)
            Me.GetRolePropertiesAsync(Name, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetRolePropertiesAsync(ByVal Name As String, ByVal userState As Object)
            If (Me.GetRolePropertiesOperationCompleted Is Nothing) Then
                Me.GetRolePropertiesOperationCompleted = AddressOf Me.OnGetRolePropertiesOperationCompleted
            End If
            Me.InvokeAsync("GetRoleProperties", New Object() {Name}, Me.GetRolePropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetRolePropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetRolePropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetRolePropertiesCompleted(Me, New GetRolePropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "RoleProperties", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetRoleProperties(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task)
            Me.Invoke("SetRoleProperties", New Object() {Name, Description, Tasks})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetRolePropertiesAsync(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task)
            Me.SetRolePropertiesAsync(Name, Description, Tasks, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetRolePropertiesAsync(ByVal Name As String, ByVal Description As String, ByVal Tasks() As Task, ByVal userState As Object)
            If (Me.SetRolePropertiesOperationCompleted Is Nothing) Then
                Me.SetRolePropertiesOperationCompleted = AddressOf Me.OnSetRolePropertiesOperationCompleted
            End If
            Me.InvokeAsync("SetRoleProperties", New Object() {Name, Description, Tasks}, Me.SetRolePropertiesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetRolePropertiesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetRolePropertiesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetRolePropertiesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "SystemPolicies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetSystemPolicies() As <System.Xml.Serialization.XmlArrayAttribute("Policies")> Policy()
            Dim results() As Object = Me.Invoke("GetSystemPolicies", New Object(-1) {})
            Return CType(results(0),Policy())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetSystemPoliciesAsync()
            Me.GetSystemPoliciesAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetSystemPoliciesAsync(ByVal userState As Object)
            If (Me.GetSystemPoliciesOperationCompleted Is Nothing) Then
                Me.GetSystemPoliciesOperationCompleted = AddressOf Me.OnGetSystemPoliciesOperationCompleted
            End If
            Me.InvokeAsync("GetSystemPolicies", New Object(-1) {}, Me.GetSystemPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetSystemPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetSystemPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetSystemPoliciesCompleted(Me, New GetSystemPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "SystemPolicies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetSystemPolicies(ByVal Policies() As Policy)
            Me.Invoke("SetSystemPolicies", New Object() {Policies})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSystemPoliciesAsync(ByVal Policies() As Policy)
            Me.SetSystemPoliciesAsync(Policies, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetSystemPoliciesAsync(ByVal Policies() As Policy, ByVal userState As Object)
            If (Me.SetSystemPoliciesOperationCompleted Is Nothing) Then
                Me.SetSystemPoliciesOperationCompleted = AddressOf Me.OnSetSystemPoliciesOperationCompleted
            End If
            Me.InvokeAsync("SetSystemPolicies", New Object() {Policies}, Me.SetSystemPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetSystemPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetSystemPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetSystemPoliciesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "Policies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPolicies(ByVal Item As String, ByRef InheritParent As Boolean) As <System.Xml.Serialization.XmlArrayAttribute("Policies")> Policy()
            Dim results() As Object = Me.Invoke("GetPolicies", New Object() {Item})
            InheritParent = CType(results(1),Boolean)
            Return CType(results(0),Policy())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetPoliciesAsync(ByVal Item As String)
            Me.GetPoliciesAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetPoliciesAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.GetPoliciesOperationCompleted Is Nothing) Then
                Me.GetPoliciesOperationCompleted = AddressOf Me.OnGetPoliciesOperationCompleted
            End If
            Me.InvokeAsync("GetPolicies", New Object() {Item}, Me.GetPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetPoliciesCompleted(Me, New GetPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "Policies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SetPolicies(ByVal Item As String, ByVal Policies() As Policy)
            Me.Invoke("SetPolicies", New Object() {Item, Policies})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetPoliciesAsync(ByVal Item As String, ByVal Policies() As Policy)
            Me.SetPoliciesAsync(Item, Policies, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetPoliciesAsync(ByVal Item As String, ByVal Policies() As Policy, ByVal userState As Object)
            If (Me.SetPoliciesOperationCompleted Is Nothing) Then
                Me.SetPoliciesOperationCompleted = AddressOf Me.OnSetPoliciesOperationCompleted
            End If
            Me.InvokeAsync("SetPolicies", New Object() {Item, Policies}, Me.SetPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetPoliciesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Inh"& _ 
            "eritParentSecurity", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub InheritParentSecurity(ByVal Item As String)
            Me.Invoke("InheritParentSecurity", New Object() {Item})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub InheritParentSecurityAsync(ByVal Item As String)
            Me.InheritParentSecurityAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub InheritParentSecurityAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.InheritParentSecurityOperationCompleted Is Nothing) Then
                Me.InheritParentSecurityOperationCompleted = AddressOf Me.OnInheritParentSecurityOperationCompleted
            End If
            Me.InvokeAsync("InheritParentSecurity", New Object() {Item}, Me.InheritParentSecurityOperationCompleted, userState)
        End Sub
        
        Private Sub OnInheritParentSecurityOperationCompleted(ByVal arg As Object)
            If (Not (Me.InheritParentSecurityCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent InheritParentSecurityCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "SystemPermissions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetSystemPermissions() As <System.Xml.Serialization.XmlArrayAttribute("Permissions"), System.Xml.Serialization.XmlArrayItemAttribute("Operation")> String()
            Dim results() As Object = Me.Invoke("GetSystemPermissions", New Object(-1) {})
            Return CType(results(0),String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetSystemPermissionsAsync()
            Me.GetSystemPermissionsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetSystemPermissionsAsync(ByVal userState As Object)
            If (Me.GetSystemPermissionsOperationCompleted Is Nothing) Then
                Me.GetSystemPermissionsOperationCompleted = AddressOf Me.OnGetSystemPermissionsOperationCompleted
            End If
            Me.InvokeAsync("GetSystemPermissions", New Object(-1) {}, Me.GetSystemPermissionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetSystemPermissionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetSystemPermissionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetSystemPermissionsCompleted(Me, New GetSystemPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "Permissions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPermissions(ByVal Item As String) As <System.Xml.Serialization.XmlArrayAttribute("Permissions"), System.Xml.Serialization.XmlArrayItemAttribute("Operation")> String()
            Dim results() As Object = Me.Invoke("GetPermissions", New Object() {Item})
            Return CType(results(0),String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetPermissionsAsync(ByVal Item As String)
            Me.GetPermissionsAsync(Item, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetPermissionsAsync(ByVal Item As String, ByVal userState As Object)
            If (Me.GetPermissionsOperationCompleted Is Nothing) Then
                Me.GetPermissionsOperationCompleted = AddressOf Me.OnGetPermissionsOperationCompleted
            End If
            Me.InvokeAsync("GetPermissions", New Object() {Item}, Me.GetPermissionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetPermissionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetPermissionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetPermissionsCompleted(Me, New GetPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log"& _ 
            "onUser", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub LogonUser(ByVal userName As String, ByVal password As String, ByVal authority As String)
            Me.Invoke("LogonUser", New Object() {userName, password, authority})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogonUserAsync(ByVal userName As String, ByVal password As String, ByVal authority As String)
            Me.LogonUserAsync(userName, password, authority, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogonUserAsync(ByVal userName As String, ByVal password As String, ByVal authority As String, ByVal userState As Object)
            If (Me.LogonUserOperationCompleted Is Nothing) Then
                Me.LogonUserOperationCompleted = AddressOf Me.OnLogonUserOperationCompleted
            End If
            Me.InvokeAsync("LogonUser", New Object() {userName, password, authority}, Me.LogonUserOperationCompleted, userState)
        End Sub
        
        Private Sub OnLogonUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogonUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogonUserCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log"& _ 
            "off", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub Logoff()
            Me.Invoke("Logoff", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogoffAsync()
            Me.LogoffAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogoffAsync(ByVal userState As Object)
            If (Me.LogoffOperationCompleted Is Nothing) Then
                Me.LogoffOperationCompleted = AddressOf Me.OnLogoffOperationCompleted
            End If
            Me.InvokeAsync("Logoff", New Object(-1) {}, Me.LogoffOperationCompleted, userState)
        End Sub
        
        Private Sub OnLogoffOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogoffCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogoffCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre"& _ 
            "ateModel", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CreateModel(ByVal Model As String, ByVal Parent As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Definition() As Byte, ByVal Properties() As [Property]) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("CreateModel", New Object() {Model, Parent, Definition, Properties})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub CreateModelAsync(ByVal Model As String, ByVal Parent As String, ByVal Definition() As Byte, ByVal Properties() As [Property])
            Me.CreateModelAsync(Model, Parent, Definition, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateModelAsync(ByVal Model As String, ByVal Parent As String, ByVal Definition() As Byte, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.CreateModelOperationCompleted Is Nothing) Then
                Me.CreateModelOperationCompleted = AddressOf Me.OnCreateModelOperationCompleted
            End If
            Me.InvokeAsync("CreateModel", New Object() {Model, Parent, Definition, Properties}, Me.CreateModelOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateModelOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateModelCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateModelCompleted(Me, New CreateModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "ModelDefinition", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetModelDefinition(ByVal Model As String) As <System.Xml.Serialization.XmlElementAttribute("Definition", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetModelDefinition", New Object() {Model})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetModelDefinitionAsync(ByVal Model As String)
            Me.GetModelDefinitionAsync(Model, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetModelDefinitionAsync(ByVal Model As String, ByVal userState As Object)
            If (Me.GetModelDefinitionOperationCompleted Is Nothing) Then
                Me.GetModelDefinitionOperationCompleted = AddressOf Me.OnGetModelDefinitionOperationCompleted
            End If
            Me.InvokeAsync("GetModelDefinition", New Object() {Model}, Me.GetModelDefinitionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetModelDefinitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetModelDefinitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetModelDefinitionCompleted(Me, New GetModelDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set"& _ 
            "ModelDefinition", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SetModelDefinition(ByVal Model As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Definition() As Byte) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("SetModelDefinition", New Object() {Model, Definition})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub SetModelDefinitionAsync(ByVal Model As String, ByVal Definition() As Byte)
            Me.SetModelDefinitionAsync(Model, Definition, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetModelDefinitionAsync(ByVal Model As String, ByVal Definition() As Byte, ByVal userState As Object)
            If (Me.SetModelDefinitionOperationCompleted Is Nothing) Then
                Me.SetModelDefinitionOperationCompleted = AddressOf Me.OnSetModelDefinitionOperationCompleted
            End If
            Me.InvokeAsync("SetModelDefinition", New Object() {Model, Definition}, Me.SetModelDefinitionOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetModelDefinitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetModelDefinitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetModelDefinitionCompleted(Me, New SetModelDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis"& _ 
            "tModelPerspectives", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListModelPerspectives(ByVal Model As String) As <System.Xml.Serialization.XmlArrayAttribute("ModelCatalogItems")> ModelCatalogItem()
            Dim results() As Object = Me.Invoke("ListModelPerspectives", New Object() {Model})
            Return CType(results(0),ModelCatalogItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListModelPerspectivesAsync(ByVal Model As String)
            Me.ListModelPerspectivesAsync(Model, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListModelPerspectivesAsync(ByVal Model As String, ByVal userState As Object)
            If (Me.ListModelPerspectivesOperationCompleted Is Nothing) Then
                Me.ListModelPerspectivesOperationCompleted = AddressOf Me.OnListModelPerspectivesOperationCompleted
            End If
            Me.InvokeAsync("ListModelPerspectives", New Object() {Model}, Me.ListModelPerspectivesOperationCompleted, userState)
        End Sub
        
        Private Sub OnListModelPerspectivesOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListModelPerspectivesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListModelPerspectivesCompleted(Me, New ListModelPerspectivesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get"& _ 
            "UserModel", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetUserModel(ByVal Model As String, ByVal Perspective As String) As <System.Xml.Serialization.XmlElementAttribute("Definition", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetUserModel", New Object() {Model, Perspective})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetUserModelAsync(ByVal Model As String, ByVal Perspective As String)
            Me.GetUserModelAsync(Model, Perspective, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetUserModelAsync(ByVal Model As String, ByVal Perspective As String, ByVal userState As Object)
            If (Me.GetUserModelOperationCompleted Is Nothing) Then
                Me.GetUserModelOperationCompleted = AddressOf Me.OnGetUserModelOperationCompleted
            End If
            Me.InvokeAsync("GetUserModel", New Object() {Model, Perspective}, Me.GetUserModelOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetUserModelOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetUserModelCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetUserModelCompleted(Me, New GetUserModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" & _
            "tModelItemChildren", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListModelItemChildren(ByVal Model As String, ByVal ModelItemID As String, ByVal Recursive As Boolean) As <System.Xml.Serialization.XmlArrayAttribute("ModelItems")> ModelItem()
            Dim results() As Object = Me.Invoke("ListModelItemChildren", New Object() {Model, ModelItemID, Recursive})
            Return CType(results(0), ModelItem())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListModelItemChildrenAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Recursive As Boolean)
            Me.ListModelItemChildrenAsync(Model, ModelItemID, Recursive, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListModelItemChildrenAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Recursive As Boolean, ByVal userState As Object)
            If (Me.ListModelItemChildrenOperationCompleted Is Nothing) Then
                Me.ListModelItemChildrenOperationCompleted = AddressOf Me.OnListModelItemChildrenOperationCompleted
            End If
            Me.InvokeAsync("ListModelItemChildren", New Object() {Model, ModelItemID, Recursive}, Me.ListModelItemChildrenOperationCompleted, userState)
        End Sub
        
        Private Sub OnListModelItemChildrenOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListModelItemChildrenCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListModelItemChildrenCompleted(Me, New ListModelItemChildrenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ModelItemPermissions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetModelItemPermissions(ByVal Model As String, ByVal ModelItemID As String) As <System.Xml.Serialization.XmlArrayAttribute("Permissions")> String()
            Dim results() As Object = Me.Invoke("GetModelItemPermissions", New Object() {Model, ModelItemID})
            Return CType(results(0), String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetModelItemPermissionsAsync(ByVal Model As String, ByVal ModelItemID As String)
            Me.GetModelItemPermissionsAsync(Model, ModelItemID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetModelItemPermissionsAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal userState As Object)
            If (Me.GetModelItemPermissionsOperationCompleted Is Nothing) Then
                Me.GetModelItemPermissionsOperationCompleted = AddressOf Me.OnGetModelItemPermissionsOperationCompleted
            End If
            Me.InvokeAsync("GetModelItemPermissions", New Object() {Model, ModelItemID}, Me.GetModelItemPermissionsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetModelItemPermissionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetModelItemPermissionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetModelItemPermissionsCompleted(Me, New GetModelItemPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ModelItemPolicies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetModelItemPolicies(ByVal Model As String, ByVal ModelItemID As String, ByRef InheritParent As Boolean) As <System.Xml.Serialization.XmlArrayAttribute("Policies")> Policy()
            Dim results() As Object = Me.Invoke("GetModelItemPolicies", New Object() {Model, ModelItemID})
            InheritParent = CType(results(1), Boolean)
            Return CType(results(0), Policy())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetModelItemPoliciesAsync(ByVal Model As String, ByVal ModelItemID As String)
            Me.GetModelItemPoliciesAsync(Model, ModelItemID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetModelItemPoliciesAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal userState As Object)
            If (Me.GetModelItemPoliciesOperationCompleted Is Nothing) Then
                Me.GetModelItemPoliciesOperationCompleted = AddressOf Me.OnGetModelItemPoliciesOperationCompleted
            End If
            Me.InvokeAsync("GetModelItemPolicies", New Object() {Model, ModelItemID}, Me.GetModelItemPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetModelItemPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetModelItemPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetModelItemPoliciesCompleted(Me, New GetModelItemPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "ModelItemPolicies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetModelItemPolicies(ByVal Model As String, ByVal ModelItemID As String, ByVal Policies() As Policy)
            Me.Invoke("SetModelItemPolicies", New Object() {Model, ModelItemID, Policies})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetModelItemPoliciesAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Policies() As Policy)
            Me.SetModelItemPoliciesAsync(Model, ModelItemID, Policies, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetModelItemPoliciesAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Policies() As Policy, ByVal userState As Object)
            If (Me.SetModelItemPoliciesOperationCompleted Is Nothing) Then
                Me.SetModelItemPoliciesOperationCompleted = AddressOf Me.OnSetModelItemPoliciesOperationCompleted
            End If
            Me.InvokeAsync("SetModelItemPolicies", New Object() {Model, ModelItemID, Policies}, Me.SetModelItemPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetModelItemPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetModelItemPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetModelItemPoliciesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Inh" & _
            "eritModelItemParentSecurity", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub InheritModelItemParentSecurity(ByVal Model As String, ByVal ModelItemID As String)
            Me.Invoke("InheritModelItemParentSecurity", New Object() {Model, ModelItemID})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub InheritModelItemParentSecurityAsync(ByVal Model As String, ByVal ModelItemID As String)
            Me.InheritModelItemParentSecurityAsync(Model, ModelItemID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub InheritModelItemParentSecurityAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal userState As Object)
            If (Me.InheritModelItemParentSecurityOperationCompleted Is Nothing) Then
                Me.InheritModelItemParentSecurityOperationCompleted = AddressOf Me.OnInheritModelItemParentSecurityOperationCompleted
            End If
            Me.InvokeAsync("InheritModelItemParentSecurity", New Object() {Model, ModelItemID}, Me.InheritModelItemParentSecurityOperationCompleted, userState)
        End Sub
        
        Private Sub OnInheritModelItemParentSecurityOperationCompleted(ByVal arg As Object)
            If (Not (Me.InheritModelItemParentSecurityCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent InheritModelItemParentSecurityCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Rem"& _ 
            "oveAllModelItemPolicies", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub RemoveAllModelItemPolicies(ByVal Model As String)
            Me.Invoke("RemoveAllModelItemPolicies", New Object() {Model})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RemoveAllModelItemPoliciesAsync(ByVal Model As String)
            Me.RemoveAllModelItemPoliciesAsync(Model, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RemoveAllModelItemPoliciesAsync(ByVal Model As String, ByVal userState As Object)
            If (Me.RemoveAllModelItemPoliciesOperationCompleted Is Nothing) Then
                Me.RemoveAllModelItemPoliciesOperationCompleted = AddressOf Me.OnRemoveAllModelItemPoliciesOperationCompleted
            End If
            Me.InvokeAsync("RemoveAllModelItemPolicies", New Object() {Model}, Me.RemoveAllModelItemPoliciesOperationCompleted, userState)
        End Sub
        
        Private Sub OnRemoveAllModelItemPoliciesOperationCompleted(ByVal arg As Object)
            If (Not (Me.RemoveAllModelItemPoliciesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RemoveAllModelItemPoliciesCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "ModelDrillthroughReports", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub SetModelDrillthroughReports(ByVal Model As String, ByVal ModelItemID As String, ByVal Reports() As ModelDrillthroughReport)
            Me.Invoke("SetModelDrillthroughReports", New Object() {Model, ModelItemID, Reports})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetModelDrillthroughReportsAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Reports() As ModelDrillthroughReport)
            Me.SetModelDrillthroughReportsAsync(Model, ModelItemID, Reports, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetModelDrillthroughReportsAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal Reports() As ModelDrillthroughReport, ByVal userState As Object)
            If (Me.SetModelDrillthroughReportsOperationCompleted Is Nothing) Then
                Me.SetModelDrillthroughReportsOperationCompleted = AddressOf Me.OnSetModelDrillthroughReportsOperationCompleted
            End If
            Me.InvokeAsync("SetModelDrillthroughReports", New Object() {Model, ModelItemID, Reports}, Me.SetModelDrillthroughReportsOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetModelDrillthroughReportsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetModelDrillthroughReportsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetModelDrillthroughReportsCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" & _
            "tModelDrillthroughReports", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListModelDrillthroughReports(ByVal Model As String, ByVal ModelItemID As String) As <System.Xml.Serialization.XmlArrayAttribute("Reports")> ModelDrillthroughReport()
            Dim results() As Object = Me.Invoke("ListModelDrillthroughReports", New Object() {Model, ModelItemID})
            Return CType(results(0), ModelDrillthroughReport())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListModelDrillthroughReportsAsync(ByVal Model As String, ByVal ModelItemID As String)
            Me.ListModelDrillthroughReportsAsync(Model, ModelItemID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListModelDrillthroughReportsAsync(ByVal Model As String, ByVal ModelItemID As String, ByVal userState As Object)
            If (Me.ListModelDrillthroughReportsOperationCompleted Is Nothing) Then
                Me.ListModelDrillthroughReportsOperationCompleted = AddressOf Me.OnListModelDrillthroughReportsOperationCompleted
            End If
            Me.InvokeAsync("ListModelDrillthroughReports", New Object() {Model, ModelItemID}, Me.ListModelDrillthroughReportsOperationCompleted, userState)
        End Sub
        
        Private Sub OnListModelDrillthroughReportsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListModelDrillthroughReportsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListModelDrillthroughReportsCompleted(Me, New ListModelDrillthroughReportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Gen"& _ 
            "erateModel", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GenerateModel(ByVal DataSource As String, ByVal Model As String, ByVal Parent As String, ByVal Properties() As [Property]) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("GenerateModel", New Object() {DataSource, Model, Parent, Properties})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GenerateModelAsync(ByVal DataSource As String, ByVal Model As String, ByVal Parent As String, ByVal Properties() As [Property])
            Me.GenerateModelAsync(DataSource, Model, Parent, Properties, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GenerateModelAsync(ByVal DataSource As String, ByVal Model As String, ByVal Parent As String, ByVal Properties() As [Property], ByVal userState As Object)
            If (Me.GenerateModelOperationCompleted Is Nothing) Then
                Me.GenerateModelOperationCompleted = AddressOf Me.OnGenerateModelOperationCompleted
            End If
            Me.InvokeAsync("GenerateModel", New Object() {DataSource, Model, Parent, Properties}, Me.GenerateModelOperationCompleted, userState)
        End Sub
        
        Private Sub OnGenerateModelOperationCompleted(ByVal arg As Object)
            If (Not (Me.GenerateModelCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GenerateModelCompleted(Me, New GenerateModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out),  _
         System.Web.Services.Protocols.SoapHeaderAttribute("BatchHeaderValue"),  _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Reg"& _ 
            "enerateModel", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RegenerateModel(ByVal Model As String) As <System.Xml.Serialization.XmlArrayAttribute("Warnings")> Warning()
            Dim results() As Object = Me.Invoke("RegenerateModel", New Object() {Model})
            Return CType(results(0),Warning())
        End Function
        
        '''<remarks/>
        Public Overloads Sub RegenerateModelAsync(ByVal Model As String)
            Me.RegenerateModelAsync(Model, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RegenerateModelAsync(ByVal Model As String, ByVal userState As Object)
            If (Me.RegenerateModelOperationCompleted Is Nothing) Then
                Me.RegenerateModelOperationCompleted = AddressOf Me.OnRegenerateModelOperationCompleted
            End If
            Me.InvokeAsync("RegenerateModel", New Object() {Model}, Me.RegenerateModelOperationCompleted, userState)
        End Sub
        
        Private Sub OnRegenerateModelOperationCompleted(ByVal arg As Object)
            If (Not (Me.RegenerateModelCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RegenerateModelCompleted(Me, New RegenerateModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId:="System.String.Compare(System.String,System.String,System.Boolean)")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")> Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) _
                        OrElse (url Is String.Empty)) Then
                Return False
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If (((wsUri.Port >= 1024) _
                        AndAlso (wsUri.Port <= 5000)) _
                        AndAlso (String.Compare(wsUri.Host, "localHost", True) = 0)) Then
                Return True
            End If
            Return False
        End Function
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable:=false)>  _
    Partial Public Class ServerInfoHeader
        Inherits System.Web.Services.Protocols.SoapHeader
        
        Private reportServerVersionNumberField As String
        
        Private reportServerEditionField As String
        
        Private reportServerVersionField As String
        
        Private reportServerDateTimeField As String
        
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields")> Private anyAttrField() As System.Xml.XmlAttribute
        
        '''<remarks/>
        Public Property ReportServerVersionNumber() As String
            Get
                Return Me.reportServerVersionNumberField
            End Get
            Set
                Me.reportServerVersionNumberField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ReportServerEdition() As String
            Get
                Return Me.reportServerEditionField
            End Get
            Set
                Me.reportServerEditionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ReportServerVersion() As String
            Get
                Return Me.reportServerVersionField
            End Get
            Set
                Me.reportServerVersionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ReportServerDateTime() As String
            Get
                Return Me.reportServerDateTimeField
            End Get
            Set
                Me.reportServerDateTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()>  _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set
                Me.anyAttrField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ModelDrillthroughReport
        
        Private pathField As String
        
        Private typeField As DrillthroughType
        
        '''<remarks/>
        Public Property Path() As String
            Get
                Return Me.pathField
            End Get
            Set
                Me.pathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Type() As DrillthroughType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Public Enum DrillthroughType
        
        '''<remarks/>
        Detail
        
        '''<remarks/>
        List
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ModelItem
        
        Private idField As String
        
        Private nameField As String
        
        Private typeField As ModelItemTypeEnum
        
        Private descriptionField As String
        
        Private modelItemsField() As ModelItem
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ID() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Type() As ModelItemTypeEnum
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property ModelItems() As ModelItem()
            Get
                Return Me.modelItemsField
            End Get
            Set(ByVal value As ModelItem())
                Me.modelItemsField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ModelItemTypeEnum

        '''<remarks/>
        Model

        '''<remarks/>
        EntityFolder

        '''<remarks/>
        FieldFolder

        '''<remarks/>
        Entity

        '''<remarks/>
        Attribute

        '''<remarks/>
        Role
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ModelPerspective
        
        Private idField As String
        
        Private nameField As String
        
        Private descriptionField As String
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ID() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ModelCatalogItem
        
        Private modelField As String
        
        Private descriptionField As String
        
        Private perspectivesField() As ModelPerspective
        
        '''<remarks/>
        Public Property Model() As String
            Get
                Return Me.modelField
            End Get
            Set
                Me.modelField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property Perspectives() As ModelPerspective()
            Get
                Return Me.perspectivesField
            End Get
            Set(ByVal value As ModelPerspective())
                Me.perspectivesField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class Policy

        Private groupUserNameField As String

        Private rolesField() As Role

        '''<remarks/>
        Public Property GroupUserName() As String
            Get
                Return Me.groupUserNameField
            End Get
            Set(ByVal value As String)
                Me.groupUserNameField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property Roles() As Role()
            Get
                Return Me.rolesField
            End Get
            Set(ByVal value As Role())
                Me.rolesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Role
        
        Private nameField As String
        
        Private descriptionField As String
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Task
        
        Private taskIDField As String
        
        Private nameField As String
        
        Private descriptionField As String
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property TaskID() As String
            Get
                Return Me.taskIDField
            End Get
            Set(ByVal value As String)
                Me.taskIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class [Event]

        Private typeField As String

        '''<remarks/>
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set(ByVal value As String)
                Me.typeField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Extension
        
        Private extensionTypeField As ExtensionTypeEnum
        
        Private nameField As String
        
        Private localizedNameField As String
        
        Private visibleField As Boolean
        
        Private isModelGenerationSupportedField As Boolean
        
        '''<remarks/>
        Public Property ExtensionType() As ExtensionTypeEnum
            Get
                Return Me.extensionTypeField
            End Get
            Set
                Me.extensionTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LocalizedName() As String
            Get
                Return Me.localizedNameField
            End Get
            Set
                Me.localizedNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Visible() As Boolean
            Get
                Return Me.visibleField
            End Get
            Set
                Me.visibleField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IsModelGenerationSupported() As Boolean
            Get
                Return Me.isModelGenerationSupportedField
            End Get
            Set
                Me.isModelGenerationSupportedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ExtensionTypeEnum

        '''<remarks/>
        Delivery

        '''<remarks/>
        Render

        '''<remarks/>
        Data

        '''<remarks/>
        All
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Subscription
        
        Private subscriptionIDField As String
        
        Private ownerField As String
        
        Private pathField As String
        
        Private virtualPathField As String
        
        Private reportField As String
        
        Private deliverySettingsField As ExtensionSettings
        
        Private descriptionField As String
        
        Private statusField As String
        
        Private activeField As ActiveState
        
        Private lastExecutedField As Date
        
        Private lastExecutedFieldSpecified As Boolean
        
        Private modifiedByField As String
        
        Private modifiedDateField As Date
        
        Private eventTypeField As String
        
        Private isDataDrivenField As Boolean
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property SubscriptionID() As String
            Get
                Return Me.subscriptionIDField
            End Get
            Set(ByVal value As String)
                Me.subscriptionIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Owner() As String
            Get
                Return Me.ownerField
            End Get
            Set
                Me.ownerField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Path() As String
            Get
                Return Me.pathField
            End Get
            Set
                Me.pathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property VirtualPath() As String
            Get
                Return Me.virtualPathField
            End Get
            Set
                Me.virtualPathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Report() As String
            Get
                Return Me.reportField
            End Get
            Set
                Me.reportField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property DeliverySettings() As ExtensionSettings
            Get
                Return Me.deliverySettingsField
            End Get
            Set
                Me.deliverySettingsField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Status() As String
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Active() As ActiveState
            Get
                Return Me.activeField
            End Get
            Set
                Me.activeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastExecuted() As Date
            Get
                Return Me.lastExecutedField
            End Get
            Set
                Me.lastExecutedField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property LastExecutedSpecified() As Boolean
            Get
                Return Me.lastExecutedFieldSpecified
            End Get
            Set
                Me.lastExecutedFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ModifiedBy() As String
            Get
                Return Me.modifiedByField
            End Get
            Set
                Me.modifiedByField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ModifiedDate() As Date
            Get
                Return Me.modifiedDateField
            End Get
            Set
                Me.modifiedDateField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EventType() As String
            Get
                Return Me.eventTypeField
            End Get
            Set
                Me.eventTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IsDataDriven() As Boolean
            Get
                Return Me.isDataDrivenField
            End Get
            Set
                Me.isDataDrivenField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ExtensionSettings
        
        Private extensionField As String
        
        Private parameterValuesField() As ParameterValueOrFieldReference
        
        '''<remarks/>
        Public Property Extension() As String
            Get
                Return Me.extensionField
            End Get
            Set
                Me.extensionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute(GetType(ParameterFieldReference)),  _
         System.Xml.Serialization.XmlArrayItemAttribute(GetType(ParameterValue))>  _
        Public Property ParameterValues() As ParameterValueOrFieldReference()
            Get
                Return Me.parameterValuesField
            End Get
            Set
                Me.parameterValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ParameterFieldReference
        Inherits ParameterValueOrFieldReference
        
        Private parameterNameField As String
        
        Private fieldAliasField As String
        
        '''<remarks/>
        Public Property ParameterName() As String
            Get
                Return Me.parameterNameField
            End Get
            Set
                Me.parameterNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FieldAlias() As String
            Get
                Return Me.fieldAliasField
            End Get
            Set
                Me.fieldAliasField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ParameterFieldReference)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ParameterValue)),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ParameterValueOrFieldReference
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ParameterValue
        Inherits ParameterValueOrFieldReference
        
        Private nameField As String
        
        Private valueField As String
        
        Private labelField As String
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Label() As String
            Get
                Return Me.labelField
            End Get
            Set
                Me.labelField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ActiveState
        
        Private deliveryExtensionRemovedField As Boolean
        
        Private deliveryExtensionRemovedFieldSpecified As Boolean
        
        Private sharedDataSourceRemovedField As Boolean
        
        Private sharedDataSourceRemovedFieldSpecified As Boolean
        
        Private missingParameterValueField As Boolean
        
        Private missingParameterValueFieldSpecified As Boolean
        
        Private invalidParameterValueField As Boolean
        
        Private invalidParameterValueFieldSpecified As Boolean
        
        Private unknownReportParameterField As Boolean
        
        Private unknownReportParameterFieldSpecified As Boolean
        
        '''<remarks/>
        Public Property DeliveryExtensionRemoved() As Boolean
            Get
                Return Me.deliveryExtensionRemovedField
            End Get
            Set
                Me.deliveryExtensionRemovedField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property DeliveryExtensionRemovedSpecified() As Boolean
            Get
                Return Me.deliveryExtensionRemovedFieldSpecified
            End Get
            Set
                Me.deliveryExtensionRemovedFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property SharedDataSourceRemoved() As Boolean
            Get
                Return Me.sharedDataSourceRemovedField
            End Get
            Set
                Me.sharedDataSourceRemovedField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property SharedDataSourceRemovedSpecified() As Boolean
            Get
                Return Me.sharedDataSourceRemovedFieldSpecified
            End Get
            Set
                Me.sharedDataSourceRemovedFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MissingParameterValue() As Boolean
            Get
                Return Me.missingParameterValueField
            End Get
            Set
                Me.missingParameterValueField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property MissingParameterValueSpecified() As Boolean
            Get
                Return Me.missingParameterValueFieldSpecified
            End Get
            Set
                Me.missingParameterValueFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property InvalidParameterValue() As Boolean
            Get
                Return Me.invalidParameterValueField
            End Get
            Set
                Me.invalidParameterValueField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property InvalidParameterValueSpecified() As Boolean
            Get
                Return Me.invalidParameterValueFieldSpecified
            End Get
            Set
                Me.invalidParameterValueFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnknownReportParameter() As Boolean
            Get
                Return Me.unknownReportParameterField
            End Get
            Set
                Me.unknownReportParameterField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property UnknownReportParameterSpecified() As Boolean
            Get
                Return Me.unknownReportParameterFieldSpecified
            End Get
            Set
                Me.unknownReportParameterFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ExtensionParameter
        
        Private nameField As String
        
        Private displayNameField As String
        
        Private requiredField As Boolean
        
        Private requiredFieldSpecified As Boolean
        
        Private readOnlyField As Boolean
        
        Private valueField As String
        
        Private errorField As String
        
        Private encryptedField As Boolean
        
        Private isPasswordField As Boolean
        
        Private validValuesField() As ValidValue
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property DisplayName() As String
            Get
                Return Me.displayNameField
            End Get
            Set
                Me.displayNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Required() As Boolean
            Get
                Return Me.requiredField
            End Get
            Set
                Me.requiredField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property RequiredSpecified() As Boolean
            Get
                Return Me.requiredFieldSpecified
            End Get
            Set
                Me.requiredFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property [ReadOnly]() As Boolean
            Get
                Return Me.readOnlyField
            End Get
            Set
                Me.readOnlyField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property [Error]() As String
            Get
                Return Me.errorField
            End Get
            Set
                Me.errorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Encrypted() As Boolean
            Get
                Return Me.encryptedField
            End Get
            Set
                Me.encryptedField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IsPassword() As Boolean
            Get
                Return Me.isPasswordField
            End Get
            Set
                Me.isPasswordField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Value")>  _
        Public Property ValidValues() As ValidValue()
            Get
                Return Me.validValuesField
            End Get
            Set
                Me.validValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ValidValue
        
        Private labelField As String
        
        Private valueField As String
        
        '''<remarks/>
        Public Property Label() As String
            Get
                Return Me.labelField
            End Get
            Set
                Me.labelField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class QueryDefinition
        
        Private commandTypeField As String
        
        Private commandTextField As String
        
        Private timeoutField As Integer
        
        Private timeoutFieldSpecified As Boolean
        
        '''<remarks/>
        Public Property CommandType() As String
            Get
                Return Me.commandTypeField
            End Get
            Set
                Me.commandTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CommandText() As String
            Get
                Return Me.commandTextField
            End Get
            Set
                Me.commandTextField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Timeout() As Integer
            Get
                Return Me.timeoutField
            End Get
            Set
                Me.timeoutField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property TimeoutSpecified() As Boolean
            Get
                Return Me.timeoutFieldSpecified
            End Get
            Set
                Me.timeoutFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Field
        
        Private aliasField As String
        
        Private nameField As String
        
        '''<remarks/>
        Public Property [Alias]() As String
            Get
                Return Me.aliasField
            End Get
            Set
                Me.aliasField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSetDefinition
        
        Private fieldsField() As Field
        
        Private queryField As QueryDefinition
        
        Private caseSensitivityField As SensitivityEnum
        
        Private caseSensitivityFieldSpecified As Boolean
        
        Private collationField As String
        
        Private accentSensitivityField As SensitivityEnum
        
        Private accentSensitivityFieldSpecified As Boolean
        
        Private kanatypeSensitivityField As SensitivityEnum
        
        Private kanatypeSensitivityFieldSpecified As Boolean
        
        Private widthSensitivityField As SensitivityEnum
        
        Private widthSensitivityFieldSpecified As Boolean
        
        Private nameField As String
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property Fields() As Field()
            Get
                Return Me.fieldsField
            End Get
            Set(ByVal value As Field())
                Me.fieldsField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Query() As QueryDefinition
            Get
                Return Me.queryField
            End Get
            Set
                Me.queryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CaseSensitivity() As SensitivityEnum
            Get
                Return Me.caseSensitivityField
            End Get
            Set
                Me.caseSensitivityField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property CaseSensitivitySpecified() As Boolean
            Get
                Return Me.caseSensitivityFieldSpecified
            End Get
            Set
                Me.caseSensitivityFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Collation() As String
            Get
                Return Me.collationField
            End Get
            Set
                Me.collationField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property AccentSensitivity() As SensitivityEnum
            Get
                Return Me.accentSensitivityField
            End Get
            Set
                Me.accentSensitivityField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property AccentSensitivitySpecified() As Boolean
            Get
                Return Me.accentSensitivityFieldSpecified
            End Get
            Set
                Me.accentSensitivityFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property KanatypeSensitivity() As SensitivityEnum
            Get
                Return Me.kanatypeSensitivityField
            End Get
            Set
                Me.kanatypeSensitivityField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property KanatypeSensitivitySpecified() As Boolean
            Get
                Return Me.kanatypeSensitivityFieldSpecified
            End Get
            Set
                Me.kanatypeSensitivityFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property WidthSensitivity() As SensitivityEnum
            Get
                Return Me.widthSensitivityField
            End Get
            Set
                Me.widthSensitivityField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property WidthSensitivitySpecified() As Boolean
            Get
                Return Me.widthSensitivityFieldSpecified
            End Get
            Set
                Me.widthSensitivityFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum SensitivityEnum

        '''<remarks/>
        [True]

        '''<remarks/>
        [False]

        '''<remarks/>
        [Auto]
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataRetrievalPlan
        
        Private itemField As DataSourceDefinitionOrReference
        
        Private dataSetField As DataSetDefinition
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", GetType(DataSourceDefinition)),  _
         System.Xml.Serialization.XmlElementAttribute("DataSourceReference", GetType(DataSourceReference)),  _
         System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", GetType(InvalidDataSourceReference))>  _
        Public Property Item() As DataSourceDefinitionOrReference
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property DataSet() As DataSetDefinition
            Get
                Return Me.dataSetField
            End Get
            Set
                Me.dataSetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSourceDefinition
        Inherits DataSourceDefinitionOrReference
        
        Private extensionField As String
        
        Private connectStringField As String
        
        Private useOriginalConnectStringField As Boolean
        
        Private originalConnectStringExpressionBasedField As Boolean
        
        Private credentialRetrievalField As CredentialRetrievalEnum
        
        Private windowsCredentialsField As Boolean
        
        Private impersonateUserField As Boolean
        
        Private impersonateUserFieldSpecified As Boolean
        
        Private promptField As String
        
        Private userNameField As String
        
        Private passwordField As String
        
        Private enabledField As Boolean
        
        Private enabledFieldSpecified As Boolean
        
        '''<remarks/>
        Public Property Extension() As String
            Get
                Return Me.extensionField
            End Get
            Set
                Me.extensionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ConnectString() As String
            Get
                Return Me.connectStringField
            End Get
            Set
                Me.connectStringField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UseOriginalConnectString() As Boolean
            Get
                Return Me.useOriginalConnectStringField
            End Get
            Set
                Me.useOriginalConnectStringField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property OriginalConnectStringExpressionBased() As Boolean
            Get
                Return Me.originalConnectStringExpressionBasedField
            End Get
            Set
                Me.originalConnectStringExpressionBasedField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CredentialRetrieval() As CredentialRetrievalEnum
            Get
                Return Me.credentialRetrievalField
            End Get
            Set
                Me.credentialRetrievalField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property WindowsCredentials() As Boolean
            Get
                Return Me.windowsCredentialsField
            End Get
            Set
                Me.windowsCredentialsField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ImpersonateUser() As Boolean
            Get
                Return Me.impersonateUserField
            End Get
            Set
                Me.impersonateUserField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ImpersonateUserSpecified() As Boolean
            Get
                Return Me.impersonateUserFieldSpecified
            End Get
            Set
                Me.impersonateUserFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set
                Me.promptField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Password() As String
            Get
                Return Me.passwordField
            End Get
            Set
                Me.passwordField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Enabled() As Boolean
            Get
                Return Me.enabledField
            End Get
            Set
                Me.enabledField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property EnabledSpecified() As Boolean
            Get
                Return Me.enabledFieldSpecified
            End Get
            Set
                Me.enabledFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum CredentialRetrievalEnum

        '''<remarks/>
        Prompt

        '''<remarks/>
        Store

        '''<remarks/>
        Integrated

        '''<remarks/>
        None
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(InvalidDataSourceReference)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(DataSourceReference)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(DataSourceDefinition)),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSourceDefinitionOrReference
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class InvalidDataSourceReference
        Inherits DataSourceDefinitionOrReference
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSourceReference
        Inherits DataSourceDefinitionOrReference
        
        Private referenceField As String
        
        '''<remarks/>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Schedule
        
        Private scheduleIDField As String
        
        Private nameField As String
        
        Private definitionField As ScheduleDefinition
        
        Private descriptionField As String
        
        Private creatorField As String
        
        Private nextRunTimeField As Date
        
        Private nextRunTimeFieldSpecified As Boolean
        
        Private lastRunTimeField As Date
        
        Private lastRunTimeFieldSpecified As Boolean
        
        Private referencesPresentField As Boolean
        
        Private stateField As ScheduleStateEnum
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ScheduleID() As String
            Get
                Return Me.scheduleIDField
            End Get
            Set(ByVal value As String)
                Me.scheduleIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Definition() As ScheduleDefinition
            Get
                Return Me.definitionField
            End Get
            Set
                Me.definitionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Creator() As String
            Get
                Return Me.creatorField
            End Get
            Set
                Me.creatorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property NextRunTime() As Date
            Get
                Return Me.nextRunTimeField
            End Get
            Set
                Me.nextRunTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property NextRunTimeSpecified() As Boolean
            Get
                Return Me.nextRunTimeFieldSpecified
            End Get
            Set
                Me.nextRunTimeFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastRunTime() As Date
            Get
                Return Me.lastRunTimeField
            End Get
            Set
                Me.lastRunTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property LastRunTimeSpecified() As Boolean
            Get
                Return Me.lastRunTimeFieldSpecified
            End Get
            Set
                Me.lastRunTimeFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ReferencesPresent() As Boolean
            Get
                Return Me.referencesPresentField
            End Get
            Set
                Me.referencesPresentField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property State() As ScheduleStateEnum
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ScheduleDefinition
        Inherits ScheduleDefinitionOrReference
        
        Private startDateTimeField As Date
        
        Private endDateField As Date
        
        Private endDateFieldSpecified As Boolean
        
        Private itemField As RecurrencePattern
        
        '''<remarks/>
        Public Property StartDateTime() As Date
            Get
                Return Me.startDateTimeField
            End Get
            Set
                Me.startDateTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EndDate() As Date
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property EndDateSpecified() As Boolean
            Get
                Return Me.endDateFieldSpecified
            End Get
            Set
                Me.endDateFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("MinuteRecurrence", GetType(MinuteRecurrence)),  _
         System.Xml.Serialization.XmlElementAttribute("MonthlyDOWRecurrence", GetType(MonthlyDOWRecurrence)),  _
         System.Xml.Serialization.XmlElementAttribute("WeeklyRecurrence", GetType(WeeklyRecurrence)),  _
         System.Xml.Serialization.XmlElementAttribute("MonthlyRecurrence", GetType(MonthlyRecurrence)),  _
         System.Xml.Serialization.XmlElementAttribute("DailyRecurrence", GetType(DailyRecurrence))>  _
        Public Property Item() As RecurrencePattern
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class MinuteRecurrence
        Inherits RecurrencePattern
        
        Private minutesIntervalField As Integer
        
        '''<remarks/>
        Public Property MinutesInterval() As Integer
            Get
                Return Me.minutesIntervalField
            End Get
            Set
                Me.minutesIntervalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(MonthlyDOWRecurrence)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(MonthlyRecurrence)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(DailyRecurrence)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(WeeklyRecurrence)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(MinuteRecurrence)),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class RecurrencePattern
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class MonthlyDOWRecurrence
        Inherits RecurrencePattern

        Private whichWeekField As WeekNumberEnum

        Private whichWeekFieldSpecified As Boolean

        Private daysOfWeekField As DaysOfWeekSelector

        Private monthsOfYearField As MonthsOfYearSelector

        '''<remarks/>
        Public Property WhichWeek() As WeekNumberEnum
            Get
                Return Me.whichWeekField
            End Get
            Set(ByVal value As WeekNumberEnum)
                Me.whichWeekField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property WhichWeekSpecified() As Boolean
            Get
                Return Me.whichWeekFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.whichWeekFieldSpecified = Value
            End Set
        End Property

        '''<remarks/>
        Public Property DaysOfWeek() As DaysOfWeekSelector
            Get
                Return Me.daysOfWeekField
            End Get
            Set(ByVal value As DaysOfWeekSelector)
                Me.daysOfWeekField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property MonthsOfYear() As MonthsOfYearSelector
            Get
                Return Me.monthsOfYearField
            End Get
            Set(ByVal value As MonthsOfYearSelector)
                Me.monthsOfYearField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum WeekNumberEnum

        '''<remarks/>
        FirstWeek

        '''<remarks/>
        SecondWeek

        '''<remarks/>
        ThirdWeek

        '''<remarks/>
        FourthWeek

        '''<remarks/>
        LastWeek
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DaysOfWeekSelector
        
        Private sundayField As Boolean
        
        Private mondayField As Boolean
        
        Private tuesdayField As Boolean
        
        Private wednesdayField As Boolean
        
        Private thursdayField As Boolean
        
        Private fridayField As Boolean
        
        Private saturdayField As Boolean
        
        '''<remarks/>
        Public Property Sunday() As Boolean
            Get
                Return Me.sundayField
            End Get
            Set
                Me.sundayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Monday() As Boolean
            Get
                Return Me.mondayField
            End Get
            Set
                Me.mondayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Tuesday() As Boolean
            Get
                Return Me.tuesdayField
            End Get
            Set
                Me.tuesdayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Wednesday() As Boolean
            Get
                Return Me.wednesdayField
            End Get
            Set
                Me.wednesdayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Thursday() As Boolean
            Get
                Return Me.thursdayField
            End Get
            Set
                Me.thursdayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Friday() As Boolean
            Get
                Return Me.fridayField
            End Get
            Set
                Me.fridayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Saturday() As Boolean
            Get
                Return Me.saturdayField
            End Get
            Set
                Me.saturdayField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class MonthsOfYearSelector
        
        Private januaryField As Boolean
        
        Private februaryField As Boolean
        
        Private marchField As Boolean
        
        Private aprilField As Boolean
        
        Private mayField As Boolean
        
        Private juneField As Boolean
        
        Private julyField As Boolean
        
        Private augustField As Boolean
        
        Private septemberField As Boolean
        
        Private octoberField As Boolean
        
        Private novemberField As Boolean
        
        Private decemberField As Boolean
        
        '''<remarks/>
        Public Property January() As Boolean
            Get
                Return Me.januaryField
            End Get
            Set
                Me.januaryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property February() As Boolean
            Get
                Return Me.februaryField
            End Get
            Set
                Me.februaryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property March() As Boolean
            Get
                Return Me.marchField
            End Get
            Set
                Me.marchField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property April() As Boolean
            Get
                Return Me.aprilField
            End Get
            Set
                Me.aprilField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property May() As Boolean
            Get
                Return Me.mayField
            End Get
            Set
                Me.mayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property June() As Boolean
            Get
                Return Me.juneField
            End Get
            Set
                Me.juneField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property July() As Boolean
            Get
                Return Me.julyField
            End Get
            Set
                Me.julyField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property August() As Boolean
            Get
                Return Me.augustField
            End Get
            Set
                Me.augustField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property September() As Boolean
            Get
                Return Me.septemberField
            End Get
            Set
                Me.septemberField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property October() As Boolean
            Get
                Return Me.octoberField
            End Get
            Set
                Me.octoberField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property November() As Boolean
            Get
                Return Me.novemberField
            End Get
            Set
                Me.novemberField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property December() As Boolean
            Get
                Return Me.decemberField
            End Get
            Set
                Me.decemberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class MonthlyRecurrence
        Inherits RecurrencePattern
        
        Private daysField As String
        
        Private monthsOfYearField As MonthsOfYearSelector
        
        '''<remarks/>
        Public Property Days() As String
            Get
                Return Me.daysField
            End Get
            Set
                Me.daysField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MonthsOfYear() As MonthsOfYearSelector
            Get
                Return Me.monthsOfYearField
            End Get
            Set
                Me.monthsOfYearField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DailyRecurrence
        Inherits RecurrencePattern
        
        Private daysIntervalField As Integer
        
        '''<remarks/>
        Public Property DaysInterval() As Integer
            Get
                Return Me.daysIntervalField
            End Get
            Set
                Me.daysIntervalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class WeeklyRecurrence
        Inherits RecurrencePattern
        
        Private weeksIntervalField As Integer
        
        Private weeksIntervalFieldSpecified As Boolean
        
        Private daysOfWeekField As DaysOfWeekSelector
        
        '''<remarks/>
        Public Property WeeksInterval() As Integer
            Get
                Return Me.weeksIntervalField
            End Get
            Set
                Me.weeksIntervalField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property WeeksIntervalSpecified() As Boolean
            Get
                Return Me.weeksIntervalFieldSpecified
            End Get
            Set
                Me.weeksIntervalFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property DaysOfWeek() As DaysOfWeekSelector
            Get
                Return Me.daysOfWeekField
            End Get
            Set
                Me.daysOfWeekField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(NoSchedule)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ScheduleReference)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ScheduleDefinition)),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ScheduleDefinitionOrReference
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class NoSchedule
        Inherits ScheduleDefinitionOrReference
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ScheduleReference
        Inherits ScheduleDefinitionOrReference
        
        Private scheduleIDField As String
        
        Private definitionField As ScheduleDefinition
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ScheduleID() As String
            Get
                Return Me.scheduleIDField
            End Get
            Set(ByVal value As String)
                Me.scheduleIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Definition() As ScheduleDefinition
            Get
                Return Me.definitionField
            End Get
            Set
                Me.definitionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ScheduleStateEnum

        '''<remarks/>
        Ready

        '''<remarks/>
        Running

        '''<remarks/>
        Paused

        '''<remarks/>
        Expired

        '''<remarks/>
        Failing
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ReportHistorySnapshot
        
        Private historyIDField As String
        
        Private creationDateField As Date
        
        Private sizeField As Integer
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property HistoryID() As String
            Get
                Return Me.historyIDField
            End Get
            Set(ByVal value As String)
                Me.historyIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreationDate() As Date
            Get
                Return Me.creationDateField
            End Get
            Set
                Me.creationDateField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Size() As Integer
            Get
                Return Me.sizeField
            End Get
            Set
                Me.sizeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSourcePrompt
        
        Private nameField As String
        
        Private dataSourceIDField As String
        
        Private promptField As String
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property DataSourceID() As String
            Get
                Return Me.dataSourceIDField
            End Get
            Set(ByVal value As String)
                Me.dataSourceIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set
                Me.promptField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSource
        
        Private nameField As String
        
        Private itemField As DataSourceDefinitionOrReference
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", GetType(DataSourceDefinition)),  _
         System.Xml.Serialization.XmlElementAttribute("DataSourceReference", GetType(DataSourceReference)),  _
         System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", GetType(InvalidDataSourceReference))>  _
        Public Property Item() As DataSourceDefinitionOrReference
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Job
        
        Private jobIDField As String
        
        Private nameField As String
        
        Private pathField As String
        
        Private descriptionField As String
        
        Private machineField As String
        
        Private userField As String
        
        Private startDateTimeField As Date
        
        Private actionField As JobActionEnum
        
        Private typeField As JobTypeEnum
        
        Private statusField As JobStatusEnum
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property JobID() As String
            Get
                Return Me.jobIDField
            End Get
            Set(ByVal value As String)
                Me.jobIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Path() As String
            Get
                Return Me.pathField
            End Get
            Set
                Me.pathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Machine() As String
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property User() As String
            Get
                Return Me.userField
            End Get
            Set
                Me.userField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property StartDateTime() As Date
            Get
                Return Me.startDateTimeField
            End Get
            Set
                Me.startDateTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Action() As JobActionEnum
            Get
                Return Me.actionField
            End Get
            Set
                Me.actionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Type() As JobTypeEnum
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Status() As JobStatusEnum
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum JobActionEnum

        '''<remarks/>
        Render

        '''<remarks/>
        SnapshotCreation

        '''<remarks/>
        ReportHistoryCreation

        '''<remarks/>
        ExecuteQuery
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum JobTypeEnum

        '''<remarks/>
        User

        '''<remarks/>
        System
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum JobStatusEnum

        '''<remarks/>
        [New]

        '''<remarks/>
        Running

        '''<remarks/>
        CancelRequested
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(TimeExpiration)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ScheduleExpiration)),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ExpirationDefinition
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class TimeExpiration
        Inherits ExpirationDefinition
        
        Private minutesField As Integer
        
        '''<remarks/>
        Public Property Minutes() As Integer
            Get
                Return Me.minutesField
            End Get
            Set
                Me.minutesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ScheduleExpiration
        Inherits ExpirationDefinition
        
        Private itemField As ScheduleDefinitionOrReference
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ScheduleReference", GetType(ScheduleReference)),  _
         System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", GetType(ScheduleDefinition))>  _
        Public Property Item() As ScheduleDefinitionOrReference
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class ReportParameter
        
        Private nameField As String
        
        Private typeField As ParameterTypeEnum
        
        Private typeFieldSpecified As Boolean
        
        Private nullableField As Boolean
        
        Private nullableFieldSpecified As Boolean
        
        Private allowBlankField As Boolean
        
        Private allowBlankFieldSpecified As Boolean
        
        Private multiValueField As Boolean
        
        Private multiValueFieldSpecified As Boolean
        
        Private queryParameterField As Boolean
        
        Private queryParameterFieldSpecified As Boolean
        
        Private promptField As String
        
        Private promptUserField As Boolean
        
        Private promptUserFieldSpecified As Boolean
        
        Private dependenciesField() As String
        
        Private validValuesQueryBasedField As Boolean
        
        Private validValuesQueryBasedFieldSpecified As Boolean
        
        Private validValuesField() As ValidValue
        
        Private defaultValuesQueryBasedField As Boolean
        
        Private defaultValuesQueryBasedFieldSpecified As Boolean
        
        Private defaultValuesField() As String
        
        Private stateField As ParameterStateEnum
        
        Private stateFieldSpecified As Boolean
        
        Private errorMessageField As String
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Type() As ParameterTypeEnum
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
            Set
                Me.typeFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Nullable() As Boolean
            Get
                Return Me.nullableField
            End Get
            Set
                Me.nullableField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property NullableSpecified() As Boolean
            Get
                Return Me.nullableFieldSpecified
            End Get
            Set
                Me.nullableFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property AllowBlank() As Boolean
            Get
                Return Me.allowBlankField
            End Get
            Set
                Me.allowBlankField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property AllowBlankSpecified() As Boolean
            Get
                Return Me.allowBlankFieldSpecified
            End Get
            Set
                Me.allowBlankFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MultiValue() As Boolean
            Get
                Return Me.multiValueField
            End Get
            Set
                Me.multiValueField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property MultiValueSpecified() As Boolean
            Get
                Return Me.multiValueFieldSpecified
            End Get
            Set
                Me.multiValueFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property QueryParameter() As Boolean
            Get
                Return Me.queryParameterField
            End Get
            Set
                Me.queryParameterField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property QueryParameterSpecified() As Boolean
            Get
                Return Me.queryParameterFieldSpecified
            End Get
            Set
                Me.queryParameterFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set
                Me.promptField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property PromptUser() As Boolean
            Get
                Return Me.promptUserField
            End Get
            Set
                Me.promptUserField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property PromptUserSpecified() As Boolean
            Get
                Return Me.promptUserFieldSpecified
            End Get
            Set
                Me.promptUserFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Dependency")>  _
        Public Property Dependencies() As String()
            Get
                Return Me.dependenciesField
            End Get
            Set
                Me.dependenciesField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ValidValuesQueryBased() As Boolean
            Get
                Return Me.validValuesQueryBasedField
            End Get
            Set
                Me.validValuesQueryBasedField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ValidValuesQueryBasedSpecified() As Boolean
            Get
                Return Me.validValuesQueryBasedFieldSpecified
            End Get
            Set
                Me.validValuesQueryBasedFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property ValidValues() As ValidValue()
            Get
                Return Me.validValuesField
            End Get
            Set(ByVal value As ValidValue())
                Me.validValuesField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property DefaultValuesQueryBased() As Boolean
            Get
                Return Me.defaultValuesQueryBasedField
            End Get
            Set
                Me.defaultValuesQueryBasedField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property DefaultValuesQueryBasedSpecified() As Boolean
            Get
                Return Me.defaultValuesQueryBasedFieldSpecified
            End Get
            Set
                Me.defaultValuesQueryBasedFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Value")>  _
        Public Property DefaultValues() As String()
            Get
                Return Me.defaultValuesField
            End Get
            Set
                Me.defaultValuesField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property State() As ParameterStateEnum
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property StateSpecified() As Boolean
            Get
                Return Me.stateFieldSpecified
            End Get
            Set
                Me.stateFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ErrorMessage() As String
            Get
                Return Me.errorMessageField
            End Get
            Set
                Me.errorMessageField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ParameterTypeEnum

        '''<remarks/>
        [Boolean]

        '''<remarks/>
        DateTime

        '''<remarks/>
        [Integer]

        '''<remarks/>
        Float

        '''<remarks/>
        [String]
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ParameterStateEnum

        '''<remarks/>
        HasValidValue

        '''<remarks/>
        MissingValidValue

        '''<remarks/>
        HasOutstandingDependencies

        '''<remarks/>
        DynamicValuesUnavailable
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class DataSourceCredentials
        
        Private dataSourceNameField As String
        
        Private userNameField As String
        
        Private passwordField As String
        
        '''<remarks/>
        Public Property DataSourceName() As String
            Get
                Return Me.dataSourceNameField
            End Get
            Set
                Me.dataSourceNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Password() As String
            Get
                Return Me.passwordField
            End Get
            Set
                Me.passwordField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class Warning
        
        Private codeField As String
        
        Private severityField As String
        
        Private objectNameField As String
        
        Private objectTypeField As String
        
        Private messageField As String
        
        '''<remarks/>
        Public Property Code() As String
            Get
                Return Me.codeField
            End Get
            Set
                Me.codeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Severity() As String
            Get
                Return Me.severityField
            End Get
            Set
                Me.severityField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ObjectName() As String
            Get
                Return Me.objectNameField
            End Get
            Set
                Me.objectNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ObjectType() As String
            Get
                Return Me.objectTypeField
            End Get
            Set
                Me.objectTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class CatalogItem
        
        Private idField As String
        
        Private nameField As String
        
        Private pathField As String
        
        Private virtualPathField As String
        
        Private typeField As ItemTypeEnum
        
        Private sizeField As Integer
        
        Private sizeFieldSpecified As Boolean
        
        Private descriptionField As String
        
        Private hiddenField As Boolean
        
        Private hiddenFieldSpecified As Boolean
        
        Private creationDateField As Date
        
        Private creationDateFieldSpecified As Boolean
        
        Private modifiedDateField As Date
        
        Private modifiedDateFieldSpecified As Boolean
        
        Private createdByField As String
        
        Private modifiedByField As String
        
        Private mimeTypeField As String
        
        Private executionDateField As Date
        
        Private executionDateFieldSpecified As Boolean
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ID() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Path() As String
            Get
                Return Me.pathField
            End Get
            Set
                Me.pathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property VirtualPath() As String
            Get
                Return Me.virtualPathField
            End Get
            Set
                Me.virtualPathField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Type() As ItemTypeEnum
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Size() As Integer
            Get
                Return Me.sizeField
            End Get
            Set
                Me.sizeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property SizeSpecified() As Boolean
            Get
                Return Me.sizeFieldSpecified
            End Get
            Set
                Me.sizeFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Hidden() As Boolean
            Get
                Return Me.hiddenField
            End Get
            Set
                Me.hiddenField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property HiddenSpecified() As Boolean
            Get
                Return Me.hiddenFieldSpecified
            End Get
            Set
                Me.hiddenFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreationDate() As Date
            Get
                Return Me.creationDateField
            End Get
            Set
                Me.creationDateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property CreationDateSpecified() As Boolean
            Get
                Return Me.creationDateFieldSpecified
            End Get
            Set
                Me.creationDateFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ModifiedDate() As Date
            Get
                Return Me.modifiedDateField
            End Get
            Set
                Me.modifiedDateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ModifiedDateSpecified() As Boolean
            Get
                Return Me.modifiedDateFieldSpecified
            End Get
            Set
                Me.modifiedDateFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreatedBy() As String
            Get
                Return Me.createdByField
            End Get
            Set
                Me.createdByField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ModifiedBy() As String
            Get
                Return Me.modifiedByField
            End Get
            Set
                Me.modifiedByField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MimeType() As String
            Get
                Return Me.mimeTypeField
            End Get
            Set
                Me.mimeTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ExecutionDate() As Date
            Get
                Return Me.executionDateField
            End Get
            Set
                Me.executionDateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ExecutionDateSpecified() As Boolean
            Get
                Return Me.executionDateFieldSpecified
            End Get
            Set
                Me.executionDateFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ItemTypeEnum

        '''<remarks/>
        Unknown

        '''<remarks/>
        Folder

        '''<remarks/>
        Report

        '''<remarks/>
        Resource

        '''<remarks/>
        LinkedReport

        '''<remarks/>
        DataSource

        '''<remarks/>
        Model
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(SearchCondition)), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class [Property]

        Private nameField As String

        Private valueField As String

        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set(ByVal value As String)
                Me.valueField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")>  _
    Partial Public Class SearchCondition
        Inherits [Property]
        
        Private conditionField As ConditionEnum
        
        Private conditionFieldSpecified As Boolean
        
        '''<remarks/>
        Public Property Condition() As ConditionEnum
            Get
                Return Me.conditionField
            End Get
            Set
                Me.conditionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ConditionSpecified() As Boolean
            Get
                Return Me.conditionFieldSpecified
            End Get
            Set
                Me.conditionFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ConditionEnum

        '''<remarks/>
        Contains

        '''<remarks/>
        Equals
    End Enum
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable:=false)>  _
    Partial Public Class BatchHeader
        Inherits System.Web.Services.Protocols.SoapHeader
        
        Private batchIDField As String
        
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields")> Private anyAttrField() As System.Xml.XmlAttribute
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property BatchID() As String
            Get
                Return Me.batchIDField
            End Get
            Set(ByVal value As String)
                Me.batchIDField = Value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()>  _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set
                Me.anyAttrField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable:=false)>  _
    Partial Public Class ItemNamespaceHeader
        Inherits System.Web.Services.Protocols.SoapHeader
        
        Private itemNamespaceField As ItemNamespaceEnum
        
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields")> Private anyAttrField() As System.Xml.XmlAttribute
        
        '''<remarks/>
        Public Property ItemNamespace() As ItemNamespaceEnum
            Get
                Return Me.itemNamespaceField
            End Get
            Set
                Me.itemNamespaceField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()>  _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set
                Me.anyAttrField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ItemNamespaceEnum

        '''<remarks/>
        PathBased

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId:="Member")> GUIDBased
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ExecutionSettingEnum

        '''<remarks/>
        Live

        '''<remarks/>
        Snapshot
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum BooleanOperatorEnum

        '''<remarks/>
        [And]

        '''<remarks/>
        [Or]
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum SecurityScopeEnum

        '''<remarks/>
        System

        '''<remarks/>
        Catalog

        '''<remarks/>
        Model

        '''<remarks/>
        All
    End Enum
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListSecureMethodsCompletedEventHandler(ByVal sender As Object, ByVal e As ListSecureMethodsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListSecureMethodsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateBatchCompletedEventHandler(ByVal sender As Object, ByVal e As CreateBatchCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateBatchCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CancelBatchCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ExecuteBatchCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetSystemPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetSystemPropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetSystemPropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As [Property]()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), [Property]())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetSystemPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DeleteItemCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub MoveItemCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListChildrenCompletedEventHandler(ByVal sender As Object, ByVal e As ListChildrenCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListChildrenCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As CatalogItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), CatalogItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListDependentItemsCompletedEventHandler(ByVal sender As Object, ByVal e As ListDependentItemsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListDependentItemsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As CatalogItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), CatalogItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetPropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetPropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As [Property]()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), [Property]())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetItemTypeCompletedEventHandler(ByVal sender As Object, ByVal e As GetItemTypeCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetItemTypeCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As ItemTypeEnum
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),ItemTypeEnum)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateFolderCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateReportCompletedEventHandler(ByVal sender As Object, ByVal e As CreateReportCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateReportCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetReportDefinitionCompletedEventHandler(ByVal sender As Object, ByVal e As GetReportDefinitionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetReportDefinitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetReportDefinitionCompletedEventHandler(ByVal sender As Object, ByVal e As SetReportDefinitionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class SetReportDefinitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateResourceCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetResourceContentsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetResourceContentsCompletedEventHandler(ByVal sender As Object, ByVal e As GetResourceContentsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetResourceContentsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MimeType() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetReportParametersCompletedEventHandler(ByVal sender As Object, ByVal e As GetReportParametersCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetReportParametersCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ReportParameter()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ReportParameter())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetReportParametersCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateLinkedReportCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetReportLinkCompletedEventHandler(ByVal sender As Object, ByVal e As GetReportLinkCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetReportLinkCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetReportLinkCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetRenderResourceCompletedEventHandler(ByVal sender As Object, ByVal e As GetRenderResourceCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetRenderResourceCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MimeType() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetExecutionOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetExecutionOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetExecutionOptionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetExecutionOptionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionSettingEnum
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),ExecutionSettingEnum)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Item() As ScheduleDefinitionOrReference
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),ScheduleDefinitionOrReference)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetCacheOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetCacheOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetCacheOptionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetCacheOptionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Item() As ExpirationDefinition
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),ExpirationDefinition)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub UpdateReportExecutionSnapshotCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub FlushCacheCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListJobsCompletedEventHandler(ByVal sender As Object, ByVal e As ListJobsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListJobsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Job()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Job())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CancelJobCompletedEventHandler(ByVal sender As Object, ByVal e As CancelJobCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CancelJobCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateDataSourceCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetDataSourceContentsCompletedEventHandler(ByVal sender As Object, ByVal e As GetDataSourceContentsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetDataSourceContentsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DataSourceDefinition
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DataSourceDefinition)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetDataSourceContentsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub EnableDataSourceCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DisableDataSourceCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetItemDataSourcesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetItemDataSourcesCompletedEventHandler(ByVal sender As Object, ByVal e As GetItemDataSourcesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetItemDataSourcesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As DataSource()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), DataSource())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetItemDataSourcePromptsCompletedEventHandler(ByVal sender As Object, ByVal e As GetItemDataSourcePromptsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetItemDataSourcePromptsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As DataSourcePrompt()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), DataSourcePrompt())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateReportHistorySnapshotCompletedEventHandler(ByVal sender As Object, ByVal e As CreateReportHistorySnapshotCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateReportHistorySnapshotCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Warnings() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetReportHistoryOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetReportHistoryOptionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetReportHistoryOptionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetReportHistoryOptionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property KeepExecutionSnapshots() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Item() As ScheduleDefinitionOrReference
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),ScheduleDefinitionOrReference)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetReportHistoryLimitCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetReportHistoryLimitCompletedEventHandler(ByVal sender As Object, ByVal e As GetReportHistoryLimitCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetReportHistoryLimitCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property IsSystem() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property SystemLimit() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),Integer)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListReportHistoryCompletedEventHandler(ByVal sender As Object, ByVal e As ListReportHistoryCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListReportHistoryCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ReportHistorySnapshot()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ReportHistorySnapshot())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DeleteReportHistorySnapshotCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub FindItemsCompletedEventHandler(ByVal sender As Object, ByVal e As FindItemsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class FindItemsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As CatalogItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), CatalogItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateScheduleCompletedEventHandler(ByVal sender As Object, ByVal e As CreateScheduleCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateScheduleCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DeleteScheduleCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetSchedulePropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetSchedulePropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetSchedulePropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetSchedulePropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Schedule
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Schedule)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListScheduledReportsCompletedEventHandler(ByVal sender As Object, ByVal e As ListScheduledReportsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListScheduledReportsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As CatalogItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), CatalogItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListSchedulesCompletedEventHandler(ByVal sender As Object, ByVal e As ListSchedulesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListSchedulesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Schedule()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Schedule())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub PauseScheduleCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ResumeScheduleCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateSubscriptionCompletedEventHandler(ByVal sender As Object, ByVal e As CreateSubscriptionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateSubscriptionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateDataDrivenSubscriptionCompletedEventHandler(ByVal sender As Object, ByVal e As CreateDataDrivenSubscriptionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateDataDrivenSubscriptionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetSubscriptionPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetDataDrivenSubscriptionPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetSubscriptionPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetSubscriptionPropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetSubscriptionPropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property ExtensionSettings() As ExtensionSettings
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),ExtensionSettings)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Description() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Active() As ActiveState
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(3),ActiveState)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Status() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(4),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property EventType() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(5),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MatchData() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(6),String)
            End Get
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Parameters() As ParameterValue()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(7), ParameterValue())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetDataDrivenSubscriptionPropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetDataDrivenSubscriptionPropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetDataDrivenSubscriptionPropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property ExtensionSettings() As ExtensionSettings
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),ExtensionSettings)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property DataRetrievalPlan() As DataRetrievalPlan
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(2),DataRetrievalPlan)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Description() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(3),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Active() As ActiveState
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(4),ActiveState)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Status() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(5),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property EventType() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(6),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MatchData() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(7),String)
            End Get
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Parameters() As ParameterValueOrFieldReference()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(8), ParameterValueOrFieldReference())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DeleteSubscriptionCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub PrepareQueryCompletedEventHandler(ByVal sender As Object, ByVal e As PrepareQueryCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class PrepareQueryCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DataSetDefinition
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DataSetDefinition)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Changed() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property ParameterNames() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetExtensionSettingsCompletedEventHandler(ByVal sender As Object, ByVal e As GetExtensionSettingsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetExtensionSettingsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ExtensionParameter()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExtensionParameter())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ValidateExtensionSettingsCompletedEventHandler(ByVal sender As Object, ByVal e As ValidateExtensionSettingsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ValidateExtensionSettingsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ExtensionParameter()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExtensionParameter())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListSubscriptionsCompletedEventHandler(ByVal sender As Object, ByVal e As ListSubscriptionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListSubscriptionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Subscription()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Subscription())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListSubscriptionsUsingDataSourceCompletedEventHandler(ByVal sender As Object, ByVal e As ListSubscriptionsUsingDataSourceCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListSubscriptionsUsingDataSourceCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Subscription()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Subscription())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListExtensionsCompletedEventHandler(ByVal sender As Object, ByVal e As ListExtensionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListExtensionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Extension()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Extension())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListEventsCompletedEventHandler(ByVal sender As Object, ByVal e As ListEventsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListEventsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As [Event]()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), [Event]())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub FireEventCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListTasksCompletedEventHandler(ByVal sender As Object, ByVal e As ListTasksCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListTasksCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Task()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Task())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListRolesCompletedEventHandler(ByVal sender As Object, ByVal e As ListRolesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListRolesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Role()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Role())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateRoleCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub DeleteRoleCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetRolePropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As GetRolePropertiesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetRolePropertiesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Task()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Task())
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property Description() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetRolePropertiesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetSystemPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As GetSystemPoliciesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetSystemPoliciesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Policy()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Policy())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetSystemPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As GetPoliciesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetPoliciesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Policy()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Policy())
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property InheritParent() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub InheritParentSecurityCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetSystemPermissionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetSystemPermissionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetSystemPermissionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetPermissionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetPermissionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetPermissionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LogonUserCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LogoffCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub CreateModelCompletedEventHandler(ByVal sender As Object, ByVal e As CreateModelCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class CreateModelCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetModelDefinitionCompletedEventHandler(ByVal sender As Object, ByVal e As GetModelDefinitionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetModelDefinitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetModelDefinitionCompletedEventHandler(ByVal sender As Object, ByVal e As SetModelDefinitionCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class SetModelDefinitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListModelPerspectivesCompletedEventHandler(ByVal sender As Object, ByVal e As ListModelPerspectivesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListModelPerspectivesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ModelCatalogItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ModelCatalogItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetUserModelCompletedEventHandler(ByVal sender As Object, ByVal e As GetUserModelCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetUserModelCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListModelItemChildrenCompletedEventHandler(ByVal sender As Object, ByVal e As ListModelItemChildrenCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListModelItemChildrenCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ModelItem()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ModelItem())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetModelItemPermissionsCompletedEventHandler(ByVal sender As Object, ByVal e As GetModelItemPermissionsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetModelItemPermissionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetModelItemPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As GetModelItemPoliciesCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GetModelItemPoliciesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Policy()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Policy())
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property InheritParent() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetModelItemPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub InheritModelItemParentSecurityCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub RemoveAllModelItemPoliciesCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetModelDrillthroughReportsCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListModelDrillthroughReportsCompletedEventHandler(ByVal sender As Object, ByVal e As ListModelDrillthroughReportsCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class ListModelDrillthroughReportsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As ModelDrillthroughReport()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ModelDrillthroughReport())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GenerateModelCompletedEventHandler(ByVal sender As Object, ByVal e As GenerateModelCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class GenerateModelCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub RegenerateModelCompletedEventHandler(ByVal sender As Object, ByVal e As RegenerateModelCompletedEventArgs)
    
    '''<remarks/>
    Partial Public Class RegenerateModelCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Warning())
            End Get
        End Property
    End Class
End Namespace

Namespace ReportExecutionService

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")> <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="ReportExecutionServiceSoap", [Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"), _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ParameterValueOrFieldReference))> _
    Partial Public Class ReportExecutionService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private serverInfoHeaderValueField As ServerInfoHeader

        Private ListSecureMethodsOperationCompleted As System.Threading.SendOrPostCallback

        Private executionHeaderValueField As ExecutionHeader

        Private LoadReportOperationCompleted As System.Threading.SendOrPostCallback

        Private LoadReportDefinitionOperationCompleted As System.Threading.SendOrPostCallback

        Private SetExecutionCredentialsOperationCompleted As System.Threading.SendOrPostCallback

        Private SetExecutionParametersOperationCompleted As System.Threading.SendOrPostCallback

        Private ResetExecutionOperationCompleted As System.Threading.SendOrPostCallback

        Private RenderOperationCompleted As System.Threading.SendOrPostCallback

        Private RenderStreamOperationCompleted As System.Threading.SendOrPostCallback

        Private GetExecutionInfoOperationCompleted As System.Threading.SendOrPostCallback

        Private GetDocumentMapOperationCompleted As System.Threading.SendOrPostCallback

        Private LoadDrillthroughTargetOperationCompleted As System.Threading.SendOrPostCallback

        Private ToggleItemOperationCompleted As System.Threading.SendOrPostCallback

        Private NavigateDocumentMapOperationCompleted As System.Threading.SendOrPostCallback

        Private NavigateBookmarkOperationCompleted As System.Threading.SendOrPostCallback

        Private FindStringOperationCompleted As System.Threading.SendOrPostCallback

        Private SortOperationCompleted As System.Threading.SendOrPostCallback

        Private GetRenderResourceOperationCompleted As System.Threading.SendOrPostCallback

        Private ListRenderingExtensionsOperationCompleted As System.Threading.SendOrPostCallback

        Private LogonUserOperationCompleted As System.Threading.SendOrPostCallback

        Private LogoffOperationCompleted As System.Threading.SendOrPostCallback

        Private useDefaultCredentialsSetExplicitly As Boolean

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
                Me.UseDefaultCredentials = True
                Me.useDefaultCredentialsSetExplicitly = False
            Else
                Me.useDefaultCredentialsSetExplicitly = True
            End If
        End Sub

        Public Property ServerInfoHeaderValue() As ServerInfoHeader
            Get
                Return Me.serverInfoHeaderValueField
            End Get
            Set(ByVal value As ServerInfoHeader)
                Me.serverInfoHeaderValueField = value
            End Set
        End Property

        Public Property ExecutionHeaderValue() As ExecutionHeader
            Get
                Return Me.executionHeaderValueField
            End Get
            Set(ByVal value As ExecutionHeader)
                Me.executionHeaderValueField = value
            End Set
        End Property

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")> Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set(ByVal value As String)
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = False)) Then
                    MyBase.UseDefaultCredentials = False
                End If
                MyBase.Url = value
            End Set
        End Property

        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set(ByVal value As Boolean)
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = True
            End Set
        End Property

        '''<remarks/>
        Public Event ListSecureMethodsCompleted As ListSecureMethodsCompletedEventHandler

        '''<remarks/>
        Public Event LoadReportCompleted As LoadReportCompletedEventHandler

        '''<remarks/>
        Public Event LoadReportDefinitionCompleted As LoadReportDefinitionCompletedEventHandler

        '''<remarks/>
        Public Event SetExecutionCredentialsCompleted As SetExecutionCredentialsCompletedEventHandler

        '''<remarks/>
        Public Event SetExecutionParametersCompleted As SetExecutionParametersCompletedEventHandler

        '''<remarks/>
        Public Event ResetExecutionCompleted As ResetExecutionCompletedEventHandler

        '''<remarks/>
        Public Event RenderCompleted As RenderCompletedEventHandler

        '''<remarks/>
        Public Event RenderStreamCompleted As RenderStreamCompletedEventHandler

        '''<remarks/>
        Public Event GetExecutionInfoCompleted As GetExecutionInfoCompletedEventHandler

        '''<remarks/>
        Public Event GetDocumentMapCompleted As GetDocumentMapCompletedEventHandler

        '''<remarks/>
        Public Event LoadDrillthroughTargetCompleted As LoadDrillthroughTargetCompletedEventHandler

        '''<remarks/>
        Public Event ToggleItemCompleted As ToggleItemCompletedEventHandler

        '''<remarks/>
        Public Event NavigateDocumentMapCompleted As NavigateDocumentMapCompletedEventHandler

        '''<remarks/>
        Public Event NavigateBookmarkCompleted As NavigateBookmarkCompletedEventHandler

        '''<remarks/>
        Public Event FindStringCompleted As FindStringCompletedEventHandler

        '''<remarks/>
        Public Event SortCompleted As SortCompletedEventHandler

        '''<remarks/>
        Public Event GetRenderResourceCompleted As GetRenderResourceCompletedEventHandler

        '''<remarks/>
        Public Event ListRenderingExtensionsCompleted As ListRenderingExtensionsCompletedEventHandler

        '''<remarks/>
        Public Event LogonUserCompleted As LogonUserCompletedEventHandler

        '''<remarks/>
        Public Event LogoffCompleted As LogoffCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" & _
            "tSecureMethods", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListSecureMethods() As String()
            Dim results() As Object = Me.Invoke("ListSecureMethods", New Object(-1) {})
            Return CType(results(0), String())
        End Function

        '''<remarks/>
        Public Overloads Sub ListSecureMethodsAsync()
            Me.ListSecureMethodsAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ListSecureMethodsAsync(ByVal userState As Object)
            If (Me.ListSecureMethodsOperationCompleted Is Nothing) Then
                Me.ListSecureMethodsOperationCompleted = AddressOf Me.OnListSecureMethodsOperationCompleted
            End If
            Me.InvokeAsync("ListSecureMethods", New Object(-1) {}, Me.ListSecureMethodsOperationCompleted, userState)
        End Sub

        Private Sub OnListSecureMethodsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListSecureMethodsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListSecureMethodsCompleted(Me, New ListSecureMethodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" & _
            "dReport", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function LoadReport(ByVal Report As String, ByVal HistoryID As String) As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("LoadReport", New Object() {Report, HistoryID})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub LoadReportAsync(ByVal Report As String, ByVal HistoryID As String)
            Me.LoadReportAsync(Report, HistoryID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LoadReportAsync(ByVal Report As String, ByVal HistoryID As String, ByVal userState As Object)
            If (Me.LoadReportOperationCompleted Is Nothing) Then
                Me.LoadReportOperationCompleted = AddressOf Me.OnLoadReportOperationCompleted
            End If
            Me.InvokeAsync("LoadReport", New Object() {Report, HistoryID}, Me.LoadReportOperationCompleted, userState)
        End Sub

        Private Sub OnLoadReportOperationCompleted(ByVal arg As Object)
            If (Not (Me.LoadReportCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LoadReportCompleted(Me, New LoadReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" & _
            "dReportDefinition", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function LoadReportDefinition(<System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Definition() As Byte, ByRef warnings() As Warning) As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("LoadReportDefinition", New Object() {Definition})
            warnings = CType(results(1), Warning())
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub LoadReportDefinitionAsync(ByVal Definition() As Byte)
            Me.LoadReportDefinitionAsync(Definition, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LoadReportDefinitionAsync(ByVal Definition() As Byte, ByVal userState As Object)
            If (Me.LoadReportDefinitionOperationCompleted Is Nothing) Then
                Me.LoadReportDefinitionOperationCompleted = AddressOf Me.OnLoadReportDefinitionOperationCompleted
            End If
            Me.InvokeAsync("LoadReportDefinition", New Object() {Definition}, Me.LoadReportDefinitionOperationCompleted, userState)
        End Sub

        Private Sub OnLoadReportDefinitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.LoadReportDefinitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LoadReportDefinitionCompleted(Me, New LoadReportDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "ExecutionCredentials", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function SetExecutionCredentials(ByVal Credentials() As DataSourceCredentials) As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("SetExecutionCredentials", New Object() {Credentials})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub SetExecutionCredentialsAsync(ByVal Credentials() As DataSourceCredentials)
            Me.SetExecutionCredentialsAsync(Credentials, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetExecutionCredentialsAsync(ByVal Credentials() As DataSourceCredentials, ByVal userState As Object)
            If (Me.SetExecutionCredentialsOperationCompleted Is Nothing) Then
                Me.SetExecutionCredentialsOperationCompleted = AddressOf Me.OnSetExecutionCredentialsOperationCompleted
            End If
            Me.InvokeAsync("SetExecutionCredentials", New Object() {Credentials}, Me.SetExecutionCredentialsOperationCompleted, userState)
        End Sub

        Private Sub OnSetExecutionCredentialsOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetExecutionCredentialsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetExecutionCredentialsCompleted(Me, New SetExecutionCredentialsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" & _
            "ExecutionParameters", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function SetExecutionParameters(ByVal Parameters() As ParameterValue, ByVal ParameterLanguage As String) As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("SetExecutionParameters", New Object() {Parameters, ParameterLanguage})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub SetExecutionParametersAsync(ByVal Parameters() As ParameterValue, ByVal ParameterLanguage As String)
            Me.SetExecutionParametersAsync(Parameters, ParameterLanguage, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetExecutionParametersAsync(ByVal Parameters() As ParameterValue, ByVal ParameterLanguage As String, ByVal userState As Object)
            If (Me.SetExecutionParametersOperationCompleted Is Nothing) Then
                Me.SetExecutionParametersOperationCompleted = AddressOf Me.OnSetExecutionParametersOperationCompleted
            End If
            Me.InvokeAsync("SetExecutionParameters", New Object() {Parameters, ParameterLanguage}, Me.SetExecutionParametersOperationCompleted, userState)
        End Sub

        Private Sub OnSetExecutionParametersOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetExecutionParametersCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetExecutionParametersCompleted(Me, New SetExecutionParametersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Res" & _
            "etExecution", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ResetExecution() As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("ResetExecution", New Object(-1) {})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub ResetExecutionAsync()
            Me.ResetExecutionAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ResetExecutionAsync(ByVal userState As Object)
            If (Me.ResetExecutionOperationCompleted Is Nothing) Then
                Me.ResetExecutionOperationCompleted = AddressOf Me.OnResetExecutionOperationCompleted
            End If
            Me.InvokeAsync("ResetExecution", New Object(-1) {}, Me.ResetExecutionOperationCompleted, userState)
        End Sub

        Private Sub OnResetExecutionOperationCompleted(ByVal arg As Object)
            If (Not (Me.ResetExecutionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ResetExecutionCompleted(Me, New ResetExecutionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="6#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="5#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="4#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ren" & _
            "der", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function Render(ByVal Format As String, ByVal DeviceInfo As String, ByRef Extension As String, ByRef MimeType As String, ByRef Encoding As String, ByRef Warnings() As Warning, ByRef StreamIds() As String) As <System.Xml.Serialization.XmlElementAttribute("Result", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("Render", New Object() {Format, DeviceInfo})
            Extension = CType(results(1), String)
            MimeType = CType(results(2), String)
            Encoding = CType(results(3), String)
            Warnings = CType(results(4), Warning())
            StreamIds = CType(results(5), String())
            Return CType(results(0), Byte())
        End Function

        '''<remarks/>
        Public Overloads Sub RenderAsync(ByVal Format As String, ByVal DeviceInfo As String)
            Me.RenderAsync(Format, DeviceInfo, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub RenderAsync(ByVal Format As String, ByVal DeviceInfo As String, ByVal userState As Object)
            If (Me.RenderOperationCompleted Is Nothing) Then
                Me.RenderOperationCompleted = AddressOf Me.OnRenderOperationCompleted
            End If
            Me.InvokeAsync("Render", New Object() {Format, DeviceInfo}, Me.RenderOperationCompleted, userState)
        End Sub

        Private Sub OnRenderOperationCompleted(ByVal arg As Object)
            If (Not (Me.RenderCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RenderCompleted(Me, New RenderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="1#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="4#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ren" & _
            "derStream", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function RenderStream(ByVal Format As String, ByVal StreamID As String, ByVal DeviceInfo As String, ByRef Encoding As String, ByRef MimeType As String) As <System.Xml.Serialization.XmlElementAttribute("Result", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("RenderStream", New Object() {Format, StreamID, DeviceInfo})
            Encoding = CType(results(1), String)
            MimeType = CType(results(2), String)
            Return CType(results(0), Byte())
        End Function

        '''<remarks/>
        Public Overloads Sub RenderStreamAsync(ByVal Format As String, ByVal StreamID As String, ByVal DeviceInfo As String)
            Me.RenderStreamAsync(Format, StreamID, DeviceInfo, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub RenderStreamAsync(ByVal Format As String, ByVal StreamID As String, ByVal DeviceInfo As String, ByVal userState As Object)
            If (Me.RenderStreamOperationCompleted Is Nothing) Then
                Me.RenderStreamOperationCompleted = AddressOf Me.OnRenderStreamOperationCompleted
            End If
            Me.InvokeAsync("RenderStream", New Object() {Format, StreamID, DeviceInfo}, Me.RenderStreamOperationCompleted, userState)
        End Sub

        Private Sub OnRenderStreamOperationCompleted(ByVal arg As Object)
            If (Not (Me.RenderStreamCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RenderStreamCompleted(Me, New RenderStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "ExecutionInfo", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetExecutionInfo() As <System.Xml.Serialization.XmlElementAttribute("executionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("GetExecutionInfo", New Object(-1) {})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        Public Overloads Sub GetExecutionInfoAsync()
            Me.GetExecutionInfoAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetExecutionInfoAsync(ByVal userState As Object)
            If (Me.GetExecutionInfoOperationCompleted Is Nothing) Then
                Me.GetExecutionInfoOperationCompleted = AddressOf Me.OnGetExecutionInfoOperationCompleted
            End If
            Me.InvokeAsync("GetExecutionInfo", New Object(-1) {}, Me.GetExecutionInfoOperationCompleted, userState)
        End Sub

        Private Sub OnGetExecutionInfoOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetExecutionInfoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetExecutionInfoCompleted(Me, New GetExecutionInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "DocumentMap", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetDocumentMap() As <System.Xml.Serialization.XmlElementAttribute("result")> DocumentMapNode
            Dim results() As Object = Me.Invoke("GetDocumentMap", New Object(-1) {})
            Return CType(results(0), DocumentMapNode)
        End Function

        '''<remarks/>
        Public Overloads Sub GetDocumentMapAsync()
            Me.GetDocumentMapAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetDocumentMapAsync(ByVal userState As Object)
            If (Me.GetDocumentMapOperationCompleted Is Nothing) Then
                Me.GetDocumentMapOperationCompleted = AddressOf Me.OnGetDocumentMapOperationCompleted
            End If
            Me.InvokeAsync("GetDocumentMap", New Object(-1) {}, Me.GetDocumentMapOperationCompleted, userState)
        End Sub

        Private Sub OnGetDocumentMapOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetDocumentMapCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetDocumentMapCompleted(Me, New GetDocumentMapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.InOut), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" & _
            "dDrillthroughTarget", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function LoadDrillthroughTarget(ByVal DrillthroughID As String) As <System.Xml.Serialization.XmlElementAttribute("ExecutionInfo")> ExecutionInfo
            Dim results() As Object = Me.Invoke("LoadDrillthroughTarget", New Object() {DrillthroughID})
            Return CType(results(0), ExecutionInfo)
        End Function

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub LoadDrillthroughTargetAsync(ByVal DrillthroughID As String)
            Me.LoadDrillthroughTargetAsync(DrillthroughID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LoadDrillthroughTargetAsync(ByVal DrillthroughID As String, ByVal userState As Object)
            If (Me.LoadDrillthroughTargetOperationCompleted Is Nothing) Then
                Me.LoadDrillthroughTargetOperationCompleted = AddressOf Me.OnLoadDrillthroughTargetOperationCompleted
            End If
            Me.InvokeAsync("LoadDrillthroughTarget", New Object() {DrillthroughID}, Me.LoadDrillthroughTargetOperationCompleted, userState)
        End Sub

        Private Sub OnLoadDrillthroughTargetOperationCompleted(ByVal arg As Object)
            If (Not (Me.LoadDrillthroughTargetCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LoadDrillthroughTargetCompleted(Me, New LoadDrillthroughTargetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Tog" & _
            "gleItem", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ToggleItem(ByVal ToggleID As String) As <System.Xml.Serialization.XmlElementAttribute("Found")> Boolean
            Dim results() As Object = Me.Invoke("ToggleItem", New Object() {ToggleID})
            Return CType(results(0), Boolean)
        End Function

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub ToggleItemAsync(ByVal ToggleID As String)
            Me.ToggleItemAsync(ToggleID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ToggleItemAsync(ByVal ToggleID As String, ByVal userState As Object)
            If (Me.ToggleItemOperationCompleted Is Nothing) Then
                Me.ToggleItemOperationCompleted = AddressOf Me.OnToggleItemOperationCompleted
            End If
            Me.InvokeAsync("ToggleItem", New Object() {ToggleID}, Me.ToggleItemOperationCompleted, userState)
        End Sub

        Private Sub OnToggleItemOperationCompleted(ByVal arg As Object)
            If (Not (Me.ToggleItemCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ToggleItemCompleted(Me, New ToggleItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Nav" & _
            "igateDocumentMap", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function NavigateDocumentMap(ByVal DocMapID As String) As <System.Xml.Serialization.XmlElementAttribute("PageNumber")> Integer
            Dim results() As Object = Me.Invoke("NavigateDocumentMap", New Object() {DocMapID})
            Return CType(results(0), Integer)
        End Function

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub NavigateDocumentMapAsync(ByVal DocMapID As String)
            Me.NavigateDocumentMapAsync(DocMapID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub NavigateDocumentMapAsync(ByVal DocMapID As String, ByVal userState As Object)
            If (Me.NavigateDocumentMapOperationCompleted Is Nothing) Then
                Me.NavigateDocumentMapOperationCompleted = AddressOf Me.OnNavigateDocumentMapOperationCompleted
            End If
            Me.InvokeAsync("NavigateDocumentMap", New Object() {DocMapID}, Me.NavigateDocumentMapOperationCompleted, userState)
        End Sub

        Private Sub OnNavigateDocumentMapOperationCompleted(ByVal arg As Object)
            If (Not (Me.NavigateDocumentMapCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent NavigateDocumentMapCompleted(Me, New NavigateDocumentMapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="1#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Nav" & _
            "igateBookmark", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function NavigateBookmark(ByVal BookmarkID As String, ByRef UniqueName As String) As <System.Xml.Serialization.XmlElementAttribute("PageNumber")> Integer
            Dim results() As Object = Me.Invoke("NavigateBookmark", New Object() {BookmarkID})
            UniqueName = CType(results(1), String)
            Return CType(results(0), Integer)
        End Function

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="0#")> Public Overloads Sub NavigateBookmarkAsync(ByVal BookmarkID As String)
            Me.NavigateBookmarkAsync(BookmarkID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub NavigateBookmarkAsync(ByVal BookmarkID As String, ByVal userState As Object)
            If (Me.NavigateBookmarkOperationCompleted Is Nothing) Then
                Me.NavigateBookmarkOperationCompleted = AddressOf Me.OnNavigateBookmarkOperationCompleted
            End If
            Me.InvokeAsync("NavigateBookmark", New Object() {BookmarkID}, Me.NavigateBookmarkOperationCompleted, userState)
        End Sub

        Private Sub OnNavigateBookmarkOperationCompleted(ByVal arg As Object)
            If (Not (Me.NavigateBookmarkCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent NavigateBookmarkCompleted(Me, New NavigateBookmarkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fin" & _
            "dString", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function FindString(ByVal StartPage As Integer, ByVal EndPage As Integer, ByVal FindValue As String) As <System.Xml.Serialization.XmlElementAttribute("PageNumber")> Integer
            Dim results() As Object = Me.Invoke("FindString", New Object() {StartPage, EndPage, FindValue})
            Return CType(results(0), Integer)
        End Function

        '''<remarks/>
        Public Overloads Sub FindStringAsync(ByVal StartPage As Integer, ByVal EndPage As Integer, ByVal FindValue As String)
            Me.FindStringAsync(StartPage, EndPage, FindValue, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub FindStringAsync(ByVal StartPage As Integer, ByVal EndPage As Integer, ByVal FindValue As String, ByVal userState As Object)
            If (Me.FindStringOperationCompleted Is Nothing) Then
                Me.FindStringOperationCompleted = AddressOf Me.OnFindStringOperationCompleted
            End If
            Me.InvokeAsync("FindString", New Object() {StartPage, EndPage, FindValue}, Me.FindStringOperationCompleted, userState)
        End Sub

        Private Sub OnFindStringOperationCompleted(ByVal arg As Object)
            If (Not (Me.FindStringCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FindStringCompleted(Me, New FindStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="3#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue"), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sor" & _
            "t", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function Sort(ByVal SortItem As String, ByVal Direction As SortDirectionEnum, ByVal Clear As Boolean, ByRef ReportItem As String, ByRef NumPages As Integer) As <System.Xml.Serialization.XmlElementAttribute("PageNumber")> Integer
            Dim results() As Object = Me.Invoke("Sort", New Object() {SortItem, Direction, Clear})
            ReportItem = CType(results(1), String)
            NumPages = CType(results(2), Integer)
            Return CType(results(0), Integer)
        End Function

        '''<remarks/>
        Public Overloads Sub SortAsync(ByVal SortItem As String, ByVal Direction As SortDirectionEnum, ByVal Clear As Boolean)
            Me.SortAsync(SortItem, Direction, Clear, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SortAsync(ByVal SortItem As String, ByVal Direction As SortDirectionEnum, ByVal Clear As Boolean, ByVal userState As Object)
            If (Me.SortOperationCompleted Is Nothing) Then
                Me.SortOperationCompleted = AddressOf Me.OnSortOperationCompleted
            End If
            Me.InvokeAsync("Sort", New Object() {SortItem, Direction, Clear}, Me.SortOperationCompleted, userState)
        End Sub

        Private Sub OnSortOperationCompleted(ByVal arg As Object)
            If (Not (Me.SortCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SortCompleted(Me, New SortCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId:="2#")> <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" & _
            "RenderResource", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetRenderResource(ByVal Format As String, ByVal DeviceInfo As String, ByRef MimeType As String) As <System.Xml.Serialization.XmlElementAttribute("Result", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetRenderResource", New Object() {Format, DeviceInfo})
            MimeType = CType(results(1), String)
            Return CType(results(0), Byte())
        End Function

        '''<remarks/>
        Public Overloads Sub GetRenderResourceAsync(ByVal Format As String, ByVal DeviceInfo As String)
            Me.GetRenderResourceAsync(Format, DeviceInfo, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetRenderResourceAsync(ByVal Format As String, ByVal DeviceInfo As String, ByVal userState As Object)
            If (Me.GetRenderResourceOperationCompleted Is Nothing) Then
                Me.GetRenderResourceOperationCompleted = AddressOf Me.OnGetRenderResourceOperationCompleted
            End If
            Me.InvokeAsync("GetRenderResource", New Object() {Format, DeviceInfo}, Me.GetRenderResourceOperationCompleted, userState)
        End Sub

        Private Sub OnGetRenderResourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetRenderResourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetRenderResourceCompleted(Me, New GetRenderResourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" & _
            "tRenderingExtensions", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListRenderingExtensions() As <System.Xml.Serialization.XmlArrayAttribute("Extensions")> Extension()
            Dim results() As Object = Me.Invoke("ListRenderingExtensions", New Object(-1) {})
            Return CType(results(0), Extension())
        End Function

        '''<remarks/>
        Public Overloads Sub ListRenderingExtensionsAsync()
            Me.ListRenderingExtensionsAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ListRenderingExtensionsAsync(ByVal userState As Object)
            If (Me.ListRenderingExtensionsOperationCompleted Is Nothing) Then
                Me.ListRenderingExtensionsOperationCompleted = AddressOf Me.OnListRenderingExtensionsOperationCompleted
            End If
            Me.InvokeAsync("ListRenderingExtensions", New Object(-1) {}, Me.ListRenderingExtensionsOperationCompleted, userState)
        End Sub

        Private Sub OnListRenderingExtensionsOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListRenderingExtensionsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListRenderingExtensionsCompleted(Me, New ListRenderingExtensionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" & _
            "onUser", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub LogonUser(ByVal userName As String, ByVal password As String, ByVal authority As String)
            Me.Invoke("LogonUser", New Object() {userName, password, authority})
        End Sub

        '''<remarks/>
        Public Overloads Sub LogonUserAsync(ByVal userName As String, ByVal password As String, ByVal authority As String)
            Me.LogonUserAsync(userName, password, authority, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LogonUserAsync(ByVal userName As String, ByVal password As String, ByVal authority As String, ByVal userState As Object)
            If (Me.LogonUserOperationCompleted Is Nothing) Then
                Me.LogonUserOperationCompleted = AddressOf Me.OnLogonUserOperationCompleted
            End If
            Me.InvokeAsync("LogonUser", New Object() {userName, password, authority}, Me.LogonUserOperationCompleted, userState)
        End Sub

        Private Sub OnLogonUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogonUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogonUserCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction:=System.Web.Services.Protocols.SoapHeaderDirection.Out), _
         System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" & _
            "off", RequestNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub Logoff()
            Me.Invoke("Logoff", New Object(-1) {})
        End Sub

        '''<remarks/>
        Public Overloads Sub LogoffAsync()
            Me.LogoffAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LogoffAsync(ByVal userState As Object)
            If (Me.LogoffOperationCompleted Is Nothing) Then
                Me.LogoffOperationCompleted = AddressOf Me.OnLogoffOperationCompleted
            End If
            Me.InvokeAsync("Logoff", New Object(-1) {}, Me.LogoffOperationCompleted, userState)
        End Sub

        Private Sub OnLogoffOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogoffCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogoffCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId:="System.String.Compare(System.String,System.String,System.Boolean)")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")> Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) _
                        OrElse (url Is String.Empty)) Then
                Return False
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If (((wsUri.Port >= 1024) _
                        AndAlso (wsUri.Port <= 5000)) _
                        AndAlso (String.Compare(wsUri.Host, "localHost", True) = 0)) Then
                Return True
            End If
            Return False
        End Function
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable:=False)> _
    Partial Public Class ServerInfoHeader
        Inherits System.Web.Services.Protocols.SoapHeader

        Private reportServerVersionNumberField As String

        Private reportServerEditionField As String

        Private reportServerVersionField As String

        Private reportServerDateTimeField As String

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields")> Private anyAttrField() As System.Xml.XmlAttribute

        '''<remarks/>
        Public Property ReportServerVersionNumber() As String
            Get
                Return Me.reportServerVersionNumberField
            End Get
            Set(ByVal value As String)
                Me.reportServerVersionNumberField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ReportServerEdition() As String
            Get
                Return Me.reportServerEditionField
            End Get
            Set(ByVal value As String)
                Me.reportServerEditionField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ReportServerVersion() As String
            Get
                Return Me.reportServerVersionField
            End Get
            Set(ByVal value As String)
                Me.reportServerVersionField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ReportServerDateTime() As String
            Get
                Return Me.reportServerDateTimeField
            End Get
            Set(ByVal value As String)
                Me.reportServerDateTimeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()> _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set(ByVal value As System.Xml.XmlAttribute())
                Me.anyAttrField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class Extension

        Private extensionTypeField As ExtensionTypeEnum

        Private nameField As String

        Private localizedNameField As String

        Private visibleField As Boolean

        Private isModelGenerationSupportedField As Boolean

        '''<remarks/>
        Public Property ExtensionType() As ExtensionTypeEnum
            Get
                Return Me.extensionTypeField
            End Get
            Set(ByVal value As ExtensionTypeEnum)
                Me.extensionTypeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property LocalizedName() As String
            Get
                Return Me.localizedNameField
            End Get
            Set(ByVal value As String)
                Me.localizedNameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Visible() As Boolean
            Get
                Return Me.visibleField
            End Get
            Set(ByVal value As Boolean)
                Me.visibleField = value
            End Set
        End Property

        '''<remarks/>
        Public Property IsModelGenerationSupported() As Boolean
            Get
                Return Me.isModelGenerationSupportedField
            End Get
            Set(ByVal value As Boolean)
                Me.isModelGenerationSupportedField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ExtensionTypeEnum

        '''<remarks/>
        Delivery

        '''<remarks/>
        Render

        '''<remarks/>
        Data

        '''<remarks/>
        All
    End Enum

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class DocumentMapNode

        Private labelField As String

        Private uniqueNameField As String

        Private childrenField() As DocumentMapNode

        '''<remarks/>
        Public Property Label() As String
            Get
                Return Me.labelField
            End Get
            Set(ByVal value As String)
                Me.labelField = value
            End Set
        End Property

        '''<remarks/>
        Public Property UniqueName() As String
            Get
                Return Me.uniqueNameField
            End Get
            Set(ByVal value As String)
                Me.uniqueNameField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property Children() As DocumentMapNode()
            Get
                Return Me.childrenField
            End Get
            Set(ByVal value As DocumentMapNode())
                Me.childrenField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ParameterValue)), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ParameterValueOrFieldReference
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ParameterValue
        Inherits ParameterValueOrFieldReference

        Private nameField As String

        Private valueField As String

        Private labelField As String

        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set(ByVal value As String)
                Me.valueField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Label() As String
            Get
                Return Me.labelField
            End Get
            Set(ByVal value As String)
                Me.labelField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class DataSourceCredentials

        Private dataSourceNameField As String

        Private userNameField As String

        Private passwordField As String

        '''<remarks/>
        Public Property DataSourceName() As String
            Get
                Return Me.dataSourceNameField
            End Get
            Set(ByVal value As String)
                Me.dataSourceNameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set(ByVal value As String)
                Me.userNameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Password() As String
            Get
                Return Me.passwordField
            End Get
            Set(ByVal value As String)
                Me.passwordField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class Warning

        Private codeField As String

        Private severityField As String

        Private objectNameField As String

        Private objectTypeField As String

        Private messageField As String

        '''<remarks/>
        Public Property Code() As String
            Get
                Return Me.codeField
            End Get
            Set(ByVal value As String)
                Me.codeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Severity() As String
            Get
                Return Me.severityField
            End Get
            Set(ByVal value As String)
                Me.severityField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ObjectName() As String
            Get
                Return Me.objectNameField
            End Get
            Set(ByVal value As String)
                Me.objectNameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ObjectType() As String
            Get
                Return Me.objectTypeField
            End Get
            Set(ByVal value As String)
                Me.objectTypeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Message() As String
            Get
                Return Me.messageField
            End Get
            Set(ByVal value As String)
                Me.messageField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ReportMargins

        Private topField As Double

        Private bottomField As Double

        Private leftField As Double

        Private rightField As Double

        '''<remarks/>
        Public Property Top() As Double
            Get
                Return Me.topField
            End Get
            Set(ByVal value As Double)
                Me.topField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Bottom() As Double
            Get
                Return Me.bottomField
            End Get
            Set(ByVal value As Double)
                Me.bottomField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Left() As Double
            Get
                Return Me.leftField
            End Get
            Set(ByVal value As Double)
                Me.leftField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Right() As Double
            Get
                Return Me.rightField
            End Get
            Set(ByVal value As Double)
                Me.rightField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ReportPaperSize

        Private heightField As Double

        Private widthField As Double

        '''<remarks/>
        Public Property Height() As Double
            Get
                Return Me.heightField
            End Get
            Set(ByVal value As Double)
                Me.heightField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Width() As Double
            Get
                Return Me.widthField
            End Get
            Set(ByVal value As Double)
                Me.widthField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class PageSettings

        Private paperSizeField As ReportPaperSize

        Private marginsField As ReportMargins

        '''<remarks/>
        Public Property PaperSize() As ReportPaperSize
            Get
                Return Me.paperSizeField
            End Get
            Set(ByVal value As ReportPaperSize)
                Me.paperSizeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Margins() As ReportMargins
            Get
                Return Me.marginsField
            End Get
            Set(ByVal value As ReportMargins)
                Me.marginsField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class DataSourcePrompt

        Private nameField As String

        Private dataSourceIDField As String

        Private promptField As String

        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property DataSourceID() As String
            Get
                Return Me.dataSourceIDField
            End Get
            Set(ByVal value As String)
                Me.dataSourceIDField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set(ByVal value As String)
                Me.promptField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ValidValue

        Private labelField As String

        Private valueField As String

        '''<remarks/>
        Public Property Label() As String
            Get
                Return Me.labelField
            End Get
            Set(ByVal value As String)
                Me.labelField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set(ByVal value As String)
                Me.valueField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ReportParameter

        Private nameField As String

        Private typeField As ParameterTypeEnum

        Private typeFieldSpecified As Boolean

        Private nullableField As Boolean

        Private nullableFieldSpecified As Boolean

        Private allowBlankField As Boolean

        Private allowBlankFieldSpecified As Boolean

        Private multiValueField As Boolean

        Private multiValueFieldSpecified As Boolean

        Private queryParameterField As Boolean

        Private queryParameterFieldSpecified As Boolean

        Private promptField As String

        Private promptUserField As Boolean

        Private promptUserFieldSpecified As Boolean

        Private dependenciesField() As String

        Private validValuesQueryBasedField As Boolean

        Private validValuesQueryBasedFieldSpecified As Boolean

        Private validValuesField() As ValidValue

        Private defaultValuesQueryBasedField As Boolean

        Private defaultValuesQueryBasedFieldSpecified As Boolean

        Private defaultValuesField() As String

        Private stateField As ParameterStateEnum

        Private stateFieldSpecified As Boolean

        Private errorMessageField As String

        '''<remarks/>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property

        '''<remarks/>
        Public Property Type() As ParameterTypeEnum
            Get
                Return Me.typeField
            End Get
            Set(ByVal value As ParameterTypeEnum)
                Me.typeField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.typeFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property Nullable() As Boolean
            Get
                Return Me.nullableField
            End Get
            Set(ByVal value As Boolean)
                Me.nullableField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property NullableSpecified() As Boolean
            Get
                Return Me.nullableFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.nullableFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property AllowBlank() As Boolean
            Get
                Return Me.allowBlankField
            End Get
            Set(ByVal value As Boolean)
                Me.allowBlankField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property AllowBlankSpecified() As Boolean
            Get
                Return Me.allowBlankFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.allowBlankFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property MultiValue() As Boolean
            Get
                Return Me.multiValueField
            End Get
            Set(ByVal value As Boolean)
                Me.multiValueField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property MultiValueSpecified() As Boolean
            Get
                Return Me.multiValueFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.multiValueFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property QueryParameter() As Boolean
            Get
                Return Me.queryParameterField
            End Get
            Set(ByVal value As Boolean)
                Me.queryParameterField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property QueryParameterSpecified() As Boolean
            Get
                Return Me.queryParameterFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.queryParameterFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set(ByVal value As String)
                Me.promptField = value
            End Set
        End Property

        '''<remarks/>
        Public Property PromptUser() As Boolean
            Get
                Return Me.promptUserField
            End Get
            Set(ByVal value As Boolean)
                Me.promptUserField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property PromptUserSpecified() As Boolean
            Get
                Return Me.promptUserFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.promptUserFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Dependency")> _
        Public Property Dependencies() As String()
            Get
                Return Me.dependenciesField
            End Get
            Set(ByVal value As String())
                Me.dependenciesField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ValidValuesQueryBased() As Boolean
            Get
                Return Me.validValuesQueryBasedField
            End Get
            Set(ByVal value As Boolean)
                Me.validValuesQueryBasedField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ValidValuesQueryBasedSpecified() As Boolean
            Get
                Return Me.validValuesQueryBasedFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.validValuesQueryBasedFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property ValidValues() As ValidValue()
            Get
                Return Me.validValuesField
            End Get
            Set(ByVal value As ValidValue())
                Me.validValuesField = value
            End Set
        End Property

        '''<remarks/>
        Public Property DefaultValuesQueryBased() As Boolean
            Get
                Return Me.defaultValuesQueryBasedField
            End Get
            Set(ByVal value As Boolean)
                Me.defaultValuesQueryBasedField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property DefaultValuesQueryBasedSpecified() As Boolean
            Get
                Return Me.defaultValuesQueryBasedFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.defaultValuesQueryBasedFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Value")> _
        Public Property DefaultValues() As String()
            Get
                Return Me.defaultValuesField
            End Get
            Set(ByVal value As String())
                Me.defaultValuesField = value
            End Set
        End Property

        '''<remarks/>
        Public Property State() As ParameterStateEnum
            Get
                Return Me.stateField
            End Get
            Set(ByVal value As ParameterStateEnum)
                Me.stateField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property StateSpecified() As Boolean
            Get
                Return Me.stateFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.stateFieldSpecified = value
            End Set
        End Property

        '''<remarks/>
        Public Property ErrorMessage() As String
            Get
                Return Me.errorMessageField
            End Get
            Set(ByVal value As String)
                Me.errorMessageField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ParameterTypeEnum

        '''<remarks/>
        [Boolean]

        '''<remarks/>
        DateTime

        '''<remarks/>
        [Integer]

        '''<remarks/>
        Float

        '''<remarks/>
        [String]
    End Enum

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum ParameterStateEnum

        '''<remarks/>
        HasValidValue

        '''<remarks/>
        MissingValidValue

        '''<remarks/>
        HasOutstandingDependencies

        '''<remarks/>
        DynamicValuesUnavailable
    End Enum

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Partial Public Class ExecutionInfo

        Private hasSnapshotField As Boolean

        Private needsProcessingField As Boolean

        Private allowQueryExecutionField As Boolean

        Private credentialsRequiredField As Boolean

        Private parametersRequiredField As Boolean

        Private expirationDateTimeField As Date

        Private executionDateTimeField As Date

        Private numPagesField As Integer

        Private parametersField() As ReportParameter

        Private dataSourcePromptsField() As DataSourcePrompt

        Private hasDocumentMapField As Boolean

        Private executionIDField As String

        Private reportPathField As String

        Private historyIDField As String

        Private reportPageSettingsField As PageSettings

        Private autoRefreshIntervalField As Integer

        '''<remarks/>
        Public Property HasSnapshot() As Boolean
            Get
                Return Me.hasSnapshotField
            End Get
            Set(ByVal value As Boolean)
                Me.hasSnapshotField = value
            End Set
        End Property

        '''<remarks/>
        Public Property NeedsProcessing() As Boolean
            Get
                Return Me.needsProcessingField
            End Get
            Set(ByVal value As Boolean)
                Me.needsProcessingField = value
            End Set
        End Property

        '''<remarks/>
        Public Property AllowQueryExecution() As Boolean
            Get
                Return Me.allowQueryExecutionField
            End Get
            Set(ByVal value As Boolean)
                Me.allowQueryExecutionField = value
            End Set
        End Property

        '''<remarks/>
        Public Property CredentialsRequired() As Boolean
            Get
                Return Me.credentialsRequiredField
            End Get
            Set(ByVal value As Boolean)
                Me.credentialsRequiredField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ParametersRequired() As Boolean
            Get
                Return Me.parametersRequiredField
            End Get
            Set(ByVal value As Boolean)
                Me.parametersRequiredField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ExpirationDateTime() As Date
            Get
                Return Me.expirationDateTimeField
            End Get
            Set(ByVal value As Date)
                Me.expirationDateTimeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ExecutionDateTime() As Date
            Get
                Return Me.executionDateTimeField
            End Get
            Set(ByVal value As Date)
                Me.executionDateTimeField = value
            End Set
        End Property

        '''<remarks/>
        Public Property NumPages() As Integer
            Get
                Return Me.numPagesField
            End Get
            Set(ByVal value As Integer)
                Me.numPagesField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property Parameters() As ReportParameter()
            Get
                Return Me.parametersField
            End Get
            Set(ByVal value As ReportParameter())
                Me.parametersField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public Property DataSourcePrompts() As DataSourcePrompt()
            Get
                Return Me.dataSourcePromptsField
            End Get
            Set(ByVal value As DataSourcePrompt())
                Me.dataSourcePromptsField = value
            End Set
        End Property

        '''<remarks/>
        Public Property HasDocumentMap() As Boolean
            Get
                Return Me.hasDocumentMapField
            End Get
            Set(ByVal value As Boolean)
                Me.hasDocumentMapField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ExecutionID() As String
            Get
                Return Me.executionIDField
            End Get
            Set(ByVal value As String)
                Me.executionIDField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ReportPath() As String
            Get
                Return Me.reportPathField
            End Get
            Set(ByVal value As String)
                Me.reportPathField = value
            End Set
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property HistoryID() As String
            Get
                Return Me.historyIDField
            End Get
            Set(ByVal value As String)
                Me.historyIDField = value
            End Set
        End Property

        '''<remarks/>
        Public Property ReportPageSettings() As PageSettings
            Get
                Return Me.reportPageSettingsField
            End Get
            Set(ByVal value As PageSettings)
                Me.reportPageSettingsField = value
            End Set
        End Property

        '''<remarks/>
        Public Property AutoRefreshInterval() As Integer
            Get
                Return Me.autoRefreshIntervalField
            End Get
            Set(ByVal value As Integer)
                Me.autoRefreshIntervalField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable:=False)> _
    Partial Public Class ExecutionHeader
        Inherits System.Web.Services.Protocols.SoapHeader

        Private executionIDField As String

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields")> Private anyAttrField() As System.Xml.XmlAttribute

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId:="Member")> Public Property ExecutionID() As String
            Get
                Return Me.executionIDField
            End Get
            Set(ByVal value As String)
                Me.executionIDField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()> _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set(ByVal value As System.Xml.XmlAttribute())
                Me.anyAttrField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")> <System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")> _
    Public Enum SortDirectionEnum

        '''<remarks/>
        None

        '''<remarks/>
        Ascending

        '''<remarks/>
        Descending
    End Enum

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListSecureMethodsCompletedEventHandler(ByVal sender As Object, ByVal e As ListSecureMethodsCompletedEventArgs)

    '''<remarks/>
    Partial Public Class ListSecureMethodsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String())
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LoadReportCompletedEventHandler(ByVal sender As Object, ByVal e As LoadReportCompletedEventArgs)

    '''<remarks/>
    Partial Public Class LoadReportCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LoadReportDefinitionCompletedEventHandler(ByVal sender As Object, ByVal e As LoadReportDefinitionCompletedEventArgs)

    '''<remarks/>
    Partial Public Class LoadReportDefinitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId:="Member")> Public ReadOnly Property warnings() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), Warning())
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetExecutionCredentialsCompletedEventHandler(ByVal sender As Object, ByVal e As SetExecutionCredentialsCompletedEventArgs)

    '''<remarks/>
    Partial Public Class SetExecutionCredentialsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SetExecutionParametersCompletedEventHandler(ByVal sender As Object, ByVal e As SetExecutionParametersCompletedEventArgs)

    '''<remarks/>
    Partial Public Class SetExecutionParametersCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ResetExecutionCompletedEventHandler(ByVal sender As Object, ByVal e As ResetExecutionCompletedEventArgs)

    '''<remarks/>
    Partial Public Class ResetExecutionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub RenderCompletedEventHandler(ByVal sender As Object, ByVal e As RenderCompletedEventArgs)

    '''<remarks/>
    Partial Public Class RenderCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Extension() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property MimeType() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Encoding() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(3), String)
            End Get
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Warnings() As Warning()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(4), Warning())
            End Get
        End Property

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property StreamIds() As String()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(5), String())
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub RenderStreamCompletedEventHandler(ByVal sender As Object, ByVal e As RenderStreamCompletedEventArgs)

    '''<remarks/>
    Partial Public Class RenderStreamCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property Encoding() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property MimeType() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetExecutionInfoCompletedEventHandler(ByVal sender As Object, ByVal e As GetExecutionInfoCompletedEventArgs)

    '''<remarks/>
    Partial Public Class GetExecutionInfoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetDocumentMapCompletedEventHandler(ByVal sender As Object, ByVal e As GetDocumentMapCompletedEventArgs)

    '''<remarks/>
    Partial Public Class GetDocumentMapCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As DocumentMapNode
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), DocumentMapNode)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LoadDrillthroughTargetCompletedEventHandler(ByVal sender As Object, ByVal e As LoadDrillthroughTargetCompletedEventArgs)

    '''<remarks/>
    Partial Public Class LoadDrillthroughTargetCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As ExecutionInfo
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), ExecutionInfo)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ToggleItemCompletedEventHandler(ByVal sender As Object, ByVal e As ToggleItemCompletedEventArgs)

    '''<remarks/>
    Partial Public Class ToggleItemCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Boolean)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub NavigateDocumentMapCompletedEventHandler(ByVal sender As Object, ByVal e As NavigateDocumentMapCompletedEventArgs)

    '''<remarks/>
    Partial Public Class NavigateDocumentMapCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Integer)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub NavigateBookmarkCompletedEventHandler(ByVal sender As Object, ByVal e As NavigateBookmarkCompletedEventArgs)

    '''<remarks/>
    Partial Public Class NavigateBookmarkCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Integer)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property UniqueName() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub FindStringCompletedEventHandler(ByVal sender As Object, ByVal e As FindStringCompletedEventArgs)

    '''<remarks/>
    Partial Public Class FindStringCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Integer)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub SortCompletedEventHandler(ByVal sender As Object, ByVal e As SortCompletedEventArgs)

    '''<remarks/>
    Partial Public Class SortCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Integer)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property ReportItem() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property NumPages() As Integer
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), Integer)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub GetRenderResourceCompletedEventHandler(ByVal sender As Object, ByVal e As GetRenderResourceCompletedEventArgs)

    '''<remarks/>
    Partial Public Class GetRenderResourceCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Byte())
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property MimeType() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub ListRenderingExtensionsCompletedEventHandler(ByVal sender As Object, ByVal e As ListRenderingExtensionsCompletedEventArgs)

    '''<remarks/>
    Partial Public Class ListRenderingExtensionsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")> Public ReadOnly Property Result() As Extension()
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Extension())
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LogonUserCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")> Public Delegate Sub LogoffCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
End Namespace