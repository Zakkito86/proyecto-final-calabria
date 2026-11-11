using System;

namespace GladiadoresDeConsola
{
    class Program
    {
        // Constantes: valores de las reglas que no cambian durante la partida.
        const int PUNTOS_TOTALES = 40;
        const int VIDA_MINIMA = 10;
        const int VIDA_MAXIMA = 25;
        const int ATAQUE_MINIMO = 5;
        const int ATAQUE_MAXIMO = 20;
        const int DEFENSA_MINIMA = 1;
        const int DEFENSA_MAXIMA = 10;
        const int PUNTOS_RECUPERACION = 5;
        const int MAX_RECUPERACIONES = 2;

        static void Main(string[] args)
        {
            int modalidad;

            // Primero se pregunta qué modalidad quiere jugar el usuario.
            modalidad = ElegirModalidad();

            // Cada opción llama a una función diferente.
            if (modalidad == 1)
            {
                Modo1vs1();
            }
            else if (modalidad == 2)
            {
                Modo2vs2();
            }
            else if (modalidad == 3)
            {
                Modo3vs3();
            }
            else if (modalidad == 5)
            {
                Modo5vs5();
            }
        }

        // Pide una modalidad y no continúa hasta recibir una opción permitida.
        static int ElegirModalidad()
        {
            int modalidad = 0;

            while (modalidad != 1 && modalidad != 2 && modalidad != 3 && modalidad != 5)
            {
                Console.WriteLine("===== GLADIADORES DE CONSOLA =====");
                Console.WriteLine("Elegí la modalidad:");
                Console.WriteLine("1. 1 vs 1");
                Console.WriteLine("2. 2 vs 2");
                Console.WriteLine("3. 3 vs 3");
                Console.WriteLine("5. 5 vs 5");
                Console.Write("Opcion: ");

                modalidad = int.Parse(Console.ReadLine());

                if (modalidad != 1 && modalidad != 2 && modalidad != 3 && modalidad != 5)
                {
                    Console.WriteLine("Modalidad incorrecta. Volve a intentarlo.");
                }
            }

            return modalidad;
        }

        // Cada modalidad tiene su propia función y crea arreglos del tamaño correspondiente.
        static void Modo1vs1()
        {
            int cantidad = 1;

            string[] nombres1 = new string[cantidad];
            int[] vidas1 = new int[cantidad];
            int[] vidasMaximas1 = new int[cantidad];
            int[] ataques1 = new int[cantidad];
            int[] defensas1 = new int[cantidad];
            int[] danos1 = new int[cantidad];
            int[] recuperaciones1 = new int[cantidad];

            string[] nombres2 = new string[cantidad];
            int[] vidas2 = new int[cantidad];
            int[] vidasMaximas2 = new int[cantidad];
            int[] ataques2 = new int[cantidad];
            int[] defensas2 = new int[cantidad];
            int[] danos2 = new int[cantidad];
            int[] recuperaciones2 = new int[cantidad];

            IniciarPartida(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2);
        }

        // Prepara los arreglos necesarios para una partida de dos contra dos.
        static void Modo2vs2()
        {
            int cantidad = 2;

            string[] nombres1 = new string[cantidad];
            int[] vidas1 = new int[cantidad];
            int[] vidasMaximas1 = new int[cantidad];
            int[] ataques1 = new int[cantidad];
            int[] defensas1 = new int[cantidad];
            int[] danos1 = new int[cantidad];
            int[] recuperaciones1 = new int[cantidad];

            string[] nombres2 = new string[cantidad];
            int[] vidas2 = new int[cantidad];
            int[] vidasMaximas2 = new int[cantidad];
            int[] ataques2 = new int[cantidad];
            int[] defensas2 = new int[cantidad];
            int[] danos2 = new int[cantidad];
            int[] recuperaciones2 = new int[cantidad];

            IniciarPartida(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2);
        }

