using TorchBuild.Models.Interfaces;
using TorchBuild.Models.Stats;
namespace TorchBuild.Models.Character
{
    public class Character
    {
        public BaseStats Base { get; } = new BaseStats();
        public DefenseStats Defense { get; } = new DefenseStats();
        public SurvivabilityStats Survivability { get; } = new SurvivabilityStats();

        public List<ActiveSkillSlot> ActiveSkillSlots { get; } = new List<ActiveSkillSlot>
        {
            new ActiveSkillSlot(0), new ActiveSkillSlot(1), new ActiveSkillSlot(2), new ActiveSkillSlot(3), new ActiveSkillSlot(4)
        };

        public List<PassiveSkillSlot> PassiveSkillSlots { get; } = new List<PassiveSkillSlot>
        {
            new PassiveSkillSlot(0), new PassiveSkillSlot(1), new PassiveSkillSlot(2), new PassiveSkillSlot(3), new PassiveSkillSlot(4)
        };

        public List<IPositiveStatusEffect> PositiveStatusEffects { get; } = new List<IPositiveStatusEffect>();
        public List<INegativeStatusEffect> NegativeStatusEffects { get; } = new List<INegativeStatusEffect>();
    }
}

