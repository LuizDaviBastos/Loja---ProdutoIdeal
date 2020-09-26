using ProdutoIdeal.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProdutoIdeal.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CEP)) AdicionarCritica("Campo CEP obrigatório");
            if (ItensPedidos.Any() == false) AdicionarCritica("É necessário pelo menos um item");


        }
    }
}

