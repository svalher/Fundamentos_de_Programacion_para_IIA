# Guía de Instalación y Configuración de Entornos de Desarrollo
### Materia: Fundamentos de Programación (IAD-2413) — ITD / TecNM
### Herramienta común: Visual Studio Code

**Propósito de este documento:** reunir en un solo material las guías de instalación y configuración para los tres lenguajes que se pueden usar en las prácticas de la asignatura (**Python**, **Java** y **C#**), todos trabajados sobre el mismo editor, **Visual Studio Code**. La idea es que, sin importar qué lenguaje elija el grupo o el equipo de trabajo, el alumno siga el mismo formato de guía: instalación del SDK/intérprete correspondiente, configuración de VS Code, primer programa, depuración básica, errores comunes y checklist de verificación.

> Nota para el profesor: no es necesario que todo el grupo use el mismo lenguaje. Este documento está pensado para poder asignar guías distintas por equipo, o para que el alumno elija con cuál lenguaje sentirse más cómodo desde la Práctica 1 (Tema 1: Introducción a la programación y conceptos fundamentales).

## Contenido

1. [Guía Python + VS Code](#guía-1-python--visual-studio-code)
2. [Guía Java + VS Code](#guía-2-java--visual-studio-code)
3. [Guía C# + VS Code](#guía-3-c--visual-studio-code)
4. [Comparativa rápida entre los tres entornos](#comparativa-rápida-entre-los-tres-entornos)

---

## Guía 1: Python + Visual Studio Code

**Objetivo:** que cada alumno tenga, en menos de 30 minutos y sin depender del profesor, un entorno funcional para escribir, ejecutar y depurar programas en Python usando Visual Studio Code (VS Code).

> Nota didáctica para el profesor: la mayoría de los problemas que reportan los alumnos NO son de programación, son de instalación (Python no quedó en el PATH, abrieron la terminal equivocada, o VS Code no detectó el intérprete). Por eso esta guía insiste tanto en la verificación paso a paso: si algo falla, se detecta de inmediato y no se arrastra el problema a la primera práctica.

---

### 0. Requisitos previos

- Laptop con Windows 10/11, macOS o Linux (esta guía cubre los tres, con énfasis en Windows por ser el más común en el grupo).
- Conexión a internet (solo para la descarga e instalación).
- Permisos de administrador en el equipo.

---

### Parte 1: Instalar Python

#### Windows

1. Ir a **https://www.python.org/downloads/** y descargar la versión estable más reciente (evitar versiones "rc" o "beta").
2. Ejecutar el instalador descargado.
3. **Paso crítico (aquí es donde la mayoría falla):** en la primera pantalla del instalador, marcar la casilla inferior:
   - ☑ **"Add python.exe to PATH"**
   - Si no se marca esta casilla, Python se instala pero la terminal no lo va a reconocer, y los alumnos verán el error `'python' no se reconoce como un comando interno o externo`.
4. Dar clic en **"Install Now"**.
5. Al terminar, dar clic en **"Disable path length limit"** si aparece (evita errores con rutas largas más adelante).

#### macOS

1. Ir a **https://www.python.org/downloads/** y descargar el instalador `.pkg` para macOS.
2. Ejecutar el instalador y seguir los pasos por defecto.
3. macOS ya trae Python 2 preinstalado por compatibilidad del sistema; por eso siempre se usará el comando `python3`, nunca `python`.

#### Linux (Ubuntu/Debian)

En la mayoría de las distribuciones Python 3 ya viene instalado. Verificar y, si falta, instalar `pip` y el entorno virtual:

```bash
sudo apt update
sudo apt install python3 python3-pip python3-venv
```

---

### Parte 2: Verificar que Python quedó bien instalado

**Este paso no es opcional.** Antes de tocar VS Code, hay que confirmar en la terminal que el sistema reconoce a Python.

- **Windows:** abrir el menú Inicio, escribir `cmd` o `PowerShell` y abrirlo.
- **macOS/Linux:** abrir la aplicación "Terminal".

Escribir:

```bash
python --version
```

En macOS/Linux puede ser necesario usar:

```bash
python3 --version
```

Debe mostrar algo como `Python 3.13.x`. Si sale un error, el problema casi siempre es que no se marcó "Add to PATH" (Windows) → hay que desinstalar y volver a instalar marcando esa casilla, o agregar Python al PATH manualmente.

Verificar también que `pip` (el gestor de paquetes) esté disponible:

```bash
pip --version
```

---

### Parte 3: Instalar Visual Studio Code

1. Ir a **https://code.visualstudio.com/** y descargar la versión para el sistema operativo correspondiente.
2. Instalar con las opciones por defecto. En Windows, es recomendable dejar marcadas las casillas:
   - ☑ "Add to PATH"
   - ☑ "Register Code as an editor for supported file types"
   - ☑ "Add 'Open with Code' action to Windows Explorer context menu"

Esta última opción es muy útil en clase: permite dar clic derecho sobre cualquier carpeta y abrirla directamente en VS Code.

---

### Parte 4: Configurar VS Code para trabajar con Python

#### 4.1 Instalar la extensión de Python

1. Abrir VS Code.
2. Ir al ícono de **Extensiones** en la barra lateral izquierda (o `Ctrl+Shift+X`).
3. Buscar **"Python"** (la extensión oficial, publicada por **Microsoft**, con el ícono azul/amarillo).
4. Dar clic en **Instalar**.

Esta extensión incluye automáticamente:
- Resaltado de sintaxis y autocompletado (Pylance).
- Detección de intérpretes de Python instalados.
- Soporte para depuración (debugging) y ejecución de código.

#### 4.2 Verificar/seleccionar el intérprete de Python

Este es el segundo punto donde más se atoran los alumnos: VS Code puede tener instalada la extensión pero apuntando a ningún intérprete o al equivocado.

1. Abrir la paleta de comandos: `Ctrl+Shift+P` (Windows/Linux) o `Cmd+Shift+P` (macOS).
2. Escribir **"Python: Select Interpreter"** y presionar Enter.
3. Elegir la versión de Python que se instaló en la Parte 1 (debe aparecer en la lista automáticamente).
4. Confirmar que en la barra inferior izquierda de VS Code ahora se muestra el número de versión de Python.

---

### Parte 5: Crear la carpeta de trabajo y el primer programa

1. Crear en el escritorio (o en Documentos) una carpeta, por ejemplo: `FundamentosProgramacion`.
2. En VS Code: **Archivo → Abrir carpeta...** y seleccionar esa carpeta.
3. En el explorador de VS Code (panel izquierdo), dar clic derecho → **Nuevo archivo** → nombrarlo `hola_mundo.py`.

   > Importante: la extensión **`.py`** es obligatoria; sin ella, VS Code no activa el modo Python.

4. Escribir el siguiente código:

```python
print("Hola, mundo")
nombre = input("¿Cómo te llamas? ")
print(f"Bienvenido a Fundamentos de Programación, {nombre}")
```

5. Guardar el archivo (`Ctrl+S`).

#### Ejecutar el programa

Hay dos formas, conviene que los alumnos conozcan ambas:

- **Botón rápido:** clic en el triángulo ▶ (Run Python File) en la esquina superior derecha del editor.
- **Terminal integrada:** abrir con `Ctrl+ñ` o desde el menú **Terminal → Nueva terminal**, y escribir:

```bash
python hola_mundo.py
```

Si todo está bien configurado, aparecerá el resultado en el panel de terminal dentro de VS Code, y el programa esperará a que se escriba el nombre.

---

### Parte 6: Depuración básica (opcional pero muy recomendable desde la primera práctica)

1. Dar clic a la izquierda del número de línea para poner un **breakpoint** (punto rojo).
2. Presionar `F5` o ir a **Ejecutar → Iniciar depuración**.
3. Elegir la opción **"Python File"** cuando se pregunte el tipo de configuración.
4. El programa se detendrá en el breakpoint y se podrán revisar las variables en el panel izquierdo.

Enseñar esto desde el inicio evita que, más adelante, los alumnos solo usen `print()` para "adivinar" dónde está el error.

---

### Tabla de errores comunes y solución rápida

| Síntoma | Causa probable | Solución |
|---|---|---|
| `'python' no se reconoce como un comando` | No se marcó "Add to PATH" al instalar | Reinstalar Python marcando la casilla, o agregar la ruta manualmente al PATH del sistema |
| VS Code no sugiere código ni resalta errores | Falta la extensión de Python o no está seleccionado el intérprete | Instalar extensión "Python" de Microsoft y usar "Python: Select Interpreter" |
| Al ejecutar, dice `No module named 'pip'` | Instalación incompleta de Python | Reinstalar Python desde cero |
| El botón ▶ no aparece | El archivo no tiene extensión `.py` | Renombrar el archivo con `.py` al final |
| Los acentos o "ñ" se ven raros al ejecutar | Codificación de la terminal (más común en Windows con CMD antiguo) | Usar la terminal integrada de VS Code, que ya maneja UTF-8 correctamente |
| `python3` funciona pero `python` no (Mac/Linux) | Es el comportamiento normal del sistema | Usar siempre `python3` en esos sistemas |

---

### Checklist de verificación antes de la primera práctica

Pedir a cada alumno que confirme lo siguiente antes de iniciar la Unidad 2 (o la primera práctica de programación):

- [ ] `python --version` (o `python3 --version`) muestra un número de versión sin errores.
- [ ] VS Code tiene instalada la extensión oficial "Python" (Microsoft).
- [ ] Al abrir un archivo `.py`, la barra inferior de VS Code muestra el intérprete seleccionado.
- [ ] El programa `hola_mundo.py` corrió correctamente y pidió/mostró el nombre.
- [ ] Se probó al menos un breakpoint con `F5`.

---

### Recomendación para la sesión de clase

Sugerencia de dinámica para la primera sesión de laboratorio: realizar la instalación en vivo, proyectando la pantalla, deteniéndose exactamente en el paso de "Add to PATH" y en "Select Interpreter", que son los dos puntos donde ocurre el 80% de los problemas reportados por los alumnos. Después, dejar 5 minutos para que cada quien corra su `hola_mundo.py` y levante la mano si algo falla, antes de avanzar a contenido nuevo.

---

## Guía 2: Java + Visual Studio Code

**Objetivo:** que cada alumno tenga, en menos de 30 minutos y sin depender del profesor, un entorno funcional para escribir, compilar, ejecutar y depurar programas en Java usando Visual Studio Code (VS Code).

> Nota didáctica para el profesor: en Java, a diferencia de Python, el 90% de los problemas de instalación vienen de dos cosas: (1) instalar un JDK equivocado o incompleto, y (2) que el sistema no sabe dónde quedó instalado ese JDK (variable `JAVA_HOME`). Esta guía está diseñada para que ambos puntos queden resueltos antes de escribir una sola línea de código.

---

### 0. ¿Qué SDK de Java usar? (decisión importante antes de instalar)

Para programar en Java se necesita el **JDK (Java Development Kit)**, no solo el JRE (que únicamente ejecuta programas, no los compila). Existen varias distribuciones del JDK; las tres más comunes son:

| Distribución | Costo / licencia | Comentario |
|---|---|---|
| **Oracle JDK** | Gratis para uso general desde JDK 17, pero con términos de licencia (NFTC) que hay que leer con cuidado, y en versiones anteriores requería suscripción para uso en producción | Es la "original", pero su licencia ha generado confusión incluso en entornos profesionales |
| **Eclipse Temurin** (de la Eclipse Adoptium Foundation) | 100% gratuito, código abierto, sin letras chiquitas | Es el sucesor directo del antiguo AdoptOpenJDK, muy usado en la industria |
| **Microsoft Build of OpenJDK** | 100% gratuito, código abierto, mantenido por Microsoft | Se integra de forma nativa y automática con la extensión de Java de VS Code |

#### Recomendación para este curso: **Microsoft Build of OpenJDK**

Razones concretas:

1. **Cero fricción con VS Code:** la extensión oficial de Java para VS Code (que instalaremos en la Parte 2) puede descargar e instalar este JDK automáticamente, sin que el alumno tenga que ir a buscar un instalador aparte.
2. **Sin ambigüedad de licencia:** es completamente gratuito para cualquier uso, sin necesidad de leer términos legales antes de usarlo en el laboratorio.
3. **Es un JDK estándar:** al ser una distribución de OpenJDK, el código que se escriba es 100% compatible con cualquier otra distribución (Oracle, Temurin, etc.), así que no hay riesgo de "atarse" a algo no estándar.

Si en tu instituto ya tienen Eclipse Temurin instalado en los laboratorios, es igualmente válido y esta guía funciona igual; el único cambio sería el sitio de descarga en la Parte 1.

---

### Parte 1: Instalar el JDK

#### Opción A (recomendada): dejar que VS Code lo instale automáticamente

Se puede omitir esta parte por completo e instalar el JDK desde dentro de VS Code en la Parte 2, sección 2.3. Es la forma más simple para un grupo grande, porque VS Code descarga la versión correcta automáticamente.

#### Opción B: instalar el JDK manualmente antes de abrir VS Code

Recomendable si el laboratorio no tiene buena conexión a internet al momento de trabajar en VS Code, o si se quiere tener todo listo de antemano.

1. Ir a **https://learn.microsoft.com/java/openjdk/download**
2. Descargar la versión **LTS más reciente** (por ejemplo, JDK 21), eligiendo el instalador para el sistema operativo correspondiente (`.msi` para Windows, `.pkg` para macOS, `.tar.gz` para Linux).
3. Ejecutar el instalador con las opciones por defecto.
   - **Windows:** el instalador `.msi` de Microsoft Build of OpenJDK configura automáticamente la variable `JAVA_HOME` y agrega Java al PATH. Este es uno de sus grandes beneficios frente a otras distribuciones.
4. Reiniciar el equipo (o al menos cerrar y volver a abrir cualquier terminal) para que los cambios de variables de entorno surtan efecto.

---

### Parte 2: Verificar el JDK y preparar VS Code

#### 2.1 Verificar que el JDK quedó instalado (solo si se hizo la Opción B)

Abrir una terminal (`cmd`/PowerShell en Windows, Terminal en macOS/Linux) y escribir:

```bash
java -version
javac -version
```

- `java -version` confirma que se puede **ejecutar** código Java.
- `javac -version` confirma que se puede **compilar** código Java (`javac` es el compilador; si falta, normalmente significa que se instaló un JRE en vez de un JDK completo).

Ambos comandos deben mostrar el mismo número de versión, sin errores.

#### 2.2 Instalar Visual Studio Code

1. Ir a **https://code.visualstudio.com/** y descargar la versión para el sistema operativo correspondiente.
2. Instalar con las opciones por defecto. En Windows, dejar marcadas:
   - ☑ "Add to PATH"
   - ☑ "Add 'Open with Code' action to Windows Explorer context menu"

#### 2.3 Instalar el paquete de extensiones de Java

1. Abrir VS Code.
2. Ir al ícono de **Extensiones** (`Ctrl+Shift+X`).
3. Buscar **"Extension Pack for Java"** — publicado por **Microsoft**. Este es el paso más importante de toda la guía: es un solo paquete que instala automáticamente TODO lo necesario:
   - Language Support for Java (compilación, autocompletado, errores en tiempo real)
   - Debugger for Java (depuración)
   - Test Runner for Java (pruebas unitarias, útil para prácticas posteriores)
   - Maven for Java (gestión de proyectos)
   - Project Manager for Java
4. Dar clic en **Instalar**. VS Code instalará los cinco componentes de forma automática.

#### 2.4 Si no se instaló el JDK antes (Opción A)

Al abrir el primer archivo `.java`, VS Code detectará que no hay un JDK configurado y mostrará una notificación con un botón como **"Install a JDK"** o **"Download JDK"**. Al darle clic:

1. Elegir la opción que ofrece **Microsoft Build of OpenJDK**.
2. VS Code lo descarga e instala en una carpeta interna, sin que el alumno tenga que configurar nada manualmente.

Esta es la ruta más recomendable para un salón completo, porque elimina el paso de "cada quien instala el JDK por su cuenta con posibles variantes".

---

### Parte 3: Crear la carpeta de trabajo y el primer programa

1. Crear una carpeta de trabajo, por ejemplo `FundamentosProgramacion`.
2. En VS Code: **Archivo → Abrir carpeta...** y seleccionar esa carpeta.
3. Es muy recomendable dejar que VS Code cree la estructura de proyecto por nosotros:
   - Abrir la paleta de comandos (`Ctrl+Shift+P`) y escribir **"Java: Create Java Project"**.
   - Elegir **"No build tools"** para un proyecto simple (ideal para las primeras prácticas; más adelante se puede usar Maven o Gradle).
   - Seleccionar la carpeta de trabajo.

   Esto genera automáticamente una carpeta `src/` (donde va el código) y una `bin/` (donde van los archivos compilados) — la misma estructura que se usa en proyectos reales.

4. Dentro de `src/`, VS Code ya crea un archivo `Main.java` de ejemplo. Editarlo así:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hola, mundo");

        Scanner scanner = new Scanner(System.in);
        System.out.print("¿Cómo te llamas? ");
        String nombre = scanner.nextLine();

        System.out.println("Bienvenido a Fundamentos de Programación, " + nombre);
        scanner.close();
    }
}
```

   > Regla clave de Java que hay que remarcar a los alumnos: **el nombre del archivo debe coincidir exactamente con el nombre de la clase pública** (`Main.java` → `public class Main`). Si no coinciden, no compila, y este es uno de los errores más comunes en las primeras semanas.

5. Guardar el archivo (`Ctrl+S`).

#### Ejecutar el programa

- **Botón rápido:** clic en **"Run"**, que aparece automáticamente arriba del método `main`.
- **Terminal integrada**, desde la carpeta del proyecto:

```bash
javac src/Main.java -d bin
java -cp bin Main
```

Para el día a día en clase, conviene usar siempre el botón "Run" de VS Code, ya que compila y ejecuta en un solo paso; los comandos manuales son útiles para que los alumnos entiendan qué está pasando "por debajo".

---

### Parte 4: Depuración básica

1. Dar clic a la izquierda del número de línea para poner un **breakpoint** (punto rojo).
2. Presionar `F5`, o dar clic en **"Debug"** (aparece junto al botón "Run" arriba del método `main`).
3. El programa se detendrá en el breakpoint; en el panel izquierdo se pueden inspeccionar las variables (`nombre`, `scanner`, etc.) en tiempo real.

---

### Tabla de errores comunes y solución rápida

| Síntoma | Causa probable | Solución |
|---|---|---|
| `'java' no se reconoce como un comando` | El JDK no quedó en el PATH / no se reinició la terminal | Cerrar y reabrir la terminal; si persiste, reinstalar el JDK verificando que configure `JAVA_HOME` |
| `javac` no funciona pero `java` sí | Se instaló solo un JRE, no un JDK completo | Reinstalar usando el instalador del JDK completo de Microsoft Build of OpenJDK |
| `class Main is public, should be declared in a file named Main.java` | El nombre del archivo no coincide con el de la clase pública | Renombrar el archivo para que coincida exactamente (incluyendo mayúsculas) |
| VS Code no muestra el botón "Run" sobre `main` | Falta el "Extension Pack for Java" o el proyecto no se creó como proyecto de Java | Instalar el Extension Pack y volver a crear el proyecto con "Java: Create Java Project" |
| Error `JAVA_HOME is not defined` al usar herramientas externas (Maven, etc.) | La variable de entorno no quedó configurada | En Windows: Configuración → Variables de entorno → crear `JAVA_HOME` apuntando a la carpeta de instalación del JDK |
| El programa no pide el `nombre` y se cierra de inmediato | Se está ejecutando desde un botón que no soporta entrada por teclado (poco común) | Ejecutar desde la terminal integrada de VS Code, que sí soporta `Scanner`/`input` |

---

### Checklist de verificación antes de la primera práctica

- [ ] `java -version` y `javac -version` responden con el mismo número de versión, sin errores.
- [ ] VS Code tiene instalado el **"Extension Pack for Java"** (Microsoft).
- [ ] Se creó un proyecto con "Java: Create Java Project" y aparece la estructura `src/` / `bin/`.
- [ ] El archivo `Main.java` corrió correctamente con el botón "Run" y respondió a la entrada de teclado.
- [ ] Se probó al menos un breakpoint con `F5`.

---

### Recomendación para la sesión de clase

Para Java conviene invertir un poco más de tiempo en la instalación que con Python, precisamente por el tema del JDK y las variables de entorno. Sugerencia de dinámica: instalar en vivo usando la **Opción A** (dejar que VS Code descargue el JDK de Microsoft automáticamente al abrir el primer archivo `.java`), ya que reduce a la mitad los pasos manuales y evita que cada alumno traiga una versión distinta de JDK instalada desde antes. Cerrar la sesión con el checklist anterior antes de avanzar al Tema 1.5 (sintaxis para definición de funciones y métodos).

---

## Guía 3: C# + Visual Studio Code

**Objetivo:** que cada alumno tenga, en menos de 30 minutos y sin depender del profesor, un entorno funcional para escribir, compilar, ejecutar y depurar programas en C# usando Visual Studio Code (VS Code).

> Nota didáctica para el profesor: en C# el punto donde más se atoran los alumnos no es el lenguaje en sí, sino confundir **Visual Studio** (el IDE completo de Microsoft, pesado, solo Windows) con **Visual Studio Code** (el editor ligero multiplataforma que usamos en este curso). Ambos sirven para programar en C#, pero esta guía es específicamente para VS Code + .NET SDK, que es más ligero y funciona igual en Windows, macOS y Linux.

---

### 0. ¿Qué SDK usar?

A diferencia de Java (donde hay que elegir entre distintas distribuciones del JDK), en C# la decisión es más simple: se necesita el **.NET SDK**, que es único y lo distribuye Microsoft de forma gratuita y de código abierto. No existen distribuciones alternativas que compitan entre sí como en el caso de Java.

#### Recomendación para este curso: **.NET SDK (versión LTS más reciente)**

Razones concretas:

1. **Es la única opción oficial y gratuita:** no hay que comparar licencias ni distribuciones distintas.
2. **Incluye todo lo necesario:** el compilador de C#, el runtime para ejecutar programas, y el comando `dotnet` que se usa para crear, compilar, ejecutar y probar proyectos.
3. **Elegir "LTS" (Long Term Support):** al momento de descargar, el sitio de Microsoft ofrece varias versiones; siempre conviene elegir la marcada como **LTS**, ya que es la más estable y la que va a tener soporte por más tiempo durante el semestre.

---

### Parte 1: Instalar el .NET SDK

1. Ir a **https://dotnet.microsoft.com/download** y descargar el **.NET SDK** (no el "Runtime", que solo ejecuta programas pero no los compila) en su versión **LTS**.
2. Elegir el instalador correspondiente al sistema operativo:
   - Windows: `.exe`
   - macOS: `.pkg`
   - Linux: seguir las instrucciones específicas de la distribución (por ejemplo, `apt`, `dnf`, o el script oficial de Microsoft)
3. Ejecutar el instalador con las opciones por defecto. El instalador de Windows y macOS configura automáticamente las variables de entorno necesarias; no se requiere ningún ajuste manual como sí ocurre con Java.
4. Reiniciar cualquier terminal abierta para que los cambios surtan efecto.

---

### Parte 2: Verificar la instalación

Abrir una terminal (`cmd`/PowerShell en Windows, Terminal en macOS/Linux) y escribir:

```bash
dotnet --version
```

Debe mostrar un número de versión (por ejemplo `8.0.xxx`) sin errores. Este único comando confirma que tanto el compilador como el runtime quedaron bien instalados; a diferencia de Java, aquí no hace falta verificar dos comandos por separado.

Para ver más detalle del entorno instalado (útil si algo falla más adelante):

```bash
dotnet --info
```

---

### Parte 3: Instalar Visual Studio Code

1. Ir a **https://code.visualstudio.com/** y descargar la versión para el sistema operativo correspondiente.
2. Instalar con las opciones por defecto. En Windows, dejar marcadas:
   - ☑ "Add to PATH"
   - ☑ "Add 'Open with Code' action to Windows Explorer context menu"

---

### Parte 4: Configurar VS Code para trabajar con C#

#### 4.1 Instalar la extensión de C#

1. Abrir VS Code.
2. Ir al ícono de **Extensiones** (`Ctrl+Shift+X`).
3. Buscar **"C# Dev Kit"** — publicado por **Microsoft**. Al instalarlo, VS Code instalará automáticamente también:
   - **C#** (soporte base del lenguaje, IntelliSense, resaltado de sintaxis)
   - **.NET Install Tool** (puede detectar o instalar el SDK si hiciera falta)
4. Dar clic en **Instalar** y esperar a que termine (puede tardar un par de minutos la primera vez).

> Importante: existe una extensión más antigua llamada solo **"C#"** (sin "Dev Kit"). El "C# Dev Kit" es la opción moderna recomendada por Microsoft, porque agrega el explorador de soluciones/proyectos y una experiencia de ejecución/depuración más parecida a Visual Studio completo, pero dentro de VS Code.

#### 4.2 Iniciar sesión (opcional pero recomendable)

El "C# Dev Kit" puede pedir iniciar sesión con una cuenta gratuita de Microsoft para desbloquear todas sus funciones (es gratuito para estudiantes e individuos). Si el laboratorio no permite iniciar sesión con cuentas personales, la extensión sigue funcionando para lo esencial del curso (compilar, ejecutar, depurar) sin necesidad de iniciar sesión.

---

### Parte 5: Crear el proyecto y el primer programa

A diferencia de Python, en C# **no se trabaja con un solo archivo suelto**: siempre se crea un "proyecto", que es una carpeta con un archivo de configuración (`.csproj`). Esto es normal y así se trabaja también en la industria.

1. Crear una carpeta de trabajo, por ejemplo `FundamentosProgramacion`.
2. Abrir una terminal dentro de esa carpeta (en VS Code: **Terminal → Nueva terminal**, después de abrir la carpeta con **Archivo → Abrir carpeta...**).
3. Crear el proyecto con el comando:

```bash
dotnet new console -n MiPrimerPrograma
```

   Esto genera una subcarpeta `MiPrimerPrograma/` con:
   - `Program.cs` (el archivo con el código)
   - `MiPrimerPrograma.csproj` (el archivo de configuración del proyecto)

4. Abrir esa subcarpeta en VS Code (**Archivo → Abrir carpeta...** → `MiPrimerPrograma`), o simplemente navegar a `Program.cs` desde el explorador de archivos.
5. Reemplazar el contenido de `Program.cs` con:

```csharp
Console.WriteLine("Hola, mundo");

Console.Write("¿Cómo te llamas? ");
string? nombre = Console.ReadLine();

Console.WriteLine($"Bienvenido a Fundamentos de Programación, {nombre}");
```

   > Nota para explicar en clase: las versiones recientes de C# (a partir de C# 9/10) permiten escribir instrucciones directamente en `Program.cs` sin necesidad de declarar una clase `Main` explícita (se le llama "top-level statements"). Esto hace que el primer programa se vea muy parecido al de Python, lo cual ayuda a que no se sientan abrumados desde el primer día.

6. Guardar el archivo (`Ctrl+S`).

#### Ejecutar el programa

Desde la terminal, dentro de la carpeta del proyecto (`MiPrimerPrograma/`):

```bash
dotnet run
```

Este comando compila y ejecuta en un solo paso. Si todo está bien configurado, se verá el saludo y el programa esperará a que se escriba el nombre.

También se puede ejecutar con el botón ▶ **"Run"** que aparece en VS Code gracias al C# Dev Kit, una vez que el proyecto está abierto correctamente.

---

### Parte 6: Depuración básica

1. Dar clic a la izquierda del número de línea para poner un **breakpoint** (punto rojo).
2. Presionar `F5` o usar el panel de **"Run and Debug"** (ícono de play con un bicho, en la barra lateral izquierda).
3. Si es la primera vez, VS Code puede preguntar qué tipo de proyecto es: elegir **"C#"** / **".NET"**.
4. El programa se detendrá en el breakpoint y se podrán inspeccionar las variables (`nombre`, etc.) en el panel izquierdo.

---

### Tabla de errores comunes y solución rápida

| Síntoma | Causa probable | Solución |
|---|---|---|
| `'dotnet' no se reconoce como un comando` | El SDK no quedó en el PATH / no se reinició la terminal | Cerrar y reabrir la terminal; si persiste, reinstalar el .NET SDK (no solo el Runtime) |
| VS Code no muestra el botón "Run" ni IntelliSense | Falta el "C# Dev Kit" o se abrió un archivo suelto en vez de la carpeta del proyecto | Instalar "C# Dev Kit" y abrir la carpeta que contiene el archivo `.csproj` |
| `dotnet run` dice que no encuentra ningún proyecto | Se ejecutó el comando fuera de la carpeta que contiene el `.csproj` | Verificar con `dir`/`ls` que se está dentro de la carpeta correcta antes de correr `dotnet run` |
| Error de compilación por `nombre` nulo (`CS8600`, advertencia de nulabilidad) | Es un aviso normal de C# moderno sobre valores que podrían ser `null` | Se puede explicar como una introducción temprana al manejo de nulos; no impide ejecutar el programa |
| El programa no pide el `nombre` y se cierra de inmediato | Se ejecutó desde un botón/depurador que no soporta entrada por teclado | Ejecutar desde la terminal integrada con `dotnet run` |
| VS Code pide iniciar sesión y el alumno no quiere/puede | Es opcional para el "C# Dev Kit" | Se puede omitir ("Skip"/"Not now") y seguir trabajando con las funciones básicas |

---

### Checklist de verificación antes de la primera práctica

- [ ] `dotnet --version` responde con un número de versión sin errores.
- [ ] VS Code tiene instalado el **"C# Dev Kit"** (Microsoft).
- [ ] Se creó un proyecto con `dotnet new console -n NombreProyecto` y aparecen `Program.cs` y el archivo `.csproj`.
- [ ] El programa corrió correctamente con `dotnet run` (o el botón "Run") y respondió a la entrada de teclado.
- [ ] Se probó al menos un breakpoint con `F5`.

---

### Recomendación para la sesión de clase

Conviene remarcar desde el inicio que **no se debe confundir Visual Studio con Visual Studio Code**: son dos programas distintos de Microsoft, y las instrucciones de esta guía son específicamente para VS Code. Sugerencia de dinámica: instalar el .NET SDK en vivo, mostrar el único comando de verificación (`dotnet --version`, mucho más simple que en Java), y dedicar tiempo extra a explicar por qué C# trabaja con "proyectos" (carpeta + `.csproj`) en vez de archivos sueltos como Python, ya que este es el cambio de mentalidad más importante frente a lo que ya vieron en la práctica de Python. Cerrar con el checklist antes de avanzar a la siguiente práctica.

---

## Comparativa rápida entre los tres entornos

| Aspecto | Python | Java | C# |
|---|---|---|---|
| Qué se instala primero | Intérprete de Python (python.org) | JDK — se recomienda Microsoft Build of OpenJDK | .NET SDK (Microsoft, versión LTS) |
| Extensión clave en VS Code | "Python" (Microsoft) | "Extension Pack for Java" (Microsoft) | "C# Dev Kit" (Microsoft) |
| Comando de verificación | `python --version` | `java -version` y `javac -version` | `dotnet --version` |
| ¿Requiere estructura de proyecto? | No, se puede trabajar con un solo archivo `.py` | Sí, se recomienda crear proyecto con "Java: Create Java Project" | Sí, se crea con `dotnet new console` |
| Cómo se ejecuta | Botón "Run" o `python archivo.py` | Botón "Run" o `javac` + `java` | Botón "Run" o `dotnet run` |
| Punto donde más se atoran los alumnos | Falta marcar "Add to PATH" al instalar | Confundir JDK con JRE, o `JAVA_HOME` no configurado | Confundir Visual Studio con Visual Studio Code |
| Curva de entrada para la Práctica 1 | La más baja | Intermedia (tipado y sintaxis de clases) | Intermedia (similar a Java, pero instalación más simple) |

### Recomendación general de secuencia para el curso

Para el Tema 1 (conceptos básicos, variables, tipos de datos, operadores), Python es el punto de entrada más amigable por su sintaxis simple. Java y C# son útiles para reforzar, más adelante en el temario, conceptos como tipado estricto y programación orientada a objetos, que se retoman formalmente en la materia de Programación Orientada a Objetos. La actividad de aprendizaje sugerida en el temario oficial ("Ejercicios de codificación en Python, C++, Java y R") permite usar esta comparativa para justificar por qué se eligió Python, Java o C# como lenguaje principal de práctica en el grupo.
