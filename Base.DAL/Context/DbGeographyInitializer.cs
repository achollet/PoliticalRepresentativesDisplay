using System.Linq;
using Base.DAL.Entities;

namespace Base.DAL.Context
{
    public static class DbGeographyInitializer
    {        
        public static void Initialize(GeographyContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Countries.Any())
            {
                var countries = new Country[]{
                    new Country{ CodeIso2 = "FR", CodeIso3 = "FRA", Name ="France"}
                };
                context.SaveChanges();
            }

            if (!context.Regions.Any())
            {
                context.SaveChanges();
            }

            if (!context.Departments.Any())
            {
                context.SaveChanges();
            }

            if (!context.Districts.Any())
            {
                context.SaveChanges();
            }

            if (!context.Towns.Any())
            {
                context.SaveChanges();
            }
        }
    }
}