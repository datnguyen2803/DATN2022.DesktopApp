using Prism.Mvvm;
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
    public class MainViewModel : BindableBase
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        #endregion

        public bool IsLoaded = false;

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }

        private LoginViewModel loginViewModel = new LoginViewModel();

        private HomeViewModel homeViewModel = new HomeViewModel();

        private StationListViewModel stationListModel = new StationListViewModel();

        public MainViewModel()
        {

            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if (p == null)
                {
                    return;
                }

                CurrentViewModel = loginViewModel;
                CurrentViewModel = homeViewModel;


            }
            );

            CloseWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Close();
            });
        }

    }
}
