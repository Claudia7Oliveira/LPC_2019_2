using ContasEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ContasEF.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
    }
}