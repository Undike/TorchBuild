using System.IO;
using System.Text.Json;
using TorchBuild.Models.Skills;

namespace TorchBuild.Models.Skills
{
    public static class SkillLoader
    {
        public static ActiveSkill LoadActiveSkill(string fileName)
        {
            string path = Path.Combine("Skills", $"{fileName}.json");
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл {fileName}.json не найден!");
            }

            string json = File.ReadAllText(path);
            var skill = JsonSerializer.Deserialize<ActiveSkill>(json);

            return skill ?? throw new InvalidDataException($"Ошибка загрузки {fileName}.json!");
        }
    }
}
