/*Clase 8: Tarea - Ejercicio 
Escribir un programa que haga lo siguiente:

1) Crear una matriz de dos dimensiones de tipo int llamada números
2) Determinar el tamaño de cada dimansión (fila, columnas) mediante 
valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posición 
correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios*/


/*2) Determinar el tamaño de cada dimensión (fila, columnas) mediante
valores ingresados por pantalla*/
Console.WriteLine("Ingrese cuántas filas desea que tenga la matriz");
//Se inicializa la variable filas mediante definición del usuario
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cuántas columnas desea que tenga la matriz");
//Se inicializa la variable columnas mediante definición del usuario
int columnas = int.Parse(Console.ReadLine());

//1) Crear una matriz de dos dimensiones de tipo int llamada números
int[,] numeros = new int[filas, columnas];

/*Para especificar la condición en el for calculo cuál es su length
tanto para filas como para columnas ingresadas por el usuario*/

//Total de filas de la matriz
int lengthFilas = numeros.GetUpperBound(0) + 1;

//Total de columnas de la matriz
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//3) Declarar un vector de tipo double llamado promedios
double[] promedios = new double[lengthColumnas];

//4) Recorrer la matriz para su carga con elementos de tipo int
for (int fila = 0; fila < lengthFilas; fila++)
{
    Console.WriteLine($"Para los valores de la {fila + 1}° fila:");
    for (int columna = 0; columna < lengthColumnas; columna++)
    {
        Console.WriteLine($"Ingrese el valor de la {columna + 1}° columna");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

//6) Calcular el promedio de cada columna y asignarlo a la posición correspondiente dentro del vector promedios
for (int columna = 0; columna < lengthColumnas; columna++)
{
    //Inicializo fuera del 2° bucle para que con cada iteración el acumuladorr vuelva a cero
    double sumaNumeros = 0;
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        sumaNumeros += numeros[fila, columna];
        promedios[columna] = sumaNumeros / lengthFilas;
    }
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------");

//5) Recorrer la matriz para mostrar cada valor
Console.WriteLine($"La matriz ingresada de {lengthFilas} filas y {lengthColumnas} columnas es:");
Console.WriteLine();

for (int fila = 0; fila < lengthFilas; fila++)
{
    for (int columna = 0; columna < lengthColumnas; columna++)
    {
        Console.Write($"{numeros[fila, columna]:00} | ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------");

//7) Mostrar los promedios recorriendo el vector promedios
Console.WriteLine("El promedio de cada columna es:");
Console.WriteLine();

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.Write($"{promedios[columna]:00.00} | ");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------");