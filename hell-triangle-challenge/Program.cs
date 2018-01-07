using System;

namespace hell_triangle_challenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas do triângulo:");
            int quantidadeDeLinhas = int.Parse(Console.ReadLine());

            object[] linhas = new object[quantidadeDeLinhas];

            for (int i = 1; i <= quantidadeDeLinhas; i++)
            {
                int[] numeros = new int[i];
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("Digite o {0}º número da linha {1}:", j, i);
                    numeros[j - 1] = int.Parse(Console.ReadLine());
                }

                linhas[i - 1] = numeros;
            }
            
            Console.WriteLine("Total máximo do triângulo: {0}", ObterTotalMaximoDoTriangulo(linhas));
            Console.ReadLine();
        }

        public static int ObterTotalMaximoDoTriangulo(object[] linhas)
        {
            int soma = 0;

            for (int i = 1; i <= linhas.Length; i++)
            {
                int[] linhaAtual = linhas[i - 1] as int[];

                int maiorDaLinha = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (j <= 2 && linhaAtual[j - 1] > maiorDaLinha)
                    {
                        maiorDaLinha = linhaAtual[j - 1];
                    }
                }

                soma += maiorDaLinha;
            }

            return soma;
        }
    }
}
