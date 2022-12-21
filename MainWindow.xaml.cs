
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace wpf1._1
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

        private void Red_Selected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Colors.Red;
        }

        private void blue_Selected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Colors.Blue;
        }

        private void orange_Selected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Colors.Orange;
        }

        private void slid_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brsh.Height = slid.Value;
            brsh.Width=slid.Value;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (del.IsChecked == true)   
            {
                brsh.Color = Colors.White;
            }
            else 
            {
                brsh.Color = Colors.Blue;
            }
        }
    }
}
