using UnityEngine;

public class Armor_Boots : Item_Armor
{
    public void EquipArmor(ITaker_item player)
    {
        base.EquipArmor();
        player.EquipBoots(this);
    }
}
