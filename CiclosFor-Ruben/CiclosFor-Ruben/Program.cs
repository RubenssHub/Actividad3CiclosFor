using System;

namespace CiclosFor_Ruben
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Imprime los numeros del x hasta y de -1");
            Console.WriteLine("empezamos el ciclo");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("terminamos el ciclo");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("de cuanto en cunto?");
            z = Convert.ToDouble(Console.ReadLine());

            if (x < y)
            {
                for (double i = x; i < y; i += z)
                {
                    Console.WriteLine("i= " + i);
                }
            }
        }

    }
}
