using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class IndexedSequentialSearch
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

            /*gera tabela de índice especificando o tamanho do sub-conjunto*/
            int n, j;
            Console.WriteLine("Digite tamanho de cada sub-conjunto ");
            int Tamanho_Subconj = Convert.ToInt32(Console.ReadLine());

            j = Tamanho_Subconj;
            /*j é o valor do índice armazenado em k_indice sendo, Tamanho_Subconj é o numero de registros que cada subconjunto tem*/

            n = N / Tamanho_Subconj;
            /*n guarda o número de linhas na tabela índice*/

            int[] k_indice = new int[100];
            //guarda o valor da chave do início do conjunto

            int[] p_indice = new int[100];
            //guarda o índice do início do conjunto

            for (i = 0; i < n; i++)
            {
                k_indice[i] = basededados[j - 1];
                p_indice[i] = j - 1;
                j += Tamanho_Subconj;
            }

            Console.WriteLine("Digite chave procurada: ");
            int chaveproc = Convert.ToInt32(Console.ReadLine());

            /*Procura na tabela de índice o conjunto onde pode estar a chave procurada*/
            Console.WriteLine("Tabela de Índices: ");
            Console.WriteLine("\t p \t k");
            for (i = 0; i < n; i++)
                Console.WriteLine("\t" + p_indice[i] + "\t" + k_indice[i]);

            /*Procura na tabela de índice o conjunto onde pode estar a chave procurada*/
            int low, hi;
            for (i = 0; i < n && k_indice[i] < chaveproc; i++) ;
            if (k_indice[i] != chaveproc)
            {
                if (i == 0)
                    low = 0;
                else
                    low = p_indice[i - 1];
                if (i == n)
                    //hi = qtd - 1;
                    hi = 10 - 1;
                else
                    hi = p_indice[i];
                /*Procura na base de dados no intervalo do conjunto 
                onde pode estar a chave procurada*/

                for (j = low; j < hi && basededados[j] != chaveproc; j++) ;
                if (j < hi)
                {
                    Console.WriteLine(" chave encontrada na posição " + j);
                }
                else
                {
                    Console.WriteLine(" chave não foi encontrada ");
                }
            }

            else
            {
                Console.WriteLine(" chave encontrada na posição " + p_indice[i]);
            }
        }

        static IEnumerable<int> ConvertArray(string value)
        {
            return value.Split(" ").Select(x => Convert.ToInt32(x));
        }
    }
}
