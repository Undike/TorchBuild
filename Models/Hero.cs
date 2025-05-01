namespace TorchBuild.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public List<SubClass> SubClasses { get; set; }
      
    }

    public class SubClass
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int HeroSkillSlots { get; set; }
        public List<SkillSlot> UniqueSkills { get; set; }

    }

    public class SkillSlot
    {
        public int Slot { get; set; }
        public List<string> HeroSkillChoices { get; set; }
        public int PassiveSkillSlotCount { get; set; }
    }
}
