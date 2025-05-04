using System;
using System.IO;
using System.Text.Json;
using TorchBuild.Models.Talents;

namespace TorchBuild.Models
{
    public class JsonLoader
    {
        public static God? LoadGod(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"Файл не найден: {filePath}");
            }

            string json = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true }; // Игнорируем регистр
            return JsonSerializer.Deserialize<God>(json, options);
        }
    }
}
