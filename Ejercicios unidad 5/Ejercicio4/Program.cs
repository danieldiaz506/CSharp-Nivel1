using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    con++;
                }
            }
            if (con == 2)
                Console.WriteLine("El numero ingresado es primo");
            else
                Console.WriteLine("El numero ingresado NO es primo");
        }
    }
}
