# Guía de diseño visual — Presentaciones IAD-2413

> Pega este bloque completo al inicio de un chat nuevo (o dentro del mensaje donde pidas la presentación) para que las diapositivas mantengan el mismo diseño visual que las anteriores de este proyecto.

## Contexto del curso
Fundamentos de Programación (IAD-2413) · Ingeniería en Inteligencia Artificial · Instituto Tecnológico de Durango (TecNM). Las presentaciones comparan código en **Python, C# y Java**.

## Herramienta y formato
- Generar con `pptxgenjs`, layout `LAYOUT_WIDE` (13.3 × 7.5 in).
- Antes de generar, revisar `/mnt/skills/public/pptx/SKILL.md`.
- Validar con `validate.py` y revisar el texto extraído (`markitdown`) para confirmar que todo el código mostrado es sintácticamente correcto antes de entregar el archivo.

## Paleta de colores (hex)

| Uso | Nombre | Hex |
|---|---|---|
| Fondo oscuro (portada/cierre) | NAVY | `1E2761` |
| Círculos decorativos sobre navy | — | `273580` |
| Texto claro sobre navy | ICE | `CADCFC` |
| Blanco | WHITE | `FFFFFF` |
| Texto oscuro principal | CHARCOAL | `2B2B33` |
| Texto secundario/gris | GRAY_TEXT | `4A4A55` |
| Fondo de diapositivas de contenido | LIGHT_BG | `F4F6FB` |
| Fondo de tarjetas blancas | CARD_BG | `FFFFFF` |
| Fondo de bloques de código | CODE_BG | `1B1D2A` |
| Texto de código | CODE_TEXT | `E8E8F0` |
| Filas alternas en tablas | — | `EDF0FA` |
| Bordes de tabla | — | `DDE1EF` |
| Texto de pie de página | — | `9AA0B4` |

**Colores por lenguaje (usar siempre estos, son consistentes en todas las diapositivas):**

| Lenguaje | Hex | Referencia |
|---|---|---|
| Python | `3776AB` | azul oficial de Python |
| C# | `9B4F96` | púrpura |
| Java | `E76F00` | naranja oficial de Java |
| Acento de éxito/positivo (ej. "salida correcta") | `1F9D74` | verde |

## Tipografías

| Uso | Fuente |
|---|---|
| Títulos y encabezados | Cambria (bold) |
| Texto de cuerpo, subtítulos, tablas | Calibri |
| Código | Courier New |

## Estructura estándar de una presentación
1. **Portada** (fondo NAVY)
2. **Objetivo / contexto** (fondo LIGHT_BG)
3. Diapositivas de contenido (instrucciones, tablas, diagramas, código)
4. **Comparación / tabla resumen** cuando aplique
5. **Cierre** (fondo NAVY): entregables o idea clave + criterios de evaluación

## Componentes reutilizables

### 1. Diapositiva de portada (fondo NAVY)
- Dos elipses decorativas de color `273580`: una arriba a la derecha (parcialmente fuera del slide) y otra abajo a la izquierda.
- Texto "eyebrow": mayúsculas, bold, `charSpacing: 3`, color ICE, tamaño ~15pt.
- Título principal: Cambria bold, 38-46pt, color WHITE.
- Subtítulo: Calibri, 17-20pt, color ICE.
- Badges de lenguaje: rectángulos redondeados (`roundRect`, `rectRadius: 0.08`) de ~1.5×0.45in, rellenos con el color de cada lenguaje (PY/CS/JV), texto centrado bold blanco.
- Pie institucional abajo a la izquierda: "Instituto Tecnológico de Durango · TecNM" + carrera/materia, color `9AAAD8`, tamaño 12pt.

### 2. Barra de título (diapositivas de contenido)
- Título: Cambria bold, 28-30pt, color NAVY, posición `x:0.5, y:0.35`.
- Subtítulo opcional: Calibri italic, 14pt, color GRAY_TEXT, `y:0.98`.

