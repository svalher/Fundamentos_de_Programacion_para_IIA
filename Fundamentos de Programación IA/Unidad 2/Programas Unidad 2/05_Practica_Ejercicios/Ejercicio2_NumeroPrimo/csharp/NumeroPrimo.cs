// Ejercicio 2 de práctica — Unidad 2 (IAD-2413)
// Verificar si un número es primo.
//
// Enunciado: lee un número entero positivo y determina si es primo (un
// número primo solo es divisible entre 1 y entre sí mismo).
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar el método EsPrimo().

using System;

class NumeroPrimo
{
    static bool EsPrimo(int numero)
    {
        // TODO 1: decide qué hacer con 0, 1 y los números negativos.
        // TODO 2: recorre los posibles divisores desde 2 hasta donde
        //         consideres necesario.
        // TODO 3: si encuentras un divisor exacto, el número NO es primo.
        // TODO 4: si no encontraste ninguno, el número SÍ es primo.
        throw new NotImplementedException("Implementa EsPrimo()");
    }

    static void Main()
    {
        Console.Write("Escribe un número entero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(numero + (EsPrimo(numero) ? " es primo" : " no es primo"));
    }
}
