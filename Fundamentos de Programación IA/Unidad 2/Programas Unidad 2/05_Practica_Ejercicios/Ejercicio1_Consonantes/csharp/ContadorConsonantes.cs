// Ejercicio 1 de práctica — Unidad 2 (IAD-2413)
// Contador de consonantes en una frase.
//
// Enunciado: lee una frase y cuenta cuántas consonantes contiene (cualquier
// letra que no sea vocal ni espacio ni signo de puntuación), sin importar
// mayúsculas o minúsculas.
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar el método ContarConsonantes().

using System;

class ContadorConsonantes
{
    static int ContarConsonantes(string frase)
    {
        // TODO 1: define qué caracteres son vocales.
        // TODO 2: recorre la frase en minúsculas (frase.ToLower()).
        // TODO 3: decide si cada carácter es una letra y si NO es vocal.
        // TODO 4: cuenta y regresa el resultado.
        throw new NotImplementedException("Implementa ContarConsonantes()");
    }

    static void Main()
    {
        Console.Write("Escribe una frase: ");
        string frase = Console.ReadLine();
        Console.WriteLine("Consonantes encontradas: " + ContarConsonantes(frase));
    }
}
