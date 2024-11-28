using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int promedio = 0, n, acu = 0;
            Console.WriteLine("Ingrese 10 numeros: ");
            for (int x = 0; x < 10; x++)
            {
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / 10;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.WriteLine("Los valores ingresados mayores al promedio son: ");
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio)
                {
                    Console.WriteLine(numeros[x]);
                }
            }

        }
    }
}
