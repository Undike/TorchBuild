using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.Talents
{
    public class God
    {
        public string Name { get; }
        public string MainStats { get; } //Временно! изменить!!!
        public TalentBranch BaseTalentBranch { get; private set; }
        public TalentBranch SecondTalentTree { get; private set; }
        public TalentBranch ThirdTalentTree  { get; private set; }
        public TalentBranch FourthTalentTree { get; private set; }

        public void SetTalentTree(TalentBranch baseTalentBranch, TalentBranch secondTalentTree, TalentBranch thirdTalentTree, TalentBranch fourthTalentTree)
        {
            if (baseTalentBranch.TreeSize != 18)
            {
                throw new ArgumentException($"Ошибка: Базовое древо должно содержать 7 тиров, но получено: {baseTalentBranch.TreeSize} тиров");
            }

            if (secondTalentTree.TreeSize != 24 || thirdTalentTree.TreeSize != 24 || fourthTalentTree.TreeSize != 24)
            {
                throw new ArgumentException($"Ошибка: Продвинутые ветки должны содержать 9 тиров, но получено: {secondTalentTree.TreeSize}, {thirdTalentTree.TreeSize}, {fourthTalentTree.TreeSize}");
            }
            BaseTalentBranch = baseTalentBranch;
            SecondTalentTree = secondTalentTree;
            ThirdTalentTree = thirdTalentTree;
            FourthTalentTree = fourthTalentTree;
        }
    }
}