        // Prepara los arreglos necesarios para una partida de tres contra tres.
        static void Modo3vs3()
        {
            int cantidad = 3;

            string[] nombres1 = new string[cantidad];
            int[] vidas1 = new int[cantidad];
            int[] vidasMaximas1 = new int[cantidad];
            int[] ataques1 = new int[cantidad];
            int[] defensas1 = new int[cantidad];
            int[] danos1 = new int[cantidad];
            int[] recuperaciones1 = new int[cantidad];

            string[] nombres2 = new string[cantidad];
            int[] vidas2 = new int[cantidad];
            int[] vidasMaximas2 = new int[cantidad];
            int[] ataques2 = new int[cantidad];
            int[] defensas2 = new int[cantidad];
            int[] danos2 = new int[cantidad];
            int[] recuperaciones2 = new int[cantidad];

            IniciarPartida(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2);
        }

        // Prepara los arreglos necesarios para una partida de cinco contra cinco.
        static void Modo5vs5()
        {
            int cantidad = 5;

            string[] nombres1 = new string[cantidad];
            int[] vidas1 = new int[cantidad];
            int[] vidasMaximas1 = new int[cantidad];
            int[] ataques1 = new int[cantidad];
            int[] defensas1 = new int[cantidad];
            int[] danos1 = new int[cantidad];
            int[] recuperaciones1 = new int[cantidad];

            string[] nombres2 = new string[cantidad];
            int[] vidas2 = new int[cantidad];
            int[] vidasMaximas2 = new int[cantidad];
            int[] ataques2 = new int[cantidad];
            int[] defensas2 = new int[cantidad];
            int[] danos2 = new int[cantidad];
            int[] recuperaciones2 = new int[cantidad];

            IniciarPartida(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2);
        }

        // Esta función prepara los dos equipos y después comienza el combate.
        // La cantidad llega desde la función del modo elegido.
        static void IniciarPartida(int cantidad,
            string[] nombres1, int[] vidas1, int[] vidasMaximas1, int[] ataques1, int[] defensas1, int[] danos1, int[] recuperaciones1,
            string[] nombres2, int[] vidas2, int[] vidasMaximas2, int[] ataques2, int[] defensas2, int[] danos2, int[] recuperaciones2)
        {
            string equipo1;
            string equipo2;

            Console.WriteLine();
            Console.WriteLine("===== CREACION DE LOS EQUIPOS =====");

            // Primero el Jugador 1 elige el nombre y crea todos sus gladiadores.
            equipo1 = PedirNombreEquipo("Jugador 1");

            Console.WriteLine();
            Console.WriteLine("Jugador 1: " + equipo1);
            CrearEquipo(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1, nombres2);

            // Cuando termina el Jugador 1, el Jugador 2 crea su propio equipo.
            equipo2 = PedirNombreEquipo("Jugador 2");

            Console.WriteLine();
            Console.WriteLine("Jugador 2: " + equipo2);
            CrearEquipo(cantidad, nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2, nombres1);

            JugarCombate(cantidad, equipo1, equipo2,
                nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1, recuperaciones1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2, recuperaciones2);
        }

        // Comprueba que el nombre del equipo no esté vacío ni tenga solamente espacios.
        static string PedirNombreEquipo(string jugador)
        {
            string nombre = "";

            while (NombreVacio(nombre) == 1)
            {
                Console.Write(jugador + ", escribi el nombre de tu equipo: ");
                nombre = Console.ReadLine();

                if (NombreVacio(nombre) == 1)
                {
                    Console.WriteLine("El nombre no puede quedar vacio.");
                }
            }

            return nombre;
        }

        // Devuelve 1 si el texto está vacío o tiene solamente espacios.
        // Devuelve 0 si tiene por lo menos un carácter que no sea un espacio.
        static int NombreVacio(string nombre)
        {
            int i;

            if (nombre == "")
            {
                return 1;
            }

            for (i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != ' ')
                {
                    return 0;
                }
            }

            return 1;
        }

