using Cadastro.Model;
using Cadastro_Front_End.Models;
using Cadastro_Front_End.Models.ViewModels;

namespace Cadastro_Front_End.Repository.Interface
{
    public interface ITarefaRep
    {
        List<TarefaViewModel> GetAllTarefa();
        List<PessoaModel> GetAllPessoas();
        TarefaModel GetTarefa(int id);
        void Insert(TarefaModel pessoa);
        void Delete(int id);
    }
}
