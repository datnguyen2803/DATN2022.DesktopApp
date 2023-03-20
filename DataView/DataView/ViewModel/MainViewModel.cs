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

        public static SIDEBAR_ITEM_CODE SelectedSideBarItem { get; set; }
        public INTERNAL_VIEW_CODE CurrentView { get; set; }

        private Window _window { get; set; }

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
                IsWindowLoaded = true;
                if (f == null)
                {
                    return;
                }

                _window = f as Window;

                CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_LOGIN;
                SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_NONE;

                loginViewModel = new LoginViewModel();
                homeViewModel = new HomeViewModel();
                stationViewModel = new StationViewModel();
                pumpViewModel = new PumpViewModel();

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
            CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_NONE;
            SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_NONE;

            _window.Close();
        }

        private void HandleInternalMessage(InternalMessage _internalMessage)
        {
            INTERNAL_MESSAGE_CODE myCode = _internalMessage.Code;
            switch (myCode)
            {
                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_SUCCESS:
                    CurrentViewModel = homeViewModel;
                    CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_HOME;
                    SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;


                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_LOGIN_FAIL:
                    // do nothing
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_HOME:
                    CurrentViewModel = homeViewModel;
                    CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_HOME;
                    SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU:
                    Debug.WriteLine("Changing to station menu...");
                    CurrentViewModel = stationViewModel;
                    CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_STATION_MENU;
                    SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_SEARCH;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_MENU:
                    Debug.WriteLine("Changing to pump menu...");
                    CurrentViewModel = pumpViewModel;
                    CurrentView = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_PUMP_MENU;
                    SelectedSideBarItem = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_ABOUT;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_QUIT:
                    Stop();
                    break;

                default:
                    break;
            }
        }


        public static SIDEBAR_ITEM_CODE getSelectedSidebarItem() { return SelectedSideBarItem; }
    }
}
