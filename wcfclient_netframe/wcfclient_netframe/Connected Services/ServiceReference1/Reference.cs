﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfclient_netframe.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="emp", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class emp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> deptnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string empnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int empnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> salaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> deptno {
            get {
                return this.deptnoField;
            }
            set {
                if ((this.deptnoField.Equals(value) != true)) {
                    this.deptnoField = value;
                    this.RaisePropertyChanged("deptno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string empname {
            get {
                return this.empnameField;
            }
            set {
                if ((object.ReferenceEquals(this.empnameField, value) != true)) {
                    this.empnameField = value;
                    this.RaisePropertyChanged("empname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int empno {
            get {
                return this.empnoField;
            }
            set {
                if ((this.empnoField.Equals(value) != true)) {
                    this.empnoField = value;
                    this.RaisePropertyChanged("empno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string job {
            get {
                return this.jobField;
            }
            set {
                if ((object.ReferenceEquals(this.jobField, value) != true)) {
                    this.jobField = value;
                    this.RaisePropertyChanged("job");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> salary {
            get {
                return this.salaryField;
            }
            set {
                if ((this.salaryField.Equals(value) != true)) {
                    this.salaryField = value;
                    this.RaisePropertyChanged("salary");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        void Register(wcfclient_netframe.ServiceReference1.emp obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        System.Threading.Tasks.Task RegisterAsync(wcfclient_netframe.ServiceReference1.emp obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRec", ReplyAction="http://tempuri.org/IService/GetRecResponse")]
        wcfclient_netframe.ServiceReference1.emp[] GetRec();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRec", ReplyAction="http://tempuri.org/IService/GetRecResponse")]
        System.Threading.Tasks.Task<wcfclient_netframe.ServiceReference1.emp[]> GetRecAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : wcfclient_netframe.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<wcfclient_netframe.ServiceReference1.IService>, wcfclient_netframe.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Register(wcfclient_netframe.ServiceReference1.emp obj) {
            base.Channel.Register(obj);
        }
        
        public System.Threading.Tasks.Task RegisterAsync(wcfclient_netframe.ServiceReference1.emp obj) {
            return base.Channel.RegisterAsync(obj);
        }
        
        public wcfclient_netframe.ServiceReference1.emp[] GetRec() {
            return base.Channel.GetRec();
        }
        
        public System.Threading.Tasks.Task<wcfclient_netframe.ServiceReference1.emp[]> GetRecAsync() {
            return base.Channel.GetRecAsync();
        }
    }
}