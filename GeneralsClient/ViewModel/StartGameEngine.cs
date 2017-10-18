using GeneralsClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsClient.ViewModel
{
    public class StartGameEngine
    {
        public StartGameEngine() {

        }
        //Начало игры
        RelayCommand _StartNewGame { get; set; }
        public RelayCommand StartNewGame
        {
            get
            {
                if (_StartNewGame == null)
                {
                    _StartNewGame = new RelayCommand(
                        x =>
                        {
                            Login l = new Login();
                            l.ShowDialog();
                        });
                }
                return _StartNewGame;
            }
        }
        //Выход
        RelayCommand _Exit { get; set; }
        public RelayCommand Exit
        {
            get
            {
                if (_Exit == null)
                    _Exit = new RelayCommand(
                        x=>
                        {
                            System.Windows.Application.Current.Shutdown();
                        });
                return _Exit;
            }
        }
    }
}
