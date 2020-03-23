using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Projekt_PSBD
{
    public class KomisDbInitializer : CreateDatabaseIfNotExists<KomisContext>
    {
        protected override void Seed(KomisContext context)
        {
            base.Seed(context);
        }
    }
}


