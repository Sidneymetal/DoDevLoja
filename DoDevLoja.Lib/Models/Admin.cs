namespace DoDevLoja.Lib.Models
{
    public class Admin : Usuario
    {
        public string CNPJ { get; set; }
        public string GetCNPJ()
        {
            return CNPJ;
        }
        public void SetCNPJ(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}
