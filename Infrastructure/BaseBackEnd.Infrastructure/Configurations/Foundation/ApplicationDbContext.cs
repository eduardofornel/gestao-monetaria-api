using BaseBackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SeuNamespace;

namespace BaseBackEnd.Infrastructure.Configurations.Fundation
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // -----------------------
        //  DbSets (Entidades)
        // -----------------------
        public DbSet<OperacaoEntity> Operacoes { get; set; }

        // -----------------------
        //  Configurações
        // -----------------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new OperacaoConfiguration());
        }
    }
}
