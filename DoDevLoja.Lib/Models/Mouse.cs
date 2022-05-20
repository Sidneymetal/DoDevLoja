namespace DoDevLoja.Lib.Models
{
    public class Mouse : Produto
    {
        public int DPI { get; set; }
        public bool SemFio { get; set; }

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