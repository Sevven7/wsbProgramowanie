using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2506
{
    public enum DniTygodnia
    {
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }
    public enum EtapyPrania
    {
        Wypełnianie,
        Pranie,
        Płukanie,
        Wirowanie,
        Suszenie
    }
    public enum Posiłki
    {
        Śniadanie,
        DrugieŚniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }
    public enum BierkiSzachowe
    {
        Król = 0,
        King = Król,
        Hetman,
        Queen = Hetman,
        Wieża,
        Rook = Wieża,
        Goniec,
        Bishop = Goniec,
        Skoczek,
        Knight = Skoczek,
        Pion,
        Pawn = Pion
    }
}