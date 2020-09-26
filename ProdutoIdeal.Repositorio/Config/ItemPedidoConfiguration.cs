using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoIdeal.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoIdeal.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            
        }
    }
}
