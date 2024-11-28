using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           // paso 0 declarar las variables, tener en cuenta el tipo

           int n1, n2, resultado;

           // paso 1: pedir valores
           
           Console.WriteLine("Ingrese un numero:");

           n1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese otro numero:");

           n2 = int.Parse(Console.ReadLine());
        
           // paso 2: Realizar calculo

           resultado = n1 + n2;

           //paso 3: Emitir resultado

           Console.WriteLine("El resultado de la suma es:" + resultado);










        }
    }
}
