using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Seleccion_Modo;
            /*Variables Jugador 1*/

            string NameEquipo1 = "";
            string NameGladiador1 = "";
            string NameGladiador2 = "";
           


            /*Variables Jugadr 2*/
            Console.WriteLine("#ELIGE EL MODO QUE VA A USAR#");
            Console.Write("|1| 1V1 -  ");
            Console.Write("|2| 2V2 -  ");
            Console.Write("|3| 3V3 -  ");
            Console.WriteLine("|4| 5V5   ");
            Console.Write("Respuesta:");
            Seleccion_Modo = int.Parse(Console.ReadLine());

            PersonalizacionJugador1(NameEquipo1,NameGladiador1, NameGladiador2, Seleccion_Modo);

            Console.WriteLine($"{Seleccion_Modo} - {NameEquipo1} - {NameGladiador1} - {NameGladiador2}");
        }
        static void PersonalizacionJugador1(string NameEquipo1, string NameGladiador1, string NameGladiador2, int Modo)
        {
            switch (Modo)
            {
                case 1:
                    Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");

                    if (Modo == 1)
                    {
                        Console.Write("Nombre del Equipo: ");
                        NameEquipo1 = Console.ReadLine();

                        Console.Write($"Nombre del Gladiador N°{Modo}: ");
                        NameGladiador1 = Console.ReadLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");

                    if (Modo == 2)
                    {
                        Console.Write("Nombre del Equipo: ");
                        NameEquipo1 = Console.ReadLine();

                        Console.Write("Nombre del Gladiador N°1: ");
                        NameGladiador1 = Console.ReadLine();
                        Console.Write("Nombre del Gladiador N°2: ");
                        NameGladiador2 = Console.ReadLine();

                    }
                    break;
            }
        }
    }
}





parte de oli
class Program
    {
        static void Main(string[] args)
        {
            int Seleccion_Modo;

            string nombvreequipo1 = "";
            string nombredeGladiador1 = "";
            string nombredeGladiador2 = "";

            Console.WriteLine("ELIGE EL MODO");
            Console.WriteLine("1 - 1V1");
            Console.WriteLine("2 - 2V2");
            Console.WriteLine("3 - 3V3");
            Console.WriteLine("4 - 5V5");
            Console.Write("Respuesta: ");

            Seleccion_Modo = int.Parse(Console.ReadLine());

            Console.WriteLine("PERSONALIZACION JUGADOR 1");

            Console.Write("nombre del equipo: ");
            nombvreequipo1 = Console.ReadLine();

            Console.Write("nombre del Gladiador 1: ");
            nombredeGladiador1 = Console.ReadLine();

            if (Seleccion_Modo >= 2)
            {
                Console.Write("nombre del Gladiador 2: ");
                nombredeGladiador2 = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("eqyuipo: " + nombvreequipo1);
            Console.WriteLine("Gladiador 1: " + nombredeGladiador1);

            if (Seleccion_Modo >= 2)
            {
                Console.WriteLine("Gladiador 2: " +  nombredeGladiador2);
            }
        }
    }
}
