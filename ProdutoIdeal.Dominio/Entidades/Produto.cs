namespace ProdutoIdeal.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

       /* public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome)) AdicionarCritica("Nome não pode ser nulo");
        }*/
    }
}
