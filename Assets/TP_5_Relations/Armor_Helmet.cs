using UnityEngine;

public class Armor_Helmet : Item_Armor, ITakable_item
{
    public void EquipArmor(ITaker_item player)
    {
        base.EquipArmor();
        player.EquipHelmet(this);
    }
}
