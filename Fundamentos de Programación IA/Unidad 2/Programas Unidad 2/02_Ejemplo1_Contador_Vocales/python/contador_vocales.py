"""
Ejemplo 1 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
Contador de vocales en una palabra o frase.
"""


def contar_vocales(palabra):
    """Cuenta cuántas vocales (a, e, i, o, u) contiene una palabra.

    Nota: esta versión no cuenta letras acentuadas (á, é, í...) como vocales.
    """
    vocales = "aeiou"
    contador = 0
    for letra in palabra.lower():
        if letra in vocales:
            contador += 1
    return contador


def main():
    palabra = input("Escribe una palabra: ")
    print("Vocales encontradas:", contar_vocales(palabra))


if __name__ == "__main__":
    main()
