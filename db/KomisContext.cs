using System.Data.Entity;

namespace Projekt_PSBD.db
{
    public class KomisContext : DbContext
    {
        public KomisContext() : base("Komis_Samochodowy_Janusz-DB")
        {
            Database.SetInitializer<KomisContext>(new KomisDbInitializer());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutoNaSprzedazConfigurations());
        }

        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<RokProdukcji> RokProdukcjis { get; set; }
        public DbSet<PojemnoscSilnika> PojemnoscSilnikas { get; set; }
        public DbSet<RodzajPaliwa> RodzajPaliwas { get; set; }
        public DbSet<RodzajNadwozia> RodzajNadwozias { get; set; }
        public DbSet<KolorNadwozia>KolorNadwozias { get; set; }
        //public DbSet<TypSkrzyniBiegow> TypSkrzyniBiegows { get; set; }
        public DbSet<AutoNaSprzedaz> AutoAutoNaSprzedazs { get; set; }
        public DbSet<Uzytkownik> Uzytkowniks { get; set; }
    }
}