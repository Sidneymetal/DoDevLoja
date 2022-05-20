namespace DoDevLoja.Lib.Models
{
    public class Teclado : Produto
    {
        public bool SemFio { get; set; }
        public bool Mecanico { get; set; }

        public Teclado(bool semfio, bool mecanico, string nome, string marca,
        string descricao, double valor, int estoque) :
        base(nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semfio);
            SetMecanico(mecanico);
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
        public bool GetMecanico()
        {
            return Mecanico;
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
    }
}