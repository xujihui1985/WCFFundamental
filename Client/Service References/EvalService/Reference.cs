﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.EvalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eval", Namespace="http://test/evals")]
    [System.SerializableAttribute()]
    public partial class Eval : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubmitterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeSubmittedField;
        
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
        public string Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Submitter {
            get {
                return this.SubmitterField;
            }
            set {
                if ((object.ReferenceEquals(this.SubmitterField, value) != true)) {
                    this.SubmitterField = value;
                    this.RaisePropertyChanged("Submitter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeSubmitted {
            get {
                return this.TimeSubmittedField;
            }
            set {
                if ((this.TimeSubmittedField.Equals(value) != true)) {
                    this.TimeSubmittedField = value;
                    this.RaisePropertyChanged("TimeSubmitted");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EvalService.IEvalService")]
    public interface IEvalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/SubmitEval", ReplyAction="http://tempuri.org/IEvalService/SubmitEvalResponse")]
        void SubmitEval(Client.EvalService.Eval eval);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/SubmitEval", ReplyAction="http://tempuri.org/IEvalService/SubmitEvalResponse")]
        System.Threading.Tasks.Task SubmitEvalAsync(Client.EvalService.Eval eval);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
        Client.EvalService.Eval[] GetEvals();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
        System.Threading.Tasks.Task<Client.EvalService.Eval[]> GetEvalsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvalsBySubmitter", ReplyAction="http://tempuri.org/IEvalService/GetEvalsBySubmitterResponse")]
        Client.EvalService.Eval[] GetEvalsBySubmitter(string submitter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvalsBySubmitter", ReplyAction="http://tempuri.org/IEvalService/GetEvalsBySubmitterResponse")]
        System.Threading.Tasks.Task<Client.EvalService.Eval[]> GetEvalsBySubmitterAsync(string submitter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/RemoveEval", ReplyAction="http://tempuri.org/IEvalService/RemoveEvalResponse")]
        void RemoveEval(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/RemoveEval", ReplyAction="http://tempuri.org/IEvalService/RemoveEvalResponse")]
        System.Threading.Tasks.Task RemoveEvalAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEvalServiceChannel : Client.EvalService.IEvalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EvalServiceClient : System.ServiceModel.ClientBase<Client.EvalService.IEvalService>, Client.EvalService.IEvalService {
        
        public EvalServiceClient() {
        }
        
        public EvalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SubmitEval(Client.EvalService.Eval eval) {
            base.Channel.SubmitEval(eval);
        }
        
        public System.Threading.Tasks.Task SubmitEvalAsync(Client.EvalService.Eval eval) {
            return base.Channel.SubmitEvalAsync(eval);
        }
        
        public Client.EvalService.Eval[] GetEvals() {
            return base.Channel.GetEvals();
        }
        
        public System.Threading.Tasks.Task<Client.EvalService.Eval[]> GetEvalsAsync() {
            return base.Channel.GetEvalsAsync();
        }
        
        public Client.EvalService.Eval[] GetEvalsBySubmitter(string submitter) {
            return base.Channel.GetEvalsBySubmitter(submitter);
        }
        
        public System.Threading.Tasks.Task<Client.EvalService.Eval[]> GetEvalsBySubmitterAsync(string submitter) {
            return base.Channel.GetEvalsBySubmitterAsync(submitter);
        }
        
        public void RemoveEval(string id) {
            base.Channel.RemoveEval(id);
        }
        
        public System.Threading.Tasks.Task RemoveEvalAsync(string id) {
            return base.Channel.RemoveEvalAsync(id);
        }
    }
}
