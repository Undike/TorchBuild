namespace TorchBuild.Models.Stats
{
    public class StatModifier
    {
        public AttributeModifierType AttributeModifier { get; }
        public double Value { get; }

        public StatModifier(AttributeModifierType attributeModifier, double value)
        {
            AttributeModifier = attributeModifier;
            Value = value;
        }
    }
}
