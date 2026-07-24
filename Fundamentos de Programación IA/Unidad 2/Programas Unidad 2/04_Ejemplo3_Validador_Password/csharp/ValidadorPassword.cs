// Ejemplo 3 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Validador de contraseña segura.

using System;
using System.Linq;

class ValidadorPassword
{
    // Verifica que la contraseña tenga al menos 8 caracteres.
    static bool TieneLongitudMinima(string password) => password.Length >= 8;

    // Verifica que la contraseña tenga al menos una letra mayúscula.
    static bool TieneMayuscula(string password) => password.Any(char.IsUpper);

    // Verifica que la contraseña tenga al menos un dígito.
    static bool TieneDigito(string password) => password.Any(char.IsDigit);

    // Una contraseña es segura si cumple las tres reglas anteriores.
    static bool EsSegura(string password) =>
        TieneLongitudMinima(password) && TieneMayuscula(password) && TieneDigito(password);

    static void Main()
    {
        Console.Write("Escribe una contraseña: ");
        string password = Console.ReadLine();
        Console.WriteLine(EsSegura(password)
            ? "Contraseña segura"
            : "Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito");
    }
}
