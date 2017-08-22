using Microsoft.EntityFrameworkCore;
using Base.DAL.Entities;

namespace Base.DAL.Context
{
    public class ElectionContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Election> Elections { get; set; }
        public DbSet<ElectionType> ElectionTypes { get; set; }
        public DbSet<ElectionResult> ElectionResults { get; set; }
        public DbSet<Candidature> Candidatures { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<TermType> TermTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Election>().ToTable("Election");
            modelBuilder.Entity<ElectionType>().ToTable("ElectionType");
            modelBuilder.Entity<ElectionResult>().ToTable("ElectionResult");
            modelBuilder.Entity<Candidature>().ToTable("Candidature");
            modelBuilder.Entity<Term>().ToTable("Term");
            modelBuilder.Entity<TermType>().ToTable("TermType");        
        }
    }
}