using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            switch (a)
            {
                case 1: 
                   Console.WriteLine("Hola");
                   break;
                case 2:
                   Console.WriteLine("Chau");
                   break;
                case 3:
                   Console.WriteLine("Blanco");
                   break;
                case 4:
                   Console.WriteLine("Negro");
                   break;
                default:
                   Console.WriteLine("Opción incorrecta");
                   break;
            }
        }
    }
}
