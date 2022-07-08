using System;
using System.Collections.Generic;
using System.Linq;

namespace Search
{
    public class SequentialSearch
    {
        public void Example()
        {
            /*simula estrutura de dados com registros*/
            int[] basededados = new int[100];
            Console.WriteLine("Digite numeros inteiros POSITIVOS e -1 para SAIR: ");
            var entrada = ConvertArray(Console.ReadLine());

            int item = entrada.FirstOrDefault();
            for (int i = 0; item > 0; i++)
            {
                basededados[i] = item;
                item = entrada.Skip(i + 1).FirstOrDefault();
            }
            /*vetor para armazenar posicao onde registros foram encontrados*/
            int[] encontrados = new int[100];

            Console.WriteLine("Digite chave procurada: ");
            int chaveproc = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            for (int i = 0; i < basededados.Length; i++)
            {
                if (basededados[i] == chaveproc)
                {
                    encontrados[cont] = i;
                    cont++;
                }
            }

            Console.WriteLine("Posições onde chave foram encontradas");
            for (int i = 0; i < cont; i++)
                Console.WriteLine(encontrados[i]);
        }

        static IEnumerable<int> ConvertArray(string value)
        {
            return value.Split(" ").Select(x => Convert.ToInt32(x));
        }
    }
}
