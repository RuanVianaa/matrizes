using System;
using MinhaBiblioteca;
class ex003
{
    //Crie uma função que receba uma matriz N por M e conte quantos números iguais a X existem na matriz. X
    //deve ser informado pelo usuário (parâmetro da função). Retorne a quantas ocorrências de X existem na
    //matriz.
    static int contarOcorrencias(int[,] matriz, int x)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == x)
                {
                    count++;
                }
            }
        }
        return count;
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

        Console.WriteLine("Entre com o valor a ser contado:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine($"O valor {x} aparece {contarOcorrencias(matriz, x)} vezes na matriz.");
    }
}