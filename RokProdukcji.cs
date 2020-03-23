using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class RokProdukcji
    {
        [Key]
        public int RokProdukcjiID { get; set; }
        public int Rok { get; set; }
    }
}