using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conP, conT = 0;
            Console.WriteLine("Ingrese 10 numeros:");
            for (int i = 0; i < 10; i++)
            {
                conP = 0;
                n = int.Parse(Console.ReadLine());
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                        conP++;
                }
                if (conP == 2)
                    conT++;
            }
            Console.WriteLine("La cantidad total de numeros primos es: " + conT);
        }
    }
}
