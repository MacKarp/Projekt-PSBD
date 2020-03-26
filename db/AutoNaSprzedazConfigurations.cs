using System.Data.Entity.ModelConfiguration;

namespace Projekt_PSBD.db
{
    public class AutoNaSprzedazConfigurations : EntityTypeConfiguration<AutoNaSprzedaz>
    {
        public AutoNaSprzedazConfigurations()
        {
            this.HasRequired(s => s.Marka);
            this.HasRequired(s => s.Model);
            this.HasRequired(s => s.RokProdukcji);
            this.HasRequired(s => s.PojemnoscSilnika);
            this.HasRequired(s => s.RodzajPaliwa);
            this.Property(s => s.Przebieg).IsRequired();
            this.Property(s => s.Moc).IsRequired();
            this.HasRequired(s => s.RodzajNadwozia);
            this.Property(s => s.IloscMiejs).IsRequired();
            this.HasRequired(s => s.KolorNadwozia);
            this.HasRequired(s => s.TypSkrzyniBiegow);
            this.Property(s => s.Opis).IsRequired();
            this.Property(s => s.Cena).IsRequired();
        }
    }
}