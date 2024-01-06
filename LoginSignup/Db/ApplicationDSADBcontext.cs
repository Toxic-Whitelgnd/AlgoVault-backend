using LoginSignup.Models;
using Microsoft.EntityFrameworkCore;


namespace LoginSignup.Db
{
    public class ApplicationDSADBcontext : DbContext
    {
        // DbSet with dynamic table name
        public DbSet<DSAmodel> DSATables { get; set; }

        public ApplicationDSADBcontext(DbContextOptions<ApplicationDSADBcontext> options) : base(options)
        {
            
        }


    }
}
