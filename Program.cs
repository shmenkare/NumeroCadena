using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            NumeroaCadena(num);
            Console.ReadKey();

        }
        static void NumeroaCadena(int n1)
        {
            switch (n1)
            { 
                case 1:
                    Console.WriteLine("El numero es Uno");
                    break;
                case 2:
                    Console.WriteLine("El numero es Dos");
                    break;
                case 3:
                    Console.WriteLine("El numero es Tres");
                    break;
                case 4:
                    Console.WriteLine("El numero es Cuatro");
                    break;
                case 5:
                    Console.WriteLine("El numero es Cinco");
                    break;
                case 6:
                    Console.WriteLine("El numero es Seis");
                    break;
                case 7:
                    Console.WriteLine("El numero es Siete");
                    break;
                case 8:
                    Console.WriteLine("El numero es Ocho");
                    break;
                case 9:
                    Console.WriteLine("El numero es Nueve");
                    break;
                case 10 :
                    Console.WriteLine("El numero es Dies");
                    break;
                default :
                    Console.WriteLine("Opcion no valida");
                    break;

             }
        }
    }
}
