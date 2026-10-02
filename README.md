# Práctica 1 - Introducción a Unity y C#
**Asignatura:** Interfaces Inteligentes  
**Alumno:** Diego García Hernández

## Descripción
Este repositorio contiene la primera práctica de la asignatura, donde se abordan conceptos básicos de Unity mediante 4 ejercicios prácticos: manipulación de componentes, uso de la clase Math, operaciones espaciales con vectores (Vector3) y búsqueda de GameObjects mediante etiquetas (Tags).

---

## Hitos de la Práctica

### Hito 1: Cambio de color aleatorio
Se ha creado un script `CambiadorDeColor` asignado a un cubo. El script genera un color aleatorio modificando un canal del vector RGB cada N frames (parametrizable desde el inspector usando variables públicas).
![Prueba Ejercicio 1](./Assets/Gifs/ejercicio1.gif.gif)

### Hito 2: Calculadora de Vectores (Vector3)
Script asociado a una esfera que toma dos variables `Vector3` públicas dadas desde el Inspector. Calcula y muestra por consola y en el propio inspector la magnitud de ambos, el ángulo que forman, la distancia entre ellos y cuál se encuentra a mayor altura (eje Y).
![Prueba Ejercicio 2](./Assets/Gifs/ejercicio2.gif.gif)

### Hito 3: Posición en el mundo
Se ha utilizado el atajo `transform.position` dentro de la esfera para leer las coordenadas exactas donde está situada en la escena y mostrarlas a través de la consola mediante `Debug.Log`.
![Prueba Ejercicio 3](./Assets/Gifs/ejercicio3.gif.gif)

### Hito 4: Búsqueda por Etiquetas (Tags) y distancias
En este ejercicio, el script de la esfera busca a otros dos objetos en la escena (un cubo y un cilindro) utilizando `GameObject.FindWithTag()`. Una vez localizados, accede a sus componentes Transform para calcular y mostrar por consola la distancia a la que se encuentran respecto a la esfera.
![Prueba Ejercicio 4](./Assets/Gifs/ejercicio4.gif.gif)
