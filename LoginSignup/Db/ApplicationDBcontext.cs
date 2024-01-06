using LoginSignup.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSignup.Db
{
    // Defining the table in the database
    public class ApplicationDBcontext :DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext>options) : base(options)
        {
            
        }

        public DbSet<UserModel> userdetails { get; set; }
    }
}
