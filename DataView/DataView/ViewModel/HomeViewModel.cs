﻿using DataView.Common.Helper;
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
        private StationListViewModel stationListViewModel { get; set; }
        private StationViewModel stationViewModel { get; set; }
        private PumpViewModel pumpViewModel { get; set; }

        

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
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_STATION_LIST;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU:
                    Debug.WriteLine("Changing to station menu...");
                    CurrentContentViewModel = new StationViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_STATION_MENU;
                    SelectedSideBarCode = SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_STATION_MENU;
                    break;

                case INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_MENU:
                    Debug.WriteLine("Changing to pump menu...");
                    CurrentContentViewModel = new PumpViewModel();
                    CurrentContentCode = INTERNAL_VIEW_CODE.CODE_INTERNAL_VIEW_PUMP_MENU;
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
