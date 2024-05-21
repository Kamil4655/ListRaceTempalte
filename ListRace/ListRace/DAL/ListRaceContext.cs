using ListRace.Models;
using Microsoft.EntityFrameworkCore;

namespace ListRace.DAL
{
    public class ListRaceContext : DbContext
    {
        public ListRaceContext(DbContextOptions<ListRaceContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
