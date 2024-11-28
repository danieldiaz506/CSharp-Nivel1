using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, c;
            Console.WriteLine("Ingrese el precio de venta: ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("El precio final es: " + producto(p, c));
        }
        static int producto(int a, int b){
            int r;
            r = a * b;
            return r;
        }
    }
}
