# Problema29

Problema 29. Control de acceso a la sede
Estructura elegida

if - else if - else con condiciones compuestas.

Justificación

Se utiliza esta estructura porque cada rol tiene un horario específico de acceso, excepto el administrador, que puede entrar a cualquier hora válida.

Pruebas de ejecución
Prueba 1: Administrador a las 2

Entrada: rol admin, hora 2.

Salida esperada:

Ingrese el rol (admin, instructor, aprendiz): admin
Ingrese la hora de llegada (0-23): 2
Acceso permitido

Prueba 2: Aprendiz a las 19

Entrada: rol aprendiz, hora 19.

Salida esperada:

Ingrese el rol (admin, instructor, aprendiz): aprendiz
Ingrese la hora de llegada (0-23): 19
Acceso denegado

Evidencia

Guardar las capturas reales en evidencias
