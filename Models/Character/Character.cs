using TorchBuild.Models.Skills;
using TorchBuild.Models.Stats;
namespace TorchBuild.Models.Character
{
    public class Character
    {
        public BaseStats Base { get; } = new BaseStats();
        public DefenseStats Defense { get; } = new DefenseStats();
        public SurvivabilityStats Survivability { get; } = new SurvivabilityStats();

        public int Energy => Base.Energy; // 🔹 Количество доступных слотов для `SupportSkills`

        public List<ActiveSkillSlot> ActiveSkillSlots { get; } = new List<ActiveSkillSlot>
        {
            new ActiveSkillSlot(0), new ActiveSkillSlot(1), new ActiveSkillSlot(2), new ActiveSkillSlot(3), new ActiveSkillSlot(4)
        };

        public List<PassiveSkillSlot> PassiveSkillSlots { get; } = new List<PassiveSkillSlot>
        {
            new PassiveSkillSlot(0), new PassiveSkillSlot(1), new PassiveSkillSlot(2), new PassiveSkillSlot(3), new PassiveSkillSlot(4)
        };

        public ActiveSkillSlot GetMainActiveSkillSlot() => ActiveSkillSlots[0];

        public bool EquipSupportSkill(int slotIndex, Skill supportSkill, bool isActiveSkill)
        {
            if (isActiveSkill)
                return ActiveSkillSlots[slotIndex].AddSupportSkill(supportSkill, Energy);
            else
                return PassiveSkillSlots[slotIndex].AddSupportSkill(supportSkill, Energy);
        }
    }
}
