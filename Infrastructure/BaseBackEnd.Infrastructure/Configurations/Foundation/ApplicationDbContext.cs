using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GestaoMonetariaApi.Infrastructure.Configurations.Foundation
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
        public DbSet<OperacaoEntity> Operacoes { get; set; } = null!;
        public DbSet<CategoriaEntity> Categorias { get; set; } = null!;

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
