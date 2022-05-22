/**********************Matrices en C#***********************/
//Guarda en una variable varios datos de un mismo tipo
//Es mutable
//Puede ser unidimensional (array/vector), o multidimensional

/*******Declaración de Matrices unidimensional o array******/
//Matriz Unidimensional o Array o Vector
string[] autos = new string[3]; //se declaran cuántas posiciones tendrá

/*****Inicialización de la matriz unidimensional o array****/
autos[0] = "Volvo";
autos[1] = "Fiat";
autos[2] = "BMW";
//autos[3] = "Toyota";
//Console.WriteLine(autos[0]); //El índice 3 al estar fuera de rango tirará error
Console.WriteLine(autos[0]); //imprime el primer elemento que corresponde a la primer posición

//o puedo declarar e inicializar en el mismo momento
string[] cars = { "Volvo", "Fiat", "BMW" };
Console.WriteLine(cars[0]); //imprime el primer elemento que corresponde a la primer posición

//o declarar la matriz y luego asignarle los valores de cada elemento de a uno
string[] colores = new string[3]; //se declaran cuántas posiciones tendrá 3 posiciones->índices 0, 1, 2
colores[0] = "Celeste";
colores[1] = "Rojo";
colores[2] = "Verde";
Console.WriteLine($"En el índice 0 usted ingresó {colores[0]}"); //imprime el primer elemento que corresponde a la primer posición

/************Cambio el valor de uno de los elementos*********/
colores[0] = "Violeta"; //se reasigna el valor
Console.WriteLine($"Ahora en el índice 0 le asignó el color {colores[0]}");

/*******************Matriz unidimensional con inputs**********/
int[] numeros = new int[3]; //se declaran cuántas posiciones tendrá 3 posiciones->índices 0, 1, 2
int acumulador = 0; //Declaro e inicializo la variable acumulador para poder sumar los elementos desde el inicio

//Ciclo for para ingresar cada elemento a través de inputs 
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el número de la posición {i + 1}:");
    numeros[i] = int.Parse(Console.ReadLine());
    //Acumula la suma de todos los elementos del array/matriz unidimensional
    acumulador += numeros[i];

    //Imprimo los números ingresados
    Console.WriteLine($"En el índice {i} usted ingresó {numeros[i]}"); //Si quisiera imprimir luego de ingresado los elementos,
                                                                       //entonces debo hacer otro for igual luego
}
//Imprimo la suma de los elementos
Console.WriteLine($"La suma de los elementos es: {acumulador}");

//Imprimo la cantidad de posiciones del array
Console.WriteLine($"El array tiene {numeros.Length} posiciones");


/*******************Matriz unidimensional con inputs**********/
//La diferencia con el anterior, es que imprimo todos los elementos juntos una vez que fueron ingresados
int[] numbers = new int[5]; //se declaran cuántas posiciones tendrá 3 posiciones->índices 0, 1, 2
int suma = 0; //Declaro e inicializo la variable acumulador para poder sumar los elementos desde el inicio

//Ciclo for para ingresar cada elemento a través de inputs 
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Ingrese el número de la posición {i + 1}:");
    numbers[i] = int.Parse(Console.ReadLine());
    //Acumula la suma de todos los elementos del array/matriz unidimensional
    suma += numbers[i];
}
//Imprimo la suma de los elementos
Console.WriteLine($"La suma de los elementos es: {suma}");

//Imprimo la cantidad de posiciones del array
Console.WriteLine($"El array tiene {numbers.Length} posiciones");

//Hago otro for igual al anterior para imprimir luego de ingresado los elementos
for (int i = 0; i < numbers.Length; i++)
{
    //Imprimo los números ingresados
    Console.WriteLine($"En el índice {i} usted ingresó {numbers[i]}");
}