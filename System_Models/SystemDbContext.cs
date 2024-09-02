using Microsoft.EntityFrameworkCore;
using System;

namespace System_Models
{
    public class SystemDbContext: DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
    
}
