using System;
using System.Linq;

namespace IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AppDbContext())
            {


                var pessoas = contexto.Pessoas.MaisVelhoQue(28).ToList();

                foreach (var p in pessoas)
                {
                    Console.WriteLine($"{p.Nome} - {p.Nascimento}");
                }
                Console.ReadLine();
            }
        }

        private static void consulta4()
        {
            using (var contexto = new AppDbContext())
            {
                // Not parameterized.
                var res1 = contexto.Pessoas.Where(p => p.Genero.GeneroId == 2);

                int feminino = 2;
                // Consulta parametrizada não usa o plano anterior
                var res2 = contexto.Pessoas.Where(p => p.Genero.GeneroId == feminino).ToList();

                int masculino = 1;
                // Consulta parametrizada usa o plano anterior
                var res3 = contexto.Pessoas.Where(p => p.Genero.GeneroId == masculino).ToList();

            }
        }

        private static void Consulta3(AppDbContext contexto)
        {
            bool resultado = false;

            //Não acessa o banco de dados ainda...
            IQueryable<Pessoa> consulta = contexto.Pessoas.Include(g => g.Genero)
                                           .Where(p => p.Genero.GeneroId == 2);

            if (resultado)
            {
                consulta = consulta.OrderBy(p => p.Sobrenome);
            }

            // Agora acessa o banco de dados
            List<Pessoa> mulheres = consulta.ToList();

            // Exibe o resultado
            foreach (var m in mulheres)
            {
                Console.WriteLine($"{m.Nome} - {m.Sobrenome}");
            }
        }

        private static void Consulta2(AppDbContext contexto)
        {
            IQueryable<Pessoa> resultado = contexto.Pessoas.Include(g => g.Genero)
                                           .Where(p => p.Genero.GeneroId == 2)
                                           .OrderBy(p => p.Nome);

            // Agora sim, acessa o banco de dados
            List<Pessoa> mulheres = resultado.ToList();

            // Exibe o resultado
            foreach (var m in mulheres)
            {
                Console.WriteLine($"{m.Nome} - {m.Sobrenome}");
            }
        }

        private static void Consulta1(AppDbContext contexto)
        {
            var resultado = contexto.Pessoas.ToList();

            foreach (var p in resultado)
            {
                Console.WriteLine($"{p.Nome} - {p.Sobrenome} - {p.Nascimento}");
            }
        }
    }
}
