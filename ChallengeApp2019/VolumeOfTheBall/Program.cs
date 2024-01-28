using System;
using static System.Math;

namespace VolumeOfTheBall
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, objętość;
                        
            Console.WriteLine("Program oblicza objętość kuli o podanym promieniu r");
            Console.WriteLine("Podaj promień r");
            r = double.Parse(Console.ReadLine());

            objętość = 4.0 * PI * r * r * r / 3;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Objętość kuli o podanym promieniu r = {0:##.##} wynosi {1:##.##}", r, objętość);
            Console.ResetColor();
        }
    }
}
