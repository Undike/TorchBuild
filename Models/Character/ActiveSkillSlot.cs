using TorchBuild.Models.Skills;
using TorchBuild.Models.Stats;

namespace TorchBuild.Models.Character
{
    public class ActiveSkillSlot
    {
        public int SlotIndex { get; }
        public Skill ActiveSkill { get; private set; }
        public List<Skill> SupportSkills { get; private set; } = new List<Skill>();
        public AttackDamageStats AttackStats { get; private set; }
        public SpellDamageStats SpellStats { get; private set; }

        public ActiveSkillSlot(int index)
        {
            SlotIndex = index;
            AttackStats = new AttackDamageStats();
            SpellStats = new SpellDamageStats();
        }

        public void SetActiveSkill(Skill skill)
        {
            ActiveSkill = skill;

            //if (skill.SkillTags.Contains("Attack"))
            //    AttackStats.CalculateAttackDamage(skill);
            //else if (skill.SkillTags.Contains("Spell"))
            //    SpellStats.CalculateSpellDamage(skill);
            // to do
        }

        public bool AddSupportSkill(Skill supportSkill, int maxSlots)
        {
            if (SupportSkills.Count < maxSlots)
            {
                SupportSkills.Add(supportSkill);
                return true;
            }
            return false;
        }
    }
}
