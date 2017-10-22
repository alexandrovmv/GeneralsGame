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
        //Крестьяни
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
        int _CurrentSeedForBuy{get; set;}
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
        #region Покупка зерна
        #region Свойства
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
        #region Засев
        public int CurrentSeedForSeeding { get; set; }

        RelayCommand _Seeding { get; set; }
        public RelayCommand Seeding
        {
            get
            {
                if (_Seeding == null)
                    _Seeding = new RelayCommand(
                        x =>
                        {
                            InterClass.gc.Seeding(InterClass.PlayerName, CurrentSeedForSeeding);
                            MaxSeedForSale -= CurrentSeedForSeeding;
                            Seeds = InterClass.gc.GetSeedCount(InterClass.PlayerName);
                            MaxSeedForSeeding -= CurrentSeedForSeeding;
                        }
                        , x => { return MaxSeedForSeeding > 0; }
                        );
                return _Seeding;
            }
        }
        #endregion
        #endregion
        #region Найм ученых
        #region Свойства
        static int _MaxScientists { get; set; }
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
        public int CurrentScientistsForSale { get; set; }
        #endregion
        #region Команды
        RelayCommand _FireScientists { get; set; }
        public RelayCommand FireScientists
        {
            get
            {
                if (_FireScientists == null)
                    _FireScientists = new RelayCommand(x => {
                        InterClass.gc.SellScietists(InterClass.PlayerName, CurrentScientistsForSale);
                        Scientists = InterClass.gc.GetScientists(InterClass.PlayerName);
                        SpendOnScientists = InterClass.gc.SpendOnScientists(InterClass.PlayerName);
                        Balance = Money - SpendOnScientists - SpendOnSoldiers;
                       
                        Peasants += CurrentScientistsForSale;
                    }, x => { return Scientists > 0; });
                return _FireScientists;
            }
        }
        #endregion
        #endregion
        #region Покупка зерна
        #region Свойства
        static int _MaxBuySeed { get; set; } = 150;
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
        #endregion
        #endregion
        #region Найм солдат
        #region Свойства
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
                        InterClass.gc.HireSoldiers(InterClass.PlayerName, CurrentCountOfSoldiers);
                        Soldiers = InterClass.gc.GetCountOfSoldiers(InterClass.PlayerName);
                        SpendOnSoldiers = InterClass.gc.GetSpendOnSoldiers(InterClass.PlayerName);
                        Money = InterClass.gc.GetMoney(InterClass.PlayerName);
                        Balance = Money - SpendOnScientists - SpendOnSoldiers;
                        MaxSoldiers -= CurrentCountOfSoldiers;
                        MaxFireSoldiers = Soldiers;
                        Peasants -= CurrentCountOfSoldiers;
                    });
                return _HireSoldiers;
            }
        }
        #endregion
        #endregion
        #region Увольнение солдат
        #region Свойства
        static int _MaxFireSoldiers { get; set; } = 150;
        public int MaxFireSoldiers
        {
            get
            {
                return _MaxFireSoldiers;
            }
            set
            {
                _MaxFireSoldiers = value;
                OnPropertyChanged();
            }
        }
        public int CurrentSoldiersForSale { get; set; }
        #region Команды
        RelayCommand _FireSoldiers { get; set; }
        public RelayCommand FireSoldiers
        {
            get
            {
                if (_FireSoldiers == null)
                    _FireSoldiers = new RelayCommand(x => {
                        InterClass.gc.SellSoldiers(InterClass.PlayerName, CurrentSoldiersForSale);
                        Soldiers = InterClass.gc.GetCountOfSoldiers(InterClass.PlayerName);
                        SpendOnSoldiers = InterClass.gc.GetSpendOnSoldiers(InterClass.PlayerName);
                        Balance = Money - SpendOnScientists - SpendOnSoldiers;
                        MaxFireSoldiers -= CurrentSoldiersForSale;
                        Peasants += CurrentSoldiersForSale;
                        MaxSoldiers = Money / StaticConstats.PriceOfSoldiers;
                        MaxScientists = Money / StaticConstats.PriceOfScientists;
                    }, x => { return MaxFireSoldiers > 0; });
                return _FireSoldiers;
            }
        }
        #endregion
        #endregion
        #endregion
        /// <summary>
        /// Метод для пересчета всех покахателйей на вкладке Экономика.
        /// При добавлении нового показателя необходимо добавить его пересчет в даный метод.
        /// </summary>
        void RefreshTabEconomic()
        {
            Money = ServiceClient.GetMoney(PlayerName);
            MaxBuySeed = Money / StaticConstats.PriceOfSeedsBuy;
            MaxSoldiers = Money / StaticConstats.PriceOfSoldiers;
            MaxScientists = Money / StaticConstats.PriceOfScientists;

            Peasants = ServiceClient.GetCountOfPeasants(PlayerName);
            Scientists = Scientists = ServiceClient.GetScientists(PlayerName);
            MaxFireSoldiers = Soldiers = ServiceClient.GetCountOfSoldiers(PlayerName);
            MaxSeedForSale = Seeds = ServiceClient.GetSeedCount(PlayerName);

            SpendOnScientists = ServiceClient.GetScientists(PlayerName) * StaticConstats.SpendOnScientist;
            SpendOnSoldiers = ServiceClient.GetCountOfSoldiers(PlayerName) * StaticConstats.SpendOnSoldier;
            Balance = Money - SpendOnScientists - SpendOnSoldiers;
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
