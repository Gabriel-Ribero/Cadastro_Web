using Cadastro.Model;
using Cadastro_Front_End.Models;
using Cadastro_Front_End.Models.ViewModels;
using Cadastro_Front_End.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Front_End.Controllers
{
    public class TarefaController : Controller
    {

        private readonly ITarefaRep _tarefaRep;

        public TarefaController(ITarefaRep tarefaRep)
        {
            _tarefaRep = tarefaRep;
        }



        /* Home de tarefas */
        public IActionResult Index()
        {
            List<TarefaViewModel> listTarefa = _tarefaRep.GetAllTarefa();
            return View(listTarefa);
        }


        /* Página de Inclusão de tarefa */
        public IActionResult Criar()
        {
            ViewBag.Pessoas = _tarefaRep.GetAllPessoas();
            return View();
        }


        /* Página de exclusão do tarefa */
        public IActionResult Excluir(int id)
        {
            TarefaModel tarefa = _tarefaRep.GetTarefa(id);
            return View(tarefa);
        }



        [HttpPost]
        public IActionResult Insert(TarefaModel tarefa)
        {
            _tarefaRep.Insert(tarefa);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _tarefaRep.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
