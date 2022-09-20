using System;

namespace Search
{
    public class BinarySearch
    {
        public void Example()
        {
            Random gerador = new Random();
            int N = 100;
            int i;

            /*cria a estrutura de dados (vetor) com N elementos*/
            int[] basededados = new int[N];
            Console.WriteLine("Criando vetor com 100 elementos: ");
            for (i = 0; i < N; i++)
                basededados[i] = (int)gerador.Next() / 1000;

            Console.WriteLine("Ordenando o vetor criado...");
            bool troca = true;
            for (i = 0; i < N - 1 && troca == true; i++)
            {
                int aux;
                troca = false;
                for (int k = 0; k < N - i - 1; k++)
                {
                    if (basededados[k] > basededados[k + 1])
                    {
                        aux = basededados[k];
                        basededados[k] = basededados[k + 1];
                        basededados[k + 1] = aux;
                        troca = true;
                    }
                }
            }

            for (i = 0; i < N; i++)
                Console.WriteLine(i + "\t" + basededados[i]);

            Console.WriteLine("Digite chave procurada: ");
            int chaveproc = Convert.ToInt32(Console.ReadLine());

            /*Pesquisa na estrutura de dados o valor solicitado*/
            Console.WriteLine("Procurando o chave solicitada...");
            int i_baixo = 0;
            int i_medio = 0;
            int i_alto = N - 1;
            int achou = 0;
            int posicao = -1;
            while (achou != 1 && i_baixo <= i_alto)
            {
                i_medio = (i_baixo + i_alto) / 2;
                if (chaveproc == basededados[i_medio])
                {
                    posicao = i_medio;
                    achou = 1;
                }
                else
                {
                    if (chaveproc < basededados[i_medio])
                        i_alto = i_medio - 1;
                    else
                        i_baixo = i_medio + 1;
                }
            }
            if (posicao == -1)
                Console.WriteLine("Chave não encontrada");

        else
                Console.WriteLine("Chave encontrada posicao " + posicao);
        }
    }
}

