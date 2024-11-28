using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conI,conT, mayor, conGrupOrd = 0, numGrup = 0, porcentaje, porcentajeActual = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese una lista de numeros: ");
                n = int.Parse(Console.ReadLine());
                bool bandOrden = true;
                conI = 0;
                conT = 0;
                mayor = 0;
                porcentaje = 0;
                while (n != 0)
                {
                    conT++;
                    if (n % 2 != 0)
                        conI++;
                    
                    if (mayor == 0)
                    {
                        mayor = n;
                    }else{
                        if (mayor > n && bandOrden == true)
                        {
                            bandOrden = true;
                            mayor = n;
                        }else{
                            bandOrden = false;
                        }
                    }
                    n = int.Parse(Console.ReadLine());
                }
                porcentaje = (conI * 100)/conT;
                if (x == 0)
                {
                    porcentajeActual = porcentaje;
                    numGrup = x + 1;
                }else{

                    if(porcentaje > porcentajeActual)
                    {
                        porcentajeActual = porcentaje;
                        numGrup = x + 1;
                    }
                }
                if (bandOrden)
                {
                    conGrupOrd++;
                }
            }
            Console.WriteLine("La cantidad de grupos ordenados es: " + conGrupOrd);
            Console.WriteLine("El grupo con mayor porcentaje de impares es el numero : " + numGrup);

        }
    }
}