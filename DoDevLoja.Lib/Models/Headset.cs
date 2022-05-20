namespace DoDevLoja.Lib.Models
{
    public class Headset : Produto
    {
        public bool SemFio { get; set; }
        public bool Surround { get; set; }

        public Headset(bool semfio, bool surround, int id, string nome, string marca,
        string descricao, double valor, int estoque) :
        base(id, nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semfio);
            SetSurround(surround);
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
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