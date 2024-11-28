using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, resultado;
            Console.WriteLine("Ingrese una nota:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una nota:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una nota:");
            n3 = float.Parse(Console.ReadLine());
            resultado = (n1+n2+n3)/3;
            Console.WriteLine("El promedio de nota es: " + resultado.ToString("0.00"));
        }
    }
}
