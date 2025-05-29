using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication13.Models;

namespace WebApplication13.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Add your DbSets here
        public DbSet<Employee> Employees { get; set; }
    }
}