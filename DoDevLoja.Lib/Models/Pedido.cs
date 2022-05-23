namespace DoDevLoja.Lib.Models
{
    public class Pedido
    {
        public Usuario Usuario { get; set; }
        public List <Produto> ListaProduto { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }

        public Pedido(Usuario usuario, double valortotal, string status, DateTime data)
        {
            SetUsuario = (usuario);
            SetValorTotal = (valortotal);
            SetStatus = (status);
            SetData = (data);
            ListaProduto = new List<Produto>();
        }

        public Usuario GetUsuario()
        {
            return Usuario;
        }
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
        public List <Produto> GetListaProduto()
        {
            return ListaProduto;
        }
        public void SetListaProduto(List <Produto> listaproduto)
        {
            ListaProduto = listaproduto;
        }
        public double GetValorTotal()
        {
            return ValorTotal;
        }
        public void SetValorTotal(double valortotal)
        {
            ValorTotal = valortotal;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public DateTime GetData()
        {
            return Data;
        }
        public void SetData(DateTime data)
        {
            Data =  data;
        }
        public void AdicionarProduto(Produto novoproduto)
        {           
           ListaProduto.Add(novoproduto);
        }
        public void RemoverProduto(Produto removeproduto)
        {
            ListaProduto.Remove(removeproduto);
        }
        public double FinalizarPedido()
        {
            var pedidoFinal = 0.0;
            foreach (Produto produto in Produto)
            {
                pedidoFinal = pedidoFinal + produto.GetValor();
            }
            Status = "Pedido Finalizado.";
            return ValorTotal = pedidoFinal;
        }
    }
}