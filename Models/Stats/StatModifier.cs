namespace TorchBuild.Models.Stats
{
    public class StatModifier
    {
        public AttributeModifierType AttributeModifier { get; }
        public double? Value { get; }
        public int? ForEach { get; }
        public double? MaxValue { get; }
        public double? Duration { get; }
        public int? MaxStack { get; }
        public double? IntervalInSeconds { get; }

        public StatModifier(
            AttributeModifierType attributeModifier, 
            double? value = null, 
            int? forEach = null, 
            double? maxValue = null, 
            double? duration = null, 
            int? maxStack = null, 
            double? intervalInSeconds = null)
        {
            AttributeModifier = attributeModifier;
            Value = value;
            ForEach = forEach;
            MaxValue = maxValue;
            Duration = duration;
            MaxStack = maxStack;
            IntervalInSeconds = intervalInSeconds;
        }
    }
}
