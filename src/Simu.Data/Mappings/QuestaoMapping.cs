using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simu.App.Models;

namespace Simu.Data.Mappings
{
    public class QuestaoMapping : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            //builder.HasKey(p => p.Id);
            //builder.Property(p => p.AssuntoId);
            //builder.Property(p => p.ProvaId);
            //builder.Property(p => p.Prova)
            //    .IsRequired();
            //builder.Property(p => p.Tema)
            //     .IsRequired();
            //builder.Property(p => p.TipoAssunto)
            //     .HasColumnType("varchar(100)");

            //1 : 1 => Questao : Prova
            //builder.HasOne(f => f.ProvaId)
            //    .WithOne(f => f);

            //1 : N => Questao : Assunto
            //builder.HasMany(f => f.Assunto)
            //    .WithOne(p => p.Questao)
            //    .HasForeingKey(p => p.QuestaoId);


            //builder.ToTable("Questao");

        }
    }
}
