using UnityEngine;

public class Armor_Chest : Item_Armor
{
    public void EquipArmor(ITaker_item player)
    {
        base.EquipArmor();
        player.EquipChest(this);
    }
}
