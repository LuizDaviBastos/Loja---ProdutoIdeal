using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Dominio.Entidades;
using ProdutoIdeal.Repositorio.Contexto;

namespace ProdutoIdeal.Repositorio.Repositorios
{
    public class PedidoRepositorio : Repositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(ProdutoIdealContext ProdutoIdealContext) : base(ProdutoIdealContext)
        {
        }
    }
}
