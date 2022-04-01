using FFXIVMacroGenerator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.IO;

namespace FFXIVMacroGenerator.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<MACRO_URL_M> MACRO_URL_M { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RemovePluralizingTableNameConvention(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(AppContext.BaseDirectory, @"Database\MacroDB.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
            base.OnConfiguring(optionsBuilder);
        }

        public static void RemovePluralizingTableNameConvention(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entity.GetDefaultTableName();
                entity.SetTableName(tableName);
            }
        }
    }
}
