"""
Ejercicio 4 de práctica — Unidad 2 (IAD-2413)
Validador de correo electrónico simple.

Enunciado: lee una cadena de texto y determina, con reglas simples, si
*parece* un correo electrónico válido. Como mínimo debe cumplir:
  - Contener exactamente un símbolo "@".
  - Tener al menos un carácter antes del "@".
  - Tener al menos un punto (".") después del "@".

Pista: este ejercicio es un "primo" del Ejemplo 3 (validador de
contraseña) — usa el mismo enfoque de funciones booleanas pequeñas
combinadas con "and".

Este archivo es una PLANTILLA. Sigue la metodología de la Unidad 2
(2.1 a 2.7) antes de completar las funciones de abajo.
"""


def tiene_una_arroba(correo):
    """Verifica que el correo tenga exactamente un símbolo @."""
    # TODO: cuenta cuántas veces aparece "@" en correo y compara contra 1.
    raise NotImplementedError("Implementa tiene_una_arroba()")


def tiene_texto_antes_de_arroba(correo):
    """Verifica que haya al menos un carácter antes del @."""
    # TODO: encuentra la posición del "@" y evalúa si hay texto antes.
    raise NotImplementedError("Implementa tiene_texto_antes_de_arroba()")


def tiene_punto_despues_de_arroba(correo):
    """Verifica que exista un punto "." después del @."""
    # TODO: encuentra la posición del "@" y busca un "." después de esa posición.
    raise NotImplementedError("Implementa tiene_punto_despues_de_arroba()")


def parece_valido(correo):
    """Combina las tres reglas anteriores para decidir si el correo parece válido."""
    # TODO: combina las tres funciones anteriores con "and".
    raise NotImplementedError("Implementa parece_valido()")


def main():
    correo = input("Escribe un correo electrónico: ")
    if parece_valido(correo):
        print("Parece un correo válido")
    else:
        print("No parece un correo válido")


if __name__ == "__main__":
    main()
