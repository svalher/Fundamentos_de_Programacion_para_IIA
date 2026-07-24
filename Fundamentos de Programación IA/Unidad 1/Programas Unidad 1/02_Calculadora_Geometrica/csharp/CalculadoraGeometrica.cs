/*
 * Práctica complementaria - Calculadora geométrica
 * Fundamentos de Programación (IAD-2413)
 * Instituto Tecnológico de Durango (TecNM)
 *
 * Calcula el área de distintas figuras geométricas:
 * círculo, cuadrado, rectángulo, triángulo, rombo,
 * trapecio y pentágono regular.
 *
 * Lenguaje: C#
 * Compilar y ejecutar (SDK de .NET):
 *   dotnet run
 * o bien, con csc:
 *   csc CalculadoraGeometrica.cs && CalculadoraGeometrica.exe
 */

using System;

class CalculadoraGeometrica
{
    // -------------------------------------------------
    // Funciones y métodos: uno por figura geométrica
    // -------------------------------------------------
    static double AreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    static double AreaCuadrado(double lado)
    {
        return Math.Pow(lado, 2);
    }

    static double AreaRectangulo(double baseR, double altura)
    {
        return baseR * altura;
    }

    static double AreaTriangulo(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }

    static double AreaRombo(double diagonalMayor, double diagonalMenor)
    {
        return (diagonalMayor * diagonalMenor) / 2;
    }

    static double AreaTrapecio(double baseMayor, double baseMenor, double altura)
    {
        return ((baseMayor + baseMenor) * altura) / 2;
    }

    static double AreaPentagono(double lado)
    {
        // Área de un pentágono regular a partir de su lado
        return (5 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 5));
    }

    // -------------------------------------------------
    // Entrada de datos con validación
    // -------------------------------------------------
    static double LeerNumero(string mensaje)
    {
        double valor;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out valor))
            {
                if (valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("El valor debe ser mayor que cero.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Introduce un número.");
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== CALCULADORA GEOMÉTRICA (C#) =====");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Cuadrado");
        Console.WriteLine("3. Rectángulo");
        Console.WriteLine("4. Triángulo");
        Console.WriteLine("5. Rombo");
        Console.WriteLine("6. Trapecio");
        Console.WriteLine("7. Pentágono regular");
        Console.WriteLine("8. Salir");
    }

    // -------------------------------------------------
    // Programa principal
    // Estructuras de control: condicionales (if-else if) y bucle (while)
    // -------------------------------------------------
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            Console.Write("Selecciona una figura (1-8): ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                double r = LeerNumero("Radio: ");
                Console.WriteLine($"\nÁrea del círculo = {AreaCirculo(r):F2}");
            }
            else if (opcion == "2")
            {
                double lado = LeerNumero("Lado: ");
                Console.WriteLine($"\nÁrea del cuadrado = {AreaCuadrado(lado):F2}");
            }
            else if (opcion == "3")
            {
                double baseR = LeerNumero("Base: ");
                double altura = LeerNumero("Altura: ");
                Console.WriteLine($"\nÁrea del rectángulo = {AreaRectangulo(baseR, altura):F2}");
            }
            else if (opcion == "4")
            {
                double baseT = LeerNumero("Base: ");
                double altura = LeerNumero("Altura: ");
                Console.WriteLine($"\nÁrea del triángulo = {AreaTriangulo(baseT, altura):F2}");
            }
            else if (opcion == "5")
            {
                double dMayor = LeerNumero("Diagonal mayor: ");
                double dMenor = LeerNumero("Diagonal menor: ");
                Console.WriteLine($"\nÁrea del rombo = {AreaRombo(dMayor, dMenor):F2}");
            }
            else if (opcion == "6")
            {
                double bMayor = LeerNumero("Base mayor: ");
                double bMenor = LeerNumero("Base menor: ");
                double altura = LeerNumero("Altura: ");
                Console.WriteLine($"\nÁrea del trapecio = {AreaTrapecio(bMayor, bMenor, altura):F2}");
            }
            else if (opcion == "7")
            {
                double lado = LeerNumero("Lado: ");
                Console.WriteLine($"\nÁrea del pentágono regular = {AreaPentagono(lado):F2}");
            }
            else if (opcion == "8")
            {
                Console.WriteLine("Fin del programa. ¡Hasta luego!");
                continuar = false;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
            }
        }
    }
}
