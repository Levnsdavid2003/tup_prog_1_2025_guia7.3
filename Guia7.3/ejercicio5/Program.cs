using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestados, positivos, negativos, indecisos;
            double prcpositivo, prcnegativo, prcindeciso;


            Console.WriteLine("--- Lista de encuestas ---\n");
            Console.WriteLine(@"Ingrese la primer opinión:
    0: Positiva
    1: Negativa
    2: Indeciso
    Otro: Salir");
            int opinion = Convert.ToInt32(Console.ReadLine());
            encuestados = 0;
            positivos = 0;
            negativos = 0;
            indecisos = 0;
            prcpositivo = 0;
            prcnegativo = 0;
            prcindeciso = 0;

            while (opinion >= 0 && opinion <= 2)
            {
                switch (opinion)
                {
                    case 0:
                        positivos++;
                        break;
                    case 1:
                        negativos++;
                        break;
                    case 2:
                        indecisos++;
                        break;
                    default:
                        Console.WriteLine("----- Fin de lista -----\n");
                        break;
                }

                if (opinion >= 0 && opinion <= 2)
                {
                    encuestados++;
                    Console.WriteLine(@"
Ingrese la siguiente opinión:
    0: Positiva
    1: Negativa
    2: Indeciso
    Otro: Salir");
                    opinion = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (encuestados > 0)
            {
                prcpositivo = (positivos * 100) / encuestados;
                prcnegativo = (negativos * 100) / encuestados;
                prcindeciso = (indecisos * 100) / encuestados;
                Console.WriteLine($@"
Resultados:
    - Opiniones: {encuestados}
    - Porcentaje de opiniones positivas: {prcpositivo:f2}%
    - Porcentaje de opiniones negativas: {prcnegativo:f2}%
    - Porcentaje de opiniones indecisas: {prcindeciso:f2}%");
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
            }

            Console.ReadKey();
        }
    }
}
