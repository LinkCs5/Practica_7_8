Console.Write("Ingrese el tamaño del cuadro magico: ");
int tamaño = int.Parse(Console.ReadLine()!);

CuadroMagico cuadroMagico = new CuadroMagico(tamaño);

cuadroMagico.leerMatriz();

if(cuadroMagico.esCuadroMagico())
{
    Console.WriteLine($"Es un cuadro mágico con constante mágica: {cuadroMagico.constanteMagica()}");
}
else
{
    Console.WriteLine("No es un cuadro mágico.");
}

class CuadroMagico
{
    private int[,] matriz;
    private int tamaño;

    public CuadroMagico(int tamaño)
    {
        this.tamaño = tamaño;
        matriz = new int[tamaño,tamaño];
    }

    public void leerMatriz()
    {
        Console.WriteLine($"Ingrese los valores para el cuadro mágico ({tamaño}x{tamaño}: )");

        for (int i = 0; i < tamaño; i++ )
        {
            for (int j = 0; j < tamaño; j++)
            {
                Console.Write($"Fila {i + 1}, columna {j + 1}: ");
                matriz[i,j] = int.Parse(Console.ReadLine()!);
            }
        }
    }

    public bool esCuadroMagico()
    {
        int sumarReferencia = 0;
        for (int j = 0; j < tamaño; j++)
        {
            sumarReferencia += matriz[0,j];
        }

        for (int i = 0; i < tamaño; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < tamaño; j++)
            {
                sumaFila += matriz[i,j];
            }
            if(sumaFila != sumarReferencia)
            {
                return false;
            }
        }
        for (int j  = 0; j < tamaño; j++)
        {
            int sumaColumna = 0;
            for(int i = 0; i < tamaño; i++)
            {
                sumaColumna += matriz[i,j];

            }
            if(sumaColumna != sumarReferencia)
            {
                return false;
            }
        }

        int sumarDiagonalPrincipal = 0;
        for (int i = 0; i < tamaño; i++)
        {
            sumarDiagonalPrincipal +=matriz[i,i];
        }
        if(sumarDiagonalPrincipal != sumarReferencia)
        {
            return false;
        }

        return true;
    }

    public int constanteMagica()
    {
        int sumarReferencia = 0;
        for (int j = 0; j < tamaño; j++)
        {
            sumarReferencia += matriz[0,j];

        }
        return sumarReferencia;
    }
}