using Cadastro.Model;
using Cadastro_Front_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class SistemaCadastroDBContext : DbContext
    {
        public SistemaCadastroDBContext(DbContextOptions<SistemaCadastroDBContext> options) : base(options) 
        {}

        /* Espelho da Tabela no Sql Server*/
        public DbSet<PessoaModel> Pessoa { get; set; }

        public DbSet<TarefaModel> Tarefa { get; set; }

    }
}
