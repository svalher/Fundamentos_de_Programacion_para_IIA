// Ejercicio 3 de práctica — Unidad 2 (IAD-2413)
// La palabra más larga de una lista.
//
// Enunciado: lee una lista de palabras y determina cuál es la palabra
// más larga. Si hay un empate, se debe mostrar la primera que apareció.
//
// Pista: este problema es un "primo" del Ejemplo 2 (máxima y mínima
// temperatura) — el mismo patrón de comparación aplica aquí.
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar el método PalabraMasLarga().

using System;
using System.Collections.Generic;

class PalabraMasLarga
{
    static string EncontrarPalabraMasLarga(List<string> palabras)
    {
        // TODO 1: inicializa tu resultado con la primera palabra de la lista.
        // TODO 2: recorre el resto comparando longitudes (palabra.Length).
        // TODO 3: decide la condición para que, en caso de empate, se
        //         conserve la primera palabra que apareció.
        throw new NotImplementedException("Implementa EncontrarPalabraMasLarga()");
    }

    static void Main()
    {
        Console.Write("¿Cuántas palabras vas a capturar? ");
        int n = int.Parse(Console.ReadLine());

        List<string> palabras = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Palabra {i + 1}: ");
            palabras.Add(Console.ReadLine());
        }

        Console.WriteLine("La palabra más larga es: " + EncontrarPalabraMasLarga(palabras));
    }
}
