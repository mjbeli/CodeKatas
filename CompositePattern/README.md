# Composite Pattern

Este patrón nos permite construir estructuras de objetos en forma de árbol con una jerarquía de forma que podamos aplicar las mismas operaciones sobre objetos intermedios del árbol y sobre las hojas. 

El usuario o cliente del árbol puede tratar de forma uniforme todos los elementos que lo componen (ya sean elementos individuales o listas de elementos). Esto se ve en la siguiente imagen en que tanto los nodos como las hojas del árbol tienen la función ```Operation()```.
 
  - Component: abstracción que declara comportamiento común para todos los elementos del árbol, puede implementar un comportamiento por defecto.
  - Composite: nodo del árbol. Define comportamiento para los elementos que tienen hijos. Implementa operaciones relativas a la gestión de los hijos (como añadir o eliminar componente).
  - Leaf: elemento hoja, no puede tener hijos. Define comportamiento para los elementos individuales.
  - Client: usuario de la jerarquía.
 
![DecoratorUML](composite.gif)
