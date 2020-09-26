using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoIdeal.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoIdeal.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            
        }
    }
}
