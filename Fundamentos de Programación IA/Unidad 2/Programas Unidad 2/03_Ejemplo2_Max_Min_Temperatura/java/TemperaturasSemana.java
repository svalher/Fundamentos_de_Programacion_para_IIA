// Ejemplo 2 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Temperatura máxima y mínima de la semana.

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class TemperaturasSemana {

    // Calcula el valor máximo y mínimo de una lista de temperaturas.
    static double[] calcularMaxMin(List<Double> temperaturas) {
        double max = temperaturas.get(0);
        double min = temperaturas.get(0);
        for (int i = 1; i < temperaturas.size(); i++) {
            double t = temperaturas.get(i);
            if (t > max) max = t;
            if (t < min) min = t;
        }
        return new double[] { max, min };
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Double> temperaturas = new ArrayList<>();
        for (int i = 0; i < 7; i++) {
            System.out.print("Temperatura día " + (i + 1) + ": ");
            temperaturas.add(Double.parseDouble(sc.nextLine()));
        }

        double[] resultado = calcularMaxMin(temperaturas);
        System.out.println("Máxima: " + resultado[0]);
        System.out.println("Mínima: " + resultado[1]);
    }
}
