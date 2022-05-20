namespace DoDevLoja.Lib.Models
{
    public class Headset : Produto
    {
        public bool SemFio { get; set; }
        public bool Surround { get; set; }

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
    }
}