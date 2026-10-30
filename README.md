# Castlevania

Juego de plataformas 2D desarrollado en **Unity 6** (6000.6.2f1), inspirado en la saga Castlevania. Proyecto de aprendizaje y práctica con Unity y C#.

## Características

- Movimiento horizontal del personaje (Belmont) con animaciones de reposo y de correr controladas por el Animator.
- El personaje se gira según la dirección en la que camina.
- Salto y doble salto, con detección de suelo.
- Recolección de frutas (manzanas, plátanos y cerezas) con contador en pantalla.
- Escenario con tilemap, plataformas y fondo con efecto de capas.

## Controles

| Acción | Tecla |
|--------|-------|
| Mover a la derecha | `D` o flecha derecha |
| Mover a la izquierda | `A` o flecha izquierda |
| Saltar / doble salto | `Espacio` |

## Cómo ejecutarlo

1. Instala [Unity Hub](https://unity.com/download) y la versión **Unity 6 (6000.6.2f1)**.
2. Clona el repositorio:
   ```bash
   git clone https://github.com/SebasImitolaFernandez/Castlevania.git
   ```
3. En Unity Hub pulsa **Add** y selecciona la carpeta del proyecto.
4. Abre la escena principal desde `Assets/Scenes` y pulsa **Play**.

La primera vez Unity tardará un poco, porque regenera la carpeta `Library`.

## Estructura del proyecto

```
Assets/
├── Animation/   Animator y clips del personaje
├── Scenes/      Escenas del juego
├── Scripts/     Código en C#
└── Sprites/     Gráficos del juego
```

### Scripts principales

- `PlayerMove.cs`: movimiento, giro, salto y doble salto del jugador.
- `CheckGround.cs`: detecta si el personaje está tocando el suelo.
- `FruitCollected.cs`: recoge las frutas y avisa al contador.
- `FruitCounter.cs`: muestra en pantalla cuántas frutas se han recogido.

## Créditos

Proyecto creado por **Sebastián Imitola Fernández**.

Los sprites y recursos gráficos pertenecen a sus respectivos autores. Este proyecto es solo educativo y no tiene fines comerciales. Castlevania es una marca de Konami.
