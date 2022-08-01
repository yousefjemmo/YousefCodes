using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FirstWPF
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new Application(); 
            var win = new Window();

            app.MainWindow = win;
            win.Show();

            Console.WriteLine("Hello Yousef");
            win.Background = Brushes.Blue;

            var ellipse = new Ellipse();
            ellipse.Fill = Brushes.Yellow;
            ellipse.MouseLeftButtonDown += OnMouseLeftButton;
            ellipse.MouseLeftButtonUp += OnMouseLeftButton; 

            win.Content = ellipse;
            app.Run();
        }

        private static void OnMouseLeftButton(object sender, MouseButtonEventArgs e)
        {
           Ellipse ellipse = (Ellipse)sender;
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                ellipse.CaptureMouse();
                ellipse.Fill = Brushes.Green;
            }
            else
            {
                ellipse.Fill = Brushes.Purple;
                ellipse.ReleaseMouseCapture();
            }
        }
    }
}
