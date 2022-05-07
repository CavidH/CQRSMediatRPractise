// Cavid Haciyev
// 2022/05/07   20:06

using CQRSMediatRPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRPractise.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, HP = 1.5, Name = "Lada", Weight = 1.5 },
                new Car { Id = 2, HP = 2.5, Name = "nissan", Weight = 2.5 },
                new Car { Id = 3, HP = 3.5, Name = "toyota", Weight = 3.5 },
                new Car { Id = 4, HP = 4.5, Name = "ford", Weight = 4.5 }
                );
        }

        public DbSet<Car> Cars { get; set; }



    }
}