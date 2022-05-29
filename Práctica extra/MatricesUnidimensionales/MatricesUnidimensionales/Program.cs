/**********************Matrices en C#***********************/
//Guarda en una variable varios datos de un mismo tipo
//Es mutable
//Puede ser unidimensional (array/vector), bidimensionales o multidimensional

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


/***********Valores por defecto en arrays/vectores**************/

/*Hasta no asignarle los elementos a cada posición, cada espacio en memoria guarda
un valor por defecto dependiendo del tipo de dato*/
int[] myIntArray;
myIntArray = new int[5];
Console.WriteLine(myIntArray[3]); //por defecto imprime 0

float[] myFloatArray;
myFloatArray = new float[5];
Console.WriteLine(myFloatArray[3]); //por defecto imprime 0

string[] myStringArray;
myStringArray = new string[5];
Console.WriteLine(myStringArray[3]); //por defecto imprime un espacio vacío

char[] myCharArray;
myCharArray = new char[5];
Console.WriteLine(myCharArray[3]); //por defecto imprime un espacio vacío

double[] myDoubleArray;
myDoubleArray = new double[5];
Console.WriteLine(myDoubleArray[3]); //por defecto imprime 0

//string[] myStringArray;
//myStringArray = new string[5];
myStringArray = new string[5] { "Ana", "Martina", "", "Sofia", "Lucia" };
Console.WriteLine(myStringArray[2]);
Console.WriteLine(myStringArray[3]);

//int[] myIntArray;
//myIntArray = new int[5];
myIntArray[0] = 1;
myIntArray[1] = 2;
//myIntArray[2] //lo dejo vacío
myIntArray[3] = 4;
myIntArray[4] = 5;
Console.WriteLine(myIntArray[2]);
Console.WriteLine(myIntArray[3]);
Console.WriteLine();


/***********Arrays/vectores - Uso del método .Length***********************/
/
/*Creo un array de 5 elementos con inputs por pantalla, imprimo los valores 
 y calculo el promedio del array*/
Console.WriteLine("===============================================");
Console.WriteLine("Array de 5 elementos");
Console.WriteLine("===============================================");

int[] numerosArray = new int[5];
int sumaArray = 0;
float promedio = 0;

for (int i = 0; i < numerosArray.Length; i++)
{
    Console.WriteLine($"Ingrese el valor para el {i + 1}° elemento del array");
    numerosArray[i] = int.Parse(Console.ReadLine());
    sumaArray += numerosArray[i];
}
Console.WriteLine("===============================================");

Console.WriteLine("El vector tiene los siguientes valores:");
for (int i = 0; i < numerosArray.Length; i++)
{
    Console.WriteLine(numerosArray[i]);
}
Console.WriteLine("================================================");

promedio = (float)sumaArray / numerosArray.Length;
Console.WriteLine($"El promedio de los valores del array es {promedio}");

Console.WriteLine();


/*Similar que el anterior, sólo que el tamaño del array lo define el usuario por pantalla, 
imprimo los valores y calculo el promedio del array*/
Console.WriteLine("===============================================");
Console.WriteLine("Array de n elementos, definido por el usuario");
Console.WriteLine("===============================================");

Console.WriteLine("Ingrese la cantidad de elementos del array");
int elementosArray = int.Parse(Console.ReadLine());

int[] numerosArray_ = new int[elementosArray];
int sumaArray_ = 0;
float promedio_ = 0;

for (int i = 0; i < numerosArray_.Length; i++)
{
    Console.WriteLine($"Ingrese el valor para el {i + 1}° elemento del array");
    numerosArray_[i] = int.Parse(Console.ReadLine());
    sumaArray_ += numerosArray_[i];
}
Console.WriteLine("===============================================");

Console.WriteLine("El vector tiene los siguientes valores:");
for (int i = 0; i < numerosArray_.Length; i++)
{
    Console.WriteLine(numerosArray_[i]);
}
Console.WriteLine("================================================");

promedio_ = (float)sumaArray_ / numerosArray_.Length;
Console.WriteLine($"El promedio de los valores del array es {promedio_}");

Console.WriteLine();


/***********Arrays/vectores de tipo implícito***************************/

/*se declara sin especificar tipo de dato, ni tamaño del array. Se debe asignar 
los elementos al momento de declararlo, por lo que el array implícito debe ser 
inicializado siempre*/

//Array implícito de números enteros
var arrayImplicitoInt = new[] { 2, 4, 5, 7 };

//Para recorrer el array implícito
Console.WriteLine("Elementos en array implícito de integers:");
for (int i = 0; i < arrayImplicitoInt.Length; i++)
{
    Console.WriteLine($"El {i + 1}° valor es {arrayImplicitoInt[i]}");
}


//Array implícito de números doubles
var arrayImplicitoDouble = new[] { 2.53, 4.53, 5.54, 7.55 };

//Para recorrer el array implícito
Console.WriteLine("Elementos en array implícito de doubles:");
for (int i = 0; i < arrayImplicitoDouble.Length; i++)
{
    Console.WriteLine($"El {i + 1}° valor es {arrayImplicitoDouble[i]}");
}


//Array implícito de números doubles con enteros
//Con que haya 1 sólo double en un array de integers, ese o convierte en un array de doubles
var arrayImplicitoDoubleInt = new[] { 2, 4.53, 5, 7 };

//Para recorrer el array implícito
Console.WriteLine("Elementos en array implícito de doubles y enteros:");
for (int i = 0; i < arrayImplicitoDoubleInt.Length; i++)
{
    Console.WriteLine($"El {i + 1}° valor es {arrayImplicitoDoubleInt[i]}");
}


//Array implícito de strings
var arrayImplicitoStrings = new[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

//Para recorrer el array implícito con for
Console.WriteLine("Elementos en array implícito de strings:");
for (int i = 0; i < arrayImplicitoStrings.Length; i++)
{
    Console.WriteLine($"El {i + 1}° valor es {arrayImplicitoStrings[i]}");
}

//foreach para recorrer arrays implícitos. Menos uso de código para recorrerlo
foreach (string var in arrayImplicitoStrings)
{
    Console.WriteLine(var);
}