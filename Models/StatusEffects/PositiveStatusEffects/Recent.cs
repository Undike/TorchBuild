using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.StatusEffects.PositiveStatusEffects
{
    public class Recent : IPositiveStatusEffect
    {
        public string Name { get; } = "Recent";
        public string Description { get; } = "Recent";
        public int Duration { get; } = 4;
        public int Stacks { get; } = 1;
        public void ApplyEffect()
        {
            //TO DO
        }
        public void RemoveEffect()
        {
            //TO DO
        }
    }
}
