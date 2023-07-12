using Microsoft.EntityFrameworkCore;

namespace InspimoSignalRApi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NMRQQJ1\\SQLEXPRESS;initial catalog=DbSignalR;integrated security=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
