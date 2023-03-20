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

namespace DataView.ViewModel
{
    class HomeViewModel : BindableBase
    {
        #region commands
        #endregion

        public bool IsHomeSelected { get; set; }
        public bool IsSearchSelected { get; set; }
        public bool IsAboutSelected { get; set; }

        public class CustomStationModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int numberOfPumpOn { get; set; }
            public int numberOfPumpOff { get; set; }

            public CustomStationModel()
            {
                Id = 0;
                Name = string.Empty;
                Address = string.Empty;
                numberOfPumpOn = 0;
                numberOfPumpOff = 0;
            }

        }

        public List<CustomStationModel> myStationList { get; set; }

        public HomeViewModel()
        {

            myStationList = new List<CustomStationModel>();

            InitSidebar();
            GetDataFromDB();
            

        }

        private void GetDataFromDB()
        {
            CustomStationModel station1 = new CustomStationModel()
            {
                Id = 1,
                Name = "A",
                Address = "Hà Đông",
                numberOfPumpOn = 1,
                numberOfPumpOff = 3
            };
            CustomStationModel station2 = new CustomStationModel()
            {
                Id = 2,
                Name = "B",
                Address = "Hai Bà Trưng",
                numberOfPumpOn = 1,
                numberOfPumpOff = 4
            };
            CustomStationModel station3 = new CustomStationModel()
            {
                Id = 3,
                Name = "C",
                Address = "Từ Liêm",
                numberOfPumpOn = 2,
                numberOfPumpOff = 3
            };

            myStationList.Add(station1);
            myStationList.Add(station2);
            myStationList.Add(station3);

        }

        private void SendToMain(INTERNAL_MESSAGE_CODE _code, String _message = "")
        {
            InternalMessage newMess = new InternalMessage(_code, _message);
            Messenger.Default.Send(newMess);
        }

        private void InitSidebar()
        {
            IsHomeSelected = MainViewModel.getSelectedSidebarItem() == SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_HOME ? true : false;
            IsSearchSelected = MainViewModel.getSelectedSidebarItem() == SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_SEARCH ? true : false;
            IsAboutSelected = MainViewModel.getSelectedSidebarItem() == SIDEBAR_ITEM_CODE.SIDEBAR_ITEM_ABOUT ? true : false;
            Debug.WriteLine($"IsHomeSelected = {0} IsSearchSelected = {1} IsAboutSelected = {2}", IsHomeSelected, IsSearchSelected, IsAboutSelected);
        }
    }
}
