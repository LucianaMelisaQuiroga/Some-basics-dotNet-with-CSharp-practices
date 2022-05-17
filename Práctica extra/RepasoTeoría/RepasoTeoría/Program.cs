//***********************Declaración e inicialización de constantes**************//
//Año de ignaugurción de la compañía
const int AnioIgnauguracion = 2005; //se declaran e inicializan en lamisma linea siempre

//**********************Declaración de variables*********************************//
//Año de campaña actual
//ushort campana;
//**********************Inicialización de variables*********************************//
//campana = 2022; 
int campana = 2022; //o ambos pasos en una misma linea de código

//***************************Operaciones********************************************//
//Años de la compañía en el mercado
int aniosCompania = campana - AnioIgnauguracion;
Console.WriteLine($"La empresa nació en el año {AnioIgnauguracion}, está presente en el mercado desde hace {aniosCompania} años");
//También puedo escribir las operaciones dentro de Console.WriteLine
Console.WriteLine($"La empresa nació en el año {AnioIgnauguracion}, está presente en el mercado desde hace {campana - AnioIgnauguracion} años");

//***************************Declaración de variables del mismo tipo de dato también en una sóla linea**//
int cantidadEmpleados = 25;
Console.WriteLine($"Tenemos un equipo formado por {cantidadEmpleados} profesionales, y estamos buscando expandernos. We Are Hiring!");

//***************************Input de usuario****************************************// 
Console.WriteLine("Ingresa tu nombre");
string nombreUsuario = Console.ReadLine();

Console.Write($"Hola {nombreUsuario}"); //Console.Write() no tiene salto de linea 
Console.WriteLine(". Bienvenida/o a nuestra compañía"); //Console.WriteLine() sí tiene salto de linea

//***************************Parseado*************************************************//
Console.WriteLine("Cuántos años de experiencia tenés en programación?");
int aniosExperienciaProgramacion = int.Parse(Console.ReadLine()); //lo convierto a numérico xq el programa hará operaciones aritméticas con la variable

Console.WriteLine($"Mi nombre es {nombreUsuario} y tengo {aniosExperienciaProgramacion} de experiencia programando");

Console.WriteLine("Presiona Enter para finalizar la sesión");
Console.ReadKey();

//***************************Tipo de datos C#****************************//

//Integers: 
int number_int = 2147483647;
Console.WriteLine(number_int);

uint number_uint = 3000000000U;
Console.WriteLine(number_uint);

short number_short = 32767;
Console.WriteLine(number_short);

ushort number_ushort = 32768;
Console.WriteLine(number_ushort);

long number_long = 700000000000000000L;
Console.WriteLine(number_long);

ulong number_ulong = 18000000000000000000UL;
Console.WriteLine(number_ulong);

byte number_byte = 148;
Console.WriteLine(number_byte);

sbyte number_sbyte = 125;
Console.WriteLine(number_sbyte);

//Floating-point:
float number_float = 3.000007F;
Console.WriteLine(number_float);

double number_double = 1.79000000222235D;
Console.WriteLine(number_double);

decimal number_decimal = 7.3e28M;
Console.WriteLine(number_decimal);

//Otros tipos de datos: 
bool tareaTerminada = false;
Console.WriteLine(tareaTerminada);

char letra = 'q';
Console.WriteLine(letra);

string mensaje = "Esto es un string";
Console.WriteLine(mensaje);

//quedan por ver más adelante los tipos de datos dinámicos