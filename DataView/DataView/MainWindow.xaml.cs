using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
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

namespace DataView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //GetData();
        }

        private void GetData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44393/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/hello?id=1").Result;

            if(response.IsSuccessStatusCode)
            {
                string myres = response.Content.ReadAsStringAsync().Result;
                this.Card0_Status.Text = myres;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode);
            }
        }

        private void Card0_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Card0_Status.Text = "Status: nice";
        }

    }

}
