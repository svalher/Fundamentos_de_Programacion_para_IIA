# Guía de Instalación y Configuración: C# + Visual Studio Code
### Materia: Fundamentos de Programación (IAD-2413) — ITD / TecNM

**Objetivo:** que cada alumno tenga, en menos de 30 minutos y sin depender del profesor, un entorno funcional para escribir, compilar, ejecutar y depurar programas en C# usando Visual Studio Code (VS Code).

> Nota didáctica para el profesor: en C# el punto donde más se atoran los alumnos no es el lenguaje en sí, sino confundir **Visual Studio** (el IDE completo de Microsoft, pesado, solo Windows) con **Visual Studio Code** (el editor ligero multiplataforma que usamos en este curso). Ambos sirven para programar en C#, pero esta guía es específicamente para VS Code + .NET SDK, que es más ligero y funciona igual en Windows, macOS y Linux.

---

## 0. ¿Qué SDK usar?

A diferencia de Java (donde hay que elegir entre distintas distribuciones del JDK), en C# la decisión es más simple: se necesita el **.NET SDK**, que es único y lo distribuye Microsoft de forma gratuita y de código abierto. No existen distribuciones alternativas que compitan entre sí como en el caso de Java.

### Recomendación para este curso: **.NET SDK (versión LTS más reciente)**

Razones concretas:

1. **Es la única opción oficial y gratuita:** no hay que comparar licencias ni distribuciones distintas.
2. **Incluye todo lo necesario:** el compilador de C#, el runtime para ejecutar programas, y el comando `dotnet` que se usa para crear, compilar, ejecutar y probar proyectos.
3. **Elegir "LTS" (Long Term Support):** al momento de descargar, el sitio de Microsoft ofrece varias versiones; siempre conviene elegir la marcada como **LTS**, ya que es la más estable y la que va a tener soporte por más tiempo durante el semestre.

---

## Parte 1: Instalar el .NET SDK

1. Ir a **https://dotnet.microsoft.com/download** y descargar el **.NET SDK** (no el "Runtime", que solo ejecuta programas pero no los compila) en su versión **LTS**.
2. Elegir el instalador correspondiente al sistema operativo:
   - Windows: `.exe`
   - macOS: `.pkg`
   - Linux: seguir las instrucciones específicas de la distribución (por ejemplo, `apt`, `dnf`, o el script oficial de Microsoft)
3. Ejecutar el instalador con las opciones por defecto. El instalador de Windows y macOS configura automáticamente las variables de entorno necesarias; no se requiere ningún ajuste manual como sí ocurre con Java.
4. Reiniciar cualquier terminal abierta para que los cambios surtan efecto.

---

## Parte 2: Verificar la instalación

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

## Parte 3: Instalar Visual Studio Code

1. Ir a **https://code.visualstudio.com/** y descargar la versión para el sistema operativo correspondiente.
2. Instalar con las opciones por defecto. En Windows, dejar marcadas:
   - ☑ "Add to PATH"
   - ☑ "Add 'Open with Code' action to Windows Explorer context menu"

---

## Parte 4: Configurar VS Code para trabajar con C#

### 4.1 Instalar la extensión de C#

1. Abrir VS Code.
2. Ir al ícono de **Extensiones** (`Ctrl+Shift+X`).
3. Buscar **"C# Dev Kit"** — publicado por **Microsoft**. Al instalarlo, VS Code instalará automáticamente también:
   - **C#** (soporte base del lenguaje, IntelliSense, resaltado de sintaxis)
   - **.NET Install Tool** (puede detectar o instalar el SDK si hiciera falta)
4. Dar clic en **Instalar** y esperar a que termine (puede tardar un par de minutos la primera vez).

> Importante: existe una extensión más antigua llamada solo **"C#"** (sin "Dev Kit"). El "C# Dev Kit" es la opción moderna recomendada por Microsoft, porque agrega el explorador de soluciones/proyectos y una experiencia de ejecución/depuración más parecida a Visual Studio completo, pero dentro de VS Code.

### 4.2 Iniciar sesión (opcional pero recomendable)

