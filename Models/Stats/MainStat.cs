namespace TorchBuild.Models.Stats
{
    public class MainStat
    {
        int Strength { get; set; } = 0;
        int Dexterity { get; set; } = 0;
        int Intelligence { get; set; } = 0;

        public MainStat(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