### 3. Pie de página (todas las diapositivas de contenido)
- Texto izquierdo: "[Tema de la presentación] · IAD-2413 · ITD", Calibri 10pt, color `9AA0B4`, `y:7.15`.
- Número de página opcional a la derecha, mismo estilo.

### 4. Tarjeta de código (`codeCard`)
- Rectángulo redondeado fondo `CODE_BG`, `rectRadius: 0.06`, con sombra exterior suave (`shadow: outer, opacity 0.25, blur 6`).
- Círculo de color del lenguaje (~0.28in) + etiqueta del lenguaje en bold blanco junto a él.
- Código en Courier New 11pt, color `CODE_TEXT`, `lineSpacingMultiple: 1.12`, alineado arriba.
- Tres tarjetas lado a lado (Python / C# / Java) cuando se compara sintaxis: ancho ~3.9in cada una, separación 0.25in, para caber en el ancho de 13.3in.
- Cuando el código es más largo (una función completa), usar **una tarjeta ancha** (~7.3in) en vez de tres columnas, para no tener que truncar líneas.
- **Regla crítica:** cada línea del arreglo `lines` debe ser una línea de código completa y sintácticamente válida. Nunca partir una cadena de texto (string) entre dos elementos del arreglo — eso rompe la sintaxis visualmente aunque no afecte la renderización.

### 5. Panel de pasos numerados (`stepsPanel`)
- Se usa junto a una tarjeta de código para explicar su funcionamiento paso a paso.
- Cada paso es una tarjeta blanca redondeada con sombra suave, un círculo numerado del color de acento a la izquierda, título en Cambria bold navy y descripción en Calibri gris.

### 6. Tablas comparativas
- Encabezado: fondo NAVY (columna de "aspecto") + un color de lenguaje por columna cuando aplica, texto blanco bold.
- Filas alternas: blanco / `EDF0FA`.
- Bordes: `DDE1EF`, 1pt.
- Texto de datos en Calibri; usar Courier New solo si la celda contiene código/sintaxis (ej. `int`, `bool`).

### 7. Diagramas de flujo
- Cajas rectangulares redondeadas de colores distintos (uno por etapa), texto blanco bold centrado.
- Un rombo (`diamond`) para puntos de decisión.
- Flechas (`line` con `endArrowType: triangle`) conectando las cajas, color `9AA0B4`.
- Recuadro inferior tipo "callout" (fondo `EDF0FA`, texto NAVY italic) para explicar el bucle o la lógica repetitiva.

### 8. Diapositiva de cierre (fondo NAVY)
- Misma decoración de elipse que la portada (una sola, arriba a la izquierda).
- Título Cambria bold blanco.
- Lista numerada con círculos de color (ciclando entre PY/CS/JV/verde/ICE) + texto blanco o ICE.
- Puede dividirse en dos columnas (ej. "Entregables" | "Criterios de evaluación") separadas por una línea vertical `3D4A9E`.

## Reglas generales de espaciado
- Márgenes laterales estándar: `x: 0.6` a `0.7`.
- Separación entre tres tarjetas iguales: `0.25in`.
- Footer siempre en `y: 7.15`; dejar al menos ~0.3–0.6in de espacio entre el último elemento de contenido y el footer.
- Evitar que dos elementos con texto se solapen: calcular siempre `y + h` del elemento anterior antes de posicionar el siguiente.
- No temer al espacio en blanco: no es necesario llenar todo el slide.

## Checklist antes de entregar
1. `validate.py` → debe pasar todas las validaciones.
2. Extraer texto con `markitdown` y revisar que **todo el código en los `codeCard` sea sintácticamente correcto** (sin strings partidos entre líneas, sin llaves faltantes).
3. Copiar el `.pptx` final a `/mnt/user-data/outputs/` y compartir con `present_files`.
