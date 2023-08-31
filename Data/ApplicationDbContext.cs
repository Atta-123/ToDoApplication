

using ToDoApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoApplication.Data
{
	public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{

		}
		
		public DbSet<Todo> todos { get; set; }
	}
}
