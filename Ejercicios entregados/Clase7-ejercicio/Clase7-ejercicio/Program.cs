/*Clase 7: Tarea - Ejercicio 
Escribir un programa que haga lo siguiente:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números. 
6) Mostrar todos los números ingresados por pantalla. 
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.*/


//Declaro e inicializo la variable acumulador para poder calcular la suma de los elementos
float sumaNumeros = 0;

/*Declaro e inicializo la variable para poder comparar e identificar cuál es el número mayor
de los ingresados*/
float numeroMayor = 0;

/*Declaro e inicializo la variable para poder comparar e identificar cuál es el número menor
de los ingresados*/
float numeroMenor = 0;

/*Declaro e inicializo la variable para poder calcular el promedio de los números
 ingresados*/
float promedioNumerosIngresados = 0;

//1) Pida 10 números al usuario
//Defino la cantidad de posociones del array
float[] numeroIngresado = new float[10];

Console.WriteLine($"Ingrese 10 números");
//Ciclo for para ingresar cada elemento al array a través de inputs 
for (int i = 0; i < numeroIngresado.Length; i++)
{
    Console.WriteLine($"Ingrese el {i + 1}° número");
    numeroIngresado[i] = float.Parse(Console.ReadLine());

    //2) Obtener la suma de todos los números ingresados
    sumaNumeros += numeroIngresado[i];

    //3) Obtener cuál es el mayor de todos los números
    if (i == 0)
    {
        numeroMayor = numeroIngresado[i];
    }
    else if (numeroIngresado[i] > numeroMayor)
    {
        numeroMayor = numeroIngresado[i];
    }
    //4) Obtener cuál es el menor de todos los números
    if (i == 0)
    {
        numeroMenor = numeroIngresado[i];
    }
    else if (numeroIngresado[i] < numeroMenor)
    {
        numeroMenor = numeroIngresado[i];
    }
}

//5) Obtener el promedio de todos los números
promedioNumerosIngresados = sumaNumeros / numeroIngresado.Length;

//6) Mostrar todos los números ingresados por pantalla 
Console.WriteLine("Los números ingresados son:");
for (int i = 0; i < numeroIngresado.Length; i++)
{
    Console.WriteLine(numeroIngresado[i]);
}

//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5
Console.WriteLine($"La suma total de los números ingresados es {sumaNumeros}.\n" +
                 $"El mayor es de los números ingresados es {numeroMayor}.\n" +
                 $"El menor es de los números ingresados es {numeroMenor}.\n" +
                 $"El promedio de los números ingresados es {promedioNumerosIngresados}.");