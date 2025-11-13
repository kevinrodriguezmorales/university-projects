# university-projects
Repository for sharing university projects

```py
class Serie:
    def __init__(self, n):
        self.n = n
        self.terminos = []

    def generar_serie(self):
        """
        Genera los n primeros términos de la serie:
        2, 5, 7, 12, 19, 31, 50, 81, 131, ...
        Patrón: cada término (a partir del 3ro) es la suma de los dos anteriores.
        """
        if self.n >= 1:
            self.terminos.append(2)
        if self.n >= 2:
            self.terminos.append(5)

        for i in range(2, self.n):
            siguiente = self.terminos[i - 1] + self.terminos[i - 2]
            self.terminos.append(siguiente)

    def mostrar_serie(self):
        """
        Muestra los elementos almacenados en la lista.
        """
        print("Serie generada:")
        for i, valor in enumerate(self.terminos):
            print(f"[{i}] -> {valor}")


def main():
    try:
        n = int(input("Ingrese un número entero (n ≥ 1): "))
        if n < 1:
            print("Por favor, ingrese un número mayor o igual a 1.")
            return

        serie = Serie(n)
        serie.generar_serie()
        serie.mostrar_serie()

    except ValueError:
        print("Debe ingresar un número entero válido.")


if __name__ == "__main__":
    main()

```

```py
# pregunta02.py

class Divisores:
    def __init__(self, n: int):
        self.n = n
        self.lista = []

    def calcular(self):
        """Llena self.lista con todos los divisores de n (en orden ascendente)."""
        self.lista = []
        for d in range(1, self.n + 1):
            if self.n % d == 0:
                self.lista.append(d)

    def mostrar(self, titulo: str = "Divisores"):
        """Imprime los elementos de la lista con un título."""
        print(f"{titulo}:")
        print(self.lista)
        print()

    def seleccion_desc(self):
        """
        Ordena self.lista de mayor a menor usando el
        Algoritmo de Selección (Selection Sort).
        """
        a = self.lista
        n = len(a)
        for i in range(n - 1):
            # seleccionar el índice del máximo en la parte no ordenada
            idx_max = i
            for j in range(i + 1, n):
                if a[j] > a[idx_max]:
                    idx_max = j
            # intercambiar a[i] con a[idx_max]
            a[i], a[idx_max] = a[idx_max], a[i]


def main():
    try:
        n = int(input("Ingrese un número (n ≥ 2): "))
        if n < 2:
            print("Por favor ingrese un entero mayor o igual a 2.")
            return

        d = Divisores(n)
        d.calcular()

        print("\nLos divisores de", n, "son:")
        print(d.lista)  # (b) mostrar desde la lista

        d.seleccion_desc()  # (c) ordenar de mayor a menor por Selección
        print("\nEl arreglo de los divisores ordenado de mayor a menor por el Alg. de Selección es:")
        print(d.lista)

    except ValueError:
        print("Debe ingresar un número entero válido.")


if __name__ == "__main__":
    main()

```
