//Ciclo while - Juego adivine el número
int juegoAzar;
int contador = 1;

Console.WriteLine("Ingrese un número al azar del 1 al 10\nQue comience el juego!!");
juegoAzar = int.Parse(Console.ReadLine());

while (juegoAzar != 5)
{
    contador++;
    Console.WriteLine("Le erraste, vuelve a intentarlo!!\n" +
                      "Ingrese un número al azar del 1 al 10");
    juegoAzar = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Ganaste!! Acertaste en el intento número {contador}");