namespace TorchBuild.Models.Stats
{
    public class StatModifier
    {
        public StatType Type { get; }
        public double Value { get; } // ✅ Значение бонуса (например, 0.09 для +9%)

        public StatModifier(StatType type, double value)
        {
            Type = type;
            Value = value;
        }
    }
}
