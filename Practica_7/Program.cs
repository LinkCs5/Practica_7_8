Console.Write("Ingresa el número de filas: ");
    if (int.TryParse(Console.ReadLine(), out int filas) && filas > 0)
    {
        Console.Write("Ingresa el número de columnas: ");
        if (int.TryParse(Console.ReadLine(), out int columnas) && columnas > 0)
        {
            MatrizCeros matrizCeros = new MatrizCeros(filas, columnas);
            matrizCeros.LlenarMatriz();
            matrizCeros.CalcularCerosEnFilas();
        }
        else
        {
        Console.WriteLine("Número de columnas no válido. Debe ser un entero positivo.");
        }
    }
    else
    {
        Console.WriteLine("Número de filas no válido. Debe ser un entero positivo.");
    }
class MatrizCeros
{
    private int[,] matriz;

    public MatrizCeros(int filas, int columnas)
    {
        matriz = new int[filas, columnas];
    }

    public void LlenarMatriz()
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Ingresa los valores de la matriz:");

        for (int fila = 0; fila < filas; fila++)
        {
            for (int columna = 0; columna < columnas; columna++)
            {
                Console.Write($"Elemento [{fila},{columna}]: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    matriz[fila, columna] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingresa un número entero.");
                    columna--; // Reintentar la entrada para esta celda
                }
            }
        }
    }

    public void CalcularCerosEnFilas()
    {
        int filas = matriz.GetLength(0);

        Console.WriteLine("Cantidad de ceros en cada fila:");

        for (int fila = 0; fila < filas; fila++)
        {
            int contadorCeros = 0;

            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if (matriz[fila, columna] == 0)
                {
                    contadorCeros++;
                }
            }

            Console.WriteLine($"Fila {fila + 1}: {contadorCeros} ceros");
        }
    }
}