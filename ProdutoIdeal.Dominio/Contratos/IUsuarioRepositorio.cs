using ProdutoIdeal.Dominio.Entidades;

namespace ProdutoIdeal.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
