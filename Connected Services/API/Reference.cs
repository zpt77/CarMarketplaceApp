//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarMarketplaceApp.API {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/CarMarketplaceServiceProject")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EngineSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductionYearField;
        
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
        public string EngineSize {
            get {
                return this.EngineSizeField;
            }
            set {
                if ((object.ReferenceEquals(this.EngineSizeField, value) != true)) {
                    this.EngineSizeField = value;
                    this.RaisePropertyChanged("EngineSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductionYear {
            get {
                return this.ProductionYearField;
            }
            set {
                if ((this.ProductionYearField.Equals(value) != true)) {
                    this.ProductionYearField = value;
                    this.RaisePropertyChanged("ProductionYear");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="API.ICarMarketplaceAPI")]
    public interface ICarMarketplaceAPI {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/GetAllCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/GetAllCarsResponse")]
        CarMarketplaceApp.API.Car[] GetAllCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/GetAllCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/GetAllCarsResponse")]
        System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> GetAllCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/GetCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/GetCarsResponse")]
        CarMarketplaceApp.API.Car[] GetCars(string make, string model, int minEngineSize, int maxEngineSize, int minProductionYear, int maxProductionYear, int minPrice, int maxPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/GetCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/GetCarsResponse")]
        System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> GetCarsAsync(string make, string model, int minEngineSize, int maxEngineSize, int minProductionYear, int maxProductionYear, int minPrice, int maxPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/AddCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/AddCarsResponse")]
        CarMarketplaceApp.API.Car[] AddCars(string make, string model, string engineSize, int productionYear, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarMarketplaceAPI/AddCars", ReplyAction="http://tempuri.org/ICarMarketplaceAPI/AddCarsResponse")]
        System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> AddCarsAsync(string make, string model, string engineSize, int productionYear, int price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarMarketplaceAPIChannel : CarMarketplaceApp.API.ICarMarketplaceAPI, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarMarketplaceAPIClient : System.ServiceModel.ClientBase<CarMarketplaceApp.API.ICarMarketplaceAPI>, CarMarketplaceApp.API.ICarMarketplaceAPI {
        
        public CarMarketplaceAPIClient() {
        }
        
        public CarMarketplaceAPIClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarMarketplaceAPIClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarMarketplaceAPIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarMarketplaceAPIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CarMarketplaceApp.API.Car[] GetAllCars() {
            return base.Channel.GetAllCars();
        }
        
        public System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> GetAllCarsAsync() {
            return base.Channel.GetAllCarsAsync();
        }
        
        public CarMarketplaceApp.API.Car[] GetCars(string make, string model, int minEngineSize, int maxEngineSize, int minProductionYear, int maxProductionYear, int minPrice, int maxPrice) {
            return base.Channel.GetCars(make, model, minEngineSize, maxEngineSize, minProductionYear, maxProductionYear, minPrice, maxPrice);
        }
        
        public System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> GetCarsAsync(string make, string model, int minEngineSize, int maxEngineSize, int minProductionYear, int maxProductionYear, int minPrice, int maxPrice) {
            return base.Channel.GetCarsAsync(make, model, minEngineSize, maxEngineSize, minProductionYear, maxProductionYear, minPrice, maxPrice);
        }
        
        public CarMarketplaceApp.API.Car[] AddCars(string make, string model, string engineSize, int productionYear, int price) {
            return base.Channel.AddCars(make, model, engineSize, productionYear, price);
        }
        
        public System.Threading.Tasks.Task<CarMarketplaceApp.API.Car[]> AddCarsAsync(string make, string model, string engineSize, int productionYear, int price) {
            return base.Channel.AddCarsAsync(make, model, engineSize, productionYear, price);
        }
    }
}
