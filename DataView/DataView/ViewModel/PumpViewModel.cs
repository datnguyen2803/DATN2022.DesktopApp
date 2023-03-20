using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.VisualBasic;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.ViewModel
{
    public class PieData
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }

    public class PumpViewModel : BindableBase
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion

        //public Collection<PieData> PumpTime { get; set; }

        public SeriesCollection pumpSeriesCollection { get; set; }

        public Func<ChartPoint, string> PointLabel { get; set; }

        public PumpViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //p.Show();
            });

            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pumpSeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Thời gian bật",
                    Values = new ChartValues<double> { 14 }
                },
                new PieSeries
                {
                    Title = "Thời gian tắt",
                    Values = new ChartValues<double> { 10 }
                },
            };


            //    PumpTime = new Collection<PieData>();
            //    GetDataFromDB();

        }


        //private void GetDataFromDB()
        //{
        //    PieData pump1 = new PieData()
        //    {
        //        Key = "Thời gian bật",
        //        Value = 14,
        //    };
        //    PieData pump2 = new PieData()
        //    {
        //        Key = "Thời gian bật",
        //        Value = 24 - pump1.Value
        //    };

        //    PumpTime.Add(pump1);
        //    PumpTime.Add(pump2);
        //}
    }
}
