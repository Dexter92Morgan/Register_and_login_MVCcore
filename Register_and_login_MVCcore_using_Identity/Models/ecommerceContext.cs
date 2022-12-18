using Microsoft.EntityFrameworkCore;

namespace Register_and_login_MVCcore_using_Identity.Models
{
    public class ecommerceContext : DbContext
    {

        public ecommerceContext(DbContextOptions<ecommerceContext> options) : base(options)
        {

        }

        public virtual DbSet<Userdetails> Userdetails { get; set; }
    }
}
