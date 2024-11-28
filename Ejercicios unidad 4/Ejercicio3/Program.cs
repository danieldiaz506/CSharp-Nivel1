using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, ram, pf = 0, disco;
            Console.WriteLine("Ingrese el procesador (Del 1 al 3) ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la RAM (Del 1 al 3) ");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea aumentar el disco? 1 para si ó 0 para no ");
            disco = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1: 
                
                   switch (ram)
                   {
                       case 1: 
                          pf = 800;
                          break;
                       case 2:
                          pf = 900;
                          break;
                       case 3:
                          pf = 1000;
                          break;
                       default:
                          Console.WriteLine("Opción  de ram inválida, corriga los datos y vuelva a intentarlo");
                          break;
                   }
                   break;
                case 2:

                   switch (ram)
                   {
                       case 1:
                          pf = 900;
                          break;
                       case 2:
                          pf = 1000;
                          break;
                       case 3: 
                          pf = 1400;
                          break;
                       default:
                          Console.WriteLine("Opción de ram inválida, corriga los datos y vuelva a intentarlo");
                          break;
                   }
                   break;
                case 3:
                   switch (ram)
                   {
                       case 1: 
                          pf = 1200;
                          break;
                       case 2:
                          pf = 1400;
                          break;
                       case 3:
                          pf = 2000;
                          break;
                       default:
                          Console.WriteLine("Opción de ram inválida, corriga los datos y vuelva a intentarlo");
                          break;
                   }
                   break;
                default:
                Console.WriteLine("Opción de procesador inválida, corriga los datos y vuelva a intentarlo");
                break;
            }
            if (disco == 1 && (p== 1 || p== 2 || p == 3) && (ram == 1 || ram == 2 || ram == 3))
                pf = pf + 300;

            
            Console.WriteLine("El precio final de la maquina es: " + pf);
        }
    }
}
