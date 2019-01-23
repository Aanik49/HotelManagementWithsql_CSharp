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
    /// Interaction logic for Revinue.xaml
    /// </summary>
    public partial class Revinue : Window
    {
        public Revinue()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        float cost, revinue, income;
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

        private void btn_income_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT SUM(payment) AS total_income FROM bill", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                decimal d = (decimal)dr1["total_income"];
                txt_income.Text = d.ToString();
                income = float.Parse(txt_income.Text);


            }
            else
            {
                MessageBox.Show("Sorry!server Busy");
            }
        }

        private void btn_cost_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT SUM(amount) AS total_cost FROM expance", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                decimal d = (decimal)dr1["total_cost"];
                txt_total_cost.Text = d.ToString();
                cost = float.Parse(txt_total_cost.Text);


            }
            else
            {
                MessageBox.Show("Sorry!server Busy");
            }
           
        }

        private void btn_revinue_click(object sender, RoutedEventArgs e)
        {
            revinue = income - cost;
            txt_revinue.Text = revinue.ToString();
        }
    }
}
