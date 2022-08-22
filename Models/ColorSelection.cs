using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class ColorSelection
    {
        [Key]
        public int PlayerId { get; set; }
         public string PlayerColor1 { get; set; }
         public string PlayerColor2 { get; set; }

         public string PlayerColor3 { get; set; }

         public string PlayerColor4 { get; set; }
        public int CorrectColorCorrectPosition { get; set; }
        public int CorrectColorWrongPosition { get; set; }

    }
}
