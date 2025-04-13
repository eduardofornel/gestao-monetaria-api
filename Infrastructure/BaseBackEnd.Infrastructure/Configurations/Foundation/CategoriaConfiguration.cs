using GestaoMonetariaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoMonetariaApi.Infrastructure.Configurations.Foundation
{

    public class CategoriaConfiguration : IEntityTypeConfiguration<CategoriaEntity>
    {
        public void Configure(EntityTypeBuilder<CategoriaEntity> builder)
        {
            builder.ToTable("tbl_categoria");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("ID")
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                   .HasColumnName("NOME")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(c => c.Operacoes)
                   .WithOne(o => o.Categoria)
                   .HasForeignKey(o => o.IdCategoria)
                   .IsRequired();
        }
    }

}
