using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class TypSkrzyniBiegow
    {
        [Key]
        public int TypSkrzyniBiegowID { get; set; }
        public string SkrzyniaBiegow { get; set; }
    }
}