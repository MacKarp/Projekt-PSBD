using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class Marka
    {
        [Key]
        public int MarkaID { get; set; }
        public string NazwaMarka { get; set; }
    }
}