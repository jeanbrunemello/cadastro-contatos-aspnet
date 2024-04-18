using Microsoft.EntityFrameworkCore;
using cadastro_contatos_aspnet.Models;

namespace cadastro_contatos_aspnet.Data
{
    public class BancoContext : DbContext
    {
      public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
