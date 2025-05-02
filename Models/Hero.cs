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
        public string ImagePath { get; set; }
        public int HeroPassiveSkillSlots { get; set; }
        public List<HeroSkillSlot> UniqueHeroPassiveSkills { get; set; }

    }

    public class HeroSkillSlot
    {
        public int Slot { get; set; }
        public List<string> HeroPassiveSkillChoices { get; set; }
        public int HeroPassiveSkillSlotCount { get; set; }
    }
}
