using System;
using static System.Math;

namespace SqrtPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyświetla pierwiastek kwadratowy z liczyby PI");
            Console.WriteLine("z dokładnością do dwóch miejsc po przecinku.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sqrt(pi) = {0:#.##}.", Sqrt(PI));
            Console.ResetColor();
        }
    }
}
