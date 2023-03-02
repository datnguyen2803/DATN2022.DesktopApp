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

    public class PumpViewModel : BaseViewModel
    {
        #region commands
        public ICommand LoadedWindowCommand { get; set; }
        #endregion

        public List<CustomStationModel> MyStationList { get; set; }

        public bool IsLoaded = false;
        public PumpViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //p.Show();
            });


            GetDataFromDB();
        }

        private void GetDataFromDB()
        {
        
        }
    }
}