El "C# Dev Kit" puede pedir iniciar sesión con una cuenta gratuita de Microsoft para desbloquear todas sus funciones (es gratuito para estudiantes e individuos). Si el laboratorio no permite iniciar sesión con cuentas personales, la extensión sigue funcionando para lo esencial del curso (compilar, ejecutar, depurar) sin necesidad de iniciar sesión.

---

## Parte 5: Crear el proyecto y el primer programa

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

### Ejecutar el programa

Desde la terminal, dentro de la carpeta del proyecto (`MiPrimerPrograma/`):

```bash
dotnet run
```

Este comando compila y ejecuta en un solo paso. Si todo está bien configurado, se verá el saludo y el programa esperará a que se escriba el nombre.

También se puede ejecutar con el botón ▶ **"Run"** que aparece en VS Code gracias al C# Dev Kit, una vez que el proyecto está abierto correctamente.

---

## Parte 6: Depuración básica

1. Dar clic a la izquierda del número de línea para poner un **breakpoint** (punto rojo).
2. Presionar `F5` o usar el panel de **"Run and Debug"** (ícono de play con un bicho, en la barra lateral izquierda).
3. Si es la primera vez, VS Code puede preguntar qué tipo de proyecto es: elegir **"C#"** / **".NET"**.
4. El programa se detendrá en el breakpoint y se podrán inspeccionar las variables (`nombre`, etc.) en el panel izquierdo.

---

## Tabla de errores comunes y solución rápida

| Síntoma | Causa probable | Solución |
|---|---|---|
| `'dotnet' no se reconoce como un comando` | El SDK no quedó en el PATH / no se reinició la terminal | Cerrar y reabrir la terminal; si persiste, reinstalar el .NET SDK (no solo el Runtime) |
| VS Code no muestra el botón "Run" ni IntelliSense | Falta el "C# Dev Kit" o se abrió un archivo suelto en vez de la carpeta del proyecto | Instalar "C# Dev Kit" y abrir la carpeta que contiene el archivo `.csproj` |
| `dotnet run` dice que no encuentra ningún proyecto | Se ejecutó el comando fuera de la carpeta que contiene el `.csproj` | Verificar con `dir`/`ls` que se está dentro de la carpeta correcta antes de correr `dotnet run` |
| Error de compilación por `nombre` nulo (`CS8600`, advertencia de nulabilidad) | Es un aviso normal de C# moderno sobre valores que podrían ser `null` | Se puede explicar como una introducción temprana al manejo de nulos; no impide ejecutar el programa |
| El programa no pide el `nombre` y se cierra de inmediato | Se ejecutó desde un botón/depurador que no soporta entrada por teclado | Ejecutar desde la terminal integrada con `dotnet run` |
| VS Code pide iniciar sesión y el alumno no quiere/puede | Es opcional para el "C# Dev Kit" | Se puede omitir ("Skip"/"Not now") y seguir trabajando con las funciones básicas |

---

## Checklist de verificación antes de la primera práctica

- [ ] `dotnet --version` responde con un número de versión sin errores.
- [ ] VS Code tiene instalado el **"C# Dev Kit"** (Microsoft).
- [ ] Se creó un proyecto con `dotnet new console -n NombreProyecto` y aparecen `Program.cs` y el archivo `.csproj`.
- [ ] El programa corrió correctamente con `dotnet run` (o el botón "Run") y respondió a la entrada de teclado.
- [ ] Se probó al menos un breakpoint con `F5`.

---

## Recomendación para la sesión de clase

Conviene remarcar desde el inicio que **no se debe confundir Visual Studio con Visual Studio Code**: son dos programas distintos de Microsoft, y las instrucciones de esta guía son específicamente para VS Code. Sugerencia de dinámica: instalar el .NET SDK en vivo, mostrar el único comando de verificación (`dotnet --version`, mucho más simple que en Java), y dedicar tiempo extra a explicar por qué C# trabaja con "proyectos" (carpeta + `.csproj`) en vez de archivos sueltos como Python, ya que este es el cambio de mentalidad más importante frente a lo que ya vieron en la práctica de Python. Cerrar con el checklist antes de avanzar a la siguiente práctica.
