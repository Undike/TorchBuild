using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.Talents
{
    public class TalentBranch
    {
        public string Name { get; }
        public int TreeSize { get; } 
        public string[] Tags { get; } 
        public List<Talent> Talents { get; } = new List<Talent>();
        public Talent? FirstCoreTalent { get; private set; } //  Первый Core Talent (12 или 16 очков)
        public Talent? SecondCoreTalent { get; private set; } //  Второй Core Talent (24 или 32 очков)

        private Talent[] FirstCoreTalentOptions = new Talent[3]; 
        private Talent[] SecondCoreTalentOptions = new Talent[3];
        public TalentBranch(string name, int treeSize, string[] tags)
        {
            Name = name;
            TreeSize = treeSize;
            Tags = tags;

            int firstCoreLevel = (TreeSize == 7) ? 12 : 16;
            int secondCoreLevel = (TreeSize == 7) ? 24 : 32;

            FirstCoreTalentOptions = CoreTalentRegistry.GetCoreTalents(Name, firstCoreLevel);
            SecondCoreTalentOptions = CoreTalentRegistry.GetCoreTalents(Name, secondCoreLevel);
        }

        public void AddTalent(Talent talent)    
        {
            Talents.Add(talent);
        }

        public void SelectCoreTalent(int requiredPoints, Talent selectedTalent)
        {
            if (FirstCoreTalentOptions.Contains(selectedTalent) && requiredPoints >= (TreeSize == 7 ? 12 : 16))
            {
                FirstCoreTalent = selectedTalent;
            }
            else if (SecondCoreTalentOptions.Contains(selectedTalent) && requiredPoints >= (TreeSize == 7 ? 24 : 32))
            {
                SecondCoreTalent = selectedTalent;
            }
            else
            {
                throw new ArgumentException($"Ошибка: Выбранный Core Talent не доступен для данного уровня вложенных очков.");
            }
        }

        public List<Talent> GetAvailableTalents(int spentPoints)
        {
            return Talents.Where(t => spentPoints >= t.Tier).ToList();
        }
    }
}
