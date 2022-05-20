namespace DoDevLoja.Lib.Models
{
    public class Mouse : Produto
    {
        public int DPI { get; set; }
        public bool SemFio { get; set; }

        public Mouse(int dpi, bool semfio, int id, string nome, string marca,
        string descricao, double valor, int estoque) :
        base(id, nome, marca, descricao, valor, estoque)
        {
            SetDPI(dpi);
            SetSemFio(semfio);
        }

        public int GetDPI()
        {
            return DPI;
        }
        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
    }
}