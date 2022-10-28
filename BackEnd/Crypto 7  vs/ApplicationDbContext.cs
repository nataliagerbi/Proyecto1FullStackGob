using Crypto_7__vs.Models;
using Microsoft.EntityFrameworkCore;

namespace Crypto_7__vs
{
    public class ApplicationDbContext:DbContext

    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        

    }
}
