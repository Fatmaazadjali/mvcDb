using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace webApp.Data
{
	public class ApplicationDbContext :DbContext 
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Todo>().Property(w => w.IsFineshed)
				.HasDefaultValue(false);
		}

		public DbSet<Todo> todos { get; set; }
    }
}
