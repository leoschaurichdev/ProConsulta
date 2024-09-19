using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Pacientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(p => p.Documento)
                .IsRequired(true)
                .HasColumnType("VARCHAR(11)");

            builder.Property(p => p.Email)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(p => p.Celular)
                .IsRequired(true)
                .HasColumnType("VARCHAR(11)");

            builder.HasIndex(p => p.Documento)
                .IsUnique(true);

            builder.HasMany(p => p.Agendamentos)
                .WithOne(a => a.Paciente)
                .HasForeignKey(a => a.PacienteId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
