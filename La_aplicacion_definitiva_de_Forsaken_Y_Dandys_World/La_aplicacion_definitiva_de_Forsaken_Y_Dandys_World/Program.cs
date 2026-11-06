

using System.ComponentModel.Design;

namespace La_aplicacion_definitiva_de_Forsaken_Y_Dandys_World
{

    internal class Program
    {
        static void MenuDandysWorld()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear(); // Limpia la consola para que el submenú se vea ordenado

            Console.WriteLine("Has Elegido");
            Console.WriteLine("====================================================");
            Console.WriteLine("               DANDYS WORLD");
            Console.WriteLine("====================================================\n");

            // Dibujo de Connie 
            string dibujo = @"⠀⠀⠀
                   ⣀⠤⠤⠄⠒⠒⠒⠒⠠⢤⡀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡠⠎⠉⡢⠔⠈⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⢉⡠⠖⠓⠒⠒⠒⠒⠒⠒⠀⠤⣀⠀⠀⠀⠀⡰⠃
⠀⠀⠀⠀⠀⠀⠀⠀⡴⣡⠚⠁⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠈⠢⡴⠋⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡜⣰⠕⠁⠀⠀⠀⠀⠀⠀⡠⠊⠣⡀⠀⠀⠀⠀⠀⠘⠦⡀⠀
⠀⠀⠀⠀⠀⠀⠀⣫⠳⢤⣄⣀⣀⣀⡠⠴⠚⢄⠀⠀⢈⠕⠒⠤⠤⠠⠖⡶⠹⠀
⠀⠀⠀⠀⠀⠀⠀⡻⠀⡜⢉⠋⠉⠉⠁⠀⠀⠈⠄⠀⠎⠀⠀⠀⠀⠀⢂⢱⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡇⢀⣋⡽⠐⠒⠒⣶⣶⣶⣶⣮⠀⠒⠒⢲⣶⣶⣶⣾⠞⡆⠀
⠀⠀⠀⠀⠀⠀⢰⠀⠐⡀⠘⡀⠀⠀⠹⣿⣿⣿⠇⠀⡆⠀⠘⢿⣿⣿⠏⢠⡇⠀
⠀⠀⠀⠀⠀⠀⢸⠀⠀⢣⠀⠘⠢⢀⣀⡀⠭⠋⠀⠀⠈⠢⠄⡠⠄⠊⠀⣸⡁⠀
⠀⠀⠀⠀⠀⠀⠘⡄⠀⢆⠑⠦⠤⠆⠀⠀⠀⡇⠀⠀⡠⠀⠀⠀⢰⠄⠜⡒⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣣⠀⠀⠑⠦⢤⠃⠀⠀⠀⠐⠖⠊⠀⠀⠀⢀⡨⠒⡞⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠀⠁⠒⣤⣄⠀⣀⠀⣤⠤⠒⠁⠀⢠⠃⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢘⡄⠀⠀⠀⠀⠀⡇⢨⠷⠬⡐⠈⡑⡤⠤⡀⡮⠀⠀⠀⠀
⠀⠀⣀⣀⠀⠀⠀⠀⢀⡇⠀⠀⠀⠀⠀⡟⡌⠢⡀⢀⠵⠋⠀⢀⠘⡄⠀⠀⠀⠀
⢠⠏⢁⣈⠑⠓⠤⠤⠖⠀⠀⠀⠀⠀⠀⢰⡘⢄⠀⠀⠀⡤⠊⠃⡖⠁⠀⠀⠀⠀
⢨⠞⠉⠀⠉⠑⢤⣀⠀⠀⠀⠀⠀⠀⠀⢀⣟⠠⠵⠒⠩⠟⡕⠊⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠙⠓⠒⠒⠒⢚⣋⠽⠋⠀⠀⠀⠀⠀⢱⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠤⠔⠚⠉⠀⠀⠀⠀⠀⠀⠀⢨⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠠⠞⠁⠀⠀⠀⣀⣀⠄⣀⣀⣀⡠⡤⠃⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⢺⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠐⠦⣀⠀⠀⠀⠈⠑⠃⠢⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠑⠢⡈⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢤⣤⠴⠗⠁";

