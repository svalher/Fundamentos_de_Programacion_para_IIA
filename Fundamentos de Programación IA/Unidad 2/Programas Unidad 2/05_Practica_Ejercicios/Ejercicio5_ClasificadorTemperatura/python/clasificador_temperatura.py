"""
Ejercicio 5 de práctica — Unidad 2 (IAD-2413)
Clasificador de temperatura corporal.

Enunciado: lee la temperatura corporal de una persona (en grados
Celsius) y clasifícala según esta tabla:

    Menor a 35.0        -> "Hipotermia"
    35.0 a 37.5          -> "Normal"
    37.6 a 39.0           -> "Fiebre"
    Mayor a 39.0          -> "Fiebre alta"

Presta atención a los límites exactos (35.0, 37.5, 39.0): decide con
claridad a qué categoría pertenece cada uno y documenta tu decisión.

Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
(2.1 a 2.7) antes de completar la función clasificar_temperatura().
"""


def clasificar_temperatura(temperatura):
    """Clasifica una temperatura corporal en Hipotermia, Normal, Fiebre o Fiebre alta.

    Parámetros:
        temperatura (float): temperatura corporal en grados Celsius.

    Retorna:
        str: el nombre de la categoría correspondiente.
    """
    # TODO 1: decide qué pasa si la temperatura es un valor imposible
    #         (por ejemplo, negativa o mayor a 45°C).
    # TODO 2: implementa las 4 categorías con if / elif / else,
    #         siguiendo el orden de la tabla y cuidando los límites.
    raise NotImplementedError("Implementa clasificar_temperatura()")


def main():
    temperatura = float(input("Temperatura corporal (°C): "))
    print("Categoría:", clasificar_temperatura(temperatura))


if __name__ == "__main__":
    main()
