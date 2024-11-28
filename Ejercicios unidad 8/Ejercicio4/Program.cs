using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(ref n);
            if (n == 0)
            {
                Console.WriteLine("El numero es cero.");
            }else
            {
                if (n > 0)
                {
                    Console.WriteLine("El numero es positivo.");
                }else
                {
                    Console.WriteLine("El numero es negativo.");
                }
            }
        }
        static void positivoNegativoCero(ref int a){
            if (a == 0)
            {
                a = 0;
            }else
            {
                if (a > 0)
                {
                    a = 1;
                }else
                {
                    a = -1;
                }
            }
        }
    }
}
