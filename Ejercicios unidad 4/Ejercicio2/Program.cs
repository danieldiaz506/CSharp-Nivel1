using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float iv, cl, r;
            Console.WriteLine("Ingrese el importe de venta:");
            iv = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros:");
            cl = float.Parse(Console.ReadLine());
            if (cl > 500){
                r = iv * 0.75F;
            }else if(cl > 300){
                r = iv * 0.85F;
            }else if(cl > 100){
                r = iv * 0.90F;
            }else
                r = iv;
                

            Console.WriteLine("El precio final es: " + r);

        }
    }
}
