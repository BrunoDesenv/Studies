using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding first the index");
            ReorderFindingTheIndexFirst();
            Console.WriteLine();
            Console.WriteLine("Finding and re-orgering");
            Reorder();
        }

        private static void ReorderFindingTheIndexFirst()
        {
            int newValue = 18;
            int i = 0, n = 8;
            int[] vetor = { 12, 15, 23, 42, 54, 63, 70, 72, 82, 0 };

            while ((newValue > vetor[i]) && (i < n))
            {
                i++;
            }

            n = n + 1;

            for (int j = n; j > i; j--)
            {
                vetor[j] = vetor[j - 1];
            }

            vetor[i] = newValue;

            foreach (var value in vetor)
            {
                Console.WriteLine(value);
            }
        }
        private static void Reorder()
        {
            int newValue = 18;
            int[] vetor = new int[9] { 12, 15, 23, 42, 54, 63, 70, 72, 82 };
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > newValue)
                {
                    aux = vetor[i];
                    vetor[i] = newValue;
                    newValue = aux;
                }
            }

            foreach (var value in vetor)
            {
                Console.WriteLine(value);
            }

        }
    }
}
