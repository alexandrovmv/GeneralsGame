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
    public partial class Engine:INotifyPropertyChanged
    {
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
        #region Засев зерна
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
        #endregion
        #region Продажа зерна
        #region Свойства
        static int _MaxSeedForSale { get; set; } = 150;
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

        #endregion

        #endregion
        #region Найм ученых
        #region Свойства
        static int _MaxScientists { get; set; } = 150;
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
        #endregion

        public Engine()
        {
            InterClass.gc.AddUser(InterClass.PlayerName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
