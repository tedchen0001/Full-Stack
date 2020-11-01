using Admin_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DI.Data
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> opt) : base(opt)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}