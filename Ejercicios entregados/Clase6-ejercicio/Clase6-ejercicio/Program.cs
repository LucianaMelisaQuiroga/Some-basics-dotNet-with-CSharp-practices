/*Clase 6: Tarea - Ejercicio 
Escribir un programa que haga lo siguiente:

1) Generar un número secreto
aleatorio con la siguiente instrucción:
// Genera un número entero aleatorio de 1 a 20
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.
3) Si el numero ingresado por el usuario es mayor al número secreto, 
avisarle que es muy grande y que intente de nuevo y que vuelva al paso 2.
4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.
5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:
    "Felicitaciones, has adivinado el número
    secreto que era:  [numeroSecreto] "
    "Lo has logrado en [n] intentos!!"
Y finalizar el programa.*/


//Declaro las variables
int numeroIngresado, numeroSecreto, contador;

//Inicializo la variable contador
contador = 1;

//Titulo el juego
Console.WriteLine("Juguemos a adivinar un número.\n" +
                 "Veamos en cuántos intentos lo lográs!!");


//1) Genera un número entero aleatorio de 1 a 20
numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

do
{
    /*2) Pedir al usuario que ingrese un número y que intente adivinar el 
    número que eligió la computadora.*/

    Console.WriteLine("Ingrese un número del 1 al 20");
    numeroIngresado = int.Parse(Console.ReadLine());

    if (numeroIngresado >= 1 && numeroIngresado <= 20)
    {
        if (numeroIngresado > numeroSecreto)
        {
            /*3) Si el número ingresado por el usuario es mayor al número secreto, 
            avisarle que es muy grande y que intente de nuevo y que vuelva al paso 2.*/

            Console.WriteLine("El número ingresado es muy grande. Reinténtelo nuevamente");
        }
        else if (numeroIngresado < numeroSecreto)
        {
            /*4) Si el numero ingresado es menor al número secreto, avisarle que es muy chico, 
            y que intente de nuevo volviendo al paso 2.*/

            Console.WriteLine("El número ingresado es muy pequeño. Reinténtelo nuevamente");
        }
        else
        {
            /*5) Si el número ingresado coincide con el número
            secreto, sacar el siguiente mensaje:
            "Felicitaciones, has adivinado el número
            secreto que era:  [numeroSecreto] "
            "Lo has logrado en [n] intentos!!"*/

            Console.WriteLine("Felicitaciones, has adivinado el número\n" +
                              $"secreto que era: {numeroSecreto}\n" +
                              $"Lo has logrado en {contador} intentos!!");
            Console.WriteLine("Fin del juego");
        }
    }
    else
    {   //Valido si se ingresan valores por fuera del rango solicitado

        Console.WriteLine("Error! Debe ingresar valores enteros positivos del 1 al 20." +
                          "Reinténtelo nuevamente");
    }
    //Incremento contador
    contador++;
}
while (numeroIngresado != numeroSecreto);