using System.Data.Entity;

namespace Projekt_PSBD.db
{

    public class KomisDbInitializer : CreateDatabaseIfNotExists<KomisContext>
    {

        protected override void Seed(KomisContext context)
        {
            base.Seed(context);
        }
    }
}



