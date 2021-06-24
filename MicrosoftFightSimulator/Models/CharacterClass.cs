using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftFightSimulator.Models
{
    public class CharacterClass
    {
        public short Armor { get; set; }
        public short HitBonus { get; set; }
        public short Damage { get; set; }
        public string Ability { get; set; }

    }
}
