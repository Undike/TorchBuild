namespace TorchBuild.Models.Skills
{
    public abstract class Skill
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public List<string> SkillTags { get; set; }
    }
}
