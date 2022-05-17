/*Clase 5: Tarea - Ejercicio 
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje 
que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que también finalice el programa, 
pero mostrando un mensaje que diga "Opción no válida".*/


//5) Si la respuesta es "S" repetir desde el punto 1
string opcion = "S";

while (opcion.ToUpper() == "S")
{
    //1) Borrar la pantalla
    Console.Clear();

    //2) Pedir el nombre de una persona
    Console.WriteLine("Ingrese su nombre");
    string nombreIngresado = Console.ReadLine();

    //3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
    Console.WriteLine($"¡Hola {nombreIngresado}!");

    //4) Preguntar si se quiere continuar
    Console.WriteLine("Desea continuar en la sesión?\n" +
                      "Opción Sí -> escriba S\n" +
                      "Opción No -> escriba N");
    opcion = Console.ReadLine();
}

if (opcion.ToUpper() == "N")
{   /*6) Si la respuesta es "N" finalizar el programa mostrando un mensaje 
    que diga "Programa finalizado correctamente"*/
    
    Console.WriteLine("Programa finalizado correctamente");
} 
else
{   /*7) Si la respuesta no es ni "S" ni "N" que también finalice el programa, 
    pero mostrando un mensaje que diga "Opción no válida"*/

    Console.WriteLine("Opción no válida");
}