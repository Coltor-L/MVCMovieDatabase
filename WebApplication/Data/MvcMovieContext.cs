using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class MvcMovieContext : DbContext
    {

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Movie> Movie { get; set; }
        
        
    }
}