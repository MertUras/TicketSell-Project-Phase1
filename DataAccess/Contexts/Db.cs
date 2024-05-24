using System;
using DataAccess.Entities;
using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Contexts
{
	public class Db:DbContext
	{
        protected readonly IConfiguration Configuration;

        public Db(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<RoleModel> Ticket { get; set; }
        
    }
}

