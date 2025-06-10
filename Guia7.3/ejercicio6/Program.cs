using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubro, crubro1, crubro2, crubro3, crubro4, crubro5;
            int venta, mayorventa, productos;
            double monto, mayorMonto, recaudTotal;
            double prcrubro1, prcrubro2, prcrubro3, prcrubro4, prcrubro5;

            venta = 0;
            mayorventa = 0;
            mayorMonto = 0;
            recaudTotal = 0;

            Console.WriteLine("Cantidad de Ventas por Rubro:");
            Console.WriteLine(@"
    Ingrese el n° de rubro (de 1 a 5):
    -1 para Salir
    ");
            rubro = Convert.ToInt32(Console.ReadLine());

            crubro1 = 0;
            crubro2 = 0;
            crubro3 = 0;
            crubro4 = 0;
            crubro5 = 0;
            prcrubro1 = 0;
            prcrubro2 = 0;
            prcrubro3 = 0;
            prcrubro4 = 0;
            prcrubro5 = 0;

            while (rubro != -1)
            {
                switch (rubro)
                {
                    case 1:
                        crubro1++; break;
                    case 2:
                        crubro2++; break;
                    case 3:
                        crubro3++; break;
                    case 4:
                        crubro4++; break;
                    case 5:
                        crubro5++; break;
                    default:
                        Console.WriteLine($"'{rubro}' no es un comando válido.");
                        break;
                }

                if (rubro >= 1 && rubro <= 5)
                {
                    venta++;
                    Console.WriteLine("Escriba la cantidad de productos vendidos:");
                    productos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escriba el monto total de los productos:");
                    monto = Convert.ToDouble(Console.ReadLine());

                    recaudTotal += monto;

                    if (monto > mayorMonto)
                    {
                        mayorMonto = monto;
                        mayorventa = venta;
                    }
                }

                Console.WriteLine(@"
    Ingrese el n° de rubro (de 1 a 5):
    -1 para Salir
    ");
                rubro = Convert.ToInt32(Console.ReadLine());
            }

            if (venta > 0)
            {
                prcrubro1 = (crubro1 / venta) * 100;
                prcrubro2 = (crubro2 / venta) * 100;
                prcrubro3 = (crubro3 / venta) * 100;
                prcrubro4 = (crubro4 / venta) * 100;
                prcrubro5 = (crubro5 / venta) * 100;

                Console.WriteLine($@"
Resultados de ventas:
    Porcentaje de: 
        Rubro 1 - {prcrubro1:f2}%
        Rubro 2 - {prcrubro2:f2}%
        Rubro 3 - {prcrubro3:f2}%
        Rubro 4 - {prcrubro4:f2}%
        Rubro 5 - {prcrubro5:f2}%
    Número de venta con mayor monto total:
        Venta {mayorventa} con ${mayorMonto}
    Recaudo total:
        ${recaudTotal}");
            }
            else
            {
                Console.WriteLine("No hubo ninguna venta registrada.");
            }
            Console.ReadKey();
        }
    }
}
