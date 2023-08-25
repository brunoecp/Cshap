using DBConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace DBConnection.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Alunos> alunos { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {

        }
    }
}
