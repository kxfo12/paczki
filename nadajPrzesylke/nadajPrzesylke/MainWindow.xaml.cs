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

namespace nadajPrzesylke
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(postcard.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
                cost.Content = "Cena: 1 zł";
            }
            else if(letter.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
                cost.Content = "Cena: 1,5 zł";
            }
            else if(package.IsChecked== true)
            {
                image.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
                cost.Content = "Cena: 10 zł";
            }
        }

        private void zatwierdzbaton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(code.Text, out int zipCode))
            {
                if (code.Text.Length == 5)
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                }
            }
            else
            {
                MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
            }
        }
    }
}