            Console.WriteLine(dibujo);
            Console.WriteLine("\n¿Elige con cual opcion quieres empezar?");
            Console.WriteLine("a) Consultoria");
            Console.WriteLine("b) Comparacion de personajes");
            Console.WriteLine("c) Game Tracker");

            // Reemplazamos el ReadKey() por un ReadLine para poder capturar la letra elegida
            string opcionDandys = Console.ReadLine()!;


            while (opcionDandys != "a" && opcionDandys != "b" && opcionDandys != "c")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduzca un número válido che. Ingresa 'a' para Consultoria, 'b' para Comparacion de Personajes y 'c' para Game Tracker  :");
                Console.ResetColor();
                opcionDandys = Console.ReadLine()!;

            }

            if (opcionDandys == "a")
            {
                ConsultoriaDandy();
            }
            else if (opcionDandys == "b")
            {
                ComparacionPersonajesDandys();

            }
            else if (opcionDandys == "c")
            {
                GameTrackerDandys();
            }

       

        }
        static void MenuForsaken()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear(); // Limpia la consola para que el submenú se vea ordenado

            Console.WriteLine("Has Elegido");
            Console.WriteLine("====================================================");
            Console.WriteLine("              Forsaken");
            Console.WriteLine("====================================================\n");

            // Dibujo de BLUDUDE 
            string dibujo = @"⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⣀⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣴⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⠀⢸⣿⣿⣿⣿⠀⣿⣿⣿⣿⣷⣧⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣤⣤⣿⣿⣿⣷⣤⣼⣿⣿⣿⣿⣿⠷⠀⠀⠀⠀⠀⠀⠀⠀⠠⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⢟⠍⠉⠉⠩⠉⠉⠙⠛⠛⡛⠂⠛⠓⠉⡗⠀⠁⣿⡆⠀⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣿⡪⡀⣀⣀⡬⠤⡄⢀⠠⠤⢞⠐⠠⠄⠂⡖⠁⢉⣻⡇⢀⡀⣀⢀⠐⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣯⢲⠀⠀⠀⡄⠀⠀⠀⠀⠀⡈⠀⠀⠀⠀⡂⠀⣸⡼⠁⠀⢐⠀⠀⠂⠐⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠻⣏⠦⠤⣀⠀⠀⠀⠀⠀⢀⠁⠀⠀⠀⡈⠀⣰⡟⠁⠂⠐⠂⠂⢂⠑⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢯⢄⠸⠀⠀⠈⠉⠉⡑⠐⠂⠤⣤⣁⡾⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢀⠀⢀⠠⠐⠈⠀⠄⠀⠀⠀⠀⠈⠓⠄⣀⠀⠀⠠⠀⣀⡠⠴⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀
