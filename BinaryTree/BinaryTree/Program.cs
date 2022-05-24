using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*Percorre arvore apresentando elementos Em_Ordem*/

        private static void show_in_order(Tree p)
        {
            if (p != null)
            {
                show_in_order(p.left);
                Console.WriteLine(" " + p.data);
                show_in_order(p.right);
            }
        }
    }
}
