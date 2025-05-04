using TorchBuild.Models.Stats;

namespace TorchBuild.Models.Talents
{
    public enum TalentType
    {
        Minor,
        Medium,
        LegendaryMedium
    }

    public class Talent
    {
        public string Name { get; }
        public TalentType Type { get; }
        public int MaxPoints { get; }
        public int CurrentPoints { get; private set; } = 0;
        public int Tier { get; }
        public Talent? PrerequisiteTalent { get; }

        public List<StatModifier> StatModifiers { get; } = new List<StatModifier>();

        public Talent(string name, TalentType type, int maxPoints, int tier, Talent? prerequisiteTalent = null, List<StatModifier>? statModifiers = null)
        {
            Name = name;
            Type = type;
            MaxPoints = maxPoints;
            Tier = tier;
            PrerequisiteTalent = prerequisiteTalent;

            if (StatModifiers != null)
                StatModifiers = statModifiers;
        }

        public bool CanUnlockTalent()
        {
            return PrerequisiteTalent == null || PrerequisiteTalent.CurrentPoints >= PrerequisiteTalent.MaxPoints;
        }

        public void InvestPoints(int points)
        {
            //TODO
        }
    }
}
