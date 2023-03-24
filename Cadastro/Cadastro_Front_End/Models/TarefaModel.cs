using Cadastro.Model;

namespace Cadastro_Front_End.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string NomeTarefa { get; set; }
        public DateTime DataConclusao { get; set; }
        public int IdPessoa { get; set; }

    }
}
