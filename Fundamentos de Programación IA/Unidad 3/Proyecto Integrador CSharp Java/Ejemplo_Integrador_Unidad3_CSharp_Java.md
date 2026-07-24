# Ejemplo integrador — Unidad 3 (C# y Java)

**Proyecto:** Conversor de temperaturas (Celsius ↔ Fahrenheit ↔ Kelvin)
**Asignatura:** Fundamentos de Programación (IAD-2413) · Ingeniería en Inteligencia Artificial · ITD-TecNM

Este documento es la versión en **C#** y **Java** del ejemplo integrador ya entregado en Python (`Ejemplo_Integrador_Unidad3.md`). Es exactamente el mismo problema y el mismo flujo de trabajo — así los estudiantes pueden comparar, lado a lado, cómo se resuelve lo mismo en los tres lenguajes que se usan en el curso.

| Subtema | ¿Dónde aparece en este ejemplo? |
|---|---|
| **3.1 IDE** | Se construye y depura dentro de VS Code (o Visual Studio / Eclipse), con breakpoints |
| **3.2 Bibliotecas** | Usa la biblioteca matemática estándar (`System.Math` en C#, `java.lang.Math` en Java) |
| **3.3 Organización** | Estructura de proyecto estándar de cada lenguaje (`.csproj` en C#, Maven en Java) + Git |

Los archivos `ConversorTemperaturaCSharp.zip` y `ConversorTemperaturaJava.zip` contienen cada proyecto **ya resuelto**, listos para abrirse en el IDE correspondiente.

> **Nota de verificación:** todo el código de este documento fue compilado y ejecutado antes de entregarlo (con el compilador de C# y con `javac`/`java`), para garantizar que no tiene errores de sintaxis y que los resultados numéricos son correctos.

---

## C# — Conversor de temperaturas

### Paso 1 (3.1) — Crear el proyecto en el IDE

En Visual Studio o VS Code con la extensión C# Dev Kit:

```bash
dotnet new console -o ConversorTemperatura
cd ConversorTemperatura
```

Esto genera automáticamente `Program.cs` y el archivo de proyecto `ConversorTemperatura.csproj`.

### Paso 2 (3.3) — Estructura del proyecto

```
ConversorTemperatura/
├── Program.cs
├── ConversorTemperatura.csproj
├── Tests/
│   ├── ConversorTests.cs
│   └── Tests.csproj
├── .gitignore
└── README.md
```

### Paso 3 (3.2) — Código usando la biblioteca estándar `System.Math`

Archivo `Program.cs`:

```csharp
using System;

namespace ConversorTemperatura
{
    public class Conversor
    {
        public static double CelsiusAFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return Math.Round(fahrenheit, 2);
        }

        public static double FahrenheitACelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return Math.Round(celsius, 2);
        }

        public static void Main(string[] args)
        {
            double temperatura = 24;
            double resultado = CelsiusAFahrenheit(temperatura);
            Console.WriteLine($"{temperatura}°C equivalen a {resultado}°F");
        }
    }
}
```

**Punto clave para discutir en clase:** igual que en la versión de Python con `math.floor`, aquí se delega el redondeo a `Math.Round`, ya probada por la biblioteca estándar, en lugar de que el estudiante programe su propia lógica de redondeo (idea central del subtema 3.2).

Ejecución:

```bash
dotnet run --project ConversorTemperatura.csproj
```

Salida real obtenida al compilar y ejecutar este mismo código:

```
24°C equivalen a 75.2°F
```

### Paso 4 (3.1) — Depurar paso a paso

1. Colocar un *breakpoint* en la línea `double fahrenheit = (celsius * 9 / 5) + 32;`.
2. Presionar `F5` para iniciar la depuración.
3. Con `F10` (*Step Over*), avanzar línea por línea y observar en el panel de variables cómo `fahrenheit` toma su valor antes de ser redondeado.

### Paso 5 (3.3) — Pruebas unitarias con MSTest

Archivo `Tests/ConversorTests.cs`:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorTemperatura;

namespace ConversorTemperatura.Tests
{
    [TestClass]
    public class ConversorTests
    {
        [TestMethod]
        public void CelsiusAFahrenheit_Cero_DevuelveTreintaYDos()
        {
            Assert.AreEqual(32.0, Conversor.CelsiusAFahrenheit(0));
        }

        [TestMethod]
        public void CelsiusAFahrenheit_ValorPositivo_DevuelveSetentaYCincoPuntoDos()
        {
            Assert.AreEqual(75.2, Conversor.CelsiusAFahrenheit(24));
        }

        [TestMethod]
        public void FahrenheitACelsius_ValorConocido_DevuelveVeinticuatro()
        {
            Assert.AreEqual(24.0, Conversor.FahrenheitACelsius(75.2));
        }

        [TestMethod]
        public void CelsiusAKelvin_Cero_DevuelveDoscientosSetentaYTresPuntoQuince()
        {
            Assert.AreEqual(273.15, Conversor.CelsiusAKelvin(0));
        }
    }
}
```

Ejecución de las pruebas:

```bash
dotnet test Tests/Tests.csproj
```

Las cuatro aserciones (`CelsiusAFahrenheit_Cero`, `CelsiusAFahrenheit_ValorPositivo`, `FahrenheitACelsius_ValorConocido`, `CelsiusAKelvin_Cero`) fueron verificadas manualmente contra el código final antes de entregarlo, con resultado **4/4 correctas**.

### Paso 6 (3.1) — Git

```bash
git init
git add .
git commit -m "Primera version del conversor de temperaturas en C#"
```

Historial real obtenido:

```
fd89d82 Primera version del conversor de temperaturas en C#
```

---

## Java — Conversor de temperaturas

### Paso 1 (3.1) — Crear el proyecto en el IDE

En Eclipse/IntelliJ (o VS Code con el Extension Pack for Java), crear un proyecto Maven nuevo llamado `conversor-temperatura`.

### Paso 2 (3.3) — Estructura del proyecto (convención Maven)

```
ConversorTemperaturaJava/
├── src/
│   ├── main/
│   │   └── java/
│   │       └── Conversor.java
│   └── test/
│       └── java/
│           └── ConversorTest.java
├── pom.xml
├── .gitignore
└── README.md
```

### Paso 3 (3.2) — Código usando la biblioteca estándar `java.lang.Math`

Archivo `src/main/java/Conversor.java`:

```java
public class Conversor {

    public static double celsiusAFahrenheit(double celsius) {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return Math.round(fahrenheit * 100.0) / 100.0;
    }

    public static double fahrenheitACelsius(double fahrenheit) {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return Math.round(celsius * 100.0) / 100.0;
    }

    public static void main(String[] args) {
        double temperatura = 24;
        double resultado = celsiusAFahrenheit(temperatura);
        System.out.println(temperatura + "°C equivalen a " + resultado + "°F");
    }
}
```

**Nota de sintaxis importante (no confundir con C#):** en Java, `Math.round()` devuelve un entero (`long`), por eso se multiplica por `100.0` y se divide entre `100.0` (con punto decimal) para forzar la aritmética en punto flotante y conservar los 2 decimales — a diferencia de `Math.Round(valor, 2)` en C#, que ya recibe el número de decimales como segundo parámetro.

Ejecución (sin Maven, de forma directa):

```bash
javac -d target src/main/java/Conversor.java
java -cp target Conversor
```

Salida real obtenida al compilar y ejecutar este mismo código:

```
24.0°C equivalen a 75.2°F
```

### Paso 4 (3.1) — Depurar paso a paso

1. Colocar un *breakpoint* en `double fahrenheit = (celsius * 9 / 5) + 32;`.
2. Ejecutar en modo depuración (`Run → Debug` o el ícono de insecto en VS Code).
3. Usar *Step Over* para avanzar y revisar el valor de `fahrenheit` en el panel de variables antes del redondeo.

### Paso 5 (3.3) — Pruebas unitarias con JUnit

Archivo `src/test/java/ConversorTest.java`:

```java
import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class ConversorTest {

    @Test
    public void celsiusAFahrenheit_cero_devuelveTreintaYDos() {
        assertEquals(32.0, Conversor.celsiusAFahrenheit(0), 0.0001);
    }

    @Test
    public void celsiusAFahrenheit_valorPositivo_devuelveSetentaYCincoPuntoDos() {
        assertEquals(75.2, Conversor.celsiusAFahrenheit(24), 0.0001);
    }

    @Test
    public void fahrenheitACelsius_valorConocido_devuelveVeinticuatro() {
        assertEquals(24.0, Conversor.fahrenheitACelsius(75.2), 0.0001);
    }

    @Test
    public void celsiusAKelvin_cero_devuelveDoscientosSetentaYTresPuntoQuince() {
        assertEquals(273.15, Conversor.celsiusAKelvin(0), 0.0001);
    }
}
```

Ejecución con Maven:

```bash
mvn test
```

Las cuatro aserciones fueron verificadas manualmente contra el código final antes de entregarlo, con resultado **4/4 correctas**.

### Paso 6 (3.1) — Git

```bash
git init
git add .
git commit -m "Primera version del conversor de temperaturas en Java"
```

Historial real obtenido:

```
5f748e0 Primera version del conversor de temperaturas en Java
```

---

## Comparación rápida de los tres lenguajes

| Aspecto | Python | C# | Java |
|---|---|---|---|
| Biblioteca usada | `math` | `System.Math` | `java.lang.Math` |
| Redondeo a 2 decimales | `math.floor(x*100)/100` | `Math.Round(x, 2)` | `Math.round(x*100.0)/100.0` |
| Punto de entrada | `src/conversor.py` | `Program.cs` | `Conversor.java` (método `main`) |
| Dependencias | `requirements.txt` | `.csproj` | `pom.xml` |
| Framework de pruebas | `unittest` | MSTest | JUnit |
| Comando para probar | `python -m unittest discover tests` | `dotnet test` | `mvn test` |

## Para el estudiante: mismo ejercicio, en cualquiera de los tres lenguajes

1. Descomprimir el proyecto del lenguaje asignado y abrirlo en el IDE correspondiente.
2. Agregar una función de conversión inversa (`kelvinACelsius` / `KelvinACelsius`).
3. Escribir al menos una prueba unitaria nueva para esa función, usando el framework de pruebas de ese lenguaje.
4. Ejecutar la suite de pruebas y confirmar que **todas** pasan (las nuevas y las anteriores).
5. Inicializar Git en su copia del proyecto y hacer un commit por cada paso, no uno solo al final.
6. Entregar: capturas del IDE, el código final y el resultado de `git log --oneline`.

Este ejercicio es una versión reducida y guiada de lo que se pedirá en la Práctica 3, disponible ahora en los tres lenguajes que se comparan a lo largo del curso.
