using TorchBuild.Models.Item;

public class Equipment
{
    public Item Helmet { get; set; }
    public Item Armor { get; set; }
    public Item Gloves { get; set; }
    public Item Boots { get; set; }
    public Item Amulet { get; set; }
    public Item Belt { get; set; }
    public Item Ring1 { get; set; }
    public Item Ring2 { get; set; }

    public Item WeaponMain { get; set; } // Основное оружие
    public Item WeaponOff { get; set; } // Вторая рука (оружие или щит)

    public void Equip(Item item)
    {
        switch (item.Type)
        {
            case ItemType.Helmet: Helmet = item; break;
            case ItemType.Armor: Armor = item; break;
            case ItemType.Gloves: Gloves = item; break;
            case ItemType.Boots: Boots = item; break;
            case ItemType.Amulet: Amulet = item; break;
            case ItemType.Belt: Belt = item; break;
            case ItemType.Ring:
                if (Ring1 == null) Ring1 = item;
                else if (Ring2 == null) Ring2 = item;
                break;
            case ItemType.TwoHandedWeapon:
                WeaponMain = item;
                WeaponOff = item; // 🔹 Двуручное оружие занимает оба слота
                break;
            case ItemType.OneHandedWeapon:
                if (WeaponMain == null)
                {
                    WeaponMain = item;
                }
                else if (WeaponOff == null)
                {
                    WeaponOff = item; // 🔹 Позволяем экипировать второе одноручное оружие
                }
                break;
            case ItemType.Shield:
                if (WeaponOff == null)
                {
                    WeaponOff = item; // 🔹 Щит можно взять только в левую руку
                }
                break;
        }
    }

    public void Unequip(ItemType type)
    {
        switch (type)
        {
            case ItemType.Helmet: Helmet = null; break;
            case ItemType.Armor: Armor = null; break;
            case ItemType.Gloves: Gloves = null; break;
            case ItemType.Boots: Boots = null; break;
            case ItemType.Amulet: Amulet = null; break;
            case ItemType.Belt: Belt = null; break;
            case ItemType.Ring: Ring1 = null; Ring2 = null; break;
            case ItemType.TwoHandedWeapon: WeaponMain = null; WeaponOff = null; break;
            case ItemType.OneHandedWeapon:
                if (WeaponMain != null) WeaponMain = null;
                else if (WeaponOff != null) WeaponOff = null;
                break;
            case ItemType.Shield: WeaponOff = null; break;
        }
    }
}