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
using System.Data.SqlClient;
namespace Hotel_management_4._2_extend
{
    /// <summary>
    /// Interaction logic for PaymentSlip.xaml
    /// </summary>
    public partial class PaymentSlip : Window
    {
        public PaymentSlip()
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
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_show_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT name,address,phone,due FROM booking WHERE phone='" + txt_phone.Text + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txt_name.Text = dr1.GetValue(0).ToString();
                txt_address.Text = dr1.GetValue(1).ToString();
                txt_due.Text = dr1.GetValue(3).ToString();
                txt_payment.Text = dr1.GetValue(3).ToString();
             
                

            }
            else
            {
                MessageBox.Show("Phone Number Not Found");
            }
        }

        private void btn_payment_submit_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO bill (phone,payment,date) VALUES (@phone,@payment,@date)", con);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@payment", txt_payment.Text);
                cmd.Parameters.AddWithValue("@date", txt_date.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed");
            }
            finally
            {
                MainWindow hm = new MainWindow();
                hm.Show();
                this.Close();
            }
        }
    }
}
