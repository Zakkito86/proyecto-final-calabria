using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int cantTurnos()
        {
            int cantVueltas = 0;
            int cantGlad = 0;

             do
            {
                Console.WriteLine("ingrese cuantos gladiadores quedan");
                cantGlad = int.Parse(Console.ReadLine());
                if (cantGlad != 0)
                { cantVueltas++;
                    Console.WriteLine("todavia quedan gladiadores, esto no ha acabado");
                    Console.WriteLine(" vamos por la oleada n° " + cantVueltas);
                }

            } while (cantGlad != 0);
            return cantVueltas;
        }
        static void Main(string[] args)
        {
        Console.WriteLine("la cantidad total de turnos de la batalla fue: {0}", cantTurnos());
        }
    }
}
