using Cadastro.Model;

namespace Cadastro.Repository.Interface
{
    public interface IPessoaRep
    {
        List<PessoaModel> GetAllPessoas();
        PessoaModel GetPessoa(int id);
        void Insert(PessoaModel pessoa);
        void Update(PessoaModel pessoa, int id);
        void Delete(int id);
    }
}
