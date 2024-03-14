using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Contexts
{
    public class Db : DbContext
    {
        public DbSet<Game> Games{ get; set; }
        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }


        public Db(DbContextOptions options) : base(options)
        {
                
        }

    } 
}

