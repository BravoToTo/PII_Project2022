# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Comandos útiles para interactuar con el bot:

- register : Para registrar un nuevo usuario en el bot.

- qualify : Para agregar una calificación a otro usuario, luego de terminado un contrato.

- offers : Despliega una serie de opciones , para poder agregar una oferta o para filtrar las ya existentes.

- contract: Para contratar a otro usuario.

Los parámetros anteriores son palabras claves que sirven para iniciar un dialogo con el bot, el cual luego va preguntando los datos a recaudar.

Para registrar un administrador se deben realizar los siguientes pasos: <br>
register -> Nombre y Apellido -> admin

Para comprobar la nueva historia de usuario pedida en la defensa se deben realizar los siguientes pasos: <br>
(Registrarse como administrador) -> qualify -> 2 -> {ID del empleado}

Se creó a modo de ejemplo un empleado (ID = '151515') en el "Program.cs" para simular la existencia de un empleado cualquiera.
A su vez, a este empleado se le simularon tres calificaciones, éstas siendo de valor 1, 3 y 5 respectivamente.

En teoría, al ejecutar esta historia de usuario, deberíamos obtener un resultado de "5", ya que ésta es la calificación de mayor valor.

En la realidad, habrán múltiples empleados ingresados en el sistema con sus respectivas calificaciones. Y nosotros, como administradores solo necesitaremos saber el 'ID' de la persona para obtener su mayor calificación.

Al diagrama UML se le agregaría, en la parte de 'QualificationManager', el nuevo método 'getMaxQualification()'
A su vez, se modificó la parte de el manejo de administradores, incluyendo la manera de registrarlos, ya que aún no lo teníamos implementado y fue necesario para la implementación de esta nueva historia de usuario. Por lo que se tuvo que agregar un nuevo método en 'Admin' y una lista que contendrá las ID de cada administrador. El método lo único que hace es agregar una nueva ID en la lista. También se modificó el handler encargado del registro de usuarios, en donde ahora se tuvo en cuenta una manera de registrar a los administradores. <br>
La lógica se hizo dentro del handler de las calificaciones 'QualifyHandler.cs', se agregó una especie de menú en el que el usuario podrá elegir la opción que quiera, siendo una de estas, la nueva historia de usuario pedida. Allí dentro, lo único que se deberá proporcionar será la ID del empleado al que queremos averiguar su mayor calificación. 