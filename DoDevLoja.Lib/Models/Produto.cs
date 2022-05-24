namespace DoDevLoja.Lib.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public bool SemFio { get; set; }

        public Produto(int id, string nome, string marca, string descricao, double valor, int estoque, bool semfio)
        {
            SetID(id);
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetValor(CalcularValor(valor));
            SetEstoque(estoque);
            SetSemFio(semfio);
        }

        public int GetID()
        {
            return ID;
        }
        public void SetID(int id)
        {
            ID = id;
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public int GetEstoque()
        {
            return Estoque;
        }
        public void SetEstoque(int estoque)
        {
            Estoque = estoque;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
        public void AdicionarProduto(int estoque)
        {
            Estoque = Estoque + estoque;
        }
        public void RemoverProduto(int estoque)
        {
            Estoque = Estoque - estoque;
        }
        public virtual double CalcularValor(double valor)
        {
            return Valor;
        }
    }
}