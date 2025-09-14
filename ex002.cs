using System;
using MinhaBiblioteca;

class ex002
{
    //Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o maior valor da matriz.
    static int getMax(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int max = matriz[0, 0];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > max)
                {
                    max = matriz[i, j];
                }
            }
        }
        return max;
    }
    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];

        Biblioteca.gerarMatriz(matriz);
        Biblioteca.mostrarMatriz(matriz);

        Console.WriteLine("Maior valor da matriz:" + getMax(matriz));
    }
}