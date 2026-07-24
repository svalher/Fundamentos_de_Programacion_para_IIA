// Ejercicio 5 de práctica — Unidad 2 (IAD-2413)
// Clasificador de temperatura corporal.
//
// Enunciado: clasifica una temperatura corporal (°C) según:
//   Menor a 35.0  -> "Hipotermia"
//   35.0 a 37.5   -> "Normal"
//   37.6 a 39.0   -> "Fiebre"
//   Mayor a 39.0  -> "Fiebre alta"
//
// Presta atención a los límites exactos (35.0, 37.5, 39.0).
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar el método ClasificarTemperatura().

using System;

class ClasificadorTemperatura
{
    static string ClasificarTemperatura(double temperatura)
    {
        // TODO 1: decide qué pasa con valores imposibles (negativos, > 45°C).
        // TODO 2: implementa las 4 categorías con if / else if / else,
        //         cuidando los límites exactos de cada rango.
        throw new NotImplementedException("Implementa ClasificarTemperatura()");
    }

    static void Main()
    {
        Console.Write("Temperatura corporal (°C): ");
        double temperatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Categoría: " + ClasificarTemperatura(temperatura));
    }
}
