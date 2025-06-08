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
            int cont, acum, num, promedio;

            Console.WriteLine("Escriba el primer número:");
            num = Convert.ToInt32(Console.ReadLine());

            cont = 0;
            acum = 0;

            while (num != -1)
            {
                acum = num + acum;
                cont++;

                Console.WriteLine("Escriba el siguiente número (o '-1' para corte):");
                num = Convert.ToInt32(Console.ReadLine());
            }

            promedio = acum / cont;

            Console.WriteLine("El promedio de los " + cont + " números es: " + promedio);
        }
    }
}
