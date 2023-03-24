using DataView.Common.Helper;
using DataView.DataModel;
using DataView.Service;
using GalaSoft.MvvmLight.Messaging;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using static DataView.Common.Helper.ConstantHelper;
using static DataView.ViewModel.StationListViewModel;

namespace DataView.ViewModel
{
    public class StationListViewModel : BindableBase
    {

        #region commands
        public ICommand SelectStationCommand { get; set; }
        #endregion


        public class CustomStationModel
        {
            public int Order { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int numberOfPumpsOn { get; set; }
            public int numberOfPumpsOff { get; set; }

            public CustomStationModel()
            {
                Order = 0;
                Name = string.Empty;
                Address = string.Empty;
                numberOfPumpsOn = 0;
                numberOfPumpsOff = 0;
            }

        }
        public List<CustomStationModel> myStationList {  get; set; }


        public CustomStationModel selectedStation { get; set; }

        public StationListViewModel()
        {
            myStationList = new List<CustomStationModel>();
            selectedStation = new CustomStationModel();

            GetDataFromDB();

            SelectStationCommand = new RelayCommand<ListView>((p) => { return true; }, (p) => { SelectStationHandler(p); });

            //Task.Factory.StartNew(async () =>
            //{
            //    System.Threading.Thread.Sleep(10);
            //    await LoadDataAsync();
            //});
        }

        //private async Task LoadDataAsync()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            List<StationModel> tempStationList = IStationService.GetAll();

        //            if (tempStationList == null)
        //            {
        //                return;
        //            }

        //            myStationList.Clear();
        //            for (int i = 0; i < tempStationList.Count; i++)
        //            {
        //                StationModel tempStation = tempStationList[i];

        //                int numberOfPumpsOn = IPumpService.GetNumberOfPumpsOn(tempStation.Name);
        //                int numberOfPumpsOff = IPumpService.GetNumberOfPumpsOff(tempStation.Name);

        //                CustomStationModel tempCustomStation = new CustomStationModel()
        //                {
        //                    Order = i + 1,
        //                    Name = tempStation.Name,
        //                    Address = tempStation.Address,
        //                    numberOfPumpsOn = numberOfPumpsOn,
        //                    numberOfPumpsOff = numberOfPumpsOff
        //                };

        //                myStationList.Add(tempCustomStation);

        //            }
        //            RaisePropertyChanged("myStationList");
        //            System.Threading.Thread.Sleep(1000);
        //        }
        //        catch (Exception)
        //        {

        //        }

        //    }

        //}


        private void GetDataFromDB()
        {
            //CustomStationModel station1 = new CustomStationModel()
            //{
            //    Id = 1,
            //    Name = "A",
            //    Address = "Hà Đông",
            //    numberOfPumpsOn = 5,
            //    numberOfPumpsOff = 3
            //};
            //CustomStationModel station2 = new CustomStationModel()
            //{
            //    Id = 2,
            //    Name = "B",
            //    Address = "Hai Bà Trưng",
            //    numberOfPumpsOn = 1,
            //    numberOfPumpsOff = 4
            //};
            //CustomStationModel station3 = new CustomStationModel()
            //{
            //    Id = 3,
            //    Name = "C",
            //    Address = "Từ Liêm",
            //    numberOfPumpsOn = 2,
            //    numberOfPumpsOff = 3
            //};

            //myStationList.Add(station1);
            //myStationList.Add(station2);
            //myStationList.Add(station3);

            List<StationModel> tempStationList = IStationService.GetAll();

            if(tempStationList == null)
            {
                return;
            }

            myStationList.Clear();

            for(int i = 0; i < tempStationList.Count; i++)
            {
                StationModel tempStation = tempStationList[i];

                int numberOfPumpsOn = IPumpService.GetNumberOfPumpsOn(tempStation.Name);
                int numberOfPumpsOff = IPumpService.GetNumberOfPumpsOff(tempStation.Name);

                CustomStationModel tempCustomStation = new CustomStationModel()
                {
                    Order = i+1,
                    Name = tempStation.Name,
                    Address = tempStation.Address,
                    numberOfPumpsOn = numberOfPumpsOn,
                    numberOfPumpsOff = numberOfPumpsOff
                };
                myStationList.Add(tempCustomStation);

            }

        }

        private void SelectStationHandler(ListView uc)
        {
            selectedStation = (CustomStationModel) uc.SelectedItem;
            SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU, selectedStation);

        }

        private void SendToMain(INTERNAL_MESSAGE_CODE _code, object _message = null)
        {
            InternalMessage newMess = new InternalMessage(_code, _message);
            Messenger.Default.Send(newMess);
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raises the 'PropertyChanged' event when the value of a property of the view model has changed.
        /// </summary>
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        /// <summary>
        /// 'PropertyChanged' event that is raised when the value of a property of the view model has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
