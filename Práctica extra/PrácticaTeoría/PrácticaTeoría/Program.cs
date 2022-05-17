//*******************************Operaciones C#***********************************// 

//Total de Bitcoins a emitirse según el whitepapper de Satoshi Nakamoto
const int TotalBitcoin = 20000000;

Console.WriteLine("Ingrese la cantidad de Bitcoins que hay en circulación");
int bitcoinCirculacion = int.Parse(Console.ReadLine());

//Bitcoins que faltan emitirse
int bitcoinAemitirse = TotalBitcoin - bitcoinCirculacion;
Console.WriteLine($"Quedan por emitirse {bitcoinAemitirse} BTC");

//Precio del BTC por unidad
Console.WriteLine("Ingrese el precio del BTC");
double precioBitcoin = double.Parse(Console.ReadLine());

/*El valor total del circulante en el mercado en criptomonedas Bitcoin
multiplico un double con un integer convertido a double*/
double totalMarketcap = (Convert.ToDouble(bitcoinCirculacion)) * precioBitcoin;
Console.WriteLine($"El valor total del circulante en el mercado en criptomonedas Bitcoin es U$D {totalMarketcap}");

Console.WriteLine("Presione Enter");
Console.ReadKey();