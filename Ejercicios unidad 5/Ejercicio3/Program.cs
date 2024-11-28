using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, promedio, acu = 0, con = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese 20 edades: ");
                e = int.Parse(Console.ReadLine());
                if (e > 18)
                {
                    acu+=e;
                    con++;
                }
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de personas mayores es: " + promedio);
        }
    }
}
