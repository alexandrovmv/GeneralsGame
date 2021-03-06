﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneralsClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGeneral")]
    public interface IGeneral {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetTerritorySize", ReplyAction="http://tempuri.org/IGeneral/GetTerritorySizeResponse")]
        int GetTerritorySize(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetTerritorySize", ReplyAction="http://tempuri.org/IGeneral/GetTerritorySizeResponse")]
        System.Threading.Tasks.Task<int> GetTerritorySizeAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxPeopleCount", ReplyAction="http://tempuri.org/IGeneral/GetMaxPeopleCountResponse")]
        int GetMaxPeopleCount(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxPeopleCount", ReplyAction="http://tempuri.org/IGeneral/GetMaxPeopleCountResponse")]
        System.Threading.Tasks.Task<int> GetMaxPeopleCountAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSeedCount", ReplyAction="http://tempuri.org/IGeneral/GetSeedCountResponse")]
        int GetSeedCount(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSeedCount", ReplyAction="http://tempuri.org/IGeneral/GetSeedCountResponse")]
        System.Threading.Tasks.Task<int> GetSeedCountAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSeedIncrement", ReplyAction="http://tempuri.org/IGeneral/GetSeedIncrementResponse")]
        int GetSeedIncrement(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSeedIncrement", ReplyAction="http://tempuri.org/IGeneral/GetSeedIncrementResponse")]
        System.Threading.Tasks.Task<int> GetSeedIncrementAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetPeopleIncrement", ReplyAction="http://tempuri.org/IGeneral/GetPeopleIncrementResponse")]
        int GetPeopleIncrement(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetPeopleIncrement", ReplyAction="http://tempuri.org/IGeneral/GetPeopleIncrementResponse")]
        System.Threading.Tasks.Task<int> GetPeopleIncrementAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientists", ReplyAction="http://tempuri.org/IGeneral/GetScientistsResponse")]
        int GetScientists(string Playername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientists", ReplyAction="http://tempuri.org/IGeneral/GetScientistsResponse")]
        System.Threading.Tasks.Task<int> GetScientistsAsync(string Playername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SpendOnScientists", ReplyAction="http://tempuri.org/IGeneral/SpendOnScientistsResponse")]
        int SpendOnScientists(string Playername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SpendOnScientists", ReplyAction="http://tempuri.org/IGeneral/SpendOnScientistsResponse")]
        System.Threading.Tasks.Task<int> SpendOnScientistsAsync(string Playername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMoney", ReplyAction="http://tempuri.org/IGeneral/GetMoneyResponse")]
        int GetMoney(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMoney", ReplyAction="http://tempuri.org/IGeneral/GetMoneyResponse")]
        System.Threading.Tasks.Task<int> GetMoneyAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/isServerFull", ReplyAction="http://tempuri.org/IGeneral/isServerFullResponse")]
        bool isServerFull();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/isServerFull", ReplyAction="http://tempuri.org/IGeneral/isServerFullResponse")]
        System.Threading.Tasks.Task<bool> isServerFullAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/ReName", ReplyAction="http://tempuri.org/IGeneral/ReNameResponse")]
        void ReName(string Oldname, string NewName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/ReName", ReplyAction="http://tempuri.org/IGeneral/ReNameResponse")]
        System.Threading.Tasks.Task ReNameAsync(string Oldname, string NewName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/FinishRound", ReplyAction="http://tempuri.org/IGeneral/FinishRoundResponse")]
        void FinishRound(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/FinishRound", ReplyAction="http://tempuri.org/IGeneral/FinishRoundResponse")]
        System.Threading.Tasks.Task FinishRoundAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/IsFinish", ReplyAction="http://tempuri.org/IGeneral/IsFinishResponse")]
        bool IsFinish();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/IsFinish", ReplyAction="http://tempuri.org/IGeneral/IsFinishResponse")]
        System.Threading.Tasks.Task<bool> IsFinishAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCount", ReplyAction="http://tempuri.org/IGeneral/GetCountResponse")]
        int GetCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCount", ReplyAction="http://tempuri.org/IGeneral/GetCountResponse")]
        System.Threading.Tasks.Task<int> GetCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/AddUser", ReplyAction="http://tempuri.org/IGeneral/AddUserResponse")]
        void AddUser(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/AddUser", ReplyAction="http://tempuri.org/IGeneral/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Registr", ReplyAction="http://tempuri.org/IGeneral/RegistrResponse")]
        bool Registr(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Registr", ReplyAction="http://tempuri.org/IGeneral/RegistrResponse")]
        System.Threading.Tasks.Task<bool> RegistrAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Autorise", ReplyAction="http://tempuri.org/IGeneral/AutoriseResponse")]
        bool Autorise(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Autorise", ReplyAction="http://tempuri.org/IGeneral/AutoriseResponse")]
        System.Threading.Tasks.Task<bool> AutoriseAsync(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireScietists", ReplyAction="http://tempuri.org/IGeneral/HireScietistsResponse")]
        void HireScietists(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireScietists", ReplyAction="http://tempuri.org/IGeneral/HireScietistsResponse")]
        System.Threading.Tasks.Task HireScietistsAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireSoldiers", ReplyAction="http://tempuri.org/IGeneral/HireSoldiersResponse")]
        void HireSoldiers(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireSoldiers", ReplyAction="http://tempuri.org/IGeneral/HireSoldiersResponse")]
        System.Threading.Tasks.Task HireSoldiersAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountScietists", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountScietistsResponse")]
        int GetMaxCountScietists(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountScietists", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountScietistsResponse")]
        System.Threading.Tasks.Task<int> GetMaxCountScietistsAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountSoldiersResponse")]
        int GetMaxCountSoldiers(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountSoldiersResponse")]
        System.Threading.Tasks.Task<int> GetMaxCountSoldiersAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountOfSeeds", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountOfSeedsResponse")]
        int GetMaxCountOfSeeds(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetMaxCountOfSeeds", ReplyAction="http://tempuri.org/IGeneral/GetMaxCountOfSeedsResponse")]
        System.Threading.Tasks.Task<int> GetMaxCountOfSeedsAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/BuySeeds", ReplyAction="http://tempuri.org/IGeneral/BuySeedsResponse")]
        void BuySeeds(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/BuySeeds", ReplyAction="http://tempuri.org/IGeneral/BuySeedsResponse")]
        System.Threading.Tasks.Task BuySeedsAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellSeeds", ReplyAction="http://tempuri.org/IGeneral/SellSeedsResponse")]
        void SellSeeds(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellSeeds", ReplyAction="http://tempuri.org/IGeneral/SellSeedsResponse")]
        System.Threading.Tasks.Task SellSeedsAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellSoldiers", ReplyAction="http://tempuri.org/IGeneral/SellSoldiersResponse")]
        void SellSoldiers(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellSoldiers", ReplyAction="http://tempuri.org/IGeneral/SellSoldiersResponse")]
        System.Threading.Tasks.Task SellSoldiersAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellScietists", ReplyAction="http://tempuri.org/IGeneral/SellScietistsResponse")]
        void SellScietists(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/SellScietists", ReplyAction="http://tempuri.org/IGeneral/SellScietistsResponse")]
        System.Threading.Tasks.Task SellScietistsAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Seeding", ReplyAction="http://tempuri.org/IGeneral/SeedingResponse")]
        void Seeding(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/Seeding", ReplyAction="http://tempuri.org/IGeneral/SeedingResponse")]
        System.Threading.Tasks.Task SeedingAsync(string PlayerName, int Count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfPeasants", ReplyAction="http://tempuri.org/IGeneral/GetCountOfPeasantsResponse")]
        int GetCountOfPeasants(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfPeasants", ReplyAction="http://tempuri.org/IGeneral/GetCountOfPeasantsResponse")]
        System.Threading.Tasks.Task<int> GetCountOfPeasantsAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetCountOfSoldiersResponse")]
        int GetCountOfSoldiers(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetCountOfSoldiersResponse")]
        System.Threading.Tasks.Task<int> GetCountOfSoldiersAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSpendOnSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetSpendOnSoldiersResponse")]
        int GetSpendOnSoldiers(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetSpendOnSoldiers", ReplyAction="http://tempuri.org/IGeneral/GetSpendOnSoldiersResponse")]
        System.Threading.Tasks.Task<int> GetSpendOnSoldiersAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForScientificLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForScientificLevelResponse")]
        int GetYearsForScientificLevel(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForScientificLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForScientificLevelResponse")]
        System.Threading.Tasks.Task<int> GetYearsForScientificLevelAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForDensityLvl", ReplyAction="http://tempuri.org/IGeneral/GetYearsForDensityLvlResponse")]
        int GetYearsForDensityLvl(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForDensityLvl", ReplyAction="http://tempuri.org/IGeneral/GetYearsForDensityLvlResponse")]
        System.Threading.Tasks.Task<int> GetYearsForDensityLvlAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForSeedIcrementLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForSeedIcrementLevelResponse")]
        int GetYearsForSeedIcrementLevel(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForSeedIcrementLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForSeedIcrementLevelResponse")]
        System.Threading.Tasks.Task<int> GetYearsForSeedIcrementLevelAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForEconomyLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForEconomyLevelResponse")]
        int GetYearsForEconomyLevel(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForEconomyLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForEconomyLevelResponse")]
        System.Threading.Tasks.Task<int> GetYearsForEconomyLevelAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForWarArtLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForWarArtLevelResponse")]
        int GetYearsForWarArtLevel(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForWarArtLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForWarArtLevelResponse")]
        System.Threading.Tasks.Task<int> GetYearsForWarArtLevelAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForPeasantIncrementLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForPeasantIncrementLevelResponse")]
        int GetYearsForPeasantIncrementLevel(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetYearsForPeasantIncrementLevel", ReplyAction="http://tempuri.org/IGeneral/GetYearsForPeasantIncrementLevelResponse")]
        System.Threading.Tasks.Task<int> GetYearsForPeasantIncrementLevelAsync(GeneralClasses.ScientificLevels a, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireGeneral", ReplyAction="http://tempuri.org/IGeneral/HireGeneralResponse")]
        void HireGeneral(string PlayerName, int Price, string Name, int Age, int Skill, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/HireGeneral", ReplyAction="http://tempuri.org/IGeneral/HireGeneralResponse")]
        System.Threading.Tasks.Task HireGeneralAsync(string PlayerName, int Price, string Name, int Age, int Skill, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/FireGeneral", ReplyAction="http://tempuri.org/IGeneral/FireGeneralResponse")]
        void FireGeneral(string PlayerName, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/FireGeneral", ReplyAction="http://tempuri.org/IGeneral/FireGeneralResponse")]
        System.Threading.Tasks.Task FireGeneralAsync(string PlayerName, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfGenerals", ReplyAction="http://tempuri.org/IGeneral/GetCountOfGeneralsResponse")]
        int GetCountOfGenerals(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetCountOfGenerals", ReplyAction="http://tempuri.org/IGeneral/GetCountOfGeneralsResponse")]
        System.Threading.Tasks.Task<int> GetCountOfGeneralsAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/IsPlayerAlreasyExist", ReplyAction="http://tempuri.org/IGeneral/IsPlayerAlreasyExistResponse")]
        bool IsPlayerAlreasyExist(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/IsPlayerAlreasyExist", ReplyAction="http://tempuri.org/IGeneral/IsPlayerAlreasyExistResponse")]
        System.Threading.Tasks.Task<bool> IsPlayerAlreasyExistAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/DeleteSelectedPlayer", ReplyAction="http://tempuri.org/IGeneral/DeleteSelectedPlayerResponse")]
        void DeleteSelectedPlayer(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/DeleteSelectedPlayer", ReplyAction="http://tempuri.org/IGeneral/DeleteSelectedPlayerResponse")]
        System.Threading.Tasks.Task DeleteSelectedPlayerAsync(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientificLevel", ReplyAction="http://tempuri.org/IGeneral/GetScientificLevelResponse")]
        int GetScientificLevel(string PlayerName, GeneralClasses.ScientificLevelType LevelType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientificLevel", ReplyAction="http://tempuri.org/IGeneral/GetScientificLevelResponse")]
        System.Threading.Tasks.Task<int> GetScientificLevelAsync(string PlayerName, GeneralClasses.ScientificLevelType LevelType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientificLevels", ReplyAction="http://tempuri.org/IGeneral/GetScientificLevelsResponse")]
        GeneralClasses.ScientificLevel[] GetScientificLevels(string PlayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneral/GetScientificLevels", ReplyAction="http://tempuri.org/IGeneral/GetScientificLevelsResponse")]
        System.Threading.Tasks.Task<GeneralClasses.ScientificLevel[]> GetScientificLevelsAsync(string PlayerName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGeneralChannel : GeneralsClient.ServiceReference1.IGeneral, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeneralClient : System.ServiceModel.ClientBase<GeneralsClient.ServiceReference1.IGeneral>, GeneralsClient.ServiceReference1.IGeneral {
        
        public GeneralClient() {
        }
        
        public GeneralClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeneralClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneralClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneralClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetTerritorySize(string PlayerName) {
            return base.Channel.GetTerritorySize(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetTerritorySizeAsync(string PlayerName) {
            return base.Channel.GetTerritorySizeAsync(PlayerName);
        }
        
        public int GetMaxPeopleCount(string PlayerName) {
            return base.Channel.GetMaxPeopleCount(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetMaxPeopleCountAsync(string PlayerName) {
            return base.Channel.GetMaxPeopleCountAsync(PlayerName);
        }
        
        public int GetSeedCount(string PlayerName) {
            return base.Channel.GetSeedCount(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetSeedCountAsync(string PlayerName) {
            return base.Channel.GetSeedCountAsync(PlayerName);
        }
        
        public int GetSeedIncrement(string PlayerName) {
            return base.Channel.GetSeedIncrement(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetSeedIncrementAsync(string PlayerName) {
            return base.Channel.GetSeedIncrementAsync(PlayerName);
        }
        
        public int GetPeopleIncrement(string PlayerName) {
            return base.Channel.GetPeopleIncrement(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetPeopleIncrementAsync(string PlayerName) {
            return base.Channel.GetPeopleIncrementAsync(PlayerName);
        }
        
        public int GetScientists(string Playername) {
            return base.Channel.GetScientists(Playername);
        }
        
        public System.Threading.Tasks.Task<int> GetScientistsAsync(string Playername) {
            return base.Channel.GetScientistsAsync(Playername);
        }
        
        public int SpendOnScientists(string Playername) {
            return base.Channel.SpendOnScientists(Playername);
        }
        
        public System.Threading.Tasks.Task<int> SpendOnScientistsAsync(string Playername) {
            return base.Channel.SpendOnScientistsAsync(Playername);
        }
        
        public int GetMoney(string PlayerName) {
            return base.Channel.GetMoney(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetMoneyAsync(string PlayerName) {
            return base.Channel.GetMoneyAsync(PlayerName);
        }
        
        public bool isServerFull() {
            return base.Channel.isServerFull();
        }
        
        public System.Threading.Tasks.Task<bool> isServerFullAsync() {
            return base.Channel.isServerFullAsync();
        }
        
        public void ReName(string Oldname, string NewName) {
            base.Channel.ReName(Oldname, NewName);
        }
        
        public System.Threading.Tasks.Task ReNameAsync(string Oldname, string NewName) {
            return base.Channel.ReNameAsync(Oldname, NewName);
        }
        
        public void FinishRound(string name) {
            base.Channel.FinishRound(name);
        }
        
        public System.Threading.Tasks.Task FinishRoundAsync(string name) {
            return base.Channel.FinishRoundAsync(name);
        }
        
        public bool IsFinish() {
            return base.Channel.IsFinish();
        }
        
        public System.Threading.Tasks.Task<bool> IsFinishAsync() {
            return base.Channel.IsFinishAsync();
        }
        
        public int GetCount() {
            return base.Channel.GetCount();
        }
        
        public System.Threading.Tasks.Task<int> GetCountAsync() {
            return base.Channel.GetCountAsync();
        }
        
        public void AddUser(string Name) {
            base.Channel.AddUser(Name);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string Name) {
            return base.Channel.AddUserAsync(Name);
        }
        
        public bool Registr(string login, string password) {
            return base.Channel.Registr(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrAsync(string login, string password) {
            return base.Channel.RegistrAsync(login, password);
        }
        
        public bool Autorise(string Login, string Password) {
            return base.Channel.Autorise(Login, Password);
        }
        
        public System.Threading.Tasks.Task<bool> AutoriseAsync(string Login, string Password) {
            return base.Channel.AutoriseAsync(Login, Password);
        }
        
        public void HireScietists(string PlayerName, int Count) {
            base.Channel.HireScietists(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task HireScietistsAsync(string PlayerName, int Count) {
            return base.Channel.HireScietistsAsync(PlayerName, Count);
        }
        
        public void HireSoldiers(string PlayerName, int Count) {
            base.Channel.HireSoldiers(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task HireSoldiersAsync(string PlayerName, int Count) {
            return base.Channel.HireSoldiersAsync(PlayerName, Count);
        }
        
        public int GetMaxCountScietists(string PlayerName) {
            return base.Channel.GetMaxCountScietists(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetMaxCountScietistsAsync(string PlayerName) {
            return base.Channel.GetMaxCountScietistsAsync(PlayerName);
        }
        
        public int GetMaxCountSoldiers(string PlayerName) {
            return base.Channel.GetMaxCountSoldiers(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetMaxCountSoldiersAsync(string PlayerName) {
            return base.Channel.GetMaxCountSoldiersAsync(PlayerName);
        }
        
        public int GetMaxCountOfSeeds(string PlayerName) {
            return base.Channel.GetMaxCountOfSeeds(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetMaxCountOfSeedsAsync(string PlayerName) {
            return base.Channel.GetMaxCountOfSeedsAsync(PlayerName);
        }
        
        public void BuySeeds(string PlayerName, int Count) {
            base.Channel.BuySeeds(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task BuySeedsAsync(string PlayerName, int Count) {
            return base.Channel.BuySeedsAsync(PlayerName, Count);
        }
        
        public void SellSeeds(string PlayerName, int Count) {
            base.Channel.SellSeeds(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task SellSeedsAsync(string PlayerName, int Count) {
            return base.Channel.SellSeedsAsync(PlayerName, Count);
        }
        
        public void SellSoldiers(string PlayerName, int Count) {
            base.Channel.SellSoldiers(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task SellSoldiersAsync(string PlayerName, int Count) {
            return base.Channel.SellSoldiersAsync(PlayerName, Count);
        }
        
        public void SellScietists(string PlayerName, int Count) {
            base.Channel.SellScietists(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task SellScietistsAsync(string PlayerName, int Count) {
            return base.Channel.SellScietistsAsync(PlayerName, Count);
        }
        
        public void Seeding(string PlayerName, int Count) {
            base.Channel.Seeding(PlayerName, Count);
        }
        
        public System.Threading.Tasks.Task SeedingAsync(string PlayerName, int Count) {
            return base.Channel.SeedingAsync(PlayerName, Count);
        }
        
        public int GetCountOfPeasants(string PlayerName) {
            return base.Channel.GetCountOfPeasants(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetCountOfPeasantsAsync(string PlayerName) {
            return base.Channel.GetCountOfPeasantsAsync(PlayerName);
        }
        
        public int GetCountOfSoldiers(string PlayerName) {
            return base.Channel.GetCountOfSoldiers(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetCountOfSoldiersAsync(string PlayerName) {
            return base.Channel.GetCountOfSoldiersAsync(PlayerName);
        }
        
        public int GetSpendOnSoldiers(string PlayerName) {
            return base.Channel.GetSpendOnSoldiers(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetSpendOnSoldiersAsync(string PlayerName) {
            return base.Channel.GetSpendOnSoldiersAsync(PlayerName);
        }
        
        public int GetYearsForScientificLevel(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForScientificLevel(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForScientificLevelAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForScientificLevelAsync(a, count);
        }
        
        public int GetYearsForDensityLvl(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForDensityLvl(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForDensityLvlAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForDensityLvlAsync(a, count);
        }
        
        public int GetYearsForSeedIcrementLevel(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForSeedIcrementLevel(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForSeedIcrementLevelAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForSeedIcrementLevelAsync(a, count);
        }
        
        public int GetYearsForEconomyLevel(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForEconomyLevel(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForEconomyLevelAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForEconomyLevelAsync(a, count);
        }
        
        public int GetYearsForWarArtLevel(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForWarArtLevel(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForWarArtLevelAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForWarArtLevelAsync(a, count);
        }
        
        public int GetYearsForPeasantIncrementLevel(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForPeasantIncrementLevel(a, count);
        }
        
        public System.Threading.Tasks.Task<int> GetYearsForPeasantIncrementLevelAsync(GeneralClasses.ScientificLevels a, int count) {
            return base.Channel.GetYearsForPeasantIncrementLevelAsync(a, count);
        }
        
        public void HireGeneral(string PlayerName, int Price, string Name, int Age, int Skill, int Speed) {
            base.Channel.HireGeneral(PlayerName, Price, Name, Age, Skill, Speed);
        }
        
        public System.Threading.Tasks.Task HireGeneralAsync(string PlayerName, int Price, string Name, int Age, int Skill, int Speed) {
            return base.Channel.HireGeneralAsync(PlayerName, Price, Name, Age, Skill, Speed);
        }
        
        public void FireGeneral(string PlayerName, string Name) {
            base.Channel.FireGeneral(PlayerName, Name);
        }
        
        public System.Threading.Tasks.Task FireGeneralAsync(string PlayerName, string Name) {
            return base.Channel.FireGeneralAsync(PlayerName, Name);
        }
        
        public int GetCountOfGenerals(string PlayerName) {
            return base.Channel.GetCountOfGenerals(PlayerName);
        }
        
        public System.Threading.Tasks.Task<int> GetCountOfGeneralsAsync(string PlayerName) {
            return base.Channel.GetCountOfGeneralsAsync(PlayerName);
        }
        
        public bool IsPlayerAlreasyExist(string PlayerName) {
            return base.Channel.IsPlayerAlreasyExist(PlayerName);
        }
        
        public System.Threading.Tasks.Task<bool> IsPlayerAlreasyExistAsync(string PlayerName) {
            return base.Channel.IsPlayerAlreasyExistAsync(PlayerName);
        }
        
        public void DeleteSelectedPlayer(string PlayerName) {
            base.Channel.DeleteSelectedPlayer(PlayerName);
        }
        
        public System.Threading.Tasks.Task DeleteSelectedPlayerAsync(string PlayerName) {
            return base.Channel.DeleteSelectedPlayerAsync(PlayerName);
        }
        
        public int GetScientificLevel(string PlayerName, GeneralClasses.ScientificLevelType LevelType) {
            return base.Channel.GetScientificLevel(PlayerName, LevelType);
        }
        
        public System.Threading.Tasks.Task<int> GetScientificLevelAsync(string PlayerName, GeneralClasses.ScientificLevelType LevelType) {
            return base.Channel.GetScientificLevelAsync(PlayerName, LevelType);
        }
        
        public GeneralClasses.ScientificLevel[] GetScientificLevels(string PlayerName) {
            return base.Channel.GetScientificLevels(PlayerName);
        }
        
        public System.Threading.Tasks.Task<GeneralClasses.ScientificLevel[]> GetScientificLevelsAsync(string PlayerName) {
            return base.Channel.GetScientificLevelsAsync(PlayerName);
        }
    }
}
