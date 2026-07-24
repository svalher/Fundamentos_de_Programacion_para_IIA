// Problema guía de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Clasificador de números en positivos, negativos y ceros.

using System;
using System.Collections.Generic;

class ClasificadorNumeros
{
    /// <summary>Lee n números capturados por el usuario.</summary>
    static List<double> CapturarNumeros(int n)
    {
        List<double> numeros = new List<double>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            double valor = double.Parse(Console.ReadLine());
            numeros.Add(valor);
        }
        return numeros;
    }

    /// <summary>Clasifica una lista de números en positivos, negativos y ceros.</summary>
    static (int positivos, int negativos, int ceros) Clasificar(List<double> numeros)
    {
        int positivos = 0, negativos = 0, ceros = 0;
        foreach (double numero in numeros)
        {
            if (numero > 0) positivos++;
            else if (numero < 0) negativos++;
            else ceros++;
        }
        return (positivos, negativos, ceros);
    }

    /// <summary>Imprime el resumen final de la clasificación.</summary>
    static void MostrarResumen(int positivos, int negativos, int ceros)
    {
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);
    }

    static void Main()
    {
        Console.Write("¿Cuántos números vas a capturar? ");
        int n = int.Parse(Console.ReadLine());

        List<double> numeros = CapturarNumeros(n);
        var (positivos, negativos, ceros) = Clasificar(numeros);
        MostrarResumen(positivos, negativos, ceros);
    }
}
