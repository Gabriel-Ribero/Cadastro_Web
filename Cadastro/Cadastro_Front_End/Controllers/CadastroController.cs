using Cadastro.Model;
using Cadastro.Repository;
using Cadastro.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Front_End.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IPessoaRep _pessoaRep;

        public CadastroController(IPessoaRep pessoaRep)
        {
            _pessoaRep = pessoaRep;
        }


        /* Página de listagem dos cadastros */
        public IActionResult Index()
        {
            List<PessoaModel> listPessoas = _pessoaRep.GetAllPessoas();
            return View(listPessoas);
        }

        /* Página de Inclusão de cadastro */
        public IActionResult Criar()
        {
            return View();
        }


        /* Página de Alteração do cadastro */
        public IActionResult Alterar(int id)
        {
            PessoaModel pessoa = _pessoaRep.GetPessoa(id);
            return View(pessoa);
        }


        /* Página de exclusão do cadastro */
        public IActionResult Excluir(int id)
        {
            PessoaModel pessoa = _pessoaRep.GetPessoa(id);
            return View(pessoa);
        }



        [HttpPost]
        public IActionResult Insert(PessoaModel pessoa)
        {
            _pessoaRep.Insert(pessoa);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(PessoaModel pessoa, int id)
        {
            _pessoaRep.Update(pessoa, id);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _pessoaRep.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
