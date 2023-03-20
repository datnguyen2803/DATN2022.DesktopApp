using DataView.Common.Helper;
using DataView.DataModel;
using DataView.Service;
using GalaSoft.MvvmLight.Messaging;
using Prism.Mvvm;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.ViewModel
{
    class LoginViewModel : BindableBase
    {
        #region commands
        public ICommand LoginCommand { get; set; }
        public ICommand ExitCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        #endregion

        private string _username;
        private string _password;
        public string Username { get => _username; set { _username = value; RaisePropertyChanged(); } }
        public string Password { get => _password; set { _password = value; RaisePropertyChanged(); } }
        public bool IsLogin { get; set; }
        public LoginViewModel()
        {
            IsLogin = false;
            _username = string.Empty;
            _password = string.Empty;

            LoginCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { Login(); });
            ExitCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { Exit(); });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        private void Login()
        {
            UserModel myUser = new UserModel()
            {
                Name = Username,
                Password = Password
            };

            try
            {
                IsLogin = IUserService.Login(myUser);
                if (IsLogin == true)
                {
                    MessageBox.Show("Thành công!");

                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_SUCCESS);
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!");
                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_FAIL);
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void Exit()
        {
            SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_QUIT);
        }

        private void SendToMain(INTERNAL_MESSAGE_CODE _code, String _message = "")
        {
            InternalMessage newMess = new InternalMessage(_code, _message);
            Messenger.Default.Send(newMess);
        }
    }
}
