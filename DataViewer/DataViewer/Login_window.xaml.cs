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

namespace DataViewer
{
    /// <summary>
    /// Interaction logic for Login_window.xaml
    /// </summary>
    public partial class Login_window : Window
    {
        public Login_window()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((tbUsername.Text == "dat") && (pbPassword.Password == "123"))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
