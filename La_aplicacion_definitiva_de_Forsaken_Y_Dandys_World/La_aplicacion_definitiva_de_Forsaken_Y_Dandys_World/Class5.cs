using System;
using Microsoft.Data.Sqlite;



public class Personaje
{
    //importanstisimo que sea privada, asi no se modifica accidentalmente
    private string Conexion = @"Data Source=C:\BD\TrackerDB.sqlite";
    private bool encontro;
    private string? comparacionSQL;
    private string? nombreTabla;

    public void CompararEnBD(string p1, string p2, string juego)
    {
        try
        {
            using (var conexion = new SqliteConnection(Conexion))
            {
                conexion.Open();

                // AQUÍ LE DECIMOS QUÉ TABLA USAR DEPENDIENDO DEL JUEGO
                nombreTabla = juego == "FORSAKEN" ? "[Personajes Forsaken]" : "[Personajes Dandy's World]";

                // le puse esto para que busque respuesta de la tabla y puse where y todo eso para que no sea tan stricta, 
                string CompararEnBD = $"SELECT * FROM {nombreTabla} WHERE LOWER(Personajes) = LOWER(@p1) OR LOWER(Personajes) = LOWER(@p2)";
                using (var comando = new SqliteCommand(CompararEnBD, conexion))
                {
                    string strp1 = p1.Trim().ToLower();
                    string strp2 = p2.Trim().ToLower();
                    comando.Parameters.AddWithValue("@p1", strp1);
                    comando.Parameters.AddWithValue("@p2", strp2);

                    using (var lector = comando.ExecuteReader())
                    {
                        {
                            while (lector.Read())
                            {
                                encontro = true;

                                string nombre = lector["Personajes"].ToString()!;
                                string rol = lector["Rol"].ToString()!;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n========================================");
                                Console.WriteLine($" PERSONAJE: {nombre.ToUpper()}");
                                Console.WriteLine($"========================================");
                                Console.ResetColor();
                                Console.WriteLine($" Rol: {rol}");

                                if (juego == "FORSAKEN")
                                {
                                    // === TODAS LAS COLUMNAS DE FORSAKEN ===
                                    Console.WriteLine($" Equipo: {lector["Equipo"]}");
                                    Console.WriteLine($" Dificultad: {lector["Dificultad de Uso"]}");
                                    Console.WriteLine($" Estadísticas: {lector["Estadisticas Generales"]}");
                                    Console.WriteLine($" Pasivas: {lector["Pasivas"]}");
                                    Console.WriteLine($" Ataque Principal: {lector["Ataque Principal"]}");
                                    Console.WriteLine($" Habilidad 1: {lector["Hab. 1"]}");
                                    Console.WriteLine($" Habilidad 2: {lector["Hab. 2"]}");
                                    Console.WriteLine($" Habilidad 3: {lector["Hab. 3"]}");
                                    Console.WriteLine($" Habilidad 4: {lector["Hab. 4"]}");

                                    // Freno para que puedas leer la comparación sin que se cierre
                                    Console.WriteLine("\n¡Comparación finalizada!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    // === TODAS LAS COLUMNAS DEL TOON (DANDY'S WORLD) ===
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\n--- ESTADÍSTICAS DEL TOON ---");
                                    Console.ResetColor();
                                    Console.WriteLine($" Habilidad: {lector["Habilidad"]}");
                                    Console.WriteLine($" Vel. Extracción: {lector["Velocidad de Extraccion"]}");
                                    Console.WriteLine($" Vel. Movimiento: {lector["Velocidad de Movimiento"]}");
                                    Console.WriteLine($" Prueba de Habilidad: {lector["Prueba de Habilidad"]}");
                                    Console.WriteLine($" Stamina: {lector["Stamina"]}");
                                    Console.WriteLine($" Sigilo: {lector["Sigilo"]}");
                                    Console.WriteLine($" Corazones: {lector["Corazon"]}");
                                    Console.WriteLine($" Trinket: {lector["Trinket"]}");
                                }
                                // === TODAS LAS COLUMNAS DEL TWISTED (DANDY'S WORLD) ===
                                string nombreTwisted = lector["Twisteds"].ToString()!;

                                // Verificamos que tenga versión Twisted registrada antes de imprimir
                                if (!string.IsNullOrWhiteSpace(nombreTwisted) && nombreTwisted != "Ninguna")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\n--- VERSIÓN {nombreTwisted.ToUpper()} ---");
                                    Console.ResetColor();
                                    Console.WriteLine($" Tipo: {lector["Tipo"]}");
                                    Console.WriteLine($" Mecánica: {lector["Mecanica"]}");
                                    Console.WriteLine($" Vel. Caminando: {lector["Velocidad Caminando"]}");
                                    Console.WriteLine($" Vel. Corriendo: {lector["Velocidad Corriendo"]}");
                                    Console.WriteLine($" Vel. Modo Pánico: {lector["Velocidad Modo Panico"]}");
                                    Console.WriteLine($" Visión Frontal: {lector["Rango de Vision (Frontal)"]}");
                                    Console.WriteLine($" Visión Circular: {lector["Rango de Vision (Circular)"]}");
                                    Console.WriteLine($" Rango de Oido: {lector["Rango de Oido"]}");
                                    Console.WriteLine($" Tiempo de Atención: {lector["Tiempo de Atencion"]}");

                                    // Freno para que puedas leer la comparación sin que se cierre
                                    Console.WriteLine("\n¡Comparación finalizada!");
                                    Console.ReadLine();
                                }





                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error en la base de datos: " + ex.Message);
            Console.ResetColor();
        }

     
    }

}
