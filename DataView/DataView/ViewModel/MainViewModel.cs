using DataView.Common.Helper;
using GalaSoft.MvvmLight.Messaging;
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
using System.Windows.Interop;
using static DataView.Common.Helper.ConstantHelper;

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

        private LoginViewModel loginViewModel { get; set; }
        private HomeViewModel homeViewModel { get; set; }
        private StationViewModel stationViewModel { get; set; }
        private PumpViewModel pumpViewModel { get; set; }

        public InternalMessage internalMessage { get; set; }

        public MainViewModel()
        {

            LoadedWindowCommand = new RelayCommand<Window>((f) => { return true; }, (f) =>
            {
                IsLoaded = true;
                if (f == null)
                {
                    return;
                }

                loginViewModel = new LoginViewModel();
                homeViewModel = new HomeViewModel();
                stationViewModel = new StationViewModel();
                pumpViewModel = new PumpViewModel();

                Start();

            }
            );

            CloseWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Close();
            });
        }

        public void HandleInternalMessage(InternalMessage _internalMessage)
        {
            INTERNAL_MESSAGE_CODE myCode = _internalMessage.Code;
            switch (myCode)
            {
                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_LOGIN_SUCCESS:
                    CurrentViewModel = homeViewModel;
                    break;
                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_LOGIN_FAIL:
                    // do nothing
                    break;

                default:
                    break;
            }
        }

        private void Start()
        {


            CurrentViewModel = loginViewModel;
            Messenger.Default.Register<InternalMessage>(this, HandleInternalMessage);
        }

    }
}
