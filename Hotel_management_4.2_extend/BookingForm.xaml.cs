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
    /// Interaction logic for BookingForm.xaml
    /// </summary>
    public partial class BookingForm : Window
    {
        public BookingForm()
        {
            InitializeComponent();

        }
        SqlCommand cmd;
        SqlConnection con;
        float cost, payment, due;
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

        private void btn_book_submit_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO booking (name,phone,address,room,duration,cost,payment,due) VALUES (@name,@phone,@address,@room,@duration,@cost,@payment,@due)", con);
                cost = float.Parse(txt_cost.Text);
                payment = float.Parse(txt_payment.Text);
                due = cost - payment;
                txt_due.Text = due.ToString();
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@room", txt_room.Text);
                cmd.Parameters.AddWithValue("@duration", txt_duration.Text);
                cmd.Parameters.AddWithValue("@cost", txt_cost.Text);
                cmd.Parameters.AddWithValue("@payment", txt_payment.Text);
                cmd.Parameters.AddWithValue("@due", txt_due.Text);

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

        

        private void btn_check_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM booking WHERE room='" + txt_room.Text + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                MessageBox.Show("Room Is not Empty");


            }
            else
            {
                btn_book_submit.IsEnabled = true;

            }
        }
    }
}
