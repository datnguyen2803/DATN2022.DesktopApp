using DataView.DataModel;
using DataView.Service;
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using Prism.Mvvm;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

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



    public class CustomPumpModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public CustomPumpModel()
        {
            Id = 0;
            Name = string.Empty;
            State = string.Empty;
        }
    }


    public class StationViewModel : BindableBase
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion

        public List<CustomStationModel> MyStationList { get; set; }
        public List<CustomPumpModel> MyPumpList { get; set; }

        public List<StationModel> myStationList { get; set; }

        public SeriesCollection pumpStateCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public StationViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //p.Show();
            });


            MyStationList = new List<CustomStationModel>();
            MyPumpList = new List<CustomPumpModel>();
            GetDataFromDB();
            Debug.WriteLine("[datchaos]: " + MyStationList.Count);

            pumpStateCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Số máy bật",
                    Values = new ChartValues<double> { 1, 4, 4, 4 }
                }
            };

            //adding series will update and animate the chart automatically
            pumpStateCollection.Add(new ColumnSeries
            {
                Title = "Số máy tắt",
                Values = new ChartValues<double> { 5, 2, 2, 2 }
            });

            //also adding values updates and animates the chart automatically
            //pumpStateCollection[1].Values.Add(48d);

            Labels = new[] { "13h", "14h", "15h", "16h" };
            Formatter = value => value.ToString("N");
        }

        private void GetDataFromDB()
        {
            //CustomStationModel station1 = new CustomStationModel()
            //{
            //    Id = 1,
            //    Name = "A",
            //    Address = "Hà Đông",
            //    numberOfPumpOn = 5,
            //    numberOfPumpOff = 3
            //};
            //CustomStationModel station2 = new CustomStationModel()
            //{
            //    Id = 2,
            //    Name = "B",
            //    Address = "Hai Bà Trưng",
            //    numberOfPumpOn = 1,
            //    numberOfPumpOff = 4
            //};
            //CustomStationModel station3 = new CustomStationModel()
            //{
            //    Id = 3,
            //    Name = "C",
            //    Address = "Từ Liêm",
            //    numberOfPumpOn = 2,
            //    numberOfPumpOff = 3
            //};

            //MyStationList.Add(station1);
            //MyStationList.Add(station2);
            //MyStationList.Add(station3);


            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });
            //MyStationList.Add(new CustomStationModel() { Id = 1, Name = "A", Address = "A", numberOfPumpOn = 1, numberOfPumpOff = 2 });



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Null cmnr");
            //    return;
            //}



            //MyPumpList.Add(new CustomPumpModel() { Id = 1, Name = "01", State = "Bật" });
            //MyPumpList.Add(new CustomPumpModel() { Id = 2, Name = "02", State = "Bật" });
            //MyPumpList.Add(new CustomPumpModel() { Id = 3, Name = "03", State = "Tắt" });
            //MyPumpList.Add(new CustomPumpModel() { Id = 4, Name = "04", State = "Bật" });
            //MyPumpList.Add(new CustomPumpModel() { Id = 5, Name = "05", State = "Tắt" });
            //MyPumpList.Add(new CustomPumpModel() { Id = 6, Name = "06", State = "Tắt" });

            myStationList = IStationService.GetAll();
            if(myStationList == null)
            {
                MessageBox.Show("No data retrieved");
            }
        }
    }
}
