using System.Collections.Generic;
using System.Linq;
using ContasEF.Context;
using Microsoft.EntityFrameworkCore;

namespace ContasEF.Models
{
    public class ContasRepository : IContasRepository
    {
       private DataContext context;

        public ContasRepository(DataContext context)
        {
            this.context = context;
        }

        public ContaLuz Get(int id)
        {
            return context.ContasLuz.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<ContaLuz> Get()
        {
            return context.ContasLuz.ToList().OrderBy(x => x.id);
        }

        public void Insert(ContaLuz contaLuz)
        {
            context.ContasLuz.Add(contaLuz);
            context.SaveChanges();
        }

        public void Update(ContaLuz contaLuz)
        {
            context.Entry(contaLuz).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.ContasLuz.Remove(Get(id));
            context.SaveChanges();
        }

        public ContaLuz GetMenorConsumo()
        {
            return Get().Any() ? Get().OrderBy(x => x.kwGasto).First() : null;
        }

        public ContaLuz GetMaiorConsumo()
        {
            return Get().Any() ? Get().OrderBy(x => x.kwGasto).Last() : null;
        }

        public ContaLuz GetMenor()
        {
            throw new System.NotImplementedException();
        }

        public ContaLuz GetMaior()
        {
            throw new System.NotImplementedException();
        }
    }
}