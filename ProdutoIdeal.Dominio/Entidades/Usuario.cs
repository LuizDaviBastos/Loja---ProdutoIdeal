using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoIdeal.Dominio.Entidades
{
   public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

       /* public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome)) AdicionarCritica("O Nome é obrigatório");
            if (string.IsNullOrEmpty(Email)) AdicionarCritica("Email Nome é obrigatório");
            if (string.IsNullOrEmpty(Senha)) AdicionarCritica("Senha Nome é obrigatório");
        }*/
    }
}
