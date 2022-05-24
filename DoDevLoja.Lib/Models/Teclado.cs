namespace DoDevLoja.Lib.Models
{
    public class Teclado : Produto
    {        
        public bool Mecanico { get; set; }

        public Teclado(bool semfio, bool mecanico, int id, string nome, string marca,
        string descricao, double valor, int estoque) :
        base(id, nome, marca, descricao, valor, estoque)
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
        public override double CalcularValor(double valor)
        {
            if (Mecanico)
                valor = valor + 200;
            if (SemFio) 
                valor = valor * 1.15;
        }
    }
}