using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Dominio.Entidades;
using ProdutoIdeal.Repositorio.Contexto;
using System.Linq;

namespace ProdutoIdeal.Repositorio.Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProdutoIdealContext produtoIdealContext) : base(produtoIdealContext)
        {

        }

        public Usuario Obter(string email, string senha)
        {
            return Entity.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
