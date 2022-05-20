namespace DoDevLoja.Lib.Models
{
    public class Clliente : Usuario
    {
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}