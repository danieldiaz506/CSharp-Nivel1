using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, ma;
            Console.WriteLine("Ingrese cuatro numeros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            ma = n1;
            if (ma >= n2)
            {
                if (ma >= n3)
                {
                    if (ma >= n4)
                        Console.WriteLine("Estan ordenados de forma decreciente");
                    else
                        Console.WriteLine("No estan ordenados de forma decreciente");
                }else
                    Console.WriteLine("No estan ordenados de forma decreciente");
            }else
                Console.WriteLine("No estan ordenados de forma decreciente");
        }
    }
}
