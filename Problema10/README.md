# Problema10

Problema 10. Analizador de datos recibidos
Estructura elegida

switch con patrones de tipo (pattern matching).

Justificación

Se utiliza esta estructura porque permite reconocer el tipo real del dato almacenado en una variable object y ejecutar el bloque correspondiente.

Pruebas de ejecución

Para cada prueba, cambia el valor de dato en Program.cs, ejecuta el programa y comprueba la salida.

Prueba 1: Texto

Dato:

object dato = "SENA";

Salida esperada:

Texto de 4 caracteres

Prueba 2: Entero

Dato:

object dato = 42;

Salida esperada:

Entero: 42

Prueba 3: Decimal

Dato:

object dato = 3.14;

Salida esperada:

Decimal: 3.14

Prueba 4: Booleano verdadero

Dato:

object dato = true;

Salida esperada:

Booleano: True

Prueba 5: Booleano falso

Dato:

object dato = false;

Salida esperada:

Booleano: False

Prueba 6: Tipo no reconocido

Dato:

object dato = 'A';

Salida esperada:

Tipo no reconocido

Evidencia

Captura de la ejecución guardada en evidencias/salida.png.
