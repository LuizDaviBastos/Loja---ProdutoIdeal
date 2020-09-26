using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Dominio.Entidades;
using ProdutoIdeal.Repositorio.Contexto;

namespace ProdutoIdeal.Repositorio.Repositorios
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProdutoIdealContext ProdutoIdealContext) : base(ProdutoIdealContext)
        {
        }
    }
}
