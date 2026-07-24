"""
Ejemplo 3 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
Validador de contraseña segura.
"""


def tiene_longitud_minima(password):
    """Verifica que la contraseña tenga al menos 8 caracteres."""
    return len(password) >= 8


def tiene_mayuscula(password):
    """Verifica que la contraseña tenga al menos una letra mayúscula."""
    return any(c.isupper() for c in password)


def tiene_digito(password):
    """Verifica que la contraseña tenga al menos un dígito."""
    return any(c.isdigit() for c in password)


def es_segura(password):
    """Una contraseña es segura si cumple las tres reglas anteriores."""
    return tiene_longitud_minima(password) and tiene_mayuscula(password) and tiene_digito(password)


def main():
    password = input("Escribe una contraseña: ")
    if es_segura(password):
        print("Contraseña segura")
    else:
        print("Contraseña insegura: debe tener 8+ caracteres, una mayúscula y un dígito")


if __name__ == "__main__":
    main()
