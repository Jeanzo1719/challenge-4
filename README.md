# 🎮 Taller Unity – Juego de “Football”

---

## 📌 Descripción

El objetivo del juego es **lanzar perros** para destruir **bolas que caen desde la parte superior de la pantalla**.

El proyecto demuestra el uso de:

* Arrays de prefabs
* Generación aleatoria
* Física básica (movimiento y colisiones)
* Lógica de juego en Unity

---

## 🧠 Mecánicas del juego

* Las **bolas enemigas** aparecen en la zona lejana y se dirigen hacia la portería del jugador.
* El jugador debe colisionar con ellas para **empujarlas hacia la portería enemiga** y eliminarlas.
* Cuando **todos los enemigos han sido eliminados**, aparece una **nueva oleada** (1 enemigo en la oleada 1, 2 en la 2, 3 en la 3, etc.).
* Al derrotar una oleada completa, también aparece un **power‑up** que aumenta la fuerza de empuje durante unos segundos.
* El **power‑up desaparece al cabo de un tiempo** si no se recoge.

---

## 🎮 Controles

| Acción                | Tecla / Eje       |
| --------------------- | ----------------- |
| Moverse (adelante/atrás) | Eje Vertical (W/S o ↑/↓) |
| Rotar cámara          | Eje Horizontal (A/D o ←/→) |

---

## ⚙️ Tecnologías utilizadas

* Unity (3D)
* C#
* Sistema de físicas de Unity (Rigidbody + Colliders)

---

## 🗂️ Estructura del proyecto (scripts principales)

* `SpawnManagerX` → Controla la generación de oleadas, enemigos y power‑ups. Lleva la cuenta de enemigos restantes y el número de oleada.
* `PlayerControllerX` → Movimiento del jugador, recogida de power‑ups, activación del turbo y colisiones con enemigos.
* `EnemyX` → Movimiento automático de las bolas enemigas hacia la portería del jugador.
* `RotateCameraX` → Permite rotar la cámara alrededor del jugador usando el eje horizontal.

---

## ⚠️ Notas importantes

* Es necesario que los objetos de la escena tengan correctamente asignados:
  * **Tags** 
  * **Componentes**
  * **Referencias** → En el Inspector, arrastrar los prefabs y el objeto del jugador a los campos públicos de `SpawnManagerX` y `PlayerControllerX`

---

## 🚀 Cómo ejecutar

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/Jeanzo1719/videojuego-taller1.git
   ```

2. Abrir el proyecto en Unity Hub

3. Ejecutar la escena principal

---

## 📹 Demo

[Ver video](./demo.mp4)
