# Práctica 4: Desarrollo de una aplicación web básica
## Fundamentos de Programación (IAD-2413) — Ingeniería en Inteligencia Artificial
### Instituto Tecnológico de Durango — TecNM

---

## Objetivo

Desarrollar una aplicación web básica que permita a los usuarios registrar sus datos personales y visualizarlos en una página de perfil, utilizando **Python con el framework Flask** para el backend y **HTML/CSS** para la interfaz, tal como lo marca el temario oficial de la asignatura.

Al terminar esta práctica, el alumno habrá:

- Instalado y configurado el entorno de desarrollo necesario.
- Construido una página web con un formulario (HTML) y la habrá estilizado (CSS).
- Escrito la lógica de un servidor web que recibe datos de un formulario y responde con una página nueva.
- Probado la aplicación en su propia computadora (`localhost`).
- Documentado el proceso realizado.

> **Nota:** esta guía usa Python/Flask como ruta principal porque es el camino más accesible para instalar y practicar. Al final se incluye una **ruta alternativa en Java/Spring Boot** para quien prefiera seguir por ese camino, ya que el temario acepta ambos.

---

## Índice

0. [Requisitos previos y materiales](#0-requisitos-previos-y-materiales)
1. [Instalación del entorno de desarrollo](#1-instalación-del-entorno-de-desarrollo)
2. [Creación de la estructura del proyecto](#2-creación-de-la-estructura-del-proyecto)
3. [Creación del entorno virtual e instalación de Flask](#3-creación-del-entorno-virtual-e-instalación-de-flask)
4. [Construcción de la interfaz web (HTML + CSS)](#4-construcción-de-la-interfaz-web-html--css)
5. [Construcción del backend (Flask)](#5-construcción-del-backend-flask)
6. [Ejecución y prueba de la aplicación](#6-ejecución-y-prueba-de-la-aplicación)
7. [Solución de problemas comunes](#7-solución-de-problemas-comunes)
8. [Actividad opcional — diseño responsivo (móvil)](#8-actividad-opcional--diseño-responsivo-móvil)
9. [Actividad opcional — guardar varios registros (persistencia simple)](#9-actividad-opcional--guardar-varios-registros-persistencia-simple)
10. [Actividad opcional — empaquetado como app de escritorio](#10-actividad-opcional--empaquetado-como-app-de-escritorio)
11. [Documentación que debes entregar](#11-documentación-que-debes-entregar)
12. [Checklist final de entrega](#12-checklist-final-de-entrega)
13. [Ruta alternativa: Java + Spring Boot](#13-ruta-alternativa-java--spring-boot)

---

## 0. Requisitos previos y materiales

- Una computadora con Windows, macOS o Linux, con permisos para instalar programas.
- Conexión a internet (solo para la instalación; la aplicación, una vez corriendo, funciona sin internet).
- Un editor de código. Se recomienda **Visual Studio Code** (ya usado en la Unidad 3). Si no lo tienes instalado, en la sección 1.2 se explica cómo hacerlo.
- Conocimientos previos: variables, condicionales, funciones (Unidad 1) y la metodología de análisis-diseño-implementación-prueba (Unidad 2).

---

## 1. Instalación del entorno de desarrollo

Si ya instalaste Python y VS Code en unidades anteriores, puedes pasar directamente al paso 1.3 (verificación) y luego a la sección 2. Si es la primera vez que configuras tu equipo, sigue todos los pasos en orden.

### 1.1 Instalar Python

**Windows:**

1. Abre el navegador y ve a **https://www.python.org/downloads/**.
2. Descarga la versión más reciente de Python 3 (por ejemplo, Python 3.12 o superior) haciendo clic en el botón amarillo "Download Python 3.x.x".
3. Ejecuta el instalador descargado.
4. **Muy importante:** en la primera pantalla del instalador, marca la casilla **"Add python.exe to PATH"** que aparece abajo, antes de darle en "Install Now". Si omites este paso, tendrás que agregar Python al PATH manualmente después.
5. Espera a que termine la instalación y cierra el instalador cuando aparezca "Setup was successful".

**macOS:**

1. Ve a **https://www.python.org/downloads/** y descarga el instalador de macOS.
2. Abre el archivo `.pkg` descargado y sigue el asistente de instalación (Continuar → Aceptar → Instalar).
3. Es posible que te pida tu contraseña de usuario; ingrésala para autorizar la instalación.

**Linux (Ubuntu/Debian):**

La mayoría de las distribuciones de Linux ya traen Python 3 preinstalado. Para confirmarlo o instalarlo, abre una terminal y ejecuta:

```bash
sudo apt update
sudo apt install python3 python3-venv python3-pip
```

### 1.2 Instalar Visual Studio Code (si no lo tienes)

1. Ve a **https://code.visualstudio.com/**.
2. Descarga el instalador correspondiente a tu sistema operativo (Windows, macOS o Linux).
3. Ejecútalo y sigue las opciones por defecto del asistente (en Windows, se recomienda marcar la casilla "Add to PATH" si aparece).
4. Abre VS Code una vez instalado para confirmar que inicia correctamente.
5. (Opcional pero recomendado) Instala la extensión oficial **"Python"** de Microsoft desde el ícono de extensiones (los cuatro cuadros en la barra lateral izquierda) para tener autocompletado y ejecución integrada.

### 1.3 Verificar la instalación

Abre una terminal:

- En **Windows**: busca "cmd" o "PowerShell" en el menú de inicio.
- En **macOS**: abre la aplicación "Terminal" (Cmd + Espacio, escribe "Terminal").
- En **Linux**: abre tu terminal habitual.

Ejecuta:

```bash
python --version
```

Si el comando anterior no funciona (error de "comando no encontrado"), prueba con:

```bash
python3 --version
```

Deberías ver algo como `Python 3.12.1`. Si ves un número de versión, Python está correctamente instalado. Verifica también que `pip` (el instalador de paquetes de Python) esté disponible:

```bash
pip --version
```

o, si usaste `python3` en el paso anterior:

```bash
pip3 --version
```

> A partir de aquí, esta guía usa `python` y `pip`. Si tu sistema requiere `python3` y `pip3`, sustitúyelos en cada comando.

---

## 2. Creación de la estructura del proyecto

Vamos a organizar el proyecto exactamente como se explicó en la Unidad 3 (creación y organización de proyectos de software).

1. Elige o crea una carpeta donde guardarás tus proyectos de la materia, por ejemplo `Documentos/IAD2413`.
2. Dentro de ella, crea una carpeta nueva llamada `practica4_registro`.
3. Abre esa carpeta con VS Code: en VS Code, ve a **Archivo → Abrir carpeta...** y selecciona `practica4_registro`.
4. Dentro de VS Code, crea la siguiente estructura de subcarpetas y archivos vacíos (puedes hacerlo con el ícono de "Nuevo archivo" / "Nueva carpeta" en el panel del explorador, a la izquierda):

```
practica4_registro/
│
├── app.py
├── templates/
│   ├── formulario.html
│   └── perfil.html
└── static/
    └── estilo.css
```

**¿Por qué esta estructura?** Flask, por convención, busca automáticamente las páginas HTML dentro de una carpeta llamada `templates/` y los archivos estáticos (CSS, imágenes, JavaScript) dentro de una carpeta llamada `static/`. Respetar estos nombres evita tener que configurar rutas manualmente.

---

## 3. Creación del entorno virtual e instalación de Flask

### 3.1 ¿Qué es un entorno virtual y por qué usarlo?

Un entorno virtual es una copia aislada de Python donde puedes instalar paquetes (como Flask) sin afectar al resto de tu sistema ni a otros proyectos. Es una buena práctica profesional que también se mencionó en la Unidad 3 al hablar de organización de proyectos.

### 3.2 Crear el entorno virtual

En VS Code, abre una terminal integrada: menú **Terminal → Nueva Terminal** (o `Ctrl + ñ` / `` Ctrl + ` ``). Asegúrate de que la terminal esté ubicada dentro de la carpeta `practica4_registro`. Ejecuta:

```bash
python -m venv venv
```

Esto crea una carpeta llamada `venv/` dentro de tu proyecto (no la borres ni la edites manualmente).

### 3.3 Activar el entorno virtual

- **Windows (PowerShell):**
  ```powershell
  venv\Scripts\Activate.ps1
  ```
  Si PowerShell muestra un error de "ejecución de scripts deshabilitada", ejecuta primero:
  ```powershell
  Set-ExecutionPolicy -Scope CurrentUser RemoteSigned
  ```
  y confirma con "S" o "Y" cuando lo pida.

- **Windows (CMD):**
  ```cmd
  venv\Scripts\activate.bat
  ```

- **macOS / Linux:**
  ```bash
  source venv/bin/activate
  ```

Sabrás que el entorno está activo porque el nombre `(venv)` aparecerá al inicio de la línea de la terminal, así:

```
(venv) C:\Documentos\IAD2413\practica4_registro>
```

> Deberás activar el entorno virtual **cada vez que abras una nueva terminal** para trabajar en este proyecto.

### 3.4 Instalar Flask

Con el entorno virtual activo, instala Flask:

```bash
pip install flask
```

Verifica que se instaló correctamente:

```bash
pip show flask
```

Deberías ver información como el nombre, versión y ubicación del paquete instalado.

### 3.5 (Recomendado) Guardar las dependencias del proyecto

Es una buena práctica dejar registradas las bibliotecas que usa tu proyecto, para que cualquier persona (o tú mismo en otra computadora) pueda instalarlas fácilmente:

```bash
pip freeze > requirements.txt
```

Esto crea un archivo `requirements.txt` en la raíz del proyecto. Inclúyelo en tu entrega.

---

## 4. Construcción de la interfaz web (HTML + CSS)

### 4.1 El formulario de registro (`templates/formulario.html`)

Abre `templates/formulario.html` y escribe el siguiente contenido:

```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de usuario</title>
    <link rel="stylesheet" href="{{ url_for('static', filename='estilo.css') }}">
</head>
<body>
    <main class="tarjeta">
        <h1>Registro de usuario</h1>
        <p>Completa tus datos para crear tu perfil.</p>

        <form action="/registro" method="POST">
            <label for="nombre">Nombre completo:</label>
            <input type="text" id="nombre" name="nombre" required>

            <label for="correo">Correo electrónico:</label>
            <input type="email" id="correo" name="correo" required>

            <label for="carrera">Carrera:</label>
            <input type="text" id="carrera" name="carrera" required>

            <button type="submit">Registrarme</button>
        </form>
    </main>
</body>
</html>
```

**Explicación de las partes nuevas:**

- `{{ url_for('static', filename='estilo.css') }}` es una instrucción especial de Flask (usa un motor de plantillas llamado **Jinja2**) que genera automáticamente la ruta correcta hacia tu archivo CSS dentro de la carpeta `static/`.
- `<form action="/registro" method="POST">` indica que, al enviarse el formulario, el navegador debe hacer una petición `POST` a la ruta `/registro` de tu servidor Flask — esa ruta la programarás en el paso 5.
- El atributo `name="nombre"` de cada `<input>` es el identificador con el que el backend (Flask) leerá ese dato. Debe coincidir exactamente con lo que uses en `app.py`.
- `required` es una validación básica del lado del navegador: no deja enviar el formulario si el campo está vacío.

### 4.2 La página de perfil (`templates/perfil.html`)

Abre `templates/perfil.html` y escribe:

```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mi perfil</title>
    <link rel="stylesheet" href="{{ url_for('static', filename='estilo.css') }}">
</head>
<body>
    <main class="tarjeta">
        <h1>¡Registro exitoso!</h1>
        <div class="perfil">
            <p><strong>Nombre:</strong> {{ nombre }}</p>
            <p><strong>Correo:</strong> {{ correo }}</p>
            <p><strong>Carrera:</strong> {{ carrera }}</p>
        </div>
        <a href="/" class="enlace">← Registrar otro usuario</a>
    </main>
</body>
</html>
```

**Explicación:** `{{ nombre }}`, `{{ correo }}` y `{{ carrera }}` son variables de Jinja2. Flask les asignará un valor real cuando "renderice" (genere) esta página desde el backend, en el paso 5.

### 4.3 Estilos (`static/estilo.css`)

Abre `static/estilo.css` y escribe:

```css
* {
    box-sizing: border-box;
    font-family: 'Segoe UI', Arial, sans-serif;
}

body {
    background-color: #F4F6FB;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    margin: 0;
}

.tarjeta {
    background-color: #FFFFFF;
    padding: 32px;
    border-radius: 12px;
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
    width: 100%;
    max-width: 380px;
}

h1 {
    color: #1E2761;
    margin-top: 0;
}

label {
    display: block;
    margin-top: 14px;
    margin-bottom: 4px;
    color: #4A4A55;
    font-size: 14px;
}

input {
    width: 100%;
    padding: 10px;
    border: 1px solid #DDE1EF;
    border-radius: 6px;
    font-size: 14px;
}

button {
    width: 100%;
    padding: 12px;
    margin-top: 20px;
    background-color: #1E2761;
    color: white;
    border: none;
    border-radius: 6px;
    font-size: 15px;
    cursor: pointer;
}

button:hover {
    background-color: #273580;
}

.perfil p {
    font-size: 15px;
    color: #2B2B33;
}

.enlace {
    display: inline-block;
    margin-top: 16px;
    color: #1E2761;
    text-decoration: none;
    font-size: 14px;
}

.enlace:hover {
    text-decoration: underline;
}
```

---

## 5. Construcción del backend (Flask)

Abre `app.py` y escribe:

```python
from flask import Flask, render_template, request

app = Flask(__name__)


@app.route("/")
def inicio():
    """Muestra el formulario de registro."""
    return render_template("formulario.html")


@app.route("/registro", methods=["POST"])
def registro():
    """Recibe los datos del formulario y muestra la página de perfil."""
    nombre = request.form.get("nombre")
    correo = request.form.get("correo")
    carrera = request.form.get("carrera")

    return render_template(
        "perfil.html",
        nombre=nombre,
        correo=correo,
        carrera=carrera
    )


if __name__ == "__main__":
    app.run(debug=True)
```

**Explicación línea por línea:**

- `from flask import Flask, render_template, request`: importa las tres piezas que usaremos: la clase principal `Flask`, la función `render_template` (para devolver una página HTML de la carpeta `templates/`) y el objeto `request` (que contiene los datos que envía el navegador).
- `app = Flask(__name__)`: crea la aplicación Flask. `__name__` le indica a Flask en qué archivo está para que pueda encontrar las carpetas `templates/` y `static/` automáticamente.
- `@app.route("/")`: es un **decorador**; le dice a Flask "cuando alguien visite la URL raíz (`/`), ejecuta la función que está justo debajo". Por defecto, una ruta responde a peticiones `GET` (visitar una URL en el navegador).
- `def inicio(): return render_template("formulario.html")`: cuando el usuario visita `/`, se le muestra el formulario que creaste en el paso 4.1.
- `@app.route("/registro", methods=["POST"])`: esta ruta solo responde a peticiones `POST`, que es el método que usa el `<form>` del paso 4.1.
- `request.form.get("nombre")`: lee el valor que el usuario escribió en el campo `<input name="nombre">` del formulario. Si el campo no existiera, `.get()` regresaría `None` en vez de generar un error — por eso se prefiere sobre `request.form["nombre"]`.
- `render_template("perfil.html", nombre=nombre, correo=correo, carrera=carrera)`: genera la página `perfil.html` sustituyendo `{{ nombre }}`, `{{ correo }}` y `{{ carrera }}` por los valores reales recibidos.
- `if __name__ == "__main__": app.run(debug=True)`: este bloque solo se ejecuta cuando corres el archivo directamente (`python app.py`), no cuando se importa desde otro archivo. `debug=True` activa el modo de depuración: reinicia el servidor automáticamente cada vez que guardas un cambio y muestra errores detallados en el navegador — **muy útil mientras desarrollas**, pero debe desactivarse en un entorno de producción real.

---

## 6. Ejecución y prueba de la aplicación

### 6.1 Ejecutar el servidor

Con el entorno virtual activo (`(venv)` visible en la terminal) y ubicado en la carpeta `practica4_registro`, ejecuta:

```bash
python app.py
```

Deberías ver algo similar a esto en la terminal:

```
 * Serving Flask app 'app'
 * Debug mode: on
 * Running on http://127.0.0.1:5000
Press CTRL+C to quit
```

### 6.2 Probar la aplicación en el navegador

1. Abre tu navegador (Chrome, Firefox, Edge, etc.).
2. Ve a la dirección **http://127.0.0.1:5000** (también puedes usar `http://localhost:5000`).
3. Deberías ver tu formulario de registro con los estilos aplicados.
4. Llena los tres campos (nombre, correo, carrera) y haz clic en **"Registrarme"**.
5. Deberías ser redirigido a la página de perfil, mostrando exactamente los datos que escribiste.
6. Haz clic en **"← Registrar otro usuario"** para regresar al formulario y probar de nuevo con otros datos.

### 6.3 Pruebas que debes realizar (y documentar con capturas)

| Prueba | Qué hacer | Resultado esperado |
|---|---|---|
| Registro exitoso | Llenar los tres campos correctamente y enviar | Se muestra la página de perfil con los datos correctos |
| Campo vacío | Dejar "Nombre" vacío e intentar enviar | El navegador impide el envío (por el atributo `required`) y muestra un mensaje |
| Correo inválido | Escribir un texto sin `@` en el campo de correo | El navegador muestra un aviso de formato inválido (por `type="email"`) |
| Caracteres especiales | Registrar un nombre con acentos o la letra "ñ" | El perfil debe mostrar el texto correctamente, sin errores |
| Volver al formulario | Dar clic en el enlace de regreso desde el perfil | Se muestra nuevamente el formulario, vacío |

### 6.4 Detener el servidor

En la terminal donde corre Flask, presiona `Ctrl + C` para detener el servidor cuando termines de probar.

---

## 7. Solución de problemas comunes

| Error / síntoma | Causa probable | Solución |
|---|---|---|
| `ModuleNotFoundError: No module named 'flask'` | El entorno virtual no está activo, o Flask no se instaló en él | Activa el entorno virtual (paso 3.3) y vuelve a instalar Flask (paso 3.4) |
| `'python' no se reconoce como un comando...` | Python no quedó agregado al PATH | Reinstala Python marcando "Add python.exe to PATH", o usa `py` en vez de `python` en Windows |
| El navegador muestra "Esta página no funciona" / no conecta | El servidor Flask no está corriendo, o se cerró la terminal | Verifica que la terminal muestre "Running on http://127.0.0.1:5000" y que no la hayas cerrado |
| `Address already in use` / puerto ocupado | Ya hay otro proceso usando el puerto 5000 | Cierra la otra instancia de Flask, o ejecuta `app.run(debug=True, port=5001)` y visita el puerto 5001 |
| `jinja2.exceptions.UndefinedError` | Falta pasar una variable al `render_template` que sí se usa en el HTML | Revisa que todas las variables `{{ }}` del HTML se estén enviando desde `app.py` |
| Los estilos CSS no se aplican | La ruta del `<link>` está mal escrita, o el archivo no está en `static/` | Verifica que uses `{{ url_for('static', filename='estilo.css') }}` y que el archivo exista en esa carpeta exacta |
| Cambios en el código no se reflejan en el navegador | El servidor no se reinició, o el navegador guardó una versión en caché | Confirma que `debug=True` esté activo; si persiste, recarga forzando el refresco (`Ctrl + F5`) |

---

## 8. Actividad opcional — diseño responsivo (móvil)

Esta actividad corresponde al punto 2 (opcional) de la práctica oficial: adaptar la aplicación para que se vea bien en dispositivos móviles.

Agrega lo siguiente al final de `static/estilo.css`:

```css
@media (max-width: 480px) {
    .tarjeta {
        margin: 16px;
        padding: 20px;
    }

    h1 {
        font-size: 22px;
    }
}
```

**Explicación:** una `@media query` aplica esas reglas de estilo únicamente cuando el ancho de pantalla es de 480 píxeles o menos (celulares típicos), reduciendo márgenes y tamaño de letra para que la tarjeta no se vea demasiado grande. Para probarlo sin un celular físico, abre las herramientas de desarrollador del navegador (`F12`), activa el "modo de dispositivo móvil" (ícono de celular/tablet) y recarga la página.

---

## 9. Actividad opcional — guardar varios registros (persistencia simple)

Esta actividad extiende la práctica para que la aplicación recuerde a todos los usuarios registrados durante la sesión, no solo al último. Es un buen puente hacia el tema de persistencia de datos que se profundizará en materias posteriores.

Modifica `app.py`:

```python
from flask import Flask, render_template, request

app = Flask(__name__)

usuarios_registrados = []  # lista en memoria; se borra al reiniciar el servidor


@app.route("/")
def inicio():
    return render_template("formulario.html")


@app.route("/registro", methods=["POST"])
def registro():
    nombre = request.form.get("nombre")
    correo = request.form.get("correo")
    carrera = request.form.get("carrera")

    usuarios_registrados.append({
        "nombre": nombre,
        "correo": correo,
        "carrera": carrera
    })

    return render_template(
        "perfil.html",
        nombre=nombre,
        correo=correo,
        carrera=carrera
    )


@app.route("/usuarios")
def usuarios():
    return render_template("usuarios.html", usuarios=usuarios_registrados)


if __name__ == "__main__":
    app.run(debug=True)
```

Crea el archivo `templates/usuarios.html`:

```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Usuarios registrados</title>
    <link rel="stylesheet" href="{{ url_for('static', filename='estilo.css') }}">
</head>
<body>
    <main class="tarjeta">
        <h1>Usuarios registrados</h1>
        {% for usuario in usuarios %}
            <div class="perfil">
                <p><strong>{{ usuario.nombre }}</strong> — {{ usuario.correo }} ({{ usuario.carrera }})</p>
            </div>
        {% else %}
            <p>Todavía no hay usuarios registrados.</p>
        {% endfor %}
        <a href="/" class="enlace">← Registrar otro usuario</a>
    </main>
</body>
</html>
```

**Explicación:** `{% for usuario in usuarios %} ... {% endfor %}` es un bucle de Jinja2 que recorre la lista `usuarios_registrados` y repite el bloque HTML por cada elemento; `{% else %}` dentro del `for` se ejecuta solo si la lista está vacía. Visita **http://127.0.0.1:5000/usuarios** para ver la lista completa.

> **Nota importante:** esta lista vive únicamente en la memoria del programa mientras el servidor está corriendo; si detienes el servidor (`Ctrl + C`) o lo reinicias, los datos se pierden. Guardar los datos de forma permanente requiere una base de datos, tema de una unidad/materia posterior.

---

## 10. Actividad opcional — empaquetado como app de escritorio

El temario permite, como actividad opcional, crear una versión de la aplicación para escritorio utilizando un framework como **Electron**. Dado que Electron trabaja de forma nativa con JavaScript (no con Python), la manera más simple de cumplir este punto sin reescribir el backend es:

1. Dejar el servidor Flask corriendo normalmente (`python app.py`).
2. Instalar Node.js desde **https://nodejs.org/** (elige la versión LTS) siguiendo el instalador por defecto.
3. Verificar la instalación:
   ```bash
   node --version
   npm --version
   ```
4. Investigar y documentar (no es obligatorio implementarlo por completo) cómo un "wrapper" de Electron puede abrir una ventana de escritorio que simplemente cargue `http://127.0.0.1:5000` en su interior, en lugar de un navegador. Esto se deja como ejercicio de investigación autónoma, ya que profundizar en Electron corresponde a una materia posterior.

---

## 11. Documentación que debes entregar

Elabora un documento breve (puede ser el mismo Word/PDF de tu reporte) que incluya:

1. **Descripción del problema:** qué hace la aplicación y para quién.
2. **Diseño:** estructura de carpetas utilizada y por qué (referencia a la Unidad 3).
3. **Implementación:** explica brevemente qué hace `app.py`, `formulario.html` y `perfil.html` (puedes basarte en las explicaciones de esta guía, pero redactadas con tus propias palabras).
4. **Pruebas realizadas:** incluye capturas de pantalla del formulario, del perfil generado y de al menos una prueba de validación (por ejemplo, el campo vacío).
5. **Dificultades encontradas y cómo las resolviste** (si tuviste algún error de la sección 7, este es el lugar para documentarlo).
6. **(Si aplica) actividades opcionales realizadas:** diseño responsivo, múltiples registros o investigación de Electron.

---

## 12. Checklist final de entrega

- [ ] Código fuente completo (`app.py`, carpeta `templates/`, carpeta `static/`, `requirements.txt`).
- [ ] La aplicación corre sin errores con `python app.py`.
- [ ] El formulario permite registrar nombre, correo y carrera.
- [ ] La página de perfil muestra correctamente los datos enviados.
- [ ] Capturas de pantalla de la aplicación en funcionamiento.
- [ ] Documento de diseño, implementación y pruebas (sección 11).
- [ ] (Opcional) Diseño responsivo probado en modo dispositivo móvil.
- [ ] (Opcional) Ruta `/usuarios` con lista de registros.
- [ ] (Opcional) Investigación documentada sobre Electron.

---

## 13. Ruta alternativa: Java + Spring Boot

Si tu equipo prefiere usar Java en vez de Python para el backend (ambos están permitidos por el temario), estos son los pasos equivalentes. Se asume que ya tienes el JDK y VS Code configurados según la guía de instalación de la Unidad 3.

### 13.1 Crear el proyecto con Spring Initializr

1. Ve a **https://start.spring.io/** en tu navegador.
2. Configura: **Project:** Maven; **Language:** Java; **Spring Boot:** la versión estable más reciente.
3. En "Dependencies", agrega **"Spring Web"** y **"Thymeleaf"** (el motor de plantillas HTML equivalente a Jinja2).
4. Haz clic en **"Generate"**; se descargará un archivo `.zip`.
5. Descomprime el `.zip` y abre la carpeta resultante con VS Code (con la extensión "Extension Pack for Java" instalada, como se vio en la Unidad 3).

### 13.2 Estructura relevante

```
src/main/java/.../RegistroController.java
src/main/resources/templates/formulario.html
src/main/resources/templates/perfil.html
src/main/resources/static/estilo.css
```

### 13.3 Controlador (equivalente a `app.py`)

```java
@Controller
public class RegistroController {

    @GetMapping("/")
    public String inicio() {
        return "formulario";
    }

    @PostMapping("/registro")
    public String registro(@RequestParam String nombre,
                            @RequestParam String correo,
                            @RequestParam String carrera,
                            Model model) {
        model.addAttribute("nombre", nombre);
        model.addAttribute("correo", correo);
        model.addAttribute("carrera", carrera);
        return "perfil";
    }
}
```

### 13.4 Plantilla de perfil con Thymeleaf (equivalente a Jinja2)

```html
<p>Nombre: <span th:text="${nombre}"></span></p>
<p>Correo: <span th:text="${correo}"></span></p>
<p>Carrera: <span th:text="${carrera}"></span></p>
```

### 13.5 Ejecutar el proyecto

Desde la terminal, dentro de la carpeta del proyecto:

```bash
./mvnw spring-boot:run
```

(en Windows: `mvnw.cmd spring-boot:run`). Cuando termine de compilar, visita **http://localhost:8080** en el navegador.

El resto del proceso (estilos CSS, pruebas, documentación y checklist de entrega) es idéntico al descrito en las secciones 4, 6, 11 y 12 de esta guía.

---

*Guía de práctica preparada para la asignatura Fundamentos de Programación (IAD-2413), Ingeniería en Inteligencia Artificial, Instituto Tecnológico de Durango — TecNM.*
