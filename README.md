# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Comandos utiles para interactuar con el bot:

- register : Para registrar un nuevo usuario en el bot.

- qualify : Para agregar una calificacion a otro usuario, luego de terminado un contrato.

- offers : Despliega una serie de opciones , para poder agregar una oferta o para filtrar las ya existentes.

- contract: Para contratar a otro usuario.

Los parametros anteriores son palabras claves que sirven para iniciar un dialogo con el bot, el cual luego va preguntando los datos a recaudar.

Para registrar un administrador se deben realizar los siguientes pasos: <br>
register -> Nombre y Apellido -> admin

Para comprobar la nueva historia de usuario pedida en la defensa se deben realizar los siguientes pasos: <br>
(Registrarse como administrador) -> qualify -> 2 -> {ID del empleado}

Se creó a modo de ejemplo un empleado (ID = '151515') en el "Program.cs" para simular la existencia de un empleado cualquiera.
A su vez, a este empleado se le simularon tres calificaciones, éstas siendo de valor 1, 3 y 5 respectivamente.

En teoría, al ejecutar esta historia de usuario, deberíamos obtener un resultado de "5", ya que ésta es la calificación de mayor valor.

En la realidad, habrán múltiples empleados ingresados en el sistema con sus respectivas calificaciones. Y nosotros, como administradores solo necesitaremos saber el 'ID' de la persona para obtener su mayor calificación.