using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API
{
	public class MyDBContext : DbContext
	{


        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
		{

		}

        public DbSet<Models.User> User { get; set; }



    }
}

