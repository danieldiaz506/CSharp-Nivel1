using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Cero");
            else if(n > 0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");
        }
    }
}
