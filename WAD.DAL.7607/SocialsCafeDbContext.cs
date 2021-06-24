using Microsoft.EntityFrameworkCore;
using System;
using WAD.DAL._7607.DBO;

namespace WAD.DAL._7607
{
    public class SocialsCafeDbContext : DbContext
    {
        public SocialsCafeDbContext(DbContextOptions<SocialsCafeDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Cafe> Cafe { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Department> Department { get; set; }

    }
}
