using La_aplicacion_definitiva_de_Forsaken_Y_Dandys_World;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Partida
{
    public string Juego { get; set; } = "";
    public string PersonajeUsado { get; set; } = "";
    public string Resultado { get; set; } = "";
    public int PisoORonda { get; set; }
    public string CausaMuerte { get; set; } = "";
    public string Tiempo_Sobrevivido { get; set; } = "";
    public int Generadores_Reparados { get; set; } = 0;

    public virtual void PedirDatos() { }
}

public class PartidaDW : Partida
{
    public PartidaDW()
    {
        Juego = "Dandy's World";
    }

    // Polimorfismo: sobreescribimos el método para Dandy's World

    public override void PedirDatos()
    {
        Console.Clear();
        Console.WriteLine("=== REGISTRAR PARTIDA DE DANDY'S WORLD ===");

        Console.Write("¿Qué Toon / Personaje usaste? ");
        PersonajeUsado = Console.ReadLine()!;

        while (string.IsNullOrWhiteSpace(PersonajeUsado) || !PersonajeUsado.Any(char.IsLetter))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: no deje vacia las casillas ni ingrese caracteres o numeros extraños, Por favor ingrese el nombre del personaje usado");
            Console.ResetColor();
            // lo ponemos para que lo lea y no haya un bucle infinito
            PersonajeUsado = Console.ReadLine()!;
        }

        Console.Write("¿A qué Piso llegaste? (solo número): ");
        int Piso_Ingresado;

        while (!int.TryParse(Console.ReadLine(), out Piso_Ingresado) || Piso_Ingresado <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Ingresa un número válido entre 1 y 24. No se aceptan 0, negativos ni símbolos.");
            Console.ResetColor();
            // Volvemos a pedir el dato para evitar el bucle infinito
            Console.Write("Intente nuevamente (solo número): ");
        }

        // Asignamos el valor YA validado a la variable de la base de datos
        PisoORonda = Piso_Ingresado;

        Console.Write("¿Causa de muerte / Twisted que te eliminó? ");
        CausaMuerte = Console.ReadLine()!;

        // Corregido: ahora evalúa CausaMuerte, no PersonajeUsado
        while (string.IsNullOrWhiteSpace(CausaMuerte) || !CausaMuerte.Any(char.IsLetter))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: no deje vacia las casillas, Por favor ingrese la causa de muerte o que twisted lo mato");
            Console.ResetColor();
            // Volvemos a pedir el dato para evitar el bucle infinito
            Console.Write("¿Causa de muerte / Twisted que te eliminó? ");
            CausaMuerte = Console.ReadLine()!;
        }

        Resultado = "Eliminado";
    }
}
