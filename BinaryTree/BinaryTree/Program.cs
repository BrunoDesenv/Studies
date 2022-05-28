using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tree = new Tree {
            //    data = 37,
            //    right = new Tree
            //    {
            //        data = 42
            //    },
            //    left = new Tree
            //    {
            //        data = 23,
            //        right = new Tree
            //        {
            //            data = 29
            //        }

            //    }
            //};

            //Insert(tree, 30);
            //ShowInOrder(tree);



            var treeExample = new Tree
            {
                data = 20,
                right = new Tree
                {
                    data = 45,
                    right = new Tree
                    {
                        data = 50,
                        left = new Tree
                        {
                            data = 47
                        },
                    }
                },
                left = new Tree
                {
                    data = 15,
                    left = new Tree
                    {
                        data = 10
                    },
                    right = new Tree
                    {
                        data = 18,
                        left = new Tree
                        {
                            data = 17
                        },
                    }

                }
            };

            RemoveABB(treeExample, 15);
            ShowInOrder(treeExample);
        }

        /*It traverses the tree presenting elements In_Order*/

        private static void ShowInOrder(Tree p)
        {
            if (p != null)
            {
                Console.WriteLine(" " + p.data);
                ShowInOrder(p.left);
                ShowInOrder(p.right);
            }
        }

        private static Tree InsertABB(Tree p, int info)
        {
            // insert element into an ABB
            if (p == null)
            {
                p = new Tree();
                p.data = info;
                p.left = null;
                p.right = null;
            }
            else if (info < p.data)
                p.left = InsertABB(p.left, info);
            else
                p.right = InsertABB(p.right, info);
            return p;
        }

        private static Tree RemoveABB(Tree p, int info)
        {
            if (p != null)
            {
                if (info == p.data)
                {
                    if (p.left == null && p.right == null)
                        //nó a ser removido é nó folha
                        return null;
                    if (p.left == null)
                        return p.right;
                    if (p.right == null)
                        /*se não há subárvore direita o ponteiro passa apontar para a subárvore esquerda */
                        return p.left;

                    /*se não há subárvore esquerda o ponteiro passa apontar para a subárvore direita*/
                    else
                    {
                        /*o nó a ser retirado possui subárvore esquerda e direita, então o nó que será retirado deve-se encontrar o menor valor na subárvore à direita */
                        Tree aux;
                        Tree reference;
                        reference = p.right;
                        aux = p.right;
                        while (aux.left != null)
                            aux = aux.left;
                        aux.left = p.left;
                        return reference;
                    }
                }
                else
                {       //procura dado a ser removido na ABB
                    if (info < p.data)
                        p.left = RemoveABB(p.left, info);
                    else
                        p.right = RemoveABB(p.right, info);
                }
            }
            return p;
        }
    }
}
