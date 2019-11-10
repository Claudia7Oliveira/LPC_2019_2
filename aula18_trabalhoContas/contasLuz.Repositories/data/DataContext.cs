using Microsoft.EntityFrameworkCore;
using contasLuz.Entities;

namespace contasLuz.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
        public DbSet<Imoveis> ImovelDb { get; set; } 
    }
}