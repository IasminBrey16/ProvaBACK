using ProvaBACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaBACK.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}