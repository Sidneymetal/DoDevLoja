namespace DoDevLoja.Lib.Models
{
    public class Admin : Usuario
    {
        public string CNPJ { get; set; }

        public Admin(string cnpj, string nome, string email, string senha) 
        : base (nome, email, senha)
        {
            SetCNPJ(cnpj);
        }
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
