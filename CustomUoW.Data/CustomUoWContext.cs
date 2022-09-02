using Microsoft.EntityFrameworkCore;
using System;

namespace CustomUoW.Data
{
    public class CustomUoWContext : DbContext
    {
        public CustomUoWContext(DbContextOptions<CustomUoWContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomUoWContext).Assembly);
        }
    }
}