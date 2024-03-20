using Protocols.ChildWindow;
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

namespace Protocols
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

        private void StationCreate(object sender, RoutedEventArgs e)
        {
            SubWindow StationCreate = new SubWindow();
            StationCreate.Owner = this;
            StationCreate.Show();
            /*Ellipse station = new Ellipse
            {
                Width = 20,
                Height = 20,
                Fill = Brushes.Red
            };

            Canvas.SetLeft(station, 100);
            Canvas.SetTop(station, 100);

            StationsArea.Children.Add(station)*/
            ;
        }
    }
}
