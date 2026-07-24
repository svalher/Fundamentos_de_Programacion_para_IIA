# Ejemplo integrador — Unidad 3

**Proyecto:** Conversor de temperaturas (Celsius ↔ Fahrenheit ↔ Kelvin)
**Asignatura:** Fundamentos de Programación (IAD-2413) · Ingeniería en Inteligencia Artificial · ITD-TecNM

Este ejemplo reúne, en un solo flujo de trabajo real, los tres subtemas de la Unidad 3:

| Subtema | ¿Dónde aparece en este ejemplo? |
|---|---|
| **3.1 IDE** | Se construye y depura dentro de VS Code, con breakpoints |
| **3.2 Bibliotecas** | Usa el módulo estándar `math` para redondear resultados |
| **3.3 Organización** | El código vive en una estructura de proyecto con `src/`, `tests/`, `README.md` y Git |

El archivo `conversor_temperatura.zip` que acompaña esta guía contiene el proyecto **ya resuelto**, para que el estudiante lo abra directamente en su IDE y siga los pasos de esta guía sobre él (o lo use como referencia para construir el suyo desde cero).

---

## Paso 1 (3.1) — Crear el proyecto en el IDE

1. Abrir VS Code.
2. `Archivo → Abrir carpeta…` y crear/seleccionar una carpeta vacía llamada `conversor_temperatura/`.
3. Confirmar que el intérprete de Python correcto está seleccionado: `Ctrl+Shift+P → Python: Select Interpreter`.
4. Abrir la terminal integrada (`` Ctrl+ ` ``).

## Paso 2 (3.3) — Crear la estructura de carpetas

Desde la terminal integrada:

```bash
mkdir src tests
```

La estructura objetivo es:

```
conversor_temperatura/
├── src/
│   └── conversor.py
├── tests/
│   └── test_conversor.py
├── requirements.txt
├── .gitignore
└── README.md
```

## Paso 3 (3.2) — Escribir el código usando una biblioteca estándar

Archivo `src/conversor.py`:

```python
import math


def celsius_a_fahrenheit(celsius):
    """Convierte grados Celsius a Fahrenheit, redondeado a 2 decimales."""
    fahrenheit = (celsius * 9 / 5) + 32
    return math.floor(fahrenheit * 100) / 100


def fahrenheit_a_celsius(fahrenheit):
    """Convierte grados Fahrenheit a Celsius, redondeado a 2 decimales."""
    celsius = (fahrenheit - 32) * 5 / 9
    return math.floor(celsius * 100) / 100


if __name__ == "__main__":
    temperatura = 24
    resultado = celsius_a_fahrenheit(temperatura)
    print(f"{temperatura}°C equivalen a {resultado}°F")
```

**Punto clave para discutir en clase:** la función usa `math.floor()` en lugar de que el estudiante programe manualmente el redondeo — así se reutiliza una función ya probada de la biblioteca estándar en vez de reinventarla (idea central del subtema 3.2).

Al ejecutar el archivo desde la terminal:

```bash
python src/conversor.py
```

Salida real obtenida al ejecutar este mismo código:

```
24°C equivalen a 75.2°F
```

## Paso 4 (3.1) — Depurar el programa paso a paso

1. Colocar un *breakpoint* haciendo clic a la izquierda del número de línea `fahrenheit = (celsius * 9 / 5) + 32`.
2. Presionar `F5` (o el botón de "Run and Debug").
3. Cuando la ejecución se detenga, observar en el panel de variables el valor de `celsius` y, un paso después (`Step Over` / `F10`), el valor recién calculado de `fahrenheit`.
4. Esto ayuda a comprobar visualmente que la fórmula matemática se está aplicando correctamente antes de confiar en el resultado impreso.

## Paso 5 (3.3) — Escribir pruebas unitarias

Archivo `tests/test_conversor.py`:

```python
import unittest
import sys
import os

sys.path.insert(0, os.path.join(os.path.dirname(__file__), "..", "src"))

from conversor import celsius_a_fahrenheit, fahrenheit_a_celsius


class TestConversor(unittest.TestCase):

    def test_celsius_a_fahrenheit_cero(self):
        self.assertEqual(celsius_a_fahrenheit(0), 32.0)

    def test_celsius_a_fahrenheit_valor_positivo(self):
        self.assertEqual(celsius_a_fahrenheit(24), 75.2)

    def test_fahrenheit_a_celsius_valor_conocido(self):
        self.assertEqual(fahrenheit_a_celsius(75.2), 24.0)

    def test_conversion_de_ida_y_vuelta(self):
        original = 30
        ida_y_vuelta = fahrenheit_a_celsius(celsius_a_fahrenheit(original))
        self.assertAlmostEqual(ida_y_vuelta, original, delta=0.1)


if __name__ == "__main__":
    unittest.main()
```

Ejecutar las pruebas desde la terminal integrada:

```bash
python -m unittest discover tests -v
```

Salida real obtenida al correr estas pruebas sobre el código anterior:

```
test_celsius_a_fahrenheit_cero (test_conversor.TestConversor.test_celsius_a_fahrenheit_cero) ... ok
test_celsius_a_fahrenheit_valor_positivo (test_conversor.TestConversor.test_celsius_a_fahrenheit_valor_positivo) ... ok
test_conversion_de_ida_y_vuelta (test_conversor.TestConversor.test_conversion_de_ida_y_vuelta) ... ok
test_fahrenheit_a_celsius_valor_conocido (test_conversor.TestConversor.test_fahrenheit_a_celsius_valor_conocido) ... ok

----------------------------------------------------------------------
Ran 4 tests in 0.001s

OK
```

Las cuatro pruebas pasan (`OK`), lo que da confianza de que la función funciona correctamente antes de seguir agregando código.

## Paso 6 — Completar `README.md` y `requirements.txt`

`requirements.txt` (vacío porque el proyecto solo usa la biblioteca estándar):

```
# Este proyecto solo usa la biblioteca estándar de Python (math),
# por lo que no requiere dependencias externas.
```

`README.md`:

```markdown
# Conversor de temperaturas

Convierte temperaturas entre grados Celsius y Fahrenheit.

## Requisitos
- Python 3.10 o superior

## Ejecución
python src/conversor.py

## Pruebas
python -m unittest discover tests
```

## Paso 7 (3.1) — Inicializar Git y hacer el primer commit

```bash
git init
git add .
git commit -m "Primera version del conversor de temperaturas"
```

Salida real de `git log --oneline` después de este commit:

```
239a193 Primera version del conversor de temperaturas
```

## Paso 8 (3.2 + 3.3) — Agregar una función nueva y registrar el cambio

Se agrega una tercera conversión (a Kelvin) reutilizando otra vez `math`:

```python
def celsius_a_kelvin(celsius):
    """Convierte grados Celsius a Kelvin, redondeado a 2 decimales."""
    kelvin = celsius + 273.15
    return math.floor(kelvin * 100) / 100
```

Al guardar el archivo, `git status` refleja el cambio:

```
 M src/conversor.py
```

Se registra el cambio con un nuevo commit:

```bash
git add .
git commit -m "Agrega conversion de Celsius a Kelvin"
```

Historial final real, con los dos commits:

```
053ea4f Agrega conversion de Celsius a Kelvin
239a193 Primera version del conversor de temperaturas
```

Este historial es exactamente lo que un evaluador vería si el estudiante entrega el proyecto con `git log --oneline`: evidencia de que el trabajo se hizo de forma incremental y ordenada, no todo de golpe al final.

---

## Resumen del flujo completo

```
3.1 Abrir IDE ─► 3.3 Crear carpetas ─► 3.2 Escribir código con math
      │                                          │
      └──────────────► 3.1 Depurar paso a paso ◄─┘
                              │
                    3.3 Escribir pruebas unitarias
                              │
                    3.3 README + requirements.txt
                              │
                    3.1 git init → commit
                              │
              3.2 + 3.3 Nueva función → nuevo commit
```

## Para el estudiante: ejercicio propuesto a partir de este ejemplo

1. Descomprimir `conversor_temperatura.zip` y abrirlo en VS Code.
2. Agregar una cuarta función `kelvin_a_celsius(kelvin)`.
3. Escribir al menos una prueba unitaria nueva para esa función.
4. Ejecutar `python -m unittest discover tests` y confirmar que **todas** las pruebas (las nuevas y las anteriores) pasan.
5. Inicializar Git en su copia del proyecto y hacer un commit por cada paso (no un solo commit al final).
6. Entregar: capturas del IDE, el código final y el resultado de `git log --oneline`.

Este ejercicio es una versión reducida y guiada de lo que se pedirá en la Práctica 3.
