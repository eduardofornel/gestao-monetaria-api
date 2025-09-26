using GestaoMonetariaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoMonetariaApi.Infrastructure.Configurations
{
    public class OperacaoConfiguration : IEntityTypeConfiguration<OperacaoEntity>
    {
        public void Configure(EntityTypeBuilder<OperacaoEntity> builder)
        {
            builder.ToTable("tbl_operacao");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                   .HasColumnName("ID")
                   .ValueGeneratedOnAdd();

            builder.Property(o => o.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(o => o.IdCategoria)
                   .HasColumnName("ID_CATEGORIA")
                   .IsRequired();

            builder.Property(o => o.FlagDebito)
                   .HasColumnName("FL_DEBITO")
                   .IsRequired();

            builder.Property(o => o.Valor)
                   .HasColumnName("VALOR")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(o => o.DataOperacao)
                   .HasColumnName("DT_OPERACAO")
                   .IsRequired();

            builder.HasOne(o => o.Categoria)
                   .WithMany(c => c.Operacoes)
                   .HasForeignKey(o => o.IdCategoria)
                   .IsRequired();
        }
    }
}
