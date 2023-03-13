using DataView.DataModel;
using DataView.Service;
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
                    MessageBox.Show("Đang đăng nhập...");
                    p.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private async void GetLogin(UserModel _user)
        {
            var handler = new WinHttpHandler();
            HttpClient client = new HttpClient(handler);
            //client.BaseAddress = new Uri("https://localhost:44393/");
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            //HttpResponseMessage response = client.GetAsync("api/user").Result;
            //Trace.WriteLine(response);

            var JsonData = JsonSerializer.Serialize(_user);
            Trace.WriteLine("datchaos check" + JsonData);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44393/api/user/login"),
                Content = new StringContent(JsonData)
            };
            

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string myres = response.Content.ReadAsStringAsync().Result;
                IsLogin = true;
            }
            else
            {
                MessageBox.Show("Error Code: " + response.StatusCode);
                IsLogin = false;
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
