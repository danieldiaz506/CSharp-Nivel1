using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            bool pares;
            Console.WriteLine("Ingrese 20 numeros: ");
            for (int x = 0; x < 20; x++)
            {
                n = int.Parse(Console.ReadLine());
                pares = par(n);
                if (pares)
                {
                    con++;
                }

            }
            Console.WriteLine("La cantidad de numeros pares es: " + con);
        }
        static bool par(int a)
        {
            bool r;
            if (a % 2 == 0)
            {
                r = true;
                return r;
            }else
            {
                r = false;
                return r;
            }


        }
    }
}
