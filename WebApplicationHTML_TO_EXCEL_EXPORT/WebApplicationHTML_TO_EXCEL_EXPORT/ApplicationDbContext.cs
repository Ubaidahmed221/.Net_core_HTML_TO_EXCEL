using Microsoft.EntityFrameworkCore;
using WebApplicationHTML_TO_EXCEL_EXPORT.Entities;

namespace WebApplicationHTML_TO_EXCEL_EXPORT
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasData(new List<Person>
                {
                    new Person {ID = 1, Name = "kamal",Email = "kamal@gmail.com", PhoneNO = "03123454546" },
                    new Person {ID = 2, Name = "Nofile",Email = "Nofile@gmail.com", PhoneNO = "03126785643" },
                    new Person {ID = 3, Name = "Ashir",Email = "Ashir@gmail.com", PhoneNO = "03123456785" },
                    new Person {ID = 4, Name = "jawad",Email = "jawad@gmail.com", PhoneNO = "03123489754" },
                    new Person {ID = 5, Name = "jawaid",Email = "jawaid@gmail.com", PhoneNO = "031575367906" },
                });
        }

        public DbSet<Person> People { get; set; }

    }
}
