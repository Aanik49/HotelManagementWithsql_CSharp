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
    /// Interaction logic for Expences.xaml
    /// </summary>
    public partial class Expences : Window
    {
        public Expences()
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

        private void btn_expance_submit_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO expance (type,amount,date) VALUES (@type,@amount,@date)", con);
                cmd.Parameters.AddWithValue("@type", txt_type.Text);
                cmd.Parameters.AddWithValue("@amount", txt_amount.Text);
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
                ManagerAccess hm = new ManagerAccess();
                hm.Show();
                this.Close();
            }
        }
    }
}
