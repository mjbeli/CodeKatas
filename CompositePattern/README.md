# Composite Pattern

Este patrón nos permite construir estructuras de objetos en forma de árbol con una jerarquía de forma que podamos aplicar las mismas operaciones sobre objetos intermedios del árbol y sobre las hojas. 

El usuario o cliente del árbol puede tratar de forma uniforme todos los elementos que lo componen (ya sean elementos individuales o listas de elementos). Esto se ve en la siguiente imagen en que tanto los nodos como las hojas del árbol tienen la función ```Operation()```.
 
![DecoratorUML](composite.gif)
