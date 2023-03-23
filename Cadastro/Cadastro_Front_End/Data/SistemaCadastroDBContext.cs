using Cadastro.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class SistemaCadastroDBContext : DbContext
    {
        public SistemaCadastroDBContext(DbContextOptions<SistemaCadastroDBContext> options) : base(options) 
        {}

        /* Espelho da Tabela no Sql Server*/
        public DbSet<PessoaModel> Pessoa { get; set; }

    }
}
