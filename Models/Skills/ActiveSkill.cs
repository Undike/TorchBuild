using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorchBuild.Models.Skills
{
    public abstract class ActiveSkill : Skill
    {
        public Dictionary<int, Dictionary<string, string>> BuffEffects { get; set; } = new();
        // to do
    }
}
