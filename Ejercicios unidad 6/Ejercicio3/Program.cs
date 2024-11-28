using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con;
            Console.WriteLine("Ingrese una lista de numeros positivos: ");
            n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                con = 0;
                while (n != 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("La cantidad de numeros de esta lista es: " + con);
                Console.WriteLine("Ingrese una lista de numeros positivos o negativo para terminar el programa: ");
                n = int.Parse(Console.ReadLine());
            }


        }
    }
}
