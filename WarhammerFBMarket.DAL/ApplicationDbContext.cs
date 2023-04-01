using Microsoft.EntityFrameworkCore;
using WarhammerFBMarket.Domain.Models;

namespace WarhammerFBMarket.DAL
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
		public DbSet<Miniature> Miniature { get; set; }
	}
}
