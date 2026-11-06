using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace La_aplicacion_definitiva_de_Forsaken_Y_Dandys_World
{
    public class Partida
    {
        public string Juego { get; set; } = "";
        public string PersonajeUsado { get; set; } = "";
        public string Resultado { get; set; } = "";
        public int PisoORonda { get; set; }
        public string CausaMuerte { get; set; } = "";
        public string Tiempo_Sobrevivido { get; set; } = "";
        public int Generadores_Reparados { get; set; }

        public virtual void PedirDatos() { }
    }

    public class PartidaForsaken : Partida
    {
        public PartidaForsaken()
        {
            Juego = "Forsaken";
        }

        public override void PedirDatos()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTRAR PARTIDA DE FORSAKEN ===");

            Console.Write("¿Qué personaje usaste?");
            PersonajeUsado = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(PersonajeUsado) || !PersonajeUsado.Any(char.IsLetter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No deje la casilla vacía.");
                Console.ResetColor();
                Console.Write("¿Qué personaje usaste?: ");
                PersonajeUsado = Console.ReadLine()!;
            }

            Console.Write("¿A qué Ronda llegaste? (solo número): ");
            int ronda;

            while (!int.TryParse(Console.ReadLine(), out ronda) || ronda <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No se aceptan 0, negativos ni símbolos.");
                Console.ResetColor();
                // Volvemos a pedir el dato para evitar el bucle infinito
                Console.Write("Intente nuevamente (solo número): ");
            }
            PisoORonda = ronda;

            Console.Write("¿Resultado de la partida? (Sobrevivió / Eliminado): ");
            Resultado = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(Resultado) || !Resultado.Any(char.IsLetter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un resultado válido.");
                Console.ResetColor();
                Console.Write("¿Resultado de la partida?: ");
                Resultado = Console.ReadLine()!;
            }

            Console.Write("¿Causa de muerte / Killer que te mató? (poné 'Ninguna' si sobreviviste): ");
            CausaMuerte = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(CausaMuerte))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No deje la casilla vacía.");
                Console.ResetColor();
                Console.Write("¿Causa de muerte?: ");
                CausaMuerte = Console.ReadLine()!;
            }

            Console.Write("¿Cuánto tiempo sobrevivió/duro? ");
            Tiempo_Sobrevivido = Console.ReadLine()!;
            while (!int.TryParse(Console.ReadLine(), out ronda) || ronda < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un número válido.");
                Console.ResetColor();
                Console.Write("¿Cuánto tiempo sobrevivió/duro?(solo numero)");
            }
            Console.Write("¿Cuántos generadores pudo reparar? (solo número): ");

            int generadores;

            while (!int.TryParse(Console.ReadLine(), out generadores) || generadores < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese un número válido.");
                Console.ResetColor();
                Console.Write("¿Cuántos generadores pudo reparar? (solo número): ");
            }

            // Guardamos el número validado como texto en la propiedad
            Generadores_Reparados = generadores;


        }
    }


}