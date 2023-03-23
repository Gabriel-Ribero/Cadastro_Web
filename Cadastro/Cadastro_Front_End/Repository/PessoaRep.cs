using Cadastro.Data;
using Cadastro.Model;
using Cadastro.Repository.Interface;

namespace Cadastro.Repository
{
    public class PessoaRep : IPessoaRep
    {
        private readonly SistemaCadastroDBContext _dbContext;
        public  PessoaRep(SistemaCadastroDBContext sistemaCadastroDBContext)
        {
            _dbContext = sistemaCadastroDBContext;
        }

        public List<PessoaModel> GetAllPessoas()
        {
            return _dbContext.Pessoa.ToList();
        }

        public PessoaModel GetPessoa(int id)
        {
            return _dbContext.Pessoa.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(PessoaModel pessoa)
        {

            _dbContext.Pessoa.Add(pessoa);
            _dbContext.SaveChanges();
        }

        public void Update(PessoaModel pessoa, int id)
        {
            PessoaModel p = GetPessoa(id);

            if (p == null) 
            {
                throw new Exception($"Houve um erro ao tentar alterar o cadastro.");
            }

            p.Nome = pessoa.Nome;
            p.DataNascimento = pessoa.DataNascimento;
            p.ValorRenda = pessoa.ValorRenda;
            p.CPF = pessoa.CPF;

            _dbContext.Pessoa.Update(p);
            _dbContext.SaveChanges();
        }   

        public void Delete(int id)
        {
            PessoaModel p = GetPessoa(id);

            if (p == null)
            {
                throw new Exception($"Pessoa com o código {id} não foi encontrada!");
            }

            _dbContext.Pessoa.Remove(p);
            _dbContext.SaveChanges();
        }
    }
}
