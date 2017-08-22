using Microsoft.EntityFrameworkCore;
using Base.DAL.Entities;

namespace Base.DAL.Context
{
    public class PoliticalFormationContext : DbContext
    {
        public DbSet<PoliticalParty> PoliticalFormations { get; set; }
        public DbSet<PartyType> FormationTypes { get; set; }
        public DbSet<Politician> Politicians { get; set; }
        public DbSet<Affiliation> Affiliations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoliticalParty>().ToTable("PoliticalFormation");
            modelBuilder.Entity<PartyType>().ToTable("FormationType");
            modelBuilder.Entity<Politician>().ToTable("Politician");
            modelBuilder.Entity<Affiliation>().ToTable("Affiliation");
        }
    }
}