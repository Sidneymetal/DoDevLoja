namespace DoDevLoja.Lib.Models
{
    public class Headset : Produto
    {     
        public bool Surround { get; set; }

        public Headset(bool semfio, bool surround, int id, string nome, string marca,
        string descricao, double valor, int estoque, bool semfio) :
        base(id, nome, marca, descricao, valor, estoque, semfio)
        {
            SetSemFio(semfio);
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
        public double CalcularValor()
        {

        }
    }
}