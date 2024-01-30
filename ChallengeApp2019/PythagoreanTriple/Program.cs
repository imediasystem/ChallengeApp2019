using System;
using static System.Math;

namespace PythagoreanTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Program sprawdza, czy podane liczby a, b, c to trójka pitagorejska");
            Console.WriteLine("Podaj liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c");
            c = int.Parse(Console.ReadLine());


            if ((a * a + b * b == c * c))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Liczby ");
                Console.Write("a = " + a + ", ");
                Console.Write("b = " + b + ", ");
                Console.Write("c = " + c);
                Console.WriteLine(" są trójką pitagorejską");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Liczby ");
                Console.Write("a = " + a + ", ");
                Console.Write("b = " + b + ", ");
                Console.Write("c = " + c);
                Console.WriteLine(" nie są trójką pitagorejską");
                Console.ResetColor();
            }
        }
    }
}
