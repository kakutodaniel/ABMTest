﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _Test.ws {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ws.WebServiceDocSoap")]
    public interface WebServiceDocSoap {
        
        // CODEGEN: Generating message contract since the operation CheckXML is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        _Test.ws.CheckXMLResponse CheckXML(_Test.ws.CheckXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckXML", ReplyAction="*")]
        System.Threading.Tasks.Task<_Test.ws.CheckXMLResponse> CheckXMLAsync(_Test.ws.CheckXMLRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Xml.XmlNode input;
        
        public CheckXMLRequest() {
        }
        
        public CheckXMLRequest(System.Xml.XmlNode input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string CheckXMLResult;
        
        public CheckXMLResponse() {
        }
        
        public CheckXMLResponse(string CheckXMLResult) {
            this.CheckXMLResult = CheckXMLResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceDocSoapChannel : _Test.ws.WebServiceDocSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceDocSoapClient : System.ServiceModel.ClientBase<_Test.ws.WebServiceDocSoap>, _Test.ws.WebServiceDocSoap {
        
        public WebServiceDocSoapClient() {
        }
        
        public WebServiceDocSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceDocSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDocSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDocSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _Test.ws.CheckXMLResponse _Test.ws.WebServiceDocSoap.CheckXML(_Test.ws.CheckXMLRequest request) {
            return base.Channel.CheckXML(request);
        }
        
        public string CheckXML(System.Xml.XmlNode input) {
            _Test.ws.CheckXMLRequest inValue = new _Test.ws.CheckXMLRequest();
            inValue.input = input;
            _Test.ws.CheckXMLResponse retVal = ((_Test.ws.WebServiceDocSoap)(this)).CheckXML(inValue);
            return retVal.CheckXMLResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_Test.ws.CheckXMLResponse> _Test.ws.WebServiceDocSoap.CheckXMLAsync(_Test.ws.CheckXMLRequest request) {
            return base.Channel.CheckXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<_Test.ws.CheckXMLResponse> CheckXMLAsync(System.Xml.XmlNode input) {
            _Test.ws.CheckXMLRequest inValue = new _Test.ws.CheckXMLRequest();
            inValue.input = input;
            return ((_Test.ws.WebServiceDocSoap)(this)).CheckXMLAsync(inValue);
        }
    }
}
