# El proceso de las pruebas unitarias en Python, C# y Java

**Ejemplo de referencia:** Conversor de temperaturas (Unidad 3)
**Asignatura:** Fundamentos de Programación (IAD-2413) · Ingeniería en Inteligencia Artificial · ITD-TecNM

---

## 1. La idea general: Arrange–Act–Assert

Antes de ver la sintaxis de cada lenguaje, hay que entender que **toda prueba unitaria sigue el mismo patrón**, sin importar el lenguaje en el que se escriba. Este patrón se conoce como **Arrange–Act–Assert** (preparar–actuar–afirmar):

| Paso | ¿Qué significa? | Ejemplo en el conversor de temperaturas |
|---|---|---|
| **Arrange** (preparar) | Se define un valor de entrada conocido | `24` grados Celsius |
| **Act** (actuar) | Se llama a la función que se quiere probar con ese valor | `celsius_a_fahrenheit(24)` |
| **Assert** (afirmar) | Se compara lo que devolvió la función contra el resultado que **ya se sabe** que es correcto | ¿El resultado es `75.2`? |

Si la comparación es verdadera, la prueba **pasa** (✔). Si no, la prueba **falla** (✘) y señala exactamente qué función se rompió, sin que el estudiante tenga que revisar todo el programa a mano.

Este es el concepto central que no cambia entre lenguajes. Lo que sí cambia es la **sintaxis** con la que cada framework de pruebas expresa esas tres partes.

---

## 2. Python — `unittest`

Archivo `tests/test_conversor.py`:

```python
import unittest
from conversor import celsius_a_fahrenheit

class TestConversor(unittest.TestCase):

    def test_celsius_a_fahrenheit_valor_positivo(self):
        self.assertEqual(celsius_a_fahrenheit(24), 75.2)
```

| Elemento | Qué hace |
|---|---|
| `class TestConversor(unittest.TestCase)` | Toda clase que hereda de `TestCase` es reconocida automáticamente como un conjunto de pruebas |
| `def test_...` | Cada método que empieza con el prefijo `test_` se ejecuta como una prueba independiente — así es como `unittest` sabe cuáles métodos correr |
| `self.assertEqual(actual, esperado)` | Compara el valor que devolvió la función (Act) contra el valor esperado (Assert) |

**Ejecución:**
```bash
python -m unittest discover tests
```

El comando busca automáticamente todos los archivos `test_*.py` dentro de la carpeta `tests/`, los importa y corre cada método `test_*`. Al final imprime un resumen (`OK` si todo pasó, o el detalle de qué falló).

---

## 3. C# — MSTest

Archivo `Tests/ConversorTests.cs`:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ConversorTests
{
    [TestMethod]
    public void CelsiusAFahrenheit_ValorPositivo_DevuelveSetentaYCincoPuntoDos()
    {
        Assert.AreEqual(75.2, Conversor.CelsiusAFahrenheit(24));
    }
}
```

| Elemento | Qué hace |
|---|---|
| `[TestClass]` | *Atributo* (una etiqueta especial) que le indica al framework "esta clase contiene pruebas" |
| `[TestMethod]` | Marca ese método específico como una prueba ejecutable — a diferencia de Python, no basta con el nombre del método; se necesita el atributo explícito |
| `Assert.AreEqual(esperado, actual)` | **Atención al orden:** en MSTest el primer argumento es el valor esperado y el segundo el obtenido — al revés de como uno tiende a pensarlo |

**Ejecución:**
```bash
dotnet test Tests/Tests.csproj
```

El SDK de .NET lee el `Tests.csproj`, compila el proyecto de pruebas (que referencia al proyecto principal mediante `<ProjectReference>`), descubre todos los métodos con `[TestMethod]` dentro de clases `[TestClass]`, y los ejecuta.

---

## 4. Java — JUnit

Archivo `src/test/java/ConversorTest.java`:

```java
import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class ConversorTest {

    @Test
    public void celsiusAFahrenheit_valorPositivo_devuelveSetentaYCincoPuntoDos() {
        assertEquals(75.2, Conversor.celsiusAFahrenheit(24), 0.0001);
    }
}
```

| Elemento | Qué hace |
|---|---|
| `@Test` | Anotación de JUnit — el equivalente Java de `[TestMethod]` en C# — marca el método como una prueba |
| `assertEquals(esperado, actual, delta)` | Igual que en C#, el primer valor es el esperado. El tercer parámetro (`delta`) es propio de Java: como los `double` tienen imprecisión de punto flotante, en vez de exigir una igualdad exacta se permite un margen de error mínimo (aquí, `0.0001`) |
| `import static org.junit.Assert.assertEquals;` | Permite escribir `assertEquals(...)` directamente en vez de `Assert.assertEquals(...)` |

**Ejecución:**
```bash
mvn test
```

Maven lee el `pom.xml`, descarga la dependencia de JUnit declarada ahí, compila `src/main/java` y `src/test/java`, y ejecuta automáticamente todos los métodos `@Test` que encuentre.

---

## 5. Comparación directa

| | Python (`unittest`) | C# (MSTest) | Java (JUnit) |
|---|---|---|---|
| Cómo se marca una prueba | El nombre del método empieza con `test_` | Atributo `[TestMethod]` sobre el método | Anotación `@Test` sobre el método |
| Cómo se marca la clase | Hereda de `unittest.TestCase` | Atributo `[TestClass]` | No requiere marca especial |
| Comparación | `self.assertEqual(actual, esperado)` | `Assert.AreEqual(esperado, actual)` | `assertEquals(esperado, actual, delta)` |
| Orden esperado/obtenido | Actual primero | Esperado primero | Esperado primero |
| Tolerancia para decimales | No se usó (el redondeo ya deja un valor exacto) | No se usó (mismo motivo) | Se exige explícitamente con `delta` |
| Comando para correr | `python -m unittest discover tests` | `dotnet test` | `mvn test` |
| ¿Requiere compilar antes? | No (Python es interpretado) | Sí — `dotnet test` compila automáticamente | Sí — Maven compila automáticamente |

---

## 6. Punto pedagógico clave

Aunque la sintaxis cambia de un lenguaje a otro, **la lógica es idéntica en los tres**: una etiqueta que identifica al método como una prueba, una llamada a la función real del programa, y una comparación contra un valor que ya se sabe correcto. Es el mismo patrón **Arrange–Act–Assert**, disfrazado con la sintaxis propia de cada lenguaje.

Entender esto le permite al estudiante moverse entre `unittest`, MSTest, JUnit — o cualquier otro framework de pruebas que encuentre en su carrera — reconociendo siempre la misma estructura debajo de la sintaxis distinta.
