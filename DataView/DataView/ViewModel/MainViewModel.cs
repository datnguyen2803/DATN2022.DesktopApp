using DataView.Common.Helper;
using GalaSoft.MvvmLight.Messaging;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public bool IsWindowLoaded = false;
        private Window window { get; set; }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }
        private LoginViewModel loginViewModel { get; set; }
        private HomeViewModel homeViewModel { get; set; }

        public InternalMessage internalMessage { get; set; }

        public MainViewModel()
        {

            LoadedWindowCommand = new RelayCommand<Window>((f) => { return true; }, (f) =>
            {
                IsWindowLoaded = true;
                if (f == null)
                {
                    return;
                }

                window = f as Window;

                loginViewModel = new LoginViewModel();
                homeViewModel = new HomeViewModel();

                Start();

            }
            );

        }

        private void Start()
        {
            CurrentViewModel = loginViewModel;
            Messenger.Default.Register<InternalMessage>(this, HandleInternalMessage);
        }

        private void Stop()
        {
            window.Close();
        }

        private void HandleInternalMessage(InternalMessage _internalMessage)
        {
            if(_internalMessage == null)
            {
                return;
            }
            internalMessage = _internalMessage;
            switch (internalMessage.Code)
            {
                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_SUCCESS:
                    CurrentViewModel = homeViewModel;
                    break;


                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_FAIL:
                    // do nothing
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_QUIT:
                    Stop();
                    break;

                default:
                    break;
            }
        }
    }
}
