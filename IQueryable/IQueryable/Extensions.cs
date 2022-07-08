using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace IQueryable
{
    public static class Extensions
    {
        public static IQueryable<Pessoa> MaisVelhoQue(this IQueryable<Pessoa> q, int idade)
        {
            return q
              .Where(p => (EF.Functions.DateDiffYear(p.Nascimento, DateTime.Today)) > idade);
        }
    }
}
