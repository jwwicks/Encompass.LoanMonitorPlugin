﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyName.BusinessEntities
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatementPeriod", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public partial class StatementPeriod : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string PeriodDescField;
        
        private System.DateTime PeriodEndDtField;
        
        private string PeriodIDField;
        
        private string PeriodNameField;
        
        private System.DateTime PeriodStartDtField;
        
        private CompanyName.BusinessEntities.CommisionPeriodType PeriodTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PeriodDesc
        {
            get
            {
                return this.PeriodDescField;
            }
            set
            {
                this.PeriodDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PeriodEndDt
        {
            get
            {
                return this.PeriodEndDtField;
            }
            set
            {
                this.PeriodEndDtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PeriodID
        {
            get
            {
                return this.PeriodIDField;
            }
            set
            {
                this.PeriodIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PeriodName
        {
            get
            {
                return this.PeriodNameField;
            }
            set
            {
                this.PeriodNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PeriodStartDt
        {
            get
            {
                return this.PeriodStartDtField;
            }
            set
            {
                this.PeriodStartDtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.CommisionPeriodType PeriodType
        {
            get
            {
                return this.PeriodTypeField;
            }
            set
            {
                this.PeriodTypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommisionPeriodType", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public enum CommisionPeriodType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BiWeekly = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Monthly = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DelegateUser", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public partial class DelegateUser : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DelegateIDField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private CompanyName.BusinessEntities.UserType SpecialUserTypeField;
        
        private string UserIDField;
        
        private string UserLabelField;
        
        private string UserRoleField;
        
        private string UserSubTypeField;
        
        private CompanyName.BusinessEntities.UserType UserTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DelegateID
        {
            get
            {
                return this.DelegateIDField;
            }
            set
            {
                this.DelegateIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.UserType SpecialUserType
        {
            get
            {
                return this.SpecialUserTypeField;
            }
            set
            {
                this.SpecialUserTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserLabel
        {
            get
            {
                return this.UserLabelField;
            }
            set
            {
                this.UserLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserRole
        {
            get
            {
                return this.UserRoleField;
            }
            set
            {
                this.UserRoleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserSubType
        {
            get
            {
                return this.UserSubTypeField;
            }
            set
            {
                this.UserSubTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.UserType UserType
        {
            get
            {
                return this.UserTypeField;
            }
            set
            {
                this.UserTypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public enum UserType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        closer = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        funder = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        processor = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        underwriter = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        agent_biweekly = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        agent_monthly = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        vr_loan_officer = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        vr_sales_manager = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        virtual_retail = 8,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Summary", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public partial class Summary : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string BPSField;
        
        private decimal CarryOverField;
        
        private bool CurrentUserCanAdminCommissionsField;
        
        private decimal DollarAdjustmentField;
        
        private string EmpIdField;
        
        private decimal GrandTotalField;
        
        private decimal GrossComissionField;
        
        private decimal IncentiveField;
        
        private decimal MaxQualifyingBPSField;
        
        private string PayPeriodMonthRefField;
        
        private decimal QualifyingUnitsField;
        
        private decimal QualifyingVolumeField;
        
        private decimal UnitAdjustmentField;
        
        private decimal UnitsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BPS
        {
            get
            {
                return this.BPSField;
            }
            set
            {
                this.BPSField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CarryOver
        {
            get
            {
                return this.CarryOverField;
            }
            set
            {
                this.CarryOverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CurrentUserCanAdminCommissions
        {
            get
            {
                return this.CurrentUserCanAdminCommissionsField;
            }
            set
            {
                this.CurrentUserCanAdminCommissionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DollarAdjustment
        {
            get
            {
                return this.DollarAdjustmentField;
            }
            set
            {
                this.DollarAdjustmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpId
        {
            get
            {
                return this.EmpIdField;
            }
            set
            {
                this.EmpIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal GrandTotal
        {
            get
            {
                return this.GrandTotalField;
            }
            set
            {
                this.GrandTotalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal GrossComission
        {
            get
            {
                return this.GrossComissionField;
            }
            set
            {
                this.GrossComissionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Incentive
        {
            get
            {
                return this.IncentiveField;
            }
            set
            {
                this.IncentiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MaxQualifyingBPS
        {
            get
            {
                return this.MaxQualifyingBPSField;
            }
            set
            {
                this.MaxQualifyingBPSField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PayPeriodMonthRef
        {
            get
            {
                return this.PayPeriodMonthRefField;
            }
            set
            {
                this.PayPeriodMonthRefField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal QualifyingUnits
        {
            get
            {
                return this.QualifyingUnitsField;
            }
            set
            {
                this.QualifyingUnitsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal QualifyingVolume
        {
            get
            {
                return this.QualifyingVolumeField;
            }
            set
            {
                this.QualifyingVolumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitAdjustment
        {
            get
            {
                return this.UnitAdjustmentField;
            }
            set
            {
                this.UnitAdjustmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Units
        {
            get
            {
                return this.UnitsField;
            }
            set
            {
                this.UnitsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Adjustment", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public partial class Adjustment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal AdjustmentAmountField;
        
        private string AdjustmentDescriptionField;
        
        private CompanyName.BusinessEntities.AdjustmentType TypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal AdjustmentAmount
        {
            get
            {
                return this.AdjustmentAmountField;
            }
            set
            {
                this.AdjustmentAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdjustmentDescription
        {
            get
            {
                return this.AdjustmentDescriptionField;
            }
            set
            {
                this.AdjustmentDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.AdjustmentType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Loan", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public partial class Loan : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal BPSField;
        
        private string BorrowerNameField;
        
        private string CategoryField;
        
        private string DecisionField;
        
        private System.DateTime DecisionDateField;
        
        private string EntityField;
        
        private string FundDateField;
        
        private decimal IncentiveField;
        
        private decimal LoanAmountField;
        
        private string LoanNumberField;
        
        private decimal UnitsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BPS
        {
            get
            {
                return this.BPSField;
            }
            set
            {
                this.BPSField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BorrowerName
        {
            get
            {
                return this.BorrowerNameField;
            }
            set
            {
                this.BorrowerNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Decision
        {
            get
            {
                return this.DecisionField;
            }
            set
            {
                this.DecisionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DecisionDate
        {
            get
            {
                return this.DecisionDateField;
            }
            set
            {
                this.DecisionDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Entity
        {
            get
            {
                return this.EntityField;
            }
            set
            {
                this.EntityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FundDate
        {
            get
            {
                return this.FundDateField;
            }
            set
            {
                this.FundDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Incentive
        {
            get
            {
                return this.IncentiveField;
            }
            set
            {
                this.IncentiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal LoanAmount
        {
            get
            {
                return this.LoanAmountField;
            }
            set
            {
                this.LoanAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoanNumber
        {
            get
            {
                return this.LoanNumberField;
            }
            set
            {
                this.LoanNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Units
        {
            get
            {
                return this.UnitsField;
            }
            set
            {
                this.UnitsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AdjustmentType", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.BusinessEntities")]
    public enum AdjustmentType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unit = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Currency = 1,
    }
}
namespace CompanyName.DataTransferObjects
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportDTO", Namespace="http://schemas.datacontract.org/2004/07/CompanyName.DataTransferObjects")]
    public partial class ReportDTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private CompanyName.BusinessEntities.Adjustment[] DollarAdjustmentsField;
        
        private CompanyName.BusinessEntities.StatementPeriod PeriodField;
        
        private CompanyName.BusinessEntities.Loan[] ReportLoansField;
        
        private CompanyName.BusinessEntities.Summary ReportSummaryField;
        
        private CompanyName.BusinessEntities.Adjustment[] UnitAdjustmentsField;
        
        private CompanyName.BusinessEntities.DelegateUser UserInfoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.Adjustment[] DollarAdjustments
        {
            get
            {
                return this.DollarAdjustmentsField;
            }
            set
            {
                this.DollarAdjustmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.StatementPeriod Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.Loan[] ReportLoans
        {
            get
            {
                return this.ReportLoansField;
            }
            set
            {
                this.ReportLoansField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.Summary ReportSummary
        {
            get
            {
                return this.ReportSummaryField;
            }
            set
            {
                this.ReportSummaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.Adjustment[] UnitAdjustments
        {
            get
            {
                return this.UnitAdjustmentsField;
            }
            set
            {
                this.UnitAdjustmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompanyName.BusinessEntities.DelegateUser UserInfo
        {
            get
            {
                return this.UserInfoField;
            }
            set
            {
                this.UserInfoField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://companyname.commissions", ConfigurationName="ICommissions")]
public interface ICommissions
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/IsCommissionsEligible", ReplyAction="http://companyname.commissions/ICommissions/IsCommissionsEligibleResponse")]
    string IsCommissionsEligible(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/GetDelegates", ReplyAction="http://companyname.commissions/ICommissions/GetDelegatesResponse")]
    string GetDelegates(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/GetStatementList", ReplyAction="http://companyname.commissions/ICommissions/GetStatementListResponse")]
    CompanyName.BusinessEntities.StatementPeriod[] GetStatementList();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/GetStatement", ReplyAction="http://companyname.commissions/ICommissions/GetStatementResponse")]
    string GetStatement(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/GetDelegatesDataContract", ReplyAction="http://companyname.commissions/ICommissions/GetDelegatesDataContractResponse")]
    CompanyName.BusinessEntities.DelegateUser[] GetDelegatesDataContract(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/GetCommissionReport", ReplyAction="http://companyname.commissions/ICommissions/GetCommissionReportResponse")]
    CompanyName.DataTransferObjects.ReportDTO GetCommissionReport(string paymentPeriodId, string employeeId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://companyname.commissions/ICommissions/CanCurrentUserAdminCommissions", ReplyAction="http://companyname.commissions/ICommissions/CanCurrentUserAdminCommissionsResponse")]
    bool CanCurrentUserAdminCommissions(string value);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICommissionsChannel : ICommissions, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CommissionsClient : System.ServiceModel.ClientBase<ICommissions>, ICommissions
{
    
    public CommissionsClient()
    {
    }
    
    public CommissionsClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CommissionsClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CommissionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CommissionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string IsCommissionsEligible(string value)
    {
        return base.Channel.IsCommissionsEligible(value);
    }
    
    public string GetDelegates(string value)
    {
        return base.Channel.GetDelegates(value);
    }
    
    public CompanyName.BusinessEntities.StatementPeriod[] GetStatementList()
    {
        return base.Channel.GetStatementList();
    }
    
    public string GetStatement(string value)
    {
        return base.Channel.GetStatement(value);
    }
    
    public CompanyName.BusinessEntities.DelegateUser[] GetDelegatesDataContract(string value)
    {
        return base.Channel.GetDelegatesDataContract(value);
    }
    
    public CompanyName.DataTransferObjects.ReportDTO GetCommissionReport(string paymentPeriodId, string employeeId)
    {
        return base.Channel.GetCommissionReport(paymentPeriodId, employeeId);
    }
    
    public bool CanCurrentUserAdminCommissions(string value)
    {
        return base.Channel.CanCurrentUserAdminCommissions(value);
    }
}
