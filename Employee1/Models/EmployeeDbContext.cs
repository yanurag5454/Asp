using System;
using Microsoft.EntityFrameworkCore;
namespace Employee1.Models
{
	public class EmployeeDbContext:DbContext
	{
		public EmployeeDbContext(DbContextOptions options) : base(options)
        {

		}
		public DbSet<Employee> Employees { get; set; }

	}
}

