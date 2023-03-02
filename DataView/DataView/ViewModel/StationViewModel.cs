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

namespace DataView.ViewModel
{
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


    public class StationViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion

        public List<CustomStationModel> MyStationList { get; set; }

        public bool IsLoaded = false;
        public StationViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //p.Show();
            });


            MyStationList = new List<CustomStationModel>();
            GetDataFromDB();
            Debug.WriteLine("[datchaos]: " + MyStationList.Count);
        }

        private void GetDataFromDB()
        {
            CustomStationModel station1 = new CustomStationModel()
            {
                Id = 1,
                Name = "A",
                Address = "Hà Đông",
                numberOfPumpOn = 5,
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

            MyStationList.Add(station1);
            MyStationList.Add(station2);
            MyStationList.Add(station3);
        }
    }
}
