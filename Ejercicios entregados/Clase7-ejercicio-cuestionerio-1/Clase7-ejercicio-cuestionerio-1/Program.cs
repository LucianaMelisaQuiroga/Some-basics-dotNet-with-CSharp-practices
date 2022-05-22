/*Clase 7: Tarea: Escribe la respuesta a la pregunta 1 - Cuál es el primer elemento de una matriz?

Respuesta:
Para una matriz unidimensional/array/vector el primer elemento es el del índice 0->variable[0], 
para una matriz multidimensional el primer elemento es el índice 0,0->variable[0,0], que 
corresponde a la primer posición. 

Ejemplo con un array:*/
string[] colores = new string[3];
colores[0] = "Celeste";
colores[1] = "Rojo";
colores[2] = "Verde";
Console.WriteLine("El primer elemento de la matriz unidimensional " +
                 $"que se encuentra en el índice 0 es {colores[0]}");