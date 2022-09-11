using ApiLucasFlix.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLucasFlix.Data
{
    public class FilmeContext : DbContext
    {

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }//

        public DbSet<Filme> Filmes { get; set; }
    }
}
