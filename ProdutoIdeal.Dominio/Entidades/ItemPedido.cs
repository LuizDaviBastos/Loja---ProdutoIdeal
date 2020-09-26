using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoIdeal.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0) AdicionarCritica("Não foi possível achar um produto nesse pedido");
            if (Quantidade <= 0) AdicionarCritica("Numero de quantidade inválido");
        }
    }
}
