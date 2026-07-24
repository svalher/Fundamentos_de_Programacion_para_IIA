// Ejemplo 1 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Contador de vocales en una palabra o frase.

using System;

class ContadorVocales
{
    /// <summary>Cuenta cuántas vocales (a, e, i, o, u) contiene una palabra.</summary>
    static int ContarVocales(string palabra)
    {
        string vocales = "aeiou";
        int contador = 0;
        foreach (char letra in palabra.ToLower())
        {
            if (vocales.Contains(letra)) contador++;
        }
        return contador;
    }

    static void Main()
    {
        Console.Write("Escribe una palabra: ");
        string palabra = Console.ReadLine();
        Console.WriteLine("Vocales encontradas: " + ContarVocales(palabra));
    }
}
