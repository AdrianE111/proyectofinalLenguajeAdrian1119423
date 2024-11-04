# proyectofinalLenguajeAdrian1119423
Proyecto Final Lenguaje Formales y Automatas

Programa principal (Program.cs)
El archivo Program.cs es el punto de entrada del programa, que coordina la carga de datos y la ejecución de la máquina de Turing para cada cadena en el archivo de entrada.

Tareas clave en Program.cs incluyen:

Carga de datos: Utiliza la ruta especificada (filePath) para cargar las cadenas desde un archivo de texto.
Procesamiento de cadenas: Itera sobre cada cadena cargada y, para cada una, crea una instancia de la máquina de Turing que realiza el procesamiento en ambas direcciones, izquierda a derecha y derecha a izquierda. Luego, muestra los resultados.

Variables y métodos importantes en MaquinaTuring.cs:

MostrarInformacionMaquina(string cadena): Muestra la información básica de la máquina de Turing, como el alfabeto, los estados y una división de la cadena en caracteres pares e impares. También utiliza la clase DosCintas para mostrar las cintas en ambas direcciones.
ProcesarCadena(string cadena): Este método aplica las transiciones a cada símbolo en la cadena usando el autómata (AFD). Configura un árbol de derivación (nodos de estados) y verifica si la cadena es válida o no. Además, imprime el árbol de derivación y el estado final.
PrintTree(Node node, string indent, bool last): Imprime el árbol de derivación, mostrando las transiciones entre los estados en formato visual.
Autómata Finito Determinista (AFD.cs)
La clase AFD modela las transiciones de la máquina de Turing y se encarga de verificar si una cadena es válida o no en función de sus transiciones. Almacena y utiliza las pilas de estados, caracteres aceptados y errores.

Variables y métodos importantes en AFD.cs:

tablaTransiciones: Diccionario que mapea el estado actual y el carácter de entrada al próximo estado, definiendo el grafo de transición de la máquina.
pilaEstados, pilaAceptados, pilaErrores: Pilas que mantienen un historial de estados visitados, caracteres aceptados, y errores, respectivamente.
Métodos principales:

VerificarCadena(string cadena, Node root): Procesa cada carácter de la cadena siguiendo las transiciones definidas. Actualiza el árbol de derivación (root) y las pilas de estado y caracteres. Verifica si la cadena es válida o no al alcanzar un estado de aceptación.
ObtenerSiguienteEstado(string estadoActual, char caracter): Retorna el próximo estado según el carácter leído y el estado actual.
PrintTransitionTable(): Imprime la tabla de transición que detalla cada movimiento posible del autómata.
PrintStackInfo(): Muestra el contenido de las pilas de estados, caracteres aceptados y errores, proporcionando un registro de los estados alcanzados durante el procesamiento de cada cadena.
Procesador de Cintas Duales (DosCintas.cs)
La clase DosCintas representa las dos cintas en la máquina de Turing y permite ver cada cadena de entrada en ambas direcciones, izquierda a derecha y derecha a izquierda.

Variables y métodos importantes en DosCintas.cs:

Cinta1: Almacena la cadena original (izquierda a derecha).
Cinta2: Almacena la cadena en orden inverso (derecha a izquierda).
Métodos principales:

MostrarCintas(): Muestra la cadena en ambas direcciones para cada cadena procesada. Facilita observar cómo se lee la cinta desde el inicio y desde el final, emulando las dos cintas de la máquina de Turing.
Nodos del Árbol de Derivación (Node.cs)
La clase Node representa cada nodo en el árbol de derivación de la máquina de Turing. Cada nodo contiene un valor (estado) y una lista de hijos, formando un árbol que visualiza las transiciones y los errores.

Variables importantes en Node.cs:

Value: Almacena el nombre del estado en el nodo.
Children: Lista de nodos hijos que representan las transiciones desde el estado actual a otros estados en el proceso de verificación de la cadena.
