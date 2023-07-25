using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2506
{
    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public string Kierunek;
    }
    public struct Przedmiot
    {
        public string Nazwa;
        public string KodPrzedmiotu;
        public int LiczbaGodzin;
        public string Prowadzacy;
    }
    public struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string StopienNaukowy;
        public string Specjalizacja;
    }
}