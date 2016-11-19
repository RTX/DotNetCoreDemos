using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(string connString) : base()
        {
            //Program.Config.GetSection()
        }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
       
        
    }
}