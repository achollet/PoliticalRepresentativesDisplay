using Base.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Base.DAL.Context
{
    public class GeographyContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Constituency> Constituencies { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<TownType> TownTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<District>().ToTable("District");
            modelBuilder.Entity<Constituency>().ToTable("Constituency");
            modelBuilder.Entity<Town>().ToTable("Town");
            modelBuilder.Entity<TownType>().ToTable("TownType");
        }
    }
}