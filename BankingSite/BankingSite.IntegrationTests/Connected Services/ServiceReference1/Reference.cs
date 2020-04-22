﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingSite.IntegrationTests.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICreditCardApplicationService")]
    public interface ICreditCardApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCardApplicationService/SubmitApplication", ReplyAction="http://tempuri.org/ICreditCardApplicationService/SubmitApplicationResponse")]
        BankingSite.Model.DomainEntities.SubmissionResult SubmitApplication(BankingSite.Model.DomainEntities.CreditCardApplication application);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCardApplicationService/SubmitApplication", ReplyAction="http://tempuri.org/ICreditCardApplicationService/SubmitApplicationResponse")]
        System.Threading.Tasks.Task<BankingSite.Model.DomainEntities.SubmissionResult> SubmitApplicationAsync(BankingSite.Model.DomainEntities.CreditCardApplication application);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCardApplicationService/GetSuccesfulApplicantsName", ReplyAction="http://tempuri.org/ICreditCardApplicationService/GetSuccesfulApplicantsNameRespon" +
            "se")]
        string GetSuccesfulApplicantsName(int submissionReferenceResult);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditCardApplicationService/GetSuccesfulApplicantsName", ReplyAction="http://tempuri.org/ICreditCardApplicationService/GetSuccesfulApplicantsNameRespon" +
            "se")]
        System.Threading.Tasks.Task<string> GetSuccesfulApplicantsNameAsync(int submissionReferenceResult);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreditCardApplicationServiceChannel : BankingSite.IntegrationTests.ServiceReference1.ICreditCardApplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditCardApplicationServiceClient : System.ServiceModel.ClientBase<BankingSite.IntegrationTests.ServiceReference1.ICreditCardApplicationService>, BankingSite.IntegrationTests.ServiceReference1.ICreditCardApplicationService {
        
        public CreditCardApplicationServiceClient() {
        }
        
        public CreditCardApplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditCardApplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditCardApplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditCardApplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BankingSite.Model.DomainEntities.SubmissionResult SubmitApplication(BankingSite.Model.DomainEntities.CreditCardApplication application) {
            return base.Channel.SubmitApplication(application);
        }
        
        public System.Threading.Tasks.Task<BankingSite.Model.DomainEntities.SubmissionResult> SubmitApplicationAsync(BankingSite.Model.DomainEntities.CreditCardApplication application) {
            return base.Channel.SubmitApplicationAsync(application);
        }
        
        public string GetSuccesfulApplicantsName(int submissionReferenceResult) {
            return base.Channel.GetSuccesfulApplicantsName(submissionReferenceResult);
        }
        
        public System.Threading.Tasks.Task<string> GetSuccesfulApplicantsNameAsync(int submissionReferenceResult) {
            return base.Channel.GetSuccesfulApplicantsNameAsync(submissionReferenceResult);
        }
    }
}