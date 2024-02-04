using System;
using static System.Math;

namespace QuadaticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            byte liczba_pierwiastków = 0;

            Console.WriteLine("Program oblicza pierwiastki równania ax^2 + bx + c = 0.");
            Console.WriteLine("Podaj współczynnik kierunkowy a.");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niedozwolona wartość współczynnika kierunkowego a. Program kończy działanie.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Podaj współczynnik b.");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj współczynnik c.");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta < 0) liczba_pierwiastków = 0;
                if (delta == 0) liczba_pierwiastków = 1;
                if (delta > 0) liczba_pierwiastków = 2;

                switch (liczba_pierwiastków)
                {
                    case 0:
                        {
                            Console.WriteLine();
                            Console.Write("Dla");
                            Console.Write("a = {0}, ", a);
                            Console.Write("b = {0}, ", b);
                            Console.Write("c = {0} ", c);
                            Console.Write("brak pierwiastków rzeczywistych.");
                        }

                        break;

                    case 1:
                        {
                            x1 = - b / (2 * a);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Dla ");
                            Console.Write("a = {0}, ", a);
                            Console.Write("b = {0}, ", b);
                            Console.Write("c = {0} ", c);
                            Console.WriteLine("trójmian ma jeden pierwiastek podwójny x1 = {0: ##.##}.", x1);
                            Console.ResetColor();
                        }
                        break;

                    case 2:
                        {
                            x1 = (- b - Sqrt(delta)) / (2 * a);
                            x2 = (- b + Sqrt(delta)) / (2 * a);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Dla ");
                            Console.Write("a = {0}, ", a);
                            Console.Write("b = {0}, ", b);
                            Console.Write("c = {0} ", c);
                            Console.Write("trójmian ma dwa pierwiastki x1 = {0: ##.##} i ", x1);
                            Console.WriteLine("x2 = {0: ##.##}", x2);
                            Console.ResetColor();
                        }
                        break;
                }
            }
        }
    }
}