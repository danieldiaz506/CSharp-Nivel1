using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, n3, n4;
           Console.WriteLine("Ingrese cuatro numeros:" );
           n1 = int.Parse(Console.ReadLine());
           n2 = int.Parse(Console.ReadLine());
           n3 = int.Parse(Console.ReadLine());
           n4 = int.Parse(Console.ReadLine());

           if (n1 > 100)
            Console.WriteLine( n1 + " Es mayor a 100");
           if (n2 > 100)
            Console.WriteLine( n2 + " Es mayor a 100");
           if (n3 > 100)
            Console.WriteLine( n3 + " Es mayor a 100");
           if (n4 > 100)
            Console.WriteLine( n4 + " Es mayor a 100");
        }
    }
}
