using GeneralClasses;
using GeneralsClient.Model;
using GeneralsClient.ServiceReference1;
using GeneralsClient.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneralsClient.ViewModel
{
    public partial class Engine : INotifyPropertyChanged
    {
 
        int _Territoty{ get; set; }
        /// <summary>
        ///  Возвращает размер территории страны
        /// </summary>
        public int Territoty
        {
            get
            {
                return _Territoty;
            }
            set
            {
                _Territoty = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        ///  Возвращает имя игрока. Инициализируется при авторизации.
        /// </summary>
        public string PlayerName { get { return InterClass.PlayerName; } }
        /// <summary>
        /// Возращает ссылку на объект объект прокси класса GeneralClient.
        /// </summary>
        public GeneralClient ServiceClient { get { return InterClass.gc; } }
        //Солдаты
        int _Soldiers { get; set; }
        public int Soldiers
        {
            get { return _Soldiers; }
            set
            {
                _Soldiers = value;
                OnPropertyChanged();
            }
        }
        //Крестьяне
        int _Peasants { get; set; }
        public int Peasants
        {
            get { return _Peasants; }
            set
            {
                _Peasants = value;
                OnPropertyChanged();
            }
        }
        //Баланс 
  
        int _Balance { get; set; }
        /// <summary>
        /// Возвращает разницу между текущими деньгами и расходами на содержание солдат и ученых
        /// </summary>
        public int Balance
        {
            get { return _Balance; }
            set
            {
                _Balance = value;
                OnPropertyChanged();
            }
        }
        int _CurrentCostSeeds { get; set; }
        public int CurrentCostSeeds
        {
            get { return _CurrentCostSeeds; }
            set
            {
                _CurrentCostSeeds = value;
                OnPropertyChanged();
            }
        }
        // Деньги
        int _Money { get; set; }

        public int Money {
            get { return _Money; }
            set {
                _Money = value;
                OnPropertyChanged();
            } }

        //Зерно 
        int _Seeds { get; set; }
        public int Seeds {
            get { return _Seeds; }
            set {
                _Seeds = value;
                OnPropertyChanged();
            } }
        int _CurrentCostOfSeedForSale { get; set; }
        public int CurrentCostOfSeedForSale
        {
            get { return _CurrentCostOfSeedForSale; }
            set
            {
                _CurrentCostOfSeedForSale = value;
                OnPropertyChanged();
            }
        }
 
        //Ученые
        int _Scientists { get; set; }
        public int Scientists
        {
            get { return _Scientists; }
            set
            {
                _Scientists = value;
                OnPropertyChanged();
            }
        }
        int _SpendOnScientists { get; set; }
        public int SpendOnScientists
        {
            get { return _SpendOnScientists; }
            set
            {
                _SpendOnScientists = value;
                OnPropertyChanged();
            }
        }
        //Солдаты
        int _SpendOnSoldiers { get; set; }
        public int SpendOnSoldiers
        {
            get { return _SpendOnSoldiers; }
            set
            {
                _SpendOnSoldiers = value;
                OnPropertyChanged();
            }
        }
        //Население
        public int _People { get; set; }
        /// <summary>
        /// Возвращает общее количество населения Крестьяне + Солдаты + Ученые
        /// </summary>
        public int People { get { return _People; } set { _People = value; OnPropertyChanged(); } }

        int _MaxPeople { get; set; }
        /// <summary>
        /// Возвращает максимальное количество населения.
        /// </summary>
        public int MaxPeople { get { return _MaxPeople; } set { _MaxPeople = value;OnPropertyChanged(); } }
        #region Найм генерала

        #region Свойства
        public string Name { get; set; }
        int _CurrentAge { get; set; } = 15;
        int _CurrentSkill { get; set; } = 1;
        public int CurrentAge
        {
            get { return _CurrentAge; }
            set {
                _CurrentAge = value;
                CalculatePriceOfGeneral();
            }
        }
        public int CurrentSkill
        {
            get { return _CurrentSkill; }
            set
            {
                _CurrentSkill = value;
                CalculatePriceOfGeneral();
            }
        }
        int _CurrentSpeed { get; set; } = 1;
        public int CurrentSpeed
        {
            get { return _CurrentSpeed; }
            set
            {
                _CurrentSpeed = value;             
                CalculatePriceOfGeneral();
            }
        }
        int _CurrentGeneralCoast { get; set; }
        public int CurrentGeneralCoast {
            get
            {
               return _CurrentGeneralCoast;
            }
            set
            {
                _CurrentGeneralCoast = value;
                OnPropertyChanged();
            }

        }
        public static int MaxAge { get; } = StaticConstats.MaxAge;
        public static int MaxSkill { get; } = StaticConstats.MaxSkill;
        public static int MaxSpeed { get; } = StaticConstats.MaxSpeed;
        #endregion
        #region Mетоды
        void CalculatePriceOfGeneral()
        {
            CurrentGeneralCoast = StaticConstats.BasePriceOfGeneral * (CurrentSkill+CurrentSpeed) / _CurrentAge;

        }
        #endregion
        #region  Команды
        RelayCommand _HireGeneral { get; set; }
        public RelayCommand HireGeneral {
            get {
                if (_HireGeneral == null)
                    _HireGeneral = new RelayCommand(x => { 
                        InterClass.gc.HireGeneral(InterClass.PlayerName, _CurrentGeneralCoast, Name,
                        CurrentAge, CurrentSkill, CurrentSpeed);
                        MessageBox.Show("Player "+ InterClass.PlayerName + " have " +InterClass.gc.GetCountOfGenerals(InterClass.PlayerName).ToString());
                    });
                return _HireGeneral;
            }  }
        #endregion

        #endregion
        #region Экономика
        int _SeedIncrement { get; set; }
        public int SeedIncrement { get { return _SeedIncrement; } set { _SeedIncrement = value;OnPropertyChanged(); } }
        int _PeopleIcrement { get; set; }
        public int PeopleIcrement { get { return _PeopleIcrement; } set { _PeopleIcrement = value; OnPropertyChanged(); } }
        #region Засев
        #region Свойства
        public int _CurrentSeedForSeeding { get; set; }
        public int CurrentSeedForSeeding { get { return _CurrentSeedForSeeding; } set { _CurrentSeedForSeeding = value; OnPropertyChanged(); } }
        static int _MaxSeedForSeeding { get; set; }
        public int MaxSeedForSeeding
        {
            get
            {
                return _MaxSeedForSeeding;
            }
            set
            {
                _MaxSeedForSeeding = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Команда
        RelayCommand _Seeding { get; set; }
        public RelayCommand Seeding
        {
            get
            {
                if (_Seeding == null)
                    _Seeding = new RelayCommand(
                        x =>
                        {
                            ServiceClient.Seeding(PlayerName, CurrentSeedForSeeding);
                            MaxSeedForSeeding -= CurrentSeedForSeeding;
                            RefreshTabEconomic();
                        }
                        , x => { return MaxSeedForSeeding > 0; }
                        );
                return _Seeding;
            }
        }
        #endregion
        #endregion
        #region Покупка зерна
        #region Свойства
        static int _MaxBuySeed { get; set; }
        public int MaxBuySeed
        {
            get
            {
                return _MaxBuySeed;
            }
            set
            {
                _MaxBuySeed = value;
                OnPropertyChanged();
            }
        }
        int _CurrentSeedForBuy { get; set; }
        public int CurrentSeedForBuy
        {
            get { return _CurrentSeedForBuy; }
            set
            {
                _CurrentSeedForBuy = value;
                OnPropertyChanged();
                CurrentCostSeeds = _CurrentSeedForBuy * StaticConstats.PriceOfSeedsBuy;
            }
        }
        #endregion
        #region Команды
        RelayCommand _BuySeed { get; set; }
        public RelayCommand BuySeed
        {
            get
            {
                if (_BuySeed == null)
                    _BuySeed = new RelayCommand(
                        x =>
                        {
                            ServiceClient.BuySeeds(PlayerName, CurrentSeedForBuy);
                            RefreshTabEconomic();                       
                        }
                        );
                return _BuySeed;
            }
        }
        #endregion
        #endregion
        #region Продажа зерна
        #region Свойства
        static int _MaxSeedForSale { get; set; }
        public int MaxSeedForSale {

            get
            {
                return _MaxSeedForSale;
            }
            set
            {
                _MaxSeedForSale = value;
                OnPropertyChanged();
            } }
        int _CurrentSeedForSale { get; set; }
        public int CurrentSeedForSale
        {
            get
            {
                return _CurrentSeedForSale;
            }
            set
            {
                _CurrentSeedForSale = value;
                OnPropertyChanged();
                CurrentCostOfSeedForSale = CurrentSeedForSale * StaticConstats.PriceOfSeedsSell;
            }
        }
        #endregion
        #region Команды
        RelayCommand _SaleSeed { get; set; }
        public RelayCommand SaleSeed {
            get
            {
                if (_SaleSeed == null)
                    _SaleSeed = new RelayCommand(
                        x =>
                        {
                            InterClass.gc.SellSeeds(InterClass.PlayerName, CurrentSeedForSale);
                            RefreshTabEconomic();                      
                        },
                        x => { return Seeds > 0; }
                        );
                return _SaleSeed;
            }
                }
        #endregion
        #endregion
    
        #region Найм ученых
        #region Свойства
        static int _MaxScientists { get; set; }
        /// <summary>
        /// Возвращает максимальное количество ученых для найма.
        /// </summary>
        public int MaxScientists
        {
            get
            {
                return _MaxScientists;
            }
            set
            {
                _MaxScientists = value;
                OnPropertyChanged();
            }
        }
        int _CurrentSpendOnScientists { get; set; }
        public int CurrentSpendOnScientists
        {
            get
            {
                return _CurrentSpendOnScientists;
            }
            set
            {
                _CurrentSpendOnScientists = value;
                OnPropertyChanged();
            }
        }
        int _CurrentCostOfScientists { get; set; }
        public int CurrentCostOfScientists
        {
            get
            {
                return _CurrentCostOfScientists;
            }
            set
            {
                _CurrentCostOfScientists = value;
                OnPropertyChanged();
            }
        }
        int _CurrentCountOfScientists { get; set; }
        public int CurrentCountOfScientists
        {
            get
            {
                return _CurrentCountOfScientists;
            }
            set
            {
                _CurrentCountOfScientists = value;
                OnPropertyChanged();
                CurrentCostOfScientists = CurrentCountOfScientists * StaticConstats.PriceOfScientists;
            }
        }
        #endregion
        #region Команды
        RelayCommand _HireScientists { get; set; }
        public RelayCommand HireScientists
        {
            get
            {
                if (_HireScientists == null)
                    _HireScientists = new RelayCommand(x => {
                        ServiceClient.HireScietists(PlayerName, CurrentCountOfScientists);
                        RefreshTabEconomic();          
                    },x=> {return Money >= CurrentCountOfScientists * StaticConstats.PriceOfScientists; });
                return _HireScientists;
            }
        }
        #endregion
        #endregion
        #region Увольнение ученых
        #region Свойства
        int _CurrentScientistsForSale { get; set; }
        public int CurrentScientistsForSale { get { return _CurrentScientistsForSale; } set { _CurrentScientistsForSale = value;OnPropertyChanged(); } }
        #endregion  
        #region Команды
        RelayCommand _FireScientists { get; set; }
        public RelayCommand FireScientists
        {
            get
            {
                if (_FireScientists == null)
                    _FireScientists = new RelayCommand(x => {
                        InterClass.gc.SellScietists(PlayerName, CurrentScientistsForSale);
                        RefreshTabEconomic();
                       
                    }, x => { return Scientists > 0; });
                return _FireScientists;
            }
        }
        #endregion
        #endregion
  
        #region Найм солдат
        #region Свойства
        /// <summary>
        /// Возвращает максимальное количество солдат для найма
        /// </summary>
        static int _MaxSoldiers { get; set; }
        public int MaxSoldiers
        {
            get
            {
                return _MaxSoldiers;
            }
            set
            {
                _MaxSoldiers = value;
                OnPropertyChanged();
            }
        }
        int _CurrentSpendOnSoldiers { get; set; }
        public int CurrentSpendOnSoldiers
        {
            get
            {
                return _CurrentSpendOnSoldiers;
            }
            set
            {
                _CurrentSpendOnSoldiers = value;
                OnPropertyChanged();
            }
        }
        int _CurrentCostOfSoldiers { get; set; }
        public int CurrentCostOfSoldiers
        {
            get
            {
                return _CurrentCostOfSoldiers;
            }
            set
            {
                _CurrentCostOfSoldiers = value;
                OnPropertyChanged();
            }
        }
        int _CurrentCountOfSoldiers { get; set; }
        public int CurrentCountOfSoldiers
        {
            get
            {
                return _CurrentCountOfSoldiers;
            }
            set
            {
                _CurrentCountOfSoldiers = value;
                OnPropertyChanged();
                CurrentCostOfSoldiers = CurrentCountOfSoldiers * StaticConstats.PriceOfSoldiers;
            }
        }
        #endregion
        #region Команды
        RelayCommand _HireSoldiers { get; set; }
        public RelayCommand HireSoldiers
        {
            get
            {
                if (_HireSoldiers == null)
                    _HireSoldiers = new RelayCommand(x => {
                        ServiceClient.HireSoldiers(PlayerName, CurrentCountOfSoldiers);
                        RefreshTabEconomic();
                    });
                return _HireSoldiers;
            }
        }
        #endregion
        #endregion
        #region Увольнение солдат
        #region Свойства

        public int _CurrentSoldiersForSale { get; set; }
        public int CurrentSoldiersForSale { get { return _CurrentSoldiersForSale; } set { _CurrentSoldiersForSale = value; OnPropertyChanged(); } }
        #region Команды
        RelayCommand _FireSoldiers { get; set; }
        public RelayCommand FireSoldiers
        {
            get
            {
                if (_FireSoldiers == null)
                    _FireSoldiers = new RelayCommand(x => {
                        ServiceClient.SellSoldiers(PlayerName, CurrentSoldiersForSale);
                        Soldiers = ServiceClient.GetCountOfSoldiers(PlayerName);
                        SpendOnSoldiers = ServiceClient.GetSpendOnSoldiers(PlayerName);
                        Balance = Money - SpendOnScientists - SpendOnSoldiers;
                        Soldiers -= CurrentSoldiersForSale;
                        Peasants += CurrentSoldiersForSale;
                        MaxSoldiers = Money / StaticConstats.PriceOfSoldiers;
                        MaxScientists = Money / StaticConstats.PriceOfScientists;
                    }, x => { return Soldiers > 0; });
                return _FireSoldiers;
            }
        }
        #endregion
        #endregion
        #endregion
        #endregion
        /// <summary>
        /// Метод для пересчета всех покахателйей на вкладке Экономика.
        /// При добавлении нового показателя необходимо добавить его пересчет в даный метод.
        /// </summary>
        void RefreshTabEconomic()
        {
            Territoty = ServiceClient.GetTerritorySize(PlayerName);
            Money = ServiceClient.GetMoney(PlayerName);
            MaxBuySeed = Money / StaticConstats.PriceOfSeedsBuy;
            MaxSoldiers = Money / StaticConstats.PriceOfSoldiers;
            MaxScientists = Money / StaticConstats.PriceOfScientists;

            Peasants = ServiceClient.GetCountOfPeasants(PlayerName);
            Scientists = Scientists = ServiceClient.GetScientists(PlayerName);
            Soldiers = Soldiers = ServiceClient.GetCountOfSoldiers(PlayerName);
            MaxSeedForSale = Seeds = ServiceClient.GetSeedCount(PlayerName);

            SpendOnScientists = ServiceClient.GetScientists(PlayerName) * StaticConstats.SpendOnScientist;
            SpendOnSoldiers = ServiceClient.GetCountOfSoldiers(PlayerName) * StaticConstats.SpendOnSoldier;
            Balance = Money - SpendOnScientists - SpendOnSoldiers;
            People = Soldiers + Scientists + Peasants;

            MaxPeople = ServiceClient.GetMaxPeopleCount(PlayerName);
            SeedIncrement = ServiceClient.GetSeedIncrement(PlayerName);
            PeopleIcrement = ServiceClient.GetPeopleIncrement(PlayerName);           
            CurrentSeedForSeeding = 0;
            CurrentSeedForSale = 0;
            CurrentSeedForBuy = 0;
            CurrentCountOfScientists = 0;
            CurrentCountOfSoldiers = 0;
            CurrentScientistsForSale = 0;
            CurrentSoldiersForSale = 0;
            CurrentSeedForSeeding = 0;

            RefreshScientificTab();
        }

        public Engine()
        {
        
          if(!ServiceClient.IsPlayerAlreasyExist(PlayerName))
            {
                ServiceClient.AddUser(PlayerName);
                RefreshTabEconomic();
                MaxSeedForSeeding = Seeds / 2;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
