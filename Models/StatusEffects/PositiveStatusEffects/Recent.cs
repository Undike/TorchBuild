using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.StatusEffects.PositiveStatusEffects
{
    public class Recent : IPositiveStatusEffect
    {
        public string Name { get; } = "Recent";
        public string Description { get; } = "Recent";
        public bool IsActive { get; private set; } = false;
        public int Duration { get; } = 4;
        public int Stacks { get; } = 1;

        public void ApplyEffect()
        {
            if (!IsActive)
            {
                IsActive = true;
            }
            else
            {
                //TODO: добавить логику работы Multistrike
            }
        }

        public void RemoveEffect()
        {
            if (IsActive)
            {
                IsActive = false;
            }
        }
    }
}
