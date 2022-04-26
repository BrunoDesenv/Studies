using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example();

            StackInt stack = new StackInt();

            string item;
            string opcao;
            StackInt.Retorno retorno = new StackInt.Retorno();

            //Initialize the stack
            stack.INIT();

            //Invoke method TOP for obtain data of node from top of stack
            retorno = stack.TOP();

            if (retorno.ok)
                Console.WriteLine("Execução do TOP: " + retorno.item);
            else
                Console.WriteLine("Execução do TOP: pilha vazia");


            //looop to insert values in the stack
            do
            {
                Console.WriteLine("Digite valor inteiro para dado");
                item = Console.ReadLine();
                stack.PUSH(Convert.ToInt32(item));

                Console.WriteLine("Digite 0 para encerrar empilhamento de dados");
                opcao = Console.ReadLine();

            } while (!opcao.Equals("0"));

            //Invoke method TOP for obtain data of node from top of stack
            retorno = stack.TOP();
            if (retorno.ok)
                Console.WriteLine("Execução do TOP: " + retorno.item);

            //loop for remov all elements of stack
            do
            {
                retorno = stack.POP();
                if (retorno.ok)
                    Console.WriteLine("Dados retirado: " + retorno.item);
            } while (retorno.ok);
        }


        static void Example()
        {
            StackInt s = new StackInt();
            StackInt.Retorno res = new StackInt.Retorno();
            //Scanner entrada = new Scanner(System.in);
            int resto, num;

            //Initialize the stack
            s.INIT();


            Console.WriteLine("Digite valor número na base 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            // making successive divisions and stacking the values ​​of the
            // remainder until num is zero
            while (num > 0)
            {
                resto = num % 2;
                s.PUSH(resto);
                num = num / 2;
            }

            /* writing the remainder in reverse order that they were obtained
               using stack LIFO property*/
            Console.WriteLine("Numero em binario: ");
            do
            {
                res = s.POP();
                if (res.ok)
                    Console.Write(" " + res.item);
            } while (res.ok);
        }
    }
}
