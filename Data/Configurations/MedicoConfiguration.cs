using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medicos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Documento)
                .IsRequired(true)
                .HasColumnType("VARCHAR(11)");

            builder.Property(x => x.Crm)
                .IsRequired(true)
                .HasColumnType("VARCHAR(8)");

            builder.Property(x => x.Celular)
                .IsRequired(true)
                .HasColumnType("VARCHAR(11)");

            builder.Property(x => x.EspecialidadeId)
                .IsRequired(true);

            builder.HasIndex(x => x.Documento)
                .IsUnique();

            builder.HasMany(x => x.Agendamentos)
                .WithOne(x => x.Medico)
                .HasForeignKey(x => x.MedicoId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
