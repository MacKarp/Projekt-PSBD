using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class RodzajPaliwa
    {
        [Key]
        public int RodzajPaliwaID { get; set; }
        public string Paliwo { get; set; }
    }
}