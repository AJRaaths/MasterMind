using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterMind.ViewModels
{
    public class GameViewModel
    {
        public ColorSelection ColorSelection { get; set; }
        public GameColors GameColors { get; set; }
    }
}
