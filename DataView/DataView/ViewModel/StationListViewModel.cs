using DataView.Service;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataView.ViewModel
{
    public class StationListViewModel : BindableBase
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

        public List<CustomStationModel> myStationList { get; set; }

        public StationListViewModel()
        {
            myStationList = new List<CustomStationModel>();

            GetDataFromDB();
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

            myStationList.Add(station1);
            myStationList.Add(station2);
            myStationList.Add(station3);
        }

        }
    }