⠀⠀⠀⠈⠀⠀⠀⠒⠀⠠⠄⠀⠀⠁⠂⠀⠀⠀⠀⠈⢉⣀⣀⣀⣀⣀⣀⠠⣈⠀⠀⠂⢁⠈⠄⠂⠀⠀⠀⠀⠁⠈⠀
⠀⠠⠀⠂⠐⢂⠁⠈⠀⢀⣤⡐⢶⣾⣷⣿⣿⡿⠻⠿⠿⣿⣿⣿⣟⢻⢊⠳⡌⠻⢷⣦⢐⠀⠀⠐⡀⠁⠀⠀⠀⠄⠀
⠀⠀⠀⠀⢀⣀⣀⡰⢀⣾⣿⣿⠀⢿⣿⣿⣿⣰⡇⣾⡎⣶⣶⢹⣹⠰⣸⢰⢸⢰⢰⡰⢾⡇⡆⡀⠇⡆⠆⠀⠀⠀⠀
⠂⢢⢉⢎⡱⢌⠖⢡⣾⣿⡿⠁⠀⠀⠙⣿⣿⣧⣹⣭⢅⢁⢭⠍⡮⣬⣬⢪⡹⣬⡍⢝⠌⠨⡥⣽⢣⡁⠁⠀⠀⠀⠀
⠀⠀⠀⠈⠒⠉⣠⣿⣿⣟⠃⠀⠀⠀⠀⠈⢺⢩⣲⢱⠪⢺⠪⠆⡇⡖⣴⢲⣱⢰⢲⢡⢢⢦⣄⠰⣦⠟⣴⡀⠇⠇⠂
⠀⠀⠀⠀⠀⣰⣿⣿⣿⡿⠀⠀⠐⠈⠀⠀⠀⠑⢋⢶⣷⣶⣷⣷⣷⣷⣷⣶⣾⣾⣾⣶⣷⣶⣾⣶⡌⢳⣶⣧⠀⠁⠀
⠀⠀⠀⠀⢰⣿⣿⣿⣿⡏⠀⠀⠈⠀⠐⠀⠀⠠⠈⠪⣽⣿⠿⠿⠿⠿⠿⠟⠛⣛⠋⣛⣛⣛⣛⣛⣓⡀⣿⣿⡆⠀⠀
⠀⠀⠀⢠⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⢀⠂⠀⠄⠀⣰⣶⣶⣿⣿⣿⣿⣿⣿⡿⢰⣿⣿⣿⣿⣿⡟⢰⣿⣿⡇⠀⠀
⠀⠀⢀⣾⣿⣿⣿⣿⣿⣇⠀⠀⠐⠀⠀⠀⠄⠁⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⣾⣿⣿⣿⣿⣿⠃⢲⣿⣿⡇⠀⠀
⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠨⠀⠃⠂⣾⣿⣿⣿⣿⣿⣿⣿⣿⡿⢰⣿⣿⣿⣿⣿⡏⣴⣿⣿⣿⠇⠀⠀
⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣿⣿⣿⣿⣿⡟⠰⠟⠛⠛⠛⠀⠀⠀
⠀⢸⣿⠿⠿⠛⠛⠛⠉⠉⠁⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⣸⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢰⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⢁⢿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⣬⣾⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   @uryk4 on Discord 
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠼⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠰⠿⠿⠿⠿⠿⠟⠀⠀⠀⠀⠀        a name tag as well ^_^ 
             ⤹           ↓↓↓↓         ⤸
            ♬⋆.˚🌀🔵ᯓ★ Bluudude ★ᯓ🔵🌀˚.⋆♬⠀          ";

            Console.WriteLine(dibujo);
            Console.WriteLine("\n¿Elige con cual opcion quieres empezar?");
            Console.WriteLine("a) Consultoria");
            Console.WriteLine("b) Comparacion de personajes");
            Console.WriteLine("c) Game Tracker");



            // Reemplazamos el ReadKey() por un ReadLine para poder capturar la letra elegida
            string opcionForsaken = Console.ReadLine()!;


            while (opcionForsaken != "a" && opcionForsaken != "b" && opcionForsaken != "c")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduzca un número válido che. Ingresa 'a' para Consultoria, 'b' para Comparacion de Personajes y 'c' para Game Tracker  :");
                Console.ResetColor();
                opcionForsaken = Console.ReadLine()!;

            }

            if (opcionForsaken == "a")
            {
                ConsultoriaForsaken();
            }
            else if (opcionForsaken == "b")
            {
                // Llamar a la función de comparación de personajes de Forsaken
                ComparacionPersonajesForsaken();
            }
            else if (opcionForsaken == "c")
            {
                // Llamar a la función de estadísticas de Forsaken
                GameTrackerForsaken();
            }



        }


        static void ConsultoriaDandy()
        {
            Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BaseDatos miBaseDeDatos = new BaseDatos();

            while (true)
            {
                Console.Clear(); // Limpiamos la pantalla al inicio de cada vuelta
                Console.ResetColor(); // Nos aseguramos de que no haya fondos amarillos xd

                Console.WriteLine("Has Elegido");
                Console.WriteLine("====================================================");
                Console.WriteLine("               CONSULTORIA DW (╭ರ_•́)");
                Console.WriteLine("====================================================\n");
                Console.WriteLine("\n Hola Soy Tu asistente de consultoria");

                string dibujo = @"⠀⠀⠀
⠀⠀⠀⠀⠀  ⢀⡀⠀⠀⠀          ⣀⡀⠀⢀⠖⠢⡀⠀⠀⠀
⠀⠀⠀⠀⠰⠊⠁⠀⠀⠀⠀⠀⠀⠈⠑⠢⣀⠀⠀⠀⠀⡞⠀⠘⠀⡆⠀⢠⠁⡠⠒⠢
⠀⠀⣠⠂⠀⣠⣴⣶⡀⠀⠀⠀⠀⢠⣦⣄⠀⠣⡀⠀⠀⢡⠀⠀⡀⠇⠀⠇⠰⠀⢠⠊
⠀⡰⠃⠀⠀⢿⣿⠿⠁⠀⠀⠀⠀⠈⠻⢿⠗⠀⠱⡀⠀⠈⢆⠀⠀⠂⠀⠈⠁⠀⡆⠀
⠰⠁⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢡⠀⠄⠈⠄⠀⠀⠀⠀⠀⠀⠀⠀
⢈⠀⢣⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⡆⠘⢢⣀⡀⠀⣀⠀⠀⠀⠀⢠⠆⠀
⢸⠀⠘⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⠃⠸⠀⠀⠀⠀⠀⠐⠤⠤⠂⠁⠀⠀
⠀⢧⡀⠙⢿⣷⣄⠀⠀⠀⠀⠀⠀⠀⢀⣼⡿⠃⢠⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⢿⠀⠈⠻⣿⣷⣦⣄⣀⣀⣤⣾⡿⠋⠀⣠⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠑⢄⠀⠀⠀⠉⠙⠉⠉⠉⠁⠀⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠒⠚⠲⠶⠶⠶⠾⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ";
                Console.WriteLine(dibujo);

                Console.WriteLine("\nPregúntame lo que necesites.");
                Console.WriteLine("Aquí tienes unas preguntas frecuentes por si no sabes qué consultar:\n");
                Console.WriteLine("--- Preguntas de contexto ---");
                Console.WriteLine("1) ¿Qué es Dandy's World y de qué trata?");
                Console.WriteLine("2) ¿Quién es Dandy y cómo funciona su tienda?");
                Console.WriteLine("3) ¿Qué son los Twisteds?\n");
                Console.WriteLine("--- Preguntas de recomendación ---");
                Console.WriteLine("4) ¿Qué personaje inicial debería usar (Started Toons)?");
                Console.WriteLine("5) ¿Cómo puedo evitar a los twisteds?");
                Console.WriteLine("6) ¿Qué debería comprar en la tienda de Dandy?\n");
                Console.WriteLine("7) Salir\n");

                Console.Write("Tu pregunta (o 'salir'): ");
                string pregunta = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(pregunta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Se requiere que escriba. Por favor, no deje los campos vacios.");
                    Console.ResetColor();
                    Console.WriteLine("\nPresiona ENTER para intentar de nuevo...");
                    Console.ReadLine(); // Freno para que el usuario lea el error
                    continue;
                }

                if (pregunta.ToLower() == "salir" || pregunta == "7")
                {
                    Console.WriteLine("Saliendo de la consultoria...");
                    break;
                }

                string Respuesta_Encontrada = miBaseDeDatos.BuscarTactica(pregunta, "Consultoria");

                Console.WriteLine("\n====================================================");
                if (Respuesta_Encontrada != null)
                {
                    Console.WriteLine($"Respuesta: {Respuesta_Encontrada}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lo sentimos, no se ha encontrado ninguna respuesta registrada para su pregunta :(.");
                    Console.ResetColor();
                }
                Console.WriteLine("====================================================");

                // Este es el freno clave antes de volver a empezar el bucle y limpiar la pantalla
                Console.WriteLine("\nPresiona ENTER para hacer otra pregunta...");
                Console.ReadLine();
            }
        }

        static void ComparacionPersonajesDandys()
{          
   

                Console.Clear();


                Console.WriteLine("Has Elegido");
                Console.WriteLine("====================================================");
                Console.WriteLine("               COMPARACION DE PERSONAJES 🤝");
                Console.WriteLine("====================================================\n");
                Console.WriteLine("\n Hola! Aqui podras comparar personajes!");

                Console.WriteLine("\nIngrese al primer personaje");

                string Personaje1 = Console.ReadLine()!;

                Console.WriteLine("¿Con que otro personaje desea comparar el seleccionado?");

                string Personaje2 = Console.ReadLine()!;

                Personaje comparador = new Personaje();
                comparador.CompararEnBD(Personaje1, Personaje2, "DANDYS WORLD");




          




        }
        static void GameTrackerDandys()
        {
            Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Has Elegido");
            Console.WriteLine("====================================================");
            Console.WriteLine("               GAME TRACKER 🎮");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("\n Hola Soy Tu asistente de registro de partidas ");


            string dibujo = @"⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣦⣄⡀⠀⠀⢀⣠⣴⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣼⣿⣿⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠉⣹⣿⣧⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣼⣿⣉⣉⠀⣉⣙⣿⣿⣿⣿⣿⣿⣿⣟⠁⣹⣿⣏⠀⣹⣧⠀⠀⠀⠀
⠀⠀⠀⢠⣿⣿⣿⣿⣀⣿⣿⣿⣉⣉⣿⣿⣉⣹⣿⣿⣏⠀⣹⣿⣿⣿⡄⠀⠀⠀
⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀
⠀⠀⠀⢸⣿⣿⣿⣿⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠸⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⠇⠀⠀⠀
⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀

⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ";
            Console.WriteLine(dibujo);
            BaseDatos bd = new BaseDatos();

            while (true)
            {
                Console.WriteLine("¿que desea hacer?");

                Console.WriteLine(" 1. Registar Partida 🎮");
                Console.WriteLine(" 2. Mostrar Historial de partidas");
                Console.WriteLine(" 3. Buscar partida");
                Console.WriteLine(" 4. Actualizar informacion de partidas");
                Console.WriteLine(" 5. Eliminar registro de partida");
                Console.WriteLine(" 6. Salir");
                String Opciones_CRUD = Console.ReadLine()!;

                if (Opciones_CRUD == "1")
                {
                    bd.RegistrarPartida(new PartidaDW());

                }


                else if (Opciones_CRUD == "2")
                {
                    bd.MostrarHistorial();

                }
                else if (Opciones_CRUD == "3")
                {
                    bd.BuscaPartida();

                }
                else if (Opciones_CRUD == "4")
                {
                    bd.ActualizarPartida();

                }
                else if (Opciones_CRUD == "5")
                {
                    bd.BorrarPartida();

                }

                else if (Opciones_CRUD.ToLower() == "salir" || Opciones_CRUD == "6")
                {
                    Console.WriteLine("Saliendo del GAME TRACKER...");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("ERROR: escribe bien ");
                    Console.ResetColor();

                }








            }







        }

        static void ConsultoriaForsaken()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BaseDatos miBaseDeDatos = new BaseDatos();

            while (true)
            {
                Console.Clear(); // Limpia la consola para que el submenú se vea ordenado
                Console.ResetColor();

                Console.WriteLine("Has Elegido");
                Console.WriteLine("====================================================");
                Console.WriteLine("               CONSULTORIA F (╭ರ_•́)");
                Console.WriteLine("====================================================\n");
                Console.WriteLine("\n Hola Soy Tu asistente de consultoria");

                string dibujo = @"⠀⠀⠀
⠀⠀⠀⠀⠀  ⢀⡀⠀⠀⠀          ⣀⡀⠀⢀⠖⠢⡀⠀⠀⠀
⠀⠀⠀⠀⠰⠊⠁⠀⠀⠀⠀⠀⠀⠈⠑⠢⣀⠀⠀⠀⠀⡞⠀⠘⠀⡆⠀⢠⠁⡠⠒⠢
⠀⠀⣠⠂⠀⣠⣴⣶⡀⠀⠀⠀⠀⢠⣦⣄⠀⠣⡀⠀⠀⢡⠀⠀⡀⠇⠀⠇⠰⠀⢠⠊
⠀⡰⠃⠀⠀⢿⣿⠿⠁⠀⠀⠀⠀⠈⠻⢿⠗⠀⠱⡀⠀⠈⢆⠀⠀⠂⠀⠈⠁⠀⡆⠀
⠰⠁⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢡⠀⠄⠈⠄⠀⠀⠀⠀⠀⠀⠀⠀
⢈⠀⢣⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⡆⠘⢢⣀⡀⠀⣀⠀⠀⠀⠀⢠⠆⠀
⢸⠀⠘⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⠃⠸⠀⠀⠀⠀⠀⠐⠤⠤⠂⠁⠀⠀
⠀⢧⡀⠙⢿⣷⣄⠀⠀⠀⠀⠀⠀⠀⢀⣼⡿⠃⢠⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⢿⠀⠈⠻⣿⣷⣦⣄⣀⣀⣤⣾⡿⠋⠀⣠⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠑⢄⠀⠀⠀⠉⠙⠉⠉⠉⠁⠀⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠒⠚⠲⠶⠶⠶⠾⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ";
                Console.WriteLine(dibujo);

                Console.WriteLine("Pregúntame lo que necesites.");
                Console.WriteLine("Aquí tienes unas preguntas frecuentes por si no sabes qué consultar:\n");
                Console.WriteLine("--- Preguntas de contexto ---");
                Console.WriteLine("1) ¿Qué es Forsaken y de qué trata?");
                Console.WriteLine("2) ¿Que son los survivalistas?");
                Console.WriteLine("3) ¿Qué son los killers?\n");
                Console.WriteLine("--- Preguntas de recomendación ---");
                Console.WriteLine("4) ¿Qué personaje inicial debería usar?");
                Console.WriteLine("5) ¿Cómo puedo evitar a los killers?");
                Console.WriteLine("6) ¿Qué debería comprar?\n");
                Console.WriteLine("7) Salir\n");

                Console.Write("Tu pregunta (o 'salir'): ");
                string pregunta = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(pregunta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Se requiere que escriba. Por favor, no deje los campos vacios.");
                    Console.ResetColor();
                    Console.WriteLine("\nPresiona ENTER para intentar de nuevo...");
                    Console.ReadLine();
                    continue;
                }

                if (pregunta.ToLower() == "salir" || pregunta == "7")
                {
                    Console.WriteLine("Saliendo de la consultoria de Forsaken...");
                    break;
                }

                // ACÁ ESTÁ LA MAGIA: Le decimos que busque en ConsultoriaForsaken
                string Respuesta_Encontrada = miBaseDeDatos.BuscarTactica(pregunta, "ConsultoriaForsaken");

                Console.WriteLine("\n====================================================");
                if (Respuesta_Encontrada != null)
                {
                    Console.WriteLine($"Respuesta: {Respuesta_Encontrada}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lo sentimos, no se ha encontrado ninguna respuesta registrada para su pregunta :(.");
                    Console.ResetColor();                   
                }
                Console.WriteLine("====================================================");

                Console.WriteLine("\nPresiona ENTER para hacer otra pregunta...");
                Console.ReadLine();
            }
        }
        static void ComparacionPersonajesForsaken()

        {
            Console.Clear();

            Console.WriteLine("Has Elegido");
            Console.WriteLine("====================================================");
            Console.WriteLine("               COMPARACION DE PERSONAJES 🤝");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("\n Hola! Aqui podras comparar personajes!");

            Console.WriteLine("\nIngrese al primer personaje");

            string Personaje1 = Console.ReadLine()!;

            Console.WriteLine("¿Con que otro personaje desea comparar el seleccionado?");

            string Personaje2 = Console.ReadLine()!;

            Personaje comparador = new Personaje();
            comparador.CompararEnBD(Personaje1, Personaje2, "FORSAKEN");




        }
        static void GameTrackerForsaken()
        {

            Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Has Elegido");
            Console.WriteLine("====================================================");
            Console.WriteLine("               GAME TRACKER 🎮");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("\n Hola Soy Tu asistente de registro de partidas ");


            string dibujo = @"⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣦⣄⡀⠀⠀⢀⣠⣴⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣼⣿⣿⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠉⣹⣿⣧⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣼⣿⣉⣉⠀⣉⣙⣿⣿⣿⣿⣿⣿⣿⣟⠁⣹⣿⣏⠀⣹⣧⠀⠀⠀⠀
⠀⠀⠀⢠⣿⣿⣿⣿⣀⣿⣿⣿⣉⣉⣿⣿⣉⣹⣿⣿⣏⠀⣹⣿⣿⣿⡄⠀⠀⠀
⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀
⠀⠀⠀⢸⣿⣿⣿⣿⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠸⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⠇⠀⠀⠀
⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀

⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ";
            Console.WriteLine(dibujo);
            BaseDatos bd = new BaseDatos();

            while (true)
            {
                Console.WriteLine("¿que desea hacer?");

                Console.WriteLine(" 1. Registar Partida 🎮");
                Console.WriteLine(" 2. Mostrar Historial de partidas");
                Console.WriteLine(" 3. Buscar partida");
                Console.WriteLine(" 4. Actualizar informacion de partidas");
                Console.WriteLine(" 5. Eliminar registro de partida");
                Console.WriteLine(" 6. Salir");
                String Opciones_CRUD = Console.ReadLine()!;

                if (Opciones_CRUD == "1")
                {

                    bd.RegistrarPartida(new PartidaForsaken());
                }


                else if (Opciones_CRUD == "2")
                {
                    bd.MostrarHistorial();

                }
                else if (Opciones_CRUD == "3")
                {
                    bd.BuscaPartida();

                }
                else if (Opciones_CRUD == "4")
                {
                    bd.ActualizarPartida();

                }
                else if (Opciones_CRUD == "5")
                {
                    bd.BorrarPartida();

                }

                else if (Opciones_CRUD.ToLower() == "salir" || Opciones_CRUD == "6")
                {
                    Console.WriteLine("Saliendo del GAME TRACKER...");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("ERROR: escribe bien ");
                    Console.ResetColor();

                }








            }










        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Bienvenido a la applicacion de ayuda definitiva de");
            Console.WriteLine("");
            Console.WriteLine("====================================================");
            Console.WriteLine("               FORSAKEN Y DANDYS WORLD");
            Console.WriteLine("====================================================\n");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Quieres que te explique como funciona la aplicacion?");
            Console.WriteLine("");

            Console.WriteLine("1.Si");
            Console.WriteLine("2.No");
            String Opcion = Console.ReadLine()!;

            while (Opcion != "1" && Opcion != "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduzca un número válido che. Ingresa '1' para Si o '2' para No:");
                Console.ResetColor();
                Opcion = Console.ReadLine()!;

            }

            if (Opcion == "1")
            {
                Console.Clear();


                Console.WriteLine("Genial!!, ahora te explico para que te quede todo claro jsjjs");
                Console.WriteLine("Tenemos 3 categorias");
                Console.WriteLine("Consultoria");
                Console.Write("Esta función es como tener a un jugador experto dándote consejos al instante para que no sufras durante tus primeros días de juego." +
                    " Te daremos guías detalladas y tácticas para que aprendas a sobrevivir rápido y sin frustrarte");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Comparacion de Personajes");
                Console.Write("Ya no tienes que adivinar quién es el mejor. Aquí puedes poner cara a cara a distintos personajes para comparar sus pros, " +
                    "contras, habilidades y roles (como soporte, centinela o survivalista). Así sabrás exactamente " +
                    "a quién elegir según tu estilo antes de entrar a la partida.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Game tracker");
                Console.Write("Llevamos un registro de tus números para que veas cómo pasas de principiante a pro." +
                    " o que erorres tuviste para intentar mejorar evitar que te pase y para mejorar, ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            }

            else if (Opcion == "2")
            {
                Console.Clear();
                Console.WriteLine("Ok, parece que ya te lo sabes, ¡GENIAL!");
                Console.WriteLine("");
                Console.WriteLine("");


            }



            Console.WriteLine("Entonces ahora dime");
            Console.WriteLine("Con que Juego empezamos?");
            Console.WriteLine("");
            Console.WriteLine("d)Dandys World");
            Console.WriteLine("f)Forsaken");
            string OpcionJuego = Console.ReadLine()!;


            while (OpcionJuego != "d" && OpcionJuego != "f")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduzca un número válido che. Ingresa 'd' para Dandys World o 'f' para Forsaken:");
                Console.ResetColor();
                OpcionJuego = Console.ReadLine()!;
            }


            if (OpcionJuego == "d")
            {


                Console.Clear();
                MenuDandysWorld();


            }


            else if (OpcionJuego == "f")
            {
                Console.Clear();
                MenuForsaken();
            }









































        }
    }

}




