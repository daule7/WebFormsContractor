﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFormsContractor.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Create(string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        System.Threading.Tasks.Task CreateAsync(string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Read(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Read", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ReadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Update(int id, string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateAsync(int id, string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebFormsContractor.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebFormsContractor.ServiceReference1.WebService1Soap>, WebFormsContractor.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender) {
            base.Channel.Create(iin, name, age, createdDate, editedDate, gender);
        }
        
        public System.Threading.Tasks.Task CreateAsync(string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender) {
            return base.Channel.CreateAsync(iin, name, age, createdDate, editedDate, gender);
        }
        
        public System.Data.DataSet Read(int id) {
            return base.Channel.Read(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ReadAsync(int id) {
            return base.Channel.ReadAsync(id);
        }
        
        public void Update(int id, string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender) {
            base.Channel.Update(id, iin, name, age, createdDate, editedDate, gender);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(int id, string iin, string name, int age, System.DateTime createdDate, System.DateTime editedDate, string gender) {
            return base.Channel.UpdateAsync(id, iin, name, age, createdDate, editedDate, gender);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
