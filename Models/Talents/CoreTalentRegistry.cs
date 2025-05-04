using System.Collections.Generic;
using System.Linq;

namespace TorchBuild.Models.Talents
{
    public class CoreTalentRegistry
    {
        private static Dictionary<string, Dictionary<int, Talent[]>> CoreTalentPool = new Dictionary<string, Dictionary<int, Talent[]>>();

        public static void AddCoreTalent(string branchName, int unlockLevel, Talent[] talents)
        {
            if (!CoreTalentPool.ContainsKey(branchName))
            {
                CoreTalentPool[branchName] = new Dictionary<int, Talent[]>();
            }

            if (talents.Length != 3)
                throw new ArgumentException($"Ошибка: Для уровня {unlockLevel} в {branchName} должно быть ровно 3 Core Talents!");

            CoreTalentPool[branchName][unlockLevel] = talents;
        }

        public static Talent[] GetCoreTalents(string branchName, int unlockLevel)
        {
            if (CoreTalentPool.ContainsKey(branchName) && CoreTalentPool[branchName].ContainsKey(unlockLevel))
            {
                return CoreTalentPool[branchName][unlockLevel];
            }

            return new Talent[0]; // Если `Core Talents` для данного уровня не найдены
        }
    }
}
