//Tabla de multiplicar 
int tabla;

Console.WriteLine("Ingrese la tabla de multiplicar que necesita");
tabla = int.Parse(Console.ReadLine());
Console.WriteLine($"Usted solicitó la tabla del {tabla}");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{tabla} * {i} = {tabla * i}");
}