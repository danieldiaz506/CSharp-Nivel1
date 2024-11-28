using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resultado;
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());
            resultado = num * num * num;
            Console.WriteLine("El resultado al cubo es:" + resultado);
        }
    }
}
