using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ing1 = new char[51];
            char ing2, ing3, letra;
            int x;
            Console.WriteLine("Ingrese una frase (Máximo 50 caracteres incluido espacios) para terminar ingrese un punto.");
            letra = char.Parse(Console.ReadLine());
            x = 0;
            while (letra != '.' && x < 50)
            {
                ing1[x] = letra;
                letra = char.Parse(Console.ReadLine());
                x++;

            }
            ing1[x] = '\0';
            Console.WriteLine("Ingrese un valor literal a reemplazar: ");
            ing2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor literal a escribir: ");
            ing3 = char.Parse(Console.ReadLine());
            for (int y = 0; y < x; y++)
            {
                if (ing1[y] == ing2)
                {
                    ing1[y] = ing3;
                }
            }
            for (int y = 0; y < x; y++)
            {
                Console.Write(ing1[y]);
            }
        }
    }
}
