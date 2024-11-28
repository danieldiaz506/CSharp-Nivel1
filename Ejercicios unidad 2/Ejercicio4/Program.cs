using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float tf, resultado;
            Console.WriteLine("Ingrese el total facturado:");
            tf = float.Parse(Console.ReadLine());
            resultado = ((tf * 5)/100) + 15000;
            Console.WriteLine("El salario a cobrar es de: " + resultado);
        }
    }
}
