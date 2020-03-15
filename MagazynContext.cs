using System.Data.Entity;

namespace Projekt_PSBD
{
    public class MagazynContext : DbContext
    {
        public MagazynContext() : base("MagazynTowarow-DB")
        {
            Database.SetInitializer<MagazynContext>(new MagazynDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Towar from separate class
            modelBuilder.Configurations.Add(new TowarConfigurations());
        }

        public DbSet<Towar> Towary { get; set; }
        public DbSet<Producent> Producenci { get; set; }
    }
}