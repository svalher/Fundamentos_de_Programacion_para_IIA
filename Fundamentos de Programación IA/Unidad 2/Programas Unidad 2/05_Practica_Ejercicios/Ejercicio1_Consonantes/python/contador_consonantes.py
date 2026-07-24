"""
Ejercicio 1 de práctica — Unidad 2 (IAD-2413)
Contador de consonantes en una frase.

Enunciado: lee una frase y cuenta cuántas consonantes contiene (cualquier
letra que no sea vocal ni espacio ni signo de puntuación), sin importar
mayúsculas o minúsculas.

Este archivo es una PLANTILLA. Completa la función siguiendo la
metodología de la Unidad 2 (2.1 a 2.7) antes de programar:
  1) Escribe tu análisis (2.1) y tu pseudocódigo (2.3) en un comentario.
  2) Implementa la función contar_consonantes().
  3) Prueba tu solución con la tabla de casos de la Unidad 2 (2.5).
"""


def contar_consonantes(frase):
    """Cuenta cuántas consonantes contiene una frase.

    Parámetros:
        frase (str): la frase a analizar.

    Retorna:
        int: el número de consonantes encontradas.
    """
    # TODO 1: define qué caracteres son vocales (para poder reconocer
    #         una consonante como "una letra que no es vocal").
    # TODO 2: recorre la frase en minúsculas, carácter por carácter.
    # TODO 3: decide si el carácter es una letra del alfabeto y,
    #         si lo es, si NO es una vocal -> entonces es consonante.
    # TODO 4: cuenta y regresa el resultado.
    raise NotImplementedError("Implementa contar_consonantes()")


def main():
    frase = input("Escribe una frase: ")
    print("Consonantes encontradas:", contar_consonantes(frase))


if __name__ == "__main__":
    main()
