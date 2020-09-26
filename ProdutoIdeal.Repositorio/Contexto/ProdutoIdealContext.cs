using Microsoft.EntityFrameworkCore;
using ProdutoIdeal.Dominio.Entidades;
using ProdutoIdeal.Dominio.ObjetosValor;
using ProdutoIdeal.Repositorio.Config;


namespace ProdutoIdeal.Repositorio.Contexto
{
    public class ProdutoIdealContext : DbContext
    {
        public ProdutoIdealContext(DbContextOptions options) : base (options) { }


        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() 
                {
                    Id = 1,
                    Nome = "Cartao",
                    Descricao = "Cartao"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Boleto",
                    Descricao = "Boleto"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Depósito"
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
