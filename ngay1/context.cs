// YourDbContext.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }

    public DbSet<Department> Departments { get; set; }
}
