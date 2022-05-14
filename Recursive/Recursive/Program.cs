using System;

namespace Recursive
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("================== FATORIAL ==================");
            Console.WriteLine("Digite valor inteiro positivo: ");
            int entrada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fatorial de " + entrada + " = " + fatorial(entrada));
            Console.WriteLine();

            Console.WriteLine("================== MDC ==================");
            Console.WriteLine("Digite 2 dados inteiros: ");
            int i = 1;
            int n = 0;
            int m = 0;
            while (i <= 2)
            {
                int result = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    n = result;
                }
                else
                {
                    m = result;
                }
                i++;
            }

            Console.WriteLine("MDC de " + n + "," + m + " = " + mdc(n, m));
            Console.WriteLine();
        }

        public static int fatorial(int n)
        {
            if (n == 0)
                return (1);
            else
                return (n * fatorial(n - 1));
        }

        public static int mdc(int n, int m)
        {
            if (n > m)
                return (mdc(m, n));
            else
            {
                if (n == 0)
                    return (m);
                else
                    return (mdc(n, m % n));
            }
        }

    }
}
