using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de números a sumar:");
            int cantidad = int.Parse(Console.ReadLine());

            int suma = 0;
            
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese el número"+i+":");

                int numero= int.Parse(Console.ReadLine());

                suma = suma + numero;

            }
            Console.Write("LA SUMA ES:"+suma);

            Console.ReadKey();

        }
    }
}
