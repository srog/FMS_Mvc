﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FmsService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameDetails", Namespace="http://schemas.datacontract.org/2004/07/FMS_Service.Models")]
    public partial class GameDetails : object
    {
        
        private int CurrentWeekField;
        
        private int CurrentYearField;
        
        private int IdField;
        
        private string ManagerNameField;
        
        private int TeamIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentWeek
        {
            get
            {
                return this.CurrentWeekField;
            }
            set
            {
                this.CurrentWeekField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentYear
        {
            get
            {
                return this.CurrentYearField;
            }
            set
            {
                this.CurrentYearField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ManagerName
        {
            get
            {
                return this.ManagerNameField;
            }
            set
            {
                this.ManagerNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TeamId
        {
            get
            {
                return this.TeamIdField;
            }
            set
            {
                this.TeamIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Team", Namespace="http://schemas.datacontract.org/2004/07/FMS_Service.Models")]
    public partial class Team : object
    {
        
        private int CashField;
        
        private int DivisionField;
        
        private int IdField;
        
        private string NameField;
        
        private int StadiumCapacityField;
        
        private int YearFormedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cash
        {
            get
            {
                return this.CashField;
            }
            set
            {
                this.CashField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Division
        {
            get
            {
                return this.DivisionField;
            }
            set
            {
                this.DivisionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StadiumCapacity
        {
            get
            {
                return this.StadiumCapacityField;
            }
            set
            {
                this.StadiumCapacityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int YearFormed
        {
            get
            {
                return this.YearFormedField;
            }
            set
            {
                this.YearFormedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/FMS_Service.Models")]
    public partial class Player : object
    {
        
        private int AgeField;
        
        private int IdField;
        
        private int InjuredWeeksField;
        
        private string NameField;
        
        private System.Nullable<int> PositionField;
        
        private int RatingField;
        
        private bool RetiredField;
        
        private int TeamIdField;
        
        private int ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age
        {
            get
            {
                return this.AgeField;
            }
            set
            {
                this.AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InjuredWeeks
        {
            get
            {
                return this.InjuredWeeksField;
            }
            set
            {
                this.InjuredWeeksField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Position
        {
            get
            {
                return this.PositionField;
            }
            set
            {
                this.PositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Retired
        {
            get
            {
                return this.RetiredField;
            }
            set
            {
                this.RetiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TeamId
        {
            get
            {
                return this.TeamIdField;
            }
            set
            {
                this.TeamIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FmsService.IFmsService")]
    public interface IFmsService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/StartGame", ReplyAction="http://tempuri.org/IFmsService/StartGameResponse")]
        System.Threading.Tasks.Task StartGameAsync(int teamId, string managerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/GetAllGameDetails", ReplyAction="http://tempuri.org/IFmsService/GetAllGameDetailsResponse")]
        System.Threading.Tasks.Task<FmsService.GameDetails[]> GetAllGameDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/GetTeam", ReplyAction="http://tempuri.org/IFmsService/GetTeamResponse")]
        System.Threading.Tasks.Task<FmsService.Team> GetTeamAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/GetAllTeams", ReplyAction="http://tempuri.org/IFmsService/GetAllTeamsResponse")]
        System.Threading.Tasks.Task<FmsService.Team[]> GetAllTeamsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/UpdateTeam", ReplyAction="http://tempuri.org/IFmsService/UpdateTeamResponse")]
        System.Threading.Tasks.Task UpdateTeamAsync(FmsService.Team team);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/GetPlayer", ReplyAction="http://tempuri.org/IFmsService/GetPlayerResponse")]
        System.Threading.Tasks.Task<FmsService.Player> GetPlayerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/GetAllPlayers", ReplyAction="http://tempuri.org/IFmsService/GetAllPlayersResponse")]
        System.Threading.Tasks.Task<FmsService.Player[]> GetAllPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/CreatePlayer", ReplyAction="http://tempuri.org/IFmsService/CreatePlayerResponse")]
        System.Threading.Tasks.Task CreatePlayerAsync(FmsService.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFmsService/UpdatePlayer", ReplyAction="http://tempuri.org/IFmsService/UpdatePlayerResponse")]
        System.Threading.Tasks.Task UpdatePlayerAsync(FmsService.Player player);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    public interface IFmsServiceChannel : FmsService.IFmsService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    public partial class FmsServiceClient : System.ServiceModel.ClientBase<FmsService.IFmsService>, FmsService.IFmsService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FmsServiceClient() : 
                base(FmsServiceClient.GetDefaultBinding(), FmsServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IFmsService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FmsServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(FmsServiceClient.GetBindingForEndpoint(endpointConfiguration), FmsServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FmsServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FmsServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FmsServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FmsServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FmsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task StartGameAsync(int teamId, string managerName)
        {
            return base.Channel.StartGameAsync(teamId, managerName);
        }
        
        public System.Threading.Tasks.Task<FmsService.GameDetails[]> GetAllGameDetailsAsync()
        {
            return base.Channel.GetAllGameDetailsAsync();
        }
        
        public System.Threading.Tasks.Task<FmsService.Team> GetTeamAsync(int id)
        {
            return base.Channel.GetTeamAsync(id);
        }
        
        public System.Threading.Tasks.Task<FmsService.Team[]> GetAllTeamsAsync()
        {
            return base.Channel.GetAllTeamsAsync();
        }
        
        public System.Threading.Tasks.Task UpdateTeamAsync(FmsService.Team team)
        {
            return base.Channel.UpdateTeamAsync(team);
        }
        
        public System.Threading.Tasks.Task<FmsService.Player> GetPlayerAsync(int id)
        {
            return base.Channel.GetPlayerAsync(id);
        }
        
        public System.Threading.Tasks.Task<FmsService.Player[]> GetAllPlayersAsync()
        {
            return base.Channel.GetAllPlayersAsync();
        }
        
        public System.Threading.Tasks.Task CreatePlayerAsync(FmsService.Player player)
        {
            return base.Channel.CreatePlayerAsync(player);
        }
        
        public System.Threading.Tasks.Task UpdatePlayerAsync(FmsService.Player player)
        {
            return base.Channel.UpdatePlayerAsync(player);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFmsService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFmsService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59514/FmsService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FmsServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IFmsService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FmsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IFmsService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IFmsService,
        }
    }
}
