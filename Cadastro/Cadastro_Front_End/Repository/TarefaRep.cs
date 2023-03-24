using Cadastro.Data;
using Cadastro.Model;
using Cadastro_Front_End.Models;
using Cadastro_Front_End.Models.ViewModels;
using Cadastro_Front_End.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Front_End.Repository
{
    public class TarefaRep : ITarefaRep
    {
        private readonly SistemaCadastroDBContext _dbContext;
        public TarefaRep(SistemaCadastroDBContext sistemaCadastroDBContext)
        {
            _dbContext = sistemaCadastroDBContext;
        }

        public List<PessoaModel> GetAllPessoas()
        {
            return _dbContext.Pessoa.ToList();
        }

        public List<TarefaViewModel> GetAllTarefa()
        {
            List<TarefaViewModel> listFinal = new List<TarefaViewModel>();
            List<TarefaModel> listaTarefa = _dbContext.Tarefa.ToList();
            foreach (var item in listaTarefa)
            {
                var obj = new TarefaViewModel();
                obj.Id = item.Id;
                obj.NomeTarefa = item.NomeTarefa;
                obj.DataConclusao = item.DataConclusao;
                obj.Pessoa = _dbContext.Pessoa.Where(x => x.Id == item.IdPessoa).FirstOrDefault().Nome;
                listFinal.Add(obj);
            }
            return listFinal;
        }

        public TarefaModel GetTarefa(int id)
        {
            return _dbContext.Tarefa.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(TarefaModel tarefa)
        {
            _dbContext.Tarefa.Add(tarefa);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            TarefaModel t = GetTarefa(id);

            if (t == null)
            {
                throw new Exception($"Tarefa com o código {id} não foi encontrada!");
            }

            _dbContext.Tarefa.Remove(t);
            _dbContext.SaveChanges();
        }
    }
}
