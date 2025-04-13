using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Infrastructure.Configurations.Foundation;
using Microsoft.EntityFrameworkCore;
using SeuNamespace;

namespace GestaoMonetariaApi.Infrastructure.Configurations.Fundation
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
        public DbSet<CategoriaEntity> Categorias { get; set; }

        // -----------------------
        //  Configurações
        // -----------------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new OperacaoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
        }
    }
}
