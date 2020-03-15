using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_PSBD
{
    public class Kraj
    {
        //[ForeignKey(Magazyn)]
        //[ForeignKey(Towar)]
        //[ForeignKey(Producent)]
        public int KrajID { get; set; }
        public string NazwaKraju { get; set; }

        public string SciezkaDoFlagi { get; set; }
    }
}