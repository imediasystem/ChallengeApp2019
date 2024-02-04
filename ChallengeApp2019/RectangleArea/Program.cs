using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole;

            try
            {
                Console.WriteLine("Program oblicza pole prostokąta.");
                Console.WriteLine("Podaj bok a.");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok b.");
                b = double.Parse(Console.ReadLine());

                pole = a * b;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Pole prostokąta o boku a = {0} i boku b = {1}", a, b);
                Console.WriteLine(" wynosi {0}.", pole);
                Console.ResetColor();
            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie podano liczby. Nie można obliczyć pola. Program kończy działanie.");
                Console.ResetColor();
            }
        }
    }
}
