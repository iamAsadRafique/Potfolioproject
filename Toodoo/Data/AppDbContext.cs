using Microsoft.EntityFrameworkCore;
using portfolio005.Models;

namespace portfolio005.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<About> tbl_About { get; set; }
        public DbSet<Contact> tbl_Contact { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Facts> tbl_Facts{ get; set; }
        public DbSet<Service> tbl_Service { get; set; }
        public DbSet<Skill> tbl_Skill { get; set; }
        public DbSet<Social> tbl_Social { get; set; }
        public DbSet<Testimonial> tbl_Testimonial { get; set; }



    }
}
