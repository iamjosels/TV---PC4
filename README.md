# Unity 2D Game for UPC

> Proyecto realizado por **José Giovanni Laura Silvera (Código: 202112986)**  
> Versión de Unity: `6000.0.45f1`

---

## 📌 Descripción

Es un juego 2D desarrollado en Unity en el que controlas a un personaje con la habilidad de cambiar su color para sobrevivir a la caída de enemigos de colores. Si coincides con el color del enemigo, ganas puntos. Si no, los pierdes. ¡Evita caer a puntuación negativa!

---

## 🕹️ Mecánicas del Juego

- Movimiento del personaje:
  - Con teclado: flechas izquierda y derecha (`← →`)
  - Con el mouse: sigue el puntero (modo estilo Hungry Hero)
- Cambio de color del jugador:
  - `X` → Beige
  - `C` → Green
  - `V` → Yellow (color inicial por defecto)
  - `B` → Purple
- Enemigos:
  - Caen cada 10 segundos desde la parte superior.
  - Tipos de enemigos:
    - `Barnacle` → Purple
    - `Bee` → Yellow
    - `Block` → Green
    - `Worn` → Beige
- Colisiones:
  - Coincide el color → +10 puntos
  - Color diferente → -20 puntos
  - Si el puntaje es negativo → pantalla Game Over
- Puntaje visible en pantalla durante el juego.
- Navegación entre escenas:
  - `Loading` → Espera 5 segundos → `Menu`
  - `Menu` → Botón para iniciar juego
  - `Game` → Escena principal
  - `Game Over` → Nombre + botón para volver a menú

---

## 🧩 Escenas

- `Loading.unity`
- `Menu.unity`
- `Game.unity`
- `GameOver.unity`

---

## 📁 Estructura del proyecto

```plaintext
Assets/
├── Art/                    # Fondos y sprites
├── Prefabs/Enemies/       # Prefabs de los 4 enemigos
├── Scenes/                # Todas las escenas del juego
├── Scripts/
│   ├── Gameplay/          # Movimiento, enemigos, jugador
│   ├── Managers/          # GameManager
│   └── UI/                # Controladores de menú y UI
```
---
---

## ▶️ Cómo ejecutar

1. Clona el repositorio o descarga el proyecto.
2. Abre el proyecto con Unity `6000.0.45f1`.
3. Abre la escena `Loading.unity`.
4. Ejecuta (`Play`) desde el editor de Unity.

---

## 📦 Requisitos

- Unity Editor `6000.0.45f1`
- TextMeshPro (importado desde `Window > TextMeshPro > Import Essentials`)

---

## 🧪 Créditos

- Programación y diseño: **José Giovanni Laura Silvera**
- Sprites base: OpenGameArt / Itch.io / propios (según origen)

---
