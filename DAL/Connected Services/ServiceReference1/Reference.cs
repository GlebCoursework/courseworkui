﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public decimal Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseParts", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DAL.ServiceReference1.Engine))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DAL.ServiceReference1.Exterior))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DAL.ServiceReference1.Gearbox))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DAL.ServiceReference1.Interior))]
    public partial class BaseParts : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.ServiceReference1.Car[] CarsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProducerField;
        
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
        public DAL.ServiceReference1.Car[] Cars {
            get {
                return this.CarsField;
            }
            set {
                if ((object.ReferenceEquals(this.CarsField, value) != true)) {
                    this.CarsField = value;
                    this.RaisePropertyChanged("Cars");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
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
        public string Producer {
            get {
                return this.ProducerField;
            }
            set {
                if ((object.ReferenceEquals(this.ProducerField, value) != true)) {
                    this.ProducerField = value;
                    this.RaisePropertyChanged("Producer");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Engine", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Engine : DAL.ServiceReference1.BaseParts {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CylindersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LitersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TorqueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cylinders {
            get {
                return this.CylindersField;
            }
            set {
                if ((this.CylindersField.Equals(value) != true)) {
                    this.CylindersField = value;
                    this.RaisePropertyChanged("Cylinders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HP {
            get {
                return this.HPField;
            }
            set {
                if ((this.HPField.Equals(value) != true)) {
                    this.HPField = value;
                    this.RaisePropertyChanged("HP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Liters {
            get {
                return this.LitersField;
            }
            set {
                if ((this.LitersField.Equals(value) != true)) {
                    this.LitersField = value;
                    this.RaisePropertyChanged("Liters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Torque {
            get {
                return this.TorqueField;
            }
            set {
                if ((this.TorqueField.Equals(value) != true)) {
                    this.TorqueField = value;
                    this.RaisePropertyChanged("Torque");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Exterior", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Exterior : DAL.ServiceReference1.BaseParts {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeOfPaintField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colour {
            get {
                return this.ColourField;
            }
            set {
                if ((object.ReferenceEquals(this.ColourField, value) != true)) {
                    this.ColourField = value;
                    this.RaisePropertyChanged("Colour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeOfPaint {
            get {
                return this.TypeOfPaintField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeOfPaintField, value) != true)) {
                    this.TypeOfPaintField = value;
                    this.RaisePropertyChanged("TypeOfPaint");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gearbox", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Gearbox : DAL.ServiceReference1.BaseParts {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Interior", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Interior : DAL.ServiceReference1.BaseParts {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaterialField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colour {
            get {
                return this.ColourField;
            }
            set {
                if ((object.ReferenceEquals(this.ColourField, value) != true)) {
                    this.ColourField = value;
                    this.RaisePropertyChanged("Colour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Material {
            get {
                return this.MaterialField;
            }
            set {
                if ((object.ReferenceEquals(this.MaterialField, value) != true)) {
                    this.MaterialField = value;
                    this.RaisePropertyChanged("Material");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/coursework.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.ServiceReference1.Engine EngineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.ServiceReference1.Exterior ExteriorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.ServiceReference1.Gearbox GearboxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.ServiceReference1.Interior InteriorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public DAL.ServiceReference1.Engine Engine {
            get {
                return this.EngineField;
            }
            set {
                if ((object.ReferenceEquals(this.EngineField, value) != true)) {
                    this.EngineField = value;
                    this.RaisePropertyChanged("Engine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DAL.ServiceReference1.Exterior Exterior {
            get {
                return this.ExteriorField;
            }
            set {
                if ((object.ReferenceEquals(this.ExteriorField, value) != true)) {
                    this.ExteriorField = value;
                    this.RaisePropertyChanged("Exterior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DAL.ServiceReference1.Gearbox Gearbox {
            get {
                return this.GearboxField;
            }
            set {
                if ((object.ReferenceEquals(this.GearboxField, value) != true)) {
                    this.GearboxField = value;
                    this.RaisePropertyChanged("Gearbox");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DAL.ServiceReference1.Interior Interior {
            get {
                return this.InteriorField;
            }
            set {
                if ((object.ReferenceEquals(this.InteriorField, value) != true)) {
                    this.InteriorField = value;
                    this.RaisePropertyChanged("Interior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
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
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMethods")]
    public interface IMethods {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ValidateUser", ReplyAction="http://tempuri.org/IMethods/ValidateUserResponse")]
        DAL.ServiceReference1.User ValidateUser(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ValidateUser", ReplyAction="http://tempuri.org/IMethods/ValidateUserResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.User> ValidateUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyUser", ReplyAction="http://tempuri.org/IMethods/ModifyUserResponse")]
        void ModifyUser(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyUser", ReplyAction="http://tempuri.org/IMethods/ModifyUserResponse")]
        System.Threading.Tasks.Task ModifyUserAsync(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetBaseParts", ReplyAction="http://tempuri.org/IMethods/GetBasePartsResponse")]
        DAL.ServiceReference1.BaseParts[] GetBaseParts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetBaseParts", ReplyAction="http://tempuri.org/IMethods/GetBasePartsResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.BaseParts[]> GetBasePartsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddParts", ReplyAction="http://tempuri.org/IMethods/AddPartsResponse")]
        void AddParts(DAL.ServiceReference1.BaseParts baseParts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddParts", ReplyAction="http://tempuri.org/IMethods/AddPartsResponse")]
        System.Threading.Tasks.Task AddPartsAsync(DAL.ServiceReference1.BaseParts baseParts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddUser", ReplyAction="http://tempuri.org/IMethods/AddUserResponse")]
        void AddUser(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddUser", ReplyAction="http://tempuri.org/IMethods/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyParts", ReplyAction="http://tempuri.org/IMethods/ModifyPartsResponse")]
        void ModifyParts(DAL.ServiceReference1.BaseParts baseParts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyParts", ReplyAction="http://tempuri.org/IMethods/ModifyPartsResponse")]
        System.Threading.Tasks.Task ModifyPartsAsync(DAL.ServiceReference1.BaseParts baseParts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddCar", ReplyAction="http://tempuri.org/IMethods/AddCarResponse")]
        void AddCar(DAL.ServiceReference1.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/AddCar", ReplyAction="http://tempuri.org/IMethods/AddCarResponse")]
        System.Threading.Tasks.Task AddCarAsync(DAL.ServiceReference1.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetCars", ReplyAction="http://tempuri.org/IMethods/GetCarsResponse")]
        DAL.ServiceReference1.Car[] GetCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetCars", ReplyAction="http://tempuri.org/IMethods/GetCarsResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.Car[]> GetCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SellCar", ReplyAction="http://tempuri.org/IMethods/SellCarResponse")]
        void SellCar(int id, int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SellCar", ReplyAction="http://tempuri.org/IMethods/SellCarResponse")]
        System.Threading.Tasks.Task SellCarAsync(int id, int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetUser", ReplyAction="http://tempuri.org/IMethods/GetUserResponse")]
        DAL.ServiceReference1.User GetUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/GetUser", ReplyAction="http://tempuri.org/IMethods/GetUserResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.User> GetUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyCar", ReplyAction="http://tempuri.org/IMethods/ModifyCarResponse")]
        void ModifyCar(DAL.ServiceReference1.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/ModifyCar", ReplyAction="http://tempuri.org/IMethods/ModifyCarResponse")]
        System.Threading.Tasks.Task ModifyCarAsync(DAL.ServiceReference1.Car car);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMethodsChannel : DAL.ServiceReference1.IMethods, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MethodsClient : System.ServiceModel.ClientBase<DAL.ServiceReference1.IMethods>, DAL.ServiceReference1.IMethods {
        
        public MethodsClient() {
        }
        
        public MethodsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MethodsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MethodsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MethodsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAL.ServiceReference1.User ValidateUser(string login, string password) {
            return base.Channel.ValidateUser(login, password);
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.User> ValidateUserAsync(string login, string password) {
            return base.Channel.ValidateUserAsync(login, password);
        }
        
        public void ModifyUser(DAL.ServiceReference1.User user) {
            base.Channel.ModifyUser(user);
        }
        
        public System.Threading.Tasks.Task ModifyUserAsync(DAL.ServiceReference1.User user) {
            return base.Channel.ModifyUserAsync(user);
        }
        
        public DAL.ServiceReference1.BaseParts[] GetBaseParts() {
            return base.Channel.GetBaseParts();
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.BaseParts[]> GetBasePartsAsync() {
            return base.Channel.GetBasePartsAsync();
        }
        
        public void AddParts(DAL.ServiceReference1.BaseParts baseParts) {
            base.Channel.AddParts(baseParts);
        }
        
        public System.Threading.Tasks.Task AddPartsAsync(DAL.ServiceReference1.BaseParts baseParts) {
            return base.Channel.AddPartsAsync(baseParts);
        }
        
        public void AddUser(DAL.ServiceReference1.User user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(DAL.ServiceReference1.User user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public void ModifyParts(DAL.ServiceReference1.BaseParts baseParts) {
            base.Channel.ModifyParts(baseParts);
        }
        
        public System.Threading.Tasks.Task ModifyPartsAsync(DAL.ServiceReference1.BaseParts baseParts) {
            return base.Channel.ModifyPartsAsync(baseParts);
        }
        
        public void AddCar(DAL.ServiceReference1.Car car) {
            base.Channel.AddCar(car);
        }
        
        public System.Threading.Tasks.Task AddCarAsync(DAL.ServiceReference1.Car car) {
            return base.Channel.AddCarAsync(car);
        }
        
        public DAL.ServiceReference1.Car[] GetCars() {
            return base.Channel.GetCars();
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.Car[]> GetCarsAsync() {
            return base.Channel.GetCarsAsync();
        }
        
        public void SellCar(int id, int userid) {
            base.Channel.SellCar(id, userid);
        }
        
        public System.Threading.Tasks.Task SellCarAsync(int id, int userid) {
            return base.Channel.SellCarAsync(id, userid);
        }
        
        public DAL.ServiceReference1.User GetUser(int id) {
            return base.Channel.GetUser(id);
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.User> GetUserAsync(int id) {
            return base.Channel.GetUserAsync(id);
        }
        
        public void ModifyCar(DAL.ServiceReference1.Car car) {
            base.Channel.ModifyCar(car);
        }
        
        public System.Threading.Tasks.Task ModifyCarAsync(DAL.ServiceReference1.Car car) {
            return base.Channel.ModifyCarAsync(car);
        }
    }
}