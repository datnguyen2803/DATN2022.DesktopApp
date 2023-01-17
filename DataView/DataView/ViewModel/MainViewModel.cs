using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataView.ViewModel
{
    public class MainViewModel
    {
        public bool IsLoad = false;
        public MainViewModel()
        {
            if (!IsLoad)
            {
                IsLoad = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
