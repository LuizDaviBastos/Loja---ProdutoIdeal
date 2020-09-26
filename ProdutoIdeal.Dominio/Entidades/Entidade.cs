using System.Collections.Generic;
using System.Linq;

namespace ProdutoIdeal.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao = new List<string>();

        protected List<string> mensagemValidacao
        {
            get => (mensagemValidacao ?? (_mensagemValidacao));
        }

        protected void LimparMensagemValidacao() => mensagemValidacao.Clear();

        protected void AdicionarCritica(string msg) => mensagemValidacao.Add(msg);

        public abstract void Validate();

        public bool IsValid { get => (!mensagemValidacao.Any()); }

    }
}
