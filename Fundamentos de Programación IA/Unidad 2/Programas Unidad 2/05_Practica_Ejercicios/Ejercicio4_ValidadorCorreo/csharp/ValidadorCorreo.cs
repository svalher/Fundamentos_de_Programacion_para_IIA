// Ejercicio 4 de práctica — Unidad 2 (IAD-2413)
// Validador de correo electrónico simple.
//
// Enunciado: determina, con reglas simples, si una cadena *parece* un
// correo electrónico válido: exactamente un "@", al menos un carácter
// antes del "@", y al menos un "." después del "@".
//
// Pista: este ejercicio es un "primo" del Ejemplo 3 (validador de
// contraseña) — usa el mismo enfoque de funciones booleanas pequeñas.
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar los métodos de abajo.

using System;

class ValidadorCorreo
{
    static bool TieneUnaArroba(string correo)
    {
        // TODO: cuenta cuántas veces aparece '@' y compara contra 1.
        throw new NotImplementedException("Implementa TieneUnaArroba()");
    }

    static bool TieneTextoAntesDeArroba(string correo)
    {
        // TODO: encuentra la posición de '@' (correo.IndexOf('@')) y
        //       evalúa si hay texto antes de esa posición.
        throw new NotImplementedException("Implementa TieneTextoAntesDeArroba()");
    }

    static bool TienePuntoDespuesDeArroba(string correo)
    {
        // TODO: encuentra la posición de '@' y busca un '.' después.
        throw new NotImplementedException("Implementa TienePuntoDespuesDeArroba()");
    }

    static bool PareceValido(string correo)
    {
        // TODO: combina las tres funciones anteriores con &&.
        throw new NotImplementedException("Implementa PareceValido()");
    }

    static void Main()
    {
        Console.Write("Escribe un correo electrónico: ");
        string correo = Console.ReadLine();
        Console.WriteLine(PareceValido(correo) ? "Parece un correo válido" : "No parece un correo válido");
    }
}
