﻿using Microsoft.EntityFrameworkCore;

namespace Notatnik.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //    .HasMany(b => b.Notes)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.ClientCascade);
        //}

    }
}
