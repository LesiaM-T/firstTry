using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DBRepository
{
   		public class RepositoryContext : DbContext
		{
			public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
			{

			}

			public DbSet<User> UsersPosts { get; set; }
			public DbSet<Task> Tasks { get; set; }
			public DbSet<Column> Columns	{ get; set; }
		
		}
	}

