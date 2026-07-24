# Fundamentos de Programación (IAD-2413)
## Instituto Tecnológico de Durango — Ingeniería en Inteligencia Artificial

# Unidad 2: Análisis y metodología de resolución de problemas
### Ejemplos trabajados en Python, C# y Java

---

## Índice

1. [Introducción a la unidad](#introducción-a-la-unidad)
2. [2.1 Descripción y análisis del problema](#21-descripción-y-análisis-del-problema)
3. [2.2 Definición de soluciones](#22-definición-de-soluciones)
4. [2.3 Diseño de algoritmos y soluciones](#23-diseño-de-algoritmos-y-soluciones)
5. [2.4 Implementación de soluciones en código](#24-implementación-de-soluciones-en-código)
6. [2.5 Depuración, pruebas y manejo de errores](#25-depuración-pruebas-y-manejo-de-errores)
7. [2.6 Documentación y buenas prácticas de programación](#26-documentación-y-buenas-prácticas-de-programación)
8. [2.7 Aplicación de la metodología en la resolución de problemas prácticos](#27-aplicación-de-la-metodología-en-la-resolución-de-problemas-prácticos)
9. [Conexión con la Práctica 2 del temario](#conexión-con-la-práctica-2-del-temario)
10. [Rúbrica sugerida de evaluación de la unidad](#rúbrica-sugerida-de-evaluación-de-la-unidad)

---

## Introducción a la unidad

La Unidad 1 dio a los estudiantes el "vocabulario" de la programación: variables, tipos de datos, operadores, estructuras de control y funciones, comparados en Python, C# y Java. La Unidad 2 da un paso más importante: **antes de escribir código hay que pensar**. Aquí se enseña una metodología repetible —análisis, diseño, implementación, depuración y documentación— que el estudiante aplicará durante el resto de la carrera, no solo en esta materia.

**Competencia específica de la unidad:** los estudiantes aprenden a resolver problemas y comunicarse en programación mediante la metodología de resolución de problemas, donde se desglosan problemas, definen soluciones, diseñan algoritmos, implementan código, depuran, prueban, documentan y aplican estas habilidades en situaciones prácticas.

**Subtemas (temario oficial):**

| No. | Subtema |
|---|---|
| 2.1 | Descripción y análisis del problema |
| 2.2 | Definición de soluciones |
| 2.3 | Diseño de algoritmos y soluciones |
| 2.4 | Implementación de soluciones en código |
| 2.5 | Depuración, pruebas y manejo de errores |
| 2.6 | Documentación y buenas prácticas de programación |
| 2.7 | Aplicación de la metodología en la resolución de problemas prácticos |

A lo largo de la unidad usaremos un **problema guía** que coincide con la Práctica 2 del temario: *leer una lista de números y clasificarlos en positivos, negativos y ceros*. Cada subtema avanza este mismo problema un paso más, para que al llegar a 2.7 el estudiante tenga la solución completa, documentada y probada en los tres lenguajes del curso.

---

## 2.1 Descripción y análisis del problema

### Idea clave
No se puede resolver bien un problema que no se entiende. La causa más común de errores en principiantes no es la sintaxis: es programar sin haber analizado qué se pide.

### Las 5 preguntas del análisis
Antes de escribir una sola línea de código, todo problema debe pasar por estas preguntas:

1. **¿Qué entra?** (datos de entrada, su tipo y su origen)
2. **¿Qué debe salir?** (resultado esperado, formato de salida)
3. **¿Qué restricciones o reglas existen?** (rango de valores, cantidad de datos, tipo de dato válido)
4. **¿Qué casos especiales o extremos hay?** (listas vacías, ceros, valores repetidos, datos inválidos)
5. **¿Cómo sé que el resultado es correcto?** (criterio de verificación)

### Aplicación al problema guía

**Enunciado:** Desarrollar un programa que lea una lista de números y los clasifique en positivos, negativos y ceros.

| Pregunta | Respuesta para este problema |
|---|---|
| ¿Qué entra? | Una lista de números (enteros o decimales), de tamaño no definido de antemano |
| ¿Qué debe salir? | Tres conteos (o tres listas): cuántos positivos, cuántos negativos, cuántos ceros |
| ¿Restricciones? | El usuario decide cuántos números captura; deben aceptarse números negativos y decimales |
| ¿Casos especiales? | Lista vacía (0 números), todos los números iguales, entrada no numérica |
| ¿Cómo verifico? | Sumar los tres conteos debe dar el total de números capturados |

### Técnica de descomposición
Un problema grande se analiza dividiéndolo en subproblemas más simples (descomposición funcional). Para el problema guía:

```
Problema: Clasificar números
 ├── Subproblema 1: Capturar N números
 ├── Subproblema 2: Determinar si un número es positivo, negativo o cero
 ├── Subproblema 3: Acumular los conteos
 └── Subproblema 4: Mostrar el resumen final
```

Esta descomposición es la que después se convierte directamente en **funciones** (subtema 2.3–2.4): un síntoma de buen análisis es que cada subproblema termina siendo una función con un solo propósito.

---

## 2.2 Definición de soluciones

### Idea clave
Antes de comprometerse con una sola forma de resolver el problema, un buen programador **compara alternativas**. No siempre la primera idea es la más simple, la más eficiente ni la más clara.

### Criterios para comparar enfoques

| Criterio | Pregunta que responde |
|---|---|
| Correctitud | ¿Produce el resultado correcto en todos los casos, incluyendo los extremos? |
| Simplicidad | ¿Qué tan fácil es de leer y explicar a otra persona? |
| Eficiencia | ¿Cuántas operaciones/recorridos hace sobre los datos? |
| Escalabilidad | ¿Sigue funcionando bien si la cantidad de datos crece mucho? |
| Mantenibilidad | ¿Qué tan fácil sería modificarlo si cambian los requisitos? |

### Aplicación al problema guía: dos enfoques posibles

**Enfoque A — Conteo directo (un solo recorrido, una sola función):**
Se lee cada número y, en el mismo paso, se decide su categoría y se incrementa un contador. Simple, rápido de escribir, pero mezcla "captura" con "clasificación" en un solo bloque.

**Enfoque B — Separación de responsabilidades (varias funciones pequeñas):**
Una función captura los números y los guarda en una lista; otra función recorre la lista y clasifica; una tercera función imprime el resumen. Es un poco más de código, pero cada función se puede probar y reutilizar por separado.

**Decisión para este curso:** se adopta el **Enfoque B**, porque introduce el hábito de modularizar (ya visto en 1.5 con funciones) y facilita la depuración y las pruebas unitarias (subtema 2.5), que son parte de la competencia de la unidad.

> **Nota didáctica:** en clase conviene pedir a los estudiantes que propongan ellos mismos un tercer enfoque (por ejemplo, usando una estructura de datos por categoría en vez de solo contadores) y que argumenten cuál prefieren y por qué. Esto entrena la competencia genérica de pensamiento crítico señalada en el temario.

---

## 2.3 Diseño de algoritmos y soluciones

### Idea clave
El diseño traduce la solución elegida (2.2) en una secuencia de pasos precisa, **independiente del lenguaje de programación**. Las dos herramientas estándar son el **pseudocódigo** y el **diagrama de flujo**.

### Pseudocódigo del problema guía

```
INICIO
  positivos ← 0
  negativos ← 0
  ceros ← 0
  PEDIR cuántos números se van a capturar (n)

  MIENTRAS se hayan capturado menos de n números:
      LEER número
      SI número > 0 ENTONCES
          positivos ← positivos + 1
      SINO SI número < 0 ENTONCES
          negativos ← negativos + 1
      SINO
          ceros ← ceros + 1
      FIN SI

  MOSTRAR "Positivos: " positivos
  MOSTRAR "Negativos: " negativos
  MOSTRAR "Ceros: " ceros
FIN
```

### Diagrama de flujo (descripción de bloques)

```
      ┌────────────┐
      │   INICIO    │
      └─────┬──────┘
            ▼
   ┌────────────────────┐
   │ positivos,negativos,│
   │   ceros ← 0          │
   └─────┬──────────────┘
         ▼
   ┌───────────────┐
   │ Pedir N        │
   └─────┬─────────┘
         ▼
   ┌────────────────────┐      NO
   │ ¿Quedan números    │────────────┐
   │ por leer?           │            │
   └─────┬──────────────┘            │
      SÍ │                            ▼
         ▼                    ┌───────────────┐
   ┌──────────────┐            │ Mostrar        │
   │ Leer número    │            │ resumen final  │
   └─────┬─────────┘            └───────┬───────┘
         ▼                              ▼
   ┌───────────────┐              ┌───────────┐
   │ ¿número > 0?   │──SÍ──►      │   FIN      │
   └─────┬─────────┘  positivos++ └───────────┘
      NO │
         ▼
   ┌───────────────┐
   │ ¿número < 0?   │──SÍ──► negativos++
   └─────┬─────────┘
      NO │
         ▼
      ceros++
         │
         └──► regresa a "¿Quedan números por leer?"
```

**Elementos estándar del diagrama de flujo** (para reforzar en clase):

| Símbolo | Significado |
|---|---|
| Óvalo | Inicio / Fin |
| Rectángulo | Proceso o asignación |
| Rombo | Decisión (condición) |
| Paralelogramo | Entrada / Salida |
| Flecha | Flujo de control |

### Del diseño al código: mapeo de responsabilidades

Retomando la descomposición del subtema 2.1, el diseño formal por función queda así:

| Función | Entrada | Salida | Responsabilidad |
|---|---|---|---|
| `capturarNumeros(n)` | cantidad n | lista de n números | Leer n números del usuario |
| `clasificar(lista)` | lista de números | tres conteos | Recorrer la lista y contar por categoría |
| `mostrarResumen(pos, neg, cer)` | tres conteos | — (imprime) | Presentar el resultado final |

Este mapeo es exactamente lo que se implementa en el subtema 2.4, en los tres lenguajes.

---

## 2.4 Implementación de soluciones en código

### Idea clave
Implementar es traducir el diseño (2.3) a la sintaxis de un lenguaje concreto **sin cambiar la lógica**. Si el algoritmo ya está bien diseñado, la implementación debería ser casi mecánica.

### Python

```python
def capturar_numeros(n):
    numeros = []
    for i in range(n):
        valor = float(input(f"Número {i + 1}: "))
        numeros.append(valor)
    return numeros


def clasificar(numeros):
    positivos = negativos = ceros = 0
    for numero in numeros:
        if numero > 0:
            positivos += 1
        elif numero < 0:
            negativos += 1
        else:
            ceros += 1
    return positivos, negativos, ceros


def mostrar_resumen(positivos, negativos, ceros):
    print("Positivos:", positivos)
    print("Negativos:", negativos)
    print("Ceros:", ceros)


def main():
    n = int(input("¿Cuántos números vas a capturar? "))
    numeros = capturar_numeros(n)
    positivos, negativos, ceros = clasificar(numeros)
    mostrar_resumen(positivos, negativos, ceros)


if __name__ == "__main__":
    main()
```

### C#

```csharp
using System;
using System.Collections.Generic;

class ClasificadorNumeros
{
    static List<double> CapturarNumeros(int n)
    {
        List<double> numeros = new List<double>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            double valor = double.Parse(Console.ReadLine());
            numeros.Add(valor);
        }
        return numeros;
    }

    static (int positivos, int negativos, int ceros) Clasificar(List<double> numeros)
    {
        int positivos = 0, negativos = 0, ceros = 0;
        foreach (double numero in numeros)
        {
            if (numero > 0) positivos++;
            else if (numero < 0) negativos++;
            else ceros++;
        }
        return (positivos, negativos, ceros);
    }

    static void MostrarResumen(int positivos, int negativos, int ceros)
    {
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);
    }

    static void Main()
    {
        Console.Write("¿Cuántos números vas a capturar? ");
        int n = int.Parse(Console.ReadLine());

        List<double> numeros = CapturarNumeros(n);
        var (positivos, negativos, ceros) = Clasificar(numeros);
        MostrarResumen(positivos, negativos, ceros);
    }
}
```

### Java

```java
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ClasificadorNumeros {

    static List<Double> capturarNumeros(int n, Scanner sc) {
        List<Double> numeros = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            System.out.print("Número " + (i + 1) + ": ");
            double valor = Double.parseDouble(sc.nextLine());
            numeros.add(valor);
        }
        return numeros;
    }

    static int[] clasificar(List<Double> numeros) {
        int positivos = 0, negativos = 0, ceros = 0;
        for (double numero : numeros) {
            if (numero > 0) positivos++;
            else if (numero < 0) negativos++;
            else ceros++;
        }
        return new int[] { positivos, negativos, ceros };
    }

    static void mostrarResumen(int positivos, int negativos, int ceros) {
        System.out.println("Positivos: " + positivos);
        System.out.println("Negativos: " + negativos);
        System.out.println("Ceros: " + ceros);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("¿Cuántos números vas a capturar? ");
        int n = Integer.parseInt(sc.nextLine());

        List<Double> numeros = capturarNumeros(n, sc);
        int[] resultado = clasificar(numeros);
        mostrarResumen(resultado[0], resultado[1], resultado[2]);
    }
}
```

### Comparación de la implementación

| Aspecto | Python | C# | Java |
|---|---|---|---|
| Estructura de datos usada | `list` | `List<double>` | `List<Double>` (ArrayList) |
| Retorno de varios valores | tupla `(a, b, c)` | tupla nombrada `(int, int, int)` | arreglo `int[]` (Java no tiene tuplas nativas) |
| Conversión de texto a número | `float(input(...))` | `double.Parse(...)` | `Double.parseDouble(...)` |
| Punto de entrada | `if __name__ == "__main__":` | `static void Main()` | `public static void main(String[] args)` |

**Idea para reforzar en clase:** las tres versiones implementan **exactamente el mismo diseño** de la sección 2.3. Es una buena pregunta de examen pedir al estudiante que señale, en un código dado, cuál bloque corresponde a `capturarNumeros`, cuál a `clasificar` y cuál a `mostrarResumen`.

---

## 2.5 Depuración, pruebas y manejo de errores

### Idea clave
Escribir código es solo la mitad del trabajo; la otra mitad es verificar que funciona **en todos los casos**, no solo en el caso feliz que el programador tenía en mente.

### Tipos de errores

| Tipo de error | Descripción | Ejemplo en este problema |
|---|---|---|
| **Error de sintaxis** | El código no cumple las reglas del lenguaje; no compila/ejecuta | Olvidar un `:` en Python o un `;` en C#/Java |
| **Error de ejecución (runtime)** | El código es válido pero falla al ejecutarse con ciertos datos | El usuario escribe "abc" donde se espera un número → excepción de conversión |
| **Error lógico** | El programa corre sin fallar, pero el resultado es incorrecto | Usar `>=` en vez de `>` y contar el cero como positivo |

### Manejo de errores por lenguaje

**Python — `try/except`:**
```python
try:
    valor = float(input(f"Número {i + 1}: "))
except ValueError:
    print("Entrada inválida, se ignorará este valor.")
```

**C# — `try/catch`:**
```csharp
try
{
    double valor = double.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida, se ignorará este valor.");
}
```

**Java — `try/catch`:**
```java
try {
    double valor = Double.parseDouble(sc.nextLine());
} catch (NumberFormatException e) {
    System.out.println("Entrada inválida, se ignorará este valor.");
}
```

### Diseño de casos de prueba

Un buen conjunto de pruebas no solo confirma que el programa funciona: busca **romperlo** a propósito. Para el problema guía:

| # | Caso de prueba | Entrada | Resultado esperado | Tipo de caso |
|---|---|---|---|---|
| 1 | Caso típico | `5, -3, 0, 10, -1` | 2 positivos, 2 negativos, 1 cero | Caso normal |
| 2 | Todos positivos | `1, 2, 3` | 3 positivos, 0 negativos, 0 ceros | Caso normal |
| 3 | Todos ceros | `0, 0, 0` | 0 positivos, 0 negativos, 3 ceros | Caso límite |
| 4 | Un solo número | `-7` | 0 positivos, 1 negativo, 0 ceros | Caso límite (n = 1) |
| 5 | Cero elementos | `n = 0` | 0, 0, 0 sin pedir números | Caso extremo |
| 6 | Número decimal negativo | `-0.5` | 0 positivos, 1 negativo, 0 ceros | Caso de tipo de dato |
| 7 | Entrada no numérica | `"abc"` | Mensaje de error, no se rompe el programa | Caso de manejo de errores |

### Técnicas de depuración

- **Depuración con puntos de interrupción (breakpoints):** ejecutar el programa paso a paso desde el IDE (VS Code, PyCharm, Eclipse) y observar el valor de las variables en cada iteración.
- **Depuración por impresión (print debugging):** insertar temporalmente `print()` / `Console.WriteLine()` / `System.out.println()` para ver el estado de las variables en puntos clave. Útil cuando no se tiene un depurador a la mano, pero debe retirarse antes de entregar el código final.
- **Verificación por casos límite primero:** antes de dar por bueno un algoritmo, probarlo con los casos extremos de la tabla anterior (lista vacía, un solo elemento, todos iguales) suele revelar más errores que probar solo con datos "normales".

---

## 2.6 Documentación y buenas prácticas de programación

### Idea clave
El código se escribe una vez, pero se lee muchas veces —por el propio autor semanas después, por compañeros de equipo, por el docente al evaluar. Documentar y seguir convenciones de estilo no es "adorno": es parte de la calidad del software.

### Buenas prácticas transversales

- **Nombres descriptivos:** `positivos`, `capturarNumeros` en vez de `p`, `f1`.
- **Una función, una responsabilidad:** cada función del diseño (2.3) hace una sola cosa.
- **Comentarios que expliquen el *por qué*, no el *qué*:** el código ya dice qué hace; el comentario debe aportar el motivo o la regla de negocio.
- **Consistencia:** un mismo estilo de nombres y sangría a lo largo de todo el archivo.
- **Documentación de funciones:** describir brevemente qué recibe y qué devuelve cada función.

### Convención de nombres por lenguaje

| Lenguaje | Convención dominante | Ejemplo |
|---|---|---|
| Python (PEP 8) | `snake_case` para variables y funciones | `capturar_numeros`, `numero_actual` |
| C# | `PascalCase` para métodos y clases, `camelCase` para variables locales | `CapturarNumeros`, `valorLeido` |
| Java | `camelCase` para métodos y variables, `PascalCase` para clases | `capturarNumeros`, `ClasificadorNumeros` |

### Ejemplo de documentación de función

**Python (docstring):**
```python
def clasificar(numeros):
    """
    Clasifica una lista de números en positivos, negativos y ceros.

    Parámetros:
        numeros (list[float]): lista de números a clasificar.

    Retorna:
        tuple: (positivos, negativos, ceros) con los conteos de cada categoría.
    """
    ...
```

**C# / Java (comentario de documentación):**
```csharp
/// <summary>
/// Clasifica una lista de números en positivos, negativos y ceros.
/// </summary>
/// <param name="numeros">Lista de números a clasificar.</param>
/// <returns>Tupla con los conteos (positivos, negativos, ceros).</returns>
```

### Checklist de buenas prácticas antes de entregar código

1. ¿Los nombres de variables y funciones explican su propósito sin necesidad de leer el cuerpo?
2. ¿Cada función hace una sola cosa y tiene un comentario o docstring que la describe?
3. ¿Se eliminaron los `print`/`Console.WriteLine` usados solo para depurar?
4. ¿El código maneja al menos los errores de entrada más obvios (dato no numérico)?
5. ¿El estilo de nombres es consistente con la convención del lenguaje usado?

---

## 2.7 Aplicación de la metodología en la resolución de problemas prácticos

### Idea clave
Esta sección cierra el ciclo: se recorre la metodología completa —análisis, definición de solución, diseño, implementación, depuración/pruebas y documentación— sobre un problema nuevo, para confirmar que el estudiante puede aplicarla de forma autónoma y no solo repetir el ejemplo guía.

### Problema propuesto para practicar la metodología completa en clase

**Enunciado:** *Un profesor quiere calcular el promedio de calificaciones de un grupo y saber cuántos alumnos aprobaron (calificación ≥ 6) y cuántos reprobaron.*

Se sugiere que, en equipos, los estudiantes recorran los mismos pasos ya vistos:

| Paso | Lo que deben entregar |
|---|---|
| 2.1 Análisis | Responder las 5 preguntas del análisis para este problema |
| 2.2 Definición de solución | Proponer al menos dos enfoques y justificar cuál eligen |
| 2.3 Diseño | Pseudocódigo y diagrama de flujo del enfoque elegido |
| 2.4 Implementación | Código en Python, C# o Java (el equipo elige uno para esta práctica) |
| 2.5 Pruebas | Tabla de al menos 5 casos de prueba, incluyendo casos límite |
| 2.6 Documentación | Comentarios/docstrings y nombres siguiendo la convención del lenguaje elegido |

### Ejemplo resuelto (guía para el docente)

**Pseudocódigo:**
```
INICIO
  suma ← 0
  aprobados ← 0
  reprobados ← 0
  PEDIR cantidad de alumnos (n)

  MIENTRAS se hayan leído menos de n calificaciones:
      LEER calificación
      suma ← suma + calificación
      SI calificación >= 6 ENTONCES
          aprobados ← aprobados + 1
      SINO
          reprobados ← reprobados + 1
      FIN SI

  promedio ← suma / n
  MOSTRAR "Promedio: " promedio
  MOSTRAR "Aprobados: " aprobados
  MOSTRAR "Reprobados: " reprobados
FIN
```

**Nota de diseño:** obsérvese que este pseudocódigo reutiliza la misma estructura (acumular mientras se lee, clasificar con una condición, mostrar un resumen) que el problema guía de la unidad. Esa es precisamente la meta de enseñar una metodología: una vez interiorizada, el estudiante reconoce el mismo patrón en problemas distintos en lugar de partir de cero cada vez.

---

## Conexión con la Práctica 2 del temario

Con el contenido de esta unidad, el equipo está listo para desarrollar la **Práctica 2: Resolución de problemas de clasificación de números**, siguiendo exactamente los siete pasos marcados en el temario oficial:

1. Descripción y análisis del problema → subtema 2.1
2. Definición de soluciones → subtema 2.2
3. Diseño de algoritmos → subtema 2.3
4. Implementación en código (Python, y opcionalmente C# y Java para comparar) → subtema 2.4
5. Depuración y pruebas → subtema 2.5
6. Documentación → subtema 2.6
7. Aplicación práctica a un conjunto de datos real o simulado → subtema 2.7

**Entregables de la práctica (según temario):**
- Código fuente del programa.
- Documentación del análisis, diseño, implementación y pruebas.
- Ejemplos de datos utilizados y resultados obtenidos.

¿Quieres que te prepare el **informe de práctica ya redactado** (documento de análisis + diseño + pruebas, listo para que el estudiante solo lo complete), o que lo convierta en una **presentación .pptx** con el mismo diseño visual de la Unidad 1 para impartir la clase?

---

## Rúbrica sugerida de evaluación de la unidad

| Criterio | Excelente | Suficiente | Insuficiente |
|---|---|---|---|
| Análisis del problema | Identifica entradas, salidas, restricciones y casos especiales con claridad | Identifica la mayoría de los elementos, con algunas omisiones | No distingue entradas/salidas o ignora casos especiales |
| Diseño del algoritmo | Pseudocódigo y/o diagrama de flujo correctos, claros y completos | Diseño funcional pero con imprecisiones menores | Diseño ausente o incoherente con la solución final |
| Implementación | Código correcto, modular y que coincide con el diseño propuesto | Código funcional pero con lógica mezclada o poco modular | Código no ejecuta o no resuelve el problema planteado |
| Pruebas y depuración | Casos de prueba que cubren casos normales, límite y de error | Solo prueba casos normales | No presenta evidencia de pruebas |
| Documentación | Nombres claros, comentarios útiles, sigue la convención del lenguaje | Documentación parcial o inconsistente | Código sin comentarios ni convención de nombres |
