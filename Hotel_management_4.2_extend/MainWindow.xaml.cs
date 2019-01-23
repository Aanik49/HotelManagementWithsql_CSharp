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
using System.Data.SqlClient;
namespace Hotel_management_4._2_extend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_manager(object sender, RoutedEventArgs e)
        {
            AdminLogin adm = new AdminLogin();
            adm.Show();
            this.Close();
        }

        private void btn_book(object sender, RoutedEventArgs e)
        {
            BookingForm bk = new BookingForm();
            bk.Show();
            this.Close();
        }

        private void btn_payment(object sender, RoutedEventArgs e)
        {
            PaymentSlip pl = new PaymentSlip();
            pl.Show();
            this.Close();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_about(object sender, RoutedEventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Close();
        }

        private void btn_Exit_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb5.Foreground = Brushes.White;
        }

        private void btn_Exit_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb5.Foreground = Brushes.Black;
        }
        private void btn_About_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb4.Foreground = Brushes.White;
        }

        private void btn_About_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb4.Foreground = Brushes.Black;
        }

        private void btn_Pay_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb3.Foreground = Brushes.White;
        }

        private void btn_Pay_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb3.Foreground = Brushes.Black;
        }

        private void btn_booking_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb2.Foreground = Brushes.White;
        }

        private void btn_booking_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb2.Foreground = Brushes.Black;
        }

        private void btn_manager_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb1.Foreground = Brushes.White;
        }

        private void btn_manager_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb1.Foreground = Brushes.Black;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void loader_event(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM dashboard ", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                
                txt_dash.Text = dr1.GetValue(1).ToString();
               




            }

        }
    }
}
