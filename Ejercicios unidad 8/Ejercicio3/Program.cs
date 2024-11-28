using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0, promedio, cuantPrimos, acu = 0;
            Console.WriteLine("Ingrese numeros (Para terminar el programa ingrese cero): ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                cuantPrimos = primo(n);
                if (cuantPrimos == 1)
                {
                    con++;
                    acu += n;
                }
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de los numeros primos: " + promedio);
        }
        static int primo(int a){
            int conP = 0, r;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    conP++;
                }
            }
            if (conP == 2)
            {
                r = 1;
                return r;
            }else
            {
                r = 0;
                return r;
            }
        }
    }
}
