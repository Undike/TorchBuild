using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.StatusEffects
{
    public class PositiveStatusEffectsManager
    {
        private Dictionary<string, IPositiveStatusEffect> _activePositiveStatusEffects = new Dictionary<string, IPositiveStatusEffect>();

        public void AddPositiveStatus(IPositiveStatusEffect statusEffect)
        {
            if (!_activePositiveStatusEffects.ContainsKey(statusEffect.Name))
            {
                _activePositiveStatusEffects[statusEffect.Name] = statusEffect;
                statusEffect.ApplyEffect();
            }
            else
            {
             //TODO
            }
        }
        public void RemovePositiveStatus(string statusName)
        {
            if (_activePositiveStatusEffects.ContainsKey(statusName))
            {
                _activePositiveStatusEffects[statusName].RemoveEffect();
                _activePositiveStatusEffects.Remove(statusName);
            }
        }
        public void ShowPositiveStatuses()
        {
            //TODO
        }
    }
}
