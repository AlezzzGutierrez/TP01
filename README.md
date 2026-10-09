<h1> Trabajo Practico 01 / Programación de Videojuegos I </h1>


##  Descripción

Este proyecto corresponde al **Trabajo Práctico N.º 01 de Programación de Videojuegos I**.

El objetivo del ejercicio fue desarrollar un **prototipo de videojuego 3D de obstáculos utilizando Unity**, aplicando diferentes conceptos de programación y desarrollo de videojuegos.

El jugador debe recorrer un circuito de plataformas, superar obstáculos, utilizar plataformas móviles y recoger una moneda para transportarla hasta una zona de entrega.

Durante el recorrido también puede encontrar un **Power-Up temporal de velocidad**, que aumenta la velocidad del jugador durante un período determinado.

El proyecto permite poner en práctica conceptos como **movimiento, físicas, colisiones, prefabs, corrutinas, temporizadores, generación de objetos y manipulación de la jerarquía de objetos**.

 ![Captura del escenario](Assets/Images/08.png)
---

##  Versión de Unity

**Unity 6.5 (6000.5.8f1)**

---

##  Controles

| Tecla          | Acción            |
| -------------- | ----------------- |
| WASD / Flechas | Movimiento        |
| Espacio        | Saltar            |
| E              | Recoger la moneda |
| R              | Soltar la moneda  |

---

##  Mecánicas implementadas

* Cámara con Cinemachine: seguimiento del jugador durante el recorrido del circuito.
* Movimiento y salto del jugador.
  ![Captura del escenario](Assets/Images/01.png)
* Plataformas móviles entre dos posiciones.
![Captura del escenario](Assets/Images/02.png)
  * Cambio de dirección temporizado mediante `Invoke()`.
* Generación periódica de obstáculos mediante `InvokeRepeating()`.
  ![Captura del escenario](Assets/Images/03.png)
  * Los obstáculos se desplazan hacia el jugador.
  * Los obstáculos pueden afectar físicamente al jugador.
* Recolección y transporte de una moneda mediante `SetParent()`.
  ![Captura del escenario](Assets/Images/04.png)
* Soltar la moneda y devolverla a su estado físico normal.
* Power-Up temporal de velocidad mediante una corrutina.
  ![Captura del escenario](Assets/Images/05.png)
* Zona de entrega para la moneda.
  ![Captura del escenario](Assets/Images/06.png)
* Detección del objeto correcto mediante Tags y Triggers.
* Evento de victoria al entregar la moneda.
* Mensaje de victoria y partículas.
  ![Captura del escenario](Assets/Images/07.png)
* Respawn del jugador al caer fuera del circuito.

---

##  Conceptos de programación utilizados

Durante el desarrollo del proyecto se utilizaron diferentes herramientas y conceptos de Unity:

* Variables y referencias mediante el Inspector.
* Métodos y estructuras de control.
* `Invoke()` para controlar acciones después de un determinado tiempo.
* `InvokeRepeating()` para generar obstáculos periódicamente.
* `Instantiate()` para crear objetos durante la ejecución.
* `Destroy()` para eliminar obstáculos después de un tiempo.
* Corrutinas para controlar efectos temporales.
* `SetParent()` para transportar la moneda junto al jugador.
* Triggers y colisiones para detectar interacciones.
* `Rigidbody` para trabajar con físicas.
* Prefabs para reutilizar elementos del escenario.

---

##  Objetivo del juego

El objetivo principal es **recorrer el circuito, superar los obstáculos, recoger la moneda y llevarla hasta la zona de entrega**.

Para completar el recorrido, el jugador deberá utilizar las plataformas disponibles, evitar los obstáculos generados y aprovechar el Power-Up de velocidad.

Al entregar correctamente la moneda en la zona correspondiente, se activa el **evento de victoria**, mostrando un mensaje y partículas como señal de que el objetivo fue completado.

> El objetivo no es solamente llegar al final, sino utilizar las diferentes mecánicas implementadas para completar el recorrido.

---

##  Tareas y mecánicas completadas

* [x] Movimiento del jugador.
* [x] Plataformas móviles.
* [x] Cambio de dirección mediante `Invoke()`.
* [x] Generación de obstáculos mediante `InvokeRepeating()`.
* [x] Destrucción automática de obstáculos.
* [x] Recolección de la moneda.
* [x] Transporte de la moneda mediante `SetParent()`.
* [x] Soltar la moneda.
* [x] Power-Up temporal de velocidad.
* [x] Zona de entrega.
* [x] Evento de victoria.
* [x] Mensaje de victoria.
* [x] Partículas de victoria.

---

##  Ejemplo de código

Una de las herramientas utilizadas en el proyecto fue `InvokeRepeating()`, utilizada para generar obstáculos de manera periódica.

```csharp
void Start()
{
    InvokeRepeating("CrearObstaculo", 2f, 3f);
}
```

En este caso, el primer obstáculo aparece después de **2 segundos** y los siguientes se generan cada **3 segundos**.

---

##  Cómo abrir y ejecutar el proyecto

1. Clonar o descargar este repositorio.
2. Abrir el proyecto utilizando **Unity 6.5 (6000.5.8f1)**.
3. Abrir la escena principal.
4. Presionar el botón **Play**.
5. Utilizar los controles indicados para recorrer el circuito.
6. Recoger la moneda y llevarla hasta la zona de entrega.

---

##  Autor

**Gutierrez Gianella Alexandra**
*DNI: 45253615*
