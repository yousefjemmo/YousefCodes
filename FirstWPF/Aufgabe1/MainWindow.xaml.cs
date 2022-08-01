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

namespace Aufgabe1
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

        private void Window_MouseEnter(object sender, MouseEventArgs e)

        {

            Window w = (Window)sender;

            w.Background = Brushes.LightGray;

        }



        private void Window_MouseLeave(object sender, MouseEventArgs e)

        {

            Window w = (Window)sender;

            w.Background = Brushes.White;

        }



        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)

        {

            Rectangle r = (Rectangle)sender;

            r.Fill = Brushes.Green;

        }



        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)

        {

            Rectangle r = (Rectangle)sender;

            r.Fill = Brushes.Blue;

        }
    }
}
