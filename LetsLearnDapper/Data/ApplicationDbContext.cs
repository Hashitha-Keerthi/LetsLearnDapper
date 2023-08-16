
using LetsLearnDapper.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsLearnDapper.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
        
        }

        public DbSet<Company> Companies { get; set; }  

       
    }
}
