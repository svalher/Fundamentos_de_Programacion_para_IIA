/*
 * Práctica 1 - Calculadora básica
 * Fundamentos de Programación (IAD-2413)
 * Instituto Tecnológico de Durango (TecNM)
 *
 * Lenguaje: Java
 * Compilar y ejecutar:
 *   javac Calculadora.java
 *   java Calculadora
 */

import java.util.Scanner;

public class Calculadora {

    // -------------------------------------------------
    // Funciones y métodos: uno por operación
    // -------------------------------------------------
    static double sumar(double a, double b) {
        return a + b;
    }

    static double restar(double a, double b) {
        return a - b;
    }

    static double multiplicar(double a, double b) {
        return a * b;
    }

    static Double dividir(double a, double b) {
        // Manejo de errores: división entre cero
        if (b == 0) {
            System.out.println("Error: no se puede dividir entre cero.");
            return null;
        }
        return a / b;
    }

    static double leerNumero(Scanner sc, String mensaje) {
        System.out.print(mensaje);
        while (!sc.hasNextDouble()) {
            sc.next(); // descarta la entrada inválida
            System.out.print("Entrada inválida. Introduce un número: ");
        }
        return sc.nextDouble();
    }

    static void mostrarMenu() {
        System.out.println("\n===== CALCULADORA BÁSICA (Java) =====");
        System.out.println("1. Sumar");
        System.out.println("2. Restar");
        System.out.println("3. Multiplicar");
        System.out.println("4. Dividir");
        System.out.println("5. Salir");
    }

    // -------------------------------------------------
    // Programa principal
    // Estructuras de control: condicionales (if-else) y bucle (while)
    // -------------------------------------------------
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        boolean continuar = true;

        while (continuar) {
            mostrarMenu();
            System.out.print("Selecciona una opción (1-5): ");
            String opcion = sc.next();

            if (opcion.equals("5")) {
                System.out.println("Fin del programa. ¡Hasta luego!");
                continuar = false;
            } else if (opcion.equals("1") || opcion.equals("2")
                    || opcion.equals("3") || opcion.equals("4")) {

                double a = leerNumero(sc, "Introduce el primer número: ");
                double b = leerNumero(sc, "Introduce el segundo número: ");

                Double resultado;
                String simbolo;

                if (opcion.equals("1")) {
                    resultado = sumar(a, b);
                    simbolo = "+";
                } else if (opcion.equals("2")) {
                    resultado = restar(a, b);
                    simbolo = "-";
                } else if (opcion.equals("3")) {
                    resultado = multiplicar(a, b);
                    simbolo = "*";
                } else { // opcion.equals("4")
                    resultado = dividir(a, b);
                    simbolo = "/";
                }

                if (resultado != null) {
                    System.out.println("\nResultado: " + a + " " + simbolo
                            + " " + b + " = " + resultado);
                }
            } else {
                System.out.println("Opción no válida. Intenta de nuevo.");
            }
        }

        sc.close();
    }
}
