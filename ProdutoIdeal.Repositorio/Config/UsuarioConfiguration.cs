using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoIdeal.Dominio.Entidades;

namespace ProdutoIdeal.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasMaxLength(400)
                .IsRequired();

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(40);

            builder.HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
