// Ejemplo 3 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
// Validador de contraseña segura.

import java.util.Scanner;

public class ValidadorPassword {

    // Verifica que la contraseña tenga al menos 8 caracteres.
    static boolean tieneLongitudMinima(String password) {
        return password.length() >= 8;
    }

    // Verifica que la contraseña tenga al menos una letra mayúscula.
    static boolean tieneMayuscula(String password) {
        for (char c : password.toCharArray()) {
            if (Character.isUpperCase(c)) return true;
        }
        return false;
    }

    // Verifica que la contraseña tenga al menos un dígito.
    static boolean tieneDigito(String password) {
        for (char c : password.toCharArray()) {
            if (Character.isDigit(c)) return true;
        }
        return false;
    }

    // Una contraseña es segura si cumple las tres reglas anteriores.
    static boolean esSegura(String password) {
        return tieneLongitudMinima(password) && tieneMayuscula(password) && tieneDigito(password);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Escribe una contraseña: ");
        String password = sc.nextLine();
        System.out.println(esSegura(password)
            ? "Contraseña segura"
            : "Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito");
    }
}
