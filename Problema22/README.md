# Problema22

Problema 22. Calculadora básica
Estructura elegida

switch con excepciones mediante throw y manejo con try-catch.

Justificación

Se utiliza switch para ejecutar la operación indicada y excepciones para controlar la división entre cero y los operadores no soportados.

Pruebas de ejecución
Prueba 1: Multiplicación

Entrada: 12, 4, \*.

Salida esperada:

Ingrese el primer número entero: 12
Ingrese el segundo número entero: 4
Ingrese el operador (+, -, _, /): _
12 \* 4 = 48

Prueba 2: División entre cero

Entrada: 10, 0, /.

Salida esperada:

Ingrese el primer número entero: 10
Ingrese el segundo número entero: 0
Ingrese el operador (+, -, \*, /): /
No se puede dividir entre cero

Prueba 3: Operador no soportado

Entrada: 5, 2, %.

Salida esperada:

Ingrese el primer número entero: 5
Ingrese el segundo número entero: 2
Ingrese el operador (+, -, \*, /): %
Operador no soportado

Prueba 4: Suma

Entrada: 8, 3, +.

Salida esperada:

Ingrese el primer número entero: 8
Ingrese el segundo número entero: 3
Ingrese el operador (+, -, \*, /): +
8 + 3 = 11

Prueba 5: División

Entrada: 9, 2, /.

Salida esperada:

Ingrese el primer número entero: 9
Ingrese el segundo número entero: 2
Ingrese el operador (+, -, \*, /): /
9 / 2 = 4.5

Evidencia

Guardar las capturas reales en evidencias
