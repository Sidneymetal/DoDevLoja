namespace DoDevLoja.Lib.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetSenha()
        {
            return Senha;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }   
}