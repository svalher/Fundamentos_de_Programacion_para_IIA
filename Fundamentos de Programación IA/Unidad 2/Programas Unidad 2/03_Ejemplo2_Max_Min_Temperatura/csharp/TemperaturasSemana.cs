// Ejemplo 2 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Temperatura máxima y mínima de la semana.

using System;
using System.Collections.Generic;

class TemperaturasSemana
{
    /// <summary>Calcula el valor máximo y mínimo de una lista de temperaturas.</summary>
    static (double max, double min) CalcularMaxMin(List<double> temperaturas)
    {
        double max = temperaturas[0];
        double min = temperaturas[0];
        for (int i = 1; i < temperaturas.Count; i++)
        {
            if (temperaturas[i] > max) max = temperaturas[i];
            if (temperaturas[i] < min) min = temperaturas[i];
        }
        return (max, min);
    }

    static void Main()
    {
        List<double> temperaturas = new List<double>();
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Temperatura día {i + 1}: ");
            temperaturas.Add(double.Parse(Console.ReadLine()));
        }

        var (max, min) = CalcularMaxMin(temperaturas);
        Console.WriteLine("Máxima: " + max);
        Console.WriteLine("Mínima: " + min);
    }
}
