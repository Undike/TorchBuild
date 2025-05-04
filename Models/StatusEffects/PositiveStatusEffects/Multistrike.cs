using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.StatusEffects.PositiveStatusEffects
{
    public class Multistrike : IPositiveStatusEffect
    {
        public string Name { get; } = "Multistrike";
        public string Description { get; } = "Multistrike";
        public int Duration { get; } = -1;
        public bool IsActive { get; private set; } = false;
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