        // Carga todos los gladiadores de un equipo.
        // nombresOtro permite comprobar que tampoco se repitan con el otro equipo.
        static void CrearEquipo(int cantidad, string[] nombres, int[] vidas, int[] vidasMaximas,
            int[] ataques, int[] defensas, int[] danos, int[] recuperaciones, string[] nombresOtro)
        {
            int i;
            int suma;

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Gladiador " + (i + 1));

                nombres[i] = PedirNombreGladiador(nombres, nombresOtro, i);

                // Se vuelven a pedir los tres atributos si la suma no da exactamente 40.
                suma = 0;

                while (suma != PUNTOS_TOTALES)
                {
                    Console.WriteLine("Tenes que repartir exactamente " + PUNTOS_TOTALES + " puntos.");

                    vidas[i] = PedirValor("Vida", VIDA_MINIMA, VIDA_MAXIMA);
                    ataques[i] = PedirValor("Ataque", ATAQUE_MINIMO, ATAQUE_MAXIMO);
                    defensas[i] = PedirValor("Defensa", DEFENSA_MINIMA, DEFENSA_MAXIMA);

                    suma = vidas[i] + ataques[i] + defensas[i];

                    if (suma != PUNTOS_TOTALES)
                    {
                        Console.WriteLine("Usaste " + suma + " puntos. La suma tiene que ser " + PUNTOS_TOTALES + ".");
                        Console.WriteLine("Volve a repartir los tres atributos.");
                    }
                }

                // La vida máxima queda guardada y no cambia durante el combate.
                vidasMaximas[i] = vidas[i];

                // Todos empiezan sin daño causado y sin recuperaciones utilizadas.
                danos[i] = 0;
                recuperaciones[i] = 0;
            }
        }

        // Pide un nombre que no esté vacío y que no se haya usado en la partida.
        static string PedirNombreGladiador(string[] nombres, string[] nombresOtro, int posicion)
        {
            string nombre = "";
            int repetido = 0;

            while (NombreVacio(nombre) == 1 || repetido == 1)
            {
                Console.Write("Nombre del gladiador: ");
                nombre = Console.ReadLine();

                repetido = 0;

                if (NombreVacio(nombre) == 1)
                {
                    Console.WriteLine("El nombre no puede estar vacio ni tener solamente espacios.");
                    repetido = 1;
                }
                else
                {
                    repetido = NombreRepetido(nombre, nombres, nombresOtro, posicion);

                    if (repetido == 1)
                    {
                        Console.WriteLine("Ese nombre ya fue utilizado. Elegi otro.");
                    }
                }
            }

            return nombre;
        }

        // Revisa los nombres anteriores del mismo equipo y todos los del otro equipo.
        static int NombreRepetido(string nombre, string[] nombres, string[] nombresOtro, int posicion)
        {
            int i;

            for (i = 0; i < posicion; i++)
            {
                if (nombres[i] == nombre)
                {
                    return 1;
                }
            }

            for (i = 0; i < nombresOtro.Length; i++)
            {
                if (nombresOtro[i] == nombre)
                {
                    return 1;
                }
            }

            return 0;
        }

        // Pide un atributo y controla que esté dentro del mínimo y el máximo.
        static int PedirValor(string atributo, int minimo, int maximo)
        {
            int valor = minimo - 1;

            while (valor < minimo || valor > maximo)
            {
                Console.Write(atributo + " (" + minimo + " a " + maximo + "): ");
                valor = int.Parse(Console.ReadLine());

                if (valor < minimo || valor > maximo)
                {
                    Console.WriteLine("Valor incorrecto. Volve a intentarlo.");
                }
            }

            return valor;
        }

        // Ejecuta los turnos alternados hasta que uno de los equipos se quede sin gladiadores.
        static void JugarCombate(int cantidad, string equipo1, string equipo2,
            string[] nombres1, int[] vidas1, int[] vidasMaximas1, int[] ataques1, int[] defensas1, int[] danos1, int[] recuperaciones1,
            string[] nombres2, int[] vidas2, int[] vidasMaximas2, int[] ataques2, int[] defensas2, int[] danos2, int[] recuperaciones2)
        {
            int turno = 1;

            while (EquipoDerrotado(cantidad, vidas1) == 0 && EquipoDerrotado(cantidad, vidas2) == 0)
            {
                // Turno del Jugador 1.
                Console.WriteLine();
                Console.WriteLine("========== TURNO " + turno + " ==========");
                MostrarEstado(cantidad, equipo1, nombres1, vidas1, vidasMaximas1);
                MostrarEstado(cantidad, equipo2, nombres2, vidas2, vidasMaximas2);
                Console.WriteLine("Juega " + equipo1 + " (Jugador 1)");

                RealizarTurno(cantidad, nombres1, vidas1, vidasMaximas1, ataques1, nombres2, vidas2, defensas2, danos1, recuperaciones1);
                turno++;

                // Si el Jugador 1 eliminó al otro equipo, no se le da otro turno.
                if (EquipoDerrotado(cantidad, vidas2) == 0)
                {
                    // Turno del Jugador 2.
                    Console.WriteLine();
                    Console.WriteLine("========== TURNO " + turno + " ==========");
                    MostrarEstado(cantidad, equipo1, nombres1, vidas1, vidasMaximas1);
                    MostrarEstado(cantidad, equipo2, nombres2, vidas2, vidasMaximas2);
                    Console.WriteLine("Juega " + equipo2 + " (Jugador 2)");

                    RealizarTurno(cantidad, nombres2, vidas2, vidasMaximas2, ataques2, nombres1, vidas1, defensas1, danos2, recuperaciones2);
                    turno++;
                }
            }

            // Al terminar, se muestra el equipo ganador y las estadísticas.
            Console.WriteLine();
            Console.WriteLine("========== FIN DEL TORNEO ==========");

            if (EquipoDerrotado(cantidad, vidas1) == 1)
            {
                Console.WriteLine("Gana " + equipo2 + " (Jugador 2) en " + (turno - 1) + " turnos.");
                MostrarReporte(cantidad, equipo1, equipo2, 2,
                    nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1,
                    nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2);
            }
            else
            {
                Console.WriteLine("Gana " + equipo1 + " (Jugador 1) en " + (turno - 1) + " turnos.");
                MostrarReporte(cantidad, equipo1, equipo2, 1,
                    nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1,
                    nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2);
            }
        }

        // Muestra la vida actual y máxima de todos los gladiadores de un equipo.
        static void MostrarEstado(int cantidad, string equipo, string[] nombres, int[] vidas, int[] vidasMaximas)
        {
            int i;

            Console.WriteLine();
            Console.WriteLine("[" + equipo + "]");

            for (i = 0; i < cantidad; i++)
            {
                Console.Write((i + 1) + ". " + nombres[i] + " Vida " + vidas[i] + "/" + vidasMaximas[i]);

                if (vidas[i] == 0)
                {
                    Console.Write(" (fuera de combate)");
                }

                Console.WriteLine();
            }
        }

        // Devuelve 1 si todos los gladiadores están fuera de combate.
        static int EquipoDerrotado(int cantidad, int[] vidas)
        {
            int i;
            int enPie = 0;

            for (i = 0; i < cantidad; i++)
            {
                if (vidas[i] > 0)
                {
                    enPie++;
                }
            }

            if (enPie == 0)
            {
                return 1;
            }

            return 0;
        }

        // Permite elegir y realizar una acción. Si una recuperación no se puede hacer,
        // vuelve a mostrar las acciones y el jugador no pierde el turno.
        static void RealizarTurno(int cantidad, string[] nombresPropios, int[] vidasPropias, int[] vidasMaximasPropias, int[] ataquesPropios,
            string[] nombresRivales, int[] vidasRivales, int[] defensasRivales, int[] danosPropios, int[] recuperacionesPropias)
        {
            int accion = 0;
            int atacante;
            int defensor;
            int elegido;
            int resultado = 0;

            // Si la recuperación no se puede realizar, accion vuelve a 0
            // y se muestran nuevamente las dos opciones.
            while (accion != 1 && accion != 2)
            {
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Recuperarse");
                Console.Write("Elegí una accion: ");
                accion = int.Parse(Console.ReadLine());

                if (accion != 1 && accion != 2)
                {
                    Console.WriteLine("Accion incorrecta.");
                }
                else if (accion == 1)
                {
                    // Se elige un atacante propio que siga en pie.
                    atacante = ElegirGladiador(cantidad, nombresPropios, vidasPropias, "Tu gladiador que ataca");

                    // Se elige un rival que también siga en pie.
                    defensor = ElegirGladiador(cantidad, nombresRivales, vidasRivales, "Gladiador rival que recibe");

                    Atacar(atacante, defensor, nombresPropios, ataquesPropios, danosPropios,
                        nombresRivales, vidasRivales, defensasRivales);
                }
                else
                {
                    elegido = ElegirGladiador(cantidad, nombresPropios, vidasPropias, "Tu gladiador que se recupera");

                    resultado = Recuperar(elegido, nombresPropios, vidasPropias, recuperacionesPropias, vidasMaximasPropias);

                    if (resultado == 0)
                    {
                        // No se termina el turno: se vuelve a pedir una acción.
                        accion = 0;
                    }
                }
            }
        }

        // Pide el número de un gladiador que exista y tenga vida mayor a cero.
        static int ElegirGladiador(int cantidad, string[] nombres, int[] vidas, string mensaje)
        {
            int numero = 0;

            while (numero < 1 || numero > cantidad || vidas[numero - 1] == 0)
            {
                Console.Write(mensaje + " (numero): ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > cantidad)
                {
                    Console.WriteLine("Ese numero no existe.");
                }
                else if (vidas[numero - 1] == 0)
                {
                    Console.WriteLine(nombres[numero - 1] + " esta fuera de combate. Elegi otro.");
                }
            }

            return numero - 1;
        }

        // Calcula el daño, resta la vida y suma solamente el daño real al atacante.
        static void Atacar(int atacante, int defensor, string[] nombresAtacantes, int[] ataques, int[] danos,
            string[] nombresDefensores, int[] vidasDefensores, int[] defensas)
        {
            int dano;
            int danoReal;

            dano = ataques[atacante] - defensas[defensor];

            if (dano < 1)
            {
                dano = 1;
            }

            danoReal = dano;

            // El daño real no puede ser mayor que la vida que le queda al defensor.
            if (danoReal > vidasDefensores[defensor])
            {
                danoReal = vidasDefensores[defensor];
            }

            vidasDefensores[defensor] = vidasDefensores[defensor] - danoReal;
            danos[atacante] = danos[atacante] + danoReal;

            Console.WriteLine(nombresAtacantes[atacante] + " golpea a " + nombresDefensores[defensor] +
                " y le quita " + danoReal + " de vida.");

            if (vidasDefensores[defensor] == 0)
            {
                Console.WriteLine(nombresDefensores[defensor] + " queda fuera de combate.");
            }
            else
            {
                Console.WriteLine(nombresDefensores[defensor] + " queda con " + vidasDefensores[defensor] + " de vida.");
            }
        }

        // Recupera 5 puntos, sin superar la vida máxima propia del gladiador y con un máximo de dos usos.
        // Devuelve 1 si pudo recuperarse y 0 si no pudo.
        static int Recuperar(int elegido, string[] nombres, int[] vidas, int[] recuperaciones, int[] vidasMaximas)
        {
            int vidaAnterior;
            int cantidadRecuperada;

            if (recuperaciones[elegido] >= MAX_RECUPERACIONES)
            {
                Console.WriteLine(nombres[elegido] + " ya uso sus dos recuperaciones.");
                return 0;
            }

            if (vidas[elegido] == 0)
            {
                Console.WriteLine("No puede recuperarse porque esta fuera de combate.");
                return 0;
            }

            vidaAnterior = vidas[elegido];
            vidas[elegido] = vidas[elegido] + PUNTOS_RECUPERACION;

            if (vidas[elegido] > vidasMaximas[elegido])
            {
                vidas[elegido] = vidasMaximas[elegido];
            }

            cantidadRecuperada = vidas[elegido] - vidaAnterior;

            if (cantidadRecuperada == 0)
            {
                Console.WriteLine(nombres[elegido] + " ya tiene la vida completa.");
                return 0;
            }

            recuperaciones[elegido]++;
            Console.WriteLine(nombres[elegido] + " recupera " + cantidadRecuperada + " puntos de vida.");
            return 1;
        }

        // Busca el daño más alto entre todos los gladiadores y muestra todos los empatados.
        // También calcula el promedio de vida del equipo ganador y muestra la tabla final.
        static void MostrarReporte(int cantidad, string equipo1, string equipo2, int ganador,
            string[] nombres1, int[] vidas1, int[] vidasMaximas1, int[] ataques1, int[] defensas1, int[] danos1,
            string[] nombres2, int[] vidas2, int[] vidasMaximas2, int[] ataques2, int[] defensas2, int[] danos2)
        {
            int mayorDano = 0;
            int i;
            int sumaVida = 0;
            int sobrevivientes = 0;
            double promedio;
            string equipoGanador;

            for (i = 0; i < cantidad; i++)
            {
                if (danos1[i] > mayorDano)
                {
                    mayorDano = danos1[i];
                }

                if (danos2[i] > mayorDano)
                {
                    mayorDano = danos2[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("MVP DEL TORNEO (" + mayorDano + " de daño):");

            for (i = 0; i < cantidad; i++)
            {
                if (danos1[i] == mayorDano)
                {
                    Console.WriteLine(nombres1[i] + " - " + danos1[i] + " de daño");
                }
            }

            for (i = 0; i < cantidad; i++)
            {
                if (danos2[i] == mayorDano)
                {
                    Console.WriteLine(nombres2[i] + " - " + danos2[i] + " de daño");
                }
            }

            // El promedio se calcula solamente con las vidas del equipo ganador.
            if (ganador == 1)
            {
                equipoGanador = equipo1;

                for (i = 0; i < cantidad; i++)
                {
                    sumaVida = sumaVida + vidas1[i];

                    if (vidas1[i] > 0)
                    {
                        sobrevivientes++;
                    }
                }
            }
            else
            {
                equipoGanador = equipo2;

                for (i = 0; i < cantidad; i++)
                {
                    sumaVida = sumaVida + vidas2[i];

                    if (vidas2[i] > 0)
                    {
                        sobrevivientes++;
                    }
                }
            }

            promedio = (double)sumaVida / cantidad;

            Console.WriteLine();
            Console.WriteLine("Promedio de vida restante de " + equipoGanador + ": " + promedio.ToString("F2"));
            Console.WriteLine("Sobrevivientes: " + sobrevivientes + " de " + cantidad);

            Console.WriteLine();
            Console.WriteLine("========== TABLA FINAL ==========");
            Console.WriteLine("EQUIPO | GLADIADOR | VIDA | ATQ | DEF | DANIO | ESTADO");

            MostrarTabla(cantidad, equipo1, equipo2, nombres1, vidas1, vidasMaximas1, ataques1, defensas1, danos1,
                nombres2, vidas2, vidasMaximas2, ataques2, defensas2, danos2);
        }

        // Muestra los datos finales de todos los gladiadores de los dos equipos.
        static void MostrarTabla(int cantidad, string equipo1, string equipo2,
            string[] nombres1, int[] vidas1, int[] vidasMaximas1, int[] ataques1, int[] defensas1, int[] danos1,
            string[] nombres2, int[] vidas2, int[] vidasMaximas2, int[] ataques2, int[] defensas2, int[] danos2)
        {
            int i;

            for (i = 0; i < cantidad; i++)
            {
                MostrarFila(equipo1, nombres1[i], vidas1[i], vidasMaximas1[i],
                    ataques1[i], defensas1[i], danos1[i]);
            }

            for (i = 0; i < cantidad; i++)
            {
                MostrarFila(equipo2, nombres2[i], vidas2[i], vidasMaximas2[i],
                    ataques2[i], defensas2[i], danos2[i]);
            }
        }

        // Imprime una fila de la tabla final.
        static void MostrarFila(string nombreEquipo, string nombre,
            int vida, int vidaMaxima, int ataque, int defensa, int dano)
        {
            string estado;

            if (vida == 0)
            {
                estado = "Fuera de combate";
            }
            else
            {
                estado = "En pie";
            }

            Console.WriteLine(nombreEquipo + " | " + nombre + " | " + vida + "/" + vidaMaxima +
                " | " + ataque + " | " + defensa + " | " + dano + " | " + estado);
        }
    }
}
