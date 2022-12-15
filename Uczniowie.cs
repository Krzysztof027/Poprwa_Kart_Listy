using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kart_Listy
{
    public partial class MainWindow : Window
    {

        public partial class Uczniowie
        {

            public String Imie { get; set; }
            public String Nazwisko { get; set; }
            public bool Plec { get; set; }
            public String Klasa { get; set; }

            public Uczniowie(string imie, string nazwisko, bool plec, string klasa)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                //this.Plec = plec;
                Plec = plec;
                Klasa = klasa;
            }
        }

    }
}
