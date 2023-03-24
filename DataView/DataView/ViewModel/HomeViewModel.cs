using DataView.Common.Helper;
using DataView.DataModel;
using GalaSoft.MvvmLight.Messaging;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static DataView.Common.Helper.ConstantHelper;
using static DataView.ViewModel.StationListViewModel;

namespace DataView.ViewModel
{
    class HomeViewModel : BindableBase
    {
        #region commands
        #endregion



        public static SIDEBAR_ITEM_CODE SelectedSideBarCode { get; set; }
        public INTERNAL_VIEW_CODE CurrentContentCode { get; set; }
        public InternalMessage internalMessage { get; set; }

        private BindableBase _currentContentViewModel;
        public BindableBase CurrentContentViewModel
        {
            get { return _currentContentViewModel; }
            set { SetProperty(ref _currentContentViewModel, value); }
        }



        public HomeViewModel()
        {
            CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_STATION_LIST;
            //SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
            internalMessage = new InternalMessage();

            //stationListViewModel = new StationListViewModel();
            //stationViewModel = new StationViewModel();
            //pumpViewModel = new PumpViewModel();

            CurrentContentViewModel = new StationListViewModel();

            Start();

        }

        private void Start()
        {
            Messenger.Default.Register<InternalMessage>(this, HandleInternalMessage);
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
                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_LIST:
                    Debug.WriteLine("Changing to station list...");
                    CurrentContentViewModel = new StationListViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_STATION_LIST;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU:
                    CustomStationModel recStation = (CustomStationModel)internalMessage.Data;
                    Debug.WriteLine("Changing to station menu...");
                    CurrentContentViewModel = new StationViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_STATION_MENU;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_MENU:
                    Debug.WriteLine("Changing to pump menu...");
                    CurrentContentViewModel = new PumpViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_PUMP_MENU;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_UPDATE:
                    Debug.WriteLine("Changing to pump update...");
                    //CurrentContentViewModel = new PumpViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_PUMP_UPDATE;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_CONFIG:
                    Debug.WriteLine("Changing to Info...");
                    //CurrentContentViewModel = new PumpViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_CONFIG;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_CONFIG;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_ABOUT:
                    Debug.WriteLine("Changing to About...");
                    //CurrentContentViewModel = new PumpViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_ABOUT;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_ABOUT;
                    break;

                default:
                    break;
            }
        }

        private void SendToMain(INTERNAL_MESSAGE_CODE _code, String _message = "")
        {
            InternalMessage newMess = new InternalMessage(_code, _message);
            Messenger.Default.Send(newMess);
        }
    }
}
