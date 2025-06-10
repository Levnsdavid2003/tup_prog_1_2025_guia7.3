using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, acum, cont, promedio;

            acum = 0;

            for (cont = 1; cont <= 20; ++cont)
            {
                Console.WriteLine("Escriba el número");
                num = Convert.ToInt32(Console.ReadLine());

                acum = num + acum;
            }

            promedio = acum / 20;

            Console.WriteLine("El promedio de los 20 números es: " + promedio);

            Console.ReadKey();
        }
    }
}
