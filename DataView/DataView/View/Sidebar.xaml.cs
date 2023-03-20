using DataView.Common.Helper;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.View
{
    /// <summary>
    /// Interaction logic for Sidebar.xaml
    /// </summary>
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        public void tabItemOnClick(object sender, RoutedEventArgs e)
        {
            var tabItem = sender as TabItem;
            if (tabItem == null)
            {
                return;
            }
            String tabItemName = tabItem.Name;

            switch (tabItemName)
            {
                case "tabItemHome":
                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_LIST);
                    break;

                case "tabItemStation":
                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU);
                    break;

                case "tabItemAbout":
                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_MENU);
                    break;

                case "tabItemQuit":
                    SendToMain(INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_QUIT);
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
