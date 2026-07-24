# Fundamentos de Programación (IAD-2413)
## Instituto Tecnológico de Durango — Ingeniería en Inteligencia Artificial

# Unidad 2 — Ejercicios de práctica
### Aplica por tu cuenta la metodología completa: análisis, diseño, implementación, pruebas y documentación

---

## Instrucciones generales

Estos ejercicios **no están resueltos** a propósito: son para que apliques, sin ayuda, la misma metodología de 7 pasos que se trabajó en clase con el problema guía (clasificación de números) y con los tres ejemplos resueltos (contador de vocales, máxima/mínima temperatura, validador de contraseña).

Para **cada** ejercicio que elijas resolver, debes entregar:

1. **2.1 Análisis** — responde las 5 preguntas del análisis (usa la plantilla de abajo).
2. **2.2 Definición de soluciones** — propón al menos dos enfoques distintos y justifica cuál eliges y por qué.
3. **2.3 Diseño** — escribe el pseudocódigo de tu solución (puedes apoyarte también en un diagrama de flujo).
4. **2.4 Implementación** — codifica tu solución en **Python** (obligatorio) y, si quieres comparar sintaxis, también en C# o Java.
5. **2.5 Pruebas** — construye una tabla de al menos 5 casos de prueba, incluyendo casos normales, casos límite y al menos un caso de error.
6. **2.6 Documentación** — usa nombres descriptivos y agrega un docstring/comentario de documentación a cada función.
7. **2.7 Aplicación** — en una o dos frases, explica en qué otro problema real podrías reutilizar el mismo patrón de solución.

### Plantilla para el análisis (2.1)

| Pregunta | Tu respuesta |
|---|---|
| ¿Qué entra? | |
| ¿Qué debe salir? | |
| ¿Qué restricciones existen? | |
| ¿Qué casos especiales hay? | |
| ¿Cómo verifico que el resultado es correcto? | |

### Plantilla para la tabla de pruebas (2.5)

| # | Entrada | Resultado esperado | Tipo de caso |
|---|---|---|---|
| 1 | | | Normal |
| 2 | | | Normal |
| 3 | | | Límite |
| 4 | | | Extremo |
| 5 | | | Manejo de errores |

---

## Ejercicio 1 — Contador de consonantes en una frase

**Enunciado:** Desarrolla un programa que lea una frase y cuente cuántas consonantes contiene (cualquier letra que no sea vocal ni espacio ni signo de puntuación), sin importar mayúsculas o minúsculas.

**Pistas para tu análisis:**
- Piensa qué caracteres **no** deberías contar (espacios, comas, puntos, números).
- ¿Qué pasa si la frase viene vacía?
- ¿Cómo decides, en tu diseño, si un carácter es una letra o no?

---

## Ejercicio 2 — Verificar si un número es primo

**Enunciado:** Desarrolla un programa que lea un número entero positivo y determine si es primo (un número primo solo es divisible entre 1 y entre sí mismo).

**Pistas para tu análisis:**
- ¿Qué debe pasar con el 0, el 1 y los números negativos? Decide una regla clara y documéntala.
- Para verificar si es primo, ¿hasta qué número necesitas probar divisores? (no hace falta probar hasta el número completo)
- Piensa en un caso de prueba con un número primo grande y otro con un número claramente no primo.

---

## Ejercicio 3 — La palabra más larga de una lista

**Enunciado:** Desarrolla un programa que lea una lista de palabras (el usuario decide cuántas) y determine cuál es la palabra más larga. Si hay un empate, se debe mostrar la primera que haya aparecido.

**Pistas para tu análisis:**
- Este problema es un "primo" del ejemplo de máxima y mínima temperatura — ¿qué cambia y qué se mantiene igual del patrón que ya conoces?
- ¿Qué haces si la lista está vacía?
- ¿Cómo defines "más larga" cuando dos palabras tienen exactamente el mismo número de caracteres?

---

## Ejercicio 4 — Validador de correo electrónico simple

**Enunciado:** Desarrolla un programa que lea una cadena de texto y determine, con reglas simples, si *parece* un correo electrónico válido. Como mínimo, debe cumplir: contener exactamente un símbolo `@`, tener al menos un carácter antes del `@`, y tener al menos un punto (`.`) después del `@`.

**Pistas para tu análisis:**
- Este ejercicio es un "primo" del validador de contraseñas — considera usar el mismo enfoque de funciones booleanas pequeñas (`tieneArroba`, `tienePuntoDespuesDeArroba`, etc.).
- ¿Qué pasa si el `@` aparece más de una vez?
- No necesitas validar el formato completo de un correo real (eso requiere expresiones regulares, que se ven más adelante); basta con las reglas simples indicadas.

---

## Ejercicio 5 — Clasificador de temperatura corporal

**Enunciado:** Desarrolla un programa que lea la temperatura corporal de una persona (en grados Celsius) y la clasifique en una de las siguientes categorías:

| Rango (°C) | Categoría |
|---|---|
| Menor a 35.0 | Hipotermia |
| 35.0 a 37.5 | Normal |
| 37.6 a 39.0 | Fiebre |
| Mayor a 39.0 | Fiebre alta |

**Pistas para tu análisis:**
- Presta atención a los límites de cada rango: ¿un valor de exactamente 37.5 a qué categoría pertenece? Tu diseño debe ser explícito sobre esto.
- ¿Qué pasa si el usuario introduce una temperatura imposible (por ejemplo, negativa o mayor a 45°C)? Decide si tu programa debe rechazarla y cómo.
- Este ejercicio es un buen candidato para practicar `if / elif / else` (Python) o su equivalente encadenado en C#/Java.

---

## Reto opcional — Combina dos patrones

**Enunciado:** Elige dos de los ejercicios anteriores (por ejemplo, el Ejercicio 3 y el Ejercicio 5) y diseña un solo programa que resuelva ambos problemas sobre el mismo conjunto de datos de entrada. Por ejemplo: leer una lista de palabras **y** de temperaturas juntas, mostrando al final tanto la palabra más larga como la clasificación de temperatura.

Este reto no tiene pistas: el objetivo es que combines, sin ayuda, dos veces la metodología completa dentro de un solo programa bien organizado en funciones.

---

## Antes de entregar — checklist rápido

- [ ] Respondí las 5 preguntas del análisis (2.1) para el problema elegido.
- [ ] Propuse y comparé al menos dos enfoques (2.2), y justifiqué cuál elegí.
- [ ] Escribí el pseudocódigo de mi solución (2.3) antes de programar.
- [ ] Mi código en Python (y, si aplica, C#/Java) implementa exactamente el diseño anterior (2.4).
- [ ] Mi tabla de pruebas (2.5) incluye al menos un caso normal, uno límite y uno de error.
- [ ] Mis nombres de variables y funciones son descriptivos, y documenté cada función (2.6).
- [ ] Expliqué en una o dos frases dónde más se podría aplicar este mismo patrón (2.7).
