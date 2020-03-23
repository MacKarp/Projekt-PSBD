using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class RodzajNadwozia
    {
        [Key]
        public int RodzajNadwoziaID { get; set; }
        public string Nadwozie { get; set; }
    }
}