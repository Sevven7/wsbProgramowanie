using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2506
{
    public enum KlasaRzadkosci
    {
        Powszechny,
        Rzadki,
        Unikalny,
        Epicki
    }

    public enum TypPrzedmiotu
    {
        Broń,
        Zbroja,
        Amulet,
        Pierścień,
        Hełm,
        Tarcza,
        Buty
    }

    public struct Przedmiot
    {
        public float Waga;
        public int Wartosc;
        public KlasaRzadkosci Rzadkosc;
        public TypPrzedmiotu Typ;
        public string NazwaWlasna;

        public void WypelnijPrzedmiot(float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
        {
            Waga = waga;
            Wartosc = wartosc;
            Rzadkosc = rzadkosc;
            Typ = typ;
            NazwaWlasna = nazwaWlasna;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa: {NazwaWlasna}");
            Console.WriteLine($"Typ: {Typ}");
            Console.WriteLine($"Rzadkosc: {Rzadkosc}");
            Console.WriteLine($"Waga: {Waga}");
            Console.WriteLine($"Wartosc: {Wartosc} szt.");
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Przedmiot[] przedmioty = new Przedmiot[3];

            // Wypełnienie struktury przykładowymi przedmiotami
            przedmioty[0].WypelnijPrzedmiot(2.5f, 10, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Broń, "Miecz");
            przedmioty[1].WypelnijPrzedmiot(1.2f, 25, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja Płytowa");
            przedmioty[2].WypelnijPrzedmiot(0.5f, 50, KlasaRzadkosci.Epicki, TypPrzedmiotu.Amulet, "Amulet Mocy");

            // Wyświetlanie informacji o przedmiotach
            foreach (Przedmiot przedmiot in przedmioty)
            {
                przedmiot.WyswietlInformacje();
            }

            // Losowanie przedmiotu
            Przedmiot losowyPrzedmiot = LosujPrzedmiot(przedmioty);
            Console.WriteLine("Wylosowany przedmiot:");
            losowyPrzedmiot.WyswietlInformacje();
        }

        public static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
        {
            // Obliczanie sumy szans dla poszczególnych klas rzadkości
            int[] szanse = new int[przedmioty.Length];
            int sumaSztuk = 0;
            for (int i = 0; i < przedmioty.Length; i++)
            {
                int szansa = (int)przedmioty[i].Rzadkosc + 1;
                szanse[i] = szansa;
                sumaSztuk += szansa;
            }

            // Losowanie przedmiotu na podstawie szans
            int losowaLiczba = new Random().Next(sumaSztuk);
            int indeks = 0;
            while (losowaLiczba >= szanse[indeks])
            {
                losowaLiczba -= szanse[indeks];
                indeks++;
            }

            return przedmioty[indeks];
        }
    }
}