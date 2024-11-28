using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = n;
                }else if(n > mayor){
                    mayor = n;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
