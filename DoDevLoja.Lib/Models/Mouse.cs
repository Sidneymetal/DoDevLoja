namespace DoDevLoja.Lib.Models
{
    public class Mouse : Produto
    {
        public int DPI { get; set; }
        public Mouse(int dpi, bool semfio, int id, string nome, string marca,
        string descricao, double valor, int estoque) :
        base(id, nome, marca, descricao, valor, estoque)
        {
            SetDPI(dpi);
        }
        public int GetDPI()
        {
            return DPI;
        }
        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }
        public override double CalcularValor(double valor)
        {
            valor = valor + (DPI / 50);
            if (SemFio)
                return valor = valor * 1.15;
        }
    }
}