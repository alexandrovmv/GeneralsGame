using GeneralClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsClient.ViewModel
{
    public partial class Engine 
    {
        int _BusyScientist { get; set; }
        public int BusyScientist { get { return _BusyScientist; } set { _BusyScientist = value; OnPropertyChanged(); } }
        int _FreeScientists { get; set; }
        public int FreeScientists { get { return _FreeScientists; } set { _FreeScientists = value; OnPropertyChanged(); } }
        public ObservableCollection<ScientificLevel> LocalScientificLevels { get { return new ObservableCollection<ScientificLevel>( ServiceClient.GetScientificLevels(PlayerName)); } }

        #region Плотность населения
        int _ScientistsForDensityLevel { get; set; }
        public int ScientistsForDensityLevel { get { return _ScientistsForDensityLevel; } set { _ScientistsForDensityLevel = value; OnPropertyChanged(); } }
        //RelayCommand 
        #endregion

        public void RefreshScientificTab()
        {
            
            FreeScientists = Scientists - BusyScientist;
        }
    }
}
