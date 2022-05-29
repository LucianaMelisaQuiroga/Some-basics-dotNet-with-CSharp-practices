/**********Conversión de tipos de datos entre primitivos. Casting implícito y explícito************/
//Método para convertir datos, que son compatibles entre sí, en otro de diferente alcance.

/**************************************Casting implícito*******************************************/
//de int a double
int numero1 = 9;
double numero2 = numero1;

//de int a long
int numero3 = 9;
double numero4 = numero3;

//de int a float
int numero5 = 9;
double numero6 = numero5;

//de int a decimal
int numero7 = 9;
decimal numero8 = numero7;

//de float a double
float numero9 = 9.45f;
double numero10 = numero9;

/**************************************Casting explícito*******************************************/
//de float a decimal
float numero11 = 9.45f;
decimal numero12 = (decimal)numero11;

//de float a int
float numero13 = 9.45f;
int numero14 = (int)numero13;

//de double a decimal
double numero15 = 9.45d;
decimal numero16 = (decimal)numero15;

//de double a int
double numero17 = 9.45d;
int numero18 = (int)numero17;

//de double a float
double numero19 = 9.45d;
float numero20 = (float)numero19;

//de decimal a double
decimal numero21 = 9.45m;
double numero22 = (double)numero21;

//de decimal a float
decimal numero23 = 9.45m;
float numero24 = (float)numero23;

//de decimal a int
decimal numero25 = 9.45m;
int numero26 = (int)numero25;

/***********************Método para convertir tipos de datos que no son compatibles***************/
//Método .Parse(): 

//de texto a int
Console.WriteLine("Ingrese un número");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(num1);

//de texto a float
Console.WriteLine("Ingrese un número");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine(num2);

//de texto a double
Console.WriteLine("Ingrese un número");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine(num3);

//de texto a decimal
Console.WriteLine("Ingrese un número");
decimal num4 = decimal.Parse(Console.ReadLine());
Console.WriteLine(num4);