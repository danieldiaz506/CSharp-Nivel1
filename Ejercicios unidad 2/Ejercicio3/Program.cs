using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, v, resultado;
            Console.WriteLine("Ingrese una distancia en km:");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una velocidad promedio km/h:");
            v = float.Parse(Console.ReadLine());
            resultado = (km * 60)/v;
            Console.WriteLine("El tiempo promedio en recorrer la distancia es de: " + resultado + " minutos");
        }
    }
}
