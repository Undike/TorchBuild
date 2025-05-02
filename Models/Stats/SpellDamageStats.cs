using TorchBuild.Models.Skills;

namespace TorchBuild.Models.Stats
{
    public class SpellDamageStats
    {
        public int SpellDPS { get; set; }
        public int FireSpellDamage { get; set; }
        public int ColdSpellDamage { get; set; }
        public int LightningSpellDamage { get; set; }
        public int ErosionSpellDamage { get; set; }
        public int DoTDPS { get; set; }
        public double SpellPenetration { get; set; }

    }
}
