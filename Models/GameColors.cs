using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    public class GameColors
    {
        [Key]
        public int GameId { get; set; }
        public string GameColor1 { get; set; }
        public string GameColor2 { get; set; }
        public string GameColor3 { get; set; }
        public string GameColor4 { get; set; }

      

    }
}
