/*Actividad Obligatoria Clase 6 - Cuestionario

1 - Puedo declarar mútiples variables en una sóla linea utilizando var. V/F?
Respuesta: [FALSO]

Justificación: 
Las variables de tipo implícito (es decir declaradas con var), no pueden tener varios declaradores.
Tiene 1 sólo declarador y se debe inicializar. 

No es correcto el siguiente uso de var:

var nombre1, edad1, inicialApellido1, monto1, servicio1;
nombre1 = "Luciana";
monto1 = 12345.678;
servicio1 = true;

//,ni
var numeroA;
numeroA = 7;
*/

/**************************El correcto uso de var es el siguiente************/
var nombreUsuario = "Luciana";
var monto = 12345.67;
var servicioContratado = true;
var numero = 7;

/*2 - En qué parte del código debe declarar e inicializar una variable para poder leer su valor? 
1-Al principio del programa sí o sí.
2-Debe declararse siempre antes de ser utilizada.
3-Puedo declarla en cualquier parte del código. 

Respuesta: [2-Debe declararse siempre antes de ser utilizada.]

Justificación:
Siguiendo el flujo de la programación estructurada, una variable local puede ser leída si 
previamente fue declarada e inicializada. La declaración puede ser al inicio del programa, 
inicializada más adelante, o declarada e inicializada en un mismo momento, pero usada si 
previamente sucedió lo anterior.

No es correcto el siguiente:

Console.WriteLine("Ingrese su usuario de classroom");
nombreAlumno1 = Console.ReadLine();

string nombreAlumno1;
*/

/**************************El órden correcto es el siguiente************/
string nombreAlumno;

Console.WriteLine("Ingrese su usuario de classroom");
nombreAlumno = Console.ReadLine();