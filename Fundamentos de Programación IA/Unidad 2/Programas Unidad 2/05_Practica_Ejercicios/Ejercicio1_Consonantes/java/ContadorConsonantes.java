// Ejercicio 1 de práctica — Unidad 2 (IAD-2413)
// Contador de consonantes en una frase.
//
// Enunciado: lee una frase y cuenta cuántas consonantes contiene (cualquier
// letra que no sea vocal ni espacio ni signo de puntuación), sin importar
// mayúsculas o minúsculas.
//
// Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
// (2.1 a 2.7) antes de completar el método contarConsonantes().

import java.util.Scanner;

public class ContadorConsonantes {

    static int contarConsonantes(String frase) {
        // TODO 1: define qué caracteres son vocales.
        // TODO 2: recorre la frase en minúsculas (frase.toLowerCase()).
        // TODO 3: decide si cada carácter es una letra y si NO es vocal.
        // TODO 4: cuenta y regresa el resultado.
        throw new UnsupportedOperationException("Implementa contarConsonantes()");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe una frase: ");
        String frase = sc.nextLine();
        System.out.println("Consonantes encontradas: " + contarConsonantes(frase));
    }
}
