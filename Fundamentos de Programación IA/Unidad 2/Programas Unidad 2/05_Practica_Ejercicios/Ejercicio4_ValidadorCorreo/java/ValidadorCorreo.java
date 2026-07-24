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

import java.util.Scanner;

public class ValidadorCorreo {

    static boolean tieneUnaArroba(String correo) {
        // TODO: cuenta cuántas veces aparece '@' y compara contra 1.
        throw new UnsupportedOperationException("Implementa tieneUnaArroba()");
    }

    static boolean tieneTextoAntesDeArroba(String correo) {
        // TODO: encuentra la posición de '@' (correo.indexOf('@')) y
        //       evalúa si hay texto antes de esa posición.
        throw new UnsupportedOperationException("Implementa tieneTextoAntesDeArroba()");
    }

    static boolean tienePuntoDespuesDeArroba(String correo) {
        // TODO: encuentra la posición de '@' y busca un '.' después.
        throw new UnsupportedOperationException("Implementa tienePuntoDespuesDeArroba()");
    }

    static boolean pareceValido(String correo) {
        // TODO: combina las tres funciones anteriores con &&.
        throw new UnsupportedOperationException("Implementa pareceValido()");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe un correo electrónico: ");
        String correo = sc.nextLine();
        System.out.println(pareceValido(correo) ? "Parece un correo válido" : "No parece un correo válido");
    }
}
