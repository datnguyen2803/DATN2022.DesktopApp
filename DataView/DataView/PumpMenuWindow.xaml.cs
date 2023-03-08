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
using System.Windows.Shapes;

namespace DataView
{
    /// <summary>
    /// Interaction logic for PumpMenuWindow.xaml
    /// </summary>
    public partial class PumpMenuWindow : Window
    {
        public PumpMenuWindow()
        {
            InitializeComponent();
        }

        private void TabItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Unable to save file, try again.");
        }
    }
}
