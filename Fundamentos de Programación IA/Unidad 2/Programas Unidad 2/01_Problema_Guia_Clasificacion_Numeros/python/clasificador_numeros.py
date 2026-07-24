"""
Problema guía de la Unidad 2 — Fundamentos de Programación (IAD-2413)
Clasificador de números en positivos, negativos y ceros.
"""


def capturar_numeros(n):
    """Lee n números capturados por el usuario y los regresa en una lista."""
    numeros = []
    for i in range(n):
        valor = float(input(f"Número {i + 1}: "))
        numeros.append(valor)
    return numeros


def clasificar(numeros):
    """Clasifica una lista de números en positivos, negativos y ceros.

    Parámetros:
        numeros (list[float]): lista de números a clasificar.

    Retorna:
        tuple: (positivos, negativos, ceros) con los conteos de cada categoría.
    """
    positivos = negativos = ceros = 0
    for numero in numeros:
        if numero > 0:
            positivos += 1
        elif numero < 0:
            negativos += 1
        else:
            ceros += 1
    return positivos, negativos, ceros


def mostrar_resumen(positivos, negativos, ceros):
    """Imprime el resumen final de la clasificación."""
    print("Positivos:", positivos)
    print("Negativos:", negativos)
    print("Ceros:", ceros)


def main():
    n = int(input("¿Cuántos números vas a capturar? "))
    numeros = capturar_numeros(n)
    positivos, negativos, ceros = clasificar(numeros)
    mostrar_resumen(positivos, negativos, ceros)


if __name__ == "__main__":
    main()
