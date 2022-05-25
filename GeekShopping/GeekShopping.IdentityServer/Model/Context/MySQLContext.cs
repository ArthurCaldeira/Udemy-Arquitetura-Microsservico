using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
	public class MySQLContext : IdentityDbContext
	{
		public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

	}
}
