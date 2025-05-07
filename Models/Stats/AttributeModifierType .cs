namespace TorchBuild.Models.Stats
{
    public enum AttributeModifierType
    {
        //Icrease DAMAGE
        IncreaseDamage,
        IncreaseAttackDamage,
        IncreaseAttackDamageWhenHoldingTwoHandedWeapon,
        IncreasePhysicalDamage,
        IncreaseElementalDamage,

        // Spell
        IncreaseSpellDamage,
        IncreaseCastSpeedPerStackOfAgilityBlessing,
        IncreaseCastSpeedPerDexterity,
        IncreaseChanceToTriggerMainSpellSkillAdditionalTimeWhenUsingIt,

        //Fire
        IncreaseFireDamage,
        IncreaseFirePenetration,
        IncreaseMinionFirePenetration,
        IncreaseMinionFireDamage,
        IncreaseIgniteDamage,
        IncreaseIgnateChance,
        IncreaseIgnatechanceForMinions,
        IncreaseFireDamageAgainstLowLifeEnemies,
        IncreaseMinionFireDamageAgainstLowLifeEnemies,
        IncreaseFireDamageOverTime,
        AddFlatBaseIgniteDamage,
        InflictAdditionalStackOfIgnite,
        IncreaseFireDamagePerStrength,
        //Convert To Fire Damage
        ConvertPhysicalDamageToFireDamage,
        ConvertMinionPhysicalDamageToFireDamage,

        //Cold
        IncreaseColdDamage,

        //Lightning
        IncreaseLightningDamage,
        IncreaseMinionLightningDamage,
        IncreaseNumbedChance,
        IncreaseNumbedChanceForMinions,
        IncreaseNumbedEffect,
        InflictAdditionalNumbedStack,
        IncreaseLightningPenetration,
        IncreaseMinionLightningPenetration,
        IncreaseLightningPenetrationOnCriticalStrike,
        ReduceMaxLifeAndEnergyShieldThresholdForInflictingNumbedOnSupremeBosses,
        //Convert To Lightning Damage
        ConvertPhysicalDamageToLightning,
        ConvertMinionPhysicalDamageToLightningDamage,

        //Erosion
        IncreaseErosionDamage,

        //Projectile
        IncreaseProjectileDamage,
        IncreaseProjectileSpeed,
        IncreaseMinionProjectileSpeed,
        IncreaseProjectileCriticalStrikeDamage,
        IncreaseProjectileDamageWithDistance,
        IncreaseProjectileDamageAgainstEnemiesInProximity, // Against Nearby Enemies
        IncreaseParabolicProjectileSplits,
        IncreaseHorizontalProjectilePenetrations,

        //Increase Addition Damage
        IncreaseAdditionalMaxDamage,
        IncreaseAdditionalMinionMaxDamage,
        IncreaseAdditionBaseDamageForTwoHandedWeapons,
        IncreaseAdditionalAttackDamageForEachUniqueTypeOfWeaponEquippedWhileDualWielding,
        IncreaseAdditionalMainHandWeaponDamageWhileHoldingAShield,
        IncreaseAdditionalDamageAppliedToLife,
        IncreaseAdditionalAttackDamageAgainstFullLifeEnemies,
        IncreaseAdditionalBaseDamageForTwoHandedWeapons,
        IncreaseAdditionFireDamageDealtByTheNextMainSkillEvery1s,
        IncreaseAdditionAttackDamageIfYouHaveUsedAWarcrySkillInTheLast8s,
        IncreaseDamageIfDefeatedEnemyRecently,
        IncreaseAdditionalDamageAfterMobilitySkill,

        //Increase Critical 
        IncreaseCriticalStrikeDamage,
        IncreaseMinionCriticalStrikeDamage,
        IncreaseCriticalStrikeRating,
        IncreaseMinionCriticalStrikeRating,
        IncreaseAttackCriticalStrikeRating,
        IncreaseRangedAttackCriticalStrikeRating, //проверить!
        IncreaseCriticalStrikeDamageToMeleeAttacks,
        IncreaseAttackCriticalStrikeRatingWhenHoldingTwoHandedWeapon,
        IncreaseCriticalStrikeChanceForEachSpellSkillUsedRecently,
        IncreaseCriticalChance,

        //Increase speed
        IncreaseAttackSpeed,
        IncreaseMinionAttackSpeed,
        IncreaseAttackSpeedAndCastSpeed,
        IncreaseMinionAttackSpeedAndCastSpeed,
        IncreaseAttackSpeedWhileDualWielding,
        IncreaseAttackSpeedWhileHoldingAShield,
        IncreaseCastSpeed,

        //Increase Additional Attack speed
        IncreaseAdditionalRangedTwoHandedWeaponBaseAttackSpeed,
        IncreaseAdditionalAttackSpeedOnCriticalStrikeRecent,

        //Movement
        IncreaseMovementSpeed,
        IncreaseMovementSpeedWhenHoldingAShield,
        ApplyMovementSpeedBonusToCooldownRecoverySpeedForMovementSkills,
        ApplyMovementSpeedBonusToAttackAndCastSpeedForMovementSkills,

        //Cooldown
        IncreaseCooldownRecoverySpeedForMobilitySkills,

        //Increase Area 
        IncreaseSkillArea,
        IncreaseAreaDamage,
        IncreaseFireSkillArea,
        IncreaseWarcrySkillArea,
        IncreaseSkillAreaIfMainSkillIsNotUsedInTheLast2s,


        // Increase Survivability
        //  Armor
        IncreaseArmor,
        AddFlatArmor,
        IncreaseChanceToGainDoubleArmor,
        IncreaseDefenceGainedFromChestArmor,
        IncreaseDefence,
        IncreaseArmorPerStackOfTenacityBlessing,
        //  Evasion
        IncreaseEvasion,
        AddFlatEvasion,
        IncreaseEvasionWhileMoving,
        IncreaseEvasionFromChestArmor,
        IncreaseEvasionPerAgilityBlessingStack,
        // Avoid 
        IncreaseChanceToAvoidDamage,
        IncreaseChanceToAvoidProjectileDamage,
        IncreaseChanceToAvoidMeleeDamage,

        // Life 
        IncreaseMaxLife,
        IncreaseLifeRegain,
        IncreaseLifeRegenerationSpeed,
        IncreaseRegeneratesLifePerSecond,
        AddFlatLife,
        RestoreMissingLife,
        DecreaseAdditionalLifeRegainInterval,
        RestoreLifeWhenReceivingAgilityBlessing,
        RestoreMissingLifeWhenSufferSevereInjury,
        RegainsAdditionalLifeBasedOnMissingEnergyShield,
        RegainsAdditionalEnergyShieldRegainBasedOnMissingLife,


        // Increase Enerygy Shield
        IncreaseMaxEnergyShield,
        IncreaseEnergyShieldRegain,
        RestoreMissingEnergyShield,
        DecreaseAdditionalEnergyShieldRegainInterval,
        RestoreMissingEnergyShieldWhenSufferSevereInjury,

        // Increase Mana
        IncreaseMaxMana,
        RegenerateManaPerSecond,
        RestoreManaWhenReceivingAgilityBlessing,

        // Increase Block
        IncreaseAttackBlockChance,
        IncreaseBlockRatioWhenHoldingTwoHandedWeapon,

        // Increase Resistances
        IncreaseFireResistance, // заменить везде на AddFireResistance
        AddColdResistance,
        AddLightningResistance,

        // MainStats
        // Strength
        IncreaseStrength,
        AddFlatStrength,
        // Dexterity
        IncreaseDexterity,
        AddFlatDexterity,
        // Intelligence

        // Increase Cost
        IncreaseSkillCost,

        // Decrease
        DecreaseAttackSkillCost,
        DecreaseSkillCost,
        DecreasePhysycalDamageTaken,
        DecreaseAdditionalElementalDamageTaken,
        DecreaseAttackSpeed,
        DecreaseAdditionalIgniteDamageTaken,
        DecreaseIgniteEffectReceived,
        DecreaseSpellDamage,
        DecreaseRegainInterval,

        // Tenacity
        IncreaseMaxTenacityBlessingStacks,
        IncreaseTenacityBlessingDuration,
        IncreaseElementalResistanceWhileTenacityBlessingIsActive,
        IncreaseChanceToGainOneStacksOfTenacityBlessingWhenTakingDamageInterval1s,
        IncreaseLifeRegenerationSpeedPerStackOfTenacityBlessingOwned,
        IncreaseFlatLifeRegenerationPerSecondPerStackOfTenacityBlessingOwned,

        // Agility Blessing
        IncreaseChanceToGainAgilityBlessingOnEvasionInterval1s,
        IncreaseAgilityBlessingDuration,
        IncreaseAttackSpeedWhileAgilityBlessingIsActive,
        IncreaseMaxAgilityBlessingStacks,
        IncreaseChanceToGainAgilityBlessingOnUseSpellSkill,

        // Paralysis
        IncreaseInflictedParalysisEffectWhenHoldingTwoHandedWeapon,

        WarcryCooldownRecoverySpeed,
        IncreaseMinimumNumberOfEnemiesAffectedByWarcry,

        IncreaseAttackSkillLevel,

        // Increase PerStat
        IncreaseArmorPerStrength,
        IncreaseElementalResistancePerArmor,
        IncreaseErosionResistancePerArmor,

        // Knockback
        IncreaseChanceToCauseKnockbackOnCriticalStrike,

        // Jumps for Projectile/Chain Skills
        IncreaseJumps,

        // Multistrike
        IncreaseMultistrikeDamage,
        IncreaseMinionMultistrikeDamage,
        IncreaseChanseToMultistrike,
        IncreaseMinionChanseToMultistrike,
        IncreaseAdditionalAttackSpeedOnMultistrike,
        IncreaseAdditionalMinionAttackSpeedOnMultistrike,

        // Injury 
        IncreaseInjuryBaffer,

        // Affliction
        IncreaseAfflictionEffect,
        IncreaseMinionAfflictionEffect,
        IncreaseFlatAfflictionInflictedPerSecond,
        IncreaseMinionFlatAfflictionInflictedPerSecond,

        // Other
        ConsumesLifeOnAttackSkillUse,
        DamageTakenBypassesEnergyShield,

        // Minios
        MinionsAreImmuneToFireDamage,
        MinionImmunityToLightningDamage,

        // Negative Effects
        IncreaseAdditionalMeleeDamageTaken,
        IncreaseAdditionalProjectileDamageTaken,
    }

}
