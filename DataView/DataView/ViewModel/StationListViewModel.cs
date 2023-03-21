using DataView.DataModel;
using DataView.Service;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace DataView.ViewModel
{
    public class StationListViewModel : BindableBase
    {
        public class CustomStationModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int numberOfPumpsOn { get; set; }
            public int numberOfPumpsOff { get; set; }

            public CustomStationModel()
            {
                Id = 0;
                Name = string.Empty;
                Address = string.Empty;
                numberOfPumpsOn = 0;
                numberOfPumpsOff = 0;
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

            for(int i = 0; i < tempStationList.Count; i++)
            {
                StationModel tempStation = tempStationList[i];

                int numberOfPumpsOn = IPumpService.GetNumberOfPumpsOn(tempStation.Name);
                int numberOfPumpsOff = IPumpService.GetNumberOfPumpsOff(tempStation.Name);

                CustomStationModel tempCustomStation = new CustomStationModel()
                {
                    Id = i+1,
                    Name = tempStation.Name,
                    Address = tempStation.Address,
                    numberOfPumpsOn = numberOfPumpsOn,
                    numberOfPumpsOff = numberOfPumpsOff
                };
                myStationList.Add(tempCustomStation);

            }

        }

        }
    }
