namespace TorchBuild.Models.Stats
{
    public enum AttributeModifierType
    {
        IncreaseDamage,
        IncreaseAttackDamage,
        IncreasePhysicalDamage,
        IncreaseSpellDamage,
        IncreaseElementalDamage,
        IncreaseFireDamage,
        IncreaseColdDamage,
        IncreaseLightningDamage,
        IncreaseErosionDamage,
        IncreaseCriticalStrikeDamage,
        IncreaseCriticalChance,
        IncreaseAttackCriticalStrikeRating,
        IncreaseRangedAttackCriticalStrikeRating,
        IncreaseCriticalStrikeDamageToMeleeAttacks,
        IncreaseAttackSpeed,
        IncreaseCastSpeed,

        IncreaseFireSkillArea,
        IncreaseSkillArea,

        IncreaseIgniteDamage,
        IncreaseIgnateChance,
        IncreaseProjectileSpeed,

        IncreaseArmor,
        IncreaseMaxLife,
        IncreaseLifeRegain,
        IncreaseMaxMana,

        IncreaseFireResistance,


        IncreaseStrength,

        IncreaseMovementSpeed,

        DecreaseAttackSkillCost,

        ConvertPhysicalDamageToFireDamage,

        AdditionFireDamageDealtByTheNextMainSkillEvery1s,
        AdditionAttackDamageIfYouHaveUsedAWarcrySkillInTheLast8s,

        WarcryCooldownRecoverySpeed,

        IncreaseAttackSkillLevel,

    }

}
