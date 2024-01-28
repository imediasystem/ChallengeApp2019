using System;

namespace FahrenheitCelsiusRecalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
                        
            Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita");
            F = double.Parse(Console.ReadLine());
            C = 5d / 9d * (F - 32);
            Console.WriteLine("Temperatura w stopniach Celsjusza wynosi {1:##}", F, C);
        }
    }
}
