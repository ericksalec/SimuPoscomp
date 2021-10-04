using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simu.App.Models;


namespace Simu.Data.Mappings
{
    public class AssuntoMapping : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            //builder.HasKey(p => p.Id);
            //builder.Property(p => p.Nome)
            //     .IsRequired()
            //     .HasColumnType("varchar(100)");

            //builder.Property(p => p.Descricao)
            //      .IsRequired()
            //   .HasColumnType("varchar(200)");

            //builder.Property(p => p.TipoAssunto)
            //     .HasColumnType("varchar(100)");

            //builder.ToTable("Assunto");

        }
    }
}
