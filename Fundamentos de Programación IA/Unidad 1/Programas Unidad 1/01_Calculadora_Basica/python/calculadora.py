"""
Práctica 1 - Calculadora básica
Fundamentos de Programación (IAD-2413)
Instituto Tecnológico de Durango (TecNM)

Lenguaje: Python
"""


# ---------------------------------------------------------
# Funciones y métodos: una función por operación
# ---------------------------------------------------------
def sumar(a, b):
    return a + b


def restar(a, b):
    return a - b


def multiplicar(a, b):
    return a * b


def dividir(a, b):
    # Manejo de errores: división entre cero
    if b == 0:
        print("Error: no se puede dividir entre cero.")
        return None
    return a / b


def leer_numero(mensaje):
    """Solicita un número al usuario y valida que sea válido."""
    while True:
        try:
            return float(input(mensaje))
        except ValueError:
            print("Entrada inválida. Introduce un número.")


def mostrar_menu():
    print("\n===== CALCULADORA BÁSICA (Python) =====")
    print("1. Sumar")
    print("2. Restar")
    print("3. Multiplicar")
    print("4. Dividir")
    print("5. Salir")


# ---------------------------------------------------------
# Programa principal
# Estructuras de control: condicionales (if-else) y bucle (while)
# ---------------------------------------------------------
def main():
    continuar = True

    while continuar:
        mostrar_menu()
        opcion = input("Selecciona una opción (1-5): ")

        if opcion == "5":
            print("Fin del programa. ¡Hasta luego!")
            continuar = False
        elif opcion in ("1", "2", "3", "4"):
            a = leer_numero("Introduce el primer número: ")
            b = leer_numero("Introduce el segundo número: ")

            if opcion == "1":
                resultado = sumar(a, b)
                simbolo = "+"
            elif opcion == "2":
                resultado = restar(a, b)
                simbolo = "-"
            elif opcion == "3":
                resultado = multiplicar(a, b)
                simbolo = "*"
            else:  # opcion == "4"
                resultado = dividir(a, b)
                simbolo = "/"

            if resultado is not None:
                print(f"\nResultado: {a} {simbolo} {b} = {resultado}")
        else:
            print("Opción no válida. Intenta de nuevo.")


if __name__ == "__main__":
    main()
