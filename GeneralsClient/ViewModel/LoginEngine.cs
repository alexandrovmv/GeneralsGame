using GeneralsClient.Model;
using GeneralsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneralsClient.ViewModel
{
    public class LoginEngine
    {
        public string PlayerLogin { get; set; }
        string _Password { get; set; }
        public string Password
        {
            get
            {
                return _Password;
            }
            set {
                _Password = value.GetHashCode().ToString();
            } }
        //Команды для кнопок Войти и Зарегестрироватся
        // Необходимо вызывать функции службы
        RelayCommand _Authorize { get; set; }
        public RelayCommand Authorize {
            get {
                if (_Authorize == null)
                {
                    _Authorize = new RelayCommand(
                        x => { bool result = InterClass.gc.Autorise(PlayerLogin, Password);
                            if (result)
                                MessageBox.Show("Success");
                            else
                                MessageBox.Show("Error");
                        }
                        );
                }
                return _Authorize;
            }
        }
        RelayCommand _Registr { get; set; }
        public RelayCommand Registr
        {
            get
            {
                if (_Registr == null)
                {
                    _Registr = new RelayCommand(
                        x => {
                            InterClass.gc.Registr(PlayerLogin, Password);
                             }
                        );
                }
                return _Registr;
            }
        }
        public LoginEngine() { }
    }
}
