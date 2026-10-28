
using System;

namespace Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Seleccion_Modo;

            string NombreEquipo1 = "";
            string NameGladiador1 = "";
            string NameGladiador2 = "";
            string NameGladiador3 = "";

            Console.WriteLine("#ELIGE EL MODO QUE VA A USAR#");
            Console.Write("|1| 1V1 -  ");
            Console.Write("|2| 2V2 -  ");
            Console.Write("|3| 3V3 -  ");
            Console.WriteLine("|4| 5V5");

            Console.Write("Respuesta: ");
            Seleccion_Modo = int.Parse(Console.ReadLine());

            string[] Datos = PersonalizacionJugador1(Seleccion_Modo);
            NombreEquipo1 = Datos[0];
            NameGladiador1 = Datos[1];
            NameGladiador2 = Datos[2];
            NameGladiador3 = Datos[3];

            Console.WriteLine("Modo: " + Seleccion_Modo);
            Console.WriteLine("Equipo: " + NombreEquipo1);
            Console.WriteLine("Gladiador 1: " + NameGladiador1);
            Console.WriteLine("Gladiador 2: " + NameGladiador2);
            Console.WriteLine("Gladiador 3: " + NameGladiador3);
        }

        static string[] PersonalizacionJugador1(int Modo)
        {
            string NameEquipo1 = "";
            string NameGladiador1 = "";
            string NameGladiador2 = "";
            string NameGladiador3 = "";

            switch (Modo)
            {
                case 1:
                    Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");

                    Console.Write("Nombre del Equipo: ");
                    NameEquipo1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°1: ");
                    NameGladiador1 = Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");

                    Console.Write("Nombre del Equipo: ");
                    NameEquipo1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°1: ");
                    NameGladiador1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°2: ");
                    NameGladiador2 = Console.ReadLine();

                    break;

                case 3: Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");
                    Console.Write("Nombre del Equipo: ");
                    NameEquipo1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°1: ");
                    NameGladiador1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°2: ");
                    NameGladiador2 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°3: ");
                    NameGladiador3 = Console.ReadLine();

                    break;

                case 4: Console.WriteLine("-- PERSONALIZACION DE EQUIPO JUGADOR 1 --");

                    Console.Write("Nombre del Equipo: ");
                    NameEquipo1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°1: ");
                    NameGladiador1 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°2: ");
                    NameGladiador2 = Console.ReadLine();

                    Console.Write("Nombre del Gladiador N°3: ");
                    NameGladiador3 = Console.ReadLine();

                    Console.Write
                    break;
            }

            string[] Datos = { NameEquipo1, NameGladiador1, NameGladiador2, NameGladiador3};

            return Datos;
        }
    }
}
