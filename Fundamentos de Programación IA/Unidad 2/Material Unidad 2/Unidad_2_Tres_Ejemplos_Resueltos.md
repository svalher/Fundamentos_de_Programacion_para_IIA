# Fundamentos de Programación (IAD-2413)
## Instituto Tecnológico de Durango — Ingeniería en Inteligencia Artificial

# Unidad 2 — Tres ejemplos resueltos con la metodología completa
### Análisis → Definición de solución → Diseño → Implementación → Pruebas → Documentación → Aplicación

---

## Cómo usar este material

El documento de la Unidad 2 explicó los siete subtemas (2.1–2.7) usando **un solo** problema guía: clasificar números en positivos, negativos y ceros. Aquí se repite exactamente la misma metodología sobre **tres problemas distintos**, para que el estudiante vea el patrón repetirse en contextos diferentes (texto, listas numéricas, validación de reglas) y termine de interiorizarlo antes de enfrentar la Práctica 2 por su cuenta.

Cada ejemplo sigue la misma estructura de siete pasos y se resuelve en **Python, C# y Java**, tal como el resto del curso.

| Ejemplo | Tema que refuerza | Tipo de dato principal |
|---|---|---|
| 1. Contador de vocales | Recorrido de cadenas de texto, condicionales | `string` / `str` |
| 2. Máxima y mínima temperatura | Recorrido de listas, comparación y actualización de variables | listas de números |
| 3. Validador de contraseña segura | Funciones booleanas pequeñas combinadas con `Y` (`&&`) | `string` + lógica booleana |

---

# Ejemplo 1: Contador de vocales en una palabra

**Enunciado:** Desarrollar un programa que lea una palabra (o frase) y cuente cuántas vocales (a, e, i, o, u) contiene, sin importar si están escritas en mayúsculas o minúsculas.

## 2.1 Descripción y análisis del problema

| Pregunta | Respuesta |
|---|---|
| ¿Qué entra? | Una cadena de texto (palabra o frase) |
| ¿Qué debe salir? | El número total de vocales encontradas |
| ¿Restricciones? | Debe funcionar sin importar mayúsculas/minúsculas |
| ¿Casos especiales? | Cadena vacía, cadena sin vocales, letras acentuadas (á, é, í...) |
| ¿Cómo verifico? | Contar manualmente las vocales de una palabra de prueba y comparar contra el resultado del programa |

> **Nota para clase:** el caso de las letras acentuadas es intencional. La solución que se presenta abajo **no** las cuenta como vocales — es una limitación real y buen material para preguntar en clase: *"¿cómo la resolverían?"* (pista: agregar `á, é, í, ó, ú` al conjunto de vocales).

## 2.2 Definición de soluciones

- **Enfoque A (elegido):** recorrer la palabra letra por letra y comparar cada una contra un conjunto de vocales. Es explícito, fácil de seguir y refuerza el uso de bucles y condicionales, que es justamente lo que esta unidad busca practicar.
- **Enfoque B (alternativa):** usar una función nativa de conteo del lenguaje (por ejemplo, sumar cuántas veces aparece cada vocal con un método de la librería estándar). Es más corto, pero oculta la lógica que se quiere enseñar en este punto del curso.

## 2.3 Diseño de algoritmos y soluciones

```
INICIO
  PEDIR palabra
  convertir palabra a minúsculas
  contador ← 0
  PARA cada letra en palabra:
      SI letra está en {a, e, i, o, u} ENTONCES
          contador ← contador + 1
      FIN SI
  MOSTRAR contador
FIN
```

## 2.4 Implementación de soluciones en código

**Python:**
```python
def contar_vocales(palabra):
    vocales = "aeiou"
    contador = 0
    for letra in palabra.lower():
        if letra in vocales:
            contador += 1
    return contador


def main():
    palabra = input("Escribe una palabra: ")
    print("Vocales encontradas:", contar_vocales(palabra))


if __name__ == "__main__":
    main()
```

