using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grupo, mayorGrupo, menorGrupo;
            int fila, valor, acumValor;
            double promedio, mayorPromedio, menorPromedio;
            grupo = 0;
            mayorGrupo = 0;
            menorGrupo = 0;
            mayorPromedio = 0;
            menorPromedio = 0;


            Console.WriteLine("\tIngreso de valores de 4 Grupos:");

            for (grupo = 1; grupo <= 4; grupo++)
            {
                Console.WriteLine($@"
Grupo {grupo}:
    Ingrese 6 valores:");
                acumValor = 0;

                for (fila = 1; fila <= 6; fila++)
                {
                    valor = Convert.ToInt32(Console.ReadLine());
                    acumValor += valor;
                }

                promedio = acumValor / 6.0;

                if (mayorPromedio < promedio || grupo == 1)
                {
                    mayorGrupo = grupo;
                    mayorPromedio = promedio;
                }
                if (menorPromedio > promedio || grupo == 1)
                {
                    menorGrupo = grupo;
                    menorPromedio = promedio;
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Mayor promedio: Grupo {mayorGrupo} con promedio de {mayorPromedio:f2}");
            Console.WriteLine($"Menor promedio: Grupo {menorGrupo} con promedio de {menorPromedio:f2}");
            Console.ReadKey();
        }
    }
}
