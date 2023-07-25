using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d, x;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        d = inputValue();
        if ((b == Math.Pow(0, d)) == 0)
        {
            Console.WriteLine("Brak rozwiązań");
        }
        else
        {
            x = a / b + c / d;
            Console.WriteLine(x);
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}