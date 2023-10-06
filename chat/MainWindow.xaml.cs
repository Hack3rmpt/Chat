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

namespace chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool IsServer = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void craete_Click(object sender, RoutedEventArgs e)
        {

            if (ip_con.Text == "Канал связи задавать тут" || ip_con.Text == "")
            {
                MessageBox.Show("Веди ip");
            }
            else
            {
                IsServer = true;
                Window1 windwow = new Window1(name.Text, ip_con.Text);
                windwow.Show();
                this.Close();
            }
        }
        private void connect_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Погоняло вводи сюда" || name.Text == "")
            {
                MessageBox.Show("Веди имя");
            }
            else
            {
                if (ip_con.Text == "Канал связи задавать тут" || ip_con.Text == "")
                {
                    MessageBox.Show("Веди ip");
                }
                else
                {
                    IsServer = false;
                    Window1 windwow = new Window1(name.Text, ip_con.Text);
                    windwow.Show();
                    this.Close();
                }
            }
        }
    }
}
