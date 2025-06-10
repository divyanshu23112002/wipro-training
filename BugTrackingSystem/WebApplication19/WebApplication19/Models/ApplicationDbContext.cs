using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication19.Models;

namespace WebApplication19.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
    }
}