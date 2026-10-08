namespace SimpleQueue
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string FormaPagamento { get; set; }
        public float ValorTotal { get; set; }

        public Cliente(string nome, string formaPagamento, float valorTotal)
        {
            Nome = nome;
            FormaPagamento = formaPagamento;
            ValorTotal = valorTotal;
        }
    }
}