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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
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
            ManagerAccess mn = new ManagerAccess();
            mn.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_publish_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO dashboard (no,sms) VALUES (@no,@sms)", con);
                cmd.Parameters.AddWithValue("@no", txt_no.Text);
                cmd.Parameters.AddWithValue("@sms", txt_dash.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed");
            }
            finally
            {
                ManagerAccess hm = new ManagerAccess();
                hm.Show();
                this.Close();
            }
        }

        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("DELETE FROM dashboard WHERE no='" + txt_no.Text + "' ", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successful");
        }

        private void btn_show_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM dashboard WHERE no='" + txt_no.Text + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                
                txt_dash.Text = dr1.GetValue(1).ToString();
               

            }
            else
            {
                MessageBox.Show("Phone Number Not Found");
            }
        }
    }
}
