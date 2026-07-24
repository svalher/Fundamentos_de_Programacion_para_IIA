"""
Ejercicio 2 de práctica — Unidad 2 (IAD-2413)
Verificar si un número es primo.

Enunciado: lee un número entero positivo y determina si es primo (un
número primo solo es divisible entre 1 y entre sí mismo).

Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
(2.1 a 2.7) antes de completar la función es_primo().
"""


def es_primo(numero):
    """Determina si un número entero es primo.

    Parámetros:
        numero (int): el número a evaluar.

    Retorna:
        bool: True si es primo, False en caso contrario.
    """
    # TODO 1: decide qué hacer con 0, 1 y los números negativos
    #         (documenta tu decisión en un comentario).
    # TODO 2: recorre los posibles divisores desde 2 hasta el número
    #         que consideres necesario (no hace falta llegar hasta
    #         "numero - 1"; piensa hasta dónde es realmente necesario).
    # TODO 3: si encuentras un divisor exacto, el número NO es primo.
    # TODO 4: si no encontraste ningún divisor, el número SÍ es primo.
    raise NotImplementedError("Implementa es_primo()")


def main():
    numero = int(input("Escribe un número entero: "))
    if es_primo(numero):
        print(numero, "es primo")
    else:
        print(numero, "no es primo")


if __name__ == "__main__":
    main()
