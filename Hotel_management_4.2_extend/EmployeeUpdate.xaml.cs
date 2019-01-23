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
    /// Interaction logic for EmployeeUpdate.xaml
    /// </summary>
    public partial class EmployeeUpdate : Window
    {
        public EmployeeUpdate()
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

        private void btn_employee_submit_click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM employee WHERE phone='" + txt_phone.Text + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txt_name.Text = dr1.GetValue(0).ToString();
                txt_address.Text = dr1.GetValue(1).ToString();
                txt_age.Text = dr1.GetValue(3).ToString();
                txt_religion.Text = dr1.GetValue(4).ToString();
                txt_salary.Text = dr1.GetValue(5).ToString();
                txt_date.Text = dr1.GetValue(6).ToString();

            }
            else
            {
                MessageBox.Show("Phone Number Not Found");
            }
        }

        private void txt_due_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_update_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("UPDATE employee SET name=@name, address=@address, phone=@phone,age=@age,religion=@religion,salary=@salary,date=@date WHERE phone='" + txt_phone.Text + "' ", con);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@age", txt_age.Text);
                cmd.Parameters.AddWithValue("@religion", txt_religion.Text);
                cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
                cmd.Parameters.AddWithValue("@date", txt_date.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone Number not found");
            }
            finally
            {
                ManagerAccess mn = new ManagerAccess();
                mn.Show();
                this.Close();
            }
        }

        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-2CGPE2S\MSSQLSERVER3;Initial Catalog=HotelManagement;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("DELETE FROM employee WHERE phone='" + txt_phone.Text + "' ", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone Number not found");
            }
            finally
            {
                ManagerAccess mn = new ManagerAccess();
                mn.Show();
                this.Close();
               
            }
        }
    }
}
