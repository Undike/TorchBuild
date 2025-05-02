using TorchBuild.Models.Skills;

namespace TorchBuild.Models.Stats
{
    public class AttackDamageStats
    {
        public int AttackDPS { get; set; }
        public int PhysicalDamage { get; set; }
        public int FireDamage { get; set; }
        public int ColdDamage { get; set; }
        public int LightningDamage { get; set; }
        public int ErosionDamage { get; set; }
        public double CriticalChance { get; set; }
        public double CriticalMultiplier { get; set; }

    }
}
