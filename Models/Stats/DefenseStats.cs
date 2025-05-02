using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorchBuild.Models.Stats
{
    public class DefenseStats
    {
        public int Armor { get; set; }
        public int Evasion { get; set; }
        public float MaxBlockChance { get; set; }
        public float DamageBlockRatio { get; set; }
    }
}
