namespace TorchBuild.Models.Item
{
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public Dictionary<string, int> Stats { get; set; } = new();

        public Item(string name, ItemType type)
        {
            Name = name;
            Type = type;
        }
    }
}
