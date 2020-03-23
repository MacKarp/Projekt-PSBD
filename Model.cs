using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        public string NazwaModel { get; set; }
    }
}