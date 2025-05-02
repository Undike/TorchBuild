using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorchBuild.Models.Character
{
    public class SurvivabilityStats
    {
        public int MaxMana { get; set; }
        public int MaxEnergyShield { get; set; }
        public float ManaRestorationPerSecond { get; set; }
        public float LifeRegainInterval { get; set; }
        public float EnergyShieldRegainInterval { get; set; }
    }
}
