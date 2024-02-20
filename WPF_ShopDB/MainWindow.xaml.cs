using Microsoft.Data.SqlClient;
using ShopDB;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ShopDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShopDBContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new ShopDBContext();
        }

        private void Cities_Click(object sender, RoutedEventArgs e)
        {
           Grid.ItemsSource = context.Cities.ToList();
        }

        private void Shops_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Shops.ToList();
        }

        private void Countries_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Country.ToList();
        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Categories.ToList();
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Products.ToList();
        }

        private void Position_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Position.ToList();
        }

        private void Workers_Click(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = context.Workers.ToList();
        }
    }
}