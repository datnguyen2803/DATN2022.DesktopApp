using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataView.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoginCommand { get; set; }
        public ICommand ExitCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        #endregion

        private string _username;
        private string _password;
        public string Username { get => _username; set { _username = value; OnPropertyChanged(); } }
        public string Password { get => _password; set { _password = value; OnPropertyChanged(); } }
        public bool IsLogin { get; set; }
        public LoginViewModel()
        {
            IsLogin = false;
            _username = string.Empty;
            _password = string.Empty;

            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            ExitCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Exit(p); });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        private void Login(Window p)
        {
            if (p == null)
            {
                return;
            }
            else
            {
                // do nothing
            }
            if ((Username == "admin") && (Password == "admin"))
            {
                IsLogin = true;
            }
            else
            {
                IsLogin = false;
            }

            if (IsLogin == true)
            {
                p.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
        private void Exit(Window p)
        {
            if(p == null)
            {
                return;
            }
            else
            {
                p.Close();
            }
        }
    }
}
