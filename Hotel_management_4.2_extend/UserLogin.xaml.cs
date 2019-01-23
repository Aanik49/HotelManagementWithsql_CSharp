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
using System.Windows.Media.Animation;
namespace Hotel_management_4._2_extend
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_submit_click(object sender, RoutedEventArgs e)
        {
            string username, password;
            username = "we";
            password = "we";

            if (username == txt_user.Text && password == txt_pass.Password)
            {
                MainWindow mn = new MainWindow();
                mn.Show();
                this.Close();
            }
            else if (username == txt_user.Text && password != txt_pass.Password)
            {
                MessageBox.Show("Password Not Matched");
                txt_pass.Password = "";
                txt_pass.Focus();
            
            }
            else if (username != txt_user.Text && password == txt_pass.Password)
            {
                MessageBox.Show("Username Not Matched");
                txt_user.Text = "";
                txt_user.Focus();

            }
            else
            {
                MessageBox.Show("Username and Password Not matched");
                txt_user.Text = "";
                txt_pass.Password = "";
                txt_user.Focus();

            }
        }

    }
}
