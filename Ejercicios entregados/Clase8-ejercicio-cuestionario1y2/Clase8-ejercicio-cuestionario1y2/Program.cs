/*Clase 8: Tarea: 
Escribe la respuesta a la pregunta 1 - Cuál es la diferencia entre un vector y una matriz?

Respuesta:
Ambas son estructuras de datos y se diferencian en la forma de acceder a cada elemento. 
Los vectores son unidimensionales y se accede a cada elemento con un sólo índice [i] por posición. 
El primer elemento que corresponde a la primer posición es nombreVariableVector[0]. 
Su recorrido es mediante un for.

En cambio en las matrices, que pueden tener 2 dimensiones, para acceder a cada elemento es mediante 
2 índices [fila,columna] por posición. 
El primer elemento que corresponde a la primer posición es nombreVariableMatriz[0,0]. 
Hay también matrices de más dimensiones llamadas multidimensionales y se accede con tantos índices 
como dimensiones tenga.
Su recorrido es mediante for anidados, tantos for como dimensiones tenga.


Escribe la respuesta a la pregunta 2 - De qué manera recorro una matriz de 2 dimensiones?

Respuesta:
La manera de recorrer una matriz de dos dimensiones es mediante un for anidado (con otro for). 
Con el primer for se ingresa al 1° elemento de índice [0,0], y con el 2° for anidado se recorren todos 
los elementos de la fila, que corresponden a cada columna. Luego vuelve al 1° for y pasa a la siguiente 
fila, el 2° for recorre todos los elementos de la fila que corresponden a esas columnas, y así sucesivamete. 
Cuando se vuelve a evaluar la condición del 1° for, luego de ya haber recorrido todos los elementos de la 
matriz, el bloque de código finaliza*/