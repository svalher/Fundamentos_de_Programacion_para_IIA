# Guía de Instalación y Configuración: Python + Visual Studio Code
### Materia: Fundamentos de Programación (IAD-2413) — ITD / TecNM

**Objetivo:** que cada alumno tenga, en menos de 30 minutos y sin depender del profesor, un entorno funcional para escribir, ejecutar y depurar programas en Python usando Visual Studio Code (VS Code).

> Nota didáctica para el profesor: la mayoría de los problemas que reportan los alumnos NO son de programación, son de instalación (Python no quedó en el PATH, abrieron la terminal equivocada, o VS Code no detectó el intérprete). Por eso esta guía insiste tanto en la verificación paso a paso: si algo falla, se detecta de inmediato y no se arrastra el problema a la primera práctica.

---

## 0. Requisitos previos

- Laptop con Windows 10/11, macOS o Linux (esta guía cubre los tres, con énfasis en Windows por ser el más común en el grupo).
- Conexión a internet (solo para la descarga e instalación).
- Permisos de administrador en el equipo.

---

## Parte 1: Instalar Python

### Windows

1. Ir a **https://www.python.org/downloads/** y descargar la versión estable más reciente (evitar versiones "rc" o "beta").
2. Ejecutar el instalador descargado.
3. **Paso crítico (aquí es donde la mayoría falla):** en la primera pantalla del instalador, marcar la casilla inferior:
   - ☑ **"Add python.exe to PATH"**
   - Si no se marca esta casilla, Python se instala pero la terminal no lo va a reconocer, y los alumnos verán el error `'python' no se reconoce como un comando interno o externo`.
4. Dar clic en **"Install Now"**.
5. Al terminar, dar clic en **"Disable path length limit"** si aparece (evita errores con rutas largas más adelante).

### macOS

1. Ir a **https://www.python.org/downloads/** y descargar el instalador `.pkg` para macOS.
2. Ejecutar el instalador y seguir los pasos por defecto.
3. macOS ya trae Python 2 preinstalado por compatibilidad del sistema; por eso siempre se usará el comando `python3`, nunca `python`.

### Linux (Ubuntu/Debian)

En la mayoría de las distribuciones Python 3 ya viene instalado. Verificar y, si falta, instalar `pip` y el entorno virtual:

```bash
sudo apt update
sudo apt install python3 python3-pip python3-venv
```

---

## Parte 2: Verificar que Python quedó bien instalado

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

## Parte 3: Instalar Visual Studio Code

1. Ir a **https://code.visualstudio.com/** y descargar la versión para el sistema operativo correspondiente.
2. Instalar con las opciones por defecto. En Windows, es recomendable dejar marcadas las casillas:
   - ☑ "Add to PATH"
   - ☑ "Register Code as an editor for supported file types"
   - ☑ "Add 'Open with Code' action to Windows Explorer context menu"

Esta última opción es muy útil en clase: permite dar clic derecho sobre cualquier carpeta y abrirla directamente en VS Code.

---

## Parte 4: Configurar VS Code para trabajar con Python

### 4.1 Instalar la extensión de Python

1. Abrir VS Code.
2. Ir al ícono de **Extensiones** en la barra lateral izquierda (o `Ctrl+Shift+X`).
3. Buscar **"Python"** (la extensión oficial, publicada por **Microsoft**, con el ícono azul/amarillo).
4. Dar clic en **Instalar**.

Esta extensión incluye automáticamente:
- Resaltado de sintaxis y autocompletado (Pylance).
- Detección de intérpretes de Python instalados.
- Soporte para depuración (debugging) y ejecución de código.

### 4.2 Verificar/seleccionar el intérprete de Python

Este es el segundo punto donde más se atoran los alumnos: VS Code puede tener instalada la extensión pero apuntando a ningún intérprete o al equivocado.

1. Abrir la paleta de comandos: `Ctrl+Shift+P` (Windows/Linux) o `Cmd+Shift+P` (macOS).
2. Escribir **"Python: Select Interpreter"** y presionar Enter.
3. Elegir la versión de Python que se instaló en la Parte 1 (debe aparecer en la lista automáticamente).
4. Confirmar que en la barra inferior izquierda de VS Code ahora se muestra el número de versión de Python.

---

## Parte 5: Crear la carpeta de trabajo y el primer programa

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

### Ejecutar el programa

Hay dos formas, conviene que los alumnos conozcan ambas:

- **Botón rápido:** clic en el triángulo ▶ (Run Python File) en la esquina superior derecha del editor.
- **Terminal integrada:** abrir con `Ctrl+ñ` o desde el menú **Terminal → Nueva terminal**, y escribir:

```bash
python hola_mundo.py
```

Si todo está bien configurado, aparecerá el resultado en el panel de terminal dentro de VS Code, y el programa esperará a que se escriba el nombre.

---

## Parte 6: Depuración básica (opcional pero muy recomendable desde la primera práctica)

1. Dar clic a la izquierda del número de línea para poner un **breakpoint** (punto rojo).
2. Presionar `F5` o ir a **Ejecutar → Iniciar depuración**.
3. Elegir la opción **"Python File"** cuando se pregunte el tipo de configuración.
4. El programa se detendrá en el breakpoint y se podrán revisar las variables en el panel izquierdo.

Enseñar esto desde el inicio evita que, más adelante, los alumnos solo usen `print()` para "adivinar" dónde está el error.

---

## Tabla de errores comunes y solución rápida

| Síntoma | Causa probable | Solución |
|---|---|---|
| `'python' no se reconoce como un comando` | No se marcó "Add to PATH" al instalar | Reinstalar Python marcando la casilla, o agregar la ruta manualmente al PATH del sistema |
| VS Code no sugiere código ni resalta errores | Falta la extensión de Python o no está seleccionado el intérprete | Instalar extensión "Python" de Microsoft y usar "Python: Select Interpreter" |
| Al ejecutar, dice `No module named 'pip'` | Instalación incompleta de Python | Reinstalar Python desde cero |
| El botón ▶ no aparece | El archivo no tiene extensión `.py` | Renombrar el archivo con `.py` al final |
| Los acentos o "ñ" se ven raros al ejecutar | Codificación de la terminal (más común en Windows con CMD antiguo) | Usar la terminal integrada de VS Code, que ya maneja UTF-8 correctamente |
| `python3` funciona pero `python` no (Mac/Linux) | Es el comportamiento normal del sistema | Usar siempre `python3` en esos sistemas |

---

## Checklist de verificación antes de la primera práctica

Pedir a cada alumno que confirme lo siguiente antes de iniciar la Unidad 2 (o la primera práctica de programación):

- [ ] `python --version` (o `python3 --version`) muestra un número de versión sin errores.
- [ ] VS Code tiene instalada la extensión oficial "Python" (Microsoft).
- [ ] Al abrir un archivo `.py`, la barra inferior de VS Code muestra el intérprete seleccionado.
- [ ] El programa `hola_mundo.py` corrió correctamente y pidió/mostró el nombre.
- [ ] Se probó al menos un breakpoint con `F5`.

---

## Recomendación para la sesión de clase

Sugerencia de dinámica para la primera sesión de laboratorio: realizar la instalación en vivo, proyectando la pantalla, deteniéndose exactamente en el paso de "Add to PATH" y en "Select Interpreter", que son los dos puntos donde ocurre el 80% de los problemas reportados por los alumnos. Después, dejar 5 minutos para que cada quien corra su `hola_mundo.py` y levante la mano si algo falla, antes de avanzar a contenido nuevo.
