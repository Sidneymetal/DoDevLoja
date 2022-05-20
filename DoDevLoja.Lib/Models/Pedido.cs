namespace DoDevLoja.Lib.Models
{
    public class Pedido
    {
        public Usuario Usuario { get; set; }
        public Produto ListaProduto { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }

        public Usuario GetUsuario()
        {
            return Usuario;
        }
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
        public Produto GetListaProduto()
        {
            return ListaProduto;
        }
        public void SetListaProduto(Produto listaproduto)
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
        public void AdicionarProduto()
        {

        }
        public void RemoverProdutu()
        {

        }
        public void FinalizarPedido()
        {
            
        }
    }
}