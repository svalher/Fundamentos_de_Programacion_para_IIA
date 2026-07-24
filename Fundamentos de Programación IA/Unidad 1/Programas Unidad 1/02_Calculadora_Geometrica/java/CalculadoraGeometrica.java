/*
 * Práctica complementaria - Calculadora geométrica
 * Fundamentos de Programación (IAD-2413)
 * Instituto Tecnológico de Durango (TecNM)
 *
 * Calcula el área de distintas figuras geométricas:
 * círculo, cuadrado, rectángulo, triángulo, rombo,
 * trapecio y pentágono regular.
 *
 * Lenguaje: Java
 * Compilar y ejecutar:
 *   javac CalculadoraGeometrica.java
 *   java CalculadoraGeometrica
 */

import java.util.Scanner;

public class CalculadoraGeometrica {

    // -------------------------------------------------
    // Funciones y métodos: uno por figura geométrica
    // -------------------------------------------------
    static double areaCirculo(double radio) {
        return Math.PI * Math.pow(radio, 2);
    }

    static double areaCuadrado(double lado) {
        return Math.pow(lado, 2);
    }

    static double areaRectangulo(double base, double altura) {
        return base * altura;
    }

    static double areaTriangulo(double base, double altura) {
        return (base * altura) / 2;
    }

    static double areaRombo(double diagonalMayor, double diagonalMenor) {
        return (diagonalMayor * diagonalMenor) / 2;
    }

    static double areaTrapecio(double baseMayor, double baseMenor, double altura) {
        return ((baseMayor + baseMenor) * altura) / 2;
    }

    static double areaPentagono(double lado) {
        // Área de un pentágono regular a partir de su lado
        return (5 * Math.pow(lado, 2)) / (4 * Math.tan(Math.PI / 5));
    }

    // -------------------------------------------------
    // Entrada de datos con validación
    // -------------------------------------------------
    static double leerNumero(Scanner sc, String mensaje) {
        double valor;
        while (true) {
            System.out.print(mensaje);
            while (!sc.hasNextDouble()) {
                sc.next();
                System.out.println("Entrada inválida. Introduce un número.");
                System.out.print(mensaje);
            }
            valor = sc.nextDouble();
            if (valor > 0) {
                return valor;
            }
            System.out.println("El valor debe ser mayor que cero.");
        }
    }

    static void mostrarMenu() {
        System.out.println("\n===== CALCULADORA GEOMÉTRICA (Java) =====");
        System.out.println("1. Círculo");
        System.out.println("2. Cuadrado");
        System.out.println("3. Rectángulo");
        System.out.println("4. Triángulo");
        System.out.println("5. Rombo");
        System.out.println("6. Trapecio");
        System.out.println("7. Pentágono regular");
        System.out.println("8. Salir");
    }

    // -------------------------------------------------
    // Programa principal
    // Estructuras de control: condicionales (if-else if) y bucle (while)
    // -------------------------------------------------
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        boolean continuar = true;

        while (continuar) {
            mostrarMenu();
            System.out.print("Selecciona una figura (1-8): ");
            String opcion = sc.next();

            if (opcion.equals("1")) {
                double r = leerNumero(sc, "Radio: ");
                System.out.printf("%nÁrea del círculo = %.2f%n", areaCirculo(r));

            } else if (opcion.equals("2")) {
                double lado = leerNumero(sc, "Lado: ");
                System.out.printf("%nÁrea del cuadrado = %.2f%n", areaCuadrado(lado));

            } else if (opcion.equals("3")) {
                double base = leerNumero(sc, "Base: ");
                double altura = leerNumero(sc, "Altura: ");
                System.out.printf("%nÁrea del rectángulo = %.2f%n", areaRectangulo(base, altura));

            } else if (opcion.equals("4")) {
                double base = leerNumero(sc, "Base: ");
                double altura = leerNumero(sc, "Altura: ");
                System.out.printf("%nÁrea del triángulo = %.2f%n", areaTriangulo(base, altura));

            } else if (opcion.equals("5")) {
                double dMayor = leerNumero(sc, "Diagonal mayor: ");
                double dMenor = leerNumero(sc, "Diagonal menor: ");
                System.out.printf("%nÁrea del rombo = %.2f%n", areaRombo(dMayor, dMenor));

            } else if (opcion.equals("6")) {
                double bMayor = leerNumero(sc, "Base mayor: ");
                double bMenor = leerNumero(sc, "Base menor: ");
                double altura = leerNumero(sc, "Altura: ");
                System.out.printf("%nÁrea del trapecio = %.2f%n", areaTrapecio(bMayor, bMenor, altura));

            } else if (opcion.equals("7")) {
                double lado = leerNumero(sc, "Lado: ");
                System.out.printf("%nÁrea del pentágono regular = %.2f%n", areaPentagono(lado));

            } else if (opcion.equals("8")) {
                System.out.println("Fin del programa. ¡Hasta luego!");
                continuar = false;

            } else {
                System.out.println("Opción no válida. Intenta de nuevo.");
            }
        }

        sc.close();
    }
}
