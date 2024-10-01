using IdentityWithRazorPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityWithRazorPage.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<ApplicationUser>().ToTable("Users","Security");
			builder.Entity<IdentityRole>().ToTable("Roles", "Security");
			builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
			builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaهms", "Security");
			builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");
			builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Security");

		}
	}
}
