using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace bugtracker.Data
{
	public class TempDb
	{
		public Microsoft.EntityFrameworkCore.DbContextOptionsBuilder getString(DbContextOptionsBuilder optionsBuilder)
		{
			return optionsBuilder.UseSqlServer("Server=localhost; Database=BugData; User Id=sa; Password=Test123;");
		}
	}
}
