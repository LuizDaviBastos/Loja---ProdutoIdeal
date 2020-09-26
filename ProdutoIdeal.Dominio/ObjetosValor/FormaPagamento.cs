using ProdutoIdeal.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoIdeal.Dominio.ObjetosValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto { get => (Id == (int) TipoPagamento.Boleto); }
        public bool EhCartaoCredito { get => (Id == (int)TipoPagamento.Cartao); }
        public bool EhDeposito { get => (Id == (int)TipoPagamento.Deposito); }
    }
}
