using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace kart_Listy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Uczniowie> DodajUcznia { get; set; } //samo będzie się aktualizować
        //Reprezentuje dynamiczną kolekcję danych, która dostarcza powiadomienia po dodaniu lub usunięciu elementów albo odświeżeniu całej listy.
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            zapiszUczniow();
        }
        private void zapiszUczniow()
        {
            DodajUcznia = new ObservableCollection<Uczniowie>();
            DodajUcznia.Add(new Uczniowie("Zosia", "Samosia", false, "3P")); ;
            DodajUcznia.Add(new Uczniowie("Edek", "Fedek", true, "3P"));
        }
    }
}
