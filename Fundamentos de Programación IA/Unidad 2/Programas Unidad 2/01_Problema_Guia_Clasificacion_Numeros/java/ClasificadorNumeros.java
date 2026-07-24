// Problema guía de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Clasificador de números en positivos, negativos y ceros.

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ClasificadorNumeros {

    // Lee n números capturados por el usuario.
    static List<Double> capturarNumeros(int n, Scanner sc) {
        List<Double> numeros = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            System.out.print("Número " + (i + 1) + ": ");
            double valor = Double.parseDouble(sc.nextLine());
            numeros.add(valor);
        }
        return numeros;
    }

    // Clasifica una lista de números en positivos, negativos y ceros.
    static int[] clasificar(List<Double> numeros) {
        int positivos = 0, negativos = 0, ceros = 0;
        for (double numero : numeros) {
            if (numero > 0) positivos++;
            else if (numero < 0) negativos++;
            else ceros++;
        }
        return new int[] { positivos, negativos, ceros };
    }

    // Imprime el resumen final de la clasificación.
    static void mostrarResumen(int positivos, int negativos, int ceros) {
        System.out.println("Positivos: " + positivos);
        System.out.println("Negativos: " + negativos);
        System.out.println("Ceros: " + ceros);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("¿Cuántos números vas a capturar? ");
        int n = Integer.parseInt(sc.nextLine());

        List<Double> numeros = capturarNumeros(n, sc);
        int[] resultado = clasificar(numeros);
        mostrarResumen(resultado[0], resultado[1], resultado[2]);
    }
}
