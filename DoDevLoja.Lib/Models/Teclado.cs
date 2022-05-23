namespace DoDevLoja.Lib.Models
{
    public class Teclado : Produto
    {        
        public bool Mecanico { get; set; }

        public Teclado(bool semfio, bool mecanico, int id, string nome, string marca,
        string descricao, double valor, int estoque, bool semfio) :
        base(id, nome, marca, descricao, valor, estoque, semfio)
        {            
            SetMecanico(mecanico);
        }        
        public bool GetMecanico()
        {
            return Mecanico;
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
        public double CalcularValor()
        {
            
        }
    }
}