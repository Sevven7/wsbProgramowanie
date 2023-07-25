using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2506
{
    public enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    public struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public float Ocena;
        public Plec Plec;

        public void WypelnijStudenta(string nazwisko, int nrAlbumu, float ocena, Plec plec)
        {
            Nazwisko = nazwisko;
            NrAlbumu = nrAlbumu;
            Ocena = Math.Max(2.0f, Math.Min(5.0f, ocena)); // Ograniczenie oceny do przedziału 2.0 - 5.0
            Plec = plec;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwisko: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            // Wypełnienie informacji o studentach
            grupa[0].WypelnijStudenta("Kowalski", 12345, 4.5f, Plec.Mezczyzna);
            grupa[1].WypelnijStudenta("Nowak", 23456, 3.8f, Plec.Kobieta);
            grupa[2].WypelnijStudenta("Wiśniewski", 34567, 5.5f, Plec.Mezczyzna); // Ocena zostanie ograniczona do 5.0
            grupa[3].WypelnijStudenta("Jankowska", 45678, 1.5f, Plec.Kobieta); // Ocena zostanie ograniczona do 2.0
            grupa[4].WypelnijStudenta("Kwiatkowski", 56789, 3.9f, Plec.Mezczyzna);

            // Wyświetlenie informacji o studentach
            foreach (Student student in grupa)
            {
                student.WyswietlInformacje();
            }

            // Obliczenie średniej ocen w grupie
            float sredniaOcen = ObliczSredniaOcen(grupa);
            Console.WriteLine($"Średnia ocen: {sredniaOcen}");
        }

        public static float ObliczSredniaOcen(Student[] grupa)
        {
            if (grupa.Length == 0)
                return 0;

            float sumaOcen = 0;
            foreach (Student student in grupa)
            {
                sumaOcen += student.Ocena;
            }

            return sumaOcen / grupa.Length;
        }
    }

}