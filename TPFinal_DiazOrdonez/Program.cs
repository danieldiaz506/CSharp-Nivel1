using System;

namespace TPFinal_DiazOrdonez
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

           // a. El mayor de los números pares.
           // b. La cantidad de números impares.
           // c. El menor de los números primos.
           
            int n, conImpares = 0, mayorPares = 0, menorPrimos = 0;
            
            Console.WriteLine("Ingrese una lista de números(Para terminar ingrese cero)");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (n%2 == 0)
                {
                    if (n > mayorPares)
                    {
                        mayorPares = n;
                    }
                    
                }else{
                    conImpares++;
                }
                if (nPrimos(n))
                {
                    if (menorPrimos == 0)
                    {
                        menorPrimos = n;
                    }else{
                        if (n < menorPrimos)
                        {
                            menorPrimos = n;
                        }
                    }
                }

                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El numero mayor de los pares es: " + mayorPares);
            Console.WriteLine("La cantidad de números impares es: " + conImpares);
            Console.WriteLine("El numero menor primo es: " + menorPrimos);
        }
        static bool nPrimos(int n)
        {
            int conPrimos = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    conPrimos++;
                }
            }
            if (conPrimos == 2)
            {
                return true;
            }else{
                return false;
            }


        }
    }
}