# Unidad 3: Herramientas de programación y desarrollo de aplicaciones

**Asignatura:** Fundamentos de Programación (IAD-2413)
**Carrera:** Ingeniería en Inteligencia Artificial
**Instituto Tecnológico de Durango — TecNM**

---

## 0. Ubicación de la unidad en el programa

La Unidad 3 es el puente entre los fundamentos teórico-algorítmicos (Unidades 1 y 2) y el desarrollo de aplicaciones prácticas (Unidad 4). Hasta ahora el estudiante ha escrito programas cortos, probablemente en un solo archivo, y los ha ejecutado de forma manual. A partir de esta unidad empieza a trabajar **como se trabaja en la industria**:

- Usando un entorno de desarrollo profesional en lugar de un editor de texto simple.
- Apoyándose en código ya construido y probado por otros (bibliotecas) en lugar de reinventar todo desde cero.
- Organizando su trabajo en una estructura de proyecto reconocible, que cualquier otra persona (o él mismo, meses después) pueda entender y mantener.

**Competencia específica de la unidad:** el estudiante utiliza entornos de desarrollo integrados, bibliotecas y módulos estándar, y aplica buenas prácticas de organización de proyectos de software.

**Relación con el resto del curso:** lo aprendido aquí se aplica directamente en la Unidad 4 (desarrollo de aplicaciones web, móviles y de escritorio) y sienta la base para materias posteriores como Algoritmia y Estructuras de Datos, Programación Orientada a Objetos y Bases de Datos, donde el uso de librerías externas y la organización de proyectos es constante y cada vez más compleja.

### Mapa mental de la unidad

```
Unidad 3
│
├── 3.1 IDE ─────────────► "¿Con qué herramienta escribo, ejecuto y depuro mi código?"
│
├── 3.2 Bibliotecas ─────► "¿Qué código ya existe y puedo reutilizar en vez de escribirlo yo?"
│
└── 3.3 Organización ────► "¿Cómo ordeno todo esto para que sea mantenible?"
```

Las tres partes no son temas aislados: en la práctica se usan **simultáneamente**. Se abre un IDE (3.1), dentro de él se importa una biblioteca (3.2), y todo el trabajo se guarda dentro de una estructura de proyecto ordenada (3.3). El ejercicio integrador de la sección 8 de este documento muestra las tres partes trabajando juntas.

---

## 1. Temario oficial de la unidad

| No. | Subtema |
|---|---|
| 3.1 | Entornos de desarrollo integrados (IDE) |
| 3.2 | Uso de bibliotecas y módulos estándar |
| 3.3 | Creación y organización de proyectos de software |

---

## 2. Competencias a desarrollar

**Específica(s):**
En Herramientas de Programación y Desarrollo de Aplicaciones, los estudiantes se introducen en el uso de IDEs, bibliotecas estándar, y estructuras de control como condicionales y bucles aplicadas en un contexto de proyecto real. También aprenden a organizar proyectos de software eficientemente.

**Genérica(s):**
- Capacidad de análisis y síntesis.
- Comunicación oral y escrita.
- Habilidad para buscar y analizar información proveniente de fuentes diversas.
- Trabajo en equipo.
- Aplicar el pensamiento analítico, lógico, creativo e innovador para el análisis y la toma de decisiones.
- Compromiso ético.
- Capacidad de aprender.
- Habilidad para trabajar en forma autónoma.
- Búsqueda del logro.

---

## 3.1 Entornos de desarrollo integrados (IDE)

### 3.1.1 ¿Qué es un IDE? (explicación desde cero)

Imagina que quieres construir un mueble de madera. Podrías hacerlo con solo un serrucho, pero sería lento y propenso a errores. Un **taller completo** con sierra eléctrica, taladro, lijadora y banco de trabajo te permite hacer el mismo mueble más rápido, con menos errores y con mejor acabado. Un IDE es ese taller, pero para escribir software.

Un **Entorno de Desarrollo Integrado** (*Integrated Development Environment*, IDE) es una aplicación que reúne, en un solo programa, todas las herramientas que un programador necesita para escribir, ejecutar, probar y corregir código:

| Herramienta incluida | ¿Para qué sirve? |
|---|---|
| **Editor de código** | Escribir el código con resaltado de sintaxis (colores según el tipo de palabra: palabra clave, variable, cadena de texto, etc.) |
| **Autocompletado / IntelliSense** | Sugiere nombres de funciones, variables y muestra su documentación mientras se escribe, reduciendo errores de dedo y de sintaxis |
| **Compilador o intérprete integrado** | Ejecuta el programa sin salir del entorno ni escribir comandos manualmente |
| **Depurador (debugger)** | Ejecuta el programa paso a paso para encontrar errores lógicos |
| **Integración con control de versiones (Git)** | Guarda el historial de cambios del proyecto y facilita el trabajo en equipo |
| **Gestor de dependencias/paquetes** | Instala bibliotecas externas de forma automática |
| **Terminal integrada** | Permite ejecutar comandos del sistema sin cambiar de ventana |

### 3.1.2 IDE vs. editor de texto vs. compilador: no confundir los términos

Es un error común confundir estos tres conceptos. Aclarémoslos:

| Concepto | ¿Qué es? | Ejemplo |
|---|---|---|
| **Editor de texto** | Solo permite escribir y guardar texto plano, sin entender el lenguaje de programación | Bloc de notas, Notepad++ |
| **Compilador / intérprete** | Programa que traduce el código fuente a algo que la computadora puede ejecutar | `python.exe`, `javac`, `csc` |
| **IDE** | Combina un editor "inteligente" + compilador/intérprete + depurador + más herramientas, todo integrado | VS Code, PyCharm, Visual Studio, Eclipse |

Un IDE **no reemplaza** al compilador o intérprete: internamente sigue usando el compilador de Python, Java o C# — lo que hace es darte una interfaz cómoda para no tener que escribir todos los comandos a mano.

### 3.1.3 IDEs relevantes para el curso

| IDE | Lenguajes principales | Características destacadas | ¿Cuándo conviene usarlo? |
|---|---|---|---|
| **Visual Studio Code (VS Code)** | Multi-lenguaje (Python, Java, C#, JS...) vía extensiones | Ligero, gratuito, gran ecosistema de extensiones, terminal integrada, muy usado en la industria | Cuando se trabaja con varios lenguajes en el mismo curso/proyecto (recomendado como entorno principal del curso) |
| **PyCharm** | Python | Análisis de código muy profundo, refactorización avanzada, integración con entornos virtuales | Proyectos exclusivamente en Python de mediana/alta complejidad |
| **Visual Studio** (no confundir con VS Code) | C#, .NET | IDE completo de Microsoft, depurador muy potente, generador de interfaces gráficas | Proyectos en C# o .NET |
| **Eclipse / IntelliJ IDEA** | Java | Estándares de la industria para desarrollo Java empresarial | Proyectos en Java, especialmente si son grandes |

> **Recomendación didáctica para el curso:** usar **VS Code** como entorno común para las prácticas comparadas en Python, C# y Java, ya que evita que el estudiante tenga que aprender tres interfaces distintas. Se puede explorar PyCharm o Visual Studio como IDEs "nativos" cuando un proyecto se enfoque en un solo lenguaje.

### 3.1.4 Instalación y configuración paso a paso

**A) Instalar VS Code**
1. Ir a `code.visualstudio.com` y descargar el instalador correspondiente al sistema operativo (Windows, macOS o Linux).
2. Ejecutar el instalador con las opciones por defecto (se recomienda marcar la casilla "Agregar a PATH").
3. Abrir VS Code y confirmar que aparece la pantalla de bienvenida.

**B) Instalar el lenguaje y su extensión**

| Lenguaje | Qué instalar primero (fuera de VS Code) | Extensión de VS Code a instalar |
|---|---|---|
| Python | Intérprete de Python desde `python.org` (marcar "Add to PATH" durante la instalación) | Extensión oficial **"Python"** (de Microsoft) |
| C# | .NET SDK desde `dotnet.microsoft.com` | Extensión **"C# Dev Kit"** |
| Java | JDK (Java Development Kit) desde `oracle.com` o `adoptium.net` | Extensión **"Extension Pack for Java"** |

**C) Verificar que todo quedó instalado correctamente**

Abrir la terminal integrada de VS Code (menú `Terminal → New Terminal`, o atajo `` Ctrl + ` ``) y escribir:

```bash
python --version      # debe mostrar algo como: Python 3.12.1
dotnet --version       # debe mostrar algo como: 8.0.100
java -version          # debe mostrar algo como: java version "21"
javac -version         # el compilador de Java
```

Si alguno de estos comandos da un error de "comando no reconocido", normalmente significa que el instalador no agregó el programa al **PATH** del sistema y hay que reiniciar el equipo o agregarlo manualmente.

**D) Ejecutar el primer programa en cada lenguaje**

*Python* — crear `hola.py`:
```python
print("Hola, mundo")
```
Ejecutar desde la terminal: `python hola.py`

*C#* — crear un proyecto de consola:
```bash
dotnet new console -o HolaMundo
cd HolaMundo
dotnet run
```

*Java* — crear `Hola.java`:
```java
public class Hola {
    public static void main(String[] args) {
        System.out.println("Hola, mundo");
    }
}
```
Compilar y ejecutar: `javac Hola.java` seguido de `java Hola`

### 3.1.5 Depuración (debugging): explicación detallada

La **depuración** es la técnica para encontrar errores lógicos ejecutando el programa de forma controlada, en lugar de solo leyendo el código o adivinando dónde está el error.

**Conceptos clave:**

| Concepto | Explicación |
|---|---|
| **Breakpoint (punto de interrupción)** | Una marca que se coloca en una línea del código. Cuando el programa llega a esa línea durante la ejecución en modo depuración, se detiene automáticamente |
| **Step over (avanzar)** | Ejecuta la línea actual completa y pasa a la siguiente, sin entrar en detalle de las funciones que llama |
| **Step into (entrar)** | Si la línea actual llama a una función, "entra" dentro de esa función para ver qué hace internamente |
| **Step out (salir)** | Termina de ejecutar la función actual y regresa a donde fue llamada |
| **Panel de variables** | Muestra el valor actual de cada variable mientras el programa está detenido en un breakpoint |
| **Watch (vigilancia)** | Permite escribir una expresión específica para monitorear su valor mientras se depura |

**Ejemplo práctico (Python en VS Code):**

```python
def calcular_promedio(lista_numeros):
    suma = 0
    for numero in lista_numeros:      # <- aquí se coloca un breakpoint (clic en el margen izquierdo)
        suma += numero
    promedio = suma / len(lista_numeros)
    return promedio

notas = [8, 9, 7, 10]
resultado = calcular_promedio(notas)
print(f"El promedio es: {resultado}")
```

Al ejecutar en modo depuración (`F5` en VS Code) y llegar al breakpoint, el estudiante puede ver en el panel de variables cómo `suma` va creciendo en cada vuelta del ciclo (`for`), lo que ayuda a entender visualmente cómo funciona el bucle y a detectar si algo no se está sumando correctamente.

### 3.1.6 Control de versiones (Git): lo mínimo indispensable

**¿Por qué es importante desde ahora?** Porque un proyecto de software rara vez se termina en un solo intento: se escribe, se corrige, se agregan funciones nuevas. Git guarda el historial de todos esos cambios y permite:

- Regresar a una versión anterior si algo se rompe.
- Trabajar en equipo sin que dos personas sobrescriban el trabajo de la otra.
- Tener respaldo del proyecto en un servicio como GitHub.

**Comandos básicos que el estudiante debe conocer en esta unidad:**

| Comando | Qué hace |
|---|---|
| `git init` | Convierte la carpeta actual en un repositorio Git (empieza a llevar el historial) |
| `git add .` | Marca todos los archivos modificados para ser incluidos en el próximo "guardado" (commit) |
| `git commit -m "mensaje"` | Guarda una "fotografía" del proyecto en ese momento, con una descripción del cambio |
| `git status` | Muestra qué archivos han cambiado desde el último commit |
| `git log` | Muestra el historial de commits realizados |

Todo IDE moderno (incluido VS Code) tiene un panel visual de "Control de código fuente" que permite hacer estas mismas acciones con clics en lugar de comandos.

### 3.1.7 Errores comunes al configurar un IDE (y cómo resolverlos)

| Problema | Causa probable | Solución |
|---|---|---|
| `'python' no se reconoce como un comando interno o externo` | Python no se agregó al PATH durante la instalación | Reinstalar marcando "Add Python to PATH", o agregarlo manualmente a las variables de entorno |
| VS Code no sugiere autocompletado | Falta instalar la extensión del lenguaje, o no se seleccionó el intérprete correcto | Instalar la extensión oficial y usar `Ctrl+Shift+P → Python: Select Interpreter` |
| El programa se ejecuta pero no muestra nada en pantalla | La terminal integrada no es la correcta, o el archivo guardado no es el que se está ejecutando | Verificar que el archivo esté guardado (punto blanco junto al nombre = cambios sin guardar) y que la terminal apunte a la carpeta correcta |
| Java: `error: class Hola is public, should be declared in a file named Hola.java` | El nombre del archivo no coincide exactamente con el nombre de la clase pública | En Java, el nombre del archivo `.java` **debe** coincidir con el nombre de la clase pública que contiene |

---

## 3.2 Uso de bibliotecas y módulos estándar

### 3.2.1 Conceptos y diferencias

Es común mezclar estos términos; aquí se definen con precisión:

| Término | Definición | Analogía |
|---|---|---|
| **Módulo** | Un solo archivo (o unidad pequeña) de código reutilizable | Un capítulo de un libro |
| **Paquete (package)** | Una colección organizada de módulos relacionados | El libro completo, dividido en capítulos |
| **Biblioteca (library)** | Conjunto de código ya escrito, probado y empaquetado, listo para usarse dentro de otro programa | Una caja de herramientas ya armada |
| **Framework** | Una estructura más grande que "dicta" cómo debe organizarse toda la aplicación (el programador llena espacios dentro de reglas ya definidas) | Un molde de pastel: tú pones los ingredientes, pero la forma ya está definida |

**Biblioteca estándar vs. biblioteca de terceros:**

- **Estándar:** viene incluida al instalar el lenguaje; no requiere instalación adicional (ej. `math` en Python).
- **De terceros:** hay que instalarla explícitamente con un gestor de paquetes (ej. `requests` en Python, instalada con `pip`).

### 3.2.2 ¿Por qué usar bibliotecas en lugar de escribir todo desde cero?

1. **Ahorro de tiempo:** calcular una raíz cuadrada, ordenar una lista o leer un archivo ya está resuelto — no hay que reinventarlo.
2. **Confiabilidad:** el código de una biblioteca estándar ha sido probado por millones de programadores; es mucho menos probable que tenga errores que el código propio escrito de un día para otro.
3. **Rendimiento:** muchas bibliotecas están optimizadas a bajo nivel, más rápido de lo que lograría un principiante.
4. **Mantenibilidad:** el código propio queda más corto y legible si delega tareas comunes a bibliotecas conocidas por cualquier programador.

### 3.2.3 Comparación de bibliotecas estándar por lenguaje

| Propósito | Python | C# | Java |
|---|---|---|---|
| Operaciones matemáticas | `math` | `System.Math` | `java.lang.Math` |
| Manejo de fechas | `datetime` | `System.DateTime` | `java.time` |
| Estructuras de datos avanzadas | `collections` | `System.Collections.Generic` | `java.util` |
| Entrada/salida de archivos | `os`, `io` | `System.IO` | `java.io` / `java.nio` |
| Números aleatorios | `random` | `System.Random` | `java.util.Random` |
| Expresiones regulares | `re` | `System.Text.RegularExpressions` | `java.util.regex` |
| Gestor de paquetes | `pip` | `NuGet` | `Maven` / `Gradle` |

### 3.2.4 Ejemplo comparado 1: módulo matemático

**Python**
```python
import math

radio = 5
area = math.pi * math.pow(radio, 2)
print(f"El área del círculo es: {area:.2f}")
```

**C#**
```csharp
using System;

double radio = 5;
double area = Math.PI * Math.Pow(radio, 2);
Console.WriteLine($"El área del círculo es: {area:F2}");
```

**Java**
```java
public class AreaCirculo {
    public static void main(String[] args) {
        double radio = 5;
        double area = Math.PI * Math.pow(radio, 2);
        System.out.printf("El área del círculo es: %.2f%n", area);
    }
}
```

**Explicación línea por línea (para eliminar cualquier duda):**

| Línea (Python como referencia) | Qué hace | Equivalente en C# | Equivalente en Java |
|---|---|---|---|
| `import math` | Carga el módulo matemático estándar para poder usar sus funciones | `using System;` (Math ya está en el espacio de nombres base) | No requiere import; `Math` está en `java.lang`, que se importa automáticamente |
| `math.pi` | Constante π (3.14159...) provista por el módulo, sin que el programador la escriba a mano | `Math.PI` | `Math.PI` |
| `math.pow(radio, 2)` | Calcula `radio` elevado a la potencia 2, usando la función de la biblioteca | `Math.Pow(radio, 2)` | `Math.pow(radio, 2)` |
| `print(f"...")` | Muestra el resultado en pantalla, con formato de 2 decimales | `Console.WriteLine($"...")` con `:F2` | `System.out.printf` con `%.2f` |

**Punto pedagógico clave:** en los tres lenguajes, el estudiante **no calcula π ni la potencia manualmente**; delega esas operaciones a la biblioteca estándar del lenguaje. Esa es, en esencia, la idea central de este subtema.

### 3.2.5 Ejemplo comparado 2: módulo de fechas

**Python**
```python
from datetime import date

hoy = date.today()
print(f"Hoy es: {hoy}")
```

**C#**
```csharp
using System;

DateTime hoy = DateTime.Today;
Console.WriteLine($"Hoy es: {hoy:yyyy-MM-dd}");
```

**Java**
```java
import java.time.LocalDate;

public class FechaActual {
    public static void main(String[] args) {
        LocalDate hoy = LocalDate.now();
        System.out.println("Hoy es: " + hoy);
    }
}
```

Este segundo ejemplo refuerza que el patrón se repite: **importar → usar una función/clase ya construida → obtener un resultado confiable**, sin importar el lenguaje.

### 3.2.6 Instalación de bibliotecas de terceros (gestores de paquetes)

| Lenguaje | Gestor | Comando típico | Ejemplo | ¿Dónde queda registrado? |
|---|---|---|---|---|
| Python | `pip` | `pip install <paquete>` | `pip install requests` | `requirements.txt` |
| C# | `NuGet` | `dotnet add package <paquete>` | `dotnet add package Newtonsoft.Json` | archivo `.csproj` |
| Java | `Maven` | se declara en `pom.xml` | `<dependency>...</dependency>` | `pom.xml` |

**Paso a paso — instalar y usar una biblioteca de terceros en Python (ejemplo con `requests`):**

1. Abrir la terminal integrada del IDE.
2. Ejecutar: `pip install requests`
3. En el código:
   ```python
   import requests

   respuesta = requests.get("https://api.github.com")
   print(respuesta.status_code)
   ```
4. Registrar la dependencia para que otros puedan reproducir el entorno: `pip freeze > requirements.txt`

### 3.2.7 Errores comunes al usar bibliotecas (y cómo resolverlos)

| Error | Causa probable | Solución |
|---|---|---|
| `ModuleNotFoundError: No module named 'requests'` (Python) | La biblioteca no está instalada, o se instaló en un entorno virtual distinto al que usa el IDE | Verificar el intérprete seleccionado en VS Code y volver a ejecutar `pip install` en la terminal correcta |
| `cannot find symbol` (Java) | Falta el `import` de la clase que se está usando | Agregar el `import` correspondiente al paquete de esa clase |
| `The type or namespace name 'X' could not be found` (C#) | Falta el `using` correspondiente, o el paquete NuGet no se instaló | Agregar el `using` y confirmar con `dotnet list package` que la dependencia está instalada |

---

## 3.3 Creación y organización de proyectos de software

### 3.3.1 ¿Por qué importa la organización?

Un programa de una sola línea puede vivir perfectamente en un solo archivo suelto. Pero un proyecto real —como el que se pide en la Práctica 3 y en el Proyecto integrador de la asignatura— necesita una estructura clara por tres razones:

1. **Claridad:** cualquier persona del equipo (o el propio estudiante meses después) debe poder entender dónde está cada cosa sin tener que preguntar.
2. **Separación de responsabilidades:** el código fuente, las pruebas y la documentación no deben mezclarse en una sola carpeta caótica.
3. **Escalabilidad:** el proyecto debe poder crecer (agregar más funciones, más archivos) sin volverse imposible de mantener.

### 3.3.2 Estructura típica de un proyecto (genérica)

```
mi_proyecto/
├── src/            → código fuente (Source)
├── tests/          → pruebas unitarias
├── docs/           → documentación
├── README.md       → descripción del proyecto, cómo instalarlo y ejecutarlo
├── .gitignore       → lista de archivos que Git debe ignorar (ej. archivos temporales)
└── (archivo de dependencias: requirements.txt / .csproj / pom.xml)
```

**¿Qué va dentro de cada carpeta y por qué?**

| Carpeta/archivo | Contenido | ¿Por qué es importante? |
|---|---|---|
| `src/` | Todo el código que forma la aplicación en sí | Separa "lo que hace funcionar el programa" del resto |
| `tests/` | Código que **prueba automáticamente** que las funciones de `src/` funcionan correctamente | Permite detectar si un cambio nuevo rompió algo que antes funcionaba |
| `docs/` | Documentos explicando el diseño, decisiones técnicas, manual de usuario, etc. | Facilita que alguien nuevo entienda el proyecto sin leer todo el código |
| `README.md` | Primer archivo que lee cualquier persona: qué hace el proyecto, cómo instalarlo, cómo ejecutarlo | Es la "puerta de entrada" al proyecto |
| `.gitignore` | Lista de archivos/carpetas que Git no debe registrar (ej. archivos temporales del IDE) | Evita ensuciar el historial del proyecto con archivos que no importan |

### 3.3.3 Estructura concreta por lenguaje

**Proyecto en Python:**
```
mi_proyecto_python/
├── src/
│   └── main.py
├── tests/
│   └── test_main.py
├── requirements.txt
└── README.md
```

**Proyecto en C# (creado con `dotnet new`):**
```
MiProyectoCSharp/
├── Program.cs
├── MiProyectoCSharp.csproj   ← aquí se registran las dependencias (equivalente a requirements.txt)
└── README.md
```

**Proyecto en Java (con Maven):**
```
mi-proyecto-java/
├── src/
│   └── main/
│       └── java/
│           └── Main.java
├── pom.xml                   ← aquí se registran las dependencias
└── README.md
```

| Elemento | Python | C# | Java |
|---|---|---|---|
| Archivo de dependencias | `requirements.txt` | `.csproj` | `pom.xml` (Maven) |
| Punto de entrada del programa | `main.py` | `Program.cs` | `Main.java` (método `main`) |
| Framework de pruebas unitarias | `unittest` / `pytest` | `MSTest` / `NUnit` | `JUnit` |

### 3.3.4 El archivo README: qué debe contener como mínimo

```markdown
# Nombre del proyecto

Breve descripción de qué hace el proyecto (1-2 líneas).

## Requisitos
- Python 3.10 o superior
- (o el requisito correspondiente al lenguaje del proyecto)

## Instalación
pip install -r requirements.txt

## Ejecución
python src/main.py

## Autor
Nombre del estudiante / equipo
```

Este archivo es lo primero que cualquier evaluador o compañero de equipo debe poder leer para entender y ejecutar el proyecto sin ayuda adicional.

### 3.3.5 Buenas prácticas de organización (resumen aplicado)

1. **Separar responsabilidades**: código fuente, pruebas y documentación en carpetas distintas — nunca todo mezclado en la raíz del proyecto.
2. **Nombrar de forma consistente**: usar un solo estilo de nombres (por ejemplo `snake_case` en Python, `PascalCase` para clases en C#/Java) y mantenerlo en todo el proyecto.
3. **Documentar desde el inicio**: escribir el `README.md` desde el primer día, no dejarlo para el final.
4. **Control de versiones desde el primer commit**: iniciar el repositorio Git (`git init`) al crear el proyecto, no cuando ya está casi terminado.
5. **Pruebas unitarias**: escribir al menos una prueba por cada función importante, de forma que los cambios futuros no rompan silenciosamente lo que ya funcionaba.
6. **Un solo propósito por archivo/función**: evitar archivos de miles de líneas que hacen "de todo un poco"; es más fácil mantener varios archivos pequeños y bien nombrados.

---

## 4. Actividades de aprendizaje sugeridas (según programa oficial)

- Exploración y práctica con diferentes IDEs para programación.
- Implementación de funcionalidades mediante bibliotecas y módulos predefinidos.
- Dominio y aplicación de estructuras condicionales, bucles, selección y repetición en la programación (integradas dentro de un proyecto organizado).
- Desarrollo de habilidades para crear y organizar proyectos de software de manera eficiente.

---

## 5. Práctica 3 (según programa oficial): Gestión de proyectos de software con un IDE

**Objetivo:** Crear y organizar un proyecto de software utilizando un entorno de desarrollo integrado (IDE) como Visual Studio Code, PyCharm o Eclipse.

**Instrucciones:**
1. **Entornos de desarrollo integrados:** seleccionar un IDE y familiarizarse con sus características.
2. **Uso de bibliotecas y módulos:** crear un proyecto que haga uso de una biblioteca estándar (por ejemplo, `math` en Python).
3. **Creación y organización de proyectos:** estructurar el proyecto con directorios adecuados para código fuente, pruebas y documentación.

**Actividad del proyecto:**
- Desarrollar una aplicación simple que permita gestionar una lista de tareas (crear, editar, eliminar y marcar como completadas).
- Implementar pruebas unitarias para las funciones principales de la aplicación.

**Entrega:**
- Proyecto completo en el IDE seleccionado.
- Capturas de pantalla del entorno de desarrollo y la organización del proyecto.
- Código fuente y pruebas unitarias.

### 5.1 Guía paso a paso sugerida para resolver la Práctica 3 (en Python, como referencia)

1. Crear la carpeta del proyecto: `gestor_tareas/`
2. Dentro, crear la estructura:
   ```
   gestor_tareas/
   ├── src/
   │   └── tareas.py
   ├── tests/
   │   └── test_tareas.py
   ├── requirements.txt
   └── README.md
   ```
3. En `src/tareas.py`, definir las funciones básicas:
   ```python
   tareas = []

   def crear_tarea(descripcion):
       tareas.append({"descripcion": descripcion, "completada": False})

   def marcar_completada(indice):
       tareas[indice]["completada"] = True

   def eliminar_tarea(indice):
       tareas.pop(indice)

   def listar_tareas():
       for i, tarea in enumerate(tareas):
           estado = "✔" if tarea["completada"] else "✗"
           print(f"{i}. [{estado}] {tarea['descripcion']}")
   ```
4. En `tests/test_tareas.py`, escribir pruebas con `unittest`:
   ```python
   import unittest
   from src.tareas import tareas, crear_tarea, marcar_completada, eliminar_tarea

   class TestGestorTareas(unittest.TestCase):
       def setUp(self):
           tareas.clear()

       def test_crear_tarea(self):
           crear_tarea("Estudiar para el examen")
           self.assertEqual(len(tareas), 1)

       def test_marcar_completada(self):
           crear_tarea("Entregar práctica")
           marcar_completada(0)
           self.assertTrue(tareas[0]["completada"])

       def test_eliminar_tarea(self):
           crear_tarea("Tarea temporal")
           eliminar_tarea(0)
           self.assertEqual(len(tareas), 0)

   if __name__ == "__main__":
       unittest.main()
   ```
5. Ejecutar las pruebas desde la terminal: `python -m unittest discover tests`
6. Escribir el `README.md` con instrucciones de instalación y ejecución.
7. Tomar capturas de pantalla del IDE mostrando: la estructura de carpetas, el código y la ejecución exitosa de las pruebas.

### 5.2 Rúbrica sugerida para evaluar la Práctica 3

| Criterio | Ponderación sugerida | Qué se observa |
|---|---|---|
| Configuración correcta del IDE y evidencia de uso (capturas) | 15% | El IDE seleccionado está correctamente configurado y las capturas lo demuestran |
| Uso justificado de al menos una biblioteca estándar | 20% | Se importa y utiliza una biblioteca estándar de forma coherente con el problema |
| Estructura del proyecto (carpetas `src`/`tests`/`docs`, README) | 25% | El proyecto sigue la estructura de carpetas recomendada y el README es claro |
| Funcionalidad completa de la app de tareas (crear, editar, eliminar, marcar completadas) | 25% | Todas las operaciones solicitadas funcionan sin errores |
| Pruebas unitarias de las funciones principales | 15% | Existen pruebas que cubren los casos principales y se ejecutan correctamente |

---

## 6. Evaluación por competencias de la unidad

Conforme al apartado 10 del programa de la asignatura, se sugiere:

- Ejercicios y problemas en clase relacionados con configuración de IDE y uso de bibliotecas.
- Evaluación de la Práctica 3 con la rúbrica de la sección 5.2.
- Evaluación teórica breve sobre conceptos de IDE, biblioteca/módulo y estructura de proyectos (ver banco de preguntas en la sección 9).
- Observación del trabajo en equipo durante la organización del proyecto.

---

## 7. Glosario de términos de la unidad

| Término | Definición breve |
|---|---|
| **IDE** | Programa que integra editor, compilador/intérprete, depurador y otras herramientas de desarrollo |
| **Compilador** | Traduce todo el código fuente a código ejecutable antes de correrlo (ej. Java, C#) |
| **Intérprete** | Ejecuta el código línea por línea sin generar un archivo ejecutable previo (ej. Python) |
| **Breakpoint** | Punto donde se detiene la ejecución del programa durante la depuración |
| **Módulo** | Unidad pequeña de código reutilizable, normalmente un solo archivo |
| **Paquete** | Colección organizada de módulos relacionados |
| **Biblioteca** | Conjunto de código ya construido y probado, listo para reutilizarse |
| **Framework** | Estructura que define cómo debe organizarse una aplicación completa |
| **Gestor de paquetes** | Herramienta que instala y administra bibliotecas externas (`pip`, `NuGet`, `Maven`) |
| **Repositorio** | Carpeta de proyecto bajo control de versiones con Git |
| **Commit** | Registro de un conjunto de cambios guardado en el historial de Git |
| **README** | Archivo de texto que describe el proyecto y cómo usarlo |

---

## 8. Ejercicio integrador (junta 3.1 + 3.2 + 3.3 en un solo flujo)

**Objetivo:** que el estudiante viva, en un solo ejercicio corto, el flujo completo de la unidad.

1. **(3.1)** Abrir VS Code y crear una carpeta nueva llamada `conversor_temperatura/`.
2. **(3.3)** Dentro, crear la estructura `src/`, `tests/` y un archivo `README.md`.
3. **(3.2)** En `src/conversor.py`, escribir una función que use el módulo estándar `math` para redondear el resultado:
   ```python
   import math

   def celsius_a_fahrenheit(celsius):
       fahrenheit = (celsius * 9/5) + 32
       return math.floor(fahrenheit * 100) / 100
   ```
4. **(3.1)** Colocar un breakpoint dentro de la función y ejecutar en modo depuración para observar cómo cambia el valor de `fahrenheit` paso a paso.
5. **(3.3)** Escribir una prueba unitaria en `tests/test_conversor.py` y ejecutarla desde la terminal integrada.
6. **(3.1 + 3.3)** Inicializar Git (`git init`), agregar los archivos (`git add .`) y hacer el primer commit (`git commit -m "Primera versión del conversor"`).

Este ejercicio corto sirve como calentamiento antes de abordar la Práctica 3 completa.

---

## 9. Banco de preguntas de autoevaluación (para repaso del estudiante)

1. ¿Cuál es la diferencia principal entre un editor de texto simple y un IDE?
2. Menciona tres herramientas que un IDE integra en un solo programa.
3. ¿Qué significa colocar un *breakpoint* y para qué sirve durante la depuración?
4. ¿Cuál es la diferencia entre un módulo, un paquete y una biblioteca?
5. ¿Por qué es preferible usar una función de una biblioteca estándar en lugar de escribirla desde cero?
6. Menciona el gestor de paquetes correspondiente a Python, C# y Java.
7. ¿Qué archivo dentro de un proyecto en Python guarda la lista de dependencias necesarias?
8. ¿Por qué es importante separar el código fuente (`src/`) de las pruebas (`tests/`) en un proyecto?
9. ¿Qué información mínima debe contener un archivo `README.md`?
10. ¿Qué hace el comando `git init` y en qué momento del proyecto debería ejecutarse?

*(Se sugiere usar estas preguntas como examen corto de teoría o como discusión grupal antes de iniciar la Práctica 3.)*

---

## 10. Fuentes de información sugeridas (tomadas del programa oficial)

- Nolasco, J. S. (2021). *Fundamentos de programación con Python 3*. España: Marcombo.
- Trejos Buriticá, O. I., Muñoz Guerrero, L. E. (2021). *Introducción a la programación con Python*. España: Ra-Ma S.A.
- VEGAS, J. M. (2022). *JAVA 17: Fundamentos prácticos de programación*. Colombia: Ediciones de la U.
- Solares Riachi, D. M. S. (2021). *Fundamentos de Programación*. Estados Unidos: Palibrio.
