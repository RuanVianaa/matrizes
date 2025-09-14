using System;
using MinhaBiblioteca;
using static MinhaBiblioteca.Biblioteca;
class ex001 
{
    //Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o menor valor da matriz.
    static int getMin(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int min = matriz[0, 0];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] < min)
                {
                    min = matriz[i, j];
                }
            }
        }
        return min;
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

        Console.WriteLine("Menor valor da matriz:" + getMin(matriz));
    }
}