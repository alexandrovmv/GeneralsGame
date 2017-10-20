using GeneralClasses;
using GeneralsClient.Model;
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
        static int _MaxSeedForSeeding { get; set; } = 150;
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
                            InterClass.gc.BuySeeds(InterClass.PlayerName, CurrentSeedForBuy);
                            MaxSeedForSale += CurrentSeedForBuy;
                            Money = InterClass.gc.GetMoney(InterClass.PlayerName);
                            Seeds = InterClass.gc.GetSeedCount(InterClass.PlayerName);
                            MaxBuySeed = InterClass.gc.GetMaxCountOfSeeds(InterClass.PlayerName);
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
                            MaxSeedForSale -= CurrentSeedForSale;
                            Money = InterClass.gc.GetMoney(InterClass.PlayerName);
                            Seeds = InterClass.gc.GetSeedCount(InterClass.PlayerName);
                            MaxScientists = Money / StaticConstats.PriceOfScientists; 
                        }
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
                        InterClass.gc.HireScietists(InterClass.PlayerName, CurrentCountOfScientists);
                        Scientists = InterClass.gc.GetScientists(InterClass.PlayerName);
                        SpendOnScientists = InterClass.gc.SpendOnScientists(InterClass.PlayerName);
                        Money = InterClass.gc.GetMoney(InterClass.PlayerName);
                        Balance = Money - SpendOnScientists - SpendOnSoldiers;
                        MaxFireScientists = Scientists;
                        Peasants -= CurrentCountOfScientists;
                    });
                return _HireScientists;
            }
        }
        #endregion
        #endregion
        #region Увольнение ученых
        #region Свойства
        static int _MaxFireScientists { get; set; } = 150;
        public int MaxFireScientists
        {
            get
            {
                return _MaxFireScientists;
            }
            set
            {
                _MaxFireScientists = value;
                OnPropertyChanged();
            }
        }
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
                        MaxFireScientists -= CurrentScientistsForSale;
                        Peasants += CurrentScientistsForSale;
                    }, x => { return MaxFireScientists > 0; });
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
        static int _MaxSoldiers { get; set; } = 150;
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
        #endregion
        #endregion

  
        public Engine()
        {
        
          if(!InterClass.gc.IsPlayerAlreasyExist(InterClass.PlayerName))
            {
            InterClass.gc.AddUser(InterClass.PlayerName);
            Money = InterClass.gc.GetMoney(InterClass.PlayerName);
            MaxSeedForSale = Seeds = InterClass.gc.GetSeedCount(InterClass.PlayerName);
            MaxBuySeed = Money / StaticConstats.PriceOfSeedsBuy;
            MaxFireScientists = Scientists = InterClass.gc.GetScientists(InterClass.PlayerName);
            Balance = Money;
            MaxSeedForSeeding = Seeds / 2;
            MaxScientists = Money / StaticConstats.PriceOfScientists;
            Peasants = InterClass.gc.GetCountOfPeasants(InterClass.PlayerName);
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
