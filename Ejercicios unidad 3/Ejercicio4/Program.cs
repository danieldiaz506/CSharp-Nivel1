using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, m;
            Console.WriteLine("Ingrese cuatro numeros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n1 < n2)
                m = n1;
            else
                m = n2;
            if (n3 < m)
                m = n3;
            if (n4 < m)
                m = n4;

            Console.WriteLine("El numero menor es: " + m);
        }
    }
}
