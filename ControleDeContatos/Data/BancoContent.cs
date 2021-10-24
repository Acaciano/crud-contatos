using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContent : DbContext
    {
        public BancoContent(DbContextOptions<BancoContent> options) :
            base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
