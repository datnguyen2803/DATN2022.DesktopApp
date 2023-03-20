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
using System.Windows.Media;
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
using static DataView.Common.Helper.ConstantHelper;

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
        public int Order { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public SolidColorBrush PColor { get; set; }

        public CustomPumpModel()
        {
            Order = 0;
            Name = string.Empty;
            State = string.Empty;
            PColor = new SolidColorBrush();
        }

        public CustomPumpModel(int order, string name, string state)
        {
            BrushConverter converter = new System.Windows.Media.BrushConverter();
            SolidColorBrush greenBrush = (SolidColorBrush)converter.ConvertFromString("#afe1af");
            SolidColorBrush redBrush = (SolidColorBrush)converter.ConvertFromString("#fcd1d6");

            Order = order;
            Name = name;
            State = state;
            PColor = (state == "Bật") ? greenBrush : redBrush;
        }
    }


    public class StationViewModel : BindableBase
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion


        public List<CustomPumpModel> MyPumpList { get; set; }

        public SeriesCollection pumpStateCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public StationViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //p.Show();
            });

            MyPumpList = new List<CustomPumpModel>();
            GetDataFromDB();

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

            List<PumpModel> tempList = IPumpService.GetByStationName("A");

            for(int i = 0; i < tempList.Count; i++) 
            {
                PumpModel tempPump = tempList[i];
                String _state = tempPump.State == 1 ? "Bật" : "Tắt";
                CustomPumpModel myCustomPump = new CustomPumpModel(i, tempPump.Position, _state);
                MyPumpList.Add(myCustomPump);
            }

            //MyPumpList.Add(new CustomPumpModel(1, "01", "Bật"));
            //MyPumpList.Add(new CustomPumpModel(2, "02", "Bật"));
            //MyPumpList.Add(new CustomPumpModel(3, "03", "Tắt"));
            //MyPumpList.Add(new CustomPumpModel(4, "04", "Tắt"));
            //MyPumpList.Add(new CustomPumpModel(5, "05", "Tắt"));
            //MyPumpList.Add(new CustomPumpModel(6, "06", "Tắt"));

        }
    }
}
