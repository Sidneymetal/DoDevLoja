namespace DoDevLoja.Lib.Models
{
    public class Cliente : Usuario
    {
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Cliente(string cpf, string endereco, string nome, string email, 
        string senha) : base (nome, email, senha)
        {
            SetCPF(cpf);
            SetEndereco(endereco);
        }

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