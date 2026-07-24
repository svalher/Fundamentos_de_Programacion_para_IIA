"""
Ejemplo 2 de la Unidad 2 — Fundamentos de Programación (IAD-2413)
Temperatura máxima y mínima de la semana.
"""


def calcular_max_min(temperaturas):
    """Calcula el valor máximo y mínimo de una lista de temperaturas."""
    maximo = temperaturas[0]
    minimo = temperaturas[0]
    for t in temperaturas[1:]:
        if t > maximo:
            maximo = t
        if t < minimo:
            minimo = t
    return maximo, minimo


def main():
    temperaturas = []
    for i in range(7):
        t = float(input(f"Temperatura día {i + 1}: "))
        temperaturas.append(t)

    maximo, minimo = calcular_max_min(temperaturas)
    print("Máxima:", maximo)
    print("Mínima:", minimo)


if __name__ == "__main__":
    main()
