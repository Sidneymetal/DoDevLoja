namespace DoDevLoja.Lib.Models
{
    public class Pedido
    {
        public Usuario Usuario { get; set; }
        public Produto ListProdutos { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
    }
}