using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArticulo = new int[15];
            int v = 0, na, naactual;
            do
            {
                Console.WriteLine("Ingrese numero de articulo (1 al 15) o un negativo para terminar el programa: ");
                na = int.Parse(Console.ReadLine());
                while (na == 0 || na > 15)
                {
                    Console.WriteLine("Ingrese solo numeros del 1 a 15 o negativo para terminar el programa: ");
                    na = int.Parse(Console.ReadLine());
                }
                if (na > 0)
                {
                   Console.WriteLine("Ingrese las ventas: ");
                   v = int.Parse(Console.ReadLine());
                }
                naactual = na;
                while (naactual == na && na > 0)
                    {
                       numArticulo[naactual - 1] += v;
                       Console.WriteLine("Ingrese numero de articulo del 1 al 15 (cero para cambiar de articulo ó numero negativo para terminar el programa): ");
                       na = int.Parse(Console.ReadLine());
                       while (na > 15)
                        { 
                            Console.WriteLine("Ingrese solo numeros del 1 a 15 (cero para cambiar de articulo ó numero negativo para terminar el programa): ");
                            na = int.Parse(Console.ReadLine());
                        }
                        if (na != naactual && na > 0)
                        {
                            Console.WriteLine("Haz cambiado de articulo, vuelve a ingresar los datos de este (Recuerda ingresar cero antes de cambiar de articulo)");
                        }else if(na > 0)
                        {
                            Console.WriteLine("Ingrese las ventas: ");
                            v = int.Parse(Console.ReadLine());
                        }
                    }
            } while (na >= 0 && na < 16);
            int mayor = 0, mv = 0, asv = 0;
            for (int x = 0; x < 15; x++)
            {
                if (x == 0)
                {
                    mayor = numArticulo[x];
                    mv = x + 1;
                }else{
                    if (numArticulo[x] > mayor)
                    {
                        mayor = numArticulo[x];
                        mv = x + 1;
                    }
                }
            }
            Console.WriteLine("Los articulos que no tuvieron ventas fueron: ");
            for (int y = 0; y < 15; y++)
            {
                if (numArticulo[y] == 0)
                {
                    
                    asv = y + 1;
                    Console.WriteLine(asv);
                }
            }
            Console.WriteLine("El articulo que tuvo más ventas fue: " + mv);
            Console.WriteLine("El articulo 10 tuvo " + numArticulo[9] + " ventas.");

        }
    }
}
