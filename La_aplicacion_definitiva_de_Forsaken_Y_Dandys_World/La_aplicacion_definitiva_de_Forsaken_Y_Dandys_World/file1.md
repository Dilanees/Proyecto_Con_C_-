# Documentación del proyecto

Nombre del proyecto: Práctica No. 1: La_Aplicacion_de_ayuda_definitiva_de_Dandys_World_Y_Forsaken

Elaborado por: Yuliana Martina Ramos Y Octavio Jose Robledo

Fecha de elaboración: 28 / 09 / 2026

---

### Objetivo del proyecto

Crear un programa de consola en C# que Ayude a los usuarios a 
encontrar informacion Dandys World y Forsaken,
Ayudar a los nuevos jugadores a mejorar y aprender de forma interactiva y divertida, y proporcionar una experiencia de usuario amigable y accesible.

---

### Objetivos del proyecto

1. Proporcionar una plataforma centralizada para acceder a información sobre Dandys World y Forsaken.
2. Facilitar el aprendizaje y la mejora de los nuevos jugadores a través de contenido interactivo y didáctico.
3. Registre su historial de partidas para almacenar y trackear su rendimiento y progreso, 
4.. Consultar tácticas de supervivencia, preguntas de recomendacion y contexto al instante mediante un chat interactivo,
5. Comparar estadísticamente a los personajes disponibles. El objetivo es transformar la experiencia de juego de "adivinar qué hacer" a "tomar decisiones basadas en datos". 

---

### Características del proyecto

- Tipo de proyecto: **Aplicación de consola**
- Versión de Visual Studio: **2026**
- Versión de C#: **.NET 10.0**

---



### Descripción del proyecto

Primero le damos la bienvenida a los usuarios y le presentamos el titulo del proyecto, 
le preguntamos si desea saber las 3 cosas que incluye la aplicacion o no, si dice que si le mostraremos una descripcion breve de todo lo que incluye, si dice que no, lo pasamos directamente al codigo principal 
Despues le preguntamos con que juego desea empezar, Dandys World o Forsaken, dependiendo de su respuesta, le mostraremos un menu con las opciones disponibles para ese juego.
No importa que juego elija, el menu sera el mismo, solo cambia el diseño, y la ASCII 

te pondra tres opciones, La primera es la seccion de consultoria, La segunda es la seccion de comparacion de personajes, y La tercera y ultima opcion es el Game Tracker.
las tres opciones dependiendo de si eliges dandys world o forsaken, solo va a cambiar la informacion que se mostrara, pero la interfaz seguira siendo la misma


### si eliges CONSULTORIA:
Te dara la bienvenida con un ascii bonito
y te preguntara que deseas consultar
y te pondra preguntas prederteminadas/ preguntas frecuetes por si no sabes que preguntar, teniendo una parte de preguntas de contexto y de preguntas de recomendacion, 
y que va a variar dependiendo de si eliges dandys world o forsaken, y el programa le dara una respuesta dependiendo de la pregunta que elija.
Mientras el usuario este en la seccion de consultoria, podra hacer preguntas personalizadas, y el programa le dara una respuesta dependiendo de la pregunta que haga,
y cada vez que termines de hacer una pregunta, el programa le preguntara si desea hacer otra pregunta, volver al menu o salir del programa
si el usuario elige volver al menu, lo regresara al menu principal, si elige salir del programa, le dara un mensaje de despedida y terminara la ejecucion del programa
y si el usuario desea continuar haciendo preguntas, le dara la bienvenida nuevamente a la seccion de consultoria y le preguntara que desea consultar, y asi sucesivamente hasta que el usuario decida salir del programa o volver al menu principal

Si eliges comparacion de personajes:
Te dara la bienvenida con un ascii bonito
y te preguntara que personaje deseas comparar, y te dara una lista de personajes disponibles para comparar, y te mostrara una comparacion estadistica de los personajes que elijas, y te dara una recomendacion de cual personaje es mejor dependiendo de la comparacion estadistica.


