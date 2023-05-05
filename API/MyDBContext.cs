using System;
using API.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API
{
    public class MyDBContext : DbContext
    {

        //static readonly string connectionString = "Server=localhost; User ID=remoteuser; Password=1234; Database=db_myeshop";

        public DbSet<Models.User> User { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }*/

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
		{

		}
    }
}

