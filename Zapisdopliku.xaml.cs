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

namespace kart_Listy
{
    /// <summary>
    /// Logika interakcji dla klasy Zapisdopliku.xaml
    /// </summary>
    public partial class Zapisdopliku : Window
    {
        public Zapisdopliku()
        {
            InitializeComponent();
        }

        private void Click_Zamknij(object sender, RoutedEventArgs e)
        {
            MessageBoxResult okno = MessageBox.Show("Czy napewno chcesz zamknąć to okno?","Zamykanie",
            MessageBoxButton.YesNo, MessageBoxImage.Question);//zadaje pytanie czy zamknąć okno
            if(okno==MessageBoxResult.Yes)//Jeśli tak, wtedy zamyka
                {
                    this.Close();
                }
        }

        
        //Błyskawica-->We właściwościach (wywyołujemy tak tą metodę)
        private void Click_Nowe_Niemodalne(object sender, RoutedEventArgs e)
        {
            var okno = new Window_Nowe();
            okno.Show();
           //Wyświetla okno niemodlane 
        }

        private void Click_Nowe_Modalne(object sender, RoutedEventArgs e)
        {
            //var->Rozpoznaj typ elememntu po pierwszym przypisaniu wartości
            var okno = new Window_Nowe();
            okno.ShowDialog();
        }
        //Błyskawica-->We właściwościach (wywyołujemy tak tą metodę) 
    }
}