### Si eliges Game Tracker:
Te dara la bienvenida con un ascii bonito
y te preguntara que deseas hacer, y te 6 opciones, 

 1. Registar Partida 🎮
 2. Mostrar Historial de partidas
 3. Buscar partida
 4. Actualizar informacion de partidas
 5. Eliminar registro de partida
 6. Salir

 ### Resgistrar partida
 dependiendo de que juego hayas elegido anteriormente, las preguntas que te hara seran diferentes 

 Preguntas para registro de partida Dandys World

  
 1. ¿Qué Toon / Personaje usaste?
 2. ¿A qué Ronda llegaste?
 3. ¿Causa de muerte / Twisted que te eliminó?

 Preguntas para el registro de Forsaken

 1. ¿Qué personaje usaste?
 2. ¿A qué Ronda llegaste?
 3. ¿Resultado de la partida?
 4.  ¿Causa de muerte / Killer que te mató?  
 5. ¿Cuánto tiempo sobrevivió/duro?
 6. ¿Cuántos generadores pudo reparar?

 Despues registrara tus respuestas en la base de datos

 ## Mostrar Historial de partidas
 Te mostrara todas las partidas registradas con la informacion que vos pusiste con antelacion.

 ## Buscar partida
 te pedira que pongas el nombre del personaje/ toon/ killer/survivar, y despues si lo encuentra , te mostrara la informacion de esa partida, y si no lo encuentra, te dira que no se encontro ninguna partida con ese nombre

 ## Actualizar informacion de partidas
 te pedira que numero de partida es (ID) y ahi te volvera a preguntar las pragunats de registro de partida

 Eliminar registro de partida
 te pedira que numero de partida es (ID) y si lo encuentra lo borarra, sino no 

 salir
 si escribes "6" o "salir" te dara un mensaje de despedida y se cerrara el programa

---

### Notas del proyecto
isnullorwhitespace(); es un metodo que se utiliza para verificar si una cadena de texto es nula o esta vacia, y se utiliza en el proyecto para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

bool: es un tipo de dato que solo puede tener dos valores, verdadero o falso, y lo utilizamos en el proyecto para evitar bucles infinitos y para controlar el flujo del programa, y tambien para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

try catch: es una estructura de control que sirve para menejar errores de tipo de base de datos, apis y errores de tipo de entrada de datos, y lo utilizamos para en este programa para todo lo relacionado a la conexion de la base de datos, de que primero intentara ejecutar el codigo, y si pasa algun error lo cachara y evitara crasheos

tryparse: es un metodo que sirve para convertir una cadena de texto a un tipo de dato numerico, y lo utilizamos en el proyecto para validar las entradas del usuario, y evitar que el programa se caiga por errores de entrada de datos.

SQLite: es un motor de base de datos ligero  que lo utilizamos en el proyecto para almacenar la informacion de las partidas registradas, para poder tirar respuestas mas personalizadas, y dar informacion de personajes y comparaciones de personajes, todo gracias a la base de datos que creamos.

Console.ForegroundColor = ConsoleColor.Red/Green/Yellow: nos sirve para ponerle color a las letras, para que quede mas bonito y para que el usuario sepa si hizo algo mas o si un texto es importante

ASCII: Es una forma de dibujar con caracteres, en este caso se utilizo para dibujar personajes de dandys world y forsaken, tambien para dinujar una carita feliz saludando y un control de consola, para que el usuario se sienta mas comodo al ver el programa y se vea mas bonito, y tambien se utilizo para dibujar una linea de separacion entre los mensajes del programa.

Console.Clear(); nos permite limpiar la consola, y lo utilizamos en el proyecto para limpiar la pantalla y y que no se llene de informacion y se vea mas ordenado.

Clases: Utilizamos las clases en este proyecto para organizar el codigo y separar las funcionalidades del programa, y lo utilizamos para crear objetos que representan a los personajes de Dandys World y Forsaken, para crear objetos que representan a las partidas registradas, crear un crud con base de datos y para crear objetos que representan a las comparaciones de personajes