using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0;
            int menor = 0;

            Console.WriteLine("Escriba el primer número (Entre 0 y 100):");
            int num = Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            while (num >= 0 && num <= 100)
            {
                contador++;
                if (contador == 1)
                {
                    mayor = num;
                    menor = num;
                }

                if (mayor < num)
                {
                    mayor = num;
                }
                if (menor > num)
                {
                    menor = num;
                }
                Console.WriteLine("Escriba el siguente número (Entre 0 y 100):");
                num = Convert.ToInt32(Console.ReadLine());
            }
            
            if (contador > 0)
            {
                Console.WriteLine($@"
    El número mayor fué: {mayor}
    El número menor fué: {menor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números o el número no pertenece al rango.");
            }

            Console.ReadKey();
        }
    }
}
