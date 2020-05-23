# Command Pattern

Este patrón encapsula una petición como un objeto, por lo tanto permite parametrizar clientes con diferentes peticiones e implementar operaciones que se pueden deshacer (undo).

###### Receiver
En nuestro ejercicio de domótica tendremos dispositivos concretos:
 - Enciende la luz.
 - Enciende netflix.
Cada uno de estas operaciones tiene sus operaciones particulares en sus clases concretas (por ejemplo netflix tiene encender la tv, inciar la aplicación, seleccionar contenido,...).

###### Command
Se tendrá una interfaz ICommand que define las operaciones comunes, por ejemplo activar, desactivar (ExecuteOn en nuestro ejemplo).

###### ConcreteCommand
Cada dispositivo concreto (luz y netflix) tendrá una clase envoltura que tiene un atributo del tipo concreto y además implementa la interfaz anterior. En las operaciones comunes (ExecuteOn) cada clase concreta llama al conjunto de operaciones que pone en marcha el aparato.

###### Invoker
Por último hay una clase que gestiona los comandos (AutoHomeInvoker) que tiene una lista de comandos y llama a la activación de los dispositivos.

![DecoratorUML](commandPattern.gif)
