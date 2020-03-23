using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class KolorNadwozia
    {
        [Key]
        public int KolorNadwoziaID { get; set; }
        public string Kolor { get; set; }
    }
}