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

namespace Hotel_management_4._2_extend
{
    /// <summary>
    /// Interaction logic for ManagerAccess.xaml
    /// </summary>
    public partial class ManagerAccess : Window
    {
        public ManagerAccess()
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_logout_click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void Add_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb1.Foreground = Brushes.White;
        }
        private void Add_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb1.Foreground = Brushes.Black;
        }

        private void update_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb2.Foreground = Brushes.White;
        }

        private void update_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb2.Foreground = Brushes.Black;
        }

        private void expenses_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb3.Foreground = Brushes.White;
        }

        private void expenses_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb3.Foreground = Brushes.Black;
        }

        private void revenue_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb4.Foreground = Brushes.White;
        }

        private void revenue_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb4.Foreground = Brushes.Black;
        }

        private void dashboard_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb5.Foreground = Brushes.White;
        }

        private void dashboard_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb5.Foreground = Brushes.Black;
        }

        private void logout_MouseEnter(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb6.Foreground = Brushes.White;
        }

        private void logout_MouseLeave(object sender, MouseEventArgs e)
        {
            //Foreground color set

            lb6.Foreground = Brushes.Black;
        }

        private void btn_EmplyeeAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.Show();
            this.Close();
        }

        private void btn_EmployeeUpdate_Click(object sender, RoutedEventArgs e)
        {
            EmployeeUpdate update = new EmployeeUpdate();
            update.Show();
            this.Close();
        }

        private void btn_Expenses_Click(object sender, RoutedEventArgs e)
        {
            Expences exp = new Expences();
            exp.Show();
            this.Close();
        }

        private void btn_Revenue_Click(object sender, RoutedEventArgs e)
        {
            Revinue rev = new Revinue();
            rev.Show();
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            Dashboard das = new Dashboard();
            das.Show();
            this.Close();
        }
    }
}
