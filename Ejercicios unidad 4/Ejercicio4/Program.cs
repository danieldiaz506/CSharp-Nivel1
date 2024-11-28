using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, rs, rm;
            Console.WriteLine("Ingrese 3 numeros");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            rs = n1 + n2;
            rm = n2 * n3;
            if (rs > rm)
                Console.WriteLine("la suma de los dos primeros es mayor al producto del segundo con el tercero");
            else
                Console.WriteLine("la suma de los dos primeros no es mayor al producto del segundo con el tercero");
        }
    }
}
