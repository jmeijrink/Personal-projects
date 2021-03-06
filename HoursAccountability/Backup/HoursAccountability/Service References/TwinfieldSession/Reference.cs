﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoursAccountability.TwinfieldSession {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.twinfield.com/", ConfigurationName="TwinfieldSession.SessionSoap")]
    public interface SessionSoap {
        
        // CODEGEN: Generating message contract since message LogonResponse has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/Logon", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.LogonResponse Logon(HoursAccountability.TwinfieldSession.LogonRequest request);
        
        // CODEGEN: Generating message contract since message SmsLogonRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/SmsLogon", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.SmsLogonResponse SmsLogon(HoursAccountability.TwinfieldSession.SmsLogonRequest request);
        
        // CODEGEN: Generating message contract since message SmsSendCodeRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/SmsSendCode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.SmsSendCodeResponse SmsSendCode(HoursAccountability.TwinfieldSession.SmsSendCodeRequest request);
        
        // CODEGEN: Generating message contract since message ChangePasswordRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/ChangePassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.ChangePasswordResponse ChangePassword(HoursAccountability.TwinfieldSession.ChangePasswordRequest request);
        
        // CODEGEN: Generating message contract since message SelectCompanyRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/SelectCompany", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.SelectCompanyResponse SelectCompany(HoursAccountability.TwinfieldSession.SelectCompanyRequest request);
        
        // CODEGEN: Generating message contract since message KeepAliveRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/KeepAlive", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.KeepAliveResponse KeepAlive(HoursAccountability.TwinfieldSession.KeepAliveRequest request);
        
        // CODEGEN: Generating message contract since message AbandonRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/Abandon", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.AbandonResponse Abandon(HoursAccountability.TwinfieldSession.AbandonRequest request);
        
        // CODEGEN: Generating message contract since message GetRoleRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://www.twinfield.com/GetRole", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        HoursAccountability.TwinfieldSession.GetRoleResponse GetRole(HoursAccountability.TwinfieldSession.GetRoleRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public partial class Header : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sessionIDField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SessionID {
            get {
                return this.sessionIDField;
            }
            set {
                this.sessionIDField = value;
                this.RaisePropertyChanged("SessionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public enum LogonResult {
        
        /// <remarks/>
        Ok,
        
        /// <remarks/>
        Blocked,
        
        /// <remarks/>
        Untrusted,
        
        /// <remarks/>
        Invalid,
        
        /// <remarks/>
        Deleted,
        
        /// <remarks/>
        Disabled,
        
        /// <remarks/>
        OrganisationInactive,
        
        /// <remarks/>
        ClientInvalid,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public enum LogonAction {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        SMSLogon,
        
        /// <remarks/>
        ChangePassword,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Logon", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class LogonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=2)]
        public string organisation;
        
        public LogonRequest() {
        }
        
        public LogonRequest(string user, string password, string organisation) {
            this.user = user;
            this.password = password;
            this.organisation = organisation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogonResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class LogonResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public HoursAccountability.TwinfieldSession.LogonResult LogonResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=1)]
        public HoursAccountability.TwinfieldSession.LogonAction nextAction;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=2)]
        public string cluster;
        
        public LogonResponse() {
        }
        
        public LogonResponse(HoursAccountability.TwinfieldSession.Header Header, HoursAccountability.TwinfieldSession.LogonResult LogonResult, HoursAccountability.TwinfieldSession.LogonAction nextAction, string cluster) {
            this.Header = Header;
            this.LogonResult = LogonResult;
            this.nextAction = nextAction;
            this.cluster = cluster;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public enum SMSLogonResult {
        
        /// <remarks/>
        Ok,
        
        /// <remarks/>
        Invalid,
        
        /// <remarks/>
        TimeOut,
        
        /// <remarks/>
        Disabled,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SmsLogon", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SmsLogonRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string smsCode;
        
        public SmsLogonRequest() {
        }
        
        public SmsLogonRequest(HoursAccountability.TwinfieldSession.Header Header, string smsCode) {
            this.Header = Header;
            this.smsCode = smsCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SmsLogonResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SmsLogonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public HoursAccountability.TwinfieldSession.SMSLogonResult SmsLogonResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=1)]
        public HoursAccountability.TwinfieldSession.LogonAction nextAction;
        
        public SmsLogonResponse() {
        }
        
        public SmsLogonResponse(HoursAccountability.TwinfieldSession.SMSLogonResult SmsLogonResult, HoursAccountability.TwinfieldSession.LogonAction nextAction) {
            this.SmsLogonResult = SmsLogonResult;
            this.nextAction = nextAction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SmsSendCode", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SmsSendCodeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        public SmsSendCodeRequest() {
        }
        
        public SmsSendCodeRequest(HoursAccountability.TwinfieldSession.Header Header) {
            this.Header = Header;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SmsSendCodeResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SmsSendCodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public int SmsSendCodeResult;
        
        public SmsSendCodeResponse() {
        }
        
        public SmsSendCodeResponse(int SmsSendCodeResult) {
            this.SmsSendCodeResult = SmsSendCodeResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public enum ChangePasswordResult {
        
        /// <remarks/>
        Ok,
        
        /// <remarks/>
        Invalid,
        
        /// <remarks/>
        NotDifferent,
        
        /// <remarks/>
        NotSecure,
        
        /// <remarks/>
        Disabled,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChangePassword", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ChangePasswordRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string currentPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=1)]
        public string newPassword;
        
        public ChangePasswordRequest() {
        }
        
        public ChangePasswordRequest(HoursAccountability.TwinfieldSession.Header Header, string currentPassword, string newPassword) {
            this.Header = Header;
            this.currentPassword = currentPassword;
            this.newPassword = newPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChangePasswordResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class ChangePasswordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public HoursAccountability.TwinfieldSession.ChangePasswordResult ChangePasswordResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=1)]
        public HoursAccountability.TwinfieldSession.LogonAction nextAction;
        
        public ChangePasswordResponse() {
        }
        
        public ChangePasswordResponse(HoursAccountability.TwinfieldSession.ChangePasswordResult ChangePasswordResult, HoursAccountability.TwinfieldSession.LogonAction nextAction) {
            this.ChangePasswordResult = ChangePasswordResult;
            this.nextAction = nextAction;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.twinfield.com/")]
    public enum SelectCompanyResult {
        
        /// <remarks/>
        Ok,
        
        /// <remarks/>
        Invalid,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectCompany", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SelectCompanyRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string company;
        
        public SelectCompanyRequest() {
        }
        
        public SelectCompanyRequest(HoursAccountability.TwinfieldSession.Header Header, string company) {
            this.Header = Header;
            this.company = company;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SelectCompanyResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class SelectCompanyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public HoursAccountability.TwinfieldSession.SelectCompanyResult SelectCompanyResult;
        
        public SelectCompanyResponse() {
        }
        
        public SelectCompanyResponse(HoursAccountability.TwinfieldSession.SelectCompanyResult SelectCompanyResult) {
            this.SelectCompanyResult = SelectCompanyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="KeepAlive", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class KeepAliveRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        public KeepAliveRequest() {
        }
        
        public KeepAliveRequest(HoursAccountability.TwinfieldSession.Header Header) {
            this.Header = Header;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="KeepAliveResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class KeepAliveResponse {
        
        public KeepAliveResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Abandon", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class AbandonRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        public AbandonRequest() {
        }
        
        public AbandonRequest(HoursAccountability.TwinfieldSession.Header Header) {
            this.Header = Header;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AbandonResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class AbandonResponse {
        
        public AbandonResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRole", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class GetRoleRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.twinfield.com/")]
        public HoursAccountability.TwinfieldSession.Header Header;
        
        public GetRoleRequest() {
        }
        
        public GetRoleRequest(HoursAccountability.TwinfieldSession.Header Header) {
            this.Header = Header;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRoleResponse", WrapperNamespace="http://www.twinfield.com/", IsWrapped=true)]
    public partial class GetRoleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.twinfield.com/", Order=0)]
        public string GetRoleResult;
        
        public GetRoleResponse() {
        }
        
        public GetRoleResponse(string GetRoleResult) {
            this.GetRoleResult = GetRoleResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface SessionSoapChannel : HoursAccountability.TwinfieldSession.SessionSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class SessionSoapClient : System.ServiceModel.ClientBase<HoursAccountability.TwinfieldSession.SessionSoap>, HoursAccountability.TwinfieldSession.SessionSoap {
        
        public SessionSoapClient() {
        }
        
        public SessionSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SessionSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.LogonResponse HoursAccountability.TwinfieldSession.SessionSoap.Logon(HoursAccountability.TwinfieldSession.LogonRequest request) {
            return base.Channel.Logon(request);
        }
        
        public HoursAccountability.TwinfieldSession.Header Logon(string user, string password, string organisation, out HoursAccountability.TwinfieldSession.LogonResult LogonResult, out HoursAccountability.TwinfieldSession.LogonAction nextAction, out string cluster) {
            HoursAccountability.TwinfieldSession.LogonRequest inValue = new HoursAccountability.TwinfieldSession.LogonRequest();
            inValue.user = user;
            inValue.password = password;
            inValue.organisation = organisation;
            HoursAccountability.TwinfieldSession.LogonResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).Logon(inValue);
            LogonResult = retVal.LogonResult;
            nextAction = retVal.nextAction;
            cluster = retVal.cluster;
            return retVal.Header;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.SmsLogonResponse HoursAccountability.TwinfieldSession.SessionSoap.SmsLogon(HoursAccountability.TwinfieldSession.SmsLogonRequest request) {
            return base.Channel.SmsLogon(request);
        }
        
        public HoursAccountability.TwinfieldSession.SMSLogonResult SmsLogon(HoursAccountability.TwinfieldSession.Header Header, string smsCode, out HoursAccountability.TwinfieldSession.LogonAction nextAction) {
            HoursAccountability.TwinfieldSession.SmsLogonRequest inValue = new HoursAccountability.TwinfieldSession.SmsLogonRequest();
            inValue.Header = Header;
            inValue.smsCode = smsCode;
            HoursAccountability.TwinfieldSession.SmsLogonResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).SmsLogon(inValue);
            nextAction = retVal.nextAction;
            return retVal.SmsLogonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.SmsSendCodeResponse HoursAccountability.TwinfieldSession.SessionSoap.SmsSendCode(HoursAccountability.TwinfieldSession.SmsSendCodeRequest request) {
            return base.Channel.SmsSendCode(request);
        }
        
        public int SmsSendCode(HoursAccountability.TwinfieldSession.Header Header) {
            HoursAccountability.TwinfieldSession.SmsSendCodeRequest inValue = new HoursAccountability.TwinfieldSession.SmsSendCodeRequest();
            inValue.Header = Header;
            HoursAccountability.TwinfieldSession.SmsSendCodeResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).SmsSendCode(inValue);
            return retVal.SmsSendCodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.ChangePasswordResponse HoursAccountability.TwinfieldSession.SessionSoap.ChangePassword(HoursAccountability.TwinfieldSession.ChangePasswordRequest request) {
            return base.Channel.ChangePassword(request);
        }
        
        public HoursAccountability.TwinfieldSession.ChangePasswordResult ChangePassword(HoursAccountability.TwinfieldSession.Header Header, string currentPassword, string newPassword, out HoursAccountability.TwinfieldSession.LogonAction nextAction) {
            HoursAccountability.TwinfieldSession.ChangePasswordRequest inValue = new HoursAccountability.TwinfieldSession.ChangePasswordRequest();
            inValue.Header = Header;
            inValue.currentPassword = currentPassword;
            inValue.newPassword = newPassword;
            HoursAccountability.TwinfieldSession.ChangePasswordResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).ChangePassword(inValue);
            nextAction = retVal.nextAction;
            return retVal.ChangePasswordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.SelectCompanyResponse HoursAccountability.TwinfieldSession.SessionSoap.SelectCompany(HoursAccountability.TwinfieldSession.SelectCompanyRequest request) {
            return base.Channel.SelectCompany(request);
        }
        
        public HoursAccountability.TwinfieldSession.SelectCompanyResult SelectCompany(HoursAccountability.TwinfieldSession.Header Header, string company) {
            HoursAccountability.TwinfieldSession.SelectCompanyRequest inValue = new HoursAccountability.TwinfieldSession.SelectCompanyRequest();
            inValue.Header = Header;
            inValue.company = company;
            HoursAccountability.TwinfieldSession.SelectCompanyResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).SelectCompany(inValue);
            return retVal.SelectCompanyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.KeepAliveResponse HoursAccountability.TwinfieldSession.SessionSoap.KeepAlive(HoursAccountability.TwinfieldSession.KeepAliveRequest request) {
            return base.Channel.KeepAlive(request);
        }
        
        public void KeepAlive(HoursAccountability.TwinfieldSession.Header Header) {
            HoursAccountability.TwinfieldSession.KeepAliveRequest inValue = new HoursAccountability.TwinfieldSession.KeepAliveRequest();
            inValue.Header = Header;
            HoursAccountability.TwinfieldSession.KeepAliveResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).KeepAlive(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.AbandonResponse HoursAccountability.TwinfieldSession.SessionSoap.Abandon(HoursAccountability.TwinfieldSession.AbandonRequest request) {
            return base.Channel.Abandon(request);
        }
        
        public void Abandon(HoursAccountability.TwinfieldSession.Header Header) {
            HoursAccountability.TwinfieldSession.AbandonRequest inValue = new HoursAccountability.TwinfieldSession.AbandonRequest();
            inValue.Header = Header;
            HoursAccountability.TwinfieldSession.AbandonResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).Abandon(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HoursAccountability.TwinfieldSession.GetRoleResponse HoursAccountability.TwinfieldSession.SessionSoap.GetRole(HoursAccountability.TwinfieldSession.GetRoleRequest request) {
            return base.Channel.GetRole(request);
        }
        
        public string GetRole(HoursAccountability.TwinfieldSession.Header Header) {
            HoursAccountability.TwinfieldSession.GetRoleRequest inValue = new HoursAccountability.TwinfieldSession.GetRoleRequest();
            inValue.Header = Header;
            HoursAccountability.TwinfieldSession.GetRoleResponse retVal = ((HoursAccountability.TwinfieldSession.SessionSoap)(this)).GetRole(inValue);
            return retVal.GetRoleResult;
        }
    }
}
