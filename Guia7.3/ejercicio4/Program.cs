using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor, menor, contador;
            mayor = 0;
            menor = 0;

            for (contador = 1; contador <= 30; ++contador)
            {
                Console.WriteLine("Ingrese un número entero:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > mayor || contador == 1)
                {
                    mayor = num;
                }
                if (num < menor || contador == 1)
                {
                    menor = num;
                }
            }

            Console.WriteLine($@"
    El número mayor fué: {mayor}
    El número menor fué: {menor}");
        }
    }
}
