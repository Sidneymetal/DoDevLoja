namespace DoDevLoja.Lib.Models
{
    public class Headset : Produto
    {
        public bool Surround { get; set; }

        public Headset(bool semfio, bool surround, int id, string nome, string marca,
        string descricao, double valor, int estoque, bool semfio) :
        base(id, nome, marca, descricao, valor, estoque, semfio)
        {
            SetSurround(surround);
        }
        public bool GetSurround()
        {
            return Surround;
        }
        public void SetSurround(bool surround)
        {
            Surround = surround;
        }
        public override double CalcularValor(double valor)
        {
            if (Surround && SemFio)
            {
                valor = valor + 500;
            }
            else if (Surround || SemFio)
                valor = valor + 150;
            return valor;
        }
    }
}