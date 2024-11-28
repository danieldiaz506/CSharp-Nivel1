using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            Console.WriteLine("Ingrese 20 numeros: ");
            for (int i = 0; i < 20; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = n;
                    min = n;
                }else if(n > max){
                    max = n;
                }if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("El numero mayor es: " + max);
            Console.WriteLine("El numero menor es: " + min);

        }
    }
}
