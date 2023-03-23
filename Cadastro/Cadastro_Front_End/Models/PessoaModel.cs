namespace Cadastro.Model
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal ValorRenda { get; set; }
        public string CPF { get; set; }
    }
}
