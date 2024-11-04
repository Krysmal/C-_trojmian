using System;

namespace Trojmian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam");

            

            double a, b, c, del, x1, x2;

            string wsA, wsB, wsC, czyKon="t";

            do
            {
                do
                {
                    Console.WriteLine("Podaj współczynnik a");
                    wsA = Console.ReadLine();
                }
                while (double.TryParse(wsA, out _) is false);

                do
                {
                    Console.WriteLine("Podaj współczynnik b");
                    wsB = Console.ReadLine();
                }
                while (double.TryParse(wsB, out _) is false);

                do
                {
                    Console.WriteLine("Podaj współczynnik c");
                    wsC = Console.ReadLine();
                }
                while (double.TryParse(wsC, out _) is false);

                

           

                a = Convert.ToDouble(wsA);

                b = Convert.ToDouble(wsB);

                c = Convert.ToDouble(wsC);

                del = b * b - 4 * a * c;

                x1 = (-1 * b - Math.Sqrt(del)) / 2;

                x2 = (-1 * b + Math.Sqrt(del)) / 2;

                if (del < 0)
                    Console.WriteLine("Funkcja nie ma miejsc zerowych");
                else
                if (del == 0)
                    Console.WriteLine("Funkcja ma jedno miejsce zerowe równe " + x1);
                else
                    Console.WriteLine("Funkcja ma dwa miejsca zerowe równe " + x1 + " oraz " + x2);

                Console.WriteLine("Czy chcesz kontynuować (t/n)");

                czyKon = Console.ReadLine();

            } while (czyKon == "t");

            



        }
    }
}
