using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoIdeal.Dominio.Entidades;
using System;

namespace ProdutoIdeal.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(p => p.Valor)
                .IsRequired();
        }
    }
}
