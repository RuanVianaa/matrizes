using System;
using MinhaBiblioteca;
/*8. Caçadores de Mito 

Jorge é um apresentador de televisão que comanda a versão brasileira do grande sucesso Caçadores de Mitos, onde se estuda um mito para descobrir se é fato ou apenas um boato. No próximo episódio, Jorge deverá apresentar o mito que diz que "os raios não caem duas vezes no mesmo lugar", referindo-se aos raios das tempestades de chuva.
Para isso, foi até a cidade de Eletrolândia, que é a cidade com maior ocorrência de raios no mundo. O prefeito tem tanto orgulho desse título que mandou criar um sistema para registrar os raios. Jorge conseguiu um relatório com as ocorrências de cada raio que caiu na cidade nos últimos anos.
O mapa de Eletrolândia é um retângulo. Para o sistema de registro a cidade é subdividida em quadrados de um metro de lado, denominados quadrantes. O sistema de registro armazena o quadrante em que o raio caiu. Cada quadrante é identificado pelas suas coordenadas X e Y.
Como os quadrantes são relativamente pequenos, Jorge decidiu que se dois raios caíram no mesmo quadrante, pode-se considerar que caíram no mesmo lugar.
Tarefa 
Sua missão é escrever um programa que receba as coordenadas dos raios que caíram em Eletrolândia nos últimos anos e determine se o mito estudado é realmente apenas um mito ou pode ser considerado verdade.

Entrada 
A entrada contém um único conjunto de testes, que deve ser lido do dispositivo de entrada padrão (normalmente o teclado).
A primeira linha da entrada contém um número inteiro N (
2≤N≤500.000) representando o número de registros de raios no relatório.
Cada uma das N linhas seguintes contém 2 números inteiros X, Y (
0≤X,Y≤500), representando o registro de um raio que caiu no quadrante cujas coordenadas são (X, Y).

Saída 
Seu programa deve imprimir 1 se um raio caiu alguma vez em um mesmo lugar ou 0 caso isso não ocorreu*/

class ex008
{
    static int contarRaiosMesmoLocal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > 1)
                {
                    count++;
                }
            }
        }
        return count;

    }
    static void Main()
    {
        int x, y, quantidadeRaios;
        int linhas, cols;
        Console.Write("Entre com o número de linhas e colunas da area: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] mapa = new int[linhas, cols];
        Console.Write("Quantos raios foram anotados? ");
        quantidadeRaios = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.Write($"Entre com a posição do raio {i + 1} (x y): ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;
        }
        Biblioteca.mostrarMatriz(mapa);
        if (contarRaiosMesmoLocal(mapa) > 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
        Console.WriteLine($"Foram registrados {contarRaiosMesmoLocal(mapa)} raios caindo no mesmo local.");
    }
}