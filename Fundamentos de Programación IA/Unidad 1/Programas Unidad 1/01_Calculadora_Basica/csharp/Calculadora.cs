/*
 * Práctica 1 - Calculadora básica
 * Fundamentos de Programación (IAD-2413)
 * Instituto Tecnológico de Durango (TecNM)
 *
 * Lenguaje: C#
 * Compilar y ejecutar (SDK de .NET):
 *   dotnet run
 * o bien, con csc:
 *   csc Calculadora.cs && Calculadora.exe
 */

using System;

class Calculadora
{
    // -------------------------------------------------
    // Funciones y métodos: uno por operación
    // -------------------------------------------------
    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double? Dividir(double a, double b)
    {
        // Manejo de errores: división entre cero
        if (b == 0)
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
            return null;
        }
        return a / b;
    }

    static double LeerNumero(string mensaje)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Entrada inválida. Introduce un número: ");
        }
        return valor;
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== CALCULADORA BÁSICA (C#) =====");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
    }

    // -------------------------------------------------
    // Programa principal
    // Estructuras de control: condicionales (if-else) y bucle (while)
    // -------------------------------------------------
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            Console.Write("Selecciona una opción (1-5): ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Fin del programa. ¡Hasta luego!");
                continuar = false;
            }
            else if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
            {
                double a = LeerNumero("Introduce el primer número: ");
                double b = LeerNumero("Introduce el segundo número: ");

                double? resultado;
                string simbolo;

                if (opcion == "1")
                {
                    resultado = Sumar(a, b);
                    simbolo = "+";
                }
                else if (opcion == "2")
                {
                    resultado = Restar(a, b);
                    simbolo = "-";
                }
                else if (opcion == "3")
                {
                    resultado = Multiplicar(a, b);
                    simbolo = "*";
                }
                else // opcion == "4"
                {
                    resultado = Dividir(a, b);
                    simbolo = "/";
                }

                if (resultado != null)
                {
                    Console.WriteLine($"\nResultado: {a} {simbolo} {b} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
            }
        }
    }
}
