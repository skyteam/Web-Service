﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IBService")]
    public interface IBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBService/LogIn", ReplyAction="http://tempuri.org/IBService/LogInResponse")]
        string LogIn();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBService/LogIn", ReplyAction="http://tempuri.org/IBService/LogInResponse")]
        System.IAsyncResult BeginLogIn(System.AsyncCallback callback, object asyncState);
        
        string EndLogIn(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBServiceChannel : Client.MyService.IBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogInCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public LogInCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BServiceClient : System.ServiceModel.ClientBase<Client.MyService.IBService>, Client.MyService.IBService {
        
        private BeginOperationDelegate onBeginLogInDelegate;
        
        private EndOperationDelegate onEndLogInDelegate;
        
        private System.Threading.SendOrPostCallback onLogInCompletedDelegate;
        
        public BServiceClient() {
        }
        
        public BServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<LogInCompletedEventArgs> LogInCompleted;
        
        public string LogIn() {
            return base.Channel.LogIn();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginLogIn(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLogIn(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndLogIn(System.IAsyncResult result) {
            return base.Channel.EndLogIn(result);
        }
        
        private System.IAsyncResult OnBeginLogIn(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginLogIn(callback, asyncState);
        }
        
        private object[] OnEndLogIn(System.IAsyncResult result) {
            string retVal = this.EndLogIn(result);
            return new object[] {
                    retVal};
        }
        
        private void OnLogInCompleted(object state) {
            if ((this.LogInCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LogInCompleted(this, new LogInCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LogInAsync() {
            this.LogInAsync(null);
        }
        
        public void LogInAsync(object userState) {
            if ((this.onBeginLogInDelegate == null)) {
                this.onBeginLogInDelegate = new BeginOperationDelegate(this.OnBeginLogIn);
            }
            if ((this.onEndLogInDelegate == null)) {
                this.onEndLogInDelegate = new EndOperationDelegate(this.OnEndLogIn);
            }
            if ((this.onLogInCompletedDelegate == null)) {
                this.onLogInCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLogInCompleted);
            }
            base.InvokeAsync(this.onBeginLogInDelegate, null, this.onEndLogInDelegate, this.onLogInCompletedDelegate, userState);
        }
    }
}
