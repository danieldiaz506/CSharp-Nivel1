using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int mayor = 0, n, pos = 0;
            Console.WriteLine("Ingrese 10 numeros");
            for (int x = 0; x < 10; x++)
            {
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }
            for (int x = 0; x < 10; x++)
            {
                if (x == 0)
                {
                    mayor = numeros[x];
                    pos = x;
                }else{
                
                    if (numeros[x] > mayor)
                    {
                        mayor = numeros[x];
                        pos = x;
                    }
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("Su indice de vector es: " + pos);
        }
    }
}
