namespace TorchBuild.Models.Interfaces
{
    public interface ISkillTag
    {
        string TagName { get; }
    }

    public interface IMobility : ISkillTag { }
    public interface IAttack : ISkillTag { }
    public interface IMelee : ISkillTag { }
    public interface IPhysical : ISkillTag { }
    public interface IDemolisher : ISkillTag { }
    public interface IArea : ISkillTag { }

    public interface IStrength : ISkillTag { }
    public interface ICold : ISkillTag { }
    public interface IProjectile : ISkillTag { }
    public interface IRanged : ISkillTag { }
    public interface IHorizontal : ISkillTag { }
    public interface IDexterity : ISkillTag { }
    public interface IFire : ISkillTag { }
    public interface ISpell : ISkillTag { }
    public interface IErosion : ISkillTag { }
    public interface ILightning : ISkillTag { }
    public interface IIntelligence : ISkillTag { }

    public interface IWarcry : ISkillTag { }
    public interface IPersistent : ISkillTag { }
    public interface IRestoration : ISkillTag { }
    public interface IChanneled : ISkillTag { }
    public interface ISlashStrike : ISkillTag { }
    public interface IDefensive : ISkillTag { }
    public interface IChain : ISkillTag { }
    public interface IParabolic : ISkillTag { }
    public interface ITerra : ISkillTag { }
    public interface IVertical : ISkillTag { }
    public interface IEmpower : ISkillTag { }

    public interface IBarrage : ISkillTag { }
    public interface IShadowStrike : ISkillTag { }
    public interface ISentry : ISkillTag { }
    public interface IBeam : ISkillTag { }
    public interface ISummon : ISkillTag { }
    public interface ISynthetic : ISkillTag { }
    public interface ITroop : ISkillTag { }
    public interface ICurse : ISkillTag { }

    public interface IBaseSkill : ISkillTag { }
    public interface IEnhancedSkill : ISkillTag { }
    public interface IUltimate : ISkillTag { }
    public interface ISupport : ISkillTag { }      
    public interface IImbue : ISkillTag { }       
    public interface IAura : ISkillTag { }   
    public interface ISpiritMagus : ISkillTag { } 
}
