//Método para validar datos en inputs (.ToUpper, .ToLower)
Console.WriteLine("Desea continuar con la operación?\nS para Si\nN para No");
var respuesta = Console.ReadLine();

if (respuesta.ToUpper() == "S")
{
    Console.WriteLine("Continua");
}
else if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Finaliza sesión");
}
else
{
    Console.WriteLine("Ingrese una opción correcta");
}