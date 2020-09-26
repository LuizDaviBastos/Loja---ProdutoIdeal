using System;
using System.Collections.Generic;

namespace ProdutoIdeal.Dominio.Contratos
{
    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Excluir(int id);
        TEntity BuscarPeloId(int id);
        IEnumerable<TEntity> BuscarTodos();
    }
}
