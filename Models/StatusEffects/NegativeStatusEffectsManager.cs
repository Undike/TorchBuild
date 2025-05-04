using TorchBuild.Models.Interfaces;

namespace TorchBuild.Models.StatusEffects
{
    public class NegativeStatusEffectsManager
    {
        private Dictionary<string, INegativeStatusEffect> _activeNegativeStatusEffects = new Dictionary<string, INegativeStatusEffect>();

        public void AddPositiveStatus(INegativeStatusEffect statusEffect)
        {
            if (!_activeNegativeStatusEffects.ContainsKey(statusEffect.Name))
            {
                _activeNegativeStatusEffects[statusEffect.Name] = statusEffect;
                statusEffect.ApplyEffect();
            }
            else
            {
                //TODO
            }
        }
        public void RemovePositiveStatus(string statusName)
        {
            if (_activeNegativeStatusEffects.ContainsKey(statusName))
            {
                _activeNegativeStatusEffects[statusName].RemoveEffect();
                _activeNegativeStatusEffects.Remove(statusName);
            }
        }
        public void ShowNegativeStatuses()
        {
            //TODO
        }
    }
}

