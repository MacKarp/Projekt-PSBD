using System.Collections.Generic;
using System.Data.Entity;

namespace Projekt_PSBD
{
    public class MagazynDbInitializer : DropCreateDatabaseAlways<MagazynContext>
    {
        protected override void Seed(MagazynContext context)
        {

            base.Seed(context);
        }
    }
}