**C#:**
```csharp
using System;

class ContadorVocales
{
    static int ContarVocales(string palabra)
    {
        string vocales = "aeiou";
        int contador = 0;
        foreach (char letra in palabra.ToLower())
        {
            if (vocales.Contains(letra)) contador++;
        }
        return contador;
    }

    static void Main()
    {
        Console.Write("Escribe una palabra: ");
        string palabra = Console.ReadLine();
        Console.WriteLine("Vocales encontradas: " + ContarVocales(palabra));
    }
}
```

**Java:**
```java
import java.util.Scanner;

public class ContadorVocales {

    static int contarVocales(String palabra) {
        String vocales = "aeiou";
        int contador = 0;
        for (char letra : palabra.toLowerCase().toCharArray()) {
            if (vocales.indexOf(letra) >= 0) contador++;
        }
        return contador;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe una palabra: ");
        String palabra = sc.nextLine();
        System.out.println("Vocales encontradas: " + contarVocales(palabra));
    }
}
```

## 2.5 Depuración, pruebas y manejo de errores

| # | Entrada | Resultado esperado | Tipo de caso |
|---|---|---|---|
| 1 | `"Programación"` | 5 vocales (o, a, a, i, o) | Normal |
| 2 | `""` (cadena vacía) | 0 vocales | Extremo |
| 3 | `"xyz"` | 0 vocales | Sin vocales |
| 4 | `"AEIOU"` | 5 vocales (prueba de mayúsculas) | Normal |
| 5 | `"murciélago"` | 4 vocales — la "é" **no** se cuenta con esta solución | Límite / limitación conocida |

**Manejo de errores:** este problema, a diferencia del problema guía, no necesita `try/except` porque cualquier cadena de texto es una entrada válida (no hay conversión de tipo que pueda fallar). Es un buen ejemplo para explicar que **no todos los problemas requieren manejo de excepciones** — depende de si hay una conversión de datos que pueda fallar.

## 2.6 Documentación y buenas prácticas

