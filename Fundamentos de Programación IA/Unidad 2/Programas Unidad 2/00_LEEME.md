# Unidad 2 — Códigos fuente (IAD-2413)
### Fundamentos de Programación · Instituto Tecnológico de Durango · TecNM

Esta carpeta contiene todo el código de la Unidad 2, listo para abrir en **Visual Studio Code**.

## Estructura

```
Unidad2_Codigos/
├── 01_Problema_Guia_Clasificacion_Numeros/   → resuelto (Python, C#, Java)
├── 02_Ejemplo1_Contador_Vocales/             → resuelto (Python, C#, Java)
├── 03_Ejemplo2_Max_Min_Temperatura/          → resuelto (Python, C#, Java)
├── 04_Ejemplo3_Validador_Password/           → resuelto (Python, C#, Java)
└── 05_Practica_Ejercicios/                   → PLANTILLAS sin resolver (5 ejercicios)
```

Cada carpeta de ejemplo tiene tres subcarpetas (`python/`, `csharp/`, `java/`) con el mismo
programa implementado en los tres lenguajes del curso.

Las plantillas de `05_Practica_Ejercicios` **no están resueltas a propósito**: tienen la
estructura y los comentarios `// TODO` / `# TODO` que debes completar aplicando la
metodología de la Unidad 2 (2.1 a 2.7), tal como se explicó en clase.

## Cómo abrir el proyecto en VS Code

1. Descomprime este archivo `.zip` en tu computadora.
2. Abre VS Code → **File / Archivo → Open Folder... → Abrir carpeta...**
3. Selecciona la carpeta `Unidad2_Codigos`.

## Cómo ejecutar cada lenguaje

### Python
Requiere la extensión **Python** de Microsoft en VS Code.
```bash
python nombre_del_archivo.py
```
o usa el botón ▶ "Run Python File" en la esquina superior derecha del editor.

### C#
Requiere tener instalado el **.NET SDK** y, opcionalmente, la extensión **C# Dev Kit**.
Cada archivo `.cs` es independiente; para ejecutarlo dentro de un proyecto de consola:
```bash
dotnet new console -o MiProyecto
# copia el contenido del .cs dentro de MiProyecto/Program.cs
cd MiProyecto
dotnet run
```

### Java
Requiere el **JDK** instalado y, opcionalmente, la extensión **Extension Pack for Java**.
```bash
javac NombreDelArchivo.java
java NombreDelArchivo
```
(El nombre del archivo debe coincidir exactamente con el nombre de la clase `public class`.)

## Recordatorio de la metodología (Unidad 2)

| Paso | Qué hacer |
|---|---|
| 2.1 | Analiza el problema: qué entra, qué sale, restricciones, casos especiales, cómo verificar |
| 2.2 | Compara al menos dos enfoques antes de programar |
| 2.3 | Escribe el pseudocódigo de tu solución |
| 2.4 | Implementa el código siguiendo exactamente tu diseño |
| 2.5 | Prueba tu programa con casos normales, límite y de error |
| 2.6 | Usa nombres descriptivos y documenta cada función |
| 2.7 | Reconoce en qué otro problema podrías reutilizar el mismo patrón |
