using Microsoft.EntityFrameworkCore;
using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace ProdutoIdeal.Repositorio.Repositorios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        private ProdutoIdealContext _produtoIdealContext;
        protected DbSet<TEntity> Entity;

        public Repositorio(ProdutoIdealContext ProdutoIdealContext)
        {
            Entity = ProdutoIdealContext.Set<TEntity>();
            _produtoIdealContext = ProdutoIdealContext;
        }


        public void Adicionar(TEntity entity)
        {
            Entity.Add(entity);
            _produtoIdealContext.SaveChanges();
        }

        public TEntity BuscarPeloId(int id)
        {
            return Entity.Find(id);
        }

        public void Excluir(int id)
        {
            TEntity _entity = BuscarPeloId(id);
            if (_entity != null) Entity.Remove(_entity);
            _produtoIdealContext.SaveChanges();
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return Entity.ToList();
        }

        public void Dispose()
        {
            _produtoIdealContext.Dispose();
        }


    }
}