- Nombres descriptivos: `contador`, `vocales`, `palabra` — no `c`, `v`, `p`.
- La función `contarVocales` / `contar_vocales` hace una sola cosa: contar. No imprime ni pide datos — eso lo hace `main`.
- Convención de nombres aplicada: `contar_vocales` (Python), `ContarVocales` (C#), `contarVocales` (Java).

## 2.7 Aplicación de la metodología

Este mismo patrón —recorrer un texto letra por letra y contar coincidencias contra un conjunto de referencia— es la base de problemas mucho más complejos que el estudiante verá más adelante: contar palabras, validar formatos (como un correo electrónico), o contar caracteres repetidos. Vale la pena que el estudiante reconozca que ya domina el patrón, solo cambia *qué* se está contando.

---

# Ejemplo 2: Temperatura máxima y mínima de la semana

**Enunciado:** Desarrollar un programa que lea las temperaturas registradas durante los 7 días de la semana y determine cuál fue la temperatura máxima y cuál la mínima.

## 2.1 Descripción y análisis del problema

| Pregunta | Respuesta |
|---|---|
| ¿Qué entra? | 7 números (uno por día), pueden ser decimales y negativos |
| ¿Qué debe salir? | El valor máximo y el valor mínimo de la semana |
| ¿Restricciones? | Se capturan exactamente 7 valores |
| ¿Casos especiales? | Todos los valores iguales, temperaturas bajo cero |
| ¿Cómo verifico? | El máximo debe ser mayor o igual a todos los valores capturados; el mínimo, menor o igual a todos |

## 2.2 Definición de soluciones

- **Enfoque A (elegido):** inicializar `máximo` y `mínimo` con el primer valor leído, y comparar cada valor siguiente contra ellos, actualizándolos cuando corresponda. Un solo recorrido de la lista.
- **Enfoque B (alternativa):** guardar todos los valores en una lista y ordenarla, tomando el primer y el último elemento como mínimo y máximo. Funciona, pero es menos eficiente: ordenar toma más pasos que un solo recorrido, y aquí no se necesita la lista ordenada para nada más.

## 2.3 Diseño de algoritmos y soluciones

```
INICIO
  LEER primera temperatura
  máximo ← primera temperatura
  mínimo ← primera temperatura

  PARA cada una de las 6 temperaturas restantes:
      LEER temperatura
      SI temperatura > máximo ENTONCES
          máximo ← temperatura
      FIN SI
      SI temperatura < mínimo ENTONCES
          mínimo ← temperatura
      FIN SI

  MOSTRAR "Máxima: " máximo
  MOSTRAR "Mínima: " mínimo
FIN
```

## 2.4 Implementación de soluciones en código

**Python:**
```python
def calcular_max_min(temperaturas):
    maximo = temperaturas[0]
    minimo = temperaturas[0]
    for t in temperaturas[1:]:
        if t > maximo:
            maximo = t
        if t < minimo:
            minimo = t
    return maximo, minimo


def main():
    temperaturas = []
    for i in range(7):
        t = float(input(f"Temperatura día {i + 1}: "))
        temperaturas.append(t)

    maximo, minimo = calcular_max_min(temperaturas)
    print("Máxima:", maximo)
    print("Mínima:", minimo)


if __name__ == "__main__":
    main()
```

**C#:**
```csharp
using System;
using System.Collections.Generic;

class TemperaturasSemana
{
    static (double max, double min) CalcularMaxMin(List<double> temperaturas)
    {
        double max = temperaturas[0];
        double min = temperaturas[0];
        for (int i = 1; i < temperaturas.Count; i++)
        {
            if (temperaturas[i] > max) max = temperaturas[i];
            if (temperaturas[i] < min) min = temperaturas[i];
        }
        return (max, min);
    }

    static void Main()
    {
        List<double> temperaturas = new List<double>();
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Temperatura día {i + 1}: ");
            temperaturas.Add(double.Parse(Console.ReadLine()));
        }

        var (max, min) = CalcularMaxMin(temperaturas);
        Console.WriteLine("Máxima: " + max);
        Console.WriteLine("Mínima: " + min);
    }
}
```

**Java:**
```java
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class TemperaturasSemana {

    static double[] calcularMaxMin(List<Double> temperaturas) {
        double max = temperaturas.get(0);
        double min = temperaturas.get(0);
        for (int i = 1; i < temperaturas.size(); i++) {
            double t = temperaturas.get(i);
            if (t > max) max = t;
            if (t < min) min = t;
        }
        return new double[] { max, min };
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Double> temperaturas = new ArrayList<>();
        for (int i = 0; i < 7; i++) {
            System.out.print("Temperatura día " + (i + 1) + ": ");
            temperaturas.add(Double.parseDouble(sc.nextLine()));
        }

        double[] resultado = calcularMaxMin(temperaturas);
        System.out.println("Máxima: " + resultado[0]);
        System.out.println("Mínima: " + resultado[1]);
    }
}
```

## 2.5 Depuración, pruebas y manejo de errores

| # | Entrada (7 valores) | Resultado esperado | Tipo de caso |
|---|---|---|---|
| 1 | `20, 22, 19, 25, 18, 21, 23` | Máxima: 25, Mínima: 18 | Normal |
| 2 | `20, 20, 20, 20, 20, 20, 20` | Máxima: 20, Mínima: 20 | Límite (todos iguales) |
| 3 | `-5, -2, 0, 3, -8, 1, 4` | Máxima: 4, Mínima: -8 | Temperaturas negativas |
| 4 | `15.5, 15.5, 15.4, 15.6, 15.5, 15.5, 15.5` | Máxima: 15.6, Mínima: 15.4 | Diferencias pequeñas (decimales) |

**Manejo de errores:** igual que en el problema guía de la unidad, aquí sí puede fallar la conversión de texto a número (`float`, `double.Parse`, `Double.parseDouble`) si el usuario escribe algo que no es un número. Se recomienda envolver la lectura en `try/except` (Python) o `try/catch` (C#, Java), tal como se explicó en el subtema 2.5.

## 2.6 Documentación y buenas prácticas

- `máximo` y `mínimo` son más claros que `a` y `b`, y evitan confundir cuál es cuál.
- La función `calcularMaxMin` no imprime nada — solo calcula y regresa. Mantener la lógica de cálculo separada de la de presentación (`main`) facilita reutilizar `calcularMaxMin` en otro programa (por ejemplo, uno que grafique las temperaturas).

## 2.7 Aplicación de la metodología

Este patrón de "inicializar con el primer valor y comparar contra el resto" es uno de los algoritmos más usados en programación: se aplica igual para encontrar la calificación más alta de un grupo, el producto más caro de un inventario, o el usuario con más publicaciones en una red social. Cambia el contexto, pero la lógica (2.3) es la misma.

---

# Ejemplo 3: Validador de contraseña segura

**Enunciado:** Desarrollar un programa que lea una contraseña y determine si es segura, considerando que debe cumplir tres reglas: tener al menos 8 caracteres, contener al menos una letra mayúscula y contener al menos un dígito.

## 2.1 Descripción y análisis del problema

| Pregunta | Respuesta |
|---|---|
| ¿Qué entra? | Una cadena de texto (la contraseña propuesta) |
| ¿Qué debe salir? | Un mensaje indicando si la contraseña es segura o no |
| ¿Restricciones? | Las tres reglas son fijas: ≥ 8 caracteres, ≥ 1 mayúscula, ≥ 1 dígito |
| ¿Casos especiales? | Cadena vacía, contraseña que cumple solo una o dos de las tres reglas |
| ¿Cómo verifico? | Probar contraseñas que fallan cada regla por separado y una que las cumple todas |

## 2.2 Definición de soluciones

- **Enfoque A (elegido):** crear una función booleana pequeña por cada regla (`tieneLongitudMinima`, `tieneMayuscula`, `tieneDigito`) y combinarlas con el operador lógico `Y` (`&&`). Cada regla se puede probar, leer y modificar por separado.
- **Enfoque B (alternativa):** escribir un solo bloque con condicionales anidados (`if` dentro de `if` dentro de `if`) que revise las tres condiciones a la vez. Funciona igual, pero se vuelve difícil de leer en cuanto se agrega una cuarta regla (por ejemplo, exigir un carácter especial).

Esta comparación es una buena oportunidad para reforzar en clase la relación entre el subtema 2.2 (definición de soluciones) y el 2.6 (buenas prácticas): la solución "más simple de escribir" no siempre es la más fácil de mantener.

## 2.3 Diseño de algoritmos y soluciones

```
INICIO
  PEDIR contraseña

  longitudOK ← longitud(contraseña) >= 8
  mayusculaOK ← contraseña contiene alguna letra mayúscula
  digitoOK ← contraseña contiene algún dígito

  SI longitudOK Y mayusculaOK Y digitoOK ENTONCES
      MOSTRAR "Contraseña segura"
  SINO
      MOSTRAR "Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito"
  FIN SI
FIN
```

## 2.4 Implementación de soluciones en código

**Python:**
```python
def tiene_longitud_minima(password):
    return len(password) >= 8


def tiene_mayuscula(password):
    return any(c.isupper() for c in password)


def tiene_digito(password):
    return any(c.isdigit() for c in password)


def es_segura(password):
    return tiene_longitud_minima(password) and tiene_mayuscula(password) and tiene_digito(password)


def main():
    password = input("Escribe una contraseña: ")
    if es_segura(password):
        print("Contraseña segura")
    else:
        print("Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito")


if __name__ == "__main__":
    main()
```

**C#:**
```csharp
using System;
using System.Linq;

class ValidadorPassword
{
    static bool TieneLongitudMinima(string password) => password.Length >= 8;
    static bool TieneMayuscula(string password) => password.Any(char.IsUpper);
    static bool TieneDigito(string password) => password.Any(char.IsDigit);

    static bool EsSegura(string password) =>
        TieneLongitudMinima(password) && TieneMayuscula(password) && TieneDigito(password);

    static void Main()
    {
        Console.Write("Escribe una contraseña: ");
        string password = Console.ReadLine();
        Console.WriteLine(EsSegura(password)
            ? "Contraseña segura"
            : "Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito");
    }
}
```

**Java:**
```java
import java.util.Scanner;

public class ValidadorPassword {

    static boolean tieneLongitudMinima(String password) {
        return password.length() >= 8;
    }

    static boolean tieneMayuscula(String password) {
        for (char c : password.toCharArray()) {
            if (Character.isUpperCase(c)) return true;
        }
        return false;
    }

    static boolean tieneDigito(String password) {
        for (char c : password.toCharArray()) {
            if (Character.isDigit(c)) return true;
        }
        return false;
    }

    static boolean esSegura(String password) {
        return tieneLongitudMinima(password) && tieneMayuscula(password) && tieneDigito(password);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe una contraseña: ");
        String password = sc.nextLine();
        System.out.println(esSegura(password)
            ? "Contraseña segura"
            : "Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito");
    }
}
```

## 2.5 Depuración, pruebas y manejo de errores

| # | Entrada | ¿Segura? | Regla que falla |
|---|---|---|---|
| 1 | `"Abcdefg1"` | Sí | — (cumple las tres reglas) |
| 2 | `"abcdefg1"` | No | Falta mayúscula |
| 3 | `"ABCDEFGH"` | No | Falta dígito |
| 4 | `"Ab1"` | No | Longitud menor a 8 |
| 5 | `""` (vacía) | No | Falla las tres reglas a la vez |

Este es un buen ejemplo para mostrar en clase **por qué conviene probar cada regla por separado**: si solo se prueba con una contraseña "obviamente mala" (como la vacía) y una "obviamente buena", nunca se detectaría un error si, por ejemplo, la función `tieneDigito` estuviera mal escrita — porque ambas pruebas seguirían dando el resultado "esperado" por casualidad.

## 2.6 Documentación y buenas prácticas

- Cada función booleana tiene un nombre que **es** la pregunta que responde: `tieneMayuscula(password)` se lee casi como lenguaje natural.
- No fue necesario agregar un comentario explicando qué hace cada función: el buen nombramiento hizo el trabajo del comentario. Esto ilustra la idea central del subtema 2.6 — nombrar bien reduce la necesidad de documentar de más.

## 2.7 Aplicación de la metodología

Separar una regla de negocio compleja en varias funciones booleanas pequeñas y combinarlas con `Y`/`O` es exactamente lo que hacen los formularios de registro en aplicaciones reales (validar correo, contraseña, edad mínima, términos y condiciones). El estudiante que domina este patrón en un problema pequeño está listo para extenderlo a un formulario completo.

---

## Cierre: lo que estos tres ejemplos refuerzan de la Unidad 2

| Subtema | Lo que se repitió en los tres ejemplos |
|---|---|
| 2.1 | Las mismas 5 preguntas de análisis, aplicadas a datos de distinta naturaleza (texto, listas, reglas booleanas) |
| 2.2 | Comparar siempre al menos dos enfoques antes de programar, y justificar la elección |
| 2.3 | Pseudocódigo como paso obligatorio antes de escribir código |
| 2.4 | La misma lógica traducida a Python, C# y Java sin cambiar el diseño |
| 2.5 | Tablas de prueba con casos normales, límite y de error — y reconocer cuándo *sí* y cuándo *no* se necesita manejo de excepciones |
| 2.6 | Nombres descriptivos y funciones de una sola responsabilidad como forma de documentación |
| 2.7 | Reconocer que el mismo patrón de solución reaparece en problemas distintos |

¿Quieres que convierta estos tres ejemplos en una **presentación .pptx** complementaria (con el mismo diseño visual), o que prepare una **lista de ejercicios sin resolver** basados en este mismo formato para que los estudiantes practiquen la metodología por su cuenta?
