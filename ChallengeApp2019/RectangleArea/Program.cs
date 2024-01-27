using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole;

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
    }
}
