using System.Data.Entity.ModelConfiguration;

namespace Projekt_PSBD
{
    public class TowarConfigurations : EntityTypeConfiguration<Towar>
    {
        public TowarConfigurations()
        {
            this.Property(s => s.NazwaTowaru)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.NazwaTowaru)
                .IsConcurrencyToken();

            // Configure a one-to-one relationship between Towar & StudentAddress
            //this.HasOptional(s => s.Address) // Mark Towar.Address property optional (nullable)
            //    .WithRequired(ad => ad.Towar); // Mark StudentAddress.Towar property as required (NotNull).
        }
    }
}