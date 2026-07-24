// Ejemplo 1 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Contador de vocales en una palabra o frase.

import java.util.Scanner;

public class ContadorVocales {

    // Cuenta cuántas vocales (a, e, i, o, u) contiene una palabra.
    static int contarVocales(String palabra) {
        String vocales = "aeiou";
        int contador = 0;
        for (char letra : palabra.toLowerCase().toCharArray()) {
            if (vocales.indexOf(letra) >= 0) contador++;
        }
        return contador;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe una palabra: ");
        String palabra = sc.nextLine();
        System.out.println("Vocales encontradas: " + contarVocales(palabra));
    }
}
