using Microsoft.EntityFrameworkCore;
using ORM_Trainer_1.Models;

namespace ORM_Trainer_1.DBProvider
{
    public class MssqlContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Buraya kendi bağlantı adresiniz sınıfınız girilecek.
            optionsBuilder.UseSqlServer("Server=DESKTOP-UIFM5O9\\SQLEXPRESS;database=ProjectManagement;integrated security=true;");
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
