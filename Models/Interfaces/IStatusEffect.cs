namespace TorchBuild.Models.Interfaces
{
    public interface IStatusEffect
    {
        string Name { get; }
        string Description { get; }
        bool IsActive { get; }
        int Duration { get; }
        int Stacks { get; }
        void ApplyEffect();
        void RemoveEffect();
    }

    public interface IPositiveStatusEffect : IStatusEffect
    {
    }

    public interface INegativeStatusEffect : IStatusEffect
    {
    }
}
