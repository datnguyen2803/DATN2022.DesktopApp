using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataView.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion

        public bool IsLoaded = false;
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if(p == null)
                {
                    return;
                }
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                var loginVM = loginWindow.DataContext as LoginViewModel;
                if (loginVM == null) { return; }

                if(loginVM.IsLogin == true)
                {
                    p.Show();
                    loginWindow.Close();
                }
                else
                {
                    p.Close();
                }
            }
            );
        }
    }
}
