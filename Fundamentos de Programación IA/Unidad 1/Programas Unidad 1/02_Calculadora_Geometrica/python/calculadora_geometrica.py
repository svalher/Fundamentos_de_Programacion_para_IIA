"""
Práctica complementaria - Calculadora geométrica
Fundamentos de Programación (IAD-2413)
Instituto Tecnológico de Durango (TecNM)

Calcula el área de distintas figuras geométricas:
círculo, cuadrado, rectángulo, triángulo, rombo,
trapecio y pentágono regular.

Lenguaje: Python
"""

import math


# ---------------------------------------------------------
# Funciones y métodos: una función por figura geométrica
# ---------------------------------------------------------
def area_circulo(radio):
    return math.pi * radio ** 2


def area_cuadrado(lado):
    return lado ** 2


def area_rectangulo(base, altura):
    return base * altura


def area_triangulo(base, altura):
    return (base * altura) / 2


def area_rombo(diagonal_mayor, diagonal_menor):
    return (diagonal_mayor * diagonal_menor) / 2


def area_trapecio(base_mayor, base_menor, altura):
    return ((base_mayor + base_menor) * altura) / 2


def area_pentagono(lado):
    # Área de un pentágono regular a partir de su lado
    return (5 * lado ** 2) / (4 * math.tan(math.pi / 5))


# ---------------------------------------------------------
# Entrada de datos con validación
# ---------------------------------------------------------
def leer_numero(mensaje):
    """Solicita un número positivo y valida que sea válido."""
    while True:
        try:
            valor = float(input(mensaje))
            if valor <= 0:
                print("El valor debe ser mayor que cero.")
                continue
            return valor
        except ValueError:
            print("Entrada inválida. Introduce un número.")


def mostrar_menu():
    print("\n===== CALCULADORA GEOMÉTRICA (Python) =====")
    print("1. Círculo")
    print("2. Cuadrado")
    print("3. Rectángulo")
    print("4. Triángulo")
    print("5. Rombo")
    print("6. Trapecio")
    print("7. Pentágono regular")
    print("8. Salir")


# ---------------------------------------------------------
# Programa principal
# Estructuras de control: condicionales (if-elif-else) y bucle (while)
# ---------------------------------------------------------
def main():
    continuar = True

    while continuar:
        mostrar_menu()
        opcion = input("Selecciona una figura (1-8): ")

        if opcion == "1":
            r = leer_numero("Radio: ")
            print(f"\nÁrea del círculo = {area_circulo(r):.2f}")

        elif opcion == "2":
            lado = leer_numero("Lado: ")
            print(f"\nÁrea del cuadrado = {area_cuadrado(lado):.2f}")

        elif opcion == "3":
            base = leer_numero("Base: ")
            altura = leer_numero("Altura: ")
            print(f"\nÁrea del rectángulo = {area_rectangulo(base, altura):.2f}")

        elif opcion == "4":
            base = leer_numero("Base: ")
            altura = leer_numero("Altura: ")
            print(f"\nÁrea del triángulo = {area_triangulo(base, altura):.2f}")

        elif opcion == "5":
            d_mayor = leer_numero("Diagonal mayor: ")
            d_menor = leer_numero("Diagonal menor: ")
            print(f"\nÁrea del rombo = {area_rombo(d_mayor, d_menor):.2f}")

        elif opcion == "6":
            b_mayor = leer_numero("Base mayor: ")
            b_menor = leer_numero("Base menor: ")
            altura = leer_numero("Altura: ")
            print(f"\nÁrea del trapecio = {area_trapecio(b_mayor, b_menor, altura):.2f}")

        elif opcion == "7":
            lado = leer_numero("Lado: ")
            print(f"\nÁrea del pentágono regular = {area_pentagono(lado):.2f}")

        elif opcion == "8":
            print("Fin del programa. ¡Hasta luego!")
            continuar = False

        else:
            print("Opción no válida. Intenta de nuevo.")


if __name__ == "__main__":
    main()
