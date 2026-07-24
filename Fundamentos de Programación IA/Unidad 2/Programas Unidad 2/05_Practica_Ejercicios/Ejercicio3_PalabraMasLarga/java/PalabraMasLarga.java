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
// (2.1 a 2.7) antes de completar el método encontrarPalabraMasLarga().

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class PalabraMasLarga {

    static String encontrarPalabraMasLarga(List<String> palabras) {
        // TODO 1: inicializa tu resultado con la primera palabra de la lista.
        // TODO 2: recorre el resto comparando longitudes (palabra.length()).
        // TODO 3: decide la condición para que, en caso de empate, se
        //         conserve la primera palabra que apareció.
        throw new UnsupportedOperationException("Implementa encontrarPalabraMasLarga()");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("¿Cuántas palabras vas a capturar? ");
        int n = Integer.parseInt(sc.nextLine());

        List<String> palabras = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            System.out.print("Palabra " + (i + 1) + ": ");
            palabras.add(sc.nextLine());
        }

        System.out.println("La palabra más larga es: " + encontrarPalabraMasLarga(palabras));
    }
}
