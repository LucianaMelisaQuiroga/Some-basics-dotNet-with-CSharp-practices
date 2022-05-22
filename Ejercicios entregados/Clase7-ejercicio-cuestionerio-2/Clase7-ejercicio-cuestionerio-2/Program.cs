/*Clase 7: Tarea: Escribe la respuesta a la pregunta 2 - Cuál es la diferencia entre un acumulador y un contador?

Respuesta: 
Acumulador: variable que se modifica a sí misma con "valores variables" cada vez que se produce un suceso.
    Operaciones aritméticas posibles con acumuladores: +, -, *, /.

Ejemplo con total de venta semanal:*/
float totalVentaSemanal = 0; //Declaro e inicializo la variable acumulador

for (int i = 1; i < 8; i++)
{
    Console.WriteLine("Ingrese el monto total de ventas del día:");
    float montoVentaDiaria = float.Parse(Console.ReadLine());
    //modifico el acumulador en cada suceso con valores variables
    totalVentaSemanal += montoVentaDiaria;
}
Console.WriteLine($"La venta total semanal suma ${totalVentaSemanal}");

/*Contador: variable que se modifica a sí misma con "un valor constante" cada vez que se produce un suceso.
    Operaciones aritméticas posibles con contadores: +, -. (Esos valores constantes pueden ser de 1 en 1, o de n en n, 
    donde n es un valor distinto de 1 pero constante en todos los sucesos). 

Ejemplo con un llamador de turnos de 100 números*/
int turno = 1; //Declaro e inicializo a la variable contador

for (int i = 0; i < 100; i++)
{
    //modifico el contador en cada suceso con un valor constante
    Console.WriteLine($"Llamado a cliente con el número {turno + i} para su atención");
    Console.WriteLine("Presione Enter para llamar al siguiente cliente");
    Console.ReadKey();
}