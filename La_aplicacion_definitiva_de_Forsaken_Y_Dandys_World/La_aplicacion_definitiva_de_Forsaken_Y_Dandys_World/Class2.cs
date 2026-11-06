using La_aplicacion_definitiva_de_Forsaken_Y_Dandys_World;
using Microsoft.Data.Sqlite;
using System;

public class BaseDatos
{
    //importanstisimo que sea privada, asi no se modifica accidentalmente
    //tuve que ser mas especifica para evitar crasheos o problemas de bloqueo al intentar guardar la informacion de registro de partida
    //cambie la ruta del archivo para que no se bloquee
    private string Conexion = @"Data Source=C:\BD\TrackerDB.sqlite";

    public string BuscarTactica(string busquedaUsuario, string tablaJuego)
    {
        try
        {
            using (var conexion = new SqliteConnection(Conexion))
            {
                conexion.Open();

                // le puse esto para que busque respuesta de la tabla y puse where y todo eso para que no sea tan stricta, 
                string consultaSQL = $"SELECT Respuestas FROM {tablaJuego} WHERE Palabras_Claves LIKE '%' || @palabra || '%' COLLATE NOCASE OR @palabra LIKE '%' || Palabras_Claves || '%' COLLATE NOCASE";

                using (var comando = new SqliteCommand(consultaSQL, conexion))
                {
                    string busquedaLimpia = busquedaUsuario.Trim().ToLower();
                    comando.Parameters.AddWithValue("@palabra", busquedaLimpia);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return lector["Respuestas"].ToString()!;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return "Error crítico en la base de datos: " + ex.Message;
        }

        return null!;
    }

    // public void NuevaPartida(BaseDatos bd)
    // {
    //     Console.WriteLine("¿Qué juego jugaste?");
    //      string juego = Console.ReadLine()!;
    //
    //      Console.WriteLine("¿Qué personaje usaste?");
    //      string personaje = Console.ReadLine()!;

    //     Console.WriteLine("¿Como fue tu resultado?");
    //     string resultado = Console.ReadLine()!;

    //     Console.WriteLine("¿A qué piso o ronda llegaste? (Poné solo el número)");
    //     int piso = Convert.ToInt32(Console.ReadLine()); // Convierte el texto a número directamente

    //       Console.WriteLine("¿Causa de muerte? (si no tuviste, pone 'Ninguna')");
    //     string causa = Console.ReadLine()!;

    // Le pasamos los datos recolectados a la base de datos
    //  bd.GuardarEnBD(juego, personaje, resultado, piso, causa);

    //   Console.WriteLine("¡Partida guardada!");
    // }

public void RegistrarPartida(Partida partida)
{
    // El polimorfismo activa automáticamente el PedirDatos() del juego correspondiente
    partida.PedirDatos();

    // Le pasamos EL OBJETO ENTERO a la base de datos
    GuardarEnBD(partida);

    Console.WriteLine("\n¡Partida guardada con éxito!");
}

// Ahora recibe el objeto Partida completo, teniendo acceso a todos los datos, incluyendo los de Forsaken
public void GuardarEnBD(Partida partida)
{

        string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
        // Agregamos Tiempo_Sobrevivido y Generadores_Reparados al comando SQL
        string sql = "INSERT INTO Partidas (Juego, PersonajeUsado, Resultado, Piso_Alcanzado, CausaMuerte, Tiempo_Sobrevivido, Generadores_Reparados, Fecha) VALUES (@juego, @personaje, @resultado, @piso, @causa, @tiempo, @generadores, '2026-10-22')";

    using (var conexion = new SqliteConnection(Conexion))
    {
        conexion.Open();
        using (var comando = new SqliteCommand(sql, conexion))
        {
            // Conectamos todos los comodines sacando la info directamente del objeto
            comando.Parameters.AddWithValue("@juego", partida.Juego);
            comando.Parameters.AddWithValue("@personaje", partida.PersonajeUsado);
            comando.Parameters.AddWithValue("@resultado", partida.Resultado);
            comando.Parameters.AddWithValue("@piso", partida.PisoORonda);
            comando.Parameters.AddWithValue("@causa", partida.CausaMuerte);
            
            // Si es Dandy's World, estos dos estarán vacíos y no pasa nada. Si es Forsaken, se guardarán.
            comando.Parameters.AddWithValue("@tiempo", partida.Tiempo_Sobrevivido);
            comando.Parameters.AddWithValue("@generadores", partida.Generadores_Reparados);

            comando.ExecuteNonQuery();
        }
    }
}

    public void MostrarHistorial()
    {
        Console.Clear();
        Console.WriteLine("Aqui tienes todo tu Historial de Partidas");

        // El asterisco (*) significa "traeme TODAS las columnas", así no escribimos tanto
        string sql = "SELECT * FROM Partidas";

        using (var conexion = new SqliteConnection(Conexion))
        {
            conexion.Open();
            using (var comando = new SqliteCommand(sql, conexion))
            {
                var lector = comando.ExecuteReader(); // Sacamos un bloque 'using' extra que sobraba

                // El while da una vuelta por cada partida guardada
                while (lector.Read())
                {
                    string id = lector["ID"].ToString()!;
                    string fecha = lector["Fecha"].ToString()!;
                    string juego = lector["Juego"].ToString()!;
                    string personaje = lector["PersonajeUsado"].ToString()!;
                    string piso = lector["Piso_Alcanzado"].ToString()!;
                    string resultado = lector["Resultado"].ToString()!;
                    string causa = lector["CausaMuerte"].ToString()!;

                    // Imprimimos todas las variables pegadas directamente con el +
                    Console.WriteLine("ID: " + id + " | Fecha: " + fecha + " | Juego: " + juego + " | Personaje usado: " + personaje + " | Piso Alcanzado: " + piso + " | Resultado: " + resultado + " | Causa de muerte: " + causa);
                }
            
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Eso son todos los resultados");
        Console.ResetColor();
    }
    public void BorrarPartida()
    {
        Console.WriteLine("¿Cuál es el número de la partida que querés borrar?");
        string idBorrar = Console.ReadLine()!;

        // DELETE FROM elimina la fila completa donde el ID sea igual al que escribiste
        string sql = "DELETE FROM Partidas WHERE ID = @id";

        using (var conexion = new SqliteConnection(Conexion))
        {
            conexion.Open();
            using (var comando = new SqliteCommand(sql, conexion))
            {
                // Pegamos el ID de forma segura
                comando.Parameters.AddWithValue("@id", idBorrar);

                // Apretamos el gatillo
                comando.ExecuteNonQuery();
            }
        }

        Console.WriteLine("¡Partida eliminada con exito!");
    }



    public void ActualizarPartida()
    {
        Console.WriteLine("¿Que partida deseas modificar?");
        Console.WriteLine("solo para avisar, deme el numero exacto de su partida");
        string idActualizar = Console.ReadLine()!;

        Console.WriteLine("¿Qué juego jugaste?");
        string juego = Console.ReadLine()!;

        Console.WriteLine("¿Qué personaje usaste?");
        string personaje = Console.ReadLine()!;

        Console.WriteLine("¿Como fue tu resultado?");
        string resultado = Console.ReadLine()!;

        Console.WriteLine("¿A qué piso o ronda llegaste? (Poné solo el número)");
        int piso = Convert.ToInt32(Console.ReadLine()); // Convierte el texto a número directamente

        Console.WriteLine("¿Causa de muerte? (si no tuviste, pone 'Ninguna')");
        string causa = Console.ReadLine()!;



        // UPDATE usa SET para definir qué columnas se van a pisar con los datos nuevos
        string sql = "UPDATE Partidas SET Juego = @juego, PersonajeUsado = @personaje, Resultado = @resultado, Piso_Alcanzado = @piso, CausaMuerte = @causa WHERE ID = @id";

       
            using (var conexion = new SqliteConnection(Conexion))
            {
                conexion.Open();
                using (var comando = new SqliteCommand(sql, conexion))
                {
                comando.Parameters.AddWithValue("@juego", juego);
                comando.Parameters.AddWithValue("@personaje", personaje);
                comando.Parameters.AddWithValue("@resultado", resultado);
                comando.Parameters.AddWithValue("@piso", piso);
                comando.Parameters.AddWithValue("@causa", causa);

                // Te faltaba pasarle el ID a SQLite
                comando.Parameters.AddWithValue("@id", idActualizar);

                comando.ExecuteNonQuery();
            }
            }
        
        Console.WriteLine("¡Indormacion de Partida modificada!");

    }


    public void BuscaPartida()
    {
        // Resolvemos la Cirugía 5 pidiendo un personaje en vez de un número
        Console.WriteLine("¿Qué personaje deseas buscar?");
        Console.WriteLine("Puedes escribir el nombre completo o solo una parte:");
        string personajeBuscar = Console.ReadLine()!;

        string SQL = "SELECT * FROM Partidas WHERE PersonajeUsado LIKE '%' || @busqueda || '%' COLLATE NOCASE";

        using (var conexion = new SqliteConnection(Conexion))
        {
            conexion.Open();
            using (var comando = new SqliteCommand(SQL, conexion))
            {
                comando.Parameters.AddWithValue("@busqueda", personajeBuscar);

                // Metemos el lector ADENTRO de las llaves del comando
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string id = lector["ID"].ToString()!;
                        string fecha = lector["Fecha"].ToString()!;
                        string juego = lector["Juego"].ToString()!;
                        string personaje = lector["PersonajeUsado"].ToString()!;
                        string piso = lector["Piso_Alcanzado"].ToString()!;
                        string resultado = lector["Resultado"].ToString()!;

                        Console.WriteLine("ID: " + id + " | " + fecha + " | " + juego + " | " + personaje + " | Piso: " + piso + " | " + resultado);
                    }
                }
            } // Acá recién se cierra el comando
        }

        Console.WriteLine("¡Búsqueda finalizada!");
    }














} 


//
