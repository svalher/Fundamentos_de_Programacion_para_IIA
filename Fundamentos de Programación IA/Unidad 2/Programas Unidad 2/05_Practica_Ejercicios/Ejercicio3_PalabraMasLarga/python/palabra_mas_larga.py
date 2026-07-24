"""
Ejercicio 3 de práctica — Unidad 2 (IAD-2413)
La palabra más larga de una lista.

Enunciado: lee una lista de palabras (el usuario decide cuántas) y
determina cuál es la palabra más larga. Si hay un empate, se debe
mostrar la primera que haya aparecido.

Pista: este problema es un "primo" del Ejemplo 2 (máxima y mínima
temperatura) — el patrón de "inicializar con el primer valor y comparar
contra el resto" también aplica aquí.

Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
(2.1 a 2.7) antes de completar la función palabra_mas_larga().
"""


def palabra_mas_larga(palabras):
    """Encuentra la palabra más larga de una lista.

    Parámetros:
        palabras (list[str]): lista de palabras a comparar.

    Retorna:
        str: la primera palabra con la mayor longitud encontrada.
    """
    # TODO 1: inicializa tu resultado con la primera palabra de la lista.
    # TODO 2: recorre el resto de las palabras comparando su longitud
    #         (len(palabra)) contra la más larga encontrada hasta ahora.
    # TODO 3: decide qué condición usar para que, en caso de empate,
    #         se conserve la primera palabra que apareció.
    raise NotImplementedError("Implementa palabra_mas_larga()")


def main():
    n = int(input("¿Cuántas palabras vas a capturar? "))
    palabras = []
    for i in range(n):
        palabras.append(input(f"Palabra {i + 1}: "))

    print("La palabra más larga es:", palabra_mas_larga(palabras))


if __name__ == "__main__":
    main()
