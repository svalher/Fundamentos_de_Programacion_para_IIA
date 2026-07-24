# Fundamentos de Programación (IAD-2413)
## Instituto Tecnológico de Durango — Ingeniería en Inteligencia Artificial

# Unidad 4: Desarrollo de aplicaciones prácticas
### Ejemplos trabajados en Python, C# y Java

---

## Índice

1. [Introducción a la unidad](#introducción-a-la-unidad)
2. [4.1 Introducción al desarrollo de aplicaciones web básicas](#41-introducción-al-desarrollo-de-aplicaciones-web-básicas)
3. [4.2 Introducción al desarrollo de aplicaciones móviles](#42-introducción-al-desarrollo-de-aplicaciones-móviles)
4. [4.3 Creación de aplicaciones de escritorio simples](#43-creación-de-aplicaciones-de-escritorio-simples)
5. [4.4 Exploración de herramientas y frameworks para desarrollo de software](#44-exploración-de-herramientas-y-frameworks-para-desarrollo-de-software)
6. [Tabla comparativa de plataformas y frameworks](#tabla-comparativa-de-plataformas-y-frameworks)
7. [Conexión con la Práctica 4 del temario](#conexión-con-la-práctica-4-del-temario)
8. [Conexión con el Proyecto integrador](#conexión-con-el-proyecto-integrador)
9. [Rúbrica sugerida de evaluación de la unidad](#rúbrica-sugerida-de-evaluación-de-la-unidad)

---

## Introducción a la unidad

Las Unidades 1 a 3 dieron al estudiante el vocabulario de la programación (variables, tipos de datos, control de flujo, funciones), una metodología de resolución de problemas (análisis → diseño → implementación → depuración → documentación) y el manejo de un entorno de desarrollo profesional (IDE, bibliotecas, organización de proyectos). La Unidad 4 es donde todo eso converge: el estudiante deja de escribir programas de consola aislados y construye, por primera vez, **aplicaciones con interfaz de usuario** que alguien más podría usar — una página web, una pantalla de escritorio o el esbozo de una app móvil.

El objetivo no es que el estudiante domine ningún framework a profundidad (eso corresponde a materias posteriores como Desarrollo Web, Programación Móvil o Ingeniería de Software), sino que **comprenda el panorama**: qué tipos de aplicaciones existen, qué papel juega cada capa (interfaz, lógica de negocio, datos) y cómo los mismos fundamentos de programación aprendidos hasta ahora se aplican al construir software con el que un usuario interactúa directamente.

**Competencia específica de la unidad:** el estudiante aplica los conocimientos de programación adquiridos para desarrollar aplicaciones web, móviles y de escritorio básicas, utilizando herramientas y frameworks apropiados.

**Relación con el resto del curso:** esta unidad cierra el ciclo de Fundamentos de Programación y conecta directamente con el **Proyecto integrador de la asignatura** (plataforma de gestión de tareas colaborativas), así como con materias posteriores de la carrera: Programación Orientada a Objetos, Bases de Datos, Desarrollo Web y Desarrollo de Aplicaciones Móviles.

---

## 4.1 Introducción al desarrollo de aplicaciones web básicas

### Concepto

Una aplicación web es un programa que se ejecuta, al menos en parte, en un servidor y se consume desde un navegador. Conviene que el estudiante distinga desde el inicio tres capas:

- **Frontend (cliente):** lo que el usuario ve y con lo que interactúa — **HTML** (estructura), **CSS** (presentación) y **JavaScript** (comportamiento), interpretados por el navegador.
- **Backend (servidor):** la lógica de negocio, validaciones y acceso a datos. Se escribe en un lenguaje de propósito general (Python, C#, Java, entre otros) y responde a peticiones HTTP.
- **Persistencia (datos):** dónde se guarda la información entre sesiones — típicamente una base de datos, tema que se profundizará en materias posteriores.

El patrón cliente–servidor es la base: el navegador (cliente) envía una petición HTTP (`GET`, `POST`, etc.) a una URL; el servidor la procesa y responde, normalmente con HTML generado dinámicamente o con datos en formato JSON.

### Un backend mínimo en tres lenguajes

El siguiente ejemplo muestra un servidor web mínimo que responde a `GET /` con un saludo y a `POST /registro` con los datos enviados desde un formulario — el mismo patrón que pide la Práctica 4 del temario.

**Python — Flask**
```python
from flask import Flask, request, render_template

app = Flask(__name__)

@app.route("/")
def inicio():
    return render_template("formulario.html")

@app.route("/registro", methods=["POST"])
def registro():
    nombre = request.form.get("nombre")
    correo = request.form.get("correo")
    return render_template("perfil.html", nombre=nombre, correo=correo)

if __name__ == "__main__":
    app.run(debug=True)
```

**C# — ASP.NET Core (Minimal API)**
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(HtmlFormulario(), "text/html"));

app.MapPost("/registro", (HttpRequest request) =>
{
    string nombre = request.Form["nombre"];
    string correo = request.Form["correo"];
    return Results.Content($"<h1>Bienvenido, {nombre}</h1><p>{correo}</p>", "text/html");
});

app.Run();
```

**Java — Spring Boot**
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
                            Model model) {
        model.addAttribute("nombre", nombre);
        model.addAttribute("correo", correo);
        return "perfil";
    }
}
```

### El formulario en el cliente (HTML + CSS)

```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Registro de usuario</title>
    <style>
        body { font-family: sans-serif; max-width: 400px; margin: 40px auto; }
        input, button { width: 100%; padding: 8px; margin-top: 8px; }
    </style>
</head>
<body>
    <h1>Registro</h1>
    <form action="/registro" method="POST">
        <label>Nombre:</label>
        <input type="text" name="nombre" required>
        <label>Correo:</label>
        <input type="email" name="correo" required>
        <button type="submit">Enviar</button>
    </form>
</body>
</html>
```

### Puntos clave para el aula

- El **método HTTP** (`GET` vs `POST`) determina si los datos van en la URL o en el cuerpo de la petición; para formularios con datos sensibles o extensos se usa `POST`.
- El servidor **no mantiene memoria entre peticiones** por sí solo (HTTP es sin estado); si se necesita "recordar" al usuario entre páginas se usan sesiones o cookies — mencionar el concepto sin profundizar.
- Los tres frameworks (Flask, ASP.NET Core, Spring Boot) resuelven el mismo problema con la misma forma general: **rutas** que mapean una URL + método HTTP a una función/método que produce una respuesta.
- El diseño responsivo (que la página se vea bien en cualquier tamaño de pantalla) se menciona como concepto, ya que la Práctica 4 lo marca como actividad opcional.

---

## 4.2 Introducción al desarrollo de aplicaciones móviles

### Concepto

Una aplicación móvil se ejecuta directamente en el dispositivo (a diferencia de una app web, que corre en el navegador). Existen tres enfoques principales que conviene comparar:

| Enfoque | Ejemplo de tecnología | Ventaja | Desventaja |
|---|---|---|---|
| **Nativo** | Java/Kotlin (Android), Swift (iOS) | Máximo rendimiento y acceso al hardware | Se programa por separado para cada plataforma |
| **Multiplataforma** | .NET MAUI (C#), Flutter, React Native | Un solo código para Android e iOS | Curva de aprendizaje del framework |
| **Híbrida / basada en web** | Aplicación web empaquetada (PWA, Ionic) | Reutiliza HTML/CSS/JS | Rendimiento y acceso al hardware limitados |

Para esta unidad basta con que el estudiante identifique estos enfoques y practique la lógica de una pantalla móvil sencilla (no se espera un despliegue real a una tienda de aplicaciones ni una configuración completa de Android Studio o Xcode).

### Ejemplo conceptual: pantalla de login (interfaz + lógica separadas)

**Java — Android (vista simplificada de un `Activity`)**
```java
public class LoginActivity extends AppCompatActivity {

    private EditText campoUsuario, campoContrasena;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        campoUsuario = findViewById(R.id.campoUsuario);
        campoContrasena = findViewById(R.id.campoContrasena);
        Button botonEntrar = findViewById(R.id.botonEntrar);

        botonEntrar.setOnClickListener(v -> validarLogin());
    }

    private void validarLogin() {
        String usuario = campoUsuario.getText().toString();
        String contrasena = campoContrasena.getText().toString();
        if (usuario.isEmpty() || contrasena.isEmpty()) {
            Toast.makeText(this, "Completa ambos campos", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this, "Bienvenido, " + usuario, Toast.LENGTH_SHORT).show();
        }
    }
}
```

**C# — .NET MAUI (multiplataforma Android/iOS)**
```csharp
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        botonEntrar.Clicked += ValidarLogin;
    }

    private void ValidarLogin(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(campoUsuario.Text) || string.IsNullOrEmpty(campoContrasena.Text))
            DisplayAlert("Aviso", "Completa ambos campos", "OK");
        else
            DisplayAlert("Bienvenido", campoUsuario.Text, "OK");
    }
}
```

**Python — Kivy (prototipado rápido, multiplataforma)**
```python
from kivy.app import App
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.textinput import TextInput
from kivy.uix.button import Button
from kivy.uix.popup import Popup
from kivy.uix.label import Label

class LoginLayout(BoxLayout):
    def __init__(self, **kwargs):
        super().__init__(orientation="vertical", **kwargs)
        self.usuario = TextInput(hint_text="Usuario")
        self.contrasena = TextInput(hint_text="Contraseña", password=True)
        boton = Button(text="Entrar")
        boton.bind(on_press=self.validar_login)
        self.add_widget(self.usuario)
        self.add_widget(self.contrasena)
        self.add_widget(boton)

    def validar_login(self, instance):
        mensaje = f"Bienvenido, {self.usuario.text}" if self.usuario.text else "Completa el campo"
        Popup(title="Aviso", content=Label(text=mensaje), size_hint=(0.6, 0.3)).open()

class LoginApp(App):
    def build(self):
        return LoginLayout()

LoginApp().run()
```

### Puntos clave para el aula

- La lógica (validar campos, decidir qué mostrar) es **la misma lógica de programación ya vista en Unidad 2** (condicionales, manejo de cadenas vacías); lo nuevo es solo cómo se conecta con la interfaz gráfica mediante eventos (`onClick`, `Clicked`, `bind`).
- Insistir en que **no es indispensable instalar Android Studio completo** para cumplir el objetivo de la unidad; puede trabajarse el concepto con Kivy (Python) por su instalación más ligera, y mostrar el código Java/C# como referencia comparativa de cómo luce en el ecosistema nativo.
- Mencionar el ciclo de vida básico de una pantalla móvil (se crea, se muestra, se destruye) como un concepto nuevo frente a un script de consola que corre una sola vez de principio a fin.

---

## 4.3 Creación de aplicaciones de escritorio simples

### Concepto

Una aplicación de escritorio se instala y corre directamente sobre el sistema operativo (Windows, macOS, Linux), sin necesidad de un navegador ni de conexión a internet. Se construyen con **bibliotecas de interfaz gráfica (GUI)** que, igual que en la web, separan la interfaz (ventanas, botones, campos de texto) de la lógica que reacciona a los eventos del usuario.

### El mismo caso — captura y muestra de datos — en tres bibliotecas de escritorio

**Python — Tkinter (incluida en la biblioteca estándar)**
```python
import tkinter as tk
from tkinter import messagebox

def guardar_datos():
    nombre = campo_nombre.get()
    if nombre == "":
        messagebox.showwarning("Aviso", "El nombre es obligatorio")
    else:
        messagebox.showinfo("Perfil", f"Datos guardados para {nombre}")

ventana = tk.Tk()
ventana.title("Registro de usuario")

tk.Label(ventana, text="Nombre:").pack(pady=5)
campo_nombre = tk.Entry(ventana)
campo_nombre.pack(pady=5)

tk.Button(ventana, text="Guardar", command=guardar_datos).pack(pady=10)
ventana.mainloop()
```

**C# — Windows Forms**
```csharp
public class FormularioRegistro : Form
{
    private TextBox campoNombre = new TextBox { Left = 20, Top = 20, Width = 200 };
    private Button botonGuardar = new Button { Text = "Guardar", Left = 20, Top = 60 };

    public FormularioRegistro()
    {
        Text = "Registro de usuario";
        Controls.Add(campoNombre);
        Controls.Add(botonGuardar);
        botonGuardar.Click += GuardarDatos;
    }

    private void GuardarDatos(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(campoNombre.Text))
            MessageBox.Show("El nombre es obligatorio", "Aviso");
        else
            MessageBox.Show($"Datos guardados para {campoNombre.Text}", "Perfil");
    }
}
```

**Java — JavaFX**
```java
public class FormularioRegistro extends Application {

    @Override
    public void start(Stage escenario) {
        TextField campoNombre = new TextField();
        Button botonGuardar = new Button("Guardar");

        botonGuardar.setOnAction(e -> {
            if (campoNombre.getText().isEmpty()) {
                new Alert(Alert.AlertType.WARNING, "El nombre es obligatorio").showAndWait();
            } else {
                new Alert(Alert.AlertType.INFORMATION,
                        "Datos guardados para " + campoNombre.getText()).showAndWait();
            }
        });

        VBox raiz = new VBox(10, new Label("Nombre:"), campoNombre, botonGuardar);
        escenario.setScene(new Scene(raiz, 250, 150));
        escenario.setTitle("Registro de usuario");
        escenario.show();
    }
}
```

### Puntos clave para el aula

- Las tres bibliotecas comparten el mismo **modelo de programación orientado a eventos**: se crean componentes (widgets/controles), se asocia una función/método a un evento (clic de botón) y un bucle principal (`mainloop`, el ciclo de eventos de Windows Forms, `Application.launch` en JavaFX) mantiene la ventana viva escuchando esos eventos.
- Tkinter es la opción más accesible para practicar en el aula porque **ya viene instalada con Python**, sin dependencias adicionales.
- Vincular explícitamente este contenido con la Unidad 2: la función `guardarDatos`/`GuardarDatos`/`validar_login` es, en esencia, el mismo tipo de validación con condicionales que ya se practicó — lo nuevo es la interfaz que la dispara.

---

## 4.4 Exploración de herramientas y frameworks para desarrollo de software

### Panorama de frameworks por tipo de aplicación

| Tipo de aplicación | Python | C# | Java |
|---|---|---|---|
| Web (backend) | Flask, Django | ASP.NET Core | Spring Boot |
| Móvil | Kivy, BeeWare | .NET MAUI | Android (nativo) |
| Escritorio | Tkinter, PyQt | Windows Forms, WPF | JavaFX, Swing |

### ¿Por qué usar un framework en vez de "programar desde cero"?

Un framework resuelve problemas recurrentes que **todas** las aplicaciones de un tipo comparten (enrutamiento HTTP, manejo de eventos de ventana, ciclo de vida de pantallas) para que el desarrollador se concentre en la lógica propia del problema. Esto conecta directamente con lo visto en la Unidad 3 sobre bibliotecas y módulos estándar: un framework es, en esencia, un conjunto de bibliotecas con una estructura y convenciones definidas.

### Criterios para elegir herramienta (para discutir en clase)

1. **Tipo de aplicación a construir** (web, móvil, escritorio) — no todos los frameworks sirven para todo.
2. **Curva de aprendizaje** frente al tiempo disponible del proyecto.
3. **Comunidad y documentación disponibles** — importante para un equipo que recién aprende.
4. **Compatibilidad con el resto del stack** (por ejemplo, si el backend ya está en Python, Flask es más natural que introducir C# solo para el frontend del servidor).
5. **Necesidades del proyecto integrador**: colaboración en tiempo real, múltiples usuarios, persistencia de datos.

### Entornos y control de versiones (repaso conectado con la Unidad 3)

Se recomienda reforzar en esta unidad el uso de un IDE (VS Code, PyCharm o Eclipse, según se vio en la Unidad 3) junto con control de versiones (Git) para organizar el código de una aplicación con múltiples archivos: rutas del backend, plantillas HTML, hojas de estilo y, en algunos casos, un archivo de configuración del framework.

---

## Tabla comparativa de plataformas y frameworks

| Aspecto | Web | Móvil | Escritorio |
|---|---|---|---|
| ¿Dónde corre? | Servidor + navegador | Directamente en el dispositivo | Directamente en el sistema operativo |
| ¿Necesita internet? | Generalmente sí | Depende de la app | No, por defecto |
| Lenguaje típico (backend) | Python, C#, Java, JavaScript | Java/Kotlin, Swift, C#, Python (Kivy) | Python, C#, Java |
| Interfaz | HTML/CSS renderizado por el navegador | Vistas nativas o multiplataforma | Widgets/controles del sistema operativo |
| Distribución | Una URL, sin instalación | Tienda de aplicaciones (Play Store, App Store) | Instalador o ejecutable |
| Ejemplo de framework | Flask, ASP.NET Core, Spring Boot | Android SDK, .NET MAUI, Kivy | Tkinter, Windows Forms, JavaFX |

---

## Conexión con la Práctica 4 del temario

La **Práctica 4: Desarrollo de una aplicación web básica** pide una aplicación que permita a los usuarios registrar sus datos personales y visualizarlos en una página de perfil, con los siguientes pasos:

1. **Introducción a desarrollo de aplicaciones web:** página de registro en HTML, estilizada con CSS — corresponde exactamente al formulario mostrado en la sección 4.1.
2. **Desarrollo de aplicaciones móviles (opcional):** adaptar la página con diseño responsivo — se puede conectar con la comparación de enfoques de la sección 4.2.
3. **Aplicaciones de escritorio simples (opcional):** empaquetar la aplicación como app de escritorio con un framework como Electron — mencionar como extensión, no como obligación.
4. **Exploración de herramientas y frameworks:** usar Flask (Python) o Spring Boot (Java) para manejar la lógica de backend y la persistencia de datos — corresponde a los ejemplos de servidor de la sección 4.1 y al panorama de la sección 4.4.

**Sugerencia de entrega:** código fuente de la aplicación web, capturas de pantalla en funcionamiento y documentación breve que explique diseño, implementación y pruebas realizadas, tal como lo pide el temario oficial.

---

## Conexión con el Proyecto integrador

El **Proyecto integrador de la asignatura** — una plataforma de gestión de tareas colaborativas — llega a su fase de **desarrollo** apoyándose directamente en los contenidos de esta unidad:

- La **interfaz de usuario** (HTML, CSS y JavaScript) se construye con los conceptos de la sección 4.1.
- La **lógica de negocio** (crear, asignar, editar, eliminar y organizar tareas) se implementa en Python o Java usando un framework web como los descritos en 4.1 y 4.4.
- La **persistencia de datos** (usuarios, proyectos y tareas) requiere integrar una base de datos, tema que se profundizará en materias posteriores pero que aquí se introduce a nivel conceptual.
- Las **funcionalidades de colaboración en tiempo real** son un buen punto para que los equipos investiguen de forma autónoma (aprendizaje autónomo, competencia genérica del curso).

---

## Rúbrica sugerida de evaluación de la unidad

| Criterio | Descripción | Ponderación sugerida |
|---|---|---|
| Comprensión conceptual | Distingue correctamente entre aplicaciones web, móviles y de escritorio, y su arquitectura básica | 20% |
| Implementación funcional | La aplicación (Práctica 4) registra y muestra los datos correctamente | 30% |
| Calidad del código | Organización de archivos, nombres claros, separación entre interfaz y lógica | 20% |
| Documentación | Explica diseño, implementación y pruebas realizadas | 15% |
| Participación y trabajo autónomo | Investigación de herramientas y frameworks adicionales, participación en clase | 15% |

---

*Documento preparado para la asignatura Fundamentos de Programación (IAD-2413), Ingeniería en Inteligencia Artificial, Instituto Tecnológico de Durango — TecNM.*
