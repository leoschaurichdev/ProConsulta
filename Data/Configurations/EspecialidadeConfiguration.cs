using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class EspecialidadeConfiguration : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidades");

            builder.HasKey(e => e.Id);

            builder.Property(x=>x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnType("VARCHAR(150)");

            builder.HasMany(x => x.Medicos)
                .WithOne(x => x.Especialidade)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
