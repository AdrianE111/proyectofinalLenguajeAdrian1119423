# proyectofinalLenguajeAdrian1119423
Proyecto Final Lenguaje Formales y Automatas
Adrián Escalón Illescas Carné 1119423

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Programa Principal (Program.cs)
Program.cs es el punto de entrada del programa y coordina la ejecución de la máquina de Turing para procesar cada cadena leída desde un archivo de texto.

Variables importantes:
filePath: Ruta del archivo de texto con las cadenas de entrada.
cadenas: Lista que almacena las cadenas leídas desde el archivo.
maquina: Instancia de la clase MaquinaTuring para procesar cada cadena.

Métodos importantes:
Main(): Carga las cadenas desde el archivo especificado en filePath, y para cada cadena, instancia y utiliza MaquinaTuring para procesarla en ambas direcciones (izquierda a derecha y derecha a izquierda), mostrando los resultados en pantalla.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Máquina de Turing (MaquinaTuring.cs)
MaquinaTuring simula el funcionamiento de una máquina de Turing con dos cintas, procesando cada cadena en ambas direcciones y generando el árbol de derivación, la tabla de transición y detalles de la cinta.

Variables importantes:
afd: Instancia de la clase AFD que representa el autómata finito determinista utilizado en la máquina de Turing.
dosCintas: Instancia de la clase DosCintas que maneja la representación de la cadena en ambas direcciones.
rootNode: Nodo raíz del árbol de derivación, que se usa para mostrar la secuencia de estados durante el procesamiento de la cadena.

Métodos importantes:
MostrarInformacionMaquina(string cadena): Muestra el alfabeto de la máquina, los estados, y las representaciones de la cadena en pares, impares, izquierda a derecha y derecha a izquierda, utilizando la clase DosCintas.
ProcesarCadena(string cadena): Procesa la cadena a través del autómata finito (AFD), generando el árbol de derivación y verificando la validez de la cadena.
PrintTree(Node node, string indent, bool last): Imprime el árbol de derivación, permitiendo visualizar el recorrido de la cadena a través de los estados.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Autómata Finito Determinista (AFD.cs)
AFD modela el autómata finito determinista, definendo el grafo de transiciones de la máquina de Turing y verificando la validez de una cadena. También, gestiona pilas para almacenar el historial de estados, caracteres aceptados y errores.

Variables importantes:
tablaTransiciones: Diccionario que representa las transiciones del autómata, mapeando cada combinación de estado y carácter de entrada al siguiente estado.
pilaEstados: Pila que almacena los estados visitados durante el procesamiento de la cadena.
pilaAceptados: Pila que almacena los caracteres aceptados en cada transición.
pilaErrores: Pila que almacena los caracteres que causaron un error en el procesamiento.

Métodos importantes:
VerificarCadena(string cadena, Node root): Recorre cada carácter de la cadena, actualiza el árbol de derivación y las pilas de estado, y determina si la cadena es válida.
ObtenerSiguienteEstado(string estadoActual, char caracter): Calcula el siguiente estado a partir del estado actual y el carácter leído según las reglas de transición.
PrintTransitionTable(): Imprime la tabla de transición del autómata, mostrando cómo se mueve de un estado a otro.
PrintStackInfo(): Muestra el contenido de las pilas pilaEstados, pilaAceptados y pilaErrores.


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Procesador de Cintas Duales (DosCintas.cs)
DosCintas maneja la representación de cada cadena en ambas direcciones (izquierda a derecha y derecha a izquierda).

Variables importantes:
Cinta1: Almacena la cadena en su orden original, de izquierda a derecha.
Cinta2: Almacena la cadena invertida, representando el orden de derecha a izquierda.

Métodos importantes:
MostrarCintas(): Imprime la cadena en ambas direcciones, facilitando el análisis visual de cómo se procesa en ambas cintas.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Nodos del Árbol de Derivación (Node.cs)
Node representa un nodo en el árbol de derivación, que se utiliza para modelar las transiciones de estado en el autómata.

Variables importantes:
Value: Almacena el valor o nombre del estado representado en el nodo.
Children: Lista de nodos hijos que representan las posibles transiciones desde el estado actual.

Métodos importantes:
Node(string value): Constructor que inicializa el nodo con un valor y una lista vacía de hijos.